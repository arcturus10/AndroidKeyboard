using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Android_Keyboard
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
            string ExecutablePath = Application.StartupPath;
            WebView.Navigate(new Uri(ExecutablePath+"/debug.html"));
        }
    }
}
