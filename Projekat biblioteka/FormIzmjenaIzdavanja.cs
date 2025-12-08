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
    public partial class FormIzmjenaIzdavanja : Form
    {
        public FormIzmjenaIzdavanja()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;TrustServerCertificate=True");


        public void PopuniComboBoxImeKorisnika()
        {
            conn.Open();


            String sql = "SELECT ID_KORISNIKA, IME + ' ' + PREZIME AS IME_PREZIME_KORISNIKA FROM KORISNIK ORDER BY IME";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtKorisnik = new DataTable();

            while (!sqlDataReader.IsClosed)
            {
                dtKorisnik.Load(sqlDataReader);
            }

            comboBoxImeKorisnikaIzdavanjeIzmjena.DataSource = dtKorisnik;
            comboBoxImeKorisnikaIzdavanjeIzmjena.DisplayMember = "IME_PREZIME_KORISNIKA";
            comboBoxImeKorisnikaIzdavanjeIzmjena.ValueMember = "ID_KORISNIKA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        public void PopuniComboBoxNazivKnjige()
        {
            conn.Open();


            String sql = "SELECT ID_KNJIGE, NAZIV_KNJIGE FROM KNJIGE ORDER BY NAZIV_KNJIGE";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtKnjige = new DataTable();

            while (!sqlDataReader.IsClosed)
            {
                dtKnjige.Load(sqlDataReader);
            }

            comboBoxImeKnjigeIzdavanjeIzmjena.DataSource = dtKnjige;
            comboBoxImeKnjigeIzdavanjeIzmjena.DisplayMember = "NAZIV_KNJIGE";
            comboBoxImeKnjigeIzdavanjeIzmjena.ValueMember = "ID_KNJIGE";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        public void PopuniComboBoxImeBibliotekara()
        {
            conn.Open();


            String sql = "SELECT ID_BIBLIOTEKARA, IME + ' ' + PREZIME AS IME_PREZIME_BIBLIOTEKARA FROM BIBLIOTEKAR ORDER BY IME";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtBibliotekar = new DataTable();

            while (!sqlDataReader.IsClosed)
            {
                dtBibliotekar.Load(sqlDataReader);
            }

            comboBoxBibliotekarIzdavanjeIzmjena.DataSource = dtBibliotekar;
            comboBoxBibliotekarIzdavanjeIzmjena.DisplayMember = "IME_PREZIME_BIBLIOTEKARA";
            comboBoxBibliotekarIzdavanjeIzmjena.ValueMember = "ID_BIBLIOTEKARA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }


        private int izdavanjeID;
        public FormIzmjenaIzdavanja(int idIzdavanja, DateTime datum_izdavanja, DateTime datum_vracanja, string idKorisnika, string id_Knjige, string id_Bibliotekara)
        : this()
        {
            dateTimePickerDatumIzdavanjaIzmjena.Value = datum_izdavanja;
            dateTimePickerDatumVracanjaIzmjena.Value = datum_vracanja;


            izdavanjeID = idIzdavanja;
            textBoxIDIzdavanja.Text = izdavanjeID.ToString();
            textBoxIDIzdavanja.Enabled = false;

            PopuniComboBoxImeKorisnika();
            foreach (var item in comboBoxImeKorisnikaIzdavanjeIzmjena.Items)
            {
                DataRowView row = item as DataRowView;
                if (row != null && row["IME_PREZIME_KORISNIKA"].ToString() == idKorisnika)
                {
                    comboBoxImeKorisnikaIzdavanjeIzmjena.SelectedItem = item;
                    break;
                }
            }

            PopuniComboBoxNazivKnjige();
            foreach (var item in comboBoxImeKnjigeIzdavanjeIzmjena.Items)
            {
                DataRowView row = item as DataRowView;
                if (row != null && row["NAZIV_KNJIGE"].ToString() == id_Knjige)
                {
                    comboBoxImeKnjigeIzdavanjeIzmjena.SelectedItem = item;
                    break;
                }
            }

            PopuniComboBoxImeBibliotekara();
            foreach (var item in comboBoxBibliotekarIzdavanjeIzmjena.Items)
            {
                DataRowView row = item as DataRowView;
                if (row != null && row["IME_PREZIME_BIBLIOTEKARA"].ToString() == id_Bibliotekara)
                {
                    comboBoxBibliotekarIzdavanjeIzmjena.SelectedItem = item;
                    break;
                }
            }


        }

        private void buttonPotvrdiIzdavanje_Click(object sender, EventArgs e)
        {
            if (comboBoxBibliotekarIzdavanjeIzmjena.Text != ""
                && comboBoxImeKnjigeIzdavanjeIzmjena.Text != ""
                && comboBoxImeKorisnikaIzdavanjeIzmjena.Text != "")

            {
                conn.Open();


                SqlCommand sqlCommand;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                string sql = "UPDATE IZDAVANJE SET DATUM_IZDAVANJA = '" + dateTimePickerDatumIzdavanjaIzmjena.Value.ToString("yyyy-MM-dd") + "', " +
                                "DATUM_VRACANJA = '" + dateTimePickerDatumVracanjaIzmjena.Value.ToString("yyyy-MM-dd") + "', " +
                                "ID_KORISNIKA = " + comboBoxImeKorisnikaIzdavanjeIzmjena.SelectedValue + ", " +
                                "ID_KNJIGE = " + comboBoxImeKnjigeIzdavanjeIzmjena.SelectedValue + ", " +
                                "ID_BIBLIOTEKARA = " + comboBoxBibliotekarIzdavanjeIzmjena.SelectedValue + " " +
                                "WHERE ID_IZDAVANJA = " + izdavanjeID;


                sqlCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();


                sqlCommand.Dispose();
                conn.Close();

                FormPregledIzdatihKnjiga knjiga = new FormPregledIzdatihKnjiga();
                knjiga.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Popunite sve podatke.");

            }
        }

        private void buttonOdustaniIzdavanjeIzmjena_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPregledIzdatihKnjiga knjiga = new FormPregledIzdatihKnjiga();
            knjiga.Show();
        }
    }

}
