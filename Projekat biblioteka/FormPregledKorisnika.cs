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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projekat_biblioteka
{
    public partial class FormPregledKorisnika : Form
    {
        public FormPregledKorisnika()
        {
            InitializeComponent();
        }



        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;TrustServerCertificate=True");



        private void buttonIzadjiPregledKorisnika_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void FormPregledKorisnika_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT KORISNIK.ID_KORISNIKA AS 'ID Korisnika', KORISNIK.IME AS 'Ime', KORISNIK.PREZIME as 'Prezime', KORISNIK.EMAIL as 'Email', KORISNIK.TELEFON as 'Telefon', KORISNIK.ULICA_I_BROJ as 'Ulica i broj', MJESTO.NAZIV_MJESTA as 'Naziv mjesta'" +
                            "FROM KORISNIK " +
                            "JOIN MJESTO ON KORISNIK.ID_MJESTA = MJESTO.ID_MJESTA";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledKorisnika.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();

            dataGridViewPregledKorisnika.ClearSelection();
        }




        private void buttonRegistrujKorisnika_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDodajKorisnika registracija = new FormDodajKorisnika();
            registracija.Show();

            //OsvjeziPrikazKorisnika();
        }


        private void OsvjeziPrikazKorisnika()
        {
            conn.Open();

            string sql = "SELECT KORISNIK.ID_KORISNIKA AS 'ID Korisnika', KORISNIK.IME AS 'Ime', KORISNIK.PREZIME as 'Prezime', KORISNIK.EMAIL as 'Email', KORISNIK.TELEFON as 'Telefon', KORISNIK.ULICA_I_BROJ as 'Ulica i broj', MJESTO.NAZIV_MJESTA as 'Naziv mjesta' " +
                            "FROM KORISNIK " +
                            "JOIN MJESTO ON KORISNIK.ID_MJESTA = MJESTO.ID_MJESTA";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledKorisnika.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();
        }



        private void buttonOsvjeziPregledKorisnika_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT KORISNIK.ID_KORISNIKA AS 'ID Korisnika', KORISNIK.IME AS 'Ime', KORISNIK.PREZIME as 'Prezime', KORISNIK.EMAIL as 'Email', KORISNIK.TELEFON as 'Telefon', KORISNIK.ULICA_I_BROJ as 'Ulica i broj', MJESTO.NAZIV_MJESTA as 'Naziv mjesta' " +
                            "FROM KORISNIK " +
                            "JOIN MJESTO ON KORISNIK.ID_MJESTA = MJESTO.ID_MJESTA";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledKorisnika.DataSource = ds.Tables[0];
            conn.Close();
            command.Dispose();

        }





        private void textBoxPretraziPoIdKorisnika_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPretraziPoIdKorisnika.Text != "")
            {
                conn.Open();

                string sql = "SELECT KORISNIK.ID_KORISNIKA AS 'ID Korisnika', KORISNIK.IME AS 'Ime', KORISNIK.PREZIME as 'Prezime', KORISNIK.EMAIL as 'Email', KORISNIK.TELEFON as 'Telefon', KORISNIK.ULICA_I_BROJ as 'Ulica i broj', MJESTO.NAZIV_MJESTA as 'Naziv mjesta' " +
                    "FROM KORISNIK " +
                    "JOIN MJESTO ON KORISNIK.ID_MJESTA = MJESTO.ID_MJESTA WHERE KORISNIK.ID_KORISNIKA LIKE '"+textBoxPretraziPoIdKorisnika.Text+"%'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledKorisnika.DataSource = ds.Tables[0];
                conn.Close();

            }
            else
            {
                conn.Open();

                string sql = "SELECT KORISNIK.ID_KORISNIKA AS 'ID Korisnika', KORISNIK.IME AS 'Ime', KORISNIK.PREZIME as 'Prezime', KORISNIK.EMAIL as 'Email', KORISNIK.TELEFON as 'Telefon', KORISNIK.ULICA_I_BROJ as 'Ulica i broj', MJESTO.NAZIV_MJESTA as 'Naziv mjesta' " +
                            "FROM KORISNIK " +
                            "JOIN MJESTO ON KORISNIK.ID_MJESTA = MJESTO.ID_MJESTA";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledKorisnika.DataSource = ds.Tables[0];
                conn.Close();
            }



        }

        private void buttonObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if (dataGridViewPregledKorisnika.SelectedRows.Count == 0 && dataGridViewPregledKorisnika.SelectedCells.Count == 0)
            {
                MessageBox.Show("Morate selektovati red ili ćeliju da biste obrisali korisnika.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewPregledKorisnika.SelectedRows)
            {
                int idKorisnika = Convert.ToInt32(row.Cells["ID Korisnika"].Value);

                if (KorisnikImaIzdatihKnjiga(idKorisnika))
                {
                    MessageBox.Show("Oznacenog korisnika ne mozete obrisati jer ima izdatih knjiga.");
                }
                else
                {
                    conn.Open();
                    string sql = "DELETE FROM KORISNIK WHERE ID_KORISNIKA = @idKorisnika";
                    SqlCommand deleteCommand = new SqlCommand(sql, conn);
                    deleteCommand.Parameters.AddWithValue("@idKorisnika", idKorisnika);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }

            foreach (DataGridViewCell cell in dataGridViewPregledKorisnika.SelectedCells)
            {
                if (!dataGridViewPregledKorisnika.SelectedRows.Contains(cell.OwningRow))
                {
                    int rowIndex = cell.RowIndex;
                    int idKorisnika = Convert.ToInt32(dataGridViewPregledKorisnika.Rows[rowIndex].Cells["ID Korisnika"].Value);

                    if (KorisnikImaIzdatihKnjiga(idKorisnika))
                    {
                        MessageBox.Show("Oznacenog korisnika ne mozete obrisati jer ima izdatih knjiga!");
                        continue;
                    }

                    conn.Open();
                    string sql = "DELETE FROM KORISNIK WHERE ID_KORISNIKA = @idKorisnika";
                    SqlCommand deleteCommand = new SqlCommand(sql, conn);
                    deleteCommand.Parameters.AddWithValue("@idKorisnika", idKorisnika);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }

            OsvjeziPrikazKorisnika();
        }





        private bool KorisnikImaIzdatihKnjiga(int idKorisnika)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM IZDAVANJE WHERE ID_KORISNIKA = @idKorisnika", conn);
            command.Parameters.AddWithValue("@idKorisnika", idKorisnika);
            int count = (int)command.ExecuteScalar();
            conn.Close();

            return count > 0;
        }


        private void buttonIzmijeniKorisnika_Click(object sender, EventArgs e)
        {

            this.Hide();
            DataGridViewSelectedRowCollection selectedRows = dataGridViewPregledKorisnika.SelectedRows;

            if (selectedRows.Count == 0)
            {
                if (dataGridViewPregledKorisnika.SelectedCells.Count > 0)
                {
                    DataGridViewCell cell = dataGridViewPregledKorisnika.SelectedCells[0];
                    int rowIndex = cell.RowIndex;

                    DataGridViewRow selectedRow = dataGridViewPregledKorisnika.Rows[rowIndex];

                    int idKorisnika = Convert.ToInt32(selectedRow.Cells["ID Korisnika"].Value);
                    string ime = selectedRow.Cells["Ime"].Value.ToString();
                    string prezime = selectedRow.Cells["Prezime"].Value.ToString();
                    string email = selectedRow.Cells["Email"].Value.ToString();
                    string telefon = selectedRow.Cells["Telefon"].Value.ToString();
                    string ulicaBroj = selectedRow.Cells["Ulica i broj"].Value.ToString();
                    string mjesto = selectedRow.Cells["Naziv mjesta"].Value.ToString();


                    FormIzmjenaKorisnika izmjenaKorisnika = new FormIzmjenaKorisnika(idKorisnika, ime, prezime, email, telefon, ulicaBroj, mjesto);
                    izmjenaKorisnika.Show();
                }
                else
                {
                    MessageBox.Show("Molimo vas da odaberete korisnika za izmjenu.");
                    FormPregledKorisnika korinsik = new FormPregledKorisnika();
                    korinsik.Show();
                }
            }
            else if (selectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = selectedRows[0];

                int idKorisnika = Convert.ToInt32(selectedRow.Cells["ID Korisnika"].Value);
                string ime = selectedRow.Cells["Ime"].Value.ToString();
                string prezime = selectedRow.Cells["Prezime"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string telefon = selectedRow.Cells["Telefon"].Value.ToString();
                string ulicaBroj = selectedRow.Cells["Ulica i broj"].Value.ToString();
                string mjesto = selectedRow.Cells["Naziv mjesta"].Value.ToString();

                FormIzmjenaKorisnika izmjenaKorisnika = new FormIzmjenaKorisnika(idKorisnika, ime, prezime, email, telefon, ulicaBroj, mjesto);
                izmjenaKorisnika.Show();
            }
            else
            {
                MessageBox.Show("Možete izmijeniti samo jednog korisnika odjednom.");
            }
        }


    }
}

