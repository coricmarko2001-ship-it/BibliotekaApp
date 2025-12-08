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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekat_biblioteka
{
    public partial class FormDodajKorisnika : Form
    {
        public FormDodajKorisnika()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;TrustServerCertificate=True");

        private void buttonRegistrujSeOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPregledKorisnika formPregledkorisnika = new FormPregledKorisnika();
            formPregledkorisnika.Show();
        }




        private void buttonRegistrujSePotvrdi_Click(object sender, EventArgs e)
        {

            conn.Open();
            if (!string.IsNullOrWhiteSpace(textBoxRegistracijaIme.Text)
                && !string.IsNullOrWhiteSpace(textBoxRegistracijaPrezime.Text)
                && !string.IsNullOrWhiteSpace(textBoxRegistracijaEmail.Text)
                && !string.IsNullOrWhiteSpace(comboBoxRegistrujSeMjesto.Text))

            {

                string sql = "INSERT INTO KORISNIK (IME, PREZIME, EMAIL, TELEFON, ULICA_I_BROJ, ID_MJESTA) VALUES (@ime, @prezime, @email, @telefon, @ulica, @idMjesta)";
                SqlCommand command = new SqlCommand(sql, conn);


                command.Parameters.AddWithValue("@ime", textBoxRegistracijaIme.Text);
                command.Parameters.AddWithValue("@prezime", textBoxRegistracijaPrezime.Text);
                command.Parameters.AddWithValue("@email", textBoxRegistracijaEmail.Text);
                command.Parameters.AddWithValue("@telefon", textBoxRegistracijaTelefon.Text);
                command.Parameters.AddWithValue("@ulica", textBoxRegistracijaUlicaiBroj.Text);
                command.Parameters.AddWithValue("@idMjesta", comboBoxRegistrujSeMjesto.SelectedValue);

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
            FormPregledKorisnika pregledKorisnika = new FormPregledKorisnika();
            pregledKorisnika.Show();
        }


        public void PopuniComboBoxMjesto()
        {
            conn.Open();


            String sql = "SELECT ID_MJESTA, NAZIV_MJESTA FROM MJESTO ORDER BY NAZIV_MJESTA";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtMjesto = new DataTable();

            while (!sqlDataReader.IsClosed)
            {
                dtMjesto.Load(sqlDataReader);
            }

            comboBoxRegistrujSeMjesto.DataSource = dtMjesto;
            comboBoxRegistrujSeMjesto.DisplayMember = "NAZIV_MJESTA";
            comboBoxRegistrujSeMjesto.ValueMember = "ID_MJESTA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        private void FormRegistracija_Load(object sender, EventArgs e)
        {
            PopuniComboBoxMjesto();
        }


        public void OsvjeziComboBoxMjesto()
        {
            PopuniComboBoxMjesto();
        }

        private void buttonDodajMjestoRegistracija_Click(object sender, EventArgs e)
        {

            FormDodajMjesto dodajMjesto = new FormDodajMjesto();
            dodajMjesto.Show();
        }
    }
}
