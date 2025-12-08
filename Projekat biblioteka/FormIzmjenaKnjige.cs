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
    public partial class FormIzmjenaKnjige : Form
    {
        public FormIzmjenaKnjige()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");


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

            comboBoxIzmjenaAutor.DataSource = dtAutor;
            comboBoxIzmjenaAutor.DisplayMember = "IME_PREZIME_AUTORA";
            comboBoxIzmjenaAutor.ValueMember = "ID_AUTORA";

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

            comboBoxIzmjenaZanr.DataSource = dtZanr;
            comboBoxIzmjenaZanr.DisplayMember = "NAZIV_ZANRA";
            comboBoxIzmjenaZanr.ValueMember = "ID_ZANRA";

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

            comboBoxIzmjenaIzdavac.DataSource = dtIzdavac;
            comboBoxIzmjenaIzdavac.DisplayMember = "NAZIV_IZDAVACA";
            comboBoxIzmjenaIzdavac.ValueMember = "ID_IZDAVACA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }


        private int knjigaId;
        public FormIzmjenaKnjige(int idKnjige, string naziv_knjige, string godina_izdanja, string broj_dostupnih_knjia, string ukupan_broj_knjiga, string autor, string zanr, string izdavac)
        : this()
        {
            textBoxIzmjenaNazivKnjige.Text = naziv_knjige;
            textBoxIzmjenaGodinaIzdanja.Text = godina_izdanja;
            textBoxIzmjenaBrojDostupnihKnjiga.Text = broj_dostupnih_knjia;
            textBoxIzmjenaUkupanBrojKnjiga.Text = ukupan_broj_knjiga;


            knjigaId = idKnjige;
            textBoxIDKnjige.Text = knjigaId.ToString();
            textBoxIDKnjige.Enabled = false;

            PopuniComboBoxImeAutora();

            

            foreach (var item in comboBoxIzmjenaAutor.Items)
            {
                DataRowView row = item as DataRowView;
                if (row != null && row["IME_PREZIME_AUTORA"].ToString() == autor)
                {
                    comboBoxIzmjenaAutor.SelectedItem = item;
                    break;
                }
            }

            PopuniComboBoxZanr();
            foreach (var item in comboBoxIzmjenaZanr.Items)
            {
                DataRowView row = item as DataRowView;
                if (row != null && row["NAZIV_ZANRA"].ToString() == zanr)
                {
                    comboBoxIzmjenaZanr.SelectedItem = item;
                    break;
                }
            }

            PopuniComboBoxIzdavaci();

            foreach (var item in comboBoxIzmjenaIzdavac.Items)
            {
                DataRowView row = item as DataRowView;
                if (row != null && row["NAZIV_IZDAVACA"].ToString() == izdavac)
                {
                    comboBoxIzmjenaIzdavac.SelectedItem = item;
                    break;
                }
            }

        }

        private void buttonIzmjenaKnjigeOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPregledKnjiga knjiga = new FormPregledKnjiga();
            knjiga.Show();
        }

        private void buttonIzmjenaKnjigePotvrdi_Click(object sender, EventArgs e)
        {
            if (textBoxIzmjenaNazivKnjige.Text != ""
                && textBoxIzmjenaGodinaIzdanja.Text != ""
                && textBoxIzmjenaUkupanBrojKnjiga.Text != ""
                && textBoxIzmjenaBrojDostupnihKnjiga.Text != ""
                && comboBoxIzmjenaAutor.Text != ""
                && comboBoxIzmjenaZanr.Text != ""
                && comboBoxIzmjenaIzdavac.Text != "")

            {
                conn.Open();


                SqlCommand sqlCommand;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                String sql = "UPDATE KNJIGE SET NAZIV_KNJIGE = '" + textBoxIzmjenaNazivKnjige.Text + "', GODINA_IZDANJA = '" + textBoxIzmjenaGodinaIzdanja.Text + "', " +
                             "BROJ_DOSTUPNIH_KNJIGA = '" + textBoxIzmjenaBrojDostupnihKnjiga.Text + "', UKUPAN_BROJ_KNJIGA = '" + textBoxIzmjenaUkupanBrojKnjiga.Text + "', " +
                             "ID_AUTORA = '" + comboBoxIzmjenaAutor.SelectedValue.ToString() + "', ID_ZANRA = '" + comboBoxIzmjenaZanr.SelectedValue.ToString() + "', " +
                             "ID_IZDAVACA = '" + comboBoxIzmjenaIzdavac.SelectedValue.ToString() + "' " +
                             "WHERE ID_KNJIGE = '" + textBoxIDKnjige.Text + "'";

                sqlCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();


                sqlCommand.Dispose();
                conn.Close();


                this.Close();
                FormPregledKnjiga knjiga = new FormPregledKnjiga();
                knjiga.Show();
            }
            else
            {
                MessageBox.Show("Popunite sve podatke.");

            }
        }
    }
}
