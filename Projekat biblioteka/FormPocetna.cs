using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_biblioteka
{
    public partial class FormPocetna : Form
    {
        public FormPocetna()
        {
            InitializeComponent();
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da izađete?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pogledajKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPregledKnjiga pregledKnjiga = new FormPregledKnjiga();
            pregledKnjiga.Show();
        }

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPregledKorisnika pregledKorisnika = new FormPregledKorisnika();
            pregledKorisnika.Show();
        }

        private void pregledAutoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPregledAutora pregledAutora = new FormPregledAutora();
            pregledAutora.Show();
        }

        private void rezervisiKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIzdajKnjigu izdaj = new FormIzdajKnjigu();
            izdaj.Show();
        }

        private void pregledIzdatihKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPregledIzdatihKnjiga knjiga = new FormPregledIzdatihKnjiga();
            knjiga.Show();
        }

        private void vratiKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVratiKnjigu knjiga = new FormVratiKnjigu();
            knjiga.Show();
        }

        private void pregledBibliotekaraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPregledBibliotekara bibl = new FormPregledBibliotekara();
            bibl.Show();
        }

        private void pregledIzdavačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPregledIzdavaca izdavac = new FormPregledIzdavaca();
            izdavac.Show();
        }
    }
}
