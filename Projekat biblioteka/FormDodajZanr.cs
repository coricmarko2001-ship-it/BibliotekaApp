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
    public partial class FormDodajZanr : Form
    {
        public FormDodajZanr()
        {
            InitializeComponent();
        }


        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");

        private void buttonDodajZanrOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();

        }



        private void buttonDodajZanrPotvrdi_Click(object sender, EventArgs e)
        {
            if (textBoxDodajZanrNazivZanra.Text != "")
            {
                conn.Open();
                string sql = "INSERT INTO ZANR (NAZIV_ZANRA) VALUES (@naziv_zanra)";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@naziv_zanra", textBoxDodajZanrNazivZanra.Text);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspjesno ste dodali zanr.");

                    FormDodajKnjigu dodajKnjiguForma = Application.OpenForms.OfType<FormDodajKnjigu>().FirstOrDefault();
                    if (dodajKnjiguForma != null)
                    {
                        dodajKnjiguForma.OsvjeziComboBoxZanr();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dogodila se greska." + ex.Message);
                }
                finally
                {
                    conn.Close();
                    command.Dispose();
                }
            }

            else
            {
                MessageBox.Show("Neuspješno dodavanje. Popunite podatke koji su obavezni.");
            }

        }
    }
}
