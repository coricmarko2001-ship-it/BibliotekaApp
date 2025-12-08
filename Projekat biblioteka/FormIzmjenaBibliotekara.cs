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
    public partial class FormIzmjenaBibliotekara : Form
    {
        public FormIzmjenaBibliotekara()
        {
            InitializeComponent();
        }
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");


        private int bibliotekarID;
        public FormIzmjenaBibliotekara(int idBibliotekara, string ime, string prezime, string korisnicko_ime, string lozinka)
        : this()
        {
            textBoxIzmjenaImeBibliotekara.Text = ime;
            textBoxIzmjenaPrezimeBibliotekara.Text = prezime;
            textBoxIzmjenaKorisnickoImeBibliotekara.Text = korisnicko_ime;
            textBoxIzmjenaLozinkaBibliotekara.Text = lozinka;


            bibliotekarID = idBibliotekara;
            textBoxIDBibliotekara.Text = bibliotekarID.ToString();
            textBoxIDBibliotekara.Enabled = false;


        }

        private void buttonIzmjenaBibliotekaraOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPregledBibliotekara bibl = new FormPregledBibliotekara();
            bibl.Show();
        }

        private void buttonIzmjenaBibliotekaraPotvrdi_Click(object sender, EventArgs e)
        {
            if (textBoxIzmjenaImeBibliotekara.Text != ""
                && textBoxIzmjenaPrezimeBibliotekara.Text != ""
                && textBoxIzmjenaKorisnickoImeBibliotekara.Text != ""
                && textBoxIzmjenaLozinkaBibliotekara.Text != "")

            {
                conn.Open();


                SqlCommand sqlCommand;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                String sql = "UPDATE BIBLIOTEKAR SET IME = '" + textBoxIzmjenaImeBibliotekara.Text + "', " +  "PREZIME = '" + textBoxIzmjenaPrezimeBibliotekara.Text + "', " +
                             "KORISNICKO_IME = '" + textBoxIzmjenaKorisnickoImeBibliotekara.Text + "', " +  "LOZINKA = '" + textBoxIzmjenaLozinkaBibliotekara.Text + "' " +
                            "WHERE ID_BIBLIOTEKARA = " + bibliotekarID;

                sqlCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();


                sqlCommand.Dispose();
                conn.Close();


                this.Close();
                FormPregledBibliotekara bibl = new FormPregledBibliotekara();
                bibl.Show();
            }
            else
            {
                MessageBox.Show("Popunite sve podatke.");

            }
        }
    }
}
