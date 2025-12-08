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
    public partial class FormIzdajKnjigu : Form
    {
        public FormIzdajKnjigu()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");


        private void buttonOdustaniIzdavanje_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonIznajmiIzdavanje_Click(object sender, EventArgs e)
        {

            conn.Open();

            if (comboBoxImeKorisnikaIzdavanje.SelectedValue != null
                && comboBoxImeKnjigeIzdavanje.SelectedValue != null
                && comboBoxBibliotekarIzdavanje.SelectedValue != null)
            {
                int idKorisnika = Convert.ToInt32(comboBoxImeKorisnikaIzdavanje.SelectedValue);
                int id_Knjige = Convert.ToInt32(comboBoxImeKnjigeIzdavanje.SelectedValue);
                int id_Bibliotekara = Convert.ToInt32(comboBoxBibliotekarIzdavanje.SelectedValue);
                DateTime datum_izdavanja = dateTimePickerDatumIzdavanja.Value;
                DateTime datum_vracanja = dateTimePickerDatumVracanja.Value;


                string provjeraSql = "SELECT COUNT(*) FROM IZDAVANJE WHERE ID_KORISNIKA = @idKorisnika AND ID_KNJIGE = @id_Knjige";
                SqlCommand provjeraCommand = new SqlCommand(provjeraSql, conn);
                provjeraCommand.Parameters.AddWithValue("@idKorisnika", idKorisnika);
                provjeraCommand.Parameters.AddWithValue("@id_Knjige", id_Knjige);

                int brojIzdavanja = (int)provjeraCommand.ExecuteScalar();

                if (brojIzdavanja > 0)
                {
                    MessageBox.Show("Korisnik već posjeduje odabranu knjigu.");
                }
                else
                {
                    string sql = "INSERT INTO IZDAVANJE VALUES (@datum_izdavanja, @datum_vracanja, @idKorisnika, @id_Knjige, @id_Bibliotekara)";
                    SqlCommand command = new SqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@datum_izdavanja", datum_izdavanja);
                    command.Parameters.AddWithValue("@datum_vracanja", datum_vracanja);
                    command.Parameters.AddWithValue("@idKorisnika", idKorisnika);
                    command.Parameters.AddWithValue("@id_Knjige", id_Knjige);
                    command.Parameters.AddWithValue("@id_Bibliotekara", id_Bibliotekara);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Uspješno ste izdali knjigu.");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dogodila se greška." + ex.Message);
                    }

                    command.Dispose();
                }

                provjeraCommand.Dispose();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Nije odabrano sve potrebno.");
                this.Close();
            }



        }

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

            comboBoxImeKorisnikaIzdavanje.DataSource = dtKorisnik;
            comboBoxImeKorisnikaIzdavanje.DisplayMember = "IME_PREZIME_KORISNIKA";
            comboBoxImeKorisnikaIzdavanje.ValueMember = "ID_KORISNIKA";

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

            comboBoxImeKnjigeIzdavanje.DataSource = dtKnjige;
            comboBoxImeKnjigeIzdavanje.DisplayMember = "NAZIV_KNJIGE";
            comboBoxImeKnjigeIzdavanje.ValueMember = "ID_KNJIGE";

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

            comboBoxBibliotekarIzdavanje.DataSource = dtBibliotekar;
            comboBoxBibliotekarIzdavanje.DisplayMember = "IME_PREZIME_BIBLIOTEKARA";
            comboBoxBibliotekarIzdavanje.ValueMember = "ID_BIBLIOTEKARA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }



        private void FormIzdajKnjigu_Load(object sender, EventArgs e)
        {
            PopuniComboBoxImeKorisnika();
            PopuniComboBoxNazivKnjige();
            PopuniComboBoxImeBibliotekara();
        }
    }
}
