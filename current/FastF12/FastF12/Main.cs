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
        // All currently loaded BlenderJobs.
        // Syncs with listBox1.
        public ArrayList allJobs = new ArrayList();

        public Main()
        {
            InitializeComponent();
        }

        // Launches Wizard_Start.cs and Sets Completed Object to Reference.
        private void start_wizard(ref BlenderJob tmpBlendJob)
        {
            // Open Wizard 
            Wizard_Start wizard = new Wizard_Start(ref tmpBlendJob); // Pass by reference. Yay!

            // Show wizard as a modal dialog and determine if DialogResult = OK.
            if (wizard.ShowDialog(this) == DialogResult.OK)
            {
                // Get Back Passed Object
                tmpBlendJob = wizard.returnJob;
            }
            else
            {
                // It was cancelled. 
            }

            // Clean-up and Return Location
            wizard.Dispose();
        }

        // Launches Wizard_End.cs and Sets Completed Object to Reference.
        private void end_wizard(ref BlenderJob tmpBlendJob)
        {
            // Open Wizard 
            Wizard_End wizard = new Wizard_End(ref tmpBlendJob); // Pass by reference. Yay!

            // Show wizard as a modal dialog and determine if DialogResult = OK.
            if (wizard.ShowDialog(this) == DialogResult.OK)
            {
                // Get Back Passed Object
                tmpBlendJob = wizard.returnJob;
            }
            else
            {
                // It was cancelled. 
            }

            // Clean-up
            wizard.Dispose();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // New BlenderJob Object
            BlenderJob tmpBlend = new BlenderJob();

            // Launch Wizard_Start and Return Filled Object
            start_wizard(ref tmpBlend);
            end_wizard(ref tmpBlend);

            // Add to GUI and Loaded BlenderJobs
            allJobs.Add(tmpBlend);
            listBox1.Items.Add(tmpBlend.ProjectName);
        }
    }
}
