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
    public partial class FormPregledKnjiga : Form
    {
        public FormPregledKnjiga()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;TrustServerCertificate=True");




        private void buttonDodajKnjiguPregledKnjiga_Click(object sender, EventArgs e)
        {
            FormDodajKnjigu dodaj = new FormDodajKnjigu();
            this.Hide();
            dodaj.Show();
        }

        private void FormPregledKnjiga_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT KNJIGE.ID_KNJIGE AS 'ID knjige', KNJIGE.NAZIV_KNJIGE AS 'Naziv knjige', KNJIGE.GODINA_IZDANJA AS 'Godina izdanja', KNJIGE.BROJ_DOSTUPNIH_KNJIGA AS 'Broj dostupnih knjiga', KNJIGE.UKUPAN_BROJ_KNJIGA AS 'Ukupan broj knjiga', CONCAT(AUTORI.IME_AUTORA, ' ', AUTORI.PREZIME_AUTORA) AS 'Ime i prezime', ZANR.NAZIV_ZANRA AS 'Naziv žanra', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv izdavača'" +
                            "FROM KNJIGE " +
                            "JOIN AUTORI ON KNJIGE.ID_AUTORA = AUTORI.ID_AUTORA " +
                            "JOIN ZANR ON KNJIGE.ID_ZANRA = ZANR.ID_ZANRA " +
                            "JOIN IZDAVACI ON KNJIGE.ID_IZDAVACA = IZDAVACI.ID_IZDAVACA";

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledKnjiga.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();

        }


        private void buttonIzadjiPregledKnjiga_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBoxPretraziPoImenuKnjige_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxPretraziPoImenuKnjige.Text.ToLower();

            if (textBoxPretraziPoImenuKnjige.Text != "")
            {
                conn.Open();

                string sql = "SELECT KNJIGE.ID_KNJIGE AS 'ID knjige', KNJIGE.NAZIV_KNJIGE AS 'Naziv knjige', KNJIGE.GODINA_IZDANJA AS 'Godina izdanja', KNJIGE.BROJ_DOSTUPNIH_KNJIGA AS 'Broj dostupnih knjiga', KNJIGE.UKUPAN_BROJ_KNJIGA AS 'Ukupan broj knjiga', CONCAT(AUTORI.IME_AUTORA, ' ', AUTORI.PREZIME_AUTORA) AS 'Ime i prezime', ZANR.NAZIV_ZANRA AS 'Naziv žanra', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv izdavača' " +
                               "FROM KNJIGE " +
                               "JOIN AUTORI ON KNJIGE.ID_AUTORA = AUTORI.ID_AUTORA " +
                               "JOIN ZANR ON KNJIGE.ID_ZANRA = ZANR.ID_ZANRA " +
                               "JOIN IZDAVACI ON KNJIGE.ID_IZDAVACA = IZDAVACI.ID_IZDAVACA " +
                               "WHERE LOWER(KNJIGE.NAZIV_KNJIGE) LIKE '%" + searchText + "%'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledKnjiga.DataSource = ds.Tables[0];
                conn.Close();

            }

            else
            {
                conn.Open();

                string sql = "SELECT KNJIGE.ID_KNJIGE AS 'ID knjige', KNJIGE.NAZIV_KNJIGE AS 'Naziv knjige', KNJIGE.GODINA_IZDANJA AS 'Godina izdanja', KNJIGE.BROJ_DOSTUPNIH_KNJIGA AS 'Broj dostupnih knjiga', KNJIGE.UKUPAN_BROJ_KNJIGA AS 'Ukupan broj knjiga', CONCAT(AUTORI.IME_AUTORA, ' ', AUTORI.PREZIME_AUTORA) AS 'Ime i prezime', ZANR.NAZIV_ZANRA AS 'Naziv žanra', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv izdavača' " +
                                 "FROM KNJIGE " +
                                 "JOIN AUTORI ON KNJIGE.ID_AUTORA = AUTORI.ID_AUTORA " +
                                 "JOIN ZANR ON KNJIGE.ID_ZANRA = ZANR.ID_ZANRA " +
                                 "JOIN IZDAVACI ON KNJIGE.ID_IZDAVACA = IZDAVACI.ID_IZDAVACA";

                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledKnjiga.DataSource = ds.Tables[0];
                conn.Close();
            }
        }







        private void OsvjeziPrikazKnjiga()
        {
            conn.Open();

            string sql = "SELECT KNJIGE.ID_KNJIGE AS 'ID knjige', KNJIGE.NAZIV_KNJIGE AS 'Naziv knjige', KNJIGE.GODINA_IZDANJA AS 'Godina izdanja', KNJIGE.BROJ_DOSTUPNIH_KNJIGA AS 'Broj dostupnih knjiga', KNJIGE.UKUPAN_BROJ_KNJIGA AS 'Ukupan broj knjiga', CONCAT(AUTORI.IME_AUTORA, ' ', AUTORI.PREZIME_AUTORA) AS 'Ime i prezime', ZANR.NAZIV_ZANRA AS 'Naziv žanra', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv izdavača'" +
                            "FROM KNJIGE " +
                            "JOIN AUTORI ON KNJIGE.ID_AUTORA = AUTORI.ID_AUTORA " +
                            "JOIN ZANR ON KNJIGE.ID_ZANRA = ZANR.ID_ZANRA " +
                            "JOIN IZDAVACI ON KNJIGE.ID_IZDAVACA = IZDAVACI.ID_IZDAVACA";

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledKnjiga.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();
        }






        private void buttonOsvjeziPregledKnjiga_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT KNJIGE.ID_KNJIGE AS 'ID knjige', KNJIGE.NAZIV_KNJIGE AS 'Naziv knjige', KNJIGE.GODINA_IZDANJA AS 'Godina izdanja', KNJIGE.BROJ_DOSTUPNIH_KNJIGA AS 'Broj dostupnih knjiga', KNJIGE.UKUPAN_BROJ_KNJIGA AS 'Ukupan broj knjiga', CONCAT(AUTORI.IME_AUTORA, ' ', AUTORI.PREZIME_AUTORA) AS 'Ime i prezime', ZANR.NAZIV_ZANRA AS 'Naziv žanra', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv izdavača'" +
                            "FROM KNJIGE " +
                            "JOIN AUTORI ON KNJIGE.ID_AUTORA = AUTORI.ID_AUTORA " +
                            "JOIN ZANR ON KNJIGE.ID_ZANRA = ZANR.ID_ZANRA " +
                            "JOIN IZDAVACI ON KNJIGE.ID_IZDAVACA = IZDAVACI.ID_IZDAVACA";

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledKnjiga.DataSource = ds.Tables[0];
            conn.Close();
            command.Dispose();

        }




        private void buttonObrisiKnjigu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPregledKnjiga.SelectedRows)
            {
                string imeKnjige = row.Cells["Naziv knjige"].Value.ToString();

                if (KorisnikImaIzdatihKnjigaPoImenu(imeKnjige))
                {
                    MessageBox.Show("Oznacenu knjigu ne mozete obrisati jer je izdata.");
                }
                else
                {
                    conn.Open();
                    string sql = "DELETE FROM KNJIGE WHERE NAZIV_KNJIGE = @imeKnjige";
                    SqlCommand deleteCommand = new SqlCommand(sql, conn);
                    deleteCommand.Parameters.AddWithValue("@imeKnjige", imeKnjige);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }

            foreach (DataGridViewCell cell in dataGridViewPregledKnjiga.SelectedCells)
            {
                if (!dataGridViewPregledKnjiga.SelectedRows.Contains(cell.OwningRow))
                {
                    int rowIndex = cell.RowIndex;
                    string imeKnjige = dataGridViewPregledKnjiga.Rows[rowIndex].Cells["Naziv knjige"].Value.ToString();

                    if (KorisnikImaIzdatihKnjigaPoImenu(imeKnjige))
                    {
                        MessageBox.Show("Oznacenu knjigu ne mozete obrisati jer je izdata.");
                        continue;
                    }

                    conn.Open();
                    string sql = "DELETE FROM KNJIGE WHERE NAZIV_KNJIGE = @imeKnjige";
                    SqlCommand deleteCommand = new SqlCommand(sql, conn);
                    deleteCommand.Parameters.AddWithValue("@imeKnjige", imeKnjige);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }

            OsvjeziPrikazKnjiga();
        }



        private bool KorisnikImaIzdatihKnjigaPoImenu(string imeKnjige)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM IZDAVANJE WHERE ID_KNJIGE IN (SELECT ID_KNJIGE FROM KNJIGE WHERE NAZIV_KNJIGE = @imeKnjige)", conn);
            command.Parameters.AddWithValue("@imeKnjige", imeKnjige);
            int count = (int)command.ExecuteScalar();
            conn.Close();

            return count > 0;
        }

        private void buttonIzmijeniKnjigu_Click(object sender, EventArgs e)
        {
            conn.Open();
            this.Hide();
            DataGridViewSelectedRowCollection selectedRows = dataGridViewPregledKnjiga.SelectedRows;

            if (selectedRows.Count == 0)
            {
                
                if (dataGridViewPregledKnjiga.SelectedCells.Count > 0)
                {
                    DataGridViewCell cell = dataGridViewPregledKnjiga.SelectedCells[0];
                    int rowIndex = cell.RowIndex;

                    DataGridViewRow selectedRow = dataGridViewPregledKnjiga.Rows[rowIndex];

                    int idKnjige = Convert.ToInt32(selectedRow.Cells["ID Knjige"].Value);
                    string naziv_knjige = selectedRow.Cells["Naziv knjige"].Value.ToString();
                    string godina_izdanja = selectedRow.Cells["Godina izdanja"].Value.ToString();
                    string broj_dostupnih_knjia = selectedRow.Cells["Broj dostupnih knjiga"].Value.ToString();
                    string ukupan_broj_knjiga = selectedRow.Cells["Ukupan broj knjiga"].Value.ToString();
                    string autor = selectedRow.Cells["Ime i prezime"].Value.ToString();
                    string zanr = selectedRow.Cells["Naziv žanra"].Value.ToString();
                    string izdavac = selectedRow.Cells["Naziv izdavača"].Value.ToString();

                    
                   
                    

                    FormIzmjenaKnjige knjiga = new FormIzmjenaKnjige(idKnjige, naziv_knjige, godina_izdanja, broj_dostupnih_knjia, ukupan_broj_knjiga, autor, zanr, izdavac);
                    knjiga.Show();
                }
                else
                {
                    MessageBox.Show("Molimo vas da odaberete knjigu za izmjenu.");
                    FormPregledKnjiga knjiga = new FormPregledKnjiga();
                    knjiga.Show();
                }
               
            }



            else if (selectedRows.Count == 1)
            {
                
                DataGridViewRow selectedRow = selectedRows[0];

                int idKnjige = Convert.ToInt32(selectedRow.Cells["ID Knjige"].Value);
                string naziv_knjige = selectedRow.Cells["Naziv knjige"].Value.ToString();
                string godina_izdanja = selectedRow.Cells["Godina izdanja"].Value.ToString();
                string broj_dostupnih_knjia = selectedRow.Cells["Broj dostupnih knjiga"].Value.ToString();
                string ukupan_broj_knjiga = selectedRow.Cells["Ukupan broj knjiga"].Value.ToString();
                string autor = selectedRow.Cells["Ime i prezime"].Value.ToString();
                string zanr = selectedRow.Cells["Naziv žanra"].Value.ToString();
                string izdavac = selectedRow.Cells["Naziv izdavača"].Value.ToString();

                
         
                FormIzmjenaKnjige knjiga = new FormIzmjenaKnjige(idKnjige, naziv_knjige, godina_izdanja, broj_dostupnih_knjia, ukupan_broj_knjiga, autor, zanr, izdavac);
                knjiga.Show();
                

            }
            else
            {
                MessageBox.Show("Možete izmijeniti samo jednu knjigu odjednom.");
            }
            conn.Close();
        }
    }
}
