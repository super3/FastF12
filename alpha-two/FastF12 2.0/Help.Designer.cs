namespace FastF12_2._0
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGotoBug = new System.Windows.Forms.Button();
            this.btnGotoForum = new System.Windows.Forms.Button();
            this.btnGotoSite = new System.Windows.Forms.Button();
            this.btnGotoDownload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGotoYoutube = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(510, 310);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://1.nystic.com/Nx/embed.html", System.UriKind.Absolute);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGotoBug);
            this.groupBox1.Controls.Add(this.btnGotoForum);
            this.groupBox1.Controls.Add(this.btnGotoSite);
            this.groupBox1.Controls.Add(this.btnGotoDownload);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 122);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Help and Support";
            // 
            // btnGotoBug
            // 
            this.btnGotoBug.Image = global::FastF12_2._0.Properties.Resources.bugArrow;
            this.btnGotoBug.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGotoBug.Location = new System.Drawing.Point(6, 54);
            this.btnGotoBug.Name = "btnGotoBug";
            this.btnGotoBug.Size = new System.Drawing.Size(255, 29);
            this.btnGotoBug.TabIndex = 30;
            this.btnGotoBug.Text = "Report a Bug/Crash";
            this.btnGotoBug.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGotoBug.UseVisualStyleBackColor = true;
            this.btnGotoBug.Click += new System.EventHandler(this.btnGotoBug_Click);
            // 
            // btnGotoForum
            // 
            this.btnGotoForum.Image = global::FastF12_2._0.Properties.Resources.chainArrow;
            this.btnGotoForum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGotoForum.Location = new System.Drawing.Point(132, 19);
            this.btnGotoForum.Name = "btnGotoForum";
            this.btnGotoForum.Size = new System.Drawing.Size(129, 29);
            this.btnGotoForum.TabIndex = 29;
            this.btnGotoForum.Text = "Goto Support Forum";
            this.btnGotoForum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGotoForum.UseVisualStyleBackColor = true;
            this.btnGotoForum.Click += new System.EventHandler(this.btnGotoForum_Click);
            // 
            // btnGotoSite
            // 
            this.btnGotoSite.Image = global::FastF12_2._0.Properties.Resources.chainArrow;
            this.btnGotoSite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGotoSite.Location = new System.Drawing.Point(6, 19);
            this.btnGotoSite.Name = "btnGotoSite";
            this.btnGotoSite.Size = new System.Drawing.Size(120, 29);
            this.btnGotoSite.TabIndex = 28;
            this.btnGotoSite.Text = "Goto Official Site";
            this.btnGotoSite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGotoSite.UseVisualStyleBackColor = true;
            this.btnGotoSite.Click += new System.EventHandler(this.btnGotoSite_Click);
            // 
            // btnGotoDownload
            // 
            this.btnGotoDownload.Image = global::FastF12_2._0.Properties.Resources.driveDownload;
            this.btnGotoDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGotoDownload.Location = new System.Drawing.Point(6, 87);
            this.btnGotoDownload.Name = "btnGotoDownload";
            this.btnGotoDownload.Size = new System.Drawing.Size(255, 29);
            this.btnGotoDownload.TabIndex = 27;
            this.btnGotoDownload.Text = "Download Latest Version";
            this.btnGotoDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGotoDownload.UseVisualStyleBackColor = true;
            this.btnGotoDownload.Click += new System.EventHandler(this.btnGotoDownload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGotoYoutube);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(285, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 122);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credit";
            // 
            // btnGotoYoutube
            // 
            this.btnGotoYoutube.AutoSize = true;
            this.btnGotoYoutube.Location = new System.Drawing.Point(100, 103);
            this.btnGotoYoutube.Name = "btnGotoYoutube";
            this.btnGotoYoutube.Size = new System.Drawing.Size(67, 13);
            this.btnGotoYoutube.TabIndex = 44;
            this.btnGotoYoutube.TabStop = true;
            this.btnGotoYoutube.Text = "clicking here";
            this.btnGotoYoutube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGotoYoutube_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Blender Logo - http://blender.org/\r\nButton Icons  -  http://www.pinvoke.com/\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "If the YouTube page does not display correctly,\r\n you may go to it by\r\n";
            // 
            // button6
            // 
            this.button6.Image = global::FastF12_2._0.Properties.Resources.cross;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(12, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(510, 29);
            this.button6.TabIndex = 40;
            this.button6.Text = "Close";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Help";
            this.Text = "Help/Credits";
            this.Load += new System.EventHandler(this.Help_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btnGotoYoutube;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGotoDownload;
        private System.Windows.Forms.Button btnGotoForum;
        private System.Windows.Forms.Button btnGotoSite;
        private System.Windows.Forms.Button btnGotoBug;
    }
}