using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FastF12
{
    public partial class Wizard_End : Form
    {
        private BlenderJob newJob = new BlenderJob();
        public BlenderJob returnJob
        {
            get
            {
                return newJob;
            }
        }

        public Wizard_End(ref BlenderJob newjob)
        {
            // Start Form
            InitializeComponent();

            // Make the BlendJob Object Accessable
            this.newJob = newjob;

            // Set Default DialogResult.Cancel in case the user
            // hits the x button on the form.
            this.DialogResult = DialogResult.Cancel;
        }

        // Numeric Only Input
        public void numericOnly(ref KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                MessageBox.Show("only numbers allowed");
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Wizard_End_Load(object sender, EventArgs e)
        {
            // Resize Border Labels
            border.Height = 2;
            border2.Height = 2;

            // Sets Default
            cExtStandard.SelectedIndex = 0;
            cExtExtra.SelectedIndex = 0;
            cThread.SelectedIndex = 0;

            // Set Object to Form Controls
            if (newJob.idleRendering)
            {
                checkIdle.Checked = true;
                txtIdle.Text = newJob.idleDelay.ToString();
            }
            if (newJob.threadsEnabled)
            {
                checkThread.Checked = true;
                cThread.SelectedIndex = newJob.threadCount;
            }
            if (newJob.debugging)
            {
                checkDebug.Checked = true;
            }
            txtName.Text = newJob.fileNaming;
            for (int i = 0; i < newJob.RenderFormat.Length; i++)
            {
                if (newJob.fileExt == newJob.RenderFormat[i] && i <= 11)
                {
                    rStandard.Checked = true;
                    cExtStandard.Text = newJob.fileExt;
                    break;
                }
                else if (newJob.fileExt == newJob.RenderFormat[i] && i > 11)
                {
                    rExtra.Checked = true;
                    cExtExtra.Text = newJob.fileExt;
                    break;
                }
            }
        }

        private void bnBack_Click(object sender, EventArgs e)
        {
            // Close Form and Pass Control
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close Wizard
            this.Close();
        }

        private void checkIdle_CheckedChanged(object sender, EventArgs e)
        {
            //Enable disable idle minute(s) textbox
            if (checkIdle.Checked) { txtIdle.Enabled = true; }
            else { txtIdle.Enabled = false; }
        }

        private void rStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (rStandard.Checked) {
                cExtStandard.Enabled = true; cExtExtra.Enabled = false;
                updateLabels(cExtStandard.Text);
            }
            else { 
                cExtStandard.Enabled = false; cExtExtra.Enabled = true;
                updateLabels(cExtExtra.Text);
            } 
        }

        private void checkThread_CheckedChanged(object sender, EventArgs e)
        {
            //Enable disable idle minute(s) textbox
            if (checkThread.Checked) { cThread.Enabled = true; }
            else { cThread.Enabled = false; }
        }

        private void cExtStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLabels("JPEG");
        }

        private void cExtExtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLabels("HDR");
        }
        private void updateLabels(String ext)
        {
            //Change extention label
            if (rStandard.Checked) { ext = cExtStandard.Text; }
            else { ext = cExtExtra.Text; }

            //Update labels
            lbExt.Text = "." + ext;
            //String tmp = txtName.Text;
            lbExtExample.Text = "Example: ####." + ext + "=0001." + ext;

            String tmp = txtName.Text;
            int firstIndex = tmp.IndexOf('#');
            int lastIndex = tmp.LastIndexOf('#');

            if (firstIndex == -1 && lastIndex == -1)
            {
                tmp += "####";
                txtName.Text = tmp;

                firstIndex = tmp.IndexOf('#');
                lastIndex = tmp.LastIndexOf('#');
            }
            else if ( (firstIndex == lastIndex) )
            {
                MessageBox.Show("Invalid File Naming!");
                tmp = "####";
                txtName.Text = tmp;

                firstIndex = tmp.IndexOf('#');
                lastIndex = tmp.LastIndexOf('#');
            }

            int letterPoundFlag = 0;
            int poundLetterFlag = 0;

            int count = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                if ((i > 0) && (tmp[i - 1].ToString() != "#" && tmp[i].ToString() == "#")) { letterPoundFlag++; }
                if ((i < (tmp.Length-1)) && (tmp[i].ToString() == "#" && tmp[i+1].ToString() != "#")) { poundLetterFlag++; }
                if (tmp[i].ToString() == "#") { count++; }
            }

            String zeros = "";
            for(int x=0; x < (count-1); x++)
            {
                zeros += "0"; 
            }
            zeros += "1";


            if (letterPoundFlag > 1 || poundLetterFlag > 1)
            {
                MessageBox.Show("Invalid File Naming!");
                tmp = "####";
                txtName.Text = tmp;

                firstIndex = tmp.IndexOf('#');
                lastIndex = tmp.LastIndexOf('#');
            }

            //Invalid Block
            if (0 == firstIndex && lastIndex == tmp.Length - 1)
            {
                lbExtExample.Text = "Example: " + zeros + "." + ext;
            }
            else if (0 == firstIndex && (lastIndex == (tmp.Length -2)) )
            {
                lbExtExample.Text = "Example: " + zeros +
                    tmp[tmp.Length - 1] + "." + ext;
            }
            else if (0 == firstIndex && !(lastIndex == (tmp.Length - 2)))
            {
                //MessageBox.Show("####tt".Substring(2, 4));
                String huh = tmp.Trim('#');
                lbExtExample.Text = "Example: " + zeros +
                    huh + "." + ext;
            }
            else if (lastIndex == tmp.Length - 1)
            {
                lbExtExample.Text = "Example: " + tmp.Substring(0, firstIndex) + zeros +
                    "." + ext;
            }
            else
            {
                //invalid info
                lbExtExample.Text = "Example: " + tmp.Substring(0, firstIndex) +
                zeros + tmp.Substring(lastIndex, (tmp.Length - 1)) + "." + ext;
            }
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            updateLabels("");
        }

        private void txtIdle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric Only Input
            this.numericOnly(ref e);
        }

        private void txtIdle_Leave(object sender, EventArgs e)
        {

        }

        private void txtThread_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric Only Input
            this.numericOnly(ref e);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Set Form Controls to Object 
            if ( checkIdle.Checked )
            {
                newJob.idleRendering = true;
                newJob.idleDelay = Int32.Parse(txtIdle.Text);
            }
            if ( checkThread.Checked )
            {
                newJob.threadsEnabled = true;
                newJob.threadCount = cThread.SelectedIndex;
            }
            if ( checkDebug.Checked )
            {
                newJob.debugging = true;
            }
            newJob.fileNaming = txtName.Text;
            if (rStandard.Checked)
                newJob.fileExt = cExtStandard.Text;
            else
                newJob.fileExt = cExtExtra.Text;

            // Close Form and Pass Control
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
