namespace CampuStore
{
    partial class LoginForm
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbLoginFoot = new System.Windows.Forms.Label();
            this.checkLogin = new System.Windows.Forms.CheckBox();
            this.lbLoginHead = new System.Windows.Forms.Label();
            this.lbLoginSubHead = new System.Windows.Forms.Label();
            this.lbLoginPass = new System.Windows.Forms.Label();
            this.lbLoginEmail = new System.Windows.Forms.Label();
            this.lbLoginRemember = new System.Windows.Forms.Label();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.linkLabel1);
            this.panelLogin.Controls.Add(this.lbLoginFoot);
            this.panelLogin.Controls.Add(this.checkLogin);
            this.panelLogin.Controls.Add(this.lbLoginHead);
            this.panelLogin.Controls.Add(this.lbLoginSubHead);
            this.panelLogin.Controls.Add(this.lbLoginPass);
            this.panelLogin.Controls.Add(this.lbLoginEmail);
            this.panelLogin.Controls.Add(this.lbLoginRemember);
            this.panelLogin.Controls.Add(this.txtLoginPass);
            this.panelLogin.Controls.Add(this.txtLoginEmail);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Location = new System.Drawing.Point(68, 67);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(344, 424);
            this.panelLogin.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(242, 351);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // lbLoginFoot
            // 
            this.lbLoginFoot.AutoSize = true;
            this.lbLoginFoot.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbLoginFoot.Location = new System.Drawing.Point(63, 351);
            this.lbLoginFoot.Name = "lbLoginFoot";
            this.lbLoginFoot.Size = new System.Drawing.Size(173, 20);
            this.lbLoginFoot.TabIndex = 10;
            this.lbLoginFoot.Text = "Don\'t have an account ?";
            // 
            // checkLogin
            // 
            this.checkLogin.AutoSize = true;
            this.checkLogin.Location = new System.Drawing.Point(69, 233);
            this.checkLogin.Name = "checkLogin";
            this.checkLogin.Size = new System.Drawing.Size(18, 17);
            this.checkLogin.TabIndex = 9;
            this.checkLogin.UseVisualStyleBackColor = true;
            // 
            // lbLoginHead
            // 
            this.lbLoginHead.AutoSize = true;
            this.lbLoginHead.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbLoginHead.Location = new System.Drawing.Point(106, 0);
            this.lbLoginHead.Name = "lbLoginHead";
            this.lbLoginHead.Size = new System.Drawing.Size(130, 50);
            this.lbLoginHead.TabIndex = 1;
            this.lbLoginHead.Text = "Log in";
            // 
            // lbLoginSubHead
            // 
            this.lbLoginSubHead.AutoSize = true;
            this.lbLoginSubHead.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbLoginSubHead.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbLoginSubHead.Location = new System.Drawing.Point(13, 50);
            this.lbLoginSubHead.Name = "lbLoginSubHead";
            this.lbLoginSubHead.Size = new System.Drawing.Size(323, 20);
            this.lbLoginSubHead.TabIndex = 2;
            this.lbLoginSubHead.Text = "Welcome back ! Please log in to your account.";
            // 
            // lbLoginPass
            // 
            this.lbLoginPass.AutoSize = true;
            this.lbLoginPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbLoginPass.Location = new System.Drawing.Point(50, 171);
            this.lbLoginPass.Name = "lbLoginPass";
            this.lbLoginPass.Size = new System.Drawing.Size(73, 20);
            this.lbLoginPass.TabIndex = 3;
            this.lbLoginPass.Text = "Password";
            // 
            // lbLoginEmail
            // 
            this.lbLoginEmail.AutoSize = true;
            this.lbLoginEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbLoginEmail.Location = new System.Drawing.Point(50, 110);
            this.lbLoginEmail.Name = "lbLoginEmail";
            this.lbLoginEmail.Size = new System.Drawing.Size(104, 20);
            this.lbLoginEmail.TabIndex = 4;
            this.lbLoginEmail.Text = "Email Address";
            // 
            // lbLoginRemember
            // 
            this.lbLoginRemember.AutoSize = true;
            this.lbLoginRemember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lbLoginRemember.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbLoginRemember.Location = new System.Drawing.Point(86, 230);
            this.lbLoginRemember.Name = "lbLoginRemember";
            this.lbLoginRemember.Size = new System.Drawing.Size(108, 20);
            this.lbLoginRemember.TabIndex = 5;
            this.lbLoginRemember.Text = "Remember me";
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPass.Location = new System.Drawing.Point(54, 194);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(234, 22);
            this.txtLoginPass.TabIndex = 6;
            this.txtLoginPass.UseSystemPasswordChar = true;
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginEmail.Location = new System.Drawing.Point(54, 133);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(234, 22);
            this.txtLoginEmail.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(54, 272);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(234, 55);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lbLoginHead;
        private System.Windows.Forms.Label lbLoginSubHead;
        private System.Windows.Forms.Label lbLoginPass;
        private System.Windows.Forms.Label lbLoginEmail;
        private System.Windows.Forms.Label lbLoginRemember;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbLoginFoot;
    }
}