namespace Projekat_biblioteka
{
    partial class FormIzmjenaKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzmjenaKorisnika));
            label3=new Label();
            label2=new Label();
            textBoxIzmjenaUlicaiBroj=new TextBox();
            labelRegistracijaUlicaiBroj=new Label();
            textBoxIzmjenaTelefon=new TextBox();
            textBoxIzmjenaEmail=new TextBox();
            textBoxIzmjenaPrezime=new TextBox();
            textBoxIzmjenaIme=new TextBox();
            buttonRegistrujSeOdustani=new Button();
            buttonRegistrujSePotvrdi=new Button();
            labelRegistracijaMjesto=new Label();
            labelRegistracijaTelefon=new Label();
            labelRegistracijaEmail=new Label();
            labelRegistracijaPrezime=new Label();
            labelRegistracijaIme=new Label();
            label1=new Label();
            textBoxIDKorisnika=new TextBox();
            label4=new Label();
            comboBoxIzmjenaMjesto=new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.White;
            label3.Location=new Point(340, 319);
            label3.Name="label3";
            label3.Size=new Size(112, 20);
            label3.TabIndex=37;
            label3.Text="(nije obavezno)";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.White;
            label2.Location=new Point(340, 369);
            label2.Name="label2";
            label2.Size=new Size(112, 20);
            label2.TabIndex=36;
            label2.Text="(nije obavezno)";
            // 
            // textBoxIzmjenaUlicaiBroj
            // 
            textBoxIzmjenaUlicaiBroj.Location=new Point(181, 366);
            textBoxIzmjenaUlicaiBroj.Name="textBoxIzmjenaUlicaiBroj";
            textBoxIzmjenaUlicaiBroj.Size=new Size(153, 27);
            textBoxIzmjenaUlicaiBroj.TabIndex=35;
            // 
            // labelRegistracijaUlicaiBroj
            // 
            labelRegistracijaUlicaiBroj.AutoSize=true;
            labelRegistracijaUlicaiBroj.BackColor=Color.White;
            labelRegistracijaUlicaiBroj.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaUlicaiBroj.Location=new Point(56, 369);
            labelRegistracijaUlicaiBroj.Name="labelRegistracijaUlicaiBroj";
            labelRegistracijaUlicaiBroj.Size=new Size(111, 28);
            labelRegistracijaUlicaiBroj.TabIndex=34;
            labelRegistracijaUlicaiBroj.Text="Ulica i broj";
            // 
            // textBoxIzmjenaTelefon
            // 
            textBoxIzmjenaTelefon.Location=new Point(181, 316);
            textBoxIzmjenaTelefon.Name="textBoxIzmjenaTelefon";
            textBoxIzmjenaTelefon.Size=new Size(153, 27);
            textBoxIzmjenaTelefon.TabIndex=32;
            // 
            // textBoxIzmjenaEmail
            // 
            textBoxIzmjenaEmail.Location=new Point(181, 266);
            textBoxIzmjenaEmail.Name="textBoxIzmjenaEmail";
            textBoxIzmjenaEmail.Size=new Size(153, 27);
            textBoxIzmjenaEmail.TabIndex=31;
            // 
            // textBoxIzmjenaPrezime
            // 
            textBoxIzmjenaPrezime.Location=new Point(181, 214);
            textBoxIzmjenaPrezime.Name="textBoxIzmjenaPrezime";
            textBoxIzmjenaPrezime.Size=new Size(153, 27);
            textBoxIzmjenaPrezime.TabIndex=29;
            // 
            // textBoxIzmjenaIme
            // 
            textBoxIzmjenaIme.Location=new Point(181, 164);
            textBoxIzmjenaIme.Name="textBoxIzmjenaIme";
            textBoxIzmjenaIme.Size=new Size(153, 27);
            textBoxIzmjenaIme.TabIndex=28;
            // 
            // buttonRegistrujSeOdustani
            // 
            buttonRegistrujSeOdustani.BackColor=Color.FromArgb(255, 128, 128);
            buttonRegistrujSeOdustani.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrujSeOdustani.Location=new Point(283, 520);
            buttonRegistrujSeOdustani.Name="buttonRegistrujSeOdustani";
            buttonRegistrujSeOdustani.Size=new Size(102, 40);
            buttonRegistrujSeOdustani.TabIndex=27;
            buttonRegistrujSeOdustani.Text="Odustani";
            buttonRegistrujSeOdustani.UseVisualStyleBackColor=false;
            buttonRegistrujSeOdustani.Click+=buttonRegistrujSeOdustani_Click;
            // 
            // buttonRegistrujSePotvrdi
            // 
            buttonRegistrujSePotvrdi.BackColor=Color.FromArgb(128, 255, 128);
            buttonRegistrujSePotvrdi.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrujSePotvrdi.Location=new Point(104, 518);
            buttonRegistrujSePotvrdi.Name="buttonRegistrujSePotvrdi";
            buttonRegistrujSePotvrdi.Size=new Size(101, 42);
            buttonRegistrujSePotvrdi.TabIndex=26;
            buttonRegistrujSePotvrdi.Text="Potvrdi";
            buttonRegistrujSePotvrdi.UseVisualStyleBackColor=false;
            buttonRegistrujSePotvrdi.Click+=buttonRegistrujSePotvrdi_Click;
            // 
            // labelRegistracijaMjesto
            // 
            labelRegistracijaMjesto.AutoSize=true;
            labelRegistracijaMjesto.BackColor=Color.White;
            labelRegistracijaMjesto.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaMjesto.Location=new Point(56, 419);
            labelRegistracijaMjesto.Name="labelRegistracijaMjesto";
            labelRegistracijaMjesto.Size=new Size(78, 28);
            labelRegistracijaMjesto.TabIndex=25;
            labelRegistracijaMjesto.Text="Mjesto";
            // 
            // labelRegistracijaTelefon
            // 
            labelRegistracijaTelefon.AutoSize=true;
            labelRegistracijaTelefon.BackColor=Color.White;
            labelRegistracijaTelefon.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaTelefon.Location=new Point(56, 319);
            labelRegistracijaTelefon.Name="labelRegistracijaTelefon";
            labelRegistracijaTelefon.Size=new Size(79, 28);
            labelRegistracijaTelefon.TabIndex=24;
            labelRegistracijaTelefon.Text="Telefon";
            // 
            // labelRegistracijaEmail
            // 
            labelRegistracijaEmail.AutoSize=true;
            labelRegistracijaEmail.BackColor=Color.White;
            labelRegistracijaEmail.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaEmail.Location=new Point(56, 269);
            labelRegistracijaEmail.Name="labelRegistracijaEmail";
            labelRegistracijaEmail.Size=new Size(62, 28);
            labelRegistracijaEmail.TabIndex=23;
            labelRegistracijaEmail.Text="Email";
            // 
            // labelRegistracijaPrezime
            // 
            labelRegistracijaPrezime.AutoSize=true;
            labelRegistracijaPrezime.BackColor=Color.White;
            labelRegistracijaPrezime.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaPrezime.Location=new Point(56, 217);
            labelRegistracijaPrezime.Name="labelRegistracijaPrezime";
            labelRegistracijaPrezime.Size=new Size(86, 28);
            labelRegistracijaPrezime.TabIndex=21;
            labelRegistracijaPrezime.Text="Prezime";
            // 
            // labelRegistracijaIme
            // 
            labelRegistracijaIme.AutoSize=true;
            labelRegistracijaIme.BackColor=Color.White;
            labelRegistracijaIme.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaIme.Location=new Point(56, 167);
            labelRegistracijaIme.Name="labelRegistracijaIme";
            labelRegistracijaIme.Size=new Size(47, 28);
            labelRegistracijaIme.TabIndex=20;
            labelRegistracijaIme.Text="Ime";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(56, 117);
            label1.Name="label1";
            label1.Size=new Size(121, 28);
            label1.TabIndex=38;
            label1.Text="ID Korisnika";
            // 
            // textBoxIDKorisnika
            // 
            textBoxIDKorisnika.Location=new Point(181, 115);
            textBoxIDKorisnika.Name="textBoxIDKorisnika";
            textBoxIDKorisnika.Size=new Size(153, 27);
            textBoxIDKorisnika.TabIndex=39;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.White;
            label4.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(129, 28);
            label4.Name="label4";
            label4.Size=new Size(234, 38);
            label4.TabIndex=40;
            label4.Text="Izmjena Korisnika";
            // 
            // comboBoxIzmjenaMjesto
            // 
            comboBoxIzmjenaMjesto.FormattingEnabled=true;
            comboBoxIzmjenaMjesto.Location=new Point(181, 419);
            comboBoxIzmjenaMjesto.Name="comboBoxIzmjenaMjesto";
            comboBoxIzmjenaMjesto.Size=new Size(153, 28);
            comboBoxIzmjenaMjesto.TabIndex=41;
            // 
            // FormIzmjenaKorisnika
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(471, 583);
            Controls.Add(comboBoxIzmjenaMjesto);
            Controls.Add(label4);
            Controls.Add(textBoxIDKorisnika);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxIzmjenaUlicaiBroj);
            Controls.Add(labelRegistracijaUlicaiBroj);
            Controls.Add(textBoxIzmjenaTelefon);
            Controls.Add(textBoxIzmjenaEmail);
            Controls.Add(textBoxIzmjenaPrezime);
            Controls.Add(textBoxIzmjenaIme);
            Controls.Add(buttonRegistrujSeOdustani);
            Controls.Add(buttonRegistrujSePotvrdi);
            Controls.Add(labelRegistracijaMjesto);
            Controls.Add(labelRegistracijaTelefon);
            Controls.Add(labelRegistracijaEmail);
            Controls.Add(labelRegistracijaPrezime);
            Controls.Add(labelRegistracijaIme);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormIzmjenaKorisnika";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormIzmjenaKorisnika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox textBoxIzmjenaUlicaiBroj;
        private Label labelRegistracijaUlicaiBroj;
        private TextBox textBoxIzmjenaTelefon;
        private TextBox textBoxIzmjenaEmail;
        private TextBox textBoxIzmjenaPrezime;
        private TextBox textBoxIzmjenaIme;
        private Button buttonRegistrujSeOdustani;
        private Button buttonRegistrujSePotvrdi;
        private Label labelRegistracijaMjesto;
        private Label labelRegistracijaTelefon;
        private Label labelRegistracijaEmail;
        private Label labelRegistracijaPrezime;
        private Label labelRegistracijaIme;
        private Label label1;
        private TextBox textBoxIDKorisnika;
        private Label label4;
        private ComboBox comboBoxIzmjenaMjesto;
    }
}