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
    public partial class Wizard_Start : Form
    {
        private BlenderJob newJob = new BlenderJob();
        public BlenderJob returnJob
        {
            get
            {
                return newJob;
            }
        }

        public Wizard_Start(ref BlenderJob newjob)
        {
            // Start Form
            InitializeComponent();

            // Make the BlendJob Object Accessable
            this.newJob = newjob;

            // Set Default DialogResult.Cancel in case the user
            // hits the x button on the form.
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close Wizard
            this.Close();
        }

        private void Wizard_Start_Load(object sender, EventArgs e)
        {
            //Resize Border Labels
            border2.Height = 2;
            border.Height = 2;

            //Change values to reflect object
            txtName.Text = newJob.ProjectName;
            if (newJob.RenderType == RenderType.Single)
            {
                rSingle.Checked = true;
                txtStart.Text = newJob.startFrame.ToString();
            }
            else
            {
                rAnimation.Checked = true;
                txtStart.Text = newJob.startFrame.ToString();
                txtEnd.Text = newJob.endFrame.ToString();
            }
            txtBlend.Text = newJob.blendPath;
            txtOutput.Text = newJob.outputFolder;
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
            // Pass values back to object
            newJob.ProjectName = txtName.Text;
            if (rSingle.Checked == true)
            {
                newJob.RenderType = RenderType.Single;
                newJob.startFrame = Int32.Parse(txtStart.Text);
            }
            else
            {
                newJob.RenderType = RenderType.Animation;
                newJob.startFrame = Int32.Parse(txtStart.Text);
                newJob.endFrame = Int32.Parse(txtEnd.Text);
            }
            newJob.blendPath = txtBlend.Text;
            newJob.outputFolder = txtOutput.Text;

            // Close Form and Pass Control
            this.DialogResult = DialogResult.OK;
            this.Close();
            
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
