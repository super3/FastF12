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
    class BlendStatus
    {
        //----------------------------------
        //          Variables
        //----------------------------------
        // See if the BlendJob is currently running
        public bool isRunning;
        private Thread myThread;
            // Make the thread available to kill
        private BlendJob myBlendJob; // Should actually use inheritance here         

        //----------------------------------
        //          Properties
        //----------------------------------
        private int currFrame;
        private int currParts;
        private int totalParts;

        //----------------------------------
        //          Constructor
        //----------------------------------
        public BlendStatus(BlendJob blendjob)
        {
            // Set Default Values
            isRunning = false;
            myThread = null;
            myBlendJob = blendjob;

            currFrame = 0;
            currParts = 0;
            totalParts = 0;
        }

        //----------------------------------
        //          ToString()
        //----------------------------------
        public override string ToString()
        {
            return this.myBlendJob.ProjectName;
        }

        //----------------------------------
        //          Accessors
        //----------------------------------
        public BlendJob getBlendJob() {
            return myBlendJob;
        }
        public void setBlendJob(BlendJob tmp)
        {
            myBlendJob = tmp;
        }

        //----------------------------------
        //          Run Job Methods
        //----------------------------------
        public void run()
        {
            // Start Thread
            myThread = new Thread(DoWork);
            myThread.Start();
            isRunning = true;
        }
        public void pause()
        {
            // Empty 
        }
        public void stop()
        {
            // If Running then Stop
            if (myThread.IsAlive)
            {
                myThread.Abort();
                isRunning = false;
            }
        }

        //----------------------------------
        //          Helper Methods
        //----------------------------------
        private void DoWork()
        {
            // A CMD Shell and Blender Object
            ProcessStartInfo cmd;

            // Shell windows settings and arguments 
            cmd = new ProcessStartInfo(Properties.Settings.Default.BlenderExe, this.myBlendJob.getArgs());
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
                // TODO: Check Output
                // MessageBox.Show(oReader2.ReadLine());
            }
            oReader2.Close();  
        }
    }
}
