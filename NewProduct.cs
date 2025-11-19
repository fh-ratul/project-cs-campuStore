using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CampuStore.Result1;

namespace CampuStore
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

       

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductID_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblBrand_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkBooks_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkStationary_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkElectronics_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.GreenYellow;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = SystemColors.ActiveCaption;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // ... (all your validation code for name, brand, etc. remains the same) ...

            try
            {
                string name = txtName.Text.Replace("'", "''");
                string brand = txtBrand.Text.Replace("'", "''");
                string category = "";
                if (rdbBooks.Checked) { category = rdbBooks.Text; }
                else if (rdbStationary.Checked) { category = rdbStationary.Text; }
                else if (rdbElectronics.Checked) { category = rdbElectronics.Text; }
                string price = txtPrice.Text;
                string quantity = txtQuantity.Text;

                // --- THIS IS THE FIX ---
                // The INSERT query now includes the VendorID from the logged-in user.
                string query = "INSERT INTO Product(ProductName, ProductBrand, ProductCategory, ProductPrice, ProductQuantity, VenID) " +
                               "VALUES ('" + name + "', '" + brand + "', '" + category + "', '" + price + "','" + quantity + "', " + SessionData.LoggedInUserId + ")";

                // Note: The UPDATE part of your old code was missing. I've removed it for clarity
                // as this form seems to be for new products only.

                var result = DataAccess.ExecuteNonResultQuery(query);

                if (result.HasError == true)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Product Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
 }

