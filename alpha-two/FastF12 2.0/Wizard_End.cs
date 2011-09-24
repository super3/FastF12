using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FastF12_2._0
{
    public partial class Wizard_End : Form
    {
        public Wizard_End()
        {
            InitializeComponent();
        }

        private void Wizard_End_Load(object sender, EventArgs e)
        {
            //Resize Border Labels
            border.Height = 2;
            border2.Height = 2;
        }

        private void bnBack_Click(object sender, EventArgs e)
        {
            //Open Next Form and Keep Current Location
            Wizard_Start wizard = new Wizard_Start();
            this.Close(); //Close Old Form
            wizard.StartPosition = FormStartPosition.Manual;
            wizard.Location = new Point(this.Location.X, this.Location.Y);
            wizard.Show();   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the Wizard
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
            if (checkThread.Checked) { txtThread.Enabled = true; }
            else { txtThread.Enabled = false; }
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
            //Numeric Only Input
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void txtIdle_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(txtIdle.Text) > 60)
            {
                txtIdle.Text = "60";
            }
        }

        private void txtThread_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Numeric Only Input
            int isNumber = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void txtThread_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(txtThread.Text) > 8)
            {
                txtThread.Text = "8";
            }
        }
    }
}
