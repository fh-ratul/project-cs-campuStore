using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CampuStore
{
    public partial class settings : Form
    {

        
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
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
                setTxtName.Text = row["StName"].ToString();
                setTxtEmail.Text = row["StEmail"].ToString();
                setTxtPhn.Text = row["StPhone"].ToString();
                setTxtId.Text = row["stID"].ToString();
                setTxtDept.Text = row["StDepartment"].ToString();

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
           this.panel1.Controls.Clear();
            EditInfo form = new EditInfo();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ChangePass form = new ChangePass();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }
    }
}
