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
    public partial class studentDash : Form
    {
        public dash dashForm;
        private double lifetimeTotalCost = 0;
        private int lifetimeTotalItems = 0;
        public studentDash()
        {
            InitializeComponent();
            HighlightButton(btnStDash);
            this.dashForm = new dash();
            this.dashForm.TopLevel = false;
            this.dashForm.Dock = DockStyle.Fill;

            this.pnlStDash.Controls.Clear();
            this.pnlStDash.Controls.Add(this.dashForm);
            this.dashForm.Show();
            LoadLifetimeStats();
        }

        public void ShowMainDashboard()
        {
            HighlightButton(btnStDash);
            this.dashForm = new dash();
            this.dashForm.TopLevel = false;
            this.dashForm.Dock = DockStyle.Fill;
            this.pnlStDash.Controls.Clear();
            this.pnlStDash.Controls.Add(this.dashForm);
            this.dashForm.Show();
        }
        private void LoadLifetimeStats()
        {
            string query = "SELECT SUM(TotalPrice), SUM(Quantity) FROM Orders WHERE StudentID = " + SessionData.LoggedInUserId;
            var result = DataAccess.GetQueryData(query);

            if (!result.HasError && result.Data.Rows.Count > 0)
            {
                DataRow totalsRow = result.Data.Rows[0];
                if (totalsRow[0] != DBNull.Value)
                {
                    this.lifetimeTotalCost = Convert.ToDouble(totalsRow[0]);
                }
                if (totalsRow[1] != DBNull.Value)
                {
                    this.lifetimeTotalItems = Convert.ToInt32(totalsRow[1]);
                }
            }

            lbMyOrdersMoney.Text = this.lifetimeTotalCost.ToString("C");
            lbTotalProductsCount.Text = this.lifetimeTotalItems.ToString();

        }


        public void UpdateCheckoutTotals(double newOrderCost, int newOrderItems)
        {
            this.lifetimeTotalCost += newOrderCost;
            this.lifetimeTotalItems += newOrderItems;

            lbMyOrdersMoney.Text += this.lifetimeTotalCost.ToString("C");
            lbTotalProductsCount.Text += this.lifetimeTotalItems.ToString();
        }
        private void btnStDash_Click(object sender, EventArgs e)
        {
            HighlightButton(btnStDash);
            this.dashForm = new dash();
            this.dashForm.TopLevel = false;
            this.dashForm.Dock = DockStyle.Fill;

            this.pnlStDash.Controls.Clear();
            this.pnlStDash.Controls.Add(this.dashForm);
            this.dashForm.Show();


        }

        private void btnStOrders_Click(object sender, EventArgs e)
        {
            HighlightButton(btnStOrders);
            this.pnlStDash.Controls.Clear();
            OrdersForm form = new OrdersForm();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlStDash.Controls.Add(form);
            form.Show();

        }

        public void btnStSettings_Click(object sender, EventArgs e)
        {
            HighlightButton(btnStSettings);
            this.pnlStDash.Controls.Clear();
            settings form = new settings();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlStDash.Controls.Add(form);
            form.Show();
        }

     

        private void btnCart_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCart);
            if (this.dashForm.dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = this.dashForm.dgv.SelectedRows[0];

            int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
            string productName = row.Cells["ProductName"].Value.ToString();
            string productBrand = row.Cells["ProductBrand"].Value.ToString();
            double productPrice = Convert.ToDouble(row.Cells["ProductPrice"].Value);
            int availableQty = Convert.ToInt32(row.Cells["ProductQuantity"].Value);

            Form prompt = new Form()
            {
                Width = 300,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Enter Quantity",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lblText = new Label() { Left = 20, Top = 20, Width = 240, Text = "Enter quantity for " + productName + " (Available: " + availableQty + "):" };
            TextBox txtInput = new TextBox() { Left = 20, Top = 50, Width = 240 };
            Button btnOk = new Button() { Text = "OK", Left = 95, Width = 80, Top = 80, DialogResult = DialogResult.OK };

            prompt.Controls.Add(lblText);
            prompt.Controls.Add(txtInput);
            prompt.Controls.Add(btnOk);
            prompt.AcceptButton = btnOk;

            DialogResult dialogResult = prompt.ShowDialog();
            if (dialogResult != DialogResult.OK) return;

            string qtyInput = txtInput.Text.Trim();
            int qty;

            if (!int.TryParse(qtyInput, out qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (qty > availableQty)
            {
                MessageBox.Show("Not enough stock available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double total = productPrice * qty;

            string query = "INSERT INTO Cart(ProductID, ProductName, ProductBrand, ProductPrice, Quantity, TotalPrice, StudentID) VALUES(" +
                             productId + ", '" + productName + "', '" + productBrand + "', " + productPrice + ", " + qty + ", " + total + ", " + SessionData.LoggedInUserId + ")";

            var result = DataAccess.ExecuteNonResultQuery(query);

            if (!result.HasError)
            {
                MessageBox.Show("Added to cart successfully!");
            }
            else
            {
                MessageBox.Show("Error adding to cart: " + result.Message);
            }


        }
        private void btnStLogout_Click(object sender, EventArgs e)
        {
            HighlightButton(btnStLogout);
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnStDashCart_Click(object sender, EventArgs e)
        {
            HighlightButton(btnStDashCart);
            this.pnlStDash.Controls.Clear();
            Cart form = new Cart(this);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlStDash.Controls.Add(form);
            form.Show();
        }

        public void UpdateCheckoutTotals(decimal totalCost, int totalItems)
        {
            lbMyOrdersMoney.Text = totalCost.ToString("C");
            lbTotalProductsCount.Text = totalItems.ToString();
        }

        private void HighlightButton(Button clickedButton)
        {
            // Reset all buttons to default color
            btnStDash.BackColor = Color.White;
            btnStDash.ForeColor = SystemColors.GrayText;

            btnStOrders.BackColor = Color.White;
            btnStOrders.ForeColor = SystemColors.GrayText;

            btnStSettings.BackColor = Color.White;
            btnStSettings.ForeColor = SystemColors.GrayText;

            btnCart.BackColor = Color.White;
            btnCart.ForeColor = SystemColors.GrayText;

            btnStLogout.BackColor = Color.White;
            btnStLogout.ForeColor = SystemColors.GrayText;

            btnStDashCart.BackColor = Color.White;
            btnStDashCart.ForeColor = SystemColors.GrayText;

            // Highlight the clicked one
            clickedButton.BackColor = Color.FromArgb(59, 130, 246); // blue
            clickedButton.ForeColor = Color.White;
        }

        
    }
}
