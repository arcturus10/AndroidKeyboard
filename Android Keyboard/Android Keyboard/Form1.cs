using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Android_Keyboard
{
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "adb.exe";

            startInfo.Arguments = " devices";
            startInfo.UseShellExecute = false;
            p.StartInfo = startInfo;
            p.Start();
            var reader = p.StandardOutput;
            while (!reader.EndOfStream)
            {
                MessageBox.Show(reader.ReadLine());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = textBox1.Text;
            string[] Words = myString.Split(' ');
            foreach (string word in Words)
            {
                Process input = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.CreateNoWindow = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = "shell input keyboard text "+word;
                startInfo.UseShellExecute = false;
                input.StartInfo = startInfo;
                input.Start();
                input.WaitForExit();
                Process process = new Process();
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "adb.exe";
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                info.Arguments = "shell input keyevent 62";
                process.StartInfo = info;
                process.Start();
                Thread.Sleep(1000);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process Enter = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "adb.exe";
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.Arguments = "shell input keyevent 66";
            Enter.StartInfo = info;
            Enter.Start();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process BSpace = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "adb.exe";
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.Arguments = "shell input keyevent 67";
            BSpace.StartInfo = info;
            BSpace.Start();

        }

        private void TabKeyClick(object sender, EventArgs e)
        {
            Process Tab = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "adb.exe";
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.Arguments = "shell input keyevent 61";
            Tab.StartInfo = info;
            Tab.Start();

        }

        private void ArrowDlg_Open(object sender, EventArgs e)
        {
            ArrowKeys keys = new ArrowKeys();
            keys.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.ShowDialog();
        }
    }
}
