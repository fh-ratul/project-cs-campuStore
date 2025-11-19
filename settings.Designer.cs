namespace CampuStore
{
    partial class settings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setHead = new System.Windows.Forms.Label();
            this.setName = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.setEmail = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.setPhone = new System.Windows.Forms.Label();
            this.setTxtDept = new System.Windows.Forms.TextBox();
            this.setDept = new System.Windows.Forms.Label();
            this.setTxtId = new System.Windows.Forms.TextBox();
            this.setTxtEmail = new System.Windows.Forms.TextBox();
            this.setTxtPhn = new System.Windows.Forms.TextBox();
            this.setId = new System.Windows.Forms.Label();
            this.setTxtName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 405);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.setHead);
            this.panel1.Controls.Add(this.setName);
            this.panel1.Controls.Add(this.btnChangePass);
            this.panel1.Controls.Add(this.setEmail);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.setPhone);
            this.panel1.Controls.Add(this.setTxtDept);
            this.panel1.Controls.Add(this.setDept);
            this.panel1.Controls.Add(this.setTxtId);
            this.panel1.Controls.Add(this.setTxtEmail);
            this.panel1.Controls.Add(this.setTxtPhn);
            this.panel1.Controls.Add(this.setId);
            this.panel1.Controls.Add(this.setTxtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 405);
            this.panel1.TabIndex = 15;
            // 
            // setHead
            // 
            this.setHead.AutoSize = true;
            this.setHead.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.setHead.Location = new System.Drawing.Point(148, 16);
            this.setHead.Name = "setHead";
            this.setHead.Size = new System.Drawing.Size(257, 32);
            this.setHead.TabIndex = 13;
            this.setHead.Text = "Personal Information";
            // 
            // setName
            // 
            this.setName.AutoSize = true;
            this.setName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.setName.Location = new System.Drawing.Point(81, 63);
            this.setName.Name = "setName";
            this.setName.Size = new System.Drawing.Size(57, 23);
            this.setName.TabIndex = 0;
            this.setName.Text = "Name";
            this.setName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.DarkCyan;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(210, 298);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(137, 40);
            this.btnChangePass.TabIndex = 12;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // setEmail
            // 
            this.setEmail.AutoSize = true;
            this.setEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.setEmail.Location = new System.Drawing.Point(17, 97);
            this.setEmail.Name = "setEmail";
            this.setEmail.Size = new System.Drawing.Size(123, 23);
            this.setEmail.TabIndex = 1;
            this.setEmail.Text = "Email Address";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(210, 240);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 41);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Edit Information";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // setPhone
            // 
            this.setPhone.AutoSize = true;
            this.setPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.setPhone.Location = new System.Drawing.Point(81, 132);
            this.setPhone.Name = "setPhone";
            this.setPhone.Size = new System.Drawing.Size(59, 23);
            this.setPhone.TabIndex = 2;
            this.setPhone.Text = "Phone";
            // 
            // setTxtDept
            // 
            this.setTxtDept.BackColor = System.Drawing.Color.White;
            this.setTxtDept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTxtDept.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.setTxtDept.Location = new System.Drawing.Point(146, 198);
            this.setTxtDept.Multiline = true;
            this.setTxtDept.Name = "setTxtDept";
            this.setTxtDept.ReadOnly = true;
            this.setTxtDept.Size = new System.Drawing.Size(282, 22);
            this.setTxtDept.TabIndex = 9;
            // 
            // setDept
            // 
            this.setDept.AutoSize = true;
            this.setDept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.setDept.Location = new System.Drawing.Point(32, 198);
            this.setDept.Name = "setDept";
            this.setDept.Size = new System.Drawing.Size(108, 23);
            this.setDept.TabIndex = 10;
            this.setDept.Text = "Department";
            // 
            // setTxtId
            // 
            this.setTxtId.BackColor = System.Drawing.Color.White;
            this.setTxtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTxtId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.setTxtId.Location = new System.Drawing.Point(146, 164);
            this.setTxtId.Multiline = true;
            this.setTxtId.Name = "setTxtId";
            this.setTxtId.ReadOnly = true;
            this.setTxtId.Size = new System.Drawing.Size(282, 22);
            this.setTxtId.TabIndex = 7;
            // 
            // setTxtEmail
            // 
            this.setTxtEmail.BackColor = System.Drawing.Color.White;
            this.setTxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTxtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.setTxtEmail.Location = new System.Drawing.Point(146, 98);
            this.setTxtEmail.Multiline = true;
            this.setTxtEmail.Name = "setTxtEmail";
            this.setTxtEmail.ReadOnly = true;
            this.setTxtEmail.Size = new System.Drawing.Size(282, 22);
            this.setTxtEmail.TabIndex = 8;
            // 
            // setTxtPhn
            // 
            this.setTxtPhn.BackColor = System.Drawing.Color.White;
            this.setTxtPhn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTxtPhn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.setTxtPhn.Location = new System.Drawing.Point(146, 132);
            this.setTxtPhn.Multiline = true;
            this.setTxtPhn.Name = "setTxtPhn";
            this.setTxtPhn.ReadOnly = true;
            this.setTxtPhn.Size = new System.Drawing.Size(282, 22);
            this.setTxtPhn.TabIndex = 6;
            // 
            // setId
            // 
            this.setId.AutoSize = true;
            this.setId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.setId.Location = new System.Drawing.Point(43, 164);
            this.setId.Name = "setId";
            this.setId.Size = new System.Drawing.Size(97, 23);
            this.setId.TabIndex = 3;
            this.setId.Text = "Student ID";
            // 
            // setTxtName
            // 
            this.setTxtName.BackColor = System.Drawing.Color.White;
            this.setTxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTxtName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTxtName.Location = new System.Drawing.Point(146, 64);
            this.setTxtName.Multiline = true;
            this.setTxtName.Name = "setTxtName";
            this.setTxtName.ReadOnly = true;
            this.setTxtName.Size = new System.Drawing.Size(282, 22);
            this.setTxtName.TabIndex = 5;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(636, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label setHead;
        private System.Windows.Forms.Label setName;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label setEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label setPhone;
        private System.Windows.Forms.TextBox setTxtDept;
        private System.Windows.Forms.Label setDept;
        private System.Windows.Forms.TextBox setTxtId;
        private System.Windows.Forms.TextBox setTxtEmail;
        private System.Windows.Forms.TextBox setTxtPhn;
        private System.Windows.Forms.Label setId;
        private System.Windows.Forms.TextBox setTxtName;
    }
}