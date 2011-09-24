using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastF12_2._0
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void btnGotoSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://nystic.com");
        }

        private void btnGotoForum_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.nystic.com/viewforum.php?f=39");
        }

        private void btnGotoBug_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.nystic.com/viewtopic.php?f=39&t=6780");
        }

        private void btnGotoDownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://nystic.com/download/");
        }

        private void btnGotoYoutube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=oTU0-dGzjn8");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Close the Help Window
            this.Close();
        }

    }
}
