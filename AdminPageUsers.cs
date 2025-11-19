using System;
using System.Data;
using System.Windows.Forms;

namespace CampuStore
{
    public partial class AdminPageUsers : Form
    {
        // This table will hold the master list of all users (students and vendors)
        private DataTable allUsersTable;
        // These will store details of the currently selected user for editing/deleting
        private string selectedUserType = "";
        private int selectedUserId = 0;

        public AdminPageUsers()
        {
            InitializeComponent();
        }

        private void AdminPageUsers_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        
        private void LoadAllUsers()
        {
            try
            {
                string query = @"
            SELECT StudentID AS ID, StName AS Name, StEmail AS Email, 'Student' AS UserType, StPassword AS Password FROM Student
            UNION ALL
            SELECT venID AS ID, venName AS Name, venEmail AS Email, 'Vendor' AS UserType, venPassword AS Password FROM Vendor";

                var result = DataAccess.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error loading users: " + result.Message);
                    return;
                }

                this.allUsersTable = result.Data;

              
                this.allUsersTable.CaseSensitive = false;

                dgvUser.DataSource = this.allUsersTable;

                dgvUser.Columns["ID"].HeaderText = "User ID";
                dgvUser.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvUser.Columns["UserType"].HeaderText = "User Type";
                dgvUser.Columns["Password"].Visible = false;

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtUserID.Text = "";
            txtName.Text = "";
            txtUserEmail.Text = "";
            txtUserPassword.Text = "";
            selectedUserId = 0;
            selectedUserType = "";
            dgvUser.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if (allUsersTable == null)
            {
                MessageBox.Show("Error: The master user table ('allUsersTable') is NULL. The data never loaded when the form opened.");
                return;
            }

            if (allUsersTable.Rows.Count == 0)
            {
                MessageBox.Show("Error: The master user table was created, but it has 0 rows. The database query might be failing.");
                return;
            }

            MessageBox.Show($"Step 1: The master user table is loaded with {allUsersTable.Rows.Count} rows.");

            MessageBox.Show($"Step 2: Is the table case-sensitive? {allUsersTable.CaseSensitive}");

            string searchTerm = txtSearch.Text.Trim();
            MessageBox.Show($"Step 3: You are searching for: '{searchTerm}'");

            if (string.IsNullOrEmpty(searchTerm))
            {
                allUsersTable.DefaultView.RowFilter = "";
                MessageBox.Show("Step 4: Search term is empty. Filter has been cleared.");
            }
            else
            {
                string filterExpression;
                int searchId;
                bool isNumeric = int.TryParse(searchTerm, out searchId);

                if (isNumeric)
                {
                    filterExpression = $"ID = {searchId} OR Name LIKE '%{searchTerm.Replace("'", "''")}%'";
                }
                else
                {
                    filterExpression = $"Name LIKE '%{searchTerm.Replace("'", "''")}%'";
                }

                MessageBox.Show($"Step 4: Applying this filter expression:\n\n{filterExpression}");

                try
                {
                    allUsersTable.DefaultView.RowFilter = filterExpression;
                    MessageBox.Show("Step 5: Filter applied successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Step 5 FAILED: An error occurred while applying the filter.\n\nError: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            allUsersTable.DefaultView.RowFilter = ""; 
            ClearForm();
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvUser.Rows[e.RowIndex];

            selectedUserId = Convert.ToInt32(row.Cells["ID"].Value);
            selectedUserType = row.Cells["UserType"].Value.ToString();

            txtUserID.Text = selectedUserId.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtUserEmail.Text = row.Cells["Email"].Value.ToString();
            txtUserPassword.Text = row.Cells["Password"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0 || string.IsNullOrEmpty(selectedUserType))
            {
                MessageBox.Show("Please double-click a user to select them for deletion.", "No User Selected");
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete this {selectedUserType}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "";
                if (selectedUserType == "Student")
                {
                    query = "DELETE FROM Student WHERE StudentID = " + selectedUserId;
                }
                else if (selectedUserType == "Vendor")
                {
                    query = "DELETE FROM Vendor WHERE venID = " + selectedUserId;
                }

                var result = DataAccess.ExecuteNonResultQuery(query);
                if (result.HasError) { MessageBox.Show("Delete failed: " + result.Message); }
                else { MessageBox.Show($"{selectedUserType} deleted successfully."); }

                LoadAllUsers(); 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0 || string.IsNullOrEmpty(selectedUserType))
            {
                MessageBox.Show("Please double-click a user to select them for editing.", "No User Selected");
                return;
            }

            string name = txtName.Text.Replace("'", "''");
            string email = txtUserEmail.Text.Replace("'", "''");
            string password = txtUserPassword.Text.Replace("'", "''");

            string query = "";
            if (selectedUserType == "Student")
            {
                query = $"UPDATE Student SET StName = '{name}', StEmail = '{email}', StPassword = '{password}' WHERE StudentID = {selectedUserId}";
            }
            else if (selectedUserType == "Vendor")
            {
                query = $"UPDATE Vendor SET venName = '{name}', venEmail = '{email}', venPassword = '{password}' WHERE venID = {selectedUserId}";
            }

            var result = DataAccess.ExecuteNonResultQuery(query);
            if (result.HasError) { MessageBox.Show("Save failed: " + result.Message); }
            else { MessageBox.Show($"{selectedUserType} saved successfully."); }

            LoadAllUsers(); 
        }
    }
}