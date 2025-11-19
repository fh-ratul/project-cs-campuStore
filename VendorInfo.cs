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
    public partial class VendorInfo : Form
    {
        public VendorInfo()
        {
            InitializeComponent();
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
            try
            {
                // --- 1. Get All Values and Perform Validation First ---
                string name = txtName.Text;
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Name cannot be empty.");
                    return;
                }

                string email = txtEmail.Text;
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Email cannot be empty");
                    return;
                }

                string password = txtPassword.Text;
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password cannot be empty.");
                    return;
                }
                if (password.Length < 6)
                {
                    lblError.Text = "Password must be at least 6 characters.";
                    lblError.Visible = true;
                    return; // Stop the save process
                }

                string shopName = txtShopName.Text;
                if (string.IsNullOrWhiteSpace(shopName))
                {
                    MessageBox.Show("Shop Name cannot be empty.");
                    return;
                }

                // --- FIX: Safely get the selected location text ---
                // Using .Text is safer because it returns an empty string if nothing is selected.
                string location = cmbLocation.Text;
                if (string.IsNullOrWhiteSpace(location))
                {
                    MessageBox.Show("You must select a location.");
                    return;
                }

                // If all validation passes, hide the error label
                lblError.Visible = false;

                // --- 2. Build and Execute the Query ---
                // Escape single quotes to prevent SQL errors
                name = name.Replace("'", "''");
                email = email.Replace("'", "''");
                password = password.Replace("'", "''");
                shopName = shopName.Replace("'", "''");
                location = location.Replace("'", "''");

                // Using a cleaner string format and the correct DataAccess class name
                string query = $"UPDATE Vendor SET venName = '{name}', venEmail = '{email}', venShopName = '{shopName}', venLocation = '{location}', venPassword = '{password}' WHERE venID = {txtVendorID.Text}";

                // --- FIX: Corrected DataAccess class name ---
                var result = DataAccess.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Info Saved Successfully");
            }
            catch (Exception ex)
            {
                // A single try-catch block is cleaner for handling any errors.
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void VendorInfo_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Vendor WHERE venID = " + SessionData.LoggedInUserId;
            try
            {
                var result = DataAccess.GetQueryData(query);
                txtVendorID.Text = result.Data.Rows[0]["venID"].ToString();
                txtName.Text = result.Data.Rows[0]["venName"].ToString();
                txtEmail.Text = result.Data.Rows[0]["venEmail"].ToString();
                txtShopName.Text = result.Data.Rows[0]["venShopName"].ToString();
                cmbLocation.Text = result.Data.Rows[0]["venLocation"].ToString();
                txtPassword.Text = result.Data.Rows[0]["venPassword"].ToString();


            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

