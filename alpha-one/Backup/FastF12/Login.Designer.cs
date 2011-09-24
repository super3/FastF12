namespace FastF12
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.boxRem = new System.Windows.Forms.CheckBox();
            this.boxTos = new System.Windows.Forms.CheckBox();
            this.lbRegPass = new System.Windows.Forms.Label();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.lbRegUser = new System.Windows.Forms.Label();
            this.txtRegUser = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbRegEmail = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.boxUpdate = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.boxRem);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.lbPass);
            this.groupBox2.Controls.Add(this.txtPass);
            this.groupBox2.Controls.Add(this.lbUser);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 270);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Login";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnRegister);
            this.groupBox3.Controls.Add(this.boxUpdate);
            this.groupBox3.Controls.Add(this.lbRegEmail);
            this.groupBox3.Controls.Add(this.txtRegEmail);
            this.groupBox3.Controls.Add(this.boxTos);
            this.groupBox3.Controls.Add(this.lbRegUser);
            this.groupBox3.Controls.Add(this.lbRegPass);
            this.groupBox3.Controls.Add(this.txtRegUser);
            this.groupBox3.Controls.Add(this.txtRegPass);
            this.groupBox3.Location = new System.Drawing.Point(402, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 270);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Registration";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(6, 37);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(358, 38);
            this.txtUser.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(6, 16);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(84, 18);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Username:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(6, 99);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(358, 38);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(6, 78);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(82, 18);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 176);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(358, 41);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // boxRem
            // 
            this.boxRem.AutoSize = true;
            this.boxRem.Location = new System.Drawing.Point(6, 149);
            this.boxRem.Name = "boxRem";
            this.boxRem.Size = new System.Drawing.Size(95, 17);
            this.boxRem.TabIndex = 4;
            this.boxRem.Text = "Remember Me";
            this.boxRem.UseVisualStyleBackColor = true;
            // 
            // boxTos
            // 
            this.boxTos.AutoSize = true;
            this.boxTos.Location = new System.Drawing.Point(6, 189);
            this.boxTos.Name = "boxTos";
            this.boxTos.Size = new System.Drawing.Size(114, 17);
            this.boxTos.TabIndex = 13;
            this.boxTos.Text = "I agree to the TOS";
            this.boxTos.UseVisualStyleBackColor = true;
            // 
            // lbRegPass
            // 
            this.lbRegPass.AutoSize = true;
            this.lbRegPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegPass.Location = new System.Drawing.Point(3, 69);
            this.lbRegPass.Name = "lbRegPass";
            this.lbRegPass.Size = new System.Drawing.Size(82, 18);
            this.lbRegPass.TabIndex = 9;
            this.lbRegPass.Text = "Password:";
            // 
            // txtRegPass
            // 
            this.txtRegPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPass.Location = new System.Drawing.Point(6, 90);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.Size = new System.Drawing.Size(358, 29);
            this.txtRegPass.TabIndex = 10;
            this.txtRegPass.UseSystemPasswordChar = true;
            // 
            // lbRegUser
            // 
            this.lbRegUser.AutoSize = true;
            this.lbRegUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegUser.Location = new System.Drawing.Point(6, 16);
            this.lbRegUser.Name = "lbRegUser";
            this.lbRegUser.Size = new System.Drawing.Size(144, 18);
            this.lbRegUser.TabIndex = 7;
            this.lbRegUser.Text = "Desired Username:";
            // 
            // txtRegUser
            // 
            this.txtRegUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUser.Location = new System.Drawing.Point(6, 37);
            this.txtRegUser.Name = "txtRegUser";
            this.txtRegUser.Size = new System.Drawing.Size(358, 29);
            this.txtRegUser.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(358, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Forget that, just let me use local rendering.";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lbRegEmail
            // 
            this.lbRegEmail.AutoSize = true;
            this.lbRegEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegEmail.Location = new System.Drawing.Point(6, 122);
            this.lbRegEmail.Name = "lbRegEmail";
            this.lbRegEmail.Size = new System.Drawing.Size(52, 18);
            this.lbRegEmail.TabIndex = 11;
            this.lbRegEmail.Text = "Email:";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEmail.Location = new System.Drawing.Point(6, 143);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(358, 29);
            this.txtRegEmail.TabIndex = 12;
            // 
            // boxUpdate
            // 
            this.boxUpdate.AutoSize = true;
            this.boxUpdate.Location = new System.Drawing.Point(122, 189);
            this.boxUpdate.Name = "boxUpdate";
            this.boxUpdate.Size = new System.Drawing.Size(242, 17);
            this.boxUpdate.TabIndex = 14;
            this.boxUpdate.Text = "Keep me updated on new releases and news.";
            this.boxUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(6, 223);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(358, 41);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 294);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "FastF12 v1.4 Beta";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox boxRem;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbRegEmail;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.CheckBox boxTos;
        private System.Windows.Forms.Label lbRegUser;
        private System.Windows.Forms.Label lbRegPass;
        private System.Windows.Forms.TextBox txtRegUser;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox boxUpdate;
    }
}