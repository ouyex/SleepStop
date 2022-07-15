using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepStop
{
    public partial class Form1 : Form
    {
        string[] folderPaths = new string[4];
        bool isRunning;
        float writeTime = 5.0f;
        Timer timer = new Timer();
        string configFilePath;
        string configDirPath;

        public Form1()
        {
            InitializeComponent();
            configDirPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SleepStop";
            configFilePath = configDirPath + "\\config.cfg";
            Logger.consoleBox = consoleTextBox;
            LoadConfigData();
            UpdateLabelText();
        }

        private void drive1SelectButton_Click(object sender, EventArgs e)
        {
            SelectDrive(0);
        }

        private void drive2SelectButton_Click(object sender, EventArgs e)
        {
            SelectDrive(1);
        }

        private void drive3SelectButton_Click(object sender, EventArgs e)
        {
            SelectDrive(2);
        }

        private void drive4SelectButton_Click(object sender, EventArgs e)
        {
            SelectDrive(3);
        }

        private void UpdateLabelText()
        {
            for (int i = 0; i < folderPaths.Length; i++)
            {
                string newText = "N/A";

                if (!string.IsNullOrWhiteSpace(folderPaths[i]))
                    newText = folderPaths[i];

                newText = "Path: " + newText;

                switch (i)
                {
                    case 0:
                        drive1SelectionLabel.Text = newText;
                        break;
                    case 1:
                        drive2SelectionLabel.Text = newText;
                        break;
                    case 2:
                        drive3SelectionLabel.Text = newText;
                        break;
                    case 3:
                        drive4SelectionLabel.Text = newText;
                        break;
                }
            }
        }

        private void LoadConfigData()
        {
            if (string.IsNullOrWhiteSpace(configFilePath) || !File.Exists(configFilePath) || !Directory.Exists(configDirPath))
                return;

            string[] lines = File.ReadAllLines(configFilePath);

            for (int i = 0; i < folderPaths.Length; i++)
                folderPaths[i] = lines[i];
            try
            {
                numericUpDown1.Value = decimal.Parse(lines[lines.Length - 1]);
            }
            catch { }
            UpdateLabelText();
            Logger.WriteLine("Loaded config.");
            
        }

        private void WriteConfigData()
        {
            if (string.IsNullOrWhiteSpace(configFilePath))
                return;

            string[] linesToWrite = {
                folderPaths[0],
                folderPaths[1],
                folderPaths[2],
                folderPaths[3],
                writeTime.ToString()
            };

            if (!Directory.Exists(configDirPath))
                Directory.CreateDirectory(configDirPath);

            File.WriteAllLines(configFilePath, linesToWrite);
        }

        private void SelectDrive(int driveNum)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                bool exists = false;

                for (int i = 0; i < folderPaths.Length; i++)
                {
                    if (dialog.SelectedPath == folderPaths[i])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    folderPaths[driveNum] = dialog.SelectedPath;
                    Logger.WriteLine($"Set drive{driveNum} path to \"{folderPaths[driveNum]}\".");
                    WriteConfigData();
                    UpdateLabelText();
                }
                else
                    Logger.WriteLine($"Failed to set drive{driveNum} path, path \"{dialog.SelectedPath}\" already selected.");
            } else
            {
                Logger.WriteLine($"Failed to set drive{driveNum} path, dialog was most likely closed without a selection.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < folderPaths.Length; i++)
                folderPaths[i] = "";
            Logger.WriteLine("Cleared all drive selections.");
            WriteConfigData();
            UpdateLabelText();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                bool pathExists = false;

                for (int i = 0; i < folderPaths.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(folderPaths[i]))
                    {
                        pathExists = true;
                        break;
                    }
                }
                if (!pathExists)
                {
                    Logger.WriteLine("Failed to start, no drives selected.");
                    return;
                }

                isRunning = true;
                startButton.Text = "Stop";
                runningLabel.Text = "Status: Running";
                resetConfigButton.Enabled = false;
                drive1SelectButton.Enabled = false;
                drive2SelectButton.Enabled = false;
                drive3SelectButton.Enabled = false;
                drive4SelectButton.Enabled = false;
                numericUpDown1.Enabled = false;
                clearButton.Enabled = false;
                timer.Interval = (int)(writeTime * 60 * 1000);
                timer.Tick += new EventHandler(TimerTick);
                timer.Start();
                Logger.WriteLine("Started.");
                TimerTick(null, null);
            }
            else
            {
                isRunning = false;
                startButton.Text = "Start";
                runningLabel.Text = "Status: Stopped";
                resetConfigButton.Enabled = true;
                drive1SelectButton.Enabled = true;
                drive2SelectButton.Enabled = true;
                drive3SelectButton.Enabled = true;
                drive4SelectButton.Enabled = true;
                numericUpDown1.Enabled = true;
                clearButton.Enabled = true;
                Logger.WriteLine("Stopped.");
                timer.Stop();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            writeTime = (float)numericUpDown1.Value;
            Logger.WriteLine($"Set Write Time to {writeTime}.");
            WriteConfigData();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            for (int i = 0; i < folderPaths.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(folderPaths[i]))
                    continue;

                string filePath = folderPaths[i] + "\\sleepStopWriteFile.sleepstopwritefile";
                
                try
                {
                    File.WriteAllText(filePath, "");
                    File.Delete(filePath);
                    Logger.WriteLine($"Wrote/Deleted file at path \"{folderPaths[i]}\".");
                }
                catch (Exception ex)
                {
                    Logger.WriteLine($"Failed to write/delete file at path \"{folderPaths[i]}\". Exception:\n{ex}\n");
                }
            }
        }

        private void resetConfigButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
                return;

            DialogResult result = MessageBox.Show("Are you sure you want to reset your config?", "Reset Config", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                File.Delete(configFilePath);
                writeTime = 5.0f;
                numericUpDown1.Value = 5.0M;
                folderPaths = new string[4];
                UpdateLabelText();
                Logger.WriteLine("Deleted config file.");
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Hide();
        }
    }
}
