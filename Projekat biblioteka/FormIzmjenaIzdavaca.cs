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
    public partial class FormIzmjenaIzdavaca : Form
    {
        public FormIzmjenaIzdavaca()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");


        public void PopuniComboBoxMjesto()
        {
            conn.Open();


            String sql = "SELECT ID_MJESTA, NAZIV_MJESTA FROM MJESTO ORDER BY NAZIV_MJESTA";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dtMjesto = new DataTable();

            while (!sqlDataReader.IsClosed)
            {
                dtMjesto.Load(sqlDataReader);
            }

            comboBoxIzmjenaMjestoIzdavaca.DataSource = dtMjesto;
            comboBoxIzmjenaMjestoIzdavaca.DisplayMember = "NAZIV_MJESTA";
            comboBoxIzmjenaMjestoIzdavaca.ValueMember = "ID_MJESTA";

            sqlDataReader.Close();
            sqlCommand.Dispose();
            conn.Close();
        }

        private int izdavacID;
        public FormIzmjenaIzdavaca(int idKorisnika, string naziv, string telefon, string mjesto)
        : this()
        {
            textBoxIzmjenaNazivIzdavaca.Text = naziv;
            textBoxIzmjenaTelefonIzdavaca.Text = telefon;


            izdavacID = idKorisnika;
            textBoxIDIzdavaca.Text = izdavacID.ToString();
            textBoxIDIzdavaca.Enabled = false;

            PopuniComboBoxMjesto();
            foreach (var item in comboBoxIzmjenaMjestoIzdavaca.Items)
            {
                DataRowView row = item as DataRowView;
                if (row != null && row["NAZIV_MJESTA"].ToString() == mjesto)
                {
                    comboBoxIzmjenaMjestoIzdavaca.SelectedItem = item;
                    break;
                }
            }
        }

        private void buttonOdustaniIzdavaca_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPregledIzdavaca izdavac = new FormPregledIzdavaca();
            izdavac.Show();
        }

        private void buttonPotvrdiIzdavac_Click(object sender, EventArgs e)
        {
            if (textBoxIzmjenaNazivIzdavaca.Text != ""
                && textBoxIzmjenaTelefonIzdavaca.Text != ""
                && comboBoxIzmjenaMjestoIzdavaca.Text != "")

            {
                conn.Open();


                SqlCommand sqlCommand;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                String sql = "UPDATE IZDAVACI SET NAZIV_IZDAVACA = '" + textBoxIzmjenaNazivIzdavaca.Text + "', KONTAKT_TELEFON = '" + textBoxIzmjenaTelefonIzdavaca.Text + "'," +
                    " " + "ID_MJESTA = '" + comboBoxIzmjenaMjestoIzdavaca.SelectedValue.ToString() + "'" +
                            " WHERE ID_IZDAVACA = '" + textBoxIDIzdavaca.Text + "'";

                sqlCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();


                sqlCommand.Dispose();
                conn.Close();


                this.Close();
                FormPregledIzdavaca izdavac = new FormPregledIzdavaca();
                izdavac.Show();
            }
            else
            {
                MessageBox.Show("Popunite sve podatke.");

            }
        }
    }

}
