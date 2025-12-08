namespace Projekat_biblioteka
{
    partial class FormIzmjenaIzdavaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzmjenaIzdavaca));
            label4=new Label();
            textBoxIDIzdavaca=new TextBox();
            label1=new Label();
            comboBoxIzmjenaMjestoIzdavaca=new ComboBox();
            textBoxIzmjenaTelefonIzdavaca=new TextBox();
            textBoxIzmjenaNazivIzdavaca=new TextBox();
            buttonOdustaniIzdavaca=new Button();
            buttonPotvrdiIzdavac=new Button();
            labelRegistracijaMjesto=new Label();
            labelRegistracijaPrezime=new Label();
            labelRegistracijaIme=new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.White;
            label4.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(79, 21);
            label4.Name="label4";
            label4.Size=new Size(228, 38);
            label4.TabIndex=59;
            label4.Text="Izmjena Izdavača";
            // 
            // textBoxIDIzdavaca
            // 
            textBoxIDIzdavaca.Location=new Point(207, 109);
            textBoxIDIzdavaca.Name="textBoxIDIzdavaca";
            textBoxIDIzdavaca.Size=new Size(153, 27);
            textBoxIDIzdavaca.TabIndex=58;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(45, 109);
            label1.Name="label1";
            label1.Size=new Size(121, 28);
            label1.TabIndex=57;
            label1.Text="ID Korisnika";
            // 
            // comboBoxIzmjenaMjestoIzdavaca
            // 
            comboBoxIzmjenaMjestoIzdavaca.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxIzmjenaMjestoIzdavaca.FormattingEnabled=true;
            comboBoxIzmjenaMjestoIzdavaca.Location=new Point(207, 257);
            comboBoxIzmjenaMjestoIzdavaca.Name="comboBoxIzmjenaMjestoIzdavaca";
            comboBoxIzmjenaMjestoIzdavaca.Size=new Size(153, 28);
            comboBoxIzmjenaMjestoIzdavaca.TabIndex=52;
            // 
            // textBoxIzmjenaTelefonIzdavaca
            // 
            textBoxIzmjenaTelefonIzdavaca.Location=new Point(207, 209);
            textBoxIzmjenaTelefonIzdavaca.Name="textBoxIzmjenaTelefonIzdavaca";
            textBoxIzmjenaTelefonIzdavaca.Size=new Size(153, 27);
            textBoxIzmjenaTelefonIzdavaca.TabIndex=49;
            // 
            // textBoxIzmjenaNazivIzdavaca
            // 
            textBoxIzmjenaNazivIzdavaca.Location=new Point(207, 159);
            textBoxIzmjenaNazivIzdavaca.Name="textBoxIzmjenaNazivIzdavaca";
            textBoxIzmjenaNazivIzdavaca.Size=new Size(153, 27);
            textBoxIzmjenaNazivIzdavaca.TabIndex=48;
            // 
            // buttonOdustaniIzdavaca
            // 
            buttonOdustaniIzdavaca.BackColor=Color.FromArgb(255, 128, 128);
            buttonOdustaniIzdavaca.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdustaniIzdavaca.Location=new Point(240, 330);
            buttonOdustaniIzdavaca.Name="buttonOdustaniIzdavaca";
            buttonOdustaniIzdavaca.Size=new Size(102, 40);
            buttonOdustaniIzdavaca.TabIndex=47;
            buttonOdustaniIzdavaca.Text="Odustani";
            buttonOdustaniIzdavaca.UseVisualStyleBackColor=false;
            buttonOdustaniIzdavaca.Click+=buttonOdustaniIzdavaca_Click;
            // 
            // buttonPotvrdiIzdavac
            // 
            buttonPotvrdiIzdavac.BackColor=Color.FromArgb(128, 255, 128);
            buttonPotvrdiIzdavac.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPotvrdiIzdavac.Location=new Point(61, 328);
            buttonPotvrdiIzdavac.Name="buttonPotvrdiIzdavac";
            buttonPotvrdiIzdavac.Size=new Size(101, 42);
            buttonPotvrdiIzdavac.TabIndex=46;
            buttonPotvrdiIzdavac.Text="Potvrdi";
            buttonPotvrdiIzdavac.UseVisualStyleBackColor=false;
            buttonPotvrdiIzdavac.Click+=buttonPotvrdiIzdavac_Click;
            // 
            // labelRegistracijaMjesto
            // 
            labelRegistracijaMjesto.AutoSize=true;
            labelRegistracijaMjesto.BackColor=Color.White;
            labelRegistracijaMjesto.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaMjesto.Location=new Point(45, 257);
            labelRegistracijaMjesto.Name="labelRegistracijaMjesto";
            labelRegistracijaMjesto.Size=new Size(78, 28);
            labelRegistracijaMjesto.TabIndex=45;
            labelRegistracijaMjesto.Text="Mjesto";
            // 
            // labelRegistracijaPrezime
            // 
            labelRegistracijaPrezime.AutoSize=true;
            labelRegistracijaPrezime.BackColor=Color.White;
            labelRegistracijaPrezime.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaPrezime.Location=new Point(45, 209);
            labelRegistracijaPrezime.Name="labelRegistracijaPrezime";
            labelRegistracijaPrezime.Size=new Size(156, 28);
            labelRegistracijaPrezime.TabIndex=42;
            labelRegistracijaPrezime.Text="Kontakt telefon";
            // 
            // labelRegistracijaIme
            // 
            labelRegistracijaIme.AutoSize=true;
            labelRegistracijaIme.BackColor=Color.White;
            labelRegistracijaIme.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegistracijaIme.Location=new Point(45, 159);
            labelRegistracijaIme.Name="labelRegistracijaIme";
            labelRegistracijaIme.Size=new Size(145, 28);
            labelRegistracijaIme.TabIndex=41;
            labelRegistracijaIme.Text="Naziv izdavača";
            // 
            // FormIzmjenaIzdavaca
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(396, 415);
            Controls.Add(label4);
            Controls.Add(textBoxIDIzdavaca);
            Controls.Add(label1);
            Controls.Add(comboBoxIzmjenaMjestoIzdavaca);
            Controls.Add(textBoxIzmjenaTelefonIzdavaca);
            Controls.Add(textBoxIzmjenaNazivIzdavaca);
            Controls.Add(buttonOdustaniIzdavaca);
            Controls.Add(buttonPotvrdiIzdavac);
            Controls.Add(labelRegistracijaMjesto);
            Controls.Add(labelRegistracijaPrezime);
            Controls.Add(labelRegistracijaIme);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormIzmjenaIzdavaca";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormIzmjenaIzdavaca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBoxIDIzdavaca;
        private Label label1;
        private ComboBox comboBoxIzmjenaMjestoIzdavaca;
        private TextBox textBoxIzmjenaTelefonIzdavaca;
        private TextBox textBoxIzmjenaNazivIzdavaca;
        private Button buttonOdustaniIzdavaca;
        private Button buttonPotvrdiIzdavac;
        private Label labelRegistracijaMjesto;
        private Label labelRegistracijaPrezime;
        private Label labelRegistracijaIme;
    }
}