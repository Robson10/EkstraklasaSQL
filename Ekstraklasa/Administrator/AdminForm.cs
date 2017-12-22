using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekstraklasa.Administrator
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.BackColor = Helper.BackColor;
            myGrid.Visible = true;
            gridDruzyny.Visible = false;
            BtUsuń.Visible = false;
            AddRow.Visible = false;
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
            myGrid.Visible = true;
            gridDruzyny.Visible = false;
            BtUsuń.Visible = false;
            AddRow.Visible = false;
            var query = " select Mecz.Id_M,Druzyna.Nazwa, Mecz.Kiedy" +
                        " from Ekstraklasa.dbo.Mecz" +
                        " inner join Ekstraklasa.dbo.Relationship_2 on Relationship_2.Id_M = Mecz.Id_M" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Relationship_2.Id_D" +
                        " where Mecz.Odbyty = 0";
            myGrid.Columns.Clear();
            Helper.SelectData(query, myGrid);
            for (int i = 0; i < myGrid.Rows.Count - 1; i++)
            {
                if (myGrid[0, i].Value.Equals(myGrid[0, i + 1].Value))
                {
                    myGrid[1, i].Value = myGrid[1, i].Value + " VS " + myGrid[1, i + 1].Value;
                    myGrid.Rows.RemoveAt(i + 1);
                }
            }
            myGrid.Columns[0].Visible = false;
        }

        private void BtNoweSpotkanie_Click(object sender, EventArgs e)
        {
            NoweSpotkanieForm noweSpotkanieForm= new NoweSpotkanieForm();
            if (noweSpotkanieForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void BtZawodnik_Click(object sender, EventArgs e)
        {
            myGrid.Visible = true;
            gridDruzyny.Visible = false;
            BtUsuń.Visible = false;
            AddRow.Visible = false;
            var query = "select Druzyna.Nazwa as 'Druzyna',Zawodnik.Imie,Zawodnik.Nazwisko,Zawodnik.Pozycja,Zawodnik.KartkiCzerwone,Zawodnik.KartkiZolte from Ekstraklasa.dbo.Zawodnik" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Zawodnik.Id_D" +
                        " order by Druzyna.Id_D,Zawodnik.Nazwisko";
            myGrid.Columns.Clear();
            Helper.SelectData(query, myGrid);
        }

        private void BtDodajZawodnika_Click(object sender, EventArgs e)
        {
            NowyZawodnik nowyZawodnik = new NowyZawodnik();
            if (nowyZawodnik.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void BtDruzyny_Click(object sender, EventArgs e)
        {
            myGrid.Visible = false;
            gridDruzyny.Visible = true;
            BtUsuń.Visible = true;
            AddRow.Visible = true;
            Helper.SelectData("select * from Druzyna", gridDruzyny);
        }

        private EkstraklasaEntities db = new EkstraklasaEntities();
        private void gridDruzyny_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var id = Int32.Parse(gridDruzyny[0, e.RowIndex].Value.ToString());
            var query = "update Druzyna" +
                        " set" +
                        " Trener = '"+ gridDruzyny[1, e.RowIndex].Value.ToString() + 
                        " ', Punkty = "+ gridDruzyny[2, e.RowIndex].Value + "," +
                        " Nazwa = '"+ gridDruzyny[3, e.RowIndex].Value + "'" +
                        " where Id_D = " + id;
            Helper.UpdateData(query);
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            var query = "insert into Druzyna(Trener,Punkty,Nazwa) values('new',0,'new')";
            Helper.InsertData(query);
            Helper.SelectData("select * from Druzyna", gridDruzyny);
        }


        private void BtUsuń_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(gridDruzyny.Rows[gridDruzyny.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            var query = "delete from Druzyna where Id_D=" + id;
            Helper.DeleteData(query);
            gridDruzyny.Rows.RemoveAt(gridDruzyny.Rows.Count - 2);
            gridDruzyny.Columns.Clear();
            Helper.SelectData("select * from Druzyna", gridDruzyny);

        }

        private void BtWyniki_Click(object sender, EventArgs e)
        {
            myGrid.Visible = true;
            gridDruzyny.Visible = false;
            BtUsuń.Visible = false;
            AddRow.Visible = false;
            var query = "select Mecz.Id_M,Druzyna.Nazwa,Punkty.Punkty" +
                        " from Ekstraklasa.dbo.Mecz" +
                        " inner join Ekstraklasa.dbo.Relationship_2 on Relationship_2.Id_M = Mecz.Id_M" +
                        " inner join Ekstraklasa.dbo.Druzyna on Druzyna.Id_D = Relationship_2.Id_D" +
                        " inner join Ekstraklasa.dbo.Punkty on Druzyna.Id_D = Punkty.Id_P" +
                        " where Mecz.Odbyty = 1";
            myGrid.Columns.Clear();
            Helper.SelectData(query, myGrid);
            List<string> tempValue = new List<string>();
            for (int i = 0; i < myGrid.Rows.Count - 1; i++)
            {
                if (myGrid[0, i].Value.Equals(myGrid[0, i + 1].Value))
                {
                    myGrid[1, i].Value = myGrid[1, i].Value + " VS " + myGrid[1, i + 1].Value;
                    tempValue.Add(myGrid[2, i].Value + " - " + myGrid[2, i + 1].Value);
                    myGrid.Rows.RemoveAt(i + 1);
                }
            }

            myGrid.Columns[2].DataPropertyName = "String";
            for (int i = 0; i < tempValue.Count; i++)
            {
                myGrid[2, i].Value = tempValue[i];
            }
            myGrid.Columns[0].Visible = false;
        }
    }
}
