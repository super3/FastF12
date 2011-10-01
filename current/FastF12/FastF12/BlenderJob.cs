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
        private string[] ProjectName = "Untitled";
        private RenderType RenderType = RenderType.Single;
        private string sceneName = ""; 

        private string blendPath = "";
        private string outputFolder = "C:\\tmp\\";

        // Single Settings
        private int selectedFrame = 1; 

        // Animation Settings 
        private int currentFrame = 1; 
        private int startFrame = 1;
        private int jumpFrame = 0;
            // Render every x frames.
        private int endFrame = 250;

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
            //Should actually instantiate the class vars here.  
        }

        public String Run()
        {
            string str = " -b ";
            if (this.RenderType == RenderType.Single)
                str += RenderSingle();
            else if (this.RenderType == RenderType.Animation)
                str += RenderAnimation();
            else
                str += "";
            return str;
        }

        private String RenderSingle()
        {
            // TODO
            return "";
        }

        private String RenderAnimation()
        {
            // TODO
            return "";
        }
    }
}
