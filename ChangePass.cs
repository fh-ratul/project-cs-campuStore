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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCngUpdate_Click(object sender, EventArgs e)
        {
            string currPass = txtcngCurrPass.Text.Trim();
            string newPass = txtCngNewPass.Text.Trim();
            string retypePass = txtCngRetype.Text.Trim();

            if (currPass != SessionData.LoggedInUserPass)
            {
                MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("New password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass != retypePass)
            {
                MessageBox.Show("New passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE Student SET StPassword = '" + newPass.Replace("'", "''") + "' WHERE StudentID = " + SessionData.LoggedInUserId;
            var result = DataAccess.ExecuteNonResultQuery(query);

            if (result.HasError)
            {
                MessageBox.Show("Failed to update password: " + result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SessionData.LoggedInUserPass = newPass;
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
