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
        private DialogResult start_wizard(ref BlenderJob tmpBlendJob)
        {
            // Open Wizard 
            Wizard_Start wizard = new Wizard_Start(ref tmpBlendJob); // Pass by reference. Yay!

            // Show wizard as a modal dialog and determine if DialogResult = OK.
            DialogResult result = wizard.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                // Set Passed Object
                tmpBlendJob = wizard.returnJob;
            }
            
            // Clean-up and Return
            wizard.Dispose();
            return result;
        }

        // Launches Wizard_End.cs and Sets Completed Object to Reference.
        private DialogResult end_wizard(ref BlenderJob tmpBlendJob)
        {
            // Open Wizard 
            Wizard_End wizard = new Wizard_End(ref tmpBlendJob); // Pass by reference. Yay!

            // Show wizard as a modal dialog and determine if DialogResult = OK.
            DialogResult result = wizard.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                // Set Passed Object
                tmpBlendJob = wizard.returnJob;
            }

            // Clean-up and Return
            wizard.Dispose();
            return result;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // New BlenderJob Object and DialogResults for Option Checking
            BlenderJob tmpBlend = new BlenderJob();
            DialogResult start_wiz = new DialogResult();
            DialogResult end_wiz = new DialogResult();

            // Launch Wizard_Start and Return Filled Object
            // Repeats if user hits back button on Wizard_End.
            // Cancels everything if user hits cancel button on either form.
            do
            {
                start_wiz = start_wizard(ref tmpBlend);
                if (start_wiz == DialogResult.Cancel)
                {
                    // If Cancelled Break Loop
                    break;
                }
                end_wiz = end_wizard(ref tmpBlend);
                if (end_wiz == DialogResult.Cancel)
                {
                    // If Cancelled Break Loop and Set Object to Null
                    break;
                }
            } while (start_wiz == DialogResult.Retry || end_wiz == DialogResult.Retry);


            // Add to GUI and Loaded BlenderJobs if no cancel has been called
            if (start_wiz != DialogResult.Cancel && end_wiz != DialogResult.Cancel)
            {
                allJobs.Add(tmpBlend);
                listBox1.Items.Add(tmpBlend.ProjectName);
            }
        }
    }
}
