using System;
using System.Windows.Forms;

namespace FastF12
{
    public partial class Main : Form
    {
        //----------------------------------
        //          Varible List            
        //----------------------------------
        private BlendStatus queue = null;
             // Stores a temporary BlendJob Object 

        //----------------------------------
        //           Main Function
        //----------------------------------
        public Main()
        {
            InitializeComponent();
        }

        //----------------------------------
        //         Helper Functions
        //----------------------------------

        // Launches Wizard_Start.cs and Sets Completed Object to Reference.
        private DialogResult start_wizard(ref BlendJob tmpBlendJob)
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
        private DialogResult end_wizard(ref BlendJob tmpBlendJob)
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

        // Edit Passed BlendJob Object. If cancelled return false
        private bool edit_BlendJob(ref BlendJob tmpBlend)
        {
            // New BlendJob Object and DialogResults for Option Checking
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
                    return false;
                }
                end_wiz = end_wizard(ref tmpBlend);
                if (end_wiz == DialogResult.Cancel)
                {
                    return false;
                }
            } while (start_wiz == DialogResult.Retry || end_wiz == DialogResult.Retry);
            return true;
        }

        private void UpdateListBoxItem(ListBox lb, object item)
        {
            int index = lb.Items.IndexOf(item);
            int currIndex = lb.SelectedIndex;
            lb.BeginUpdate();
            try
            {
                lb.ClearSelected();
                lb.Items[index] = item;
                lb.SelectedIndex = currIndex;
            }
            finally
            {
                lb.EndUpdate();
            }
        }

        //----------------------------------
        //           Form Events
        //----------------------------------
        private void newBtn_Click(object sender, EventArgs e)
        {
            // New BlendJob Object and DialogResults for Option Checking
            BlendJob tmpBlend = new BlendJob();

            // Add to GUI and Loaded BlendJobs if no cancel has been called
            if (edit_BlendJob(ref tmpBlend))
            {
                listBox1.Items.Add(new BlendStatus(tmpBlend));
            }
        }

        private void trashBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Make sure user doesn't accidentally erase a BlendJob
                DialogResult dialogResult = MessageBox.Show("Delete this BlendJob?", "Delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Edit Selected BlendJob
                BlendStatus editJob = (BlendStatus)listBox1.SelectedItem;
                BlendJob tmpBlendJob = editJob.getBlendJob();
                if (edit_BlendJob(ref tmpBlendJob))
                {
                    editJob.setBlendJob(tmpBlendJob);
                    UpdateListBoxItem(listBox1, editJob);
                }
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            // Launch Settings Form
            Settings settings = new Settings();
            settings.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If there is a selected item
            if (listBox1.SelectedItem != null)
            {
                // Set Buttons Enabled
                editBtn.Enabled = true;
                trashBtn.Enabled = true;
                runBtn.Enabled = true;
                stopBtn.Enabled = true;

                // Set runBtn Run or Pause Image if job is running
                if (((BlendStatus)listBox1.SelectedItem).isRunning)
                    runBtn.Image = (System.Drawing.Image)(Properties.Resources.pause);
                else
                    runBtn.Image = (System.Drawing.Image)(Properties.Resources.run);
            }
            else
            {
                // Set Buttons Disabled
                editBtn.Enabled = false;
                trashBtn.Enabled = false;
                runBtn.Enabled = true;
                stopBtn.Enabled = true;

                // Set runBtn to Run Image
                runBtn.Image = (System.Drawing.Image)(Properties.Resources.run);
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            // Test and Warn User About Missing Blender.exe
            if (Properties.Settings.Default.BlenderExe == "")
            {
                // Warn
                MessageBox.Show("Please add a Blender.exe location");
                // Launch Settings.cs
                Settings form = new Settings();
                form.Show();
            }
            // Else Just Run the Selected Job
            else
            {
                try
                {
                    // Set runBtn to Pause image
                    runBtn.Image = (System.Drawing.Image)(Properties.Resources.pause);
                    // Run selected job
                    queue = (BlendStatus)listBox1.SelectedItem;
                    queue.run();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // Open up render output folder
            BlendJob job = (BlendJob)listBox1.SelectedItem;
            string myPath = @job.outputFolder;
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            // Stop selected job
            if ( ((BlendStatus)listBox1.SelectedItem).isRunning )
            {
                ((BlendStatus)listBox1.SelectedItem).stop();
                runBtn.Image = (System.Drawing.Image)(Properties.Resources.run);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (((BlendStatus)listBox1.SelectedItem).isRunning)
                {
                    toolStripStatusLabel1.Text = ((BlendStatus)listBox1.SelectedItem).lastOutput;
                }
                else
                {
                    int numRunning = 0;
                    foreach (BlendStatus o in listBox1.Items)
                    {
                        if (o.isRunning)
                            numRunning++;
                    }

                    if (numRunning == 0)
                    {
                        toolStripStatusLabel1.Text = "Ready";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = numRunning + " job(s) running.";
                    }
                }
            }
        }
    }
}
