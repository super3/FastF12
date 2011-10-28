using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
// Shell Scripting
using System.Diagnostics;
// Shell Scripting
using System.Runtime.InteropServices;
// ObjectsArrays

namespace FastF12
{
    public partial class Main : Form
    {
        //----------------------------------
        //          Varible List            
        //----------------------------------
        public Thread currThread = null;
            // Make the thread available to kill
        private BlendJob queue = null;
             // Stores a temporary BlendJob Object 
        private string blendExeLoc = Properties.Settings.Default.BlenderExe;
              // Blender.exe Location

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
                listBox1.Items.Add(tmpBlend);
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
                BlendJob editJob = (BlendJob)listBox1.SelectedItem;
                if (edit_BlendJob(ref editJob))
                {
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
            if (listBox1.SelectedItem != null)
            {
                editBtn.Enabled = true;
                trashBtn.Enabled = true;
                runBtn.Enabled = true;
                stopBtn.Enabled = true;
            }
            else
            {
                editBtn.Enabled = false;
                trashBtn.Enabled = false;
                runBtn.Enabled = true;
                stopBtn.Enabled = true;
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
                    queue = (BlendJob)listBox1.SelectedItem;
                    var t = new Thread(DoWork);
                    currThread = t;
                    t.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //----------------------------------
        //        Run Job Functions
        //----------------------------------

        private void DoWork()
        {
            // Change Icon
            runBtn.Image = (System.Drawing.Image)(Properties.Resources.pause);

            // A CMD Shell and Blender Object
            ProcessStartInfo cmd;

            // Shell windows settings and arguments 
            cmd = new ProcessStartInfo(this.blendExeLoc, queue.getArgs());
            MessageBox.Show(queue.getArgs());
            cmd.UseShellExecute = false;
            cmd.ErrorDialog = true;
            cmd.CreateNoWindow = true;
            cmd.RedirectStandardOutput = true;

            // Read and process shell output
            Process p = Process.Start(cmd);

            // Output for Debug
            StreamReader oReader2 = p.StandardOutput;
            while (!oReader2.EndOfStream)
            {
                //Debug: MessageBox.Show(oReader2.ReadLine());
                toolStripStatusLabel1.Text = oReader2.ReadLine();
            }
            oReader2.Close();
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
    }
}
