using System;
using System.Data;
using System.Data.SqlClient;

namespace CampuStore
{
    public class Result1
    {
        public DataTable Data { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; }

        public Result1()
        {
            Data = new DataTable();
        }
    }

    internal static class DataAccess
    {
        private static string connectionString = "Data Source=RATUL;Initial Catalog=CampuStore;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public static Result1 GetQueryData(string query, SqlParameter[] parameters = null)
        {
            var result = new Result1();
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                if (parameters != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                }
                adapter.Fill(result.Data);

                con.Close();
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Message = ex.Message;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }

        public static Result1 ExecuteNonResultQuery(string query)
        {
            var result = new Result1();
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Message = ex.Message;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
    }
}