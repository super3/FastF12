//--------------------------------------------------------------------------------------------
//  ______           _    ______  __  ___  
// |  ____|         | |  |  ____|/_ ||__ \ 
// | |__  __ _  ___ | |_ | |__    | |   ) |
// |  __|/ _` |/ __|| __||  __|   | |  / / 
// | |  | (_| |\__ \| |_ | |      | | / /_ 
// |_|   \__,_||___/ \__||_|      |_||____|
//
//--------------------------------------------------------------------------------------------                                        
// Name: FastF12
// Description: A render manager for Blender 3D(blender.org)
// Version: 1.4
// 
// Creation Date: May 22, 2009
// Completion Date: TBA
//
// Author: Shawn Wilkinson(nystic.com) (Alias: super3boy or super3) - Main Contributor 
// Credit: Brent Friedman(brentf.com) (Alias: Computer-Geek) - Programming Support
//         Geekpedia(geekpedia.com) - Idle Time Counter Script (http://tinyurl.com/l4nwhd)
// Offical Website: Nystic.com
#region Blog Posts About FastF12
//    *Fast F12 Beta 1 Released
//          http://nystic.com/blog/2009/06/07/fast-f12-beta-1-released/
//    *FastF12 Render Manager Preview
//          http://nystic.com/blog/2009/06/09/fastf12-render-manager-preview/
//    *FastF12 Development Roadmap v1
//          http://nystic.com/blog/2009/06/12/fastf12-development-roadmap-v1/
//    *Fast F12 v1.1 Released
//          http://nystic.com/blog/2009/06/18/fast-f12-v1-1-released/
//    *Fast F12 v1.2 Released
//          http://nystic.com/blog/2009/06/29/fast-f12-v1-2-released/
//    *Fast F12 v1.3 Beta Released
//          http://nystic.com/blog/2009/07/06/fast-f12-v1-3-beta-released/
//    *FastF12 v1.4 Gets a Redesign
//          http://nystic.com/blog/2009/07/10/fastf12-v1-4-gets-a-redesign/
#endregion
//--------------------------------------------------------------------------------------------      

using System;
using System.IO;
using System.Drawing;
using System.Threading; // Shell
using System.Collections; // Arrays
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Idle Timer

namespace FastF12
{
    public enum RenderType { Frame, Animation };
        // Render options ( Single Frame Render , Animation Render )
   
    public partial class Main : Form
    {
        // Unmanaged function from user32.dll( Idle Timer )
        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        // Struct we'll need to pass to the function( Idle Timer )
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        //----------------------------------
        // Varible List
        //----------------------------------
        public ArrayList queue = new ArrayList();
            //Stores the info for the jobs(BlendFile object)
        public int currJob = 1; 
            //Current Job of the Manager
        public bool killingProcess = false;
            //Lets the rest of the program know the progress
            //was paused or cancelled. 
        public Process BlenderProcess = null;
            //Make the process available to kill
        public Thread BlenderThread = null;
            //Make the thread available to kill
        public int idleTime = 0;
            //System idle time in seconds 
        public ProcessPriorityClass priority = ProcessPriorityClass.Normal;
            //Sets blender.exe priority 
        public bool timerRunning = false;
        public bool paused = false;
        

        //----------------------------------
        // Main Code List
        //----------------------------------
        public Main()
        {
            //Start Form
            InitializeComponent();

            //To-Do: Autoload in last parameters   

            //Pre-filled textboxes for easy testing.
            txtFile.Text = "C:\\Users\\Owner\\Desktop\\render\\blend\\blend.blend";
            txtBlenderExe.Text = "C:\\Program Files (x86)\\Blender Foundation\\Blender\\blender.exe";
            txtSaveDir.Text = "C:\\Users\\Owner\\Desktop\\render\\tmp";

            //Select correct index(Normal) for comboBox1
            comboPriority.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Browse for Blender.exe
            txtBlenderExe.Text = openFile("Blender.exe (blender.exe)|blender.exe");
        }

        private void UpdateListBox()
        {
            //Update the Queue to show job completion
            listQueue.Items.Clear();
            foreach (BlendFile job in queue)
            {
                listQueue.Items.Add(job.ToString(currJob));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listQueue.Items.Contains("None"))
            {
                MessageBox.Show("You don't have any items to render.");
            }
            else
            {
                //Disables/Enables Buttons
                this.btnRender.Enabled = false;
                this.btnPause.Enabled = true;
                this.btnCancel.Enabled = true;
                //Set Priority
                setPriority();
                //Reset GUI
                reset();

                if (!checkIdle.Checked) {
                    DoQueue();
                }
                else {
                    timer1.Enabled = true;
                }
            }
        }

        private void DoWork(object state)
        {
            object[] args = (object[])state;

            ProcessStartInfo cmd;
            if (!paused) { currJob = 1; } //Reset current job
            else { paused = false; } 

            foreach (BlendFile job in queue)
            {
                if (job.Curr == 1)
                {
                    //Shell windows settings and arguments 
                    cmd = new ProcessStartInfo(job.getBlendExe(), job.command());
                    cmd.UseShellExecute = false;
                    cmd.ErrorDialog = true;
                    cmd.CreateNoWindow = true;
                    cmd.RedirectStandardOutput = true;

                    //Read and process shell output
                    Process p = Process.Start(cmd);
                    BlenderProcess = p;
                    p.PriorityClass = priority;

                    StreamReader oReader2 = p.StandardOutput;
                    while (!oReader2.EndOfStream)
                    {
                        MessageBox.Show(oReader2.ReadLine());
                        UpdateStatusText(oReader2.ReadLine(), job);
                    }
                    oReader2.Close();

                    //Increment current job
                    currJob++;
                }    
            }

            //Enable/Disable needed buttons
            EnableButton(btnRender);
        }

        private delegate void DelUpdateStatusText(string text, BlendFile job);

        private delegate void DelEnableButton(Button btn);

        private void UpdateStatusText(string text, BlendFile job)
        {
            if (!InvokeRequired)
            {
                //Only act if a render frame location is passed
                if (text.StartsWith("Part:", System.StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("I found something!");
                }
                if (text.StartsWith("Saved:", System.StringComparison.OrdinalIgnoreCase))
                {
                    //Splits image path off text
                    String path = text.Substring(text.LastIndexOf("Saved:") + 7,
                           text.Length + 1 - text.IndexOf("Time:"));
                    //Splits image extention off path
                    String file = path.Substring(path.LastIndexOf("."));
                    
                    //Finds correct number of procededing zeros to make it a valid blender image
                    String zeroes = "";
                    if( job.Curr >= 1 && job.Curr <= 9 ) { zeroes = "000"; }
                    else if ( job.Curr <= 99 ) { zeroes = "00"; }
                    else if ( job.Curr <= 999 ) { zeroes = "0"; }
                    //Adds correct number of procededing zeros to make it a valid blender image
                    file = "" + zeroes + job.Curr + file;

                    //Clears desired path, saves render, and deletes image from the tmp directory
                    try
                    {
                        File.Delete(job.getDir().Trim() + "\\" + file);
                        File.Copy(path.Trim(), job.getDir().Trim() + "\\" + file);
                        File.Delete(path.Trim());
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }

                    //Display progress based on the RenderType
                    if (job.getType() == RenderType.Frame)
                    {
                        lbCurrJob.Text = "Current Job: 1 of 1";
                        lbJobPercent.Text = "100%";
                        progressBar1.Value = 100;
                    }
                    else
                    {
                        lbCurrJob.Text = "Current Job: " + job.Curr + " of " + job.getEnd() + " Frames";
                        double result = ((double)job.Curr / job.getEnd()) * 100;
                        result = Math.Round(result, 2);
                        lbJobPercent.Text = result + "%";
                        if (result >= 0 && result <= 100) { progressBar1.Value = (int)result; }
                    }
                    
                    //Increment current frame in the job
                    job.Curr++;
                   
                    //Calculate queue completion
                    int TotalCurrent = 0;
                    int TotalEnd = 0;
                    int jobs = 0;
                    foreach (BlendFile jobList in queue)
                    {
                        if (jobList.getType() == RenderType.Frame)
                        {
                            TotalCurrent += jobList.Curr - 1;
                            TotalEnd += 1;
                        }
                        else
                        {
                            TotalCurrent += jobList.Curr - 1;
                            TotalEnd += jobList.getEnd();
                        }
                        jobs++;
                    }

                    //Update labels and progress bars
                    lbQueueComp.Text = "Queue Completeion: " + TotalCurrent + " of " + TotalEnd + " Frames" +
                                  " / " + currJob + " of " + jobs + " Jobs";
                    double result2 = ((double) TotalCurrent / TotalEnd) * 100;
                    int progress = progressBar2.Value;
                    progress += ((int)result2 - progressBar2.Value);
                    if (progress >= 0 && progress <= 100) { progressBar2.Value = (int)progress; }
                }
                else
                {
                    toolStripStatusLabel1.Text = text;
                }
                UpdateListBox();
            }
            else
            {
                Invoke(new DelUpdateStatusText(UpdateStatusText), new object[] { text, job });
            }     
        }


        private void EnableButton(Button btn)
        {
            if (!InvokeRequired && killingProcess != true)
            {
                this.btnRender.Enabled = true;
                this.btnPause.Enabled = false;
                this.btnCancel.Enabled = false;
                //Disable timer if its running on that
                if (checkIdle.Checked) { timer1.Enabled = false; }
                UpdateListBox();
            }
            else if (!InvokeRequired && killingProcess == true)
            {
                //Nothing Yet
            }
            else
            {
                Invoke(new DelEnableButton(EnableButton), new object[] { btn });
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Browse for a .blend file
            txtFile.Text = openFile("*.blend (*.blend)|*.blend");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Declare Varibles
            RenderType option;
            int start, end;

            //Make sure the textboxes are nubmers
            bool text4 = (1 > Convert.ToInt32(txtFrame.Text));
            bool text5 = (1 > Convert.ToInt32(txtFraStart.Text));
            bool text6 = (1 > Convert.ToInt32(txtFraEnd.Text));

            //Make sure the textboxes are not empty
            if (string.IsNullOrEmpty(txtFile.Text) || string.IsNullOrEmpty(txtSaveDir.Text) ||
                string.IsNullOrEmpty(txtFrame.Text) || string.IsNullOrEmpty(txtFraStart.Text) ||
                string.IsNullOrEmpty(txtFraEnd.Text) || text4 || text5 || text6)
            {
                MessageBox.Show("One of your Fields is Empty or Invalid.");
            }

            //Make sure the listbox is not empty
            if (listQueue.Items.Contains("None")) { listQueue.Items.Remove("None"); }

            
            //Get needed infomation based upon the RenderType
            if (btnSingle.Checked) { option = RenderType.Frame; start = Convert.ToInt32(txtFrame.Text); end = 0; }
            else { option = RenderType.Animation; start = Convert.ToInt32(txtFraStart.Text); end = Convert.ToInt32(txtFraEnd.Text); }

            //Add to listbox and Queue
            int index = queue.Add(new BlendFile(txtBlenderExe.Text, txtFile.Text, txtSaveDir.Text, option, start, end));
            listQueue.Items.Add(queue[index]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Set save directory 
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSaveDir.Text = dlg.SelectedPath;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Link to current blog post
            System.Diagnostics.Process.Start("http://nystic.com/blog/2009/07/06/fast-f12-v1-3-beta-released/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Remove an item from the list and Queue
            if (!listQueue.Items.Contains("None"))
            {
                if (listQueue.SelectedIndex >= 0)
                {
                    queue.RemoveAt(listQueue.SelectedIndex);
                    listQueue.Items.RemoveAt(listQueue.SelectedIndex);
                    if (listQueue.Items.Count == 0) { listQueue.Items.Add("None"); }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Enable/Disable needed buttons
            txtFrame.Enabled = true;
            txtFraStart.Enabled = false;
            txtFraEnd.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Enable/Disable needed buttons
            txtFrame.Enabled = false;
            txtFraStart.Enabled = true;
            txtFraEnd.Enabled = true;        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Moves the job up one
            if (!listQueue.Items.Contains("None"))
            {
                //Switch job in listbox
                if (listQueue.SelectedIndex >= 1 && listQueue.SelectedIndex <= (listQueue.Items.Count - 1))
                {
                    int Index = listQueue.SelectedIndex;
                    //Index of selected item
                    object Swap = listQueue.SelectedItem;
                    //Selected Item
                    if ((Swap != null))
                    {
                        //If something is selected...
                        listQueue.Items.RemoveAt(Index);
                        //Remove it
                        listQueue.Items.Insert(Index - 1, Swap);
                        //Add it back in one spot up
                        //Keep this item selected
                        listQueue.SelectedItem = Swap;
                    }

                    //Switch job in Queue
                    BlendFile tmp = (BlendFile) queue[Index];
                    BlendFile tmp2 = (BlendFile)queue[Index - 1];

                    //Swich the jobs key(its for progress notification)
                    tmp.keyup();
                    tmp2.keydown();

                    queue[Index] = queue[Index - 1];
                    queue[Index - 1] = tmp;              
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Moves the job down one
            if (!listQueue.Items.Contains("None"))
            {
                //Switch job in listbox
                if (listQueue.SelectedIndex >= 0 && listQueue.SelectedIndex <= (listQueue.Items.Count - 2))
                {
                    int Index = listQueue.SelectedIndex;
                    //Index of selected item
                    object Swap = listQueue.SelectedItem;
                    //Selected Item
                    if ((Swap != null))
                    {
                        //If something is selected...
                        listQueue.Items.RemoveAt(Index);
                        //Remove it
                        listQueue.Items.Insert(Index + 1, Swap);
                        //Add it back in one spot up
                        //Keep this item selected
                        listQueue.SelectedItem = Swap;
                    }

                    //Switch job in Queue
                    BlendFile tmp = (BlendFile)queue[Index];
                    BlendFile tmp2 = (BlendFile)queue[Index + 1];

                    //Swich the jobs key(its for progress notification)
                    tmp.keydown();
                    tmp2.keyup();

                    queue[Index] = queue[Index + 1];
                    queue[Index + 1] = tmp;    
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Disables/Enables Buttons
            this.btnRender.Enabled = true;
            this.btnPause.Enabled = false;
            this.btnCancel.Enabled = false;
            //Kill blender.exe process
            killBlender();
            //Disable timer if its running on that
            if (checkIdle.Checked) { timer1.Enabled = false; }
            //Reset GUI
            reset();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Kill blender.exe process
            killBlender();
            //Disable timer if its running on that
            if (checkIdle.Checked) { timer1.Enabled = false; }

            if (btnPause.Text == "Pause")
            { 
                btnPause.Text = "Start"; paused = true;
                btnPause.Image = Image.FromHbitmap(Properties.Resources.play.GetHbitmap());
            }
            else
            {
                btnPause.Text = "Pause";
                btnPause.Image = Image.FromHbitmap(Properties.Resources.pause.GetHbitmap());

                if (checkIdle.Checked) { timer1.Enabled = true; }
                else
                {
                    try
                    {
                        var t = new Thread(DoWork);
                        BlenderThread = t;
                        t.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Kill blender.exe process
            killBlender();
            //Make sure it exits
            Application.ExitThread();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Enable/Disable textbox
            if (checkIdle.Checked)
            {
                txtIdleTime.Enabled = true;
            }
            else
            {
                txtIdleTime.Enabled = false;
            }
        }

        //Only allow numbers in the textboxes
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        //-------------------------------------------------------------
        // Functions
        //-------------------------------------------------------------
        private String openFile(String FileFilter)
        {
            //Initialize Open Files Dialog
            var dlg = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = FileFilter
            };

            //Check Result and Set Result to Upload Textbox
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.FileName;
            }
            else
            {
                return null;
            }
        }
        private void reset()
        {
            //Resets Job Progress
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            currJob = 1;
            lbCurrJob.Text = "Current Job: N/A";
            lbJobPercent.Text = "N/A";
            lbQueueComp.Text = "Queue Completeion: N/A";

            //Loops through and resets curr
            foreach (BlendFile job in queue)
            {
                job.Curr = 1;
            }
        }

        private void onlyNumbers(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) != true)
                e.Handled = true; 
        }

        private void killBlender()
        {
            string processName = "blender";
            Process[] processes = Process.GetProcessesByName(processName);

            foreach (Process process in processes)
            {
                if (process.Id == BlenderProcess.Id)
                {
                    process.Kill();
                    BlenderThread.Abort();
                    killingProcess = true;
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Kill blender.exe process
            killBlender();
        }

        private void setPriority()
        {
            if (comboPriority.Text == "Normal (Default)") { priority = ProcessPriorityClass.Normal; }
            else if (comboPriority.Text == "Idle") { priority = ProcessPriorityClass.Idle; }
            else if (comboPriority.Text == "Realtime") { priority = ProcessPriorityClass.RealTime; }
            else { priority = ProcessPriorityClass.Normal; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get the system uptime
            int systemUptime = Environment.TickCount;
            // The tick at which the last input was recorded
            int LastInputTicks = 0;
            // The number of ticks that passed since last input
            int IdleTicks = 0;

            // Set the struct
            LASTINPUTINFO LastInputInfo = new LASTINPUTINFO();
            LastInputInfo.cbSize = (uint)Marshal.SizeOf(LastInputInfo);
            LastInputInfo.dwTime = 0;

            // If we have a value from the function
            if (GetLastInputInfo(ref LastInputInfo))
            {
                // Get the number of ticks at the point when the last activity was seen
                LastInputTicks = (int)LastInputInfo.dwTime;
                // Number of idle ticks = system uptime ticks - number of ticks at last input
                IdleTicks = systemUptime - LastInputTicks;
            }

            // Set the labels; divide by 1000 to transform the milliseconds to seconds
            idleTime = IdleTicks / 1000;
            //label7.Text = idleTime.ToString();

            if (idleTime >= (Convert.ToInt32(txtIdleTime.Text) * 60) && !timerRunning)
            {
                timerRunning = true;

                DoQueue();
            }
            else if (!(idleTime > (Convert.ToInt32(txtIdleTime.Text) * 60))) {
                killBlender(); timerRunning = false;
            }
            else if (timerRunning) { /*Do nothing*/ }
            else
            {
                killBlender();
                timerRunning = false;
            }
        }

        private void DoQueue()
        {
            //Attemts to do Render Job
            try
            {
                var t = new Thread(DoWork);
                BlenderThread = t;
                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Login test = new Login();
            //test.Show();
        }

    }
    
    
}