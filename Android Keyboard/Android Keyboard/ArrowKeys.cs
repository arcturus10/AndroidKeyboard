using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Android_Keyboard
{
    public partial class ArrowKeys : MaterialSkin.Controls.MaterialForm
    {
        public ArrowKeys()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void upBtn_Click(object sender, EventArgs e)
        {
            Process UA = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "adb.exe";
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.Arguments = "shell input keyevent 19";
            UA.StartInfo = info;
            UA.Start();
        }

        private void dnBtn_Click(object sender, EventArgs e)
        {
            Process DA = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "adb.exe";
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.Arguments = "shell input keyevent 20";
            DA.StartInfo = info;
            DA.Start();
        }

        private void rtBtn_Click(object sender, EventArgs e)
        {
            Process RA = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "adb.exe";
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.Arguments = "shell input keyevent 22";
            RA.StartInfo = info;
            RA.Start();
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            Process LA = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "adb.exe";
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.Arguments = "shell input keyevent 21";
            LA.StartInfo = info;
            LA.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {   if (trackBar1.Value / 10.0 == 0)
            {
                MessageBox.Show("'Opacity' cannot be zero");
            }
            else
            {
                double Opacity = (trackBar1.Value / 10.0);
                this.Opacity = Opacity;
            }
        }
    }
}
