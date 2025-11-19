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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            AdminPageUsers form = new AdminPageUsers();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            AdminDashboard form = new AdminDashboard();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
            
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            AdminSettings form = new AdminSettings();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.Blue;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = SystemColors.Control;
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.Blue;
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.BackColor = SystemColors.Control;
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.Blue;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor= SystemColors.Control;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Red;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = SystemColors.Control;  
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            AdminDashboard form = new AdminDashboard();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
            try
            {
                string query = "SELECT * FROM Admin WHERE id = " + SessionData.LoggedInUserId;

                var result = DataAccess.GetQueryData(query);

                if (!result.HasError && result.Data.Rows.Count > 0)
                {
                    string adminName = result.Data.Rows[0]["username"].ToString();

                    lblWelcome.Text = "Welcome " + adminName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }
    }
}
