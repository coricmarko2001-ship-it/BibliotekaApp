using System.Data;
using System.Data.SqlClient;

namespace Projekat_biblioteka
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUlogujeSe_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-0F9HBNK\\SQLEXPRESS;Initial Catalog=Biblioteka;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();

            string sql = "SELECT KORISNICKO_IME, LOZINKA FROM BIBLIOTEKAR WHERE KORISNICKO_IME = '"+textBoxKorisnickoIme.Text+"'";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();



            string korisnicko_ime = textBoxKorisnickoIme.Text;
            string lozinka = textBoxLozinka.Text;

            while (reader.Read())
            {
                korisnicko_ime = reader.GetValue(0).ToString();
                lozinka = reader.GetValue(1).ToString();
            }


            if (textBoxKorisnickoIme.Text != "" && textBoxLozinka.Text!="")
            {
                this.Hide();
                FormPocetna pocetna = new FormPocetna();
                pocetna.Show();
            }
            else
            {
                MessageBox.Show("Niste unijeli ispravne podatke.");
            }

            reader.Close();
            command.Dispose();
            conn.Close();


        }

        private void buttonRegistrujSe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDodajBibliotekara bibl = new FormDodajBibliotekara();
            bibl.Show();
        }

        private void textBoxLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonUlogujeSe_Click(sender, new EventArgs());
        }


    }
}
