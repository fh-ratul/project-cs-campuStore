using System;
using System.Windows.Forms;

namespace CampuStore
{
    public partial class Sales1 : Form
    {
        private SalesLogic salesLogic;

        public Sales1(Vendor parentVendor)
        {
            InitializeComponent();
            salesLogic = new SalesLogic(parentVendor);
        }

        private void Sales1_Load(object sender, EventArgs e)
        {
            // When the form loads, by default, show daily totals and all sales details
            salesLogic.LoadSalesTotals("daily");
            txtSales.Text = salesLogic.GetSalesDetails("total");
        }

        private void btnTotalSales_Click(object sender, EventArgs e)
        {
            salesLogic.LoadSalesTotals("total");
            txtSales.Text = salesLogic.GetSalesDetails("total");
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            salesLogic.LoadSalesTotals("daily");
            txtSales.Text = salesLogic.GetSalesDetails("daily");
        }

        private void btnWeeklySales_Click(object sender, EventArgs e)
        {
            salesLogic.LoadSalesTotals("weekly");
            txtSales.Text = salesLogic.GetSalesDetails("weekly");
        }

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {
            salesLogic.LoadSalesTotals("monthly");
            txtSales.Text = salesLogic.GetSalesDetails("monthly");
        }
    }
}