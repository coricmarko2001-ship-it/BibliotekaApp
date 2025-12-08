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
    public partial class FormVratiKnjigu : Form
    {
        public FormVratiKnjigu()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");

        private void buttonOdustaniVracanje_Click(object sender, EventArgs e)
        {
            this.Hide();
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

            comboBoxImeKorisnikaVracanje.DataSource = dtKorisnik;
            comboBoxImeKorisnikaVracanje.DisplayMember = "IME_PREZIME_KORISNIKA";
            comboBoxImeKorisnikaVracanje.ValueMember = "ID_KORISNIKA";

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

            comboBoxImeKnjigeVracanje.DataSource = dtKnjige;
            comboBoxImeKnjigeVracanje.DisplayMember = "NAZIV_KNJIGE";
            comboBoxImeKnjigeVracanje.ValueMember = "ID_KNJIGE";

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

            comboBoxBibliotekarVracanje.DataSource = dtBibliotekar;
            comboBoxBibliotekarVracanje.DisplayMember = "IME_PREZIME_BIBLIOTEKARA";
            comboBoxBibliotekarVracanje.ValueMember = "ID_BIBLIOTEKARA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }



        private void FormVratiKnjigu_Load(object sender, EventArgs e)
        {
            PopuniComboBoxImeKorisnika();
            PopuniComboBoxNazivKnjige();
            PopuniComboBoxImeBibliotekara();
        }


        private int DobaviIDIzdavanjaZaOdabraneVrijednosti()
        {

            string imeKorisnika = comboBoxImeKorisnikaVracanje.SelectedValue.ToString();

            string nazivKnjige = comboBoxImeKnjigeVracanje.SelectedValue.ToString();

            try
            {
                conn.Open();
                string sql = "SELECT ID_IZDAVANJA FROM IZDAVANJE WHERE ID_KORISNIKA = @imeKorisnika  AND ID_KNJIGE = @nazivKnjige";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@imeKorisnika", imeKorisnika);

                command.Parameters.AddWithValue("@nazivKnjige", nazivKnjige);
                int idIzdavanja = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();

                return idIzdavanja;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom dobavljanja ID izdavanja: " + ex.Message);
                return -1;
            }
        }
        private void buttonPotvrdiVracanje_Click(object sender, EventArgs e)
        {
            int idIzdavanja = DobaviIDIzdavanjaZaOdabraneVrijednosti();

            if (idIzdavanja != -1)
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM IZDAVANJE WHERE ID_IZDAVANJA = @idIzdavanja";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@idIzdavanja", idIzdavanja);
                    command.ExecuteNonQuery();
                    conn.Close();



                    MessageBox.Show("Knjiga je uspješno vraćena.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške prilikom vraćanja knjige: " + ex.Message);
                }
            }
        }
    }
}
