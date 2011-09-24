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
    public partial class Wizard_Start : Form
    {
        public Wizard_Start()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the Wizard
            this.Close();
        }

        private void Wizard_Start_Load(object sender, EventArgs e)
        {
            //Resize Border Labels
            border2.Height = 2;
            border.Height = 2;
        }

        private void txtStart_Enter(object sender, EventArgs e)
        {
            //Removes "Start..." Text
            if (txtStart.Text == "Start... (Default is 1)") { txtStart.Text = ""; }
        }

        private void txtStart_Leave(object sender, EventArgs e)
        {
            //Resets "Start..." Text if Textbox is empty
            if (txtStart.Text == "") { txtStart.Text = "Start... (Default is 1)"; }
        }

        private void txtEnd_Enter(object sender, EventArgs e)
        {
            //Removes "End..." Text
            if (txtEnd.Text == "End...") { txtEnd.Text = ""; }
        }

        private void txtEnd_Leave(object sender, EventArgs e)
        {
            //Resets "End..." Text if Textbox is empty
            if (txtEnd.Text == "") { txtEnd.Text = "End..."; }
        }

        private void txtStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Numeric Only Input
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Numeric Only Input
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void rSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rSingle.Checked) { txtEnd.Enabled = false; }
            else { txtEnd.Enabled = true; }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Open Next Form and Keep Current Location
            Wizard_End wizard2 = new Wizard_End();
            this.Close(); //Close Old Form
            wizard2.Location = new Point(this.Location.X, this.Location.Y); 
            wizard2.Show();            
        }

        private void btnBlend_Click(object sender, EventArgs e)
        {
            //Browse for a .blend file
            txtBlend.Text = openFile("*.blend (*.blend)|*.blend");
        }

        //Misc. Functions
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

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //Set save directory 
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = dlg.SelectedPath;
            }
        }
    }
}
