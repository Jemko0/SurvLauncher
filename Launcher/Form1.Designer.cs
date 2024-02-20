namespace Launcher
{
    partial class SurvLauncher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurvLauncher));
            progressBar1 = new ProgressBar();
            label1 = new Label();
            StateButton = new Button();
            label2 = new Label();
            ProgressPercentageText = new Label();
            UninstallButton = new Button();
            label3 = new Label();
            DiscordLink = new LinkLabel();
            dInfo_DownloadSpeed = new Label();
            dInfo_Progress = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(268, 266);
            progressBar1.Margin = new Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(452, 26);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(81, 38);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(846, 86);
            label1.TabIndex = 2;
            label1.Text = "SurvLauncher v0.0 - specifier";
            // 
            // StateButton
            // 
            StateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StateButton.ForeColor = SystemColors.InfoText;
            StateButton.Location = new Point(268, 317);
            StateButton.Margin = new Padding(0);
            StateButton.Name = "StateButton";
            StateButton.Padding = new Padding(5);
            StateButton.Size = new Size(452, 49);
            StateButton.TabIndex = 3;
            StateButton.Text = "BUTTON_STATE";
            StateButton.UseVisualStyleBackColor = true;
            StateButton.Click += StateButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(94, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(288, 32);
            label2.TabIndex = 4;
            label2.Text = "INST_GAME_VER: cbv0.0.0";
            // 
            // ProgressPercentageText
            // 
            ProgressPercentageText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ProgressPercentageText.AutoSize = true;
            ProgressPercentageText.BackColor = Color.SteelBlue;
            ProgressPercentageText.FlatStyle = FlatStyle.System;
            ProgressPercentageText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ProgressPercentageText.ForeColor = SystemColors.ButtonFace;
            ProgressPercentageText.ImageAlign = ContentAlignment.MiddleLeft;
            ProgressPercentageText.Location = new Point(724, 258);
            ProgressPercentageText.Margin = new Padding(2, 0, 2, 0);
            ProgressPercentageText.Name = "ProgressPercentageText";
            ProgressPercentageText.Size = new Size(59, 41);
            ProgressPercentageText.TabIndex = 5;
            ProgressPercentageText.Text = "0%";
            ProgressPercentageText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UninstallButton
            // 
            UninstallButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UninstallButton.ForeColor = SystemColors.InfoText;
            UninstallButton.Location = new Point(268, 372);
            UninstallButton.Margin = new Padding(0);
            UninstallButton.Name = "UninstallButton";
            UninstallButton.Padding = new Padding(5);
            UninstallButton.Size = new Size(452, 40);
            UninstallButton.TabIndex = 6;
            UninstallButton.Text = "Uninstall";
            UninstallButton.UseVisualStyleBackColor = true;
            UninstallButton.Click += UninstallButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(94, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(272, 32);
            label3.TabIndex = 7;
            label3.Text = "API_GAME_VER: cbv0.0.0";
            DiscordLink.AutoSize = true;
            DiscordLink.Location = new Point(94, 190);
            DiscordLink.Name = "DiscordLink";
            DiscordLink.Size = new Size(155, 25);
            DiscordLink.TabIndex = 8;
            DiscordLink.TabStop = true;
            DiscordLink.Text = "DISCORD SERVER";
            dInfo_DownloadSpeed.Anchor = AnchorStyles.Top;
            dInfo_DownloadSpeed.AutoSize = true;
            dInfo_DownloadSpeed.FlatStyle = FlatStyle.Flat;
            dInfo_DownloadSpeed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dInfo_DownloadSpeed.ForeColor = SystemColors.ButtonFace;
            dInfo_DownloadSpeed.Location = new Point(567, 211);
            dInfo_DownloadSpeed.Margin = new Padding(2, 0, 2, 0);
            dInfo_DownloadSpeed.Name = "dInfo_DownloadSpeed";
            dInfo_DownloadSpeed.Size = new Size(68, 28);
            dInfo_DownloadSpeed.TabIndex = 8;
            dInfo_DownloadSpeed.Text = "0MB/s";
            // 
            // dInfo_Progress
            // 
            dInfo_Progress.Anchor = AnchorStyles.Top;
            dInfo_Progress.AutoSize = true;
            dInfo_Progress.FlatStyle = FlatStyle.Flat;
            dInfo_Progress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dInfo_Progress.ForeColor = SystemColors.ButtonFace;
            dInfo_Progress.Location = new Point(170, 211);
            dInfo_Progress.Margin = new Padding(2, 0, 2, 0);
            dInfo_Progress.Name = "dInfo_Progress";
            dInfo_Progress.Size = new Size(132, 28);
            dInfo_Progress.TabIndex = 9;
            dInfo_Progress.Text = "0MB / 999MB";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(984, 462);
            Controls.Add(DiscordLink);
            ClientSize = new Size(787, 401);
            Controls.Add(dInfo_Progress);
            Controls.Add(dInfo_DownloadSpeed);
            Controls.Add(label3);
            Controls.Add(UninstallButton);
            Controls.Add(ProgressPercentageText);
            Controls.Add(label2);
            Controls.Add(StateButton);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimumSize = new Size(920, 477);
            Name = "SurvLauncher";
            Text = "SurvLauncher";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Button StateButton;
        private Label label2;
        private Label ProgressPercentageText;
        private Button UninstallButton;
        private Label label3;
        private LinkLabel DiscordLink;
        private Label dInfo_DownloadSpeed;
        private Label dInfo_Progress;
    }
}