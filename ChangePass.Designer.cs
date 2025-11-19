namespace CampuStore
{
    partial class ChangePass
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
            this.lbCngPass = new System.Windows.Forms.Label();
            this.lbCngCurrPass = new System.Windows.Forms.Label();
            this.lbCngNewPass = new System.Windows.Forms.Label();
            this.lbCngRetype = new System.Windows.Forms.Label();
            this.txtcngCurrPass = new System.Windows.Forms.TextBox();
            this.txtCngNewPass = new System.Windows.Forms.TextBox();
            this.txtCngRetype = new System.Windows.Forms.TextBox();
            this.btnCngUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCngPass
            // 
            this.lbCngPass.AutoSize = true;
            this.lbCngPass.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCngPass.Location = new System.Drawing.Point(143, 35);
            this.lbCngPass.Name = "lbCngPass";
            this.lbCngPass.Size = new System.Drawing.Size(312, 38);
            this.lbCngPass.TabIndex = 0;
            this.lbCngPass.Text = "Change Your Password";
            this.lbCngPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCngCurrPass
            // 
            this.lbCngCurrPass.AutoSize = true;
            this.lbCngCurrPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCngCurrPass.Location = new System.Drawing.Point(109, 100);
            this.lbCngCurrPass.Name = "lbCngCurrPass";
            this.lbCngCurrPass.Size = new System.Drawing.Size(151, 23);
            this.lbCngCurrPass.TabIndex = 1;
            this.lbCngCurrPass.Text = "Current Password";
            // 
            // lbCngNewPass
            // 
            this.lbCngNewPass.AutoSize = true;
            this.lbCngNewPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCngNewPass.Location = new System.Drawing.Point(109, 166);
            this.lbCngNewPass.Name = "lbCngNewPass";
            this.lbCngNewPass.Size = new System.Drawing.Size(126, 23);
            this.lbCngNewPass.TabIndex = 2;
            this.lbCngNewPass.Text = "New Password";
            // 
            // lbCngRetype
            // 
            this.lbCngRetype.AutoSize = true;
            this.lbCngRetype.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCngRetype.Location = new System.Drawing.Point(109, 232);
            this.lbCngRetype.Name = "lbCngRetype";
            this.lbCngRetype.Size = new System.Drawing.Size(194, 23);
            this.lbCngRetype.TabIndex = 3;
            this.lbCngRetype.Text = "Re-type New Password";
            // 
            // txtcngCurrPass
            // 
            this.txtcngCurrPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcngCurrPass.Location = new System.Drawing.Point(113, 126);
            this.txtcngCurrPass.Multiline = true;
            this.txtcngCurrPass.Name = "txtcngCurrPass";
            this.txtcngCurrPass.PasswordChar = '*';
            this.txtcngCurrPass.Size = new System.Drawing.Size(342, 22);
            this.txtcngCurrPass.TabIndex = 4;
            // 
            // txtCngNewPass
            // 
            this.txtCngNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCngNewPass.Location = new System.Drawing.Point(113, 192);
            this.txtCngNewPass.Multiline = true;
            this.txtCngNewPass.Name = "txtCngNewPass";
            this.txtCngNewPass.PasswordChar = '*';
            this.txtCngNewPass.Size = new System.Drawing.Size(342, 22);
            this.txtCngNewPass.TabIndex = 5;
            // 
            // txtCngRetype
            // 
            this.txtCngRetype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCngRetype.Location = new System.Drawing.Point(113, 258);
            this.txtCngRetype.Multiline = true;
            this.txtCngRetype.Name = "txtCngRetype";
            this.txtCngRetype.PasswordChar = '*';
            this.txtCngRetype.Size = new System.Drawing.Size(342, 22);
            this.txtCngRetype.TabIndex = 6;
            // 
            // btnCngUpdate
            // 
            this.btnCngUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCngUpdate.FlatAppearance.BorderSize = 0;
            this.btnCngUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCngUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCngUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCngUpdate.Location = new System.Drawing.Point(228, 313);
            this.btnCngUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCngUpdate.Name = "btnCngUpdate";
            this.btnCngUpdate.Size = new System.Drawing.Size(91, 37);
            this.btnCngUpdate.TabIndex = 7;
            this.btnCngUpdate.Text = "Update";
            this.btnCngUpdate.UseVisualStyleBackColor = false;
            this.btnCngUpdate.Click += new System.EventHandler(this.btnCngUpdate_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(636, 405);
            this.Controls.Add(this.btnCngUpdate);
            this.Controls.Add(this.txtCngRetype);
            this.Controls.Add(this.txtCngNewPass);
            this.Controls.Add(this.txtcngCurrPass);
            this.Controls.Add(this.lbCngRetype);
            this.Controls.Add(this.lbCngNewPass);
            this.Controls.Add(this.lbCngCurrPass);
            this.Controls.Add(this.lbCngPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCngPass;
        private System.Windows.Forms.Label lbCngCurrPass;
        private System.Windows.Forms.Label lbCngNewPass;
        private System.Windows.Forms.Label lbCngRetype;
        private System.Windows.Forms.TextBox txtcngCurrPass;
        private System.Windows.Forms.TextBox txtCngNewPass;
        private System.Windows.Forms.TextBox txtCngRetype;
        private System.Windows.Forms.Button btnCngUpdate;
    }
}