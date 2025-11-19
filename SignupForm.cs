using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampuStore
{
    public partial class SignupForm : Form
    {
        string connectionString = "Data Source=RATUL;Initial Catalog=CampuStore;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public SignupForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVenSignup_Click(object sender, EventArgs e)
        {
            // Check if name is empty
            if (string.IsNullOrWhiteSpace(txtVenName.Text))
            {
                MessageBox.Show("Please enter your name.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenName.Focus();
                return;
            }

            // Check if email is empty or invalid format
            if (string.IsNullOrWhiteSpace(txtVenEmail.Text))
            {
                MessageBox.Show("Please enter your email.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenEmail.Focus();
                return;
            }
            else if (!txtVenEmail.Text.Contains("@") || !txtVenEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenEmail.Focus();
                return;
            }

            // Check if password is empty
            if (string.IsNullOrWhiteSpace(txtVenPass.Text))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenPass.Focus();
                return;
            }

            // Check password length 
            if (txtVenPass.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenPass.Focus();
                return;
            }

            //  Check if Confirm Password matches
            if (txtVenPass.Text != txtVenConPass.Text)
            {
                MessageBox.Show("Passwords do not match. Please confirm your password.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenConPass.Focus();
                return;
            }

            //  Check if Shop Name is empty
            if (string.IsNullOrWhiteSpace(txtVenShop.Text))
            {
                MessageBox.Show("Please enter your shop name.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenShop.Focus();
                return;
            }

            //  Check if Category is selected (ComboBox or similar)
            if (comboVenCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category for your shop.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboVenCategory.Focus();
                return;
            }

            // Location
            if (string.IsNullOrWhiteSpace(txtVenLocation.Text))
            {
                MessageBox.Show("Please enter your location.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenLocation.Focus();
                return;
            }

            // Check if Terms and Conditions are agreed
            if (!checkAgree.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions to proceed.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string venName = txtVenName.Text;
            string venEmail = txtVenEmail.Text;
            string venShopName = txtVenShop.Text;
            string venCategory = comboVenCategory.SelectedItem.ToString();
            string venLocation = txtVenLocation.Text;
            string venPassword = txtVenPass.Text;

        
            string query = "INSERT INTO Vendor VALUES ('" + venName + "', '" + venEmail + "', '" + venShopName + "', '" +
               venCategory + "', '" + venLocation + "', '" + venPassword + "')";


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully signed up!", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnStSignup_Click(object sender, EventArgs e)
        {
            // Check if name is empty
            if (string.IsNullOrWhiteSpace(txtStName.Text))
            {
                MessageBox.Show("Please enter your name.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStName.Focus();
                return;
            }

            // Check if email is empty or invalid format
            if (string.IsNullOrWhiteSpace(txtStEmail.Text))
            {
                MessageBox.Show("Please enter your email.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStEmail.Focus();
                return;
            }
            else if (!txtStEmail.Text.Contains("@") || !txtStEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStEmail.Focus();
                return;
            }

            // Check if password is empty
            if (string.IsNullOrWhiteSpace(txtStPass.Text))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStPass.Focus();
                return;
            }

            // Check password length 
            if (txtStPass.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStPass.Focus();
                return;
            }

            // Check if Confirm Password matches
            if (txtStPass.Text != txtStConPass.Text)
            {
                MessageBox.Show("Passwords do not match. Please confirm your password.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStConPass.Focus();
                return;
            }

            // Phone Number: Must be exactly 11 digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtStPhone.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Enter a valid phone number",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStPhone.Focus();
                return;
            }

            //  Student ID: Format like XX-XXXXX-X
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtStID.Text, @"^\d{2}-\d{5}-\d{1}$"))
            {
                MessageBox.Show("Student ID must follow the format: XX-XXXXX-X",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStID.Focus();
                return;
            }

            


            // Department
            if (comboStDept.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your department.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboStDept.Focus();
                return;
            }

            // Year / Level (if you have a combo box for academic year)
            if (comboStYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your academic year.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboStYear.Focus();
                return;
            }

            // Check if Terms and Conditions are agreed
            if (!checkStAgree.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions to proceed.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string StName = txtStName.Text;
            string StEmail = txtStEmail.Text;
            string StPhone = txtStPhone.Text;
            string StDepartment = comboStDept.SelectedItem.ToString();
            string StYear = comboStYear.SelectedItem.ToString();
            string StPassword = txtStPass.Text;
            string stID = txtStID.Text;


            string query = "INSERT INTO Student VALUES ('" + StName + "', '" + StEmail + "', '" + StPhone + "', '" +
               StDepartment + "', '" + StYear + "', '" + StPassword + "', '" + stID + "')";


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Successfully signed up!", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void linkBecomeVen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSt.Visible = false;
            panelVen.Visible = true;
        }

        private void linkStLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
            
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
            
        }
    }
}
