using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

namespace EkstraklasaWeb.Users.Klient
{
    public partial class KlientForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ComboZawodnicy.Visible = false;
                var queryTeams = " select Druzyna.Nazwa from Ekstraklasa.dbo.Druzyna";
                var tempTeams = Helper.SelectDataSet(queryTeams).Tables[0];
                ComboZawodnicy.Items.Clear();
                for (int i = 0; i < tempTeams.Rows.Count; i++)
                {
                    ComboZawodnicy.Items.Add(tempTeams.Rows[i].Field<string>(0));
                }
            }
        }

        protected void BtSpotkania_Click(object sender, EventArgs e)
        {
            ComboZawodnicy.Visible = false;
            var query = " select Mecz.Id_M,Druzyna.Nazwa, Mecz.Kiedy" +
                        " from Ekstraklasa.dbo.Mecz" +
                        " inner join Ekstraklasa.dbo.Relationship_2 on Relationship_2.Id_M = Mecz.Id_M" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Relationship_2.Id_D" +
                        " where Mecz.Odbyty = 0";
            GridView1.Columns.Clear();
            var temp =Helper.SelectDataSet(query).Tables[0];

            temp.Columns[1].ColumnName = "Drużyny";
            for (int i = 0; i < temp.Rows.Count - 1; i++)
            {
                if (temp.Rows[i][0].Equals(temp.Rows[i+1][0]))
                {
                    temp.Rows[i][1] = temp.Rows[i][1] + " VS " + temp.Rows[i+1][1];
                    temp.Rows[i + 1].Delete();
                }
            }
            GridView1.DataSource = temp;
            GridView1.DataBind();
        }

        protected void BtWyniki_Click(object sender, EventArgs e)
        {
            ComboZawodnicy.Visible = false;
            var query = "select Mecz.Id_M,Druzyna.Nazwa,Punkty.Punkty" +
                        " from Ekstraklasa.dbo.Mecz" +
                        " inner join Ekstraklasa.dbo.Relationship_2 on Relationship_2.Id_M = Mecz.Id_M" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Relationship_2.Id_D" +
                        " inner join Ekstraklasa.dbo.Punkty on Druzyna.Id_D = Punkty.Id_P" +
                        " where Mecz.Odbyty = 1";
            GridView1.Columns.Clear();
            var temp = Helper.SelectDataSet(query).Tables[0];
            List<string> tempValue = new List<string>();
            for (int i = 0; i < temp.Rows.Count - 1; i++)
            {
                if (temp.Rows[i][0].Equals(temp.Rows[i + 1][0]))
                {
                    temp.Rows[i][1] = temp.Rows[i][1] + " - " + temp.Rows[i + 1][1];
                    tempValue.Add(temp.Rows[i][2] + " - " + temp.Rows[i + 1][2]);
                    temp.Rows.RemoveAt(i + 1);
                }
            }
            temp.Columns.RemoveAt(2);
            temp.Columns.Add("Wyniki");
            temp.Columns[2].DataType= typeof(string);
            for (int i = 0; i < tempValue.Count; i++)
            {
                temp.Rows[i][2] = tempValue[i];
            }

            GridView1.DataSource = temp;
            GridView1.DataBind();
        }

        protected void BtZawodnicy_Click(object sender, EventArgs e)
        {
            ComboZawodnicy.Visible = true;
            var query = "select Druzyna.Id_D,Druzyna.Nazwa as 'Druzyna',Zawodnik.Imie,Zawodnik.Nazwisko,Zawodnik.Pozycja,Zawodnik.KartkiCzerwone,Zawodnik.KartkiZolte from Ekstraklasa.dbo.Zawodnik" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Zawodnik.Id_D" +
                        " order by Druzyna.Id_D,Zawodnik.Nazwisko";
            GridView1.Columns.Clear();
            Helper.SelectData(query, GridView1);
            GridView1.DataBind();
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
        }

        protected void ComboZawodnicy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query =
                "select Druzyna.Id_D,Druzyna.Nazwa as 'Druzyna',Zawodnik.Imie,Zawodnik.Nazwisko,Zawodnik.Pozycja,Zawodnik.KartkiCzerwone,Zawodnik.KartkiZolte from Ekstraklasa.dbo.Zawodnik" +
                " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Zawodnik.Id_D" +
                " where Druzyna.Nazwa='" + ComboZawodnicy.SelectedItem + "'" +
                " order by Druzyna.Id_D,Zawodnik.Nazwisko";
            GridView1.Columns.Clear();
            Helper.SelectData(query, GridView1);
            GridView1.DataBind();
        }
    }
}