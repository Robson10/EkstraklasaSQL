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
    public partial class NoweSpotkanieForm : Form
    {
        public NoweSpotkanieForm()
        {
            InitializeComponent();
            fillCombos();
            this.BackColor = Helper.BackColor;
        }

        private void fillCombos()
        {
            var queryTeams = " select Druzyna.Nazwa from Ekstraklasa.dbo.Druzyna";
            var tempTeams = Helper.SelectDataSet(queryTeams).Tables[0];
            for (int i = 0; i < tempTeams.Rows.Count; i++)
            {
                comboBoxDruzynaA.Items.Add(tempTeams.Rows[i].Field<string>(0));
                comboBoxDruzynaB.Items.Add(tempTeams.Rows[i].Field<string>(0));
            }
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            if (comboBoxDruzynaA.SelectedItem.Equals(""))
            {
                MessageBox.Show("Nie wybrałeś druzyny A");
            }
            else if (comboBoxDruzynaB.SelectedItem.Equals(""))
            {
                MessageBox.Show("Nie wybrałeś druzyny B");
            }
            else if (comboBoxDruzynaA.SelectedItem.Equals(comboBoxDruzynaB.SelectedItem))
            {
                MessageBox.Show("Wybrałeś dwie te same druzyny");
            }
            else if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Wybrałeś datę wstecz");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                var x = dateTimePicker1.Value;
                string kiedy = "'" + x.Year + "." +
                                 ((x.Month < 10) ? ("0" + x.Month.ToString()) : x.Month.ToString()) + "." +
                                 ((x.Day < 10) ? "0" + x.Day.ToString() : x.Day.ToString()) + "'";

                Helper.InsertData("insert into Ekstraklasa.dbo.Mecz(Odbyty, Kiedy) values(0,"+kiedy+")");
               
                var druzyna_A_Id= Helper.SelectDataSet("select * from Druzyna where Druzyna.Nazwa= '" +comboBoxDruzynaA.SelectedItem + "'").Tables[0].Rows[0].Field<int>(0);
                var druzyna_B_Id = Helper.SelectDataSet("select * from Druzyna where Druzyna.Nazwa= '" + comboBoxDruzynaB.SelectedItem + "'").Tables[0].Rows[0].Field<int>(0);
                var Mecz_id = Helper.SelectDataSet("select * from Mecz where Mecz.Kiedy = " + kiedy + "").Tables[0].Rows[0].Field<int>(0);

                Helper.InsertData("insert into Ekstraklasa.dbo.Relationship_2(Id_D, Id_M)values("+druzyna_A_Id+","+Mecz_id+")");
                Helper.InsertData("insert into Ekstraklasa.dbo.Relationship_2(Id_D, Id_M)values(" + druzyna_B_Id + "," + Mecz_id + ")");
            }

        }

        private void BtAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
