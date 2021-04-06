using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace RAMBomber
{
    public partial class Form1 : Form
    {
        int waitlength = 10;
        bool notepad;
        bool cmd;
        bool gui;
        string currentdir = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();


            WaitTimer.Interval = waitlength;

            WaitTime.TextChanged += WaitTime_TextChanged;
        }

        public void WaitTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                waitlength = Convert.ToInt32(WaitTime.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid character. Please enter a number up to 9999.", "Invalid Wait Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NotepadButton_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("This will execute a Notepad bomb operation. Continue?", "Notepad Bomb", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                notepad = true;
                WaitTimer.Start();                
            }
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            if (notepad == true)
            {
                Process.Start("notepad");
            }
            if (cmd == true)
            {
                Process.Start("cmd");
            }
            if (gui == true)
            {
                Process.Start(currentdir + "\\RAMBomber.exe");
            }
        }

        private void CMDButton_Click(object sender, EventArgs e)
        {
            DialogResult dd = MessageBox.Show("This will execute a CMD bomb operation. Continue?", "CMD Bomb", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dd == DialogResult.Yes)
            {
                cmd = true;
                WaitTimer.Start();
            }
        }

        private void GUIButton_Click(object sender, EventArgs e)
        {
            DialogResult ddd = MessageBox.Show("This will execute a GUI bomb operation. Continue?", "GUI Bomb", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ddd == DialogResult.Yes)
            {
                gui = true;
                WaitTimer.Start();
            }
        }

        private void StopNotepad_Click(object sender, EventArgs e)
        {
            WaitTimer.Stop();
            notepad = false;
            Process.Start("taskkill", "/f /im notepad.exe");
            WaitTimer.Start();
        }

        private void StopCMD_Click(object sender, EventArgs e)
        {
            WaitTimer.Stop();
            cmd = false;
            Process.Start("taskkill", "/f /im cmd.exe");
            WaitTimer.Start();
        }

        private void StopGui_Click(object sender, EventArgs e)
        {
            WaitTimer.Stop();
            gui = false;
            if (!File.Exists(currentdir + "\\stopgui.bat"))
            {
                StreamWriter sw = new StreamWriter(currentdir + "\\stopgui.bat");
                sw.Write($"taskkill /f /im \"RAMBomber.exe\"\ncd/\ncd {currentdir}\nstart /b RAMBomber.exe\nexit");
                sw.Close();
                Process.Start(currentdir + "\\stopgui.bat");
            }
            else
            {
                Process.Start(currentdir + "\\stopgui.bat");
            }
            WaitTimer.Start();
        }

        private void StopAllButton_Click(object sender, EventArgs e)
        {
            WaitTimer.Stop();
            notepad = false;
            cmd = false;
            gui = false;
            Process.Start("taskkill", "/f /im notepad.exe");
            Process.Start("taskkill", "/f /im cmd.exe");
            Process.Start(currentdir + "\\stopgui.bat");
        }

        private void WebButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/imrolii/RAMBomber");
        }
    }
}
