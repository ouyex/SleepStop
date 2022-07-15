using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SleepStop
{
    public static class Logger
    {
        static string consoleText = "";
        public static RichTextBox consoleBox;

        public static void WriteLine(string text)
        {
            consoleText += " ] " + text + "\n";
            consoleBox.Text = consoleText;
            consoleBox.SelectionStart = consoleBox.Text.Length;
            consoleBox.ScrollToCaret();
        }
    }
}
