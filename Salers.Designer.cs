namespace CampuStore
{
    partial class Salers
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTotalSales = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnWeeklySales = new System.Windows.Forms.Button();
            this.btnMonthlySales = new System.Windows.Forms.Button();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.70886F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.29114F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 395);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMonthlySales);
            this.panel1.Controls.Add(this.btnWeeklySales);
            this.panel1.Controls.Add(this.btnDailySales);
            this.panel1.Controls.Add(this.btnTotalSales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 139);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 244);
            this.panel2.TabIndex = 1;
            // 
            // btnTotalSales
            // 
            this.btnTotalSales.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTotalSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSales.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTotalSales.Location = new System.Drawing.Point(9, 38);
            this.btnTotalSales.Name = "btnTotalSales";
            this.btnTotalSales.Size = new System.Drawing.Size(134, 57);
            this.btnTotalSales.TabIndex = 0;
            this.btnTotalSales.Text = "Total Sales";
            this.btnTotalSales.UseVisualStyleBackColor = false;
            // 
            // btnDailySales
            // 
            this.btnDailySales.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDailySales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDailySales.Location = new System.Drawing.Point(160, 38);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(149, 57);
            this.btnDailySales.TabIndex = 1;
            this.btnDailySales.Text = "Daily Sales";
            this.btnDailySales.UseVisualStyleBackColor = false;
            // 
            // btnWeeklySales
            // 
            this.btnWeeklySales.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnWeeklySales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklySales.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWeeklySales.Location = new System.Drawing.Point(327, 38);
            this.btnWeeklySales.Name = "btnWeeklySales";
            this.btnWeeklySales.Size = new System.Drawing.Size(169, 57);
            this.btnWeeklySales.TabIndex = 2;
            this.btnWeeklySales.Text = "Weekly Sales";
            this.btnWeeklySales.UseVisualStyleBackColor = false;
            // 
            // btnMonthlySales
            // 
            this.btnMonthlySales.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnMonthlySales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlySales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMonthlySales.Location = new System.Drawing.Point(516, 38);
            this.btnMonthlySales.Name = "btnMonthlySales";
            this.btnMonthlySales.Size = new System.Drawing.Size(157, 57);
            this.btnMonthlySales.TabIndex = 3;
            this.btnMonthlySales.Text = "Monthly Sales";
            this.btnMonthlySales.UseVisualStyleBackColor = false;
            // 
            // txtSales
            // 
            this.txtSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSales.Location = new System.Drawing.Point(180, 20);
            this.txtSales.Multiline = true;
            this.txtSales.Name = "txtSales";
            this.txtSales.ReadOnly = true;
            this.txtSales.Size = new System.Drawing.Size(333, 106);
            this.txtSales.TabIndex = 0;
            // 
            // Salers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Salers";
            this.Text = "Salers";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDailySales;
        private System.Windows.Forms.Button btnTotalSales;
        private System.Windows.Forms.Button btnWeeklySales;
        private System.Windows.Forms.Button btnMonthlySales;
        private System.Windows.Forms.TextBox txtSales;
    }
}