using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastF12
{
    public partial class Main : Form
    {
        public ArrayList allJobs = new ArrayList();

        public Main()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Temporary BlenderJob Object
            BlenderJob tmpBlendJob = new BlenderJob();

            // Open Wizard 
            Wizard_Start wizard_start = new Wizard_Start(ref tmpBlendJob); // Pass by reference. Yay!

            // Show wizard as a modal dialog and determine if DialogResult = OK.
            if (wizard_start.ShowDialog(this) == DialogResult.OK)
            {
                // Get Back Passed Object
                tmpBlendJob = wizard_start.returnJob;

                // Add To List
                allJobs.Add(tmpBlendJob);
                listBox1.Items.Add(tmpBlendJob.ProjectName);

                // Debug
                MessageBox.Show(tmpBlendJob.Run()); 
            }
            else
            {
                // It was cancelled. 
            }
            wizard_start.Dispose();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // Same as newBtn
        }
    }
}
