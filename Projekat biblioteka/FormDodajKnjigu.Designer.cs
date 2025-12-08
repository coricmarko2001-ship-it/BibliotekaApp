namespace Projekat_biblioteka
{
    partial class FormDodajKnjigu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajKnjigu));
            labelNazivKnjige=new Label();
            labelImeAutora=new Label();
            labelZanr=new Label();
            labelIzdavac=new Label();
            labelGodinaIzdanja=new Label();
            textBoxNazivKnjige=new TextBox();
            dateTimePickerGodinaIzdanja=new DateTimePicker();
            buttonDodajKnjiguPotvrdi=new Button();
            buttonDodajKnjiguOdustani=new Button();
            labelUkupanBrojKnjiga=new Label();
            labelBrojDostupnihKnjiga=new Label();
            textBoxUkupanBrojKnjiga=new TextBox();
            textBoxBrojDostupnihKnjiga=new TextBox();
            buttonDodajZanrKnjiga=new Button();
            comboBoxDodajZanrKnjiga=new ComboBox();
            buttonDodajIzdavacaKnjiga=new Button();
            comboBoxDodajIzdavacaKnjiga=new ComboBox();
            buttonDodajAutoraKnjiga=new Button();
            comboBoxDodajAutoraKnjiga=new ComboBox();
            label2=new Label();
            SuspendLayout();
            // 
            // labelNazivKnjige
            // 
            labelNazivKnjige.AutoSize=true;
            labelNazivKnjige.BackColor=Color.White;
            labelNazivKnjige.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNazivKnjige.Location=new Point(63, 140);
            labelNazivKnjige.Name="labelNazivKnjige";
            labelNazivKnjige.Size=new Size(124, 28);
            labelNazivKnjige.TabIndex=0;
            labelNazivKnjige.Text="Naziv Knjige";
            // 
            // labelImeAutora
            // 
            labelImeAutora.AutoSize=true;
            labelImeAutora.BackColor=Color.White;
            labelImeAutora.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeAutora.Location=new Point(63, 190);
            labelImeAutora.Name="labelImeAutora";
            labelImeAutora.Size=new Size(116, 28);
            labelImeAutora.TabIndex=1;
            labelImeAutora.Text="Ime Autora";
            // 
            // labelZanr
            // 
            labelZanr.AutoSize=true;
            labelZanr.BackColor=Color.White;
            labelZanr.Font=new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelZanr.Location=new Point(63, 240);
            labelZanr.Name="labelZanr";
            labelZanr.Size=new Size(57, 29);
            labelZanr.TabIndex=3;
            labelZanr.Text="Žanr";
            // 
            // labelIzdavac
            // 
            labelIzdavac.AutoSize=true;
            labelIzdavac.BackColor=Color.White;
            labelIzdavac.Font=new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelIzdavac.Location=new Point(63, 290);
            labelIzdavac.Name="labelIzdavac";
            labelIzdavac.Size=new Size(85, 29);
            labelIzdavac.TabIndex=4;
            labelIzdavac.Text="Izdavač";
            // 
            // labelGodinaIzdanja
            // 
            labelGodinaIzdanja.AutoSize=true;
            labelGodinaIzdanja.BackColor=Color.White;
            labelGodinaIzdanja.Font=new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelGodinaIzdanja.Location=new Point(63, 340);
            labelGodinaIzdanja.Name="labelGodinaIzdanja";
            labelGodinaIzdanja.Size=new Size(160, 29);
            labelGodinaIzdanja.TabIndex=5;
            labelGodinaIzdanja.Text="Godina Izdanja";
            // 
            // textBoxNazivKnjige
            // 
            textBoxNazivKnjige.Location=new Point(301, 143);
            textBoxNazivKnjige.Name="textBoxNazivKnjige";
            textBoxNazivKnjige.Size=new Size(250, 27);
            textBoxNazivKnjige.TabIndex=9;
            // 
            // dateTimePickerGodinaIzdanja
            // 
            dateTimePickerGodinaIzdanja.Location=new Point(301, 341);
            dateTimePickerGodinaIzdanja.Name="dateTimePickerGodinaIzdanja";
            dateTimePickerGodinaIzdanja.Size=new Size(250, 27);
            dateTimePickerGodinaIzdanja.TabIndex=13;
            // 
            // buttonDodajKnjiguPotvrdi
            // 
            buttonDodajKnjiguPotvrdi.BackColor=Color.FromArgb(128, 255, 128);
            buttonDodajKnjiguPotvrdi.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajKnjiguPotvrdi.Location=new Point(222, 524);
            buttonDodajKnjiguPotvrdi.Name="buttonDodajKnjiguPotvrdi";
            buttonDodajKnjiguPotvrdi.Size=new Size(106, 38);
            buttonDodajKnjiguPotvrdi.TabIndex=14;
            buttonDodajKnjiguPotvrdi.Text="Potvrdi";
            buttonDodajKnjiguPotvrdi.UseVisualStyleBackColor=false;
            buttonDodajKnjiguPotvrdi.Click+=buttonDodajKnjiguPotvrdi_Click;
            // 
            // buttonDodajKnjiguOdustani
            // 
            buttonDodajKnjiguOdustani.BackColor=Color.FromArgb(255, 128, 128);
            buttonDodajKnjiguOdustani.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajKnjiguOdustani.Location=new Point(409, 524);
            buttonDodajKnjiguOdustani.Name="buttonDodajKnjiguOdustani";
            buttonDodajKnjiguOdustani.Size=new Size(108, 38);
            buttonDodajKnjiguOdustani.TabIndex=15;
            buttonDodajKnjiguOdustani.Text="Odustani";
            buttonDodajKnjiguOdustani.UseVisualStyleBackColor=false;
            buttonDodajKnjiguOdustani.Click+=buttonDodajKnjiguOdustani_Click;
            // 
            // labelUkupanBrojKnjiga
            // 
            labelUkupanBrojKnjiga.AutoSize=true;
            labelUkupanBrojKnjiga.BackColor=Color.White;
            labelUkupanBrojKnjiga.Font=new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelUkupanBrojKnjiga.Location=new Point(63, 392);
            labelUkupanBrojKnjiga.Name="labelUkupanBrojKnjiga";
            labelUkupanBrojKnjiga.Size=new Size(199, 29);
            labelUkupanBrojKnjiga.TabIndex=16;
            labelUkupanBrojKnjiga.Text="Ukupan broj knjiga";
            // 
            // labelBrojDostupnihKnjiga
            // 
            labelBrojDostupnihKnjiga.AutoSize=true;
            labelBrojDostupnihKnjiga.BackColor=Color.White;
            labelBrojDostupnihKnjiga.Font=new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelBrojDostupnihKnjiga.Location=new Point(63, 439);
            labelBrojDostupnihKnjiga.Name="labelBrojDostupnihKnjiga";
            labelBrojDostupnihKnjiga.Size=new Size(223, 29);
            labelBrojDostupnihKnjiga.TabIndex=17;
            labelBrojDostupnihKnjiga.Text="Broj dostupnih knjiga";
            // 
            // textBoxUkupanBrojKnjiga
            // 
            textBoxUkupanBrojKnjiga.Location=new Point(301, 395);
            textBoxUkupanBrojKnjiga.Name="textBoxUkupanBrojKnjiga";
            textBoxUkupanBrojKnjiga.Size=new Size(250, 27);
            textBoxUkupanBrojKnjiga.TabIndex=18;
            // 
            // textBoxBrojDostupnihKnjiga
            // 
            textBoxBrojDostupnihKnjiga.Location=new Point(301, 442);
            textBoxBrojDostupnihKnjiga.Name="textBoxBrojDostupnihKnjiga";
            textBoxBrojDostupnihKnjiga.Size=new Size(250, 27);
            textBoxBrojDostupnihKnjiga.TabIndex=19;
            // 
            // buttonDodajZanrKnjiga
            // 
            buttonDodajZanrKnjiga.Location=new Point(572, 240);
            buttonDodajZanrKnjiga.Name="buttonDodajZanrKnjiga";
            buttonDodajZanrKnjiga.Size=new Size(133, 29);
            buttonDodajZanrKnjiga.TabIndex=21;
            buttonDodajZanrKnjiga.Text="Dodaj Žanr";
            buttonDodajZanrKnjiga.UseVisualStyleBackColor=true;
            buttonDodajZanrKnjiga.Click+=buttonDodajZanrKnjiga_Click;
            // 
            // comboBoxDodajZanrKnjiga
            // 
            comboBoxDodajZanrKnjiga.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxDodajZanrKnjiga.FormattingEnabled=true;
            comboBoxDodajZanrKnjiga.Location=new Point(301, 241);
            comboBoxDodajZanrKnjiga.Name="comboBoxDodajZanrKnjiga";
            comboBoxDodajZanrKnjiga.Size=new Size(250, 28);
            comboBoxDodajZanrKnjiga.TabIndex=20;
            // 
            // buttonDodajIzdavacaKnjiga
            // 
            buttonDodajIzdavacaKnjiga.Location=new Point(571, 290);
            buttonDodajIzdavacaKnjiga.Name="buttonDodajIzdavacaKnjiga";
            buttonDodajIzdavacaKnjiga.Size=new Size(134, 29);
            buttonDodajIzdavacaKnjiga.TabIndex=23;
            buttonDodajIzdavacaKnjiga.Text="Dodaj Izdavača";
            buttonDodajIzdavacaKnjiga.UseVisualStyleBackColor=true;
            buttonDodajIzdavacaKnjiga.Click+=buttonDodajIzdavacaKnjiga_Click;
            // 
            // comboBoxDodajIzdavacaKnjiga
            // 
            comboBoxDodajIzdavacaKnjiga.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxDodajIzdavacaKnjiga.FormattingEnabled=true;
            comboBoxDodajIzdavacaKnjiga.Location=new Point(301, 293);
            comboBoxDodajIzdavacaKnjiga.Name="comboBoxDodajIzdavacaKnjiga";
            comboBoxDodajIzdavacaKnjiga.Size=new Size(250, 28);
            comboBoxDodajIzdavacaKnjiga.TabIndex=22;
            // 
            // buttonDodajAutoraKnjiga
            // 
            buttonDodajAutoraKnjiga.Location=new Point(571, 192);
            buttonDodajAutoraKnjiga.Name="buttonDodajAutoraKnjiga";
            buttonDodajAutoraKnjiga.Size=new Size(134, 29);
            buttonDodajAutoraKnjiga.TabIndex=25;
            buttonDodajAutoraKnjiga.Text="Dodaj Autora";
            buttonDodajAutoraKnjiga.UseVisualStyleBackColor=true;
            buttonDodajAutoraKnjiga.Click+=buttonDodajAutoraKnjiga_Click;
            // 
            // comboBoxDodajAutoraKnjiga
            // 
            comboBoxDodajAutoraKnjiga.FormattingEnabled=true;
            comboBoxDodajAutoraKnjiga.Location=new Point(300, 193);
            comboBoxDodajAutoraKnjiga.Name="comboBoxDodajAutoraKnjiga";
            comboBoxDodajAutoraKnjiga.Size=new Size(250, 28);
            comboBoxDodajAutoraKnjiga.TabIndex=24;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.White;
            label2.Font=new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(241, 42);
            label2.Name="label2";
            label2.Size=new Size(192, 41);
            label2.TabIndex=27;
            label2.Text="Dodaj Knjigu";
            // 
            // FormDodajKnjigu
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(723, 596);
            ControlBox=false;
            Controls.Add(label2);
            Controls.Add(buttonDodajAutoraKnjiga);
            Controls.Add(comboBoxDodajAutoraKnjiga);
            Controls.Add(buttonDodajIzdavacaKnjiga);
            Controls.Add(comboBoxDodajIzdavacaKnjiga);
            Controls.Add(buttonDodajZanrKnjiga);
            Controls.Add(comboBoxDodajZanrKnjiga);
            Controls.Add(textBoxBrojDostupnihKnjiga);
            Controls.Add(textBoxUkupanBrojKnjiga);
            Controls.Add(labelBrojDostupnihKnjiga);
            Controls.Add(labelUkupanBrojKnjiga);
            Controls.Add(buttonDodajKnjiguOdustani);
            Controls.Add(buttonDodajKnjiguPotvrdi);
            Controls.Add(dateTimePickerGodinaIzdanja);
            Controls.Add(textBoxNazivKnjige);
            Controls.Add(labelGodinaIzdanja);
            Controls.Add(labelIzdavac);
            Controls.Add(labelZanr);
            Controls.Add(labelImeAutora);
            Controls.Add(labelNazivKnjige);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormDodajKnjigu";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormDodajKnjigu";
            Load+=FormDodajKnjigu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNazivKnjige;
        private Label labelImeAutora;
        private Label labelZanr;
        private Label labelIzdavac;
        private Label labelGodinaIzdanja;
        private TextBox textBoxNazivKnjige;
        private TextBox textBoxZanr;
        private DateTimePicker dateTimePickerGodinaIzdanja;
        private Button buttonDodajKnjiguPotvrdi;
        private Button buttonDodajKnjiguOdustani;
        private Label labelUkupanBrojKnjiga;
        private Label labelBrojDostupnihKnjiga;
        private TextBox textBoxUkupanBrojKnjiga;
        private TextBox textBoxBrojDostupnihKnjiga;
        private Button buttonDodajZanrKnjiga;
        private ComboBox comboBoxDodajZanrKnjiga;
        private Button buttonDodajIzdavacaKnjiga;
        private ComboBox comboBoxDodajIzdavacaKnjiga;
        private Button buttonDodajAutoraKnjiga;
        private ComboBox comboBoxDodajAutoraKnjiga;
        private Label label2;
    }
}