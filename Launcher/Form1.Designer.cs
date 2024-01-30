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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            StateButton = new Button();
            label2 = new Label();
            ProgressPercentageText = new Label();
            UninstallButton = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(170, 209);
            progressBar1.Margin = new Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(465, 28);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(10, 352);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(766, 34);
            richTextBox1.TabIndex = 1;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "console output";
            richTextBox1.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(65, 30);
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
            StateButton.Location = new Point(214, 257);
            StateButton.Margin = new Padding(0);
            StateButton.Name = "StateButton";
            StateButton.Padding = new Padding(4);
            StateButton.Size = new Size(362, 39);
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
            label2.Location = new Point(75, 101);
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
            ProgressPercentageText.Location = new Point(637, 205);
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
            UninstallButton.Location = new Point(214, 301);
            UninstallButton.Margin = new Padding(0);
            UninstallButton.Name = "UninstallButton";
            UninstallButton.Padding = new Padding(4);
            UninstallButton.Size = new Size(362, 32);
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
            label3.Location = new Point(75, 126);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(227, 28);
            label3.TabIndex = 7;
            label3.Text = "API_GAME_VER: cbv0.0.0";
            // 
            // label4
            // 
            label4.AccessibleName = "";
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(421, 126);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(214, 28);
            label4.TabIndex = 8;
            label4.Text = "LAUNCHER_VER: v0.0.0";
            // 
            // SurvLauncher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(787, 401);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(UninstallButton);
            Controls.Add(ProgressPercentageText);
            Controls.Add(label2);
            Controls.Add(StateButton);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(progressBar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimumSize = new Size(740, 393);
            Name = "SurvLauncher";
            Text = "SurvLauncher";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button StateButton;
        private Label label2;
        private Label ProgressPercentageText;
        private Button UninstallButton;
        private Label label3;
        private Label label4;
    }
}