namespace Projekat_biblioteka
{
    partial class FormIzdajKnjigu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzdajKnjigu));
            labelBibliotekarIzdavanje=new Label();
            comboBoxBibliotekarIzdavanje=new ComboBox();
            comboBoxImeKorisnikaIzdavanje=new ComboBox();
            labelImeKorisnikaIzdavanje=new Label();
            comboBoxImeKnjigeIzdavanje=new ComboBox();
            labelImeKnjigeIzdavanje=new Label();
            labelDatumVracanja=new Label();
            labelDatumIzdavanja=new Label();
            dateTimePickerDatumIzdavanja=new DateTimePicker();
            dateTimePickerDatumVracanja=new DateTimePicker();
            label4=new Label();
            buttonOdustaniIzdavanje=new Button();
            buttonIznajmiIzdavanje=new Button();
            SuspendLayout();
            // 
            // labelBibliotekarIzdavanje
            // 
            labelBibliotekarIzdavanje.AutoSize=true;
            labelBibliotekarIzdavanje.BackColor=Color.White;
            labelBibliotekarIzdavanje.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBibliotekarIzdavanje.Location=new Point(55, 226);
            labelBibliotekarIzdavanje.Name="labelBibliotekarIzdavanje";
            labelBibliotekarIzdavanje.Size=new Size(112, 28);
            labelBibliotekarIzdavanje.TabIndex=68;
            labelBibliotekarIzdavanje.Text="Bibliotekar";
            // 
            // comboBoxBibliotekarIzdavanje
            // 
            comboBoxBibliotekarIzdavanje.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxBibliotekarIzdavanje.FormattingEnabled=true;
            comboBoxBibliotekarIzdavanje.Location=new Point(283, 226);
            comboBoxBibliotekarIzdavanje.Name="comboBoxBibliotekarIzdavanje";
            comboBoxBibliotekarIzdavanje.Size=new Size(250, 28);
            comboBoxBibliotekarIzdavanje.TabIndex=67;
            // 
            // comboBoxImeKorisnikaIzdavanje
            // 
            comboBoxImeKorisnikaIzdavanje.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxImeKorisnikaIzdavanje.FormattingEnabled=true;
            comboBoxImeKorisnikaIzdavanje.Location=new Point(283, 127);
            comboBoxImeKorisnikaIzdavanje.Name="comboBoxImeKorisnikaIzdavanje";
            comboBoxImeKorisnikaIzdavanje.Size=new Size(250, 28);
            comboBoxImeKorisnikaIzdavanje.TabIndex=66;
            // 
            // labelImeKorisnikaIzdavanje
            // 
            labelImeKorisnikaIzdavanje.AutoSize=true;
            labelImeKorisnikaIzdavanje.BackColor=Color.White;
            labelImeKorisnikaIzdavanje.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeKorisnikaIzdavanje.Location=new Point(55, 124);
            labelImeKorisnikaIzdavanje.Name="labelImeKorisnikaIzdavanje";
            labelImeKorisnikaIzdavanje.Size=new Size(222, 28);
            labelImeKorisnikaIzdavanje.TabIndex=65;
            labelImeKorisnikaIzdavanje.Text="Ime i prezime korisnika";
            // 
            // comboBoxImeKnjigeIzdavanje
            // 
            comboBoxImeKnjigeIzdavanje.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxImeKnjigeIzdavanje.FormattingEnabled=true;
            comboBoxImeKnjigeIzdavanje.Location=new Point(283, 176);
            comboBoxImeKnjigeIzdavanje.Name="comboBoxImeKnjigeIzdavanje";
            comboBoxImeKnjigeIzdavanje.Size=new Size(250, 28);
            comboBoxImeKnjigeIzdavanje.TabIndex=64;
            // 
            // labelImeKnjigeIzdavanje
            // 
            labelImeKnjigeIzdavanje.AutoSize=true;
            labelImeKnjigeIzdavanje.BackColor=Color.White;
            labelImeKnjigeIzdavanje.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeKnjigeIzdavanje.Location=new Point(55, 176);
            labelImeKnjigeIzdavanje.Name="labelImeKnjigeIzdavanje";
            labelImeKnjigeIzdavanje.Size=new Size(107, 28);
            labelImeKnjigeIzdavanje.TabIndex=63;
            labelImeKnjigeIzdavanje.Text="Ime knjige";
            // 
            // labelDatumVracanja
            // 
            labelDatumVracanja.AutoSize=true;
            labelDatumVracanja.BackColor=Color.White;
            labelDatumVracanja.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatumVracanja.Location=new Point(55, 326);
            labelDatumVracanja.Name="labelDatumVracanja";
            labelDatumVracanja.Size=new Size(159, 28);
            labelDatumVracanja.TabIndex=70;
            labelDatumVracanja.Text="Datum vraćanja";
            // 
            // labelDatumIzdavanja
            // 
            labelDatumIzdavanja.AutoSize=true;
            labelDatumIzdavanja.BackColor=Color.White;
            labelDatumIzdavanja.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatumIzdavanja.Location=new Point(55, 276);
            labelDatumIzdavanja.Name="labelDatumIzdavanja";
            labelDatumIzdavanja.Size=new Size(166, 28);
            labelDatumIzdavanja.TabIndex=69;
            labelDatumIzdavanja.Text="Datum izdavanja";
            // 
            // dateTimePickerDatumIzdavanja
            // 
            dateTimePickerDatumIzdavanja.Location=new Point(283, 277);
            dateTimePickerDatumIzdavanja.Name="dateTimePickerDatumIzdavanja";
            dateTimePickerDatumIzdavanja.Size=new Size(250, 27);
            dateTimePickerDatumIzdavanja.TabIndex=71;
            // 
            // dateTimePickerDatumVracanja
            // 
            dateTimePickerDatumVracanja.Location=new Point(283, 327);
            dateTimePickerDatumVracanja.Name="dateTimePickerDatumVracanja";
            dateTimePickerDatumVracanja.Size=new Size(250, 27);
            dateTimePickerDatumVracanja.TabIndex=72;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.White;
            label4.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(183, 36);
            label4.Name="label4";
            label4.Size=new Size(216, 38);
            label4.TabIndex=73;
            label4.Text="Izdavanje Knjige";
            // 
            // buttonOdustaniIzdavanje
            // 
            buttonOdustaniIzdavanje.BackColor=Color.FromArgb(255, 128, 128);
            buttonOdustaniIzdavanje.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdustaniIzdavanje.Location=new Point(330, 411);
            buttonOdustaniIzdavanje.Name="buttonOdustaniIzdavanje";
            buttonOdustaniIzdavanje.Size=new Size(102, 40);
            buttonOdustaniIzdavanje.TabIndex=75;
            buttonOdustaniIzdavanje.Text="Odustani";
            buttonOdustaniIzdavanje.UseVisualStyleBackColor=false;
            buttonOdustaniIzdavanje.Click+=buttonOdustaniIzdavanje_Click;
            // 
            // buttonIznajmiIzdavanje
            // 
            buttonIznajmiIzdavanje.BackColor=Color.FromArgb(128, 255, 128);
            buttonIznajmiIzdavanje.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIznajmiIzdavanje.Location=new Point(148, 411);
            buttonIznajmiIzdavanje.Name="buttonIznajmiIzdavanje";
            buttonIznajmiIzdavanje.Size=new Size(101, 42);
            buttonIznajmiIzdavanje.TabIndex=74;
            buttonIznajmiIzdavanje.Text="Iznajmi";
            buttonIznajmiIzdavanje.UseVisualStyleBackColor=false;
            buttonIznajmiIzdavanje.Click+=buttonIznajmiIzdavanje_Click;
            // 
            // FormIzdajKnjigu
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(586, 502);
            Controls.Add(buttonOdustaniIzdavanje);
            Controls.Add(buttonIznajmiIzdavanje);
            Controls.Add(label4);
            Controls.Add(dateTimePickerDatumVracanja);
            Controls.Add(dateTimePickerDatumIzdavanja);
            Controls.Add(labelDatumVracanja);
            Controls.Add(labelDatumIzdavanja);
            Controls.Add(labelBibliotekarIzdavanje);
            Controls.Add(comboBoxBibliotekarIzdavanje);
            Controls.Add(comboBoxImeKorisnikaIzdavanje);
            Controls.Add(labelImeKorisnikaIzdavanje);
            Controls.Add(comboBoxImeKnjigeIzdavanje);
            Controls.Add(labelImeKnjigeIzdavanje);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormIzdajKnjigu";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormIzdajKnjigu";
            Load+=FormIzdajKnjigu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBibliotekarIzdavanje;
        private ComboBox comboBoxBibliotekarIzdavanje;
        private ComboBox comboBoxImeKorisnikaIzdavanje;
        private Label labelImeKorisnikaIzdavanje;
        private ComboBox comboBoxImeKnjigeIzdavanje;
        private Label labelImeKnjigeIzdavanje;
        private Label labelDatumVracanja;
        private Label labelDatumIzdavanja;
        private DateTimePicker dateTimePickerDatumIzdavanja;
        private DateTimePicker dateTimePickerDatumVracanja;
        private Label label4;
        private Button buttonOdustaniIzdavanje;
        private Button buttonIznajmiIzdavanje;
    }
}