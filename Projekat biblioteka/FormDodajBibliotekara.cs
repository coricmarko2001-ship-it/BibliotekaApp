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

namespace Projekat_biblioteka
{
    public partial class FormDodajBibliotekara : Form
    {
        public FormDodajBibliotekara()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");


        private void buttonDodajBibliotekaraOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void buttonDodajBibliotekaraPotvrdi_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (!string.IsNullOrWhiteSpace(textBoxDodajBibliotekaraIme.Text)
                && !string.IsNullOrWhiteSpace(textBoxDodajBibliotekaraPrezime.Text)
                && !string.IsNullOrWhiteSpace(textBoxDodajBibliotekaraKorisnickoIme.Text)
                && !string.IsNullOrWhiteSpace(textBoxDodajBibliotekaraLozinka.Text))

            {

                string sql = "INSERT INTO BIBLIOTEKAR (IME, PREZIME, KORISNICKO_IME, LOZINKA) VALUES (@ime, @prezime, @korisnicko_ime, @lozinka)";
                SqlCommand command = new SqlCommand(sql, conn);


                command.Parameters.AddWithValue("@ime", textBoxDodajBibliotekaraIme.Text);
                command.Parameters.AddWithValue("@prezime", textBoxDodajBibliotekaraPrezime.Text);
                command.Parameters.AddWithValue("@korisnicko_ime", textBoxDodajBibliotekaraKorisnickoIme.Text);
                command.Parameters.AddWithValue("@lozinka", textBoxDodajBibliotekaraLozinka.Text);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspjesno ste registrovani.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dogodila se greska." + ex.Message);
                }
                finally
                {
                    conn.Close();
                    command.Dispose();
                }

            }
            else
            {
                MessageBox.Show("Neuspješno dodavanje. Popunite podatke koji su obavezni.");
            }
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
