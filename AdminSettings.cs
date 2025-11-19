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
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            
            btnSave.BackColor = Color.LightGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = SystemColors.Window;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Replace("'", "''");
            string email = txtEmail.Text.Replace("'", "''");
            string password = txtPassword.Text.Replace("'", "''");
            try
            {
                string query = "UPDATE admin SET username = '" + username + "', email = '" + email + "', password = '" + password + "' " +
                               "WHERE id = " + SessionData.LoggedInUserId;

                var result = DataAccess.ExecuteNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show("Update failed: " + result.Message);
                }
                else
                {
                    MessageBox.Show("Settings saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM admin WHERE id = " + SessionData.LoggedInUserId;
                var result = DataAccess.GetQueryData(query);

                if (!result.HasError && result.Data.Rows.Count > 0)
                {
                    txtUsername.Text = result.Data.Rows[0]["username"].ToString();
                    txtEmail.Text = result.Data.Rows[0]["email"].ToString();
                    txtPassword.Text = result.Data.Rows[0]["password"].ToString();
                }
                else
                {
                    MessageBox.Show("Could not load admin data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
