using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekstraklasa
{
    class Helper
    {
        public static System.Windows.Forms.FormBorderStyle Dc_borderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        static string connectionString = "data source=DESKTOP-M4NPT9R;initial catalog=Ekstraklasa;Integrated Security=SSPI"; //important!!!
        public static Color BackColor = Color.DimGray;
        public static Color ForeColor = Color.Wheat;
        public static Color ButtonBackColor = Color.Gray;
        public static Color BorderColor = Color.Transparent;
        public static void DesignButton(Button x)
        {
            x.ForeColor = ForeColor;
            x.BackColor = ButtonBackColor;
            x.FlatStyle = FlatStyle.Flat;
            x.FlatAppearance.BorderSize = 0;
        }
        public static void SelectData(string query,  DataGridView grid)
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
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
