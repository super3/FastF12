﻿// Icons from "Jonas Rask Design Icons for Developers" Set

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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.stopBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.trashBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(419, 329);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(494, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Image = global::FastF12.Properties.Resources.stop;
            this.stopBtn.Location = new System.Drawing.Point(437, 230);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(45, 45);
            this.stopBtn.TabIndex = 6;
            this.toolTip1.SetToolTip(this.stopBtn, "Stop");
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // runBtn
            // 
            this.runBtn.Enabled = false;
            this.runBtn.Image = global::FastF12.Properties.Resources.run;
            this.runBtn.Location = new System.Drawing.Point(437, 179);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(45, 45);
            this.runBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.runBtn, "Run/Pause");
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Image = global::FastF12.Properties.Resources.settings;
            this.settingsBtn.Location = new System.Drawing.Point(437, 296);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(45, 45);
            this.settingsBtn.TabIndex = 7;
            this.toolTip1.SetToolTip(this.settingsBtn, "Settings");
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // trashBtn
            // 
            this.trashBtn.Enabled = false;
            this.trashBtn.Image = global::FastF12.Properties.Resources.delete;
            this.trashBtn.Location = new System.Drawing.Point(437, 114);
            this.trashBtn.Name = "trashBtn";
            this.trashBtn.Size = new System.Drawing.Size(45, 45);
            this.trashBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.trashBtn, "Trash");
            this.trashBtn.UseVisualStyleBackColor = true;
            this.trashBtn.Click += new System.EventHandler(this.trashBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Image = global::FastF12.Properties.Resources.edit;
            this.editBtn.Location = new System.Drawing.Point(437, 63);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(45, 45);
            this.editBtn.TabIndex = 3;
            this.toolTip1.SetToolTip(this.editBtn, "Edit");
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Image = global::FastF12.Properties.Resources._new;
            this.newBtn.Location = new System.Drawing.Point(437, 12);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(45, 45);
            this.newBtn.TabIndex = 2;
            this.toolTip1.SetToolTip(this.newBtn, "New");
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 372);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.trashBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.newBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "FastF12";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button trashBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button stopBtn;
    }
}

