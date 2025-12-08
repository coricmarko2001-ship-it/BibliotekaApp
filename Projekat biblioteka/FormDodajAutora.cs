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
    public partial class FormDodajAutora : Form
    {
        public FormDodajAutora()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;Trust Server Certificate=True");

        private void buttonOdustaniDodajAutora_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void buttonDodajAutora_Click(object sender, EventArgs e)
        {
            if (textBoxDodajImeAutora.Text != ""
                && textBoxDodajAutorPrezime.Text != "")

            {
                conn.Open();
                string sql = "INSERT INTO AUTORI (IME_AUTORA, PREZIME_AUTORA, GODINA_RODJENJA) VALUES (@ime, @prezime, @godina_rodjenja)";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@ime", textBoxDodajImeAutora.Text);
                command.Parameters.AddWithValue("@prezime", textBoxDodajAutorPrezime.Text);
                command.Parameters.AddWithValue("@godina_rodjenja", dateTimePickerDodajGodinaRodjenja.Value);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspjesno ste dodali autora.");


                    FormDodajKnjigu formDodajKnjigu = Application.OpenForms.OfType<FormDodajKnjigu>().FirstOrDefault();
                    if (formDodajKnjigu != null)
                    {
                        formDodajKnjigu.PopuniComboBoxImeAutora();
                    }

                    if (Application.OpenForms["FormPregledAutora"] is FormPregledAutora formPregledAutora)
                    {
                        formPregledAutora.OsvjeziPrikazAutora();
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
