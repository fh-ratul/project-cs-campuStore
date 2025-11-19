using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampuStore
{
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.Blue;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = SystemColors.ActiveCaption;
        }

        private void Vendor_Load_1(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Dashboard1 form = new Dashboard1();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Dashboard1 form = new Dashboard1();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }
        private void btnNewProduct_MouseEnter(object sender, EventArgs e)
        {
            btnNewProduct.BackColor = Color.Blue;
        }
        private void btnNewProduct_MouseLeave(object sender, EventArgs e)
        {
            btnNewProduct.BackColor = SystemColors.ActiveCaption;
        }

        private void btnNewProduct_Click_1(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            NewProduct form = new NewProduct();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }
        private void btnSales_MouseEnter(object sender, EventArgs e)
        {
            btnSales.BackColor = Color.Blue;
        }
        private void btnSales_MouseLeave(object sender, EventArgs e)
        {
            btnSales.BackColor = SystemColors.ActiveCaption;
        }
        private void btnSales_Click_1(object sender, EventArgs e)
        {
            
            this.pnlMain.Controls.Clear();
            Sales1 form = new Sales1(this);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        public void UpdateDashboardTotals(decimal sales, int products)
        {
            this.txtDailySales.Text = sales.ToString("C");
            this.txtTotalProducts.Text = products.ToString();
        }
        private void btnVendorInfo_MouseEnter(object sender, EventArgs e)
        {
            btnVendorInfo.BackColor = Color.Blue;
        }

        private void btnVendorInfo_MouseLeave(object sender, EventArgs e)
        {
            btnVendorInfo.BackColor = SystemColors.ActiveCaption;
        }

        private void btnVendorInfo_Click_1(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            VendorInfo form = new VendorInfo();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.Red;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.RosyBrown;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}