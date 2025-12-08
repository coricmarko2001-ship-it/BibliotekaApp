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
    public partial class FormDodajMjesto : Form
    {
        public FormDodajMjesto()
        {
            InitializeComponent();
        }


        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;TrustServerCertificate=True");




        private void buttonOdustaniDodavanjeMjesta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajMjesto_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBoxNazivDodajMjesto.Text != "" && textBoxPostanskiBrojDodajMjesto.Text != "")
            {

                string sql = "INSERT INTO MJESTO VALUES ('"+textBoxNazivDodajMjesto.Text+"', '"+textBoxPostanskiBrojDodajMjesto.Text+"')";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();



                try
                {

                    adapter.InsertCommand = new SqlCommand(sql, conn);
                    adapter.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Uspjesno ste dodali mjesto.");

                    FormDodajKorisnika korisnik = Application.OpenForms.OfType<FormDodajKorisnika>().FirstOrDefault();
                    if (korisnik != null)
                    {
                        korisnik.OsvjeziComboBoxMjesto();
                    }

                    FormDodajIzdavaca izdavac = Application.OpenForms.OfType<FormDodajIzdavaca>().FirstOrDefault();
                    if (izdavac != null)
                    {
                        izdavac.PopuniComboBoxMjesto();
                    }

                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Dogodila se greska." + ex.Message);
                }

                conn.Close();
                command.Dispose();


            }
        }
    }
}
