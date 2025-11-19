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
    public partial class dash : Form
    {
        public dash()
        {
            InitializeComponent();
        }

        private void dash_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Product";
            var result = DataAccess.GetQueryData(query);
            dgv.DataSource = result.Data;
            dgv.Refresh();
            dgv.ClearSelection();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                (dgv.DataSource as DataTable).DefaultView.RowFilter = "";
            }
            else
            {
                try
                {
                    string filterExpression = $"ProductName LIKE '%{searchTerm.Replace("'", "''")}%'";
                    (dgv.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid search term. Error: " + ex.Message);
                }

            }
        }
    }
}
