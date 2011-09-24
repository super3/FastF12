using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
    // Shell Scripting
using System.Diagnostics;
    // Shell Scripting
using System.Runtime.InteropServices;
    // Idle Timer
using System.Collections; 
    // ObjectsArrays


namespace FastF12_2._0
{
    public partial class Main : Form
    {
        // Unmanaged function from user32.dll( Idle Timer )
        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        // Struct we'll need to pass to the function( Idle Timer )
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Lanch Render Job Wizard
            Wizard_Start wizard = new Wizard_Start();
            wizard.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Resize Border Labels
            border.Height = 2;
            border2.Height = 2;

            //Resize Form Height
            this.Height = 315;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Updates - http://nystic.com/
            //Icons - http://www.pinvoke.com/
            //Logo - http://blender.org/

            //Lanch Help
            Help help = new Help();
            help.Show();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            //Resize From
            btnMore.Visible = false;
            this.Height = 525;
            border.Visible = true;
            border2.Top = 31;
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            //Resize From
            btnMore.Visible = true;
            this.Height = 315;
            border.Visible = false;
            border2.Top = 31;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //Lanch Settings
            Settings settings = new Settings();
            settings.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();

            if (txtUser.Text == "" || txtPass.Text == "") {
                MessageBox.Show("You left the username/password blank.");
            }
            //Santize and Check for Alpha-Numeric
            else {
                //web.Navigate("http://nystic.com/login?=mode=fastf12&user=" + txtUser.Text +
                //    "&pass=" + txtPass.Text);
                //Get info ( and files) 
                //Condition if the internet fails
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://nystic.com/register/");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BlenderJob job = new BlenderJob();
            //txtUser.Text = job.Run();

            ProcessStartInfo cmd;

            //Shell windows settings and arguments 
            cmd = new ProcessStartInfo("C:\\Users\\Shawn\\Desktop\\Blender\\blender.exe",job.Run());
            cmd.UseShellExecute = false;
            cmd.ErrorDialog = true;
            cmd.CreateNoWindow = true;
            cmd.RedirectStandardOutput = true;

            //Read and process shell output
            Process p = Process.Start(cmd);

            StreamReader oReader2 = p.StandardOutput;
            while (!oReader2.EndOfStream)
            {
                MessageBox.Show(oReader2.ReadLine());
            }
            oReader2.Close();
        }

    }
}
