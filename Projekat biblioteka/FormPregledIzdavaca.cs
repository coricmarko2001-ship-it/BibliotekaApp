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
    public partial class FormPregledIzdavaca : Form
    {
        public FormPregledIzdavaca()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");

        private void buttonIzadjiPregledIzdavaca_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonDodajIzdavacaPregledIzdavaca_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDodajIzdavaca izdavac = new FormDodajIzdavaca();
            izdavac.Show();
        }

        private void FormPregledIzdavaca_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT IZDAVACI.ID_IZDAVACA AS 'ID Izdvača', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv Izdavača', IZDAVACI.KONTAKT_TELEFON as 'Kontakt telefon', MJESTO.NAZIV_MJESTA as 'Naziv mjesta' " +
                            "FROM IZDAVACI " +
                            "JOIN MJESTO ON IZDAVACI.ID_MJESTA = MJESTO.ID_MJESTA";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledIzdavaca.DataSource = ds.Tables[0];
            conn.Close();
            command.Dispose();

            dataGridViewPregledIzdavaca.ClearSelection();
        }

        private void textBoxPregledPoImenuIzdavaca_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxPregledPoImenuIzdavaca.Text.ToLower();


            if (textBoxPregledPoImenuIzdavaca.Text != "")
            {
                conn.Open();

                string sql = "SELECT IZDAVACI.ID_IZDAVACA AS 'ID Izdvača', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv Izdavača', IZDAVACI.KONTAKT_TELEFON as 'Kontakt telefon', MJESTO.NAZIV_MJESTA as 'Naziv mjesta' " +
                     "FROM IZDAVACI " +
                     "JOIN MJESTO ON IZDAVACI.ID_MJESTA = MJESTO.ID_MJESTA " +
                     "WHERE LOWER(IZDAVACI.NAZIV_IZDAVACA) LIKE '%" + searchText + "%'";

                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledIzdavaca.DataSource = ds.Tables[0];
                conn.Close();
                command.Dispose();

            }
            else
            {
                conn.Open();

                string sql = "SELECT IZDAVACI.ID_IZDAVACA AS 'ID Izdvača', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv Izdavača', IZDAVACI.KONTAKT_TELEFON as 'Kontakt telefon', MJESTO.NAZIV_MJESTA as 'Naziv mjesta' " +
                            "FROM IZDAVACI " +
                            "JOIN MJESTO ON IZDAVACI.ID_MJESTA = MJESTO.ID_MJESTA";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledIzdavaca.DataSource = ds.Tables[0];
                conn.Close();
                command.Dispose();

            }
        }

        public void OsvjeziPrikazIzdavaca()
        {
            conn.Open();

            string sql = "SELECT IZDAVACI.ID_IZDAVACA AS 'ID Izdvača', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv Izdavača', IZDAVACI.KONTAKT_TELEFON as 'Kontakt telefon', MJESTO.NAZIV_MJESTA as 'Naziv mjesta' " +
                            "FROM IZDAVACI " +
                            "JOIN MJESTO ON IZDAVACI.ID_MJESTA = MJESTO.ID_MJESTA";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledIzdavaca.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();
        }

        private void buttonOsvjeziPregledIzdavaca_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT IZDAVACI.ID_IZDAVACA AS 'ID Izdvača', IZDAVACI.NAZIV_IZDAVACA AS 'Naziv Izdavača', IZDAVACI.KONTAKT_TELEFON as 'Kontakt telefon', MJESTO.NAZIV_MJESTA as 'Naziv mjesta' " + "FROM IZDAVACI " + "JOIN MJESTO ON IZDAVACI.ID_MJESTA = MJESTO.ID_MJESTA";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledIzdavaca.DataSource = ds.Tables[0];
            conn.Close();
            command.Dispose();
        }

        private void buttonObrisiIzdavaca_Click(object sender, EventArgs e)
        {
            if (dataGridViewPregledIzdavaca.SelectedRows.Count == 0 && dataGridViewPregledIzdavaca.SelectedCells.Count == 0)
            {
                MessageBox.Show("Morate selektovati red ili ćeliju da biste obrisali izdavača.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewPregledIzdavaca.SelectedRows)
            {
                int idIzdavaca = Convert.ToInt32(row.Cells["ID Izdvača"].Value);

                conn.Open();
                string sql = "DELETE FROM IZDAVACI WHERE ID_IZDAVACA = @idIzdavaca";
                SqlCommand deleteCommand = new SqlCommand(sql, conn);
                deleteCommand.Parameters.AddWithValue("@idIzdavaca", idIzdavaca);
                deleteCommand.ExecuteNonQuery();
                conn.Close();

            }

            foreach (DataGridViewCell cell in dataGridViewPregledIzdavaca.SelectedCells)
            {
                if (!dataGridViewPregledIzdavaca.SelectedRows.Contains(cell.OwningRow))
                {
                    int rowIndex = cell.RowIndex;
                    int idIzdavaca = Convert.ToInt32(dataGridViewPregledIzdavaca.Rows[rowIndex].Cells["ID Izdvača"].Value);


                    conn.Open();
                    string sql = "DELETE FROM IZDAVACI WHERE ID_IZDAVACA = @idIzdavaca";
                    SqlCommand deleteCommand = new SqlCommand(sql, conn);
                    deleteCommand.Parameters.AddWithValue("@idIzdavaca", idIzdavaca);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }

            OsvjeziPrikazIzdavaca();
        }

        private void buttonIzmijeniIzdavaca_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewSelectedRowCollection selectedRows = dataGridViewPregledIzdavaca.SelectedRows;

            if (selectedRows.Count == 0)
            {
                if (dataGridViewPregledIzdavaca.SelectedCells.Count > 0)
                {
                    DataGridViewCell cell = dataGridViewPregledIzdavaca.SelectedCells[0];
                    int rowIndex = cell.RowIndex;

                    DataGridViewRow selectedRow = dataGridViewPregledIzdavaca.Rows[rowIndex];

                    int idIzdavaca = Convert.ToInt32(selectedRow.Cells["ID Izdvača"].Value);
                    string naziv = selectedRow.Cells["Naziv izdavača"].Value.ToString();
                    string telefon = selectedRow.Cells["Kontakt telefon"].Value.ToString();
                    string mjesto = selectedRow.Cells["Naziv mjesta"].Value.ToString();



                    FormIzmjenaIzdavaca izmjena = new FormIzmjenaIzdavaca(idIzdavaca, naziv, telefon, mjesto);
                    izmjena.Show();
                }
                else
                {
                    MessageBox.Show("Molimo vas da odaberete izdavača za izmjenu.");
                    FormPregledAutora autor = new FormPregledAutora();
                    autor.Show();
                }
            }

            else if (selectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = selectedRows[0];

                int idIzdavaca = Convert.ToInt32(selectedRow.Cells["ID Izdavača"].Value);
                string naziv = selectedRow.Cells["Naziv izdavača"].Value.ToString();
                string telefon = selectedRow.Cells["Kontakt telefon"].Value.ToString();
                string mjesto = selectedRow.Cells["Naziv mjesta"].Value.ToString();



                FormIzmjenaIzdavaca izmjena = new FormIzmjenaIzdavaca(idIzdavaca, naziv, telefon, mjesto);
                izmjena.Show();


            }
            else
            {
                MessageBox.Show("Možete izmijeniti samo jednog izdavača odjednom.");
            }
        }
    }
}
