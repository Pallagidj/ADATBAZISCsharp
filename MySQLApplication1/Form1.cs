using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQLApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            string jelszo = jelszotextBox.Text;
            DateTime regdatum = regDatum.Value;
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;"))
            {
                conn.Open();

                
                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev";
                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab != 0)
                {
                    MessageBox.Show("A usernev mar létezik");
                    return;
                }

                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO felhasznalo (nev,regdatum,jelszo) VALUES (@nev,@regdatum,@jelszo)";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@regdatum", regdatum);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                int erintettSorok = command.ExecuteNonQuery();


                }
            }
        private void updateButton_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            string jelszo = jelszotextBox.Text;
            DateTime regdatum = regDatum.Value;
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;"))
            {


                var frissites = conn.CreateCommand();
                frissites.CommandText = "UPDATE felhasznalo SET nev = @nev WHERE id=0";
                frissites.Parameters.AddWithValue("@nev", nev);
                var darab1 = (long)frissites.ExecuteScalar();
                if (darab1 == 0)
                {
                    MessageBox.Show("A user neve frissitve lett");
                    return;


                }
            }
        }
        private void deleteButt_Click(object sender, EventArgs e)
        {
            string nev = nevTextBox.Text;
            string jelszo = jelszotextBox.Text;
            DateTime regdatum = regDatum.Value;
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;"))
            {


                var torles = conn.CreateCommand();
                torles.CommandText = "DELETE FROM felhasznalo WHERE regdatum= @regdatum";
                torles.Parameters.AddWithValue("@regdatum", regdatum);
                var darab2 = (long)torles.ExecuteScalar();
                if (darab2 == 0)
                {
                    MessageBox.Show("A user torolve lett");
                    return;
                }
            }
        }

    }
    }

