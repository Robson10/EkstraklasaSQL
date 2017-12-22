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
    public partial class NowyZawodnik : Form
    {
        public NowyZawodnik()
        {
            InitializeComponent();
            this.BackColor = Helper.BackColor;
            var queryTeams = " select Druzyna.Nazwa from Ekstraklasa.dbo.Druzyna";
            var tempTeams = Helper.SelectDataSet(queryTeams).Tables[0];
            for (int i = 0; i < tempTeams.Rows.Count; i++)
            {
                comboBox1.Items.Add(tempTeams.Rows[i].Field<string>(0));
            }
        }

        private void BtAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals(""))
            {
                MessageBox.Show("Nie wybrałeś druzyny");
            }
            else if (TbImie.Text.Equals(""))
            {
                MessageBox.Show("Nie podałeś imienia");
            }
            else if (TbNazwisko.Equals(""))
            {
                MessageBox.Show("Nie podałeś nazwiska");
            }
            else if (TbPozycja.Equals(""))
            {
                MessageBox.Show("Nie podałeś Pozycji");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                var druzyna_ID = Helper.SelectDataSet("select * from Druzyna where Druzyna.Nazwa= '" + comboBox1.SelectedItem + "'").Tables[0].Rows[0].Field<int>(0);
                Helper.InsertData("insert into Ekstraklasa.dbo.Zawodnik(Id_D,KartkiZolte,KartkiCzerwone,Imie,Nazwisko,Pozycja)" +
                                  " values(" + druzyna_ID + "," + 0 + "," + 0 + ",'" + TbImie.Text + "','" + TbNazwisko.Text + "','" + TbPozycja.Text + "')");
                this.Close();
            }
        }
    }
}
