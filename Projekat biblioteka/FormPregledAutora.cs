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
    public partial class FormPregledAutora : Form
    {
        public FormPregledAutora()
        {
            InitializeComponent();
        }


        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;TrustServerCertificate=True");

        private void buttonIzadjiPregledAutora_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FormPregledAutora_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT ID_AUTORA AS 'ID autora', IME_AUTORA AS 'Ime autora', PREZIME_AUTORA AS 'Prezime autora', GODINA_RODJENJA AS 'Godina rodjenja' FROM AUTORI";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            dataGridViewPregledAutora.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();

            dataGridViewPregledAutora.ClearSelection();
        }


        private void buttonDodajAutoraPregledAutora_Click(object sender, EventArgs e)
        {

            FormDodajAutora autor = new FormDodajAutora();
            autor.Show();
        }



        private void textBoxPregledPoImenuAutora_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxPregledPoImenuAutora.Text.ToLower();

            if (textBoxPregledPoImenuAutora.Text != "")
            {
                conn.Open();

                string sql = "SELECT ID_AUTORA AS 'ID autora', IME_AUTORA AS 'Ime autora', PREZIME_AUTORA AS 'Prezime autora', GODINA_RODJENJA AS 'Godina rodjenja' FROM AUTORI " +
                    "WHERE LOWER(IME_AUTORA) LIKE '%" + searchText + "%'";
              
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledAutora.DataSource = ds.Tables[0];
                conn.Close();
                command.Dispose();

            }
            else
            {
                conn.Open();

                string sql = "SELECT ID_AUTORA AS 'ID autora', IME_AUTORA AS 'Ime autora', PREZIME_AUTORA AS 'Prezime autora', GODINA_RODJENJA AS 'Godina rodjenja' FROM AUTORI";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridViewPregledAutora.DataSource = ds.Tables[0];
                conn.Close();
                command.Dispose();

            }
        }


        public void OsvjeziPrikazAutora()
        {
            conn.Open();

            string sql = "SELECT ID_AUTORA AS 'ID autora', IME_AUTORA AS 'Ime autora', PREZIME_AUTORA AS 'Prezime autora', GODINA_RODJENJA AS 'Godina rodjenja' FROM AUTORI";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledAutora.DataSource = ds.Tables[0];

            conn.Close();
            command.Dispose();
        }

        private void buttonOsvjeziPregledAutora_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT ID_AUTORA AS 'ID autora', IME_AUTORA AS 'Ime autora', PREZIME_AUTORA AS 'Prezime autora', GODINA_RODJENJA AS 'Godina rodjenja' FROM AUTORI";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewPregledAutora.DataSource = ds.Tables[0];
            conn.Close();
            command.Dispose();
        }

        private void buttonObrisiAutora_Click(object sender, EventArgs e)
        {
            if (dataGridViewPregledAutora.SelectedRows.Count == 0 && dataGridViewPregledAutora.SelectedCells.Count == 0)
            {
                MessageBox.Show("Morate selektovati red ili ćeliju da biste obrisali autora.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewPregledAutora.SelectedRows)
            {
                int idAutora = Convert.ToInt32(row.Cells["ID Autora"].Value);

                conn.Open();
                string sql = "DELETE FROM AUTORI WHERE ID_AUTORA = @idAutora";
                SqlCommand deleteCommand = new SqlCommand(sql, conn);
                deleteCommand.Parameters.AddWithValue("@idAutora", idAutora);
                deleteCommand.ExecuteNonQuery();
                conn.Close();

            }

            foreach (DataGridViewCell cell in dataGridViewPregledAutora.SelectedCells)
            {
                if (!dataGridViewPregledAutora.SelectedRows.Contains(cell.OwningRow))
                {
                    int rowIndex = cell.RowIndex;
                    int idAutora = Convert.ToInt32(dataGridViewPregledAutora.Rows[rowIndex].Cells["ID Autora"].Value);


                    conn.Open();
                    string sql = "DELETE FROM AUTORI WHERE ID_AUTORA = @idAutora";
                    SqlCommand deleteCommand = new SqlCommand(sql, conn);
                    deleteCommand.Parameters.AddWithValue("@idAutora", idAutora);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }

            OsvjeziPrikazAutora();
        }

        private void buttonIzmijeniAutora_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewSelectedRowCollection selectedRows = dataGridViewPregledAutora.SelectedRows;

            if (selectedRows.Count == 0)
            {
                if (dataGridViewPregledAutora.SelectedCells.Count > 0)
                {
                    DataGridViewCell cell = dataGridViewPregledAutora.SelectedCells[0];
                    int rowIndex = cell.RowIndex;

                    DataGridViewRow selectedRow = dataGridViewPregledAutora.Rows[rowIndex];

                    int idAutora = Convert.ToInt32(selectedRow.Cells["ID Autora"].Value);
                    string ime = selectedRow.Cells["Ime autora"].Value.ToString();
                    string prezime = selectedRow.Cells["Prezime autora"].Value.ToString();
                    DateTime godina_rodjenja = Convert.ToDateTime(selectedRow.Cells["Godina rodjenja"].Value);



                    FormIzmjenaAutora izmjenaAutora = new FormIzmjenaAutora(idAutora, ime, prezime, godina_rodjenja);
                    izmjenaAutora.Show();
                }
                else
                {
                    MessageBox.Show("Molimo vas da odaberete autora za izmjenu.");
                    FormPregledAutora autor = new FormPregledAutora();
                    autor.Show();
                }
            }



            else if (selectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = selectedRows[0];

                int idAutora = Convert.ToInt32(selectedRow.Cells["ID Autora"].Value);
                string ime = selectedRow.Cells["Ime autora"].Value.ToString();
                string prezime = selectedRow.Cells["Prezime autora"].Value.ToString();
                DateTime godina_rodjenja = Convert.ToDateTime(selectedRow.Cells["Godina rodjenja"].Value);



                FormIzmjenaAutora izmjenaAutora = new FormIzmjenaAutora(idAutora, ime, prezime, godina_rodjenja);
                izmjenaAutora.Show();


            }
            else
            {
                MessageBox.Show("Možete izmijeniti samo jednog autora odjednom.");
            }
        }
    }
}
