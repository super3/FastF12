using System;
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
        public bool isRunning; // See if the BlendJob is currently running
        public string lastOutput; // Last command line output
        private Thread myThread; // Make the thread available to kill
        private BlendJob myBlendJob; // Should actually use inheritance here  


        //----------------------------------
        //           Status
        //----------------------------------
        private int currFrame;
        public double currParts;
        public double totalParts;

        /// <summary>
        /// BlenderStatus Constructor. Sets Default Values. 
        /// </summary>
        /// <param name="blendjob">Actual BlendJob with all the render info.</param>
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

        /// <summary>
        /// Overides ToString() and returns the project name
        /// <remarks>
        /// So the project name will show up the in listbox item text property.
        /// </remarks>
        /// </summary>
        public override string ToString()
        {
            return this.myBlendJob.ProjectName;
        }

        //----------------------------------
        //      Accessors and Mutators
        //----------------------------------
        public BlendJob getBlendJob() {
            return myBlendJob;
        }
        public void setBlendJob(BlendJob tmp)
        {
            myBlendJob = tmp;
        }

        public int percentDone()
        {
            if (myBlendJob.RenderType == RenderType.Single)
            {
                if (totalParts != 0)
                {
                    return (int)((currParts / totalParts) * 100);
                }
            }
            else
            {
                if (totalParts != 0)
                {
                    int totalFrames = (myBlendJob.endFrame - myBlendJob.startFrame) + 1;
                    return (int)((currParts / (totalParts * totalFrames)) * 100);
                }
            }

            return 0;
   
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
           // TODO
        }
        public void stop()
        {
            // Clear Variables
            isRunning = false;
            currFrame = 0;
            currParts = 0;
            totalParts = 0;

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
            cmd = new ProcessStartInfo(Properties.Settings.Default.BlenderExe, this.myBlendJob.getArgs());
            //MessageBox.Show(this.myBlendJob.getArgs());
            cmd.UseShellExecute = false;
            cmd.ErrorDialog = true;
            cmd.CreateNoWindow = true;
            cmd.RedirectStandardOutput = true;

            // Read and process shell output
            Process p = Process.Start(cmd);

            // Debug
            string debugPath = this.myBlendJob.outputFolder + "\\" + this.myBlendJob.ProjectName + "-debug.txt";
            string lottaDashes = "-----------------------------------------------------------------"; // bunch of dashes for formatting
            if (this.myBlendJob.debugging)
                System.IO.File.AppendAllText(@debugPath, Environment.NewLine+ lottaDashes + Environment.NewLine + "Render Started at " + DateTime.Now + Environment.NewLine);

            // Output for Debug
            StreamReader oReader2 = p.StandardOutput;
            while (!oReader2.EndOfStream)
            {
                // Set lastOutput for string processing
                lastOutput = oReader2.ReadLine();

                // Debug
                if (this.myBlendJob.debugging)      
                    System.IO.File.AppendAllText(@debugPath, (lastOutput+Environment.NewLine));

                // Uses lastOutput for operations
                if (lastOutput.StartsWith("Fra:", System.StringComparison.OrdinalIgnoreCase))
                {
                    // Use the power of SCOPES to reuse start and end local vars
                    {
                        // Get Indexs and Set Current Frame
                        int start = lastOutput.IndexOf("Fra:") + "Fra:".Length;
                        int end = lastOutput.IndexOf("Mem:") - "Mem:".Length;
                        currFrame = int.Parse(lastOutput.Substring(start, end));
                    }
                    {
                        // Get Index and Set Current Parts
                        int start = lastOutput.IndexOf("Part ");
                        // If something is found
                        if (start != -1)
                        {
                            // Add this to crop out "Part "
                            start += "Part ".Length;
                            string parts = lastOutput.Substring(start);
                            parts = parts.Trim();
                            string[] parts2 = parts.Split('-');
                            currParts += 1;
                            totalParts = double.Parse(parts2[1]); 
                        }
                        
                    }
                }
                else if (lastOutput == "Blender quit")
                {
                    // Kill the thread to make sure
                    stop();
                }
                else
                {
                    // Unrecognised or Disposable Output
                    // Do Nothing
                }
            }
            // Close StreamReader
            oReader2.Close();  
        }
    }
}
