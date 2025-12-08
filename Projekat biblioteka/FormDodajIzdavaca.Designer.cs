namespace Projekat_biblioteka
{
    partial class FormDodajIzdavaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajIzdavaca));
            buttonDodajMjestoIzdavac=new Button();
            comboBoxDodajIzdavacaMjesto=new ComboBox();
            textBoxDodajIzdavacaKontakt=new TextBox();
            textBoxDodajIzdavacaNaziv=new TextBox();
            buttonDodajIzdavacaOdustani=new Button();
            buttonDodajIzdavacaPotvrdi=new Button();
            label1=new Label();
            labelDodajIzdavacaMjesto=new Label();
            labelDodajIzdavacaKontakt=new Label();
            labelDodajIzdavacaNaziv=new Label();
            SuspendLayout();
            // 
            // buttonDodajMjestoIzdavac
            // 
            buttonDodajMjestoIzdavac.BackColor=Color.White;
            buttonDodajMjestoIzdavac.Location=new Point(396, 224);
            buttonDodajMjestoIzdavac.Name="buttonDodajMjestoIzdavac";
            buttonDodajMjestoIzdavac.Size=new Size(112, 29);
            buttonDodajMjestoIzdavac.TabIndex=37;
            buttonDodajMjestoIzdavac.Text="Dodaj Mjesto";
            buttonDodajMjestoIzdavac.UseVisualStyleBackColor=false;
            buttonDodajMjestoIzdavac.Click+=buttonDodajMjestoIzdavac_Click;
            // 
            // comboBoxDodajIzdavacaMjesto
            // 
            comboBoxDodajIzdavacaMjesto.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxDodajIzdavacaMjesto.FormattingEnabled=true;
            comboBoxDodajIzdavacaMjesto.Location=new Point(206, 225);
            comboBoxDodajIzdavacaMjesto.Name="comboBoxDodajIzdavacaMjesto";
            comboBoxDodajIzdavacaMjesto.Size=new Size(171, 28);
            comboBoxDodajIzdavacaMjesto.TabIndex=32;
            // 
            // textBoxDodajIzdavacaKontakt
            // 
            textBoxDodajIzdavacaKontakt.Location=new Point(206, 170);
            textBoxDodajIzdavacaKontakt.Name="textBoxDodajIzdavacaKontakt";
            textBoxDodajIzdavacaKontakt.Size=new Size(171, 27);
            textBoxDodajIzdavacaKontakt.TabIndex=29;
            // 
            // textBoxDodajIzdavacaNaziv
            // 
            textBoxDodajIzdavacaNaziv.Location=new Point(206, 121);
            textBoxDodajIzdavacaNaziv.Name="textBoxDodajIzdavacaNaziv";
            textBoxDodajIzdavacaNaziv.Size=new Size(171, 27);
            textBoxDodajIzdavacaNaziv.TabIndex=28;
            // 
            // buttonDodajIzdavacaOdustani
            // 
            buttonDodajIzdavacaOdustani.BackColor=Color.FromArgb(255, 128, 128);
            buttonDodajIzdavacaOdustani.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajIzdavacaOdustani.Location=new Point(306, 300);
            buttonDodajIzdavacaOdustani.Name="buttonDodajIzdavacaOdustani";
            buttonDodajIzdavacaOdustani.Size=new Size(102, 40);
            buttonDodajIzdavacaOdustani.TabIndex=27;
            buttonDodajIzdavacaOdustani.Text="Odustani";
            buttonDodajIzdavacaOdustani.UseVisualStyleBackColor=false;
            buttonDodajIzdavacaOdustani.Click+=buttonDodajIzdavacaOdustani_Click;
            // 
            // buttonDodajIzdavacaPotvrdi
            // 
            buttonDodajIzdavacaPotvrdi.BackColor=Color.FromArgb(128, 255, 128);
            buttonDodajIzdavacaPotvrdi.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajIzdavacaPotvrdi.Location=new Point(130, 300);
            buttonDodajIzdavacaPotvrdi.Name="buttonDodajIzdavacaPotvrdi";
            buttonDodajIzdavacaPotvrdi.Size=new Size(101, 42);
            buttonDodajIzdavacaPotvrdi.TabIndex=26;
            buttonDodajIzdavacaPotvrdi.Text="Potvrdi";
            buttonDodajIzdavacaPotvrdi.UseVisualStyleBackColor=false;
            buttonDodajIzdavacaPotvrdi.Click+=buttonDodajIzdavacaPotvrdi_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(178, 31);
            label1.Name="label1";
            label1.Size=new Size(203, 38);
            label1.TabIndex=25;
            label1.Text="Dodaj Izdavača";
            // 
            // labelDodajIzdavacaMjesto
            // 
            labelDodajIzdavacaMjesto.AutoSize=true;
            labelDodajIzdavacaMjesto.BackColor=Color.White;
            labelDodajIzdavacaMjesto.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDodajIzdavacaMjesto.Location=new Point(44, 222);
            labelDodajIzdavacaMjesto.Name="labelDodajIzdavacaMjesto";
            labelDodajIzdavacaMjesto.Size=new Size(78, 28);
            labelDodajIzdavacaMjesto.TabIndex=24;
            labelDodajIzdavacaMjesto.Text="Mjesto";
            // 
            // labelDodajIzdavacaKontakt
            // 
            labelDodajIzdavacaKontakt.AutoSize=true;
            labelDodajIzdavacaKontakt.BackColor=Color.White;
            labelDodajIzdavacaKontakt.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDodajIzdavacaKontakt.Location=new Point(44, 170);
            labelDodajIzdavacaKontakt.Name="labelDodajIzdavacaKontakt";
            labelDodajIzdavacaKontakt.Size=new Size(156, 28);
            labelDodajIzdavacaKontakt.TabIndex=21;
            labelDodajIzdavacaKontakt.Text="Kontakt telefon";
            // 
            // labelDodajIzdavacaNaziv
            // 
            labelDodajIzdavacaNaziv.AutoSize=true;
            labelDodajIzdavacaNaziv.BackColor=Color.White;
            labelDodajIzdavacaNaziv.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDodajIzdavacaNaziv.Location=new Point(44, 120);
            labelDodajIzdavacaNaziv.Name="labelDodajIzdavacaNaziv";
            labelDodajIzdavacaNaziv.Size=new Size(145, 28);
            labelDodajIzdavacaNaziv.TabIndex=20;
            labelDodajIzdavacaNaziv.Text="Naziv izdavača";
            // 
            // FormDodajIzdavaca
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(547, 384);
            Controls.Add(buttonDodajMjestoIzdavac);
            Controls.Add(comboBoxDodajIzdavacaMjesto);
            Controls.Add(textBoxDodajIzdavacaKontakt);
            Controls.Add(textBoxDodajIzdavacaNaziv);
            Controls.Add(buttonDodajIzdavacaOdustani);
            Controls.Add(buttonDodajIzdavacaPotvrdi);
            Controls.Add(label1);
            Controls.Add(labelDodajIzdavacaMjesto);
            Controls.Add(labelDodajIzdavacaKontakt);
            Controls.Add(labelDodajIzdavacaNaziv);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormDodajIzdavaca";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormDodajIzdavaca";
            Load+=FormDodajIzdavaca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDodajMjestoIzdavac;
        private ComboBox comboBoxDodajIzdavacaMjesto;
        private TextBox textBoxDodajIzdavacaKontakt;
        private TextBox textBoxDodajIzdavacaNaziv;
        private Button buttonDodajIzdavacaOdustani;
        private Button buttonDodajIzdavacaPotvrdi;
        private Label label1;
        private Label labelDodajIzdavacaMjesto;
        private Label labelDodajIzdavacaKontakt;
        private Label labelDodajIzdavacaNaziv;
    }
}