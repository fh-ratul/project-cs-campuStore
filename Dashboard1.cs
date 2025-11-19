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
using static System.Net.WebRequestMethods;

namespace CampuStore
{
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadProductInfo(string searchValue = "")
        {

            try

            { 
                string query = "select * from Product";

                if (!string.IsNullOrWhiteSpace(searchValue))

                {

                    int id;

                    if (int.TryParse(searchValue, out id))

                    {

                        query += " where ProductID = " + id + " or ProductName like '%" + searchValue + "%'";

                    }

                    else

                    {

                        query += " where ProductName like '%" + searchValue + "%'";

                    }

                }



                var result = DataAccess.GetQueryData(query);

                if (result.HasError == true)

                {

                    MessageBox.Show(result.Message);

                    return;

                }


                dgvProduct.AutoGenerateColumns = true;

                dgvProduct.DataSource = result.Data;

                dgvProduct.Refresh();

                dgvProduct.ClearSelection();

                this.newCommand();


            }

            catch (Exception ex)

            {

                MessageBox.Show("An error occurred: " + ex.Message);

            }

        }

        private void newCommand()

        {

            txtProductID.Text = "";

            txtName.Text = "";

            txtBrand.Text = "";

            rdbBooks.Checked = rdbStationary.Checked = rdbElectronics.Checked = false;

            this.txtSearch.Text = "";

            txtQuantity.Text = "";

            txtPrice.Text = "";

        }




        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Red;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.RosyBrown;
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Green;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = SystemColors.ActiveCaption;
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Thistle;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor= SystemColors.ActiveCaption;
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.Beige;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor= SystemColors.ActiveCaption;
        }

        private void Dashboard1_Load(object sender, EventArgs e)
        {
            
            
            this.loadProductInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            this.newCommand();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadProductInfo(txtSearch.Text);
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel4.Visible = true;

            try
            {
                this.newCommand();
                if (e.RowIndex < 0)
                {
                    dgvProduct.ClearSelection();
                    return;
                }

                int id = int.Parse(dgvProduct.Rows[e.RowIndex].Cells["ProductID"].Value.ToString());


                string query = "select * from Product where ProductID =" + id;

                var result = DataAccess.GetQueryData(query);
                if (result.HasError == true)
                {
                    MessageBox.Show(result.Message);
                    return;

                }

                txtProductID.Text = result.Data.Rows[0]["ProductID"].ToString();

                txtName.Text = result.Data.Rows[0]["ProductName"].ToString();

                txtBrand.Text = result.Data.Rows[0]["ProductBrand"].ToString();


                rdbBooks.Checked = result.Data.Rows[0]["ProductCategory"].ToString().ToLower() == rdbBooks.Text.ToLower();

                rdbStationary.Checked = result.Data.Rows[0]["ProductCategory"].ToString().ToLower() == rdbStationary.Text.ToLower();

                rdbElectronics.Checked = result.Data.Rows[0]["ProductCategory"].ToString().ToLower() == rdbElectronics.Text.ToLower();

                txtQuantity.Text = result.Data.Rows[0]["ProductQuantity"].ToString();

                txtPrice.Text = result.Data.Rows[0]["ProductPrice"].ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            try

            {

                if (txtProductID.Text == "")

                {

                    MessageBox.Show("Please select a user to delete.");

                    return;

                }

                int id = int.Parse(txtProductID.Text);



                string query = "delete from Product where ProductID =" + id;

                var result = DataAccess.ExecuteNonResultQuery(query);

                if (result.HasError == true)

                {

                    MessageBox.Show(result.Message);

                    return;

                }

                MessageBox.Show("Product deleted Successfully");

                this.loadProductInfo();




            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try

            {

                string name = txtName.Text;

                if (string.IsNullOrWhiteSpace(name))

                {

                    MessageBox.Show("Name cannot be empty.");

                    return;

                }


                string brand = txtBrand.Text;

                if (string.IsNullOrWhiteSpace(brand))

                {

                    MessageBox.Show("Brand cannot be empty");

                    return;

                }

                string category = "";

                if (rdbBooks.Checked)

                {

                    category = rdbBooks.Text;

                }

                else if (rdbStationary.Checked)

                {

                    category = rdbStationary.Text;

                }
                else if (rdbElectronics.Checked)
                {

                    category = rdbElectronics.Text;

                }

                string price = txtPrice.Text;

                if (string.IsNullOrWhiteSpace(price))

                {

                    MessageBox.Show("Price cannot be empty.");

                    return;

                }

                string quantity = txtQuantity.Text;

                if (string.IsNullOrWhiteSpace(quantity))

                {

                    MessageBox.Show("Quantity cannot be empty.");

                    return;

                }

                try

                {

                    string query;

                    query = "update Product set ProductName = '" + name + "', ProductBrand  = '" + brand + "', ProductCategory  = '" + category + "', ProductPrice  = '" + price + "', ProductQuantity  = '" + quantity + "' where ProductID  = " + txtProductID.Text;

                    var result = DataAccess.ExecuteNonResultQuery(query);

                    if (result.HasError == true)

                    {

                        MessageBox.Show(result.Message);

                        return;

                    }

                   

                    MessageBox.Show("Product Saved Successfully");

                    this.loadProductInfo();

                }

                catch (Exception ex)

                {

                    MessageBox.Show("An error occurred: " + ex.Message);



                }



            }

            catch (Exception ex)

            {

                MessageBox.Show("An error occurred: " + ex.Message);

            }

        }

       
    }
}

