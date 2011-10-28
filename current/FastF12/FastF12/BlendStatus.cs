using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;


namespace FastF12
{
    class BlendStatus : BlendJob
    {
        //----------------------------------
        //          Variables
        //----------------------------------
        // See if the BlendJob is currently running
        private bool isRunning
        {
            get { return isRunning; }
            set { isRunning = (bool)value; } // Cast to Make Sure
        }
        private Thread myThread = null;
            // Make the thread available to kill

        //----------------------------------
        //          Properties
        //----------------------------------
        private int currFrame;
        private int currParts;
        private int totalParts;

        //----------------------------------
        //          Constructor
        //----------------------------------
        public BlendStatus()
        {
            isRunning = false;
        }

        //----------------------------------
        //          Run Job Methods
        //----------------------------------
        public void run()
        {
            // Start Thread
            myThread = new Thread(DoWork);
            myThread.Start();
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
            cmd = new ProcessStartInfo(Properties.Settings.Default.BlenderExe, this.getArgs());
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
            }
            oReader2.Close();  
        }
    }
}
