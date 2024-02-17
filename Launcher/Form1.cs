using System.IO;
using System.Diagnostics;
using System.Net;
using System.Linq.Expressions;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Principal;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Launcher
{
    public partial class SurvLauncher : Form
    {
        public SurvLauncher()
        {
            InitializeComponent();
        }

        private string launcher_ver = "Release v2.0.0";
        private bool API_ONLINE = false;
        public System.Timers.Timer PingTimer = new System.Timers.Timer(3000);

        //directory something like C://Users/User/PathToLauncher.exe/game
        private string gameDir = System.IO.Directory.GetCurrentDirectory() + "/game";
        private string currDir = System.IO.Directory.GetCurrentDirectory();
        State CurrentState;
        private enum State
        {
            INIT,
            CHECK_FILES,
            EXTRACTING,
            UPDATE_AVAILABLE,
            INSTALLING,
            CAN_PLAY,
            UNINSTALL,
            FAILED //Unused and can be removed
        }


        void UpdateState(State NewState)
        {
            CurrentState = NewState;
            switch (NewState)
            {
                //MAKE SURE FUNCTION CALLS ARE ALWAYS LAST
                case State.INIT:
                    label1.Text = "SurvLauncher " + launcher_ver;
                    StateButton.Enabled = false;
                    StateButton.Text = "Initializing...";
                    progressBar1.Visible = false;
                    ProgressPercentageText.Visible = false;
                    UninstallButton.Visible = false;
                    label3.Text = "Latest Version: " + API_GetLatestVer();

                    DiscordLink.LinkClicked += DiscordLink_LinkClicked;
                    PingTimer.Start();
                    PingTimer.Elapsed += CheckAPIStatus;
                    UpdateState(State.CHECK_FILES);
                    return;

                case State.CHECK_FILES:
                    StateButton.Enabled = false;
                    StateButton.Text = "Checking Files...";
                    progressBar1.Visible = false;
                    ProgressPercentageText.Visible = false;
                    UninstallButton.Visible = false;

                    //CheckLauncherVersion();
                    CheckFiles();
                    return;

                case State.EXTRACTING:
                    StateButton.Enabled = false;
                    StateButton.Text = "Extracting Zip";
                    progressBar1.Visible = false;
                    ProgressPercentageText.Visible = false;
                    UninstallButton.Visible = false;
                    return;

                case State.UPDATE_AVAILABLE:
                    StateButton.Enabled = true;
                    StateButton.Text = "Update Available";
                    //progressbar & percent
                    progressBar1.Visible = false;
                    ProgressPercentageText.Visible = false;
                    UninstallButton.Visible = false;
                    return;

                case State.INSTALLING:
                    StateButton.Enabled = false;
                    StateButton.Text = "Installing...";
                    //progressbar & percent
                    progressBar1.Visible = true;
                    ProgressPercentageText.Visible = true;
                    UninstallButton.Visible = false;

                    DownloadGame();
                    return;

                case State.CAN_PLAY:
                    StateButton.Enabled = true;
                    StateButton.Text = "Play";
                    progressBar1.Visible = false;
                    ProgressPercentageText.Visible = false;
                    UninstallButton.Visible = true;
                    UninstallButton.Enabled = true;
                    return;

                case State.UNINSTALL:
                    StateButton.Text = "Uninstalling...";
                    UninstallButton.Enabled = false;
                    return;

            }
        }

        private void DiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs largs)
        {
            //launch URL please
        }

        static public string PingAPI()
        {
            using (WebClient client = new WebClient())
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("violated.one");
                return reply.Status.ToString();
            }
        }

        public void CheckAPIStatus(object sender, ElapsedEventArgs e)
        {
            if (PingAPI() == "Success")
            {
                API_ONLINE = true;
            }
            else
            {
                API_ONLINE = false;
            }
        }
        string API_GetLatestVer()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    var JSONString = client.DownloadString("https://upload.violated.one/survmulti/latest.php");
                    var JObject = JsonNode.Parse(JSONString)["version"];
                    API_ONLINE = true;
                    return JObject.ToJsonString().Replace('"', ' ').Trim();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "API Remote Server Error");
                    return "";
                }


            }
        }
        private void UninstallGame()
        {
            System.IO.Directory.Delete(gameDir + "/game", true);
            UpdateState(State.CHECK_FILES);
            SetGameVersion();
        }

        //Starts download
        private void DownloadGame()
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadProgressChanged += wc_DownloadProgressChanged;
                client.DownloadFileAsync(new System.Uri("https://upload.violated.one/survmulti/game.zip"), gameDir + "/game.zip");
                client.DownloadFileCompleted += OnfinishDownload;
            }
        }


        // Event to track the download progress
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            ProgressPercentageText.Text = (e.ProgressPercentage.ToString() + "%");
        }

        void OnfinishDownload(object sender, AsyncCompletedEventArgs e)
        {
            //richTextBox1.Text = "DownloadFinished";
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            ProgressPercentageText.Text = "100%";
            string finaldest = gameDir + "/game";

            UpdateState(State.EXTRACTING);

            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory("game/game.zip", finaldest);
                System.IO.File.Delete("game/game.zip");
                SetGameVersion();
                UpdateState(State.CAN_PLAY);
            }
            catch (Exception err)
            {
#if !RELEASE
                MessageBox.Show(err.Message + "\r\nTHIS CAN BE IGNORED", "Extract Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
#else
                //pass
#endif
            }
            UpdateState(State.CHECK_FILES);
        }

        public void SetGameVersion()
        {
            if (System.IO.File.Exists(gameDir + "/game/version.md"))
            {
                string current_ver = (System.IO.File.ReadAllText(gameDir + "/game/version.md"));
                string api_ver = API_GetLatestVer();
                label2.Text = "Game Version: " + current_ver;
                label2.ForeColor = Color.Lime;

                if (current_ver != api_ver)
                {
                    UpdateState(State.UPDATE_AVAILABLE);
                }
                else
                {
                    UpdateState(State.CAN_PLAY);
                }
            }
            else
            {
                label2.Text = "Game not Installed";
                label2.ForeColor = Color.Red;
            }
        }

        void CheckFiles()
        {
            string[] files;
            if (System.IO.Directory.Exists(gameDir))
            {
                try
                {
                    files = System.IO.Directory.GetDirectories(gameDir); //Checks files based on if there is any folder in the dir (IMPROVE)
                    if (files.Length > 0)
                    {
                        //richTextBox1.Text = "Canplay";
                        UpdateState(State.CAN_PLAY);
                    }
                    else
                    {
                        UpdateState(State.UPDATE_AVAILABLE);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\r\nLauncher will close after pressing OK", "LaunchApp Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(gameDir);
                //richTextBox1.Text = "gamedir made";
                UpdateState(State.CHECK_FILES);
            }
        }

        //private void CheckLauncherVersion()
        //{
        //    launcher_ver = System.IO.File.ReadAllText(currDir + "/launcherv.txt");
        //    label4.Text = launcher_ver;
        //    //API CALL HERE
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Connecting to API...";

            //INIT Starts pingtimer
            UpdateState(State.INIT);
            SetGameVersion();
        }

        private void StateButton_Click(object sender, EventArgs e) //State button which does different things based on State var
        {
            switch (CurrentState)
            {
                case State.UPDATE_AVAILABLE:
                    UpdateState(State.INSTALLING);
                    return;

                case State.CAN_PLAY:
                    try
                    {
                        Process.Start(gameDir + "/game/SurvivalMulti.exe", "runas");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message + "\r\nLauncher will close after pressing OK", "LaunchApp Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    Application.Exit();
                    return;
            }
        }

        private static bool IsAdministrator()
        {
            //WINDOWS
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            //OTHER PLATFORMS HERE
#if !RELEASE
                return true;
#else
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
#endif
        }

        private void UninstallButton_Click(object sender, EventArgs e)
        {
            UninstallGame();
        }
    }
}