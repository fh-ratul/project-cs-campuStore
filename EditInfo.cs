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
    public partial class EditInfo : Form
    {
        public EditInfo()
        {
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            LoadStudentData();

        }

        private void LoadStudentData()
        {
            string query = $"SELECT * FROM Student WHERE StudentID = '{SessionData.LoggedInUserId}'";
            var result = DataAccess.GetQueryData(query);

            if (!result.HasError && result.Data.Rows.Count > 0)
            {
                DataRow row = result.Data.Rows[0];
                txtEditName.Text = row["StName"].ToString();
                txtEditEmail.Text = row["StEmail"].ToString();
                txtEditPhone.Text = row["StPhone"].ToString();
                

            }
            else
            {
                MessageBox.Show("Failed to load student data.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string stName = txtEditName.Text;
            string stEmail = txtEditEmail.Text;
            string stPhone = txtEditPhone.Text;

            var queryString ="UPDATE Student SET StName='" + stName +
                         "', StEmail='" + stEmail +
                         "', StPhone='" + stPhone +
                         "' WHERE StudentID='" + SessionData.LoggedInUserId + "'";

            var result = DataAccess.ExecuteNonResultQuery(queryString);

            if (result.HasError)
            {
                MessageBox.Show(result.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Controls.Clear();
            settings form = new settings();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            form.Show();


        }
    }
}
