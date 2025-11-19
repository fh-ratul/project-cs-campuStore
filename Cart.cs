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
    public partial class Cart : Form
    {

        private studentDash parentDashboard;

        public Cart(studentDash parent)
        {
            InitializeComponent();
            this.parentDashboard = parent; 
        }
        public Cart()
        {
            InitializeComponent();
        }

        private void cart_Load(object sender, EventArgs e)
        {
            LoadCartData();
        }

        private void LoadCartData()
        {
            string query = "SELECT * FROM Cart WHERE StudentID = " + SessionData.LoggedInUserId;
            var result = DataAccess.GetQueryData(query);
            dgv2.DataSource = result.Data;
            dgv2.Refresh();
            dgv2.ClearSelection();

            double grandTotal = 0;
            foreach (DataRow row in result.Data.Rows)
            {
                grandTotal += Convert.ToDouble(row["TotalPrice"]);
            }

            lbTotal.Text = $"Total: {grandTotal:C}";
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgv2.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable cartItems = (DataTable)dgv2.DataSource;

            decimal checkoutTotalCost = 0;
            int checkoutTotalItems = 0;
            foreach (DataRow item in cartItems.Rows)
            {
                checkoutTotalCost += Convert.ToDecimal(item["TotalPrice"]);
                checkoutTotalItems += Convert.ToInt32(item["Quantity"]);
            }

            foreach (DataRow item in cartItems.Rows)
            {
                int productId = Convert.ToInt32(item["ProductID"]);
                int quantityToOrder = Convert.ToInt32(item["Quantity"]);
                string productName = item["ProductName"].ToString().Replace("'", "''");

                string stockCheckQuery = "SELECT ProductQuantity FROM Product WHERE ProductID = " + productId;
                var stockResult = DataAccess.GetQueryData(stockCheckQuery);
                if (stockResult.HasError || stockResult.Data.Rows.Count == 0)
                {
                    MessageBox.Show("Could not verify stock for " + productName + ". Checkout cancelled.", "Error");
                    return;
                }
                int currentStock = Convert.ToInt32(stockResult.Data.Rows[0]["ProductQuantity"]);
                if (currentStock < quantityToOrder)
                {
                    MessageBox.Show($"Sorry, the stock for '{productName}' has changed. Only {currentStock} are available.", "Out of Stock");
                    return;
                }

                string productBrand = item["ProductBrand"].ToString().Replace("'", "''");
                string insertOrderQuery = "INSERT INTO Orders (ProductID, ProductName, ProductBrand, ProductPrice, Quantity, TotalPrice, OrderDate, StudentID) VALUES("
                                          + productId + ", '" + productName + "', '" + productBrand + "', "
                                          + item["ProductPrice"] + ", " + quantityToOrder + ", " + item["TotalPrice"] + ", '"
                                          + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " + SessionData.LoggedInUserId + ")";
                var insertResult = DataAccess.ExecuteNonResultQuery(insertOrderQuery);
                if (insertResult.HasError)
                {
                    MessageBox.Show("Checkout failed while creating order for " + productName + ". Error: " + insertResult.Message, "Error");
                    return;
                }

                int newOrderID = 0;
                int vendorID = 0;
                var orderIdResult = DataAccess.GetQueryData("SELECT TOP 1 OrderID FROM Orders WHERE StudentID = " + SessionData.LoggedInUserId + " ORDER BY OrderID DESC");
                if (!orderIdResult.HasError && orderIdResult.Data.Rows.Count > 0)
                {
                    newOrderID = Convert.ToInt32(orderIdResult.Data.Rows[0]["OrderID"]);
                }
                var vendorIdResult = DataAccess.GetQueryData("SELECT VenID FROM Product WHERE ProductID = " + productId);
                if (!vendorIdResult.HasError && vendorIdResult.Data.Rows.Count > 0 && vendorIdResult.Data.Rows[0]["VenID"] != DBNull.Value)
                {
                    vendorID = Convert.ToInt32(vendorIdResult.Data.Rows[0]["VenID"]);
                }

                if (newOrderID > 0 && vendorID > 0)
                {
                    string salesQuery = "INSERT INTO Sales (OrderID, ProductID, StudentID, VendorID, Quantity, TotalPrice, SaleDate) VALUES ("
                                        + newOrderID + ", " + productId + ", " + SessionData.LoggedInUserId + ", "
                                        + vendorID + ", " + quantityToOrder + ", " + item["TotalPrice"] + ", '"
                                        + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                    var salesInsertResult = DataAccess.ExecuteNonResultQuery(salesQuery);
                    if (salesInsertResult.HasError)
                    {
                        MessageBox.Show("CRITICAL ERROR: Order was created but could not be recorded in sales log.", "Data Error");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("CRITICAL ERROR: Could not find OrderID or VendorID to log the sale for " + productName + ". Check that the product is linked to a vendor.", "Data Error");
                    return;
                }

                string updateStockQuery = "UPDATE Product SET ProductQuantity = ProductQuantity - " + quantityToOrder
                                          + " WHERE ProductID = " + productId;
                DataAccess.ExecuteNonResultQuery(updateStockQuery);
            }

            string deleteCartQuery = "DELETE FROM Cart WHERE StudentID = " + SessionData.LoggedInUserId;
            DataAccess.ExecuteNonResultQuery(deleteCartQuery);

            MessageBox.Show("Checkout successful! Your order has been placed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.parentDashboard != null)
            {
                this.parentDashboard.UpdateCheckoutTotals(checkoutTotalCost, checkoutTotalItems);
            }

            studentDash stdash = new studentDash();
            stdash.Show();
            this.parentDashboard.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cartIdToDelete = Convert.ToInt32(dgv2.SelectedRows[0].Cells["CartID"].Value);

            string query = "DELETE FROM Cart WHERE CartID = " + cartIdToDelete;
            var result = DataAccess.ExecuteNonResultQuery(query);

            if (result.HasError)
            {
                MessageBox.Show("Error removing item: " + result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Item removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCartData();
            }
        }
    }
}
