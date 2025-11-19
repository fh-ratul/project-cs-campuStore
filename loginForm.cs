using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CampuStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string stEmail = txtLoginEmail.Text.Trim();
            string stPassword = txtLoginPass.Text.Trim();

            if (string.IsNullOrEmpty(stEmail) || string.IsNullOrEmpty(stPassword))
            {
                MessageBox.Show("Please enter both email and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentQuery = "SELECT * FROM Student WHERE StEmail = @email AND StPassword = @password";
            SqlParameter[] studentParams = new SqlParameter[]
            {
        new SqlParameter("@email", stEmail),
        new SqlParameter("@password", stPassword)
            };
            var studentResult = DataAccess.GetQueryData(studentQuery, studentParams);

            if (studentResult.HasError) { MessageBox.Show(studentResult.Message); return; }
            if (studentResult.Data.Rows.Count == 1)
            {
                DataRow row = studentResult.Data.Rows[0];
                SessionData.LoggedInUserId = Convert.ToInt32(row["StudentID"]);
                SessionData.LoggedInUserName = row["StName"].ToString();
                SessionData.LoggedInUserPass = row["StPassword"].ToString();

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new studentDash().Show();
                return;
            }

            string adminQuery = "SELECT * FROM Admin WHERE email = @email AND password = @password";
            SqlParameter[] adminParams = new SqlParameter[]
            {
        new SqlParameter("@email", stEmail),
        new SqlParameter("@password", stPassword)
            };
            var adminResult = DataAccess.GetQueryData(adminQuery, adminParams);

            if (adminResult.HasError) { MessageBox.Show(adminResult.Message); return; }
            if (adminResult.Data.Rows.Count == 1)
            {
                DataRow row = adminResult.Data.Rows[0];
                SessionData.LoggedInUserId = Convert.ToInt32(row["id"]);
                SessionData.LoggedInUserName = row["username"].ToString();
                SessionData.LoggedInUserPass = row["password"].ToString();

                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new AdminPage().Show();
                return;
            }

            string vendorQuery = "SELECT * FROM Vendor WHERE venEmail = @email AND venPassword = @password";
            SqlParameter[] vendorParams = new SqlParameter[]
            {
        new SqlParameter("@email", stEmail),
        new SqlParameter("@password", stPassword)
            };
            var vendorResult = DataAccess.GetQueryData(vendorQuery, vendorParams);

            if (vendorResult.HasError) { MessageBox.Show(vendorResult.Message); return; }
            if (vendorResult.Data.Rows.Count == 1)
            {
                DataRow row = vendorResult.Data.Rows[0];
                SessionData.LoggedInUserId = Convert.ToInt32(row["venID"]);
                SessionData.LoggedInUserName = row["venName"].ToString();
                SessionData.LoggedInUserPass = row["venPassword"].ToString();

                MessageBox.Show("Vendor login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Vendor().Show();
                return;
            }

            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}