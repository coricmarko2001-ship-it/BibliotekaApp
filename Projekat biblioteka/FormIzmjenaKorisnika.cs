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
    public partial class FormIzmjenaKorisnika : Form
    {
        public FormIzmjenaKorisnika()
        {
            InitializeComponent();
        }


        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");


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

            comboBoxIzmjenaMjesto.DataSource = dtMjesto;
            comboBoxIzmjenaMjesto.DisplayMember = "NAZIV_MJESTA";
            comboBoxIzmjenaMjesto.ValueMember = "ID_MJESTA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }


        private int korisnikId;
        public FormIzmjenaKorisnika(int idKorisnika, string ime, string prezime, string email, string telefon, string ulicaBroj, string mjesto)
        : this()
        {
            textBoxIzmjenaIme.Text = ime;
            textBoxIzmjenaPrezime.Text = prezime;
            textBoxIzmjenaEmail.Text = email;
            textBoxIzmjenaTelefon.Text = telefon;
            textBoxIzmjenaUlicaiBroj.Text = ulicaBroj;

            korisnikId = idKorisnika;
            textBoxIDKorisnika.Text = korisnikId.ToString();
            textBoxIDKorisnika.Enabled = false;

            PopuniComboBoxMjesto();
            foreach (var item in comboBoxIzmjenaMjesto.Items)
            {
                DataRowView row = item as DataRowView;
                if (row != null && row["NAZIV_MJESTA"].ToString() == mjesto)
                {
                    comboBoxIzmjenaMjesto.SelectedItem = item;
                    break;
                }
            }

        }

        private void buttonRegistrujSeOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPregledKorisnika pregledKorisnika = new FormPregledKorisnika();
            pregledKorisnika.Show();
        }

        private void buttonRegistrujSePotvrdi_Click(object sender, EventArgs e)
        {
            if (textBoxIzmjenaIme.Text != ""
                && textBoxIzmjenaPrezime.Text != ""
                && textBoxIzmjenaEmail.Text != ""
                && comboBoxIzmjenaMjesto.Text != "")

            {
                conn.Open();


                SqlCommand sqlCommand;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                String sql = "UPDATE KORISNIK SET IME = '" + textBoxIzmjenaIme.Text + "', PREZIME = '" + textBoxIzmjenaPrezime.Text + "', " +
                            "EMAIL = '" + textBoxIzmjenaEmail.Text + "', "+ "TELEFON = '" + textBoxIzmjenaTelefon.Text + "', " +
                            "ULICA_I_BROJ = '" + textBoxIzmjenaUlicaiBroj.Text + "', " + "ID_MJESTA = '" + comboBoxIzmjenaMjesto.SelectedValue.ToString() + "'" +
                            " WHERE ID_KORISNIKA = '" + textBoxIDKorisnika.Text + "'";

                sqlCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();


                sqlCommand.Dispose();
                conn.Close();


                this.Close();
                FormPregledKorisnika knjiga = new FormPregledKorisnika();
                knjiga.Show();
            }
            else
            {
                MessageBox.Show("Popunite sve podatke.");

            }
        }


    }
}
