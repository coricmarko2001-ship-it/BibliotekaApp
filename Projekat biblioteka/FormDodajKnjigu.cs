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
    public partial class FormDodajKnjigu : Form
    {
        public FormDodajKnjigu()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;TrustServerCertificate=True");



        private void buttonDodajKnjiguOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPregledKnjiga knjiga = new FormPregledKnjiga();
            knjiga.Show();
        }

        private void buttonDodajKnjiguPotvrdi_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBoxNazivKnjige.Text != ""
                && comboBoxDodajAutoraKnjiga.SelectedValue != null
                && comboBoxDodajZanrKnjiga.SelectedValue != null
                && comboBoxDodajIzdavacaKnjiga.SelectedValue != null
                && textBoxBrojDostupnihKnjiga.Text != ""
                && textBoxUkupanBrojKnjiga.Text != "")
            {

                int idAutora = Convert.ToInt32(comboBoxDodajAutoraKnjiga.SelectedValue);
                int id_Zanra = Convert.ToInt32(comboBoxDodajZanrKnjiga.SelectedValue);
                int id_Izdavaca = Convert.ToInt32(comboBoxDodajIzdavacaKnjiga.SelectedValue);
                int godinaIzdanja = dateTimePickerGodinaIzdanja.Value.Year;


                string sql = "INSERT INTO KNJIGE VALUES (@nazivKnjige, @godinaIzdanja, @broj_dostupnih_knjiga, @ukupan_broj_knjiga, @imeAutora, @zanr, @izdavac)";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@nazivKnjige", textBoxNazivKnjige.Text);
                command.Parameters.AddWithValue("@imeAutora", idAutora);
                command.Parameters.AddWithValue("@zanr", id_Zanra);
                command.Parameters.AddWithValue("@izdavac", id_Izdavaca);
                command.Parameters.AddWithValue("@godinaIzdanja", godinaIzdanja);
                command.Parameters.AddWithValue("@ukupan_broj_knjiga", textBoxUkupanBrojKnjiga.Text);
                command.Parameters.AddWithValue("@broj_dostupnih_knjiga", textBoxBrojDostupnihKnjiga.Text);


                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspjesno ste dodali knjigu.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dogodila se greska." + ex.Message);
                }
                conn.Close();
            }

            else
            {
                MessageBox.Show("Neuspješno dodavanje.");
                this.Close();
            }


            FormPregledKnjiga knjiga = new FormPregledKnjiga();
            knjiga.Show();


        }

        private void buttonDodajZanrKnjiga_Click(object sender, EventArgs e)
        {
            FormDodajZanr zanr = new FormDodajZanr();
            zanr.Show();
        }

        private void buttonDodajAutoraKnjiga_Click(object sender, EventArgs e)
        {
            FormDodajAutora autor = new FormDodajAutora();
            autor.Show();
        }

        private void buttonDodajIzdavacaKnjiga_Click(object sender, EventArgs e)
        {
            FormDodajIzdavaca izdavac = new FormDodajIzdavaca();
            izdavac.Show();
        }

        public void PopuniComboBoxImeAutora()
        {
            conn.Open();


            String sql = "SELECT ID_AUTORA, IME_AUTORA + ' ' + PREZIME_AUTORA AS IME_PREZIME_AUTORA FROM AUTORI ORDER BY IME_AUTORA";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtAutor = new DataTable();

            while (!sqlDataReader.IsClosed)
            {
                dtAutor.Load(sqlDataReader);
            }

            comboBoxDodajAutoraKnjiga.DataSource = dtAutor;
            comboBoxDodajAutoraKnjiga.DisplayMember = "IME_PREZIME_AUTORA";
            comboBoxDodajAutoraKnjiga.ValueMember = "ID_AUTORA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        public void PopuniComboBoxZanr()
        {
            conn.Open();


            String sql = "SELECT ID_ZANRA, NAZIV_ZANRA FROM ZANR ORDER BY NAZIV_ZANRA";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtZanr = new DataTable();

            while (!sqlDataReader.IsClosed)
            {
                dtZanr.Load(sqlDataReader);
            }

            comboBoxDodajZanrKnjiga.DataSource = dtZanr;
            comboBoxDodajZanrKnjiga.DisplayMember = "NAZIV_ZANRA";
            comboBoxDodajZanrKnjiga.ValueMember = "ID_ZANRA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        public void PopuniComboBoxIzdavaci()
        {
            conn.Open();


            String sql = "SELECT ID_IZDAVACA, NAZIV_IZDAVACA FROM IZDAVACI ORDER BY NAZIV_IZDAVACA";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtIzdavac = new DataTable();

            while (!sqlDataReader.IsClosed)
            {
                dtIzdavac.Load(sqlDataReader);
            }

            comboBoxDodajIzdavacaKnjiga.DataSource = dtIzdavac;
            comboBoxDodajIzdavacaKnjiga.DisplayMember = "NAZIV_IZDAVACA";
            comboBoxDodajIzdavacaKnjiga.ValueMember = "ID_IZDAVACA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        public void OsvjeziComboBoxZanr()
        {
            PopuniComboBoxZanr();
        }



        private void FormDodajKnjigu_Load(object sender, EventArgs e)
        {
            PopuniComboBoxImeAutora();
            PopuniComboBoxZanr();
            PopuniComboBoxIzdavaci();
        }


        public void OsvjeziComboBoxIzdavaca()
        {
            PopuniComboBoxIzdavaci();
        }

    }
}
