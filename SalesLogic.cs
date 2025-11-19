using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CampuStore
{
    public class SalesLogic
    {
        private Vendor vendorForm;

        public SalesLogic(Vendor form)
        {
            this.vendorForm = form;
        }

        public void LoadSalesTotals(string filterType)
        {
            string query = @"
                SELECT ISNULL(SUM(TotalPrice), 0) AS SalesTotal, ISNULL(SUM(Quantity), 0) AS ProductCount
                FROM Sales WHERE VendorID = " + SessionData.LoggedInUserId;

            switch (filterType)
            {
                case "daily":
                    query += " AND CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)";
                    break;
                case "weekly":
                    query += " AND SaleDate >= DATEADD(day, -7, GETDATE())";
                    break;
                case "monthly":
                    query += " AND SaleDate >= DATEADD(day, -30, GETDATE())";
                    break;
            }

            var result = DataAccess.GetQueryData(query);

            if (!result.HasError && result.Data.Rows.Count > 0)
            {
                DataRow totals = result.Data.Rows[0];
                decimal salesTotal = Convert.ToDecimal(totals["SalesTotal"]);
                int productCount = Convert.ToInt32(totals["ProductCount"]);
                this.vendorForm.UpdateDashboardTotals(salesTotal, productCount);
            }
            else if (result.HasError)
            {
                MessageBox.Show("Error loading sales totals: " + result.Message);
            }
        }

        public string GetSalesDetails(string filterType)
        {
            string query = @"
                SELECT s.SaleID, p.ProductName, s.Quantity, s.TotalPrice, s.SaleDate
                FROM Sales AS s
                INNER JOIN Product AS p ON s.ProductID = p.ProductID
                WHERE s.VendorID = " + SessionData.LoggedInUserId;

            switch (filterType)
            {
                case "daily":
                    query += " AND CAST(s.SaleDate AS DATE) = CAST(GETDATE() AS DATE)";
                    break;
                case "weekly":
                    query += " AND s.SaleDate >= DATEADD(day, -7, GETDATE())";
                    break;
                case "monthly":
                    query += " AND s.SaleDate >= DATEADD(day, -30, GETDATE())";
                    break;
            }
            query += " ORDER BY s.SaleDate DESC";

            var result = DataAccess.GetQueryData(query);

            if (!result.HasError)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("ID\tProduct Name\t\tQty\tPrice\t\tDate");
                sb.AppendLine("---------------------------------------------------------------------");
                foreach (DataRow row in result.Data.Rows)
                {
                    sb.Append(row["SaleID"].ToString() + "\t");
                    sb.Append(row["ProductName"].ToString().PadRight(20) + "\t");
                    sb.Append(row["Quantity"].ToString() + "\t");
                    sb.Append(Convert.ToDecimal(row["TotalPrice"]).ToString("C") + "\t\t");
                    sb.Append(Convert.ToDateTime(row["SaleDate"]).ToShortDateString());
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            else
            {
                MessageBox.Show("Error loading sales details: " + result.Message);
                return "Error loading data.";
            }
        }
    }
}