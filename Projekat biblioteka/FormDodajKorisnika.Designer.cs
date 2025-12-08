namespace Projekat_biblioteka
{
    partial class FormDodajKorisnika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajKorisnika));
            labelRegistracijaIme=new Label();
            labelRegistracijaPrezime=new Label();
            labelRegistracijaEmail=new Label();
            labelRegistracijaTelefon=new Label();
            labelRegistracijaMjesto=new Label();
            label1=new Label();
            buttonRegistrujSePotvrdi=new Button();
            buttonRegistrujSeOdustani=new Button();
            textBoxRegistracijaIme=new TextBox();
            textBoxRegistracijaPrezime=new TextBox();
            textBoxRegistracijaEmail=new TextBox();
            textBoxRegistracijaTelefon=new TextBox();
            comboBoxRegistrujSeMjesto=new ComboBox();
            labelRegistracijaUlicaiBroj=new Label();
            textBoxRegistracijaUlicaiBroj=new TextBox();
            label2=new Label();
            label3=new Label();
            buttonDodajMjestoRegistracija=new Button();
            SuspendLayout();
            // 
            // labelRegistracijaIme
            // 
            labelRegistracijaIme.AutoSize=true;
            labelRegistracijaIme.BackColor=Color.White;
            labelRegistracijaIme.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaIme.Location=new Point(50, 115);
            labelRegistracijaIme.Name="labelRegistracijaIme";
            labelRegistracijaIme.Size=new Size(47, 28);
            labelRegistracijaIme.TabIndex=0;
            labelRegistracijaIme.Text="Ime";
            // 
            // labelRegistracijaPrezime
            // 
            labelRegistracijaPrezime.AutoSize=true;
            labelRegistracijaPrezime.BackColor=Color.White;
            labelRegistracijaPrezime.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaPrezime.Location=new Point(50, 165);
            labelRegistracijaPrezime.Name="labelRegistracijaPrezime";
            labelRegistracijaPrezime.Size=new Size(86, 28);
            labelRegistracijaPrezime.TabIndex=1;
            labelRegistracijaPrezime.Text="Prezime";
            // 
            // labelRegistracijaEmail
            // 
            labelRegistracijaEmail.AutoSize=true;
            labelRegistracijaEmail.BackColor=Color.White;
            labelRegistracijaEmail.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaEmail.Location=new Point(50, 215);
            labelRegistracijaEmail.Name="labelRegistracijaEmail";
            labelRegistracijaEmail.Size=new Size(62, 28);
            labelRegistracijaEmail.TabIndex=3;
            labelRegistracijaEmail.Text="Email";
            // 
            // labelRegistracijaTelefon
            // 
            labelRegistracijaTelefon.AutoSize=true;
            labelRegistracijaTelefon.BackColor=Color.White;
            labelRegistracijaTelefon.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaTelefon.Location=new Point(50, 265);
            labelRegistracijaTelefon.Name="labelRegistracijaTelefon";
            labelRegistracijaTelefon.Size=new Size(79, 28);
            labelRegistracijaTelefon.TabIndex=4;
            labelRegistracijaTelefon.Text="Telefon";
            // 
            // labelRegistracijaMjesto
            // 
            labelRegistracijaMjesto.AutoSize=true;
            labelRegistracijaMjesto.BackColor=Color.White;
            labelRegistracijaMjesto.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaMjesto.Location=new Point(50, 365);
            labelRegistracijaMjesto.Name="labelRegistracijaMjesto";
            labelRegistracijaMjesto.Size=new Size(78, 28);
            labelRegistracijaMjesto.TabIndex=5;
            labelRegistracijaMjesto.Text="Mjesto";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(142, 21);
            label1.Name="label1";
            label1.Size=new Size(209, 38);
            label1.TabIndex=6;
            label1.Text="Dodaj Korisnika";
            // 
            // buttonRegistrujSePotvrdi
            // 
            buttonRegistrujSePotvrdi.BackColor=Color.FromArgb(128, 255, 128);
            buttonRegistrujSePotvrdi.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrujSePotvrdi.Location=new Point(98, 440);
            buttonRegistrujSePotvrdi.Name="buttonRegistrujSePotvrdi";
            buttonRegistrujSePotvrdi.Size=new Size(101, 42);
            buttonRegistrujSePotvrdi.TabIndex=7;
            buttonRegistrujSePotvrdi.Text="Potvrdi";
            buttonRegistrujSePotvrdi.UseVisualStyleBackColor=false;
            buttonRegistrujSePotvrdi.Click+=buttonRegistrujSePotvrdi_Click;
            // 
            // buttonRegistrujSeOdustani
            // 
            buttonRegistrujSeOdustani.BackColor=Color.FromArgb(255, 128, 128);
            buttonRegistrujSeOdustani.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrujSeOdustani.Location=new Point(281, 440);
            buttonRegistrujSeOdustani.Name="buttonRegistrujSeOdustani";
            buttonRegistrujSeOdustani.Size=new Size(102, 40);
            buttonRegistrujSeOdustani.TabIndex=8;
            buttonRegistrujSeOdustani.Text="Odustani";
            buttonRegistrujSeOdustani.UseVisualStyleBackColor=false;
            buttonRegistrujSeOdustani.Click+=buttonRegistrujSeOdustani_Click;
            // 
            // textBoxRegistracijaIme
            // 
            textBoxRegistracijaIme.Location=new Point(175, 112);
            textBoxRegistracijaIme.Name="textBoxRegistracijaIme";
            textBoxRegistracijaIme.Size=new Size(153, 27);
            textBoxRegistracijaIme.TabIndex=9;
            // 
            // textBoxRegistracijaPrezime
            // 
            textBoxRegistracijaPrezime.Location=new Point(175, 162);
            textBoxRegistracijaPrezime.Name="textBoxRegistracijaPrezime";
            textBoxRegistracijaPrezime.Size=new Size(153, 27);
            textBoxRegistracijaPrezime.TabIndex=10;
            // 
            // textBoxRegistracijaEmail
            // 
            textBoxRegistracijaEmail.Location=new Point(175, 212);
            textBoxRegistracijaEmail.Name="textBoxRegistracijaEmail";
            textBoxRegistracijaEmail.Size=new Size(153, 27);
            textBoxRegistracijaEmail.TabIndex=12;
            // 
            // textBoxRegistracijaTelefon
            // 
            textBoxRegistracijaTelefon.Location=new Point(175, 262);
            textBoxRegistracijaTelefon.Name="textBoxRegistracijaTelefon";
            textBoxRegistracijaTelefon.Size=new Size(153, 27);
            textBoxRegistracijaTelefon.TabIndex=13;
            // 
            // comboBoxRegistrujSeMjesto
            // 
            comboBoxRegistrujSeMjesto.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxRegistrujSeMjesto.FormattingEnabled=true;
            comboBoxRegistrujSeMjesto.Location=new Point(175, 361);
            comboBoxRegistrujSeMjesto.Name="comboBoxRegistrujSeMjesto";
            comboBoxRegistrujSeMjesto.Size=new Size(153, 28);
            comboBoxRegistrujSeMjesto.TabIndex=14;
            // 
            // labelRegistracijaUlicaiBroj
            // 
            labelRegistracijaUlicaiBroj.AutoSize=true;
            labelRegistracijaUlicaiBroj.BackColor=Color.White;
            labelRegistracijaUlicaiBroj.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaUlicaiBroj.Location=new Point(50, 315);
            labelRegistracijaUlicaiBroj.Name="labelRegistracijaUlicaiBroj";
            labelRegistracijaUlicaiBroj.Size=new Size(111, 28);
            labelRegistracijaUlicaiBroj.TabIndex=15;
            labelRegistracijaUlicaiBroj.Text="Ulica i broj";
            // 
            // textBoxRegistracijaUlicaiBroj
            // 
            textBoxRegistracijaUlicaiBroj.Location=new Point(175, 312);
            textBoxRegistracijaUlicaiBroj.Name="textBoxRegistracijaUlicaiBroj";
            textBoxRegistracijaUlicaiBroj.Size=new Size(153, 27);
            textBoxRegistracijaUlicaiBroj.TabIndex=16;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.White;
            label2.Location=new Point(334, 315);
            label2.Name="label2";
            label2.Size=new Size(112, 20);
            label2.TabIndex=17;
            label2.Text="(nije obavezno)";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.White;
            label3.Location=new Point(334, 265);
            label3.Name="label3";
            label3.Size=new Size(112, 20);
            label3.TabIndex=18;
            label3.Text="(nije obavezno)";
            // 
            // buttonDodajMjestoRegistracija
            // 
            buttonDodajMjestoRegistracija.BackColor=Color.White;
            buttonDodajMjestoRegistracija.Location=new Point(334, 360);
            buttonDodajMjestoRegistracija.Name="buttonDodajMjestoRegistracija";
            buttonDodajMjestoRegistracija.Size=new Size(112, 29);
            buttonDodajMjestoRegistracija.TabIndex=19;
            buttonDodajMjestoRegistracija.Text="Dodaj Mjesto";
            buttonDodajMjestoRegistracija.UseVisualStyleBackColor=false;
            buttonDodajMjestoRegistracija.Click+=buttonDodajMjestoRegistracija_Click;
            // 
            // FormDodajKorisnika
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(489, 527);
            Controls.Add(buttonDodajMjestoRegistracija);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxRegistracijaUlicaiBroj);
            Controls.Add(labelRegistracijaUlicaiBroj);
            Controls.Add(comboBoxRegistrujSeMjesto);
            Controls.Add(textBoxRegistracijaTelefon);
            Controls.Add(textBoxRegistracijaEmail);
            Controls.Add(textBoxRegistracijaPrezime);
            Controls.Add(textBoxRegistracijaIme);
            Controls.Add(buttonRegistrujSeOdustani);
            Controls.Add(buttonRegistrujSePotvrdi);
            Controls.Add(label1);
            Controls.Add(labelRegistracijaMjesto);
            Controls.Add(labelRegistracijaTelefon);
            Controls.Add(labelRegistracijaEmail);
            Controls.Add(labelRegistracijaPrezime);
            Controls.Add(labelRegistracijaIme);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormDodajKorisnika";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormRegistracija";
            Load+=FormRegistracija_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegistracijaIme;
        private Label labelRegistracijaPrezime;
        private Label labelRegistracijaEmail;
        private Label labelRegistracijaTelefon;
        private Label labelRegistracijaMjesto;
        private Label label1;
        private Button buttonRegistrujSePotvrdi;
        private Button buttonRegistrujSeOdustani;
        private TextBox textBoxRegistracijaIme;
        private TextBox textBoxRegistracijaPrezime;
        private TextBox textBoxRegistracijaEmail;
        private TextBox textBoxRegistracijaTelefon;
        private ComboBox comboBoxRegistrujSeMjesto;
        private Label labelRegistracijaUlicaiBroj;
        private TextBox textBoxRegistracijaUlicaiBroj;
        private Label label2;
        private Label label3;
        private Button buttonDodajMjestoRegistracija;
    }
}