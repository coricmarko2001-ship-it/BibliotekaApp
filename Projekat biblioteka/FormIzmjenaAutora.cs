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
    public partial class FormIzmjenaAutora : Form
    {
        public FormIzmjenaAutora()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");

        private int autorID;
        public FormIzmjenaAutora(int idAutora, string ime, string prezime, DateTime godina_rodjenja)
        : this()
        {
            textBoxIzmjenaImeAutora.Text = ime;
            textBoxIzmjenaAutorPrezime.Text = prezime;
            dateTimePickerIzmjenaGodinaRodjenja.Value = godina_rodjenja;


            autorID = idAutora;
            textBoxIDAutora.Text = autorID.ToString();
            textBoxIDAutora.Enabled = false;


        }

        private void buttonRegistrujSeOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPregledAutora autor = new FormPregledAutora();
            autor.Show();
        }

        private void buttonRegistrujSePotvrdi_Click(object sender, EventArgs e)
        {
            if (textBoxIzmjenaImeAutora.Text != ""
                && textBoxIzmjenaAutorPrezime.Text != "")

            {
                conn.Open();


                SqlCommand sqlCommand;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                String sql = "UPDATE AUTORI SET IME_AUTORA = '" + textBoxIzmjenaImeAutora.Text + "', PREZIME_AUTORA = '" + textBoxIzmjenaAutorPrezime.Text + "', " +
                    "GODINA_RODJENJA = '" + dateTimePickerIzmjenaGodinaRodjenja.Value + "' WHERE ID_AUTORA = " + autorID;

                sqlCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand = new SqlCommand(sql, conn);
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();


                sqlCommand.Dispose();
                conn.Close();


                this.Close();
                FormPregledAutora autor = new FormPregledAutora();
                autor.Show();
            }
            else
            {
                MessageBox.Show("Popunite sve podatke.");

            }
        }
    }
}
