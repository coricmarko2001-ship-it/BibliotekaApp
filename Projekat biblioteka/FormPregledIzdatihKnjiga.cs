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
    public partial class FormPregledIzdatihKnjiga : Form
    {
        public FormPregledIzdatihKnjiga()
        {
            InitializeComponent();
        }
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");


        private void buttonIzadjiiznajmljivanje_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormPregledIzdatihKnjiga_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT IZDAVANJE.ID_IZDAVANJA AS 'ID izdavanja', IZDAVANJE.DATUM_IZDAVANJA AS 'Datum izdavanja', IZDAVANJE.DATUM_VRACANJA AS 'Datum vraćanja', CONCAT(KORISNIK.IME, ' ', KORISNIK.PREZIME) AS 'Ime i prezime korisnika', KNJIGE.NAZIV_KNJIGE AS 'Naziv knjige', CONCAT(BIBLIOTEKAR.IME, ' ', BIBLIOTEKAR.PREZIME) AS 'Ime i prezime bibliotekara'" +
                            "FROM IZDAVANJE " +
                            "JOIN KORISNIK ON IZDAVANJE.ID_KORISNIKA = KORISNIK.ID_KORISNIKA " +
                            "JOIN KNJIGE ON IZDAVANJE.ID_KNJIGE = KNJIGE.ID_KNJIGE " +
                            "JOIN BIBLIOTEKAR ON IZDAVANJE.ID_BIBLIOTEKARA = BIBLIOTEKAR.ID_BIBLIOTEKARA";



            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledIzdatihKnjiga.DataSource = ds.Tables[0];
            conn.Close();
            command.Dispose();

            dataGridViewPregledIzdatihKnjiga.ClearSelection();

        }

        private void textBoxPregledPoImenuKorisnika_TextChanged(object sender, EventArgs e)
        {
            string imeKorisnika = textBoxPregledPoImenuKorisnika.Text.Trim();

            if (!string.IsNullOrEmpty(imeKorisnika))
            {
                conn.Open();

                string sql = "SELECT IZDAVANJE.ID_IZDAVANJA AS 'ID izdavanja', IZDAVANJE.DATUM_IZDAVANJA AS 'Datum izdavanja', IZDAVANJE.DATUM_VRACANJA AS 'Datum vraćanja', CONCAT(KORISNIK.IME, ' ', KORISNIK.PREZIME) AS 'Ime i prezime korisnika', KNJIGE.NAZIV_KNJIGE AS 'Naziv knjige', CONCAT(BIBLIOTEKAR.IME, ' ', BIBLIOTEKAR.PREZIME) AS 'Ime i prezime bibliotekara'" +
                                 " FROM IZDAVANJE" +
                                 " JOIN KORISNIK ON IZDAVANJE.ID_KORISNIKA = KORISNIK.ID_KORISNIKA" +
                                 " JOIN KNJIGE ON IZDAVANJE.ID_KNJIGE = KNJIGE.ID_KNJIGE" +
                                 " JOIN BIBLIOTEKAR ON IZDAVANJE.ID_BIBLIOTEKARA = BIBLIOTEKAR.ID_BIBLIOTEKARA" +
                                 " WHERE LOWER(CONCAT(KORISNIK.IME, ' ', KORISNIK.PREZIME)) LIKE @imeKorisnika";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@imeKorisnika", "%" + imeKorisnika.ToLower() + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledIzdatihKnjiga.DataSource = ds.Tables[0];

                conn.Close();
            }
            else
            {
                OsvjeziPrikazIzdavanja();
            }
        }



        public void OsvjeziPrikazIzdavanja()
        {
            conn.Open();

            string sql = "SELECT IZDAVANJE.ID_IZDAVANJA AS 'ID izdavanja', IZDAVANJE.DATUM_IZDAVANJA AS 'Datum izdavanja', IZDAVANJE.DATUM_VRACANJA AS 'Datum vraćanja', CONCAT(KORISNIK.IME, ' ', KORISNIK.PREZIME) AS 'Ime i prezime korisnika', KNJIGE.NAZIV_KNJIGE AS 'Naziv knjige', CONCAT(BIBLIOTEKAR.IME, ' ', BIBLIOTEKAR.PREZIME) AS 'Ime i prezime bibliotekara'" +
                            "FROM IZDAVANJE " +
                            "JOIN KORISNIK ON IZDAVANJE.ID_KORISNIKA = KORISNIK.ID_KORISNIKA " +
                            "JOIN KNJIGE ON IZDAVANJE.ID_KNJIGE = KNJIGE.ID_KNJIGE " +
                            "JOIN BIBLIOTEKAR ON IZDAVANJE.ID_BIBLIOTEKARA = BIBLIOTEKAR.ID_BIBLIOTEKARA";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledIzdatihKnjiga.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();
        }

        private void buttonObrisiiznajmljivanje_Click(object sender, EventArgs e)
        {
            if (dataGridViewPregledIzdatihKnjiga.SelectedRows.Count == 0 && dataGridViewPregledIzdatihKnjiga.SelectedCells.Count == 0)
            {
                MessageBox.Show("Morate selektovati red ili ćeliju da biste obrisali izdavanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewPregledIzdatihKnjiga.SelectedRows)
            {
                int idIzdavanja = Convert.ToInt32(row.Cells["ID Izdavanja"].Value);

                conn.Open();
                string sql = "DELETE FROM IZDAVANJE WHERE ID_IZDAVANJA = @idIzdavanja";
                SqlCommand deleteCommand = new SqlCommand(sql, conn);
                deleteCommand.Parameters.AddWithValue("@idIzdavanja", idIzdavanja);
                deleteCommand.ExecuteNonQuery();
                conn.Close();

            }

            foreach (DataGridViewCell cell in dataGridViewPregledIzdatihKnjiga.SelectedCells)
            {
                if (!dataGridViewPregledIzdatihKnjiga.SelectedRows.Contains(cell.OwningRow))
                {
                    int rowIndex = cell.RowIndex;
                    int idIzdavanja = Convert.ToInt32(dataGridViewPregledIzdatihKnjiga.Rows[rowIndex].Cells["ID Izdavanja"].Value);


                    conn.Open();
                    string sql = "DELETE FROM IZDAVANJE WHERE ID_IZDAVANJA = @idIzdavanja";
                    SqlCommand deleteCommand = new SqlCommand(sql, conn);
                    deleteCommand.Parameters.AddWithValue("@idIzdavanja", idIzdavanja);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }

            OsvjeziPrikazIzdavanja();
        }

        private void buttonIzmijeniIznajmljivanje_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewSelectedRowCollection selectedRows = dataGridViewPregledIzdatihKnjiga.SelectedRows;

            if (selectedRows.Count == 0)
            {
                if (dataGridViewPregledIzdatihKnjiga.SelectedCells.Count > 0)
                {
                    DataGridViewCell cell = dataGridViewPregledIzdatihKnjiga.SelectedCells[0];
                    int rowIndex = cell.RowIndex;

                    DataGridViewRow selectedRow = dataGridViewPregledIzdatihKnjiga.Rows[rowIndex];

                    int idIzdavanja = Convert.ToInt32(selectedRow.Cells["ID Izdavanja"].Value);
                    string idKorisnika = selectedRow.Cells["Ime i prezime korisnika"].Value.ToString();
                    string id_Knjige = selectedRow.Cells["Naziv knjige"].Value.ToString();
                    string id_Bibliotekara = selectedRow.Cells["Ime i prezime bibliotekara"].Value.ToString();
                    DateTime datum_izdavanja = Convert.ToDateTime(selectedRow.Cells["Datum izdavanja"].Value);
                    DateTime datum_vracanja = Convert.ToDateTime(selectedRow.Cells["Datum vraćanja"].Value); ;



                    FormIzmjenaIzdavanja izdavanje = new FormIzmjenaIzdavanja(idIzdavanja, datum_izdavanja, datum_vracanja, idKorisnika, id_Knjige, id_Bibliotekara);
                    izdavanje.Show();
                }
                else
                {
                    MessageBox.Show("Molimo vas da odaberete korisnika za izmjenu.");
                    FormPregledIzdatihKnjiga knjiga = new FormPregledIzdatihKnjiga();
                    knjiga.Show();
                }
            }



            else if (selectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = selectedRows[0];

                int idIzdavanja = Convert.ToInt32(selectedRow.Cells["ID Izdavanja"].Value);
                string idKorisnika = selectedRow.Cells["Ime i prezime korisnika"].Value.ToString();
                string id_Knjige = selectedRow.Cells["Naziv knjige"].Value.ToString();
                string id_Bibliotekara = selectedRow.Cells["Ime i prezime bibliotekara"].Value.ToString();
                DateTime datum_izdavanja = Convert.ToDateTime(selectedRow.Cells["Datum izdavanja"].Value);
                DateTime datum_vracanja = Convert.ToDateTime(selectedRow.Cells["Datum vraćanja"].Value); ; ;



                FormIzmjenaIzdavanja izdavanje = new FormIzmjenaIzdavanja(idIzdavanja, datum_izdavanja, datum_vracanja, idKorisnika, id_Knjige, id_Bibliotekara);
                izdavanje.Show();


            }
            else
            {
                MessageBox.Show("Možete izmijeniti samo jednog korisnika odjednom.");
            }
        }
    }
}
