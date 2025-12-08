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
    public partial class FormDodajIzdavaca : Form
    {
        public FormDodajIzdavaca()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");

        private void buttonDodajIzdavacaOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonDodajIzdavacaPotvrdi_Click(object sender, EventArgs e)
        {
            if (textBoxDodajIzdavacaNaziv.Text != ""
                && textBoxDodajIzdavacaKontakt.Text != ""
                && !string.IsNullOrWhiteSpace(comboBoxDodajIzdavacaMjesto.Text))
            {
                conn.Open();
                string sql = "INSERT INTO IZDAVACI (NAZIV_IZDAVACA, KONTAKT_TELEFON, ID_MJESTA) VALUES (@naziv_izdavaca, @kontakt, @mjesto)";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@naziv_izdavaca", textBoxDodajIzdavacaNaziv.Text);
                command.Parameters.AddWithValue("@kontakt", textBoxDodajIzdavacaKontakt.Text);
                command.Parameters.AddWithValue("@mjesto", comboBoxDodajIzdavacaMjesto.SelectedValue);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspjesno ste dodali izdavaca.");

                    FormDodajKnjigu knjiga = Application.OpenForms.OfType<FormDodajKnjigu>().FirstOrDefault();
                    if (knjiga != null)
                    {
                        knjiga.OsvjeziComboBoxIzdavaca();
                    }

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

            FormPregledIzdavaca izadavac = new FormPregledIzdavaca();
            izadavac.Show();
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

            comboBoxDodajIzdavacaMjesto.DataSource = dtMjesto;
            comboBoxDodajIzdavacaMjesto.DisplayMember = "NAZIV_MJESTA";
            comboBoxDodajIzdavacaMjesto.ValueMember = "ID_MJESTA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        private void FormDodajIzdavaca_Load(object sender, EventArgs e)
        {
            PopuniComboBoxMjesto();
        }

        private void buttonDodajMjestoIzdavac_Click(object sender, EventArgs e)
        {
            FormDodajMjesto dodajMjesto = new FormDodajMjesto();
            dodajMjesto.Show();
        }
    }
}
