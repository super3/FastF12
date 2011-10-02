using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastF12
{
    // Global Enums
    enum RenderType { Single, Animation };
        // (Single) - Single Frame Render
        // (Animation) - Muti-Frame Animation Render

    public class BlenderJob
    {
        // Basic Settings
        private string ProjectName;
        private RenderType RenderType;
        private string sceneName;

        private string blendPath;
        private string outputFolder;

        // Single Settings
        private int selectedFrame;

        // Animation Settings 
        private int currentFrame;
        private int startFrame;
        private int endFrame;

        // File Options
        private string[] RenderFormat = new string[22] { "TGA", "IRIS", "HAMX",
            "JPEG", "MOVIE", "IRIZ", "RAWTGA", "AVIRAW", "AVIJPEG", 
            "PNG", "BMP", "FRAMESERVER", "HDR", "TIFF", "EXR",
            "MULTILAYER", "MPEG", "AVICODEC", "QUICKTIME", "CINEON",
            "DPX", "DDS" };
            // Note: All render formats from HDR onward are not supported
            // by Blender by default. 
        private string fileExt = "JPEG"; //JPEG
        private bool fileExtinName = false;
            // Add the file extension to the end of the file.
        private string fileNaming = "####";

        // Thread and Idle Settings
        private bool idleRendering = false;
        private bool threadsEnabled = false;
        private byte threadCount = 0;

        // Misc Settings
        private bool debugging = false;

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
            str += " -x " + this.fileExtinName;

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
    }
}
