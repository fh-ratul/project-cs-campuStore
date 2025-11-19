namespace CampuStore
{
    partial class EditInfo
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
            this.lbEdithead = new System.Windows.Forms.Label();
            this.lbEditName = new System.Windows.Forms.Label();
            this.lbEditEmail = new System.Windows.Forms.Label();
            this.lbEditPhone = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEdithead
            // 
            this.lbEdithead.AutoSize = true;
            this.lbEdithead.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdithead.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbEdithead.Location = new System.Drawing.Point(149, 24);
            this.lbEdithead.Name = "lbEdithead";
            this.lbEdithead.Size = new System.Drawing.Size(302, 38);
            this.lbEdithead.TabIndex = 0;
            this.lbEdithead.Text = "Edit Your Information";
            this.lbEdithead.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbEditName
            // 
            this.lbEditName.AutoSize = true;
            this.lbEditName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditName.Location = new System.Drawing.Point(88, 81);
            this.lbEditName.Name = "lbEditName";
            this.lbEditName.Size = new System.Drawing.Size(91, 23);
            this.lbEditName.TabIndex = 1;
            this.lbEditName.Text = "Full Name";
            // 
            // lbEditEmail
            // 
            this.lbEditEmail.AutoSize = true;
            this.lbEditEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditEmail.Location = new System.Drawing.Point(88, 141);
            this.lbEditEmail.Name = "lbEditEmail";
            this.lbEditEmail.Size = new System.Drawing.Size(123, 23);
            this.lbEditEmail.TabIndex = 2;
            this.lbEditEmail.Text = "Email Address";
            // 
            // lbEditPhone
            // 
            this.lbEditPhone.AutoSize = true;
            this.lbEditPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditPhone.Location = new System.Drawing.Point(88, 201);
            this.lbEditPhone.Name = "lbEditPhone";
            this.lbEditPhone.Size = new System.Drawing.Size(130, 23);
            this.lbEditPhone.TabIndex = 3;
            this.lbEditPhone.Text = "Phone Number";
            // 
            // txtEditName
            // 
            this.txtEditName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditName.Location = new System.Drawing.Point(92, 107);
            this.txtEditName.Multiline = true;
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(359, 22);
            this.txtEditName.TabIndex = 5;
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPhone.Location = new System.Drawing.Point(92, 227);
            this.txtEditPhone.Multiline = true;
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(359, 22);
            this.txtEditPhone.TabIndex = 6;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEmail.Location = new System.Drawing.Point(92, 167);
            this.txtEditEmail.Multiline = true;
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(359, 22);
            this.txtEditEmail.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(228, 275);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(636, 405);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEditEmail);
            this.Controls.Add(this.txtEditPhone);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.lbEditPhone);
            this.Controls.Add(this.lbEditEmail);
            this.Controls.Add(this.lbEditName);
            this.Controls.Add(this.lbEdithead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditInfo";
            this.Text = "EditInfo";
            this.Load += new System.EventHandler(this.edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEdithead;
        private System.Windows.Forms.Label lbEditName;
        private System.Windows.Forms.Label lbEditEmail;
        private System.Windows.Forms.Label lbEditPhone;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Button btnUpdate;
    }
}