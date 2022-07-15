
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
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
            this.aboutTitleLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.aboutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.aboutTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // mainTab
            // 
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
            this.mainTab.Size = new System.Drawing.Size(343, 253);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(182, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Write Time (minutes):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(183, 220);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(154, 27);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(4, 198);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(173, 49);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
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
            this.drive4SelectButton.Text = "Select Drive";
            this.drive4SelectButton.UseVisualStyleBackColor = true;
            // 
            // drive3SelectButton
            // 
            this.drive3SelectButton.Location = new System.Drawing.Point(6, 96);
            this.drive3SelectButton.Name = "drive3SelectButton";
            this.drive3SelectButton.Size = new System.Drawing.Size(173, 29);
            this.drive3SelectButton.TabIndex = 3;
            this.drive3SelectButton.Text = "Select Drive";
            this.drive3SelectButton.UseVisualStyleBackColor = true;
            // 
            // drive2SelectButton
            // 
            this.drive2SelectButton.Location = new System.Drawing.Point(6, 61);
            this.drive2SelectButton.Name = "drive2SelectButton";
            this.drive2SelectButton.Size = new System.Drawing.Size(173, 29);
            this.drive2SelectButton.TabIndex = 2;
            this.drive2SelectButton.Text = "Select Drive";
            this.drive2SelectButton.UseVisualStyleBackColor = true;
            // 
            // selectDrivesLabel
            // 
            this.selectDrivesLabel.AutoSize = true;
            this.selectDrivesLabel.Location = new System.Drawing.Point(6, 3);
            this.selectDrivesLabel.Name = "selectDrivesLabel";
            this.selectDrivesLabel.Size = new System.Drawing.Size(97, 20);
            this.selectDrivesLabel.TabIndex = 1;
            this.selectDrivesLabel.Text = "Select Drives:";
            // 
            // drive1SelectButton
            // 
            this.drive1SelectButton.Location = new System.Drawing.Point(6, 26);
            this.drive1SelectButton.Name = "drive1SelectButton";
            this.drive1SelectButton.Size = new System.Drawing.Size(173, 29);
            this.drive1SelectButton.TabIndex = 0;
            this.drive1SelectButton.Text = "Select Drive";
            this.drive1SelectButton.UseVisualStyleBackColor = true;
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.aboutTitleLabel);
            this.aboutTab.Location = new System.Drawing.Point(4, 29);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(343, 253);
            this.aboutTab.TabIndex = 2;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // aboutTitleLabel
            // 
            this.aboutTitleLabel.AutoSize = true;
            this.aboutTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutTitleLabel.Location = new System.Drawing.Point(98, 18);
            this.aboutTitleLabel.Name = "aboutTitleLabel";
            this.aboutTitleLabel.Size = new System.Drawing.Size(144, 41);
            this.aboutTitleLabel.TabIndex = 0;
            this.aboutTitleLabel.Text = "SleepStop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 310);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SleepStop";
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
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
    }
}

