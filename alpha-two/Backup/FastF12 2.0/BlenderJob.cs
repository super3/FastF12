using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastF12_2._0
{
    enum RenderType {Single, Animation};
         // (Single) - Single Frame Render
         // (Animation) - Muti-Frame Animation Render
    enum JobType { Local, Distributed, Client };
        // (Local) - Rendered on User's Current Computer
        // (Distributed) - Send to be Rendered on FastF12's Grid 
        // (Client) - Render and Return to FastF12's Grid

    public class BlenderJob
    {
        //Basic Job Settings
        private String ProjectName = "Untitled 1";
        private RenderType RenderType = RenderType.Animation;
        private JobType JobType = JobType.Local;

        private String blendLocation = "C:\\Users\\Shawn\\Desktop\\test.blend";
        private String outputFolder = "C:\\tmp\\";

        private int startFrame = 1;
        private int endFrame = 5;
        private int currentFrame = 0; 

        //Advanced Options
        private bool idleRendering = false;
        private String fileExt = "JPEG";
        private String fileNaming = "#####";
        private bool threadsEnabled = false;
        private byte threadCount = 1;

        //FastF12 Grid Options

        public BlenderJob() {}

        public String Run() 
        {
            if(this.JobType == JobType.Local) {
               if (this.RenderType == RenderType.Single)
               { 
                   return RenderSingle(" -b "); }
               else
               { 
                   return RenderAnimation(" -b "); }
            }
            else {
                return null;
            }
        }
        private String RenderSingle(String str)
        {
            //Add .Blend Location
            str += this.blendLocation;
            //Add Target Directoty
            str += " -o " + this.outputFolder + "\\" + this.fileNaming;
            //Add File Extention
            str += " -F " + this.fileExt;
            //Add Threads(If Requested)
            if (this.threadsEnabled)
            {
                str += " -t " + this.threadCount;
            }
            //Add Frame to be Rendered
            str += " -f " + this.startFrame;
            
            return str;                
        }
        private String RenderAnimation(String str)
        {
            //Add .Blend Location
            str += this.blendLocation;
            //Add Target Directoty
            str += " -o " + this.outputFolder + "\\" + this.fileNaming;
            //Add File Extention
            str += " -F " + this.fileExt;
            //Add Threads(If Requested)
            if (this.threadsEnabled)
            {
                str += " -t " + this.threadCount;
            }
            //Add Frames to be Rendered
            str += " -s " + this.startFrame + " -e " + this.endFrame + " -a ";

            return str;  
        }

    }
}