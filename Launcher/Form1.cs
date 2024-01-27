using System.IO;
using System.Diagnostics;
using System.Net;
using System.Linq.Expressions;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Principal;

namespace Launcher
{
    public partial class SurvLauncher : Form
    {
        public SurvLauncher()
        {
            InitializeComponent();
        }

        private string launcher_ver = "v2.3 - beta";
        private enum State
        {
            INIT,
            CHECK_FILES,
            EXTRACTING,
            UPDATE_AVAILABLE,
            INSTALLING,
            CAN_PLAY,
            UNINSTALL,
            FAILED
        }

        //directory but with /game added
        private string gameDir = System.IO.Directory.GetCurrentDirectory() + "/game";

        State CurrentState;
        void UpdateState(State NewState)
        {
            CurrentState = NewState;

            switch (NewState)
            {
                //MAKE SURE FUNCTION CALLS ARE ALWAYS 1 LINE BEFORE RETURN IN CASE
                case State.INIT:
                    label1.Text = "SurvLauncher " + launcher_ver;
                    StateButton.Enabled = false;
                    StateButton.Text = "Initializing...";

                    //progressbar & percent
                    progressBar1.Visible = false;
                    ProgressPercentageText.Visible = false;
                    UninstallButton.Visible = false;
                    UpdateState(State.CHECK_FILES);
                    return;

                case State.CHECK_FILES:
                    StateButton.Enabled = false;
                    StateButton.Text = "Checking Files...";
                    //progressbar & percent
                    progressBar1.Visible = false;
                    ProgressPercentageText.Visible = false;
                    UninstallButton.Visible = false;
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
                    //progressbar & percent
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
        string API_GetLatestVer()
        {
            //add
            return "[API_GAME_VERSION]";
        }
        private void UninstallGame()
        {
            System.IO.Directory.Delete(gameDir + "/game", true);
            UpdateState(State.CHECK_FILES);
        }
        private void DownloadGame()
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadProgressChanged += wc_DownloadProgressChanged;
                client.DownloadFileAsync(new System.Uri("https://upload.violated.one/survmulti/game.zip"), gameDir + "/game.zip");
                client.DownloadFileCompleted += OnfinishDownload;
            }
        }
        // Event to track the progress
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            ProgressPercentageText.Text = (e.ProgressPercentage.ToString() + "%");
        }

        void OnfinishDownload(object sender, AsyncCompletedEventArgs e)
        {
            richTextBox1.Text = "DownloadFinished";
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            ProgressPercentageText.Text = "100%";
            string finaldest = gameDir + "/game";
            UpdateState(State.EXTRACTING);

            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory("game/game.zip", finaldest);
                UpdateState(State.CAN_PLAY);
                System.IO.File.Delete("game/game.zip");
                SetGameVersion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "\r\nTry Again", "Extract Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            UpdateState(State.CHECK_FILES);
        }

        void SetGameVersion()
        {
            if (System.IO.File.Exists(gameDir + "/game/version.md"))
            {
                string current_ver = ("Game Version: " + System.IO.File.ReadAllText(gameDir + "/game/version.md"));
                string api_ver = API_GetLatestVer();
                label2.Text = current_ver;

                if (current_ver != api_ver)
                {
                    //retrieve API version
                    label2.Text = "Update Available: " + api_ver;
                }
            }
            else
            {
                label2.Text = "Game not Installed";
            }
        }

        void CheckFiles()
        {
            string[] files;
            if (System.IO.Directory.Exists(gameDir))
            {
                try
                {
                    files = System.IO.Directory.GetDirectories(gameDir);
                    if (files.Length > 0)
                    {
                        richTextBox1.Text = "Canplay";
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
                richTextBox1.Text = "gamedir made";
                UpdateState(State.CHECK_FILES);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateState(State.INIT);
            SetGameVersion();
        }

        private void StateButton_Click(object sender, EventArgs e)
        {
            switch (CurrentState)
            {
                case State.UPDATE_AVAILABLE:
                    if (IsAdministrator())
                    {
                        UpdateState(State.INSTALLING);
                    }
                    else
                    {
                        MessageBox.Show("The Program could not install due to permission conflicts.\r\nTry running as Administrator!");
                    }
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

            static bool IsAdministrator()
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
#if DEBUG
                return true;
#else
                        return principal.IsInRole(WindowsBuiltInRole.Administrator);
#endif
            }
        }

        private void UninstallButton_Click(object sender, EventArgs e)
        {
            UninstallGame();
        }
    }
}