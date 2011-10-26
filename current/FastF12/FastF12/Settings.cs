using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastF12
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://super3.org/");
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/super3/FastF12/");
        }

        private void btnWiki_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/super3/FastF12/wiki/");
        }

        private void btnBug_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/super3/FastF12/issues");
        }

        private void btnBrent_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://brentf.com/");
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://jonasraskdesign.com/");
        }

        private void btnPinvoke_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://p.yusukekamiyamane.com/");
        }

        private void btnBlender_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://blender.org/");
        }

        private String openFile(String FileFilter)
        {
            //Initialize Open Files Dialog
            var dlg = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = FileFilter
            };

            //Check Result and Set Result to Upload Textbox
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.FileName;
            }
            else
            {
                return null;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Browse for Blender.exe
            txtBlenderExe.Text = openFile("Blender.exe (blender.exe)|blender.exe");
        }       
    }
}
