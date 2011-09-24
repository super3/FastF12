namespace FastF12
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listQueue = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSetFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetExe = new System.Windows.Forms.Button();
            this.txtBlenderExe = new System.Windows.Forms.TextBox();
            this.btnRender = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFraEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFraStart = new System.Windows.Forms.TextBox();
            this.txtFrame = new System.Windows.Forms.TextBox();
            this.btnAnimation = new System.Windows.Forms.RadioButton();
            this.btnSingle = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbCaution = new System.Windows.Forms.Label();
            this.btnSetDir = new System.Windows.Forms.Button();
            this.txtSaveDir = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lbQueueComp = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbJobPercent = new System.Windows.Forms.Label();
            this.lbCurrJob = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtIdleTime = new System.Windows.Forms.TextBox();
            this.checkIdle = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.lbDescrip = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.listQueue);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.btnSetFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose File(.blend only)";
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Image = global::FastF12.Properties.Resources.down;
            this.btnDown.Location = new System.Drawing.Point(329, 75);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(35, 23);
            this.btnDown.TabIndex = 8;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Image = global::FastF12.Properties.Resources.up;
            this.btnUp.Location = new System.Drawing.Point(289, 75);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(35, 23);
            this.btnUp.TabIndex = 7;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Image = global::FastF12.Properties.Resources.remove;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(289, 46);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button5_Click);
            // 
            // listQueue
            // 
            this.listQueue.FormattingEnabled = true;
            this.listQueue.Items.AddRange(new object[] {
            "None"});
            this.listQueue.Location = new System.Drawing.Point(6, 17);
            this.listQueue.Name = "listQueue";
            this.listQueue.Size = new System.Drawing.Size(278, 95);
            this.listQueue.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::FastF12.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(289, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add New";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(6, 122);
            this.txtFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(278, 20);
            this.txtFile.TabIndex = 4;
            // 
            // btnSetFile
            // 
            this.btnSetFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetFile.Image = global::FastF12.Properties.Resources.folder_files;
            this.btnSetFile.Location = new System.Drawing.Point(289, 120);
            this.btnSetFile.Name = "btnSetFile";
            this.btnSetFile.Size = new System.Drawing.Size(75, 23);
            this.btnSetFile.TabIndex = 9;
            this.btnSetFile.Text = "Set File...";
            this.btnSetFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetFile.UseVisualStyleBackColor = true;
            this.btnSetFile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSetExe);
            this.groupBox2.Controls.Add(this.txtBlenderExe);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Blender.exe";
            // 
            // btnSetExe
            // 
            this.btnSetExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetExe.Image = global::FastF12.Properties.Resources.application;
            this.btnSetExe.Location = new System.Drawing.Point(289, 17);
            this.btnSetExe.Name = "btnSetExe";
            this.btnSetExe.Size = new System.Drawing.Size(75, 23);
            this.btnSetExe.TabIndex = 1;
            this.btnSetExe.Text = "Set Exe";
            this.btnSetExe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetExe.UseVisualStyleBackColor = true;
            this.btnSetExe.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBlenderExe
            // 
            this.txtBlenderExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBlenderExe.Location = new System.Drawing.Point(6, 19);
            this.txtBlenderExe.Margin = new System.Windows.Forms.Padding(2, 5, 5, 5);
            this.txtBlenderExe.Name = "txtBlenderExe";
            this.txtBlenderExe.Size = new System.Drawing.Size(278, 20);
            this.txtBlenderExe.TabIndex = 0;
            // 
            // btnRender
            // 
            this.btnRender.Image = global::FastF12.Properties.Resources.photo;
            this.btnRender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRender.Location = new System.Drawing.Point(412, 211);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(229, 65);
            this.btnRender.TabIndex = 29;
            this.btnRender.Text = "Render!";
            this.btnRender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtFraEnd);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFraStart);
            this.groupBox3.Controls.Add(this.txtFrame);
            this.groupBox3.Controls.Add(this.btnAnimation);
            this.groupBox3.Controls.Add(this.btnSingle);
            this.groupBox3.Location = new System.Drawing.Point(412, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 44);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Render Options";
            // 
            // txtFraEnd
            // 
            this.txtFraEnd.Enabled = false;
            this.txtFraEnd.Location = new System.Drawing.Point(336, 16);
            this.txtFraEnd.Name = "txtFraEnd";
            this.txtFraEnd.Size = new System.Drawing.Size(26, 20);
            this.txtFraEnd.TabIndex = 18;
            this.txtFraEnd.Text = "250";
            this.txtFraEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "to";
            // 
            // txtFraStart
            // 
            this.txtFraStart.Enabled = false;
            this.txtFraStart.Location = new System.Drawing.Point(280, 16);
            this.txtFraStart.Name = "txtFraStart";
            this.txtFraStart.Size = new System.Drawing.Size(26, 20);
            this.txtFraStart.TabIndex = 16;
            this.txtFraStart.Text = "1";
            this.txtFraStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // txtFrame
            // 
            this.txtFrame.Location = new System.Drawing.Point(129, 16);
            this.txtFrame.Name = "txtFrame";
            this.txtFrame.Size = new System.Drawing.Size(26, 20);
            this.txtFrame.TabIndex = 14;
            this.txtFrame.Text = "1";
            this.txtFrame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // btnAnimation
            // 
            this.btnAnimation.AutoSize = true;
            this.btnAnimation.Location = new System.Drawing.Point(165, 17);
            this.btnAnimation.Name = "btnAnimation";
            this.btnAnimation.Size = new System.Drawing.Size(109, 17);
            this.btnAnimation.TabIndex = 15;
            this.btnAnimation.TabStop = true;
            this.btnAnimation.Text = "Render Animation";
            this.btnAnimation.UseVisualStyleBackColor = true;
            this.btnAnimation.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnSingle
            // 
            this.btnSingle.AutoSize = true;
            this.btnSingle.Checked = true;
            this.btnSingle.Location = new System.Drawing.Point(6, 17);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(124, 17);
            this.btnSingle.TabIndex = 13;
            this.btnSingle.TabStop = true;
            this.btnSingle.Text = "Render Single Frame";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 282);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(255, 17);
            this.toolStripStatusLabel2.Text = "For help, support, and updates visit Nystic.com";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel3.Text = "(Click Here)";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lbCaution);
            this.groupBox4.Controls.Add(this.btnSetDir);
            this.groupBox4.Controls.Add(this.txtSaveDir);
            this.groupBox4.Location = new System.Drawing.Point(12, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 58);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save Directory";
            // 
            // lbCaution
            // 
            this.lbCaution.AutoSize = true;
            this.lbCaution.Location = new System.Drawing.Point(27, 39);
            this.lbCaution.Name = "lbCaution";
            this.lbCaution.Size = new System.Drawing.Size(316, 13);
            this.lbCaution.TabIndex = 12;
            this.lbCaution.Text = "Caution: Image Files will be Overwritten with the Same File Names";
            // 
            // btnSetDir
            // 
            this.btnSetDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDir.Image = global::FastF12.Properties.Resources.save;
            this.btnSetDir.Location = new System.Drawing.Point(289, 13);
            this.btnSetDir.Name = "btnSetDir";
            this.btnSetDir.Size = new System.Drawing.Size(75, 23);
            this.btnSetDir.TabIndex = 11;
            this.btnSetDir.Text = "Set Dir...";
            this.btnSetDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetDir.UseVisualStyleBackColor = true;
            this.btnSetDir.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtSaveDir
            // 
            this.txtSaveDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaveDir.Location = new System.Drawing.Point(6, 15);
            this.txtSaveDir.Margin = new System.Windows.Forms.Padding(2, 5, 5, 5);
            this.txtSaveDir.Name = "txtSaveDir";
            this.txtSaveDir.Size = new System.Drawing.Size(278, 20);
            this.txtSaveDir.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.progressBar2);
            this.groupBox5.Controls.Add(this.lbQueueComp);
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Controls.Add(this.lbJobPercent);
            this.groupBox5.Controls.Add(this.lbCurrJob);
            this.groupBox5.Location = new System.Drawing.Point(412, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 96);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Render Progress";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 70);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(356, 18);
            this.progressBar2.TabIndex = 28;
            // 
            // lbQueueComp
            // 
            this.lbQueueComp.AutoSize = true;
            this.lbQueueComp.Location = new System.Drawing.Point(6, 54);
            this.lbQueueComp.Name = "lbQueueComp";
            this.lbQueueComp.Size = new System.Drawing.Size(126, 13);
            this.lbQueueComp.TabIndex = 27;
            this.lbQueueComp.Text = "Queue Completeion: N/A";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 18);
            this.progressBar1.TabIndex = 26;
            // 
            // lbJobPercent
            // 
            this.lbJobPercent.AutoSize = true;
            this.lbJobPercent.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbJobPercent.Location = new System.Drawing.Point(338, 16);
            this.lbJobPercent.Name = "lbJobPercent";
            this.lbJobPercent.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lbJobPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbJobPercent.Size = new System.Drawing.Size(29, 13);
            this.lbJobPercent.TabIndex = 25;
            this.lbJobPercent.Text = "N/A";
            this.lbJobPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCurrJob
            // 
            this.lbCurrJob.AutoSize = true;
            this.lbCurrJob.Location = new System.Drawing.Point(6, 16);
            this.lbCurrJob.Name = "lbCurrJob";
            this.lbCurrJob.Size = new System.Drawing.Size(87, 13);
            this.lbCurrJob.TabIndex = 24;
            this.lbCurrJob.Text = "Current Job: N/A";
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Image = global::FastF12.Properties.Resources.pause;
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPause.Location = new System.Drawing.Point(647, 211);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(65, 65);
            this.btnPause.TabIndex = 30;
            this.btnPause.Text = "Pause";
            this.btnPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::FastF12.Properties.Resources.stop;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(717, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 65);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtIdleTime);
            this.groupBox6.Controls.Add(this.checkIdle);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.comboPriority);
            this.groupBox6.Controls.Add(this.lbDescrip);
            this.groupBox6.Location = new System.Drawing.Point(412, 59);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(370, 44);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Computer Usage";
            // 
            // txtIdleTime
            // 
            this.txtIdleTime.Enabled = false;
            this.txtIdleTime.Location = new System.Drawing.Point(266, 16);
            this.txtIdleTime.Name = "txtIdleTime";
            this.txtIdleTime.Size = new System.Drawing.Size(26, 20);
            this.txtIdleTime.TabIndex = 22;
            this.txtIdleTime.Text = "1";
            this.txtIdleTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // checkIdle
            // 
            this.checkIdle.AutoSize = true;
            this.checkIdle.Location = new System.Drawing.Point(183, 19);
            this.checkIdle.Name = "checkIdle";
            this.checkIdle.Size = new System.Drawing.Size(88, 17);
            this.checkIdle.TabIndex = 21;
            this.checkIdle.Text = "Render after ";
            this.checkIdle.UseVisualStyleBackColor = true;
            this.checkIdle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Priority:";
            // 
            // comboPriority
            // 
            this.comboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Items.AddRange(new object[] {
            "Idle",
            "Normal (Default)",
            "Realtime"});
            this.comboPriority.Location = new System.Drawing.Point(48, 16);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(129, 21);
            this.comboPriority.TabIndex = 20;
            // 
            // lbDescrip
            // 
            this.lbDescrip.AutoSize = true;
            this.lbDescrip.Location = new System.Drawing.Point(294, 20);
            this.lbDescrip.Name = "lbDescrip";
            this.lbDescrip.Size = new System.Drawing.Size(68, 13);
            this.lbDescrip.TabIndex = 23;
            this.lbDescrip.Text = "minute(s) idle";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 304);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "FastF12 v1.4 Beta";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSetExe;
        private System.Windows.Forms.TextBox txtBlenderExe;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnAnimation;
        private System.Windows.Forms.RadioButton btnSingle;
        private System.Windows.Forms.TextBox txtFrame;
        private System.Windows.Forms.TextBox txtFraEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFraStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox listQueue;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSetFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSetDir;
        private System.Windows.Forms.TextBox txtSaveDir;
        private System.Windows.Forms.Label lbCaution;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lbQueueComp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbJobPercent;
        private System.Windows.Forms.Label lbCurrJob;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboPriority;
        private System.Windows.Forms.Label lbDescrip;
        private System.Windows.Forms.CheckBox checkIdle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdleTime;
        private System.Windows.Forms.Timer timer1;
    }
}

