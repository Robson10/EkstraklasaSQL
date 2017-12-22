﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EkstraklasaWeb.Users.Admin
{
    public partial class AdminForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            AddRow.Visible = false;
        }

        protected void BtNoweSpotkanie_Click(object sender, EventArgs e)
        {

        }

        protected void BtSpotkania_Click(object sender, EventArgs e)
        {
            var query = " select Mecz.Id_M,Druzyna.Nazwa, Mecz.Kiedy" +
                        " from Ekstraklasa.dbo.Mecz" +
                        " inner join Ekstraklasa.dbo.Relationship_2 on Relationship_2.Id_M = Mecz.Id_M" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Relationship_2.Id_D" +
                        " where Mecz.Odbyty = 0";
            GridView1.Columns.Clear();
            var temp = Helper.SelectDataSet(query).Tables[0];

            temp.Columns[1].ColumnName = "Drużyny";
            for (int i = 0; i < temp.Rows.Count - 1; i++)
            {
                if (temp.Rows[i][0].Equals(temp.Rows[i + 1][0]))
                {
                    temp.Rows[i][1] = temp.Rows[i][1] + " VS " + temp.Rows[i + 1][1];
                    temp.Rows[i + 1].Delete();
                }
            }
            AddRow.Visible = false;
            GridView1.AutoGenerateDeleteButton = false;
            GridView1.AutoGenerateEditButton = false;
            GridView1.AutoGenerateSelectButton = false;
            GridView1.DataSource = temp;
            GridView1.DataBind();
        }

        protected void BtZawodnicy_Click(object sender, EventArgs e)
        {
            var query = "select Druzyna.Id_D,Druzyna.Nazwa as 'Druzyna',Zawodnik.Imie,Zawodnik.Nazwisko,Zawodnik.Pozycja,Zawodnik.KartkiCzerwone,Zawodnik.KartkiZolte from Ekstraklasa.dbo.Zawodnik" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Zawodnik.Id_D" +
                        " order by Druzyna.Id_D,Zawodnik.Nazwisko";
            GridView1.Columns.Clear();
            Helper.SelectData(query, GridView1);
            AddRow.Visible = false;
            GridView1.AutoGenerateDeleteButton = false;
            GridView1.AutoGenerateEditButton = false;
            GridView1.AutoGenerateSelectButton = false;
            GridView1.DataBind();
        }

        protected void BtWyniki_Click(object sender, EventArgs e)
        {
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
            temp.Columns[2].DataType = typeof(string);
            for (int i = 0; i < tempValue.Count; i++)
            {
                temp.Rows[i][2] = tempValue[i];
            }
            AddRow.Visible = false;
            GridView1.AutoGenerateDeleteButton = false;
            GridView1.AutoGenerateEditButton = false;
            GridView1.AutoGenerateSelectButton = false;
            GridView1.DataSource = temp;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                Int32.Parse(e.Row.Cells[0].Text);
                e.Row.Cells[0].Visible = false;
            }
            catch
            {
                e.Row.Cells[1].Visible = false;
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        private void getDruzyna()
        {
            AddRow.Visible = true;
            var query = " select * from Druzyna";
            GridView1.Columns.Clear();
            var temp = Helper.SelectDataSet(query).Tables[0];
            GridView1.DataSource = temp;
            GridView1.AutoGenerateDeleteButton = true;
            GridView1.AutoGenerateEditButton = true;
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void BtDruzyny_Click(object sender, EventArgs e)
        {
            getDruzyna();
        }

        protected void BtNowyZawodnik_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            getDruzyna();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var querydelete = "delete from Druzyna where Id_D=" + e.Values[0];
            Helper.DeleteData(querydelete);
            getDruzyna();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var query = "update Druzyna" +
                        " set" +
                        " Trener = '" + e.NewValues[1] +" '," +
                        " Punkty = " + e.NewValues[2] + "," +
                        " Nazwa = '" + e.NewValues[3] + "'" +
                        " where Id_D = " + e.NewValues[0];
            Helper.UpdateData(query);
            GridView1.EditIndex = -1;

            getDruzyna();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            getDruzyna();
        }

        protected void AddRow_Click(object sender, EventArgs e)
        {
            var query = "insert into Druzyna(Trener,Punkty,Nazwa) values('new',0,'new')";
            Helper.InsertData(query);
            getDruzyna();
        }
    }
}