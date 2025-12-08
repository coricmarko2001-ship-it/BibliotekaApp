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
    public partial class FormPregledBibliotekara : Form
    {
        public FormPregledBibliotekara()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;TrustServerCertificate=True");

        private void buttonIzadjiPregledBibliotekara_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPregledBibliotekara_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT ID_BIBLIOTEKARA AS 'ID Bibliotekara', IME AS 'Ime', PREZIME AS 'Prezime', KORISNICKO_IME AS 'Korisničko ime', LOZINKA AS 'Lozinka' FROM BIBLIOTEKAR";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledBibliotekara.DataSource = ds.Tables[0];



            conn.Close();
            command.Dispose();

            dataGridViewPregledBibliotekara.ClearSelection();
        }

        private void textBoxPregledPoImenuBibliotekara_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxPregledPoImenuBibliotekara.Text.ToLower();

            if (textBoxPregledPoImenuBibliotekara.Text != "")
            {
                conn.Open();

                string sql = "SELECT ID_BIBLIOTEKARA AS 'ID Bibliotekara', IME AS 'Ime', PREZIME AS 'Prezime', KORISNICKO_IME AS 'Korisničko ime', LOZINKA AS 'Lozinka' FROM BIBLIOTEKAR " +
                    "WHERE LOWER(IME) LIKE '%" + searchText + "%'";
                
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledBibliotekara.DataSource = ds.Tables[0];
                conn.Close();
                command.Dispose();

            }
            else
            {
                conn.Open();

                string sql = "SELECT ID_BIBLIOTEKARA AS 'ID Bibliotekara', IME AS 'Ime', PREZIME AS 'Prezime', KORISNICKO_IME AS 'Korisničko ime', LOZINKA AS 'Lozinka' FROM BIBLIOTEKAR";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledBibliotekara.DataSource = ds.Tables[0];
                conn.Close();
                command.Dispose();

            }
        }

        public void OsvjeziPrikazBibliotekara()
        {
            conn.Open();

            string sql = "SELECT ID_BIBLIOTEKARA AS 'ID Bibliotekara', IME AS 'Ime', PREZIME AS 'Prezime', KORISNICKO_IME AS 'Korisničko ime', LOZINKA AS 'Lozinka' FROM BIBLIOTEKAR";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledBibliotekara.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();
        }

        private void buttonOsvjeziPregledBibliotekara_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT ID_BIBLIOTEKARA AS 'ID Bibliotekara', IME AS 'Ime', PREZIME AS 'Prezime', KORISNICKO_IME AS 'Korisničko ime', LOZINKA AS 'Lozinka' FROM BIBLIOTEKAR";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledBibliotekara.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();
        }

        private void buttonObrisiBibliotekara_Click(object sender, EventArgs e)
        {
            if (dataGridViewPregledBibliotekara.SelectedRows.Count == 0 && dataGridViewPregledBibliotekara.SelectedCells.Count == 0)
            {
                MessageBox.Show("Morate selektovati red ili ćeliju da biste obrisali bibliotekara.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewPregledBibliotekara.SelectedRows)
            {
                int idBibliotekara = Convert.ToInt32(row.Cells["ID bibliotekara"].Value);

                conn.Open();
                string sql = "DELETE FROM BIBLIOTEKAR WHERE ID_BIBLIOTEKARA = @idBibliotekara";
                SqlCommand deleteCommand = new SqlCommand(sql, conn);
                deleteCommand.Parameters.AddWithValue("@idBibliotekara", idBibliotekara);
                deleteCommand.ExecuteNonQuery();
                conn.Close();
            }

            foreach (DataGridViewCell cell in dataGridViewPregledBibliotekara.SelectedCells)
            {
                if (!dataGridViewPregledBibliotekara.SelectedRows.Contains(cell.OwningRow))
                {
                    int rowIndex = cell.RowIndex;
                    int idBibliotekara = Convert.ToInt32(dataGridViewPregledBibliotekara.Rows[rowIndex].Cells["ID Bibliotekara"].Value);

                    conn.Open();
                    string sql = "DELETE FROM BIBLIOTEKAR WHERE ID_BIBLIOTEKARA = @idBibliotekara";
                    SqlCommand deleteCommand = new SqlCommand(sql, conn);
                    deleteCommand.Parameters.AddWithValue("@idBibliotekara", idBibliotekara);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }

            OsvjeziPrikazBibliotekara();
        }


        private void buttonIzmijeniBibliotekara_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewSelectedRowCollection selectedRows = dataGridViewPregledBibliotekara.SelectedRows;

            if (selectedRows.Count == 0)
            {
                if (dataGridViewPregledBibliotekara.SelectedCells.Count > 0)
                {
                    DataGridViewCell cell = dataGridViewPregledBibliotekara.SelectedCells[0];
                    int rowIndex = cell.RowIndex;

                    DataGridViewRow selectedRow = dataGridViewPregledBibliotekara.Rows[rowIndex];

                    int idBibliotekara = Convert.ToInt32(selectedRow.Cells["ID Bibliotekara"].Value);
                    string ime = selectedRow.Cells["Ime"].Value.ToString();
                    string prezime = selectedRow.Cells["Prezime"].Value.ToString();
                    string korisnicko_ime = selectedRow.Cells["Korisničko ime"].Value.ToString();
                    string lozinka = selectedRow.Cells["Lozinka"].Value.ToString();




                    FormIzmjenaBibliotekara bibl = new FormIzmjenaBibliotekara(idBibliotekara, ime, prezime, korisnicko_ime, lozinka);
                    bibl.Show();
                }
                else
                {
                    MessageBox.Show("Molimo vas da odaberete bibliotekara za izmjenu.");
                    FormPregledBibliotekara bibl = new FormPregledBibliotekara();
                    bibl.Show();
                }
            }



            else if (selectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = selectedRows[0];

                int idBibliotekara = Convert.ToInt32(selectedRow.Cells["ID Bibliotekara"].Value);
                string ime = selectedRow.Cells["Ime"].Value.ToString();
                string prezime = selectedRow.Cells["Prezime"].Value.ToString();
                string korisnicko_ime = selectedRow.Cells["Korisničko ime"].Value.ToString();
                string lozinka = selectedRow.Cells["Lozinka"].Value.ToString();



                FormIzmjenaBibliotekara bibl = new FormIzmjenaBibliotekara(idBibliotekara, ime, prezime, korisnicko_ime, lozinka);
                bibl.Show();


            }
            else
            {
                MessageBox.Show("Možete izmijeniti samo jednog bibliotekara odjednom.");
            }
        }
    }
}
