using System;
using System.Data;
using System.Windows.Forms;

namespace CampuStore
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadTotalUsers();
            LoadTotalSales();
            LoadAllUsersGrid();
        }

      
        private void LoadTotalUsers()
        {
            try
            {
                string studentQuery = "SELECT COUNT(*) FROM Student";
                var studentResult = DataAccess.GetQueryData(studentQuery);
                int studentCount = 0;
                if (!studentResult.HasError && studentResult.Data.Rows.Count > 0)
                {
                    studentCount = Convert.ToInt32(studentResult.Data.Rows[0][0]);
                }

                string vendorQuery = "SELECT COUNT(*) FROM Vendor";
                var vendorResult = DataAccess.GetQueryData(vendorQuery);
                int vendorCount = 0;
                if (!vendorResult.HasError && vendorResult.Data.Rows.Count > 0)
                {
                    vendorCount = Convert.ToInt32(vendorResult.Data.Rows[0][0]);
                }

                txtTotalUser.Text = (studentCount + vendorCount).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total users: " + ex.Message);
            }
        }

        
        private void LoadTotalSales()
        {
            try
            {
                string query = "SELECT ISNULL(SUM(TotalPrice), 0) FROM Orders";
                var result = DataAccess.GetQueryData(query);

                if (!result.HasError && result.Data.Rows.Count > 0)
                {
                    decimal totalSales = Convert.ToDecimal(result.Data.Rows[0][0]);
                    txtTotalSales.Text = totalSales.ToString("C"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total sales: " + ex.Message);
            }
        }

        
        private void LoadAllUsersGrid()
        {
            try
            {
                string query = @"
                    SELECT StName AS Name, StEmail AS Email, 'Student' AS UserType FROM Student
                    UNION ALL
                    SELECT venName AS Name, venEmail AS Email, 'Vendor' AS UserType FROM Vendor";

                var result = DataAccess.GetQueryData(query);

                if (!result.HasError)
                {
                    dgvUser.DataSource = result.Data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user list: " + ex.Message);
            }
        }
    }
}