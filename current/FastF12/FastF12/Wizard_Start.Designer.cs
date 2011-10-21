namespace FastF12
{
    partial class Wizard_Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard_Start));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.bnBack = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.border2 = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtBlend = new System.Windows.Forms.TextBox();
            this.btnBlend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rAnimation = new System.Windows.Forms.RadioButton();
            this.rSingle = new System.Windows.Forms.RadioButton();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(447, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(342, 377);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // bnBack
            // 
            this.bnBack.Enabled = false;
            this.bnBack.Location = new System.Drawing.Point(262, 377);
            this.bnBack.Name = "bnBack";
            this.bnBack.Size = new System.Drawing.Size(75, 23);
            this.bnBack.TabIndex = 12;
            this.bnBack.Text = "< Back";
            this.bnBack.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(534, 80);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Settings";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(95, 110);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(421, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Untitled 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project Name:";
            // 
            // border2
            // 
            this.border2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.border2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.border2.Location = new System.Drawing.Point(15, 354);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(505, 13);
            this.border2.TabIndex = 9;
            this.border2.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.border.Location = new System.Drawing.Point(-3, 78);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(547, 13);
            this.border.TabIndex = 10;
            this.border.Text = "_________________________________________________________________________________" +
    "_________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Render Job Setup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Output Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = ".Blend File";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(18, 315);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(409, 22);
            this.txtOutput.TabIndex = 10;
            this.txtOutput.Text = "C:\\tmp\\";
            // 
            // btnOutput
            // 
            this.btnOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOutput.Location = new System.Drawing.Point(433, 314);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(83, 23);
            this.btnOutput.TabIndex = 11;
            this.btnOutput.Text = "Browse...";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtBlend
            // 
            this.txtBlend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlend.Location = new System.Drawing.Point(18, 263);
            this.txtBlend.Name = "txtBlend";
            this.txtBlend.Size = new System.Drawing.Size(409, 22);
            this.txtBlend.TabIndex = 8;
            // 
            // btnBlend
            // 
            this.btnBlend.Location = new System.Drawing.Point(433, 262);
            this.btnBlend.Name = "btnBlend";
            this.btnBlend.Size = new System.Drawing.Size(83, 23);
            this.btnBlend.TabIndex = 9;
            this.btnBlend.Text = "Browse...";
            this.btnBlend.UseVisualStyleBackColor = true;
            this.btnBlend.Click += new System.EventHandler(this.btnBlend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rAnimation);
            this.groupBox1.Controls.Add(this.rSingle);
            this.groupBox1.Location = new System.Drawing.Point(122, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Render Type";
            // 
            // rAnimation
            // 
            this.rAnimation.AutoSize = true;
            this.rAnimation.Location = new System.Drawing.Point(12, 43);
            this.rAnimation.Name = "rAnimation";
            this.rAnimation.Size = new System.Drawing.Size(71, 17);
            this.rAnimation.TabIndex = 4;
            this.rAnimation.Text = "Animation";
            this.rAnimation.UseVisualStyleBackColor = true;
            // 
            // rSingle
            // 
            this.rSingle.AutoSize = true;
            this.rSingle.Checked = true;
            this.rSingle.Location = new System.Drawing.Point(12, 20);
            this.rSingle.Name = "rSingle";
            this.rSingle.Size = new System.Drawing.Size(86, 17);
            this.rSingle.TabIndex = 3;
            this.rSingle.TabStop = true;
            this.rSingle.Text = "Single Image";
            this.rSingle.UseVisualStyleBackColor = true;
            this.rSingle.CheckedChanged += new System.EventHandler(this.rSingle_CheckedChanged);
            // 
            // txtStart
            // 
            this.txtStart.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStart.Location = new System.Drawing.Point(7, 19);
            this.txtStart.MaxLength = 5;
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(171, 20);
            this.txtStart.TabIndex = 6;
            this.txtStart.Text = "Start... (Default is 1)";
            this.txtStart.Enter += new System.EventHandler(this.txtStart_Enter);
            this.txtStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStart_KeyPress);
            this.txtStart.Leave += new System.EventHandler(this.txtStart_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEnd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtStart);
            this.groupBox3.Location = new System.Drawing.Point(228, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 84);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frame(s)";
            // 
            // txtEnd
            // 
            this.txtEnd.Enabled = false;
            this.txtEnd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEnd.Location = new System.Drawing.Point(6, 58);
            this.txtEnd.MaxLength = 5;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(172, 20);
            this.txtEnd.TabIndex = 7;
            this.txtEnd.Text = "End...";
            this.txtEnd.Enter += new System.EventHandler(this.txtEnd_Enter);
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnd_KeyPress);
            this.txtEnd.Leave += new System.EventHandler(this.txtEnd_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "to";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FastF12.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(360, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 47);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Wizard_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtBlend);
            this.Controls.Add(this.btnBlend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.border);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.bnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Wizard_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Render Job Wizard - FastF12";
            this.Load += new System.EventHandler(this.Wizard_Start_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button bnBack;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label border2;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtBlend;
        private System.Windows.Forms.Button btnBlend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rAnimation;
        private System.Windows.Forms.RadioButton rSingle;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label6;
    }
}