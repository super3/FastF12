namespace FastF12
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBlender = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.btnGithub = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWiki = new System.Windows.Forms.Button();
            this.btnBug = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPinvoke = new System.Windows.Forms.Button();
            this.btnBrent = new System.Windows.Forms.Button();
            this.btnDesign = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBlenderExe = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBlender);
            this.groupBox1.Controls.Add(this.btnDev);
            this.groupBox1.Controls.Add(this.btnGithub);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Websites";
            // 
            // btnBlender
            // 
            this.btnBlender.Image = global::FastF12.Properties.Resources.blender;
            this.btnBlender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlender.Location = new System.Drawing.Point(17, 55);
            this.btnBlender.Name = "btnBlender";
            this.btnBlender.Size = new System.Drawing.Size(428, 35);
            this.btnBlender.TabIndex = 2;
            this.btnBlender.Text = "Blender";
            this.btnBlender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlender.UseVisualStyleBackColor = true;
            this.btnBlender.Click += new System.EventHandler(this.btnBlender_Click);
            // 
            // btnDev
            // 
            this.btnDev.Image = global::FastF12.Properties.Resources.block;
            this.btnDev.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDev.Location = new System.Drawing.Point(17, 14);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(206, 35);
            this.btnDev.TabIndex = 1;
            this.btnDev.Text = "Main Developer\'s Website";
            this.btnDev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.Image = global::FastF12.Properties.Resources.github_icon;
            this.btnGithub.Location = new System.Drawing.Point(238, 14);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(206, 35);
            this.btnGithub.TabIndex = 0;
            this.btnGithub.Text = "Github ( Source Code)";
            this.btnGithub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGithub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWiki);
            this.groupBox2.Controls.Add(this.btnBug);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Help and Bugs";
            // 
            // btnWiki
            // 
            this.btnWiki.Image = global::FastF12.Properties.Resources.document__pencil;
            this.btnWiki.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWiki.Location = new System.Drawing.Point(16, 17);
            this.btnWiki.Name = "btnWiki";
            this.btnWiki.Size = new System.Drawing.Size(206, 35);
            this.btnWiki.TabIndex = 1;
            this.btnWiki.Text = "FastF12 Wiki";
            this.btnWiki.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWiki.UseVisualStyleBackColor = true;
            this.btnWiki.Click += new System.EventHandler(this.btnWiki_Click);
            // 
            // btnBug
            // 
            this.btnBug.Image = global::FastF12.Properties.Resources.bug;
            this.btnBug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBug.Location = new System.Drawing.Point(238, 17);
            this.btnBug.Name = "btnBug";
            this.btnBug.Size = new System.Drawing.Size(206, 35);
            this.btnBug.TabIndex = 0;
            this.btnBug.Text = "Report a Bug / Issue";
            this.btnBug.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBug.UseVisualStyleBackColor = true;
            this.btnBug.Click += new System.EventHandler(this.btnBug_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPinvoke);
            this.groupBox3.Controls.Add(this.btnBrent);
            this.groupBox3.Controls.Add(this.btnDesign);
            this.groupBox3.Location = new System.Drawing.Point(12, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Special Thanks and Art";
            // 
            // btnPinvoke
            // 
            this.btnPinvoke.Location = new System.Drawing.Point(15, 58);
            this.btnPinvoke.Name = "btnPinvoke";
            this.btnPinvoke.Size = new System.Drawing.Size(428, 35);
            this.btnPinvoke.TabIndex = 3;
            this.btnPinvoke.Text = "Pinvoke Icons";
            this.btnPinvoke.UseVisualStyleBackColor = true;
            this.btnPinvoke.Click += new System.EventHandler(this.btnPinvoke_Click);
            // 
            // btnBrent
            // 
            this.btnBrent.Location = new System.Drawing.Point(16, 17);
            this.btnBrent.Name = "btnBrent";
            this.btnBrent.Size = new System.Drawing.Size(206, 35);
            this.btnBrent.TabIndex = 1;
            this.btnBrent.Text = "Brent Friedman";
            this.btnBrent.UseVisualStyleBackColor = true;
            this.btnBrent.Click += new System.EventHandler(this.btnBrent_Click);
            // 
            // btnDesign
            // 
            this.btnDesign.Location = new System.Drawing.Point(238, 17);
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.Size = new System.Drawing.Size(206, 35);
            this.btnDesign.TabIndex = 0;
            this.btnDesign.Text = "Jonasrask Design";
            this.btnDesign.UseVisualStyleBackColor = true;
            this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowse);
            this.groupBox4.Controls.Add(this.txtBlenderExe);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 52);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Blender.exe Location";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(351, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBlenderExe
            // 
            this.txtBlenderExe.Location = new System.Drawing.Point(15, 19);
            this.txtBlenderExe.Name = "txtBlenderExe";
            this.txtBlenderExe.Size = new System.Drawing.Size(330, 20);
            this.txtBlenderExe.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 356);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings - FastF12";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWiki;
        private System.Windows.Forms.Button btnBug;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBrent;
        private System.Windows.Forms.Button btnDesign;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtBlenderExe;
        private System.Windows.Forms.Button btnBlender;
        private System.Windows.Forms.Button btnPinvoke;
    }
}