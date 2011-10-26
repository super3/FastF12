using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastF12
{
    public partial class Wizard_Start : Form
    {
        // An editable BlendJob object and Return
        private BlendJob newJob = new BlendJob();
        public BlendJob returnJob
        {
            get
            {
                return newJob;
            }
        }

        public Wizard_Start(ref BlendJob newjob)
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

        // Numeric Only Input
        public void numericOnly(ref KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                // Dunno to include alert or not
                // MessageBox.Show("Only numbers allowed");
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric Only Input
            this.numericOnly(ref e);
        }

        private void txtEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric Only Input
            this.numericOnly(ref e);
        }

        private void rSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rSingle.Checked) { txtEnd.Enabled = false; }
            else { txtEnd.Enabled = true; }
        }

        // http://stackoverflow.com/questions/1046740/how-to-validate-a-string-to-only-allow-alphanumeric-characters-in-it-regex
        public static bool IsAlphaNum(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(char.IsLetter(str[i])) && (!(char.IsNumber(str[i]))))
                    return false;
            }

            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check to see if values are valid
            bool validValues = true;

            // Validate length and alphanumerics of Project Name field
            if (txtName.Text == "")
            {
                MessageBox.Show("You can't leave the Project Name blank.");
                validValues = false;
            }
            else if (txtName.Text.Length > 40)
            {
                MessageBox.Show("Project name too long.");
                validValues = false;
            }
            else if (!IsAlphaNum(txtName.Text))
            {
                MessageBox.Show("Only alphanumeric characters and underscores allowed in Project Name.");
                validValues = false;
            }

            // Validate Frame Start and Frame End
            // GUI Code already checks for only numbers in txtStart and txtEnd
            if (rSingle.Checked && txtStart.Text == "")
            {
                MessageBox.Show("Sorry. You can't leave the Start Frame field blank.");
                validValues = false;
            }
            else if (Int32.Parse(txtStart.Text) <= 0)
            {
                MessageBox.Show("Invalid Start Frame.");
                validValues = false;
            }
            else if (rAnimation.Checked && Int32.Parse(txtEnd.Text) <= 0)
            {
                MessageBox.Show("Invalid End Frame.");
                validValues = false;
            }
            else if (rAnimation.Checked && (txtStart.Text == "" || txtEnd.Text == "End..."))
            {
                MessageBox.Show("Sorry. You can't leave the Start Frame or End Frame field blank.");
                validValues = false;
            }
            else if (rAnimation.Checked && Int32.Parse(txtStart.Text) > Int32.Parse(txtEnd.Text))
            {
                MessageBox.Show("Invalid Start and End Frames.");
                validValues = false;
            }
            // TODO: Limit Number of Max Frames

            // Validate .Blend File Field
            if (txtBlend.Text == "")
            {
                MessageBox.Show("You can't leave the .Blend File blank.");
                validValues = false;
            }
            else if (!File.Exists(txtBlend.Text))
            {
                MessageBox.Show("Sorry. This file does not exist.");
                validValues = false;
            }

            // Validate Output Folder
            if (txtOutput.Text == "")
            {
                MessageBox.Show("You can't leave the Output Folder blank.");
                validValues = false;
            }
            else if (!Directory.Exists(txtOutput.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Output directory does not exist. Create it?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Create Said Directory
                    Directory.CreateDirectory(txtOutput.Text);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Output directory does not exist.");
                    validValues = false;
                }
            }

            // If values are valid pass to object, return DialogResult.OK, and close form
            if (validValues)
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
