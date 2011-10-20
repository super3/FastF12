using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastF12
{
    // Global Enums
    public enum RenderType { Single, Animation };
        // (Single) - Single Frame Render
        // (Animation) - Muti-Frame Animation Render

    public class BlenderJob
    {
        // Basic Settings
        public string ProjectName;
        public RenderType RenderType;
        public string sceneName;

        public string blendPath;
        public string outputFolder;

        // Single Settings
        public int selectedFrame;

        // Animation Settings 
        public int currentFrame;
        public int startFrame;
        public int endFrame;

        // File Options
        public string[] RenderFormat = new string[22] { "TGA", "IRIS", "HAMX",
            "JPEG", "MOVIE", "IRIZ", "RAWTGA", "AVIRAW", "AVIJPEG", 
            "PNG", "BMP", "FRAMESERVER", "HDR", "TIFF", "EXR",
            "MULTILAYER", "MPEG", "AVICODEC", "QUICKTIME", "CINEON",
            "DPX", "DDS" };
            // Note: All render formats from HDR onward are not supported
            // by Blender by default. 
        public string fileExt = "JPEG"; //JPEG
        public bool fileExtinName = false; // Not yet coded
            // Add the file extension to the end of the file. Not added yet
        public string fileNaming = "####";

        // Thread and Idle Settings
        public bool idleRendering = false;
        public int idleDelay = 1; // Delay in Minutes
        public bool threadsEnabled = false;
        public int threadCount = 0;

        // Misc Settings
        public bool debugging = false;

        public BlenderJob()
        {
            // Basic Settings
            this.ProjectName = "Untitled";
            this.RenderType = RenderType.Single;

            this.blendPath = "";
            this.outputFolder = "C:\\tmp\\";

             // Single Settings
            this.selectedFrame = 1; 

            // Animation Settings 
            this.currentFrame = 1; 
            this.startFrame = 1;
            this.endFrame = 250;

              // File Options
            this.fileExt = this.RenderFormat[3]; //JPEG
            this.fileExtinName = false;
            this.fileNaming = "####";

            // Thread and Idle Settings
            this.idleRendering = false;
            this.threadsEnabled = false;
            this.threadCount = 0;

            // Misc Settings
            this.debugging = false;
        }

        public String Run()
        {
            // Usage: blender [-b <dir><file> [-o <dir><file> ][-F <format>][-x [0|1] ]
            // [-t <threads>][-S <name>][-f <frame>][-s<frame> -e <frame> -a]]

            // Run in background command
            string str = " -b ";
            // Add Directory + File
            str += this.blendPath;

            // Add Output Directory 
            str += " -o " + outputFolder;
            // Add File Naming and Type
            str += " -F " + this.fileExt + this.fileNaming;
            if (this.fileExtinName) { str += " -x " + this.fileExtinName; }

            //Add Threads(If Requested)
            if (this.threadsEnabled)
                str += " -t " + this.threadCount ;

            // Add Scene 
            if(this.sceneName != null)
                str += " -S " + this.sceneName;

            // Add Single or Animation
            if (this.RenderType == RenderType.Single)
                str += " -f " + this.selectedFrame;
            else if (this.RenderType == RenderType.Animation)
                str += " -s " + this.startFrame + " -e " + this.endFrame + " -a";
            else
                throw new System.InvalidOperationException("Invalid RenderType");

            // Return command line arguments
            return str;
        }

        public override string ToString()
        {
            return ProjectName;
        }
    }
}
