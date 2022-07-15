
namespace SleepStop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.runningLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.configLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.drive4SelectionLabel = new System.Windows.Forms.Label();
            this.drive3SelectionLabel = new System.Windows.Forms.Label();
            this.drive2SelectionLabel = new System.Windows.Forms.Label();
            this.drive1SelectionLabel = new System.Windows.Forms.Label();
            this.drive4SelectButton = new System.Windows.Forms.Button();
            this.drive3SelectButton = new System.Windows.Forms.Button();
            this.drive2SelectButton = new System.Windows.Forms.Button();
            this.selectDrivesLabel = new System.Windows.Forms.Label();
            this.drive1SelectButton = new System.Windows.Forms.Button();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.resetConfigButton = new System.Windows.Forms.Button();
            this.aboutTitleLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.aboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.aboutTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 320);
            this.tabControl1.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.runningLabel);
            this.mainTab.Controls.Add(this.clearButton);
            this.mainTab.Controls.Add(this.configLabel);
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Controls.Add(this.numericUpDown1);
            this.mainTab.Controls.Add(this.startButton);
            this.mainTab.Controls.Add(this.drive4SelectionLabel);
            this.mainTab.Controls.Add(this.drive3SelectionLabel);
            this.mainTab.Controls.Add(this.drive2SelectionLabel);
            this.mainTab.Controls.Add(this.drive1SelectionLabel);
            this.mainTab.Controls.Add(this.drive4SelectButton);
            this.mainTab.Controls.Add(this.drive3SelectButton);
            this.mainTab.Controls.Add(this.drive2SelectButton);
            this.mainTab.Controls.Add(this.selectDrivesLabel);
            this.mainTab.Controls.Add(this.drive1SelectButton);
            this.mainTab.Location = new System.Drawing.Point(4, 29);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(343, 287);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // runningLabel
            // 
            this.runningLabel.AutoSize = true;
            this.runningLabel.Location = new System.Drawing.Point(183, 198);
            this.runningLabel.Name = "runningLabel";
            this.runningLabel.Size = new System.Drawing.Size(113, 20);
            this.runningLabel.TabIndex = 14;
            this.runningLabel.Text = "Status: Stopped";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 252);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(171, 29);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear Selected Drives";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Location = new System.Drawing.Point(6, 175);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(77, 20);
            this.configLabel.TabIndex = 12;
            this.configLabel.Text = "Configure:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Write Time (minutes):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(183, 252);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(154, 27);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(4, 198);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(173, 49);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // drive4SelectionLabel
            // 
            this.drive4SelectionLabel.AutoSize = true;
            this.drive4SelectionLabel.Location = new System.Drawing.Point(185, 135);
            this.drive4SelectionLabel.Name = "drive4SelectionLabel";
            this.drive4SelectionLabel.Size = new System.Drawing.Size(148, 20);
            this.drive4SelectionLabel.TabIndex = 8;
            this.drive4SelectionLabel.Text = "Drive Selected: None";
            // 
            // drive3SelectionLabel
            // 
            this.drive3SelectionLabel.AutoSize = true;
            this.drive3SelectionLabel.Location = new System.Drawing.Point(185, 100);
            this.drive3SelectionLabel.Name = "drive3SelectionLabel";
            this.drive3SelectionLabel.Size = new System.Drawing.Size(148, 20);
            this.drive3SelectionLabel.TabIndex = 7;
            this.drive3SelectionLabel.Text = "Drive Selected: None";
            // 
            // drive2SelectionLabel
            // 
            this.drive2SelectionLabel.AutoSize = true;
            this.drive2SelectionLabel.Location = new System.Drawing.Point(185, 65);
            this.drive2SelectionLabel.Name = "drive2SelectionLabel";
            this.drive2SelectionLabel.Size = new System.Drawing.Size(148, 20);
            this.drive2SelectionLabel.TabIndex = 6;
            this.drive2SelectionLabel.Text = "Drive Selected: None";
            // 
            // drive1SelectionLabel
            // 
            this.drive1SelectionLabel.AutoSize = true;
            this.drive1SelectionLabel.Location = new System.Drawing.Point(185, 30);
            this.drive1SelectionLabel.Name = "drive1SelectionLabel";
            this.drive1SelectionLabel.Size = new System.Drawing.Size(148, 20);
            this.drive1SelectionLabel.TabIndex = 5;
            this.drive1SelectionLabel.Text = "Drive Selected: None";
            // 
            // drive4SelectButton
            // 
            this.drive4SelectButton.Location = new System.Drawing.Point(6, 131);
            this.drive4SelectButton.Name = "drive4SelectButton";
            this.drive4SelectButton.Size = new System.Drawing.Size(173, 29);
            this.drive4SelectButton.TabIndex = 4;
            this.drive4SelectButton.Text = "Select Folder";
            this.drive4SelectButton.UseVisualStyleBackColor = true;
            this.drive4SelectButton.Click += new System.EventHandler(this.drive4SelectButton_Click);
            // 
            // drive3SelectButton
            // 
            this.drive3SelectButton.Location = new System.Drawing.Point(6, 96);
            this.drive3SelectButton.Name = "drive3SelectButton";
            this.drive3SelectButton.Size = new System.Drawing.Size(173, 29);
            this.drive3SelectButton.TabIndex = 3;
            this.drive3SelectButton.Text = "Select Folder";
            this.drive3SelectButton.UseVisualStyleBackColor = true;
            this.drive3SelectButton.Click += new System.EventHandler(this.drive3SelectButton_Click);
            // 
            // drive2SelectButton
            // 
            this.drive2SelectButton.Location = new System.Drawing.Point(6, 61);
            this.drive2SelectButton.Name = "drive2SelectButton";
            this.drive2SelectButton.Size = new System.Drawing.Size(173, 29);
            this.drive2SelectButton.TabIndex = 2;
            this.drive2SelectButton.Text = "Select Folder";
            this.drive2SelectButton.UseVisualStyleBackColor = true;
            this.drive2SelectButton.Click += new System.EventHandler(this.drive2SelectButton_Click);
            // 
            // selectDrivesLabel
            // 
            this.selectDrivesLabel.AutoSize = true;
            this.selectDrivesLabel.Location = new System.Drawing.Point(6, 3);
            this.selectDrivesLabel.Name = "selectDrivesLabel";
            this.selectDrivesLabel.Size = new System.Drawing.Size(151, 20);
            this.selectDrivesLabel.TabIndex = 1;
            this.selectDrivesLabel.Text = "Select Folders/Drives:";
            // 
            // drive1SelectButton
            // 
            this.drive1SelectButton.Location = new System.Drawing.Point(6, 26);
            this.drive1SelectButton.Name = "drive1SelectButton";
            this.drive1SelectButton.Size = new System.Drawing.Size(173, 29);
            this.drive1SelectButton.TabIndex = 0;
            this.drive1SelectButton.Text = "Select Folder";
            this.drive1SelectButton.UseVisualStyleBackColor = true;
            this.drive1SelectButton.Click += new System.EventHandler(this.drive1SelectButton_Click);
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.pictureBox1);
            this.aboutTab.Controls.Add(this.consoleTextBox);
            this.aboutTab.Controls.Add(this.versionLabel);
            this.aboutTab.Controls.Add(this.resetConfigButton);
            this.aboutTab.Controls.Add(this.aboutTitleLabel);
            this.aboutTab.Location = new System.Drawing.Point(4, 29);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(343, 287);
            this.aboutTab.TabIndex = 2;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Location = new System.Drawing.Point(6, 70);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.Size = new System.Drawing.Size(331, 211);
            this.consoleTextBox.TabIndex = 3;
            this.consoleTextBox.Text = "";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(242, 12);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(80, 20);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version 1.0";
            // 
            // resetConfigButton
            // 
            this.resetConfigButton.Location = new System.Drawing.Point(225, 35);
            this.resetConfigButton.Name = "resetConfigButton";
            this.resetConfigButton.Size = new System.Drawing.Size(112, 29);
            this.resetConfigButton.TabIndex = 1;
            this.resetConfigButton.Text = "Reset Config";
            this.resetConfigButton.UseVisualStyleBackColor = true;
            this.resetConfigButton.Click += new System.EventHandler(this.resetConfigButton_Click);
            // 
            // aboutTitleLabel
            // 
            this.aboutTitleLabel.AutoSize = true;
            this.aboutTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutTitleLabel.Location = new System.Drawing.Point(71, 12);
            this.aboutTitleLabel.Name = "aboutTitleLabel";
            this.aboutTitleLabel.Size = new System.Drawing.Size(144, 41);
            this.aboutTitleLabel.TabIndex = 0;
            this.aboutTitleLabel.Text = "SleepStop";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 342);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SleepStop";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.Button drive1SelectButton;
        private System.Windows.Forms.Label selectDrivesLabel;
        private System.Windows.Forms.Button drive4SelectButton;
        private System.Windows.Forms.Button drive3SelectButton;
        private System.Windows.Forms.Button drive2SelectButton;
        private System.Windows.Forms.Label drive1SelectionLabel;
        private System.Windows.Forms.Label drive4SelectionLabel;
        private System.Windows.Forms.Label drive3SelectionLabel;
        private System.Windows.Forms.Label drive2SelectionLabel;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.Label aboutTitleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label runningLabel;
        private System.Windows.Forms.Button resetConfigButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

