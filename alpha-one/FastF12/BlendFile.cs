using System;
using System.Text;
using System.ComponentModel;

namespace FastF12
{
    public class BlendFile
    {
        private static int key = 0;
        private int key2 = key + 1;
        private String BlenderExe; //Path for Blender Installation(Blender.exe)
        private String BlenderFile; //Path for .blend file
        private String SaveDir; // Path for the Directory to Save the Files In
        private RenderType Type; //Render Type(Single Frame or Animation)
        private int Start, _Curr = 1, End;

        [DefaultValue(1)]
        public int Curr 
        {
            get { return _Curr; }
            set { _Curr = value; }
        }
        
        //Start - Start Frame Animation (Also the frame number for a single frame render)
        //Curr - Current Frame (Keeps track of the render progress)
        //End - End Frame of Animation (Not used in sight frame render) 

        public BlendFile(String exe, String file, String dir, RenderType option, int first, int last)
        {
            key++;
            BlenderExe = exe;
            BlenderFile = file;
            SaveDir = dir;
            Type = option;
            Start = first;
            End = last;
        }

        //Accessors (So Not to Violate OOP)
        public int getStart()
        {
            return Start;
        }
        public int getEnd()
        {
            return End;
        }
        public RenderType getType()
        {
            return Type;
        }
        public String getDir()
        {
            return SaveDir;
        }

        //Mutators (So Not to Violate OOP)
        public void keyup()
        {
            if (key2 > 1) { key2--; }
        }
        public void keydown()
        {
            if (key2 < key) { key2++; }
        }

        //Returns Blender.exe location 
        public String getBlendExe()
        {
            return "\"" + BlenderExe + "\"";
        }

        //Returns correct render arguments to Blender.exe
        public String command()
        {
            if (Type == RenderType.Frame) { return "-b \"" + BlenderFile + "\" -f " + Curr; }
            else if (Type == RenderType.Animation) { return "-b \"" + BlenderFile + "\" -e " + End + "-s " + Curr + " -a"; }
            else { return null; }
        }

        //Return object in a readable format for the listbox
        public override String ToString()
        {
            String result = BlenderFile.Substring(BlenderFile.LastIndexOf("\\") + 1);
            if (Type == RenderType.Frame) { result += " / Single / Frame " + Start; }
            else { result += " / Animation / Frame " + Start + " to " + End; }
            return result;
        }
        //Return object in a readable format for the listbox with progress
        public String ToString(int currJob)
        {
            String result = BlenderFile.Substring(BlenderFile.LastIndexOf("\\") + 1);
            if (Type == RenderType.Frame) { result += " / Single / Frame " + Start; }
            else { result += " / Animation / Frame " + Start + " to " + End; }

            if (currJob == key2) { result += " / In Progress "; }
            else if (currJob >= key2) { result += " / Completed "; }

            return result;
        }
    }
}
