﻿namespace Launcher
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
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(214, 244);
            progressBar1.Margin = new Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(535, 21);
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
            label1.Location = new Point(140, 29);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(713, 72);
            label1.TabIndex = 2;
            label1.Text = "SurvLauncher v0.0 - specifier";
            // 
            // StateButton
            // 
            StateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StateButton.ForeColor = SystemColors.InfoText;
            StateButton.Location = new Point(214, 278);
            StateButton.Margin = new Padding(0);
            StateButton.Name = "StateButton";
            StateButton.Padding = new Padding(4);
            StateButton.Size = new Size(535, 39);
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
            label2.Location = new Point(161, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 28);
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
            ProgressPercentageText.Location = new Point(752, 237);
            ProgressPercentageText.Margin = new Padding(2, 0, 2, 0);
            ProgressPercentageText.Name = "ProgressPercentageText";
            ProgressPercentageText.Size = new Size(48, 35);
            ProgressPercentageText.TabIndex = 5;
            ProgressPercentageText.Text = "0%";
            ProgressPercentageText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UninstallButton
            // 
            UninstallButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UninstallButton.ForeColor = SystemColors.InfoText;
            UninstallButton.Location = new Point(214, 322);
            UninstallButton.Margin = new Padding(0);
            UninstallButton.Name = "UninstallButton";
            UninstallButton.Padding = new Padding(4);
            UninstallButton.Size = new Size(535, 37);
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
            label3.Location = new Point(161, 126);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(227, 28);
            label3.TabIndex = 7;
            label3.Text = "API_GAME_VER: cbv0.0.0";
            // 
            // DiscordLink
            // 
            DiscordLink.AutoSize = true;
            DiscordLink.Location = new Point(75, 152);
            DiscordLink.Margin = new Padding(2, 0, 2, 0);
            DiscordLink.Name = "DiscordLink";
            DiscordLink.Size = new Size(127, 20);
            DiscordLink.TabIndex = 8;
            DiscordLink.TabStop = true;
            DiscordLink.Text = "DISCORD SERVER";
            DiscordLink.Visible = false;
            // 
            // SurvLauncher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(895, 375);
            Controls.Add(DiscordLink);
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
            MinimumSize = new Size(740, 391);
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
    }
}