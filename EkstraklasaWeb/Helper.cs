using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EkstraklasaWeb
{
    public class Helper
    {
        public static string connectionString = "data source=DESKTOP-M4NPT9R;initial catalog=Ekstraklasa;Integrated Security=SSPI"; //important!!!
        public static void SelectData(string query, GridView grid)
        {
            DataSet dataSet = new DataSet(); ;
            SqlDataAdapter adapter = new SqlDataAdapter();
            using (SqlConnection con = new SqlConnection() { ConnectionString = connectionString })
            {
                con.Open();
                adapter = new SqlDataAdapter(query, connectionString);
                con.Close();
            }
            adapter.Fill(dataSet, "tab");
            grid.DataSource = dataSet.Tables[0];
            
        }
        public static DataSet SelectDataSet(string query)
        {
            DataSet dataSet = new DataSet(); ;
            SqlDataAdapter adapter = new SqlDataAdapter();
            using (SqlConnection con = new SqlConnection() { ConnectionString = connectionString })
            {
                con.Open();
                adapter = new SqlDataAdapter(query, connectionString);
                con.Close();
            }
            adapter.Fill(dataSet, "tab");
            return dataSet;
        }
        public static void UpdateData(string querry)
        {
            using (SqlConnection con = new SqlConnection() { ConnectionString = connectionString })
            {
                con.Open();
                SqlCommand command = new SqlCommand(querry, con);
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void InsertData(string querry)
        {
            using (SqlConnection con = new SqlConnection() { ConnectionString = connectionString })
            {
                con.Open();
                SqlCommand command = new SqlCommand(querry, con);
                command.ExecuteNonQuery();
                con.Close();
            }
        }
        public static void DeleteData(string query)
        {
            using (SqlConnection con = new SqlConnection() { ConnectionString = connectionString })
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}