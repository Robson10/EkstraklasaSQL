using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Ekstraklasa.Klienci
{
    public partial class KlientForm : Form
    {
        private Klient _klient;
        private EkstraklasaEntities db = new EkstraklasaEntities();

        public KlientForm(Klient klient)
        {
            InitializeComponent();
            _klient = klient;
            this.BackColor = Helper.BackColor;
            Helper.DesignButton(BtSpotkania);
            Helper.DesignButton(BtListaZawodnikow);
            Helper.DesignButton(BtWynikiMeczy);
            Helper.DesignButton(LogOut);
            Helper.DesignButton(Exit);
            ComboDruzyna.Items.AddRange(db.Druzyna.Select(x => x.Nazwa).ToArray());
        }

        protected void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void BtSpotkania_Click(object sender, EventArgs e)
        {
            var query = " select Mecz.Id_M,Druzyna.Nazwa, Mecz.Kiedy" +
                        " from Ekstraklasa.dbo.Mecz" +
                        " inner join Ekstraklasa.dbo.Relationship_2 on Relationship_2.Id_M = Mecz.Id_M" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Relationship_2.Id_D" +
                        " where Mecz.Odbyty = 0";
            GridResults.Columns.Clear();
            Helper.SelectData(query, GridResults);
            for (int i = 0; i < GridResults.Rows.Count-1; i++)
            {
                if (GridResults[0, i].Value.Equals( GridResults[0, i + 1].Value))
                {
                    GridResults[1,i].Value = GridResults[1, i].Value+ " VS "+GridResults[1, i + 1].Value;
                    GridResults.Rows.RemoveAt(i + 1);
                }
            }
            GridResults.Columns[0].Visible = false;
        }

        private void BtWynikiMeczy_Click(object sender, EventArgs e)
        {
            var query = "select Mecz.Id_M,Druzyna.Nazwa,Punkty.Punkty" +
                        " from Ekstraklasa.dbo.Mecz" +
                        " inner join Ekstraklasa.dbo.Relationship_2 on Relationship_2.Id_M = Mecz.Id_M" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Relationship_2.Id_D" +
                        " inner join Ekstraklasa.dbo.Punkty on Druzyna.Id_D = Punkty.Id_P" +
                        " where Mecz.Odbyty = 1";
            GridResults.Columns.Clear();
            Helper.SelectData(query, GridResults);
            List<string> tempValue = new List<string>();
            for (int i = 0; i < GridResults.Rows.Count - 1; i++)
            {
                if (GridResults[0, i].Value.Equals(GridResults[0, i + 1].Value))
                {
                    GridResults[1, i].Value = GridResults[1, i].Value + " VS " + GridResults[1, i + 1].Value;
                    tempValue.Add(GridResults[2, i].Value + " - " + GridResults[2, i + 1].Value);
                    GridResults.Rows.RemoveAt(i + 1);
                }
            }

            GridResults.Columns[2].DataPropertyName = "String";
            for (int i = 0; i < tempValue.Count; i++)
            {
                GridResults[2, i].Value = tempValue[i];
            }
            GridResults.Columns[0].Visible = false;
        }

        private void BtListaZawodnikow_Click(object sender, EventArgs e)
        {
            var query = "select Druzyna.Nazwa as 'Druzyna',Zawodnik.Imie,Zawodnik.Nazwisko,Zawodnik.Pozycja,Zawodnik.KartkiCzerwone,Zawodnik.KartkiZolte from Ekstraklasa.dbo.Zawodnik" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Zawodnik.Id_D" +
                        " order by Druzyna.Id_D,Zawodnik.Nazwisko";
            GridResults.Columns.Clear();
            Helper.SelectData(query, GridResults);
        }

        private void ComboDruzyna_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query =
                "select Druzyna.Nazwa as 'Druzyna',Zawodnik.Imie,Zawodnik.Nazwisko,Zawodnik.Pozycja,Zawodnik.KartkiCzerwone,Zawodnik.KartkiZolte from Ekstraklasa.dbo.Zawodnik" +
                " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Zawodnik.Id_D" +
                " where Druzyna.Nazwa='" + ComboDruzyna.SelectedItem + "'" +
                " order by Druzyna.Id_D,Zawodnik.Nazwisko";
            GridResults.Columns.Clear();
            Helper.SelectData(query, GridResults);
        }
    }
}
