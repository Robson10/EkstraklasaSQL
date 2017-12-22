using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EkstraklasaWeb
{
    public partial class _Default : Page
    {
        public int UserID = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserID"] = -1;
        }
        protected void Login1_LoggingIn(object sender, LoginCancelEventArgs e)
        {
            string text = Login1.UserName + Login1.Password;
                if (!tryConnectAsAdmin(Login1.UserName, Login1.Password))
                {
                    if (!tryConnectAsClient(Login1.UserName, Login1.Password))
                    {
                            Response.Redirect(Request.RawUrl);
                    }
                    else Response.Redirect("~/Users/Klient/KlientForm.aspx");
                }
                else Response.Redirect("~/Users/Admin/AdminForm.aspx");
        }

        private bool tryConnectAsAdmin(string login, string password)
        {
            if (login.Equals("Admin") && password.Equals("123"))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", "AdminConneced", true);
                return true;
            }
            return false;
        }

        private bool tryConnectAsClient(string login, string password)
        {
            string KlienciQuerry = "select Id_K from Klient where Login=@Login and Haslo=@Password";
            int result = GetUserData(KlienciQuerry, login, password);
            if (result == -1)
            {
                return false;
            }
            else
            {
                Session["UserID"] = result;
                return true;
            }
        }

        private int GetUserData(string query, string Login, string Password )
        {
            using (SqlConnection sqlConn = new SqlConnection(Helper.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Password", Password);
                string x = "-1";
                try { x = cmd.ExecuteScalar().ToString(); }
                catch { sqlConn.Close(); return -1; }
                sqlConn.Close();
                return Convert.ToInt32(x);
            }
        }
    }
}