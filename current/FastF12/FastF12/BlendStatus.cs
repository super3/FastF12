using System.IO;
using System.Threading;
using System.Diagnostics;

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
        public string lastOutput;

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
            lastOutput = "";

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
                lastOutput = oReader2.ReadLine();
            }
            oReader2.Close();  
        }
    }
}
