using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekstraklasa
{
    public partial class Form1 : Form
    {
        EkstraklasaEntities db = new EkstraklasaEntities();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = Helper.Dc_borderStyle;
            this.Text = "Logowanie";
            LoginTB.Text = "Admin";
            PasswordTB.Text = "123";
            this.BackColor = Helper.BackColor;
            label1.ForeColor = Helper.ForeColor;
            label2.ForeColor = Helper.ForeColor;

            Zaloguj.BackColor = Helper.ButtonBackColor;
            Zaloguj.ForeColor = Helper.ForeColor;
            Exit.BackColor = Helper.ButtonBackColor;
            Exit.ForeColor = Helper.ForeColor;
        }
        
        private void Zaloguj_Click(object sender, EventArgs e)
        {

            if (LoginTB.Text.Equals("Admin") && PasswordTB.Text.Equals("123"))
                LogAsAdmin();
            else if (LogAsClient()) { }
            else
                MessageBox.Show("Błędne dane. Spróbuj ponownie.");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogAsAdmin()
        {
            Administrator.AdminForm AdminWindow = new Administrator.AdminForm();
            this.Hide();

                if (AdminWindow.ShowDialog() == DialogResult.OK)
                {
                    LoginTB.Text = "";
                    PasswordTB.Text = "";
                    this.Show();
                }

        }
        private bool LogAsClient()
        {
            if (db.Klient.ToList().Exists(x => x.Login.Equals(LoginTB.Text) && x.Haslo.Equals(PasswordTB.Text)))
            {
                Klienci.KlientForm KlientWindow = new Klienci.KlientForm(db.Klient.ToList().Find(x => x.Login.Equals(LoginTB.Text) && x.Haslo.Equals(PasswordTB.Text)));
                this.Hide();
                if (KlientWindow.ShowDialog() == DialogResult.OK)
                {
                    LoginTB.Text = "";
                    PasswordTB.Text = "";
                    this.Show();
                }
                return true;
            }
            return false;
        }
    }
}
