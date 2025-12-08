namespace Projekat_biblioteka
{
    partial class FormIzmjenaIzdavanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzmjenaIzdavanja));
            buttonOdustaniIzdavanjeIzmjena=new Button();
            buttonPotvrdiIzdavanje=new Button();
            label4=new Label();
            dateTimePickerDatumVracanjaIzmjena=new DateTimePicker();
            dateTimePickerDatumIzdavanjaIzmjena=new DateTimePicker();
            labelDatumVracanja=new Label();
            labelDatumIzdavanja=new Label();
            labelBibliotekarIzdavanjeIzmjena=new Label();
            comboBoxBibliotekarIzdavanjeIzmjena=new ComboBox();
            comboBoxImeKorisnikaIzdavanjeIzmjena=new ComboBox();
            labelImeKorisnikaIzdavanje=new Label();
            comboBoxImeKnjigeIzdavanjeIzmjena=new ComboBox();
            labelImeKnjigeIzdavanje=new Label();
            textBoxIDIzdavanja=new TextBox();
            label1=new Label();
            SuspendLayout();
            // 
            // buttonOdustaniIzdavanjeIzmjena
            // 
            buttonOdustaniIzdavanjeIzmjena.BackColor=Color.FromArgb(255, 128, 128);
            buttonOdustaniIzdavanjeIzmjena.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdustaniIzdavanjeIzmjena.Location=new Point(354, 442);
            buttonOdustaniIzdavanjeIzmjena.Name="buttonOdustaniIzdavanjeIzmjena";
            buttonOdustaniIzdavanjeIzmjena.Size=new Size(102, 40);
            buttonOdustaniIzdavanjeIzmjena.TabIndex=88;
            buttonOdustaniIzdavanjeIzmjena.Text="Odustani";
            buttonOdustaniIzdavanjeIzmjena.UseVisualStyleBackColor=false;
            buttonOdustaniIzdavanjeIzmjena.Click+=buttonOdustaniIzdavanjeIzmjena_Click;
            // 
            // buttonPotvrdiIzdavanje
            // 
            buttonPotvrdiIzdavanje.BackColor=Color.FromArgb(128, 255, 128);
            buttonPotvrdiIzdavanje.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPotvrdiIzdavanje.Location=new Point(172, 442);
            buttonPotvrdiIzdavanje.Name="buttonPotvrdiIzdavanje";
            buttonPotvrdiIzdavanje.Size=new Size(101, 42);
            buttonPotvrdiIzdavanje.TabIndex=87;
            buttonPotvrdiIzdavanje.Text="Potvrdi";
            buttonPotvrdiIzdavanje.UseVisualStyleBackColor=false;
            buttonPotvrdiIzdavanje.Click+=buttonPotvrdiIzdavanje_Click;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.White;
            label4.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(160, 25);
            label4.Name="label4";
            label4.Size=new Size(321, 38);
            label4.TabIndex=86;
            label4.Text="Izmjena Izdavanja Knjige";
            // 
            // dateTimePickerDatumVracanjaIzmjena
            // 
            dateTimePickerDatumVracanjaIzmjena.Location=new Point(307, 358);
            dateTimePickerDatumVracanjaIzmjena.Name="dateTimePickerDatumVracanjaIzmjena";
            dateTimePickerDatumVracanjaIzmjena.Size=new Size(250, 27);
            dateTimePickerDatumVracanjaIzmjena.TabIndex=85;
            // 
            // dateTimePickerDatumIzdavanjaIzmjena
            // 
            dateTimePickerDatumIzdavanjaIzmjena.Location=new Point(307, 308);
            dateTimePickerDatumIzdavanjaIzmjena.Name="dateTimePickerDatumIzdavanjaIzmjena";
            dateTimePickerDatumIzdavanjaIzmjena.Size=new Size(250, 27);
            dateTimePickerDatumIzdavanjaIzmjena.TabIndex=84;
            // 
            // labelDatumVracanja
            // 
            labelDatumVracanja.AutoSize=true;
            labelDatumVracanja.BackColor=Color.White;
            labelDatumVracanja.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatumVracanja.Location=new Point(79, 357);
            labelDatumVracanja.Name="labelDatumVracanja";
            labelDatumVracanja.Size=new Size(159, 28);
            labelDatumVracanja.TabIndex=83;
            labelDatumVracanja.Text="Datum vraćanja";
            // 
            // labelDatumIzdavanja
            // 
            labelDatumIzdavanja.AutoSize=true;
            labelDatumIzdavanja.BackColor=Color.White;
            labelDatumIzdavanja.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatumIzdavanja.Location=new Point(79, 307);
            labelDatumIzdavanja.Name="labelDatumIzdavanja";
            labelDatumIzdavanja.Size=new Size(166, 28);
            labelDatumIzdavanja.TabIndex=82;
            labelDatumIzdavanja.Text="Datum izdavanja";
            // 
            // labelBibliotekarIzdavanjeIzmjena
            // 
            labelBibliotekarIzdavanjeIzmjena.AutoSize=true;
            labelBibliotekarIzdavanjeIzmjena.BackColor=Color.White;
            labelBibliotekarIzdavanjeIzmjena.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBibliotekarIzdavanjeIzmjena.Location=new Point(79, 257);
            labelBibliotekarIzdavanjeIzmjena.Name="labelBibliotekarIzdavanjeIzmjena";
            labelBibliotekarIzdavanjeIzmjena.Size=new Size(112, 28);
            labelBibliotekarIzdavanjeIzmjena.TabIndex=81;
            labelBibliotekarIzdavanjeIzmjena.Text="Bibliotekar";
            // 
            // comboBoxBibliotekarIzdavanjeIzmjena
            // 
            comboBoxBibliotekarIzdavanjeIzmjena.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxBibliotekarIzdavanjeIzmjena.FormattingEnabled=true;
            comboBoxBibliotekarIzdavanjeIzmjena.Location=new Point(307, 257);
            comboBoxBibliotekarIzdavanjeIzmjena.Name="comboBoxBibliotekarIzdavanjeIzmjena";
            comboBoxBibliotekarIzdavanjeIzmjena.Size=new Size(250, 28);
            comboBoxBibliotekarIzdavanjeIzmjena.TabIndex=80;
            // 
            // comboBoxImeKorisnikaIzdavanjeIzmjena
            // 
            comboBoxImeKorisnikaIzdavanjeIzmjena.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxImeKorisnikaIzdavanjeIzmjena.FormattingEnabled=true;
            comboBoxImeKorisnikaIzdavanjeIzmjena.Location=new Point(307, 158);
            comboBoxImeKorisnikaIzdavanjeIzmjena.Name="comboBoxImeKorisnikaIzdavanjeIzmjena";
            comboBoxImeKorisnikaIzdavanjeIzmjena.Size=new Size(250, 28);
            comboBoxImeKorisnikaIzdavanjeIzmjena.TabIndex=79;
            // 
            // labelImeKorisnikaIzdavanje
            // 
            labelImeKorisnikaIzdavanje.AutoSize=true;
            labelImeKorisnikaIzdavanje.BackColor=Color.White;
            labelImeKorisnikaIzdavanje.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeKorisnikaIzdavanje.Location=new Point(79, 155);
            labelImeKorisnikaIzdavanje.Name="labelImeKorisnikaIzdavanje";
            labelImeKorisnikaIzdavanje.Size=new Size(222, 28);
            labelImeKorisnikaIzdavanje.TabIndex=78;
            labelImeKorisnikaIzdavanje.Text="Ime i prezime korisnika";
            // 
            // comboBoxImeKnjigeIzdavanjeIzmjena
            // 
            comboBoxImeKnjigeIzdavanjeIzmjena.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxImeKnjigeIzdavanjeIzmjena.FormattingEnabled=true;
            comboBoxImeKnjigeIzdavanjeIzmjena.Location=new Point(307, 207);
            comboBoxImeKnjigeIzdavanjeIzmjena.Name="comboBoxImeKnjigeIzdavanjeIzmjena";
            comboBoxImeKnjigeIzdavanjeIzmjena.Size=new Size(250, 28);
            comboBoxImeKnjigeIzdavanjeIzmjena.TabIndex=77;
            // 
            // labelImeKnjigeIzdavanje
            // 
            labelImeKnjigeIzdavanje.AutoSize=true;
            labelImeKnjigeIzdavanje.BackColor=Color.White;
            labelImeKnjigeIzdavanje.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeKnjigeIzdavanje.Location=new Point(79, 207);
            labelImeKnjigeIzdavanje.Name="labelImeKnjigeIzdavanje";
            labelImeKnjigeIzdavanje.Size=new Size(107, 28);
            labelImeKnjigeIzdavanje.TabIndex=76;
            labelImeKnjigeIzdavanje.Text="Ime knjige";
            // 
            // textBoxIDIzdavanja
            // 
            textBoxIDIzdavanja.Location=new Point(307, 110);
            textBoxIDIzdavanja.Name="textBoxIDIzdavanja";
            textBoxIDIzdavanja.Size=new Size(250, 27);
            textBoxIDIzdavanja.TabIndex=90;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(85, 107);
            label1.Name="label1";
            label1.Size=new Size(124, 28);
            label1.TabIndex=89;
            label1.Text="ID Izdavanja";
            // 
            // FormIzmjenaIzdavanja
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(631, 524);
            Controls.Add(textBoxIDIzdavanja);
            Controls.Add(label1);
            Controls.Add(buttonOdustaniIzdavanjeIzmjena);
            Controls.Add(buttonPotvrdiIzdavanje);
            Controls.Add(label4);
            Controls.Add(dateTimePickerDatumVracanjaIzmjena);
            Controls.Add(dateTimePickerDatumIzdavanjaIzmjena);
            Controls.Add(labelDatumVracanja);
            Controls.Add(labelDatumIzdavanja);
            Controls.Add(labelBibliotekarIzdavanjeIzmjena);
            Controls.Add(comboBoxBibliotekarIzdavanjeIzmjena);
            Controls.Add(comboBoxImeKorisnikaIzdavanjeIzmjena);
            Controls.Add(labelImeKorisnikaIzdavanje);
            Controls.Add(comboBoxImeKnjigeIzdavanjeIzmjena);
            Controls.Add(labelImeKnjigeIzdavanje);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormIzmjenaIzdavanja";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormIzmjenaIzdavanja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOdustaniIzdavanjeIzmjena;
        private Button buttonPotvrdiIzdavanje;
        private Label label4;
        private DateTimePicker dateTimePickerDatumVracanjaIzmjena;
        private DateTimePicker dateTimePickerDatumIzdavanjaIzmjena;
        private Label labelDatumVracanja;
        private Label labelDatumIzdavanja;
        private Label labelBibliotekarIzdavanjeIzmjena;
        private ComboBox comboBoxBibliotekarIzdavanjeIzmjena;
        private ComboBox comboBoxImeKorisnikaIzdavanjeIzmjena;
        private Label labelImeKorisnikaIzdavanje;
        private ComboBox comboBoxImeKnjigeIzdavanjeIzmjena;
        private Label labelImeKnjigeIzdavanje;
        private TextBox textBoxIDIzdavanja;
        private Label label1;
    }
}