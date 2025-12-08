namespace Projekat_biblioteka
{
    partial class FormIzmjenaBibliotekara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzmjenaBibliotekara));
            label2=new Label();
            textBoxIDBibliotekara=new TextBox();
            label1=new Label();
            textBoxIzmjenaPrezimeBibliotekara=new TextBox();
            textBoxIzmjenaImeBibliotekara=new TextBox();
            buttonIzmjenaBibliotekaraOdustani=new Button();
            buttonIzmjenaBibliotekaraPotvrdi=new Button();
            labelIzmjenaAutorPrezime=new Label();
            labelIzmjenaAutorIme=new Label();
            textBoxIzmjenaLozinkaBibliotekara=new TextBox();
            textBoxIzmjenaKorisnickoImeBibliotekara=new TextBox();
            label3=new Label();
            label4=new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.White;
            label2.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(90, 27);
            label2.Name="label2";
            label2.Size=new Size(270, 38);
            label2.TabIndex=72;
            label2.Text="Izmjena Bibliotekara";
            // 
            // textBoxIDBibliotekara
            // 
            textBoxIDBibliotekara.Location=new Point(203, 110);
            textBoxIDBibliotekara.Name="textBoxIDBibliotekara";
            textBoxIDBibliotekara.Size=new Size(202, 27);
            textBoxIDBibliotekara.TabIndex=71;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(44, 110);
            label1.Name="label1";
            label1.Size=new Size(148, 28);
            label1.TabIndex=70;
            label1.Text="ID Bibliotekara";
            // 
            // textBoxIzmjenaPrezimeBibliotekara
            // 
            textBoxIzmjenaPrezimeBibliotekara.Location=new Point(203, 210);
            textBoxIzmjenaPrezimeBibliotekara.Name="textBoxIzmjenaPrezimeBibliotekara";
            textBoxIzmjenaPrezimeBibliotekara.Size=new Size(202, 27);
            textBoxIzmjenaPrezimeBibliotekara.TabIndex=69;
            // 
            // textBoxIzmjenaImeBibliotekara
            // 
            textBoxIzmjenaImeBibliotekara.Location=new Point(203, 160);
            textBoxIzmjenaImeBibliotekara.Name="textBoxIzmjenaImeBibliotekara";
            textBoxIzmjenaImeBibliotekara.Size=new Size(202, 27);
            textBoxIzmjenaImeBibliotekara.TabIndex=68;
            // 
            // buttonIzmjenaBibliotekaraOdustani
            // 
            buttonIzmjenaBibliotekaraOdustani.BackColor=Color.FromArgb(255, 128, 128);
            buttonIzmjenaBibliotekaraOdustani.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIzmjenaBibliotekaraOdustani.Location=new Point(248, 371);
            buttonIzmjenaBibliotekaraOdustani.Name="buttonIzmjenaBibliotekaraOdustani";
            buttonIzmjenaBibliotekaraOdustani.Size=new Size(102, 40);
            buttonIzmjenaBibliotekaraOdustani.TabIndex=67;
            buttonIzmjenaBibliotekaraOdustani.Text="Odustani";
            buttonIzmjenaBibliotekaraOdustani.UseVisualStyleBackColor=false;
            buttonIzmjenaBibliotekaraOdustani.Click+=buttonIzmjenaBibliotekaraOdustani_Click;
            // 
            // buttonIzmjenaBibliotekaraPotvrdi
            // 
            buttonIzmjenaBibliotekaraPotvrdi.BackColor=Color.FromArgb(128, 255, 128);
            buttonIzmjenaBibliotekaraPotvrdi.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIzmjenaBibliotekaraPotvrdi.Location=new Point(89, 371);
            buttonIzmjenaBibliotekaraPotvrdi.Name="buttonIzmjenaBibliotekaraPotvrdi";
            buttonIzmjenaBibliotekaraPotvrdi.Size=new Size(101, 42);
            buttonIzmjenaBibliotekaraPotvrdi.TabIndex=66;
            buttonIzmjenaBibliotekaraPotvrdi.Text="Potvrdi";
            buttonIzmjenaBibliotekaraPotvrdi.UseVisualStyleBackColor=false;
            buttonIzmjenaBibliotekaraPotvrdi.Click+=buttonIzmjenaBibliotekaraPotvrdi_Click;
            // 
            // labelIzmjenaAutorPrezime
            // 
            labelIzmjenaAutorPrezime.AutoSize=true;
            labelIzmjenaAutorPrezime.BackColor=Color.White;
            labelIzmjenaAutorPrezime.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelIzmjenaAutorPrezime.Location=new Point(44, 210);
            labelIzmjenaAutorPrezime.Name="labelIzmjenaAutorPrezime";
            labelIzmjenaAutorPrezime.Size=new Size(91, 28);
            labelIzmjenaAutorPrezime.TabIndex=64;
            labelIzmjenaAutorPrezime.Text="Prezime ";
            // 
            // labelIzmjenaAutorIme
            // 
            labelIzmjenaAutorIme.AutoSize=true;
            labelIzmjenaAutorIme.BackColor=Color.White;
            labelIzmjenaAutorIme.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelIzmjenaAutorIme.Location=new Point(44, 160);
            labelIzmjenaAutorIme.Name="labelIzmjenaAutorIme";
            labelIzmjenaAutorIme.Size=new Size(52, 28);
            labelIzmjenaAutorIme.TabIndex=63;
            labelIzmjenaAutorIme.Text="Ime ";
            // 
            // textBoxIzmjenaLozinkaBibliotekara
            // 
            textBoxIzmjenaLozinkaBibliotekara.Location=new Point(203, 309);
            textBoxIzmjenaLozinkaBibliotekara.Name="textBoxIzmjenaLozinkaBibliotekara";
            textBoxIzmjenaLozinkaBibliotekara.Size=new Size(202, 27);
            textBoxIzmjenaLozinkaBibliotekara.TabIndex=76;
            // 
            // textBoxIzmjenaKorisnickoImeBibliotekara
            // 
            textBoxIzmjenaKorisnickoImeBibliotekara.Location=new Point(203, 259);
            textBoxIzmjenaKorisnickoImeBibliotekara.Name="textBoxIzmjenaKorisnickoImeBibliotekara";
            textBoxIzmjenaKorisnickoImeBibliotekara.Size=new Size(202, 27);
            textBoxIzmjenaKorisnickoImeBibliotekara.TabIndex=75;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.White;
            label3.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(44, 309);
            label3.Name="label3";
            label3.Size=new Size(81, 28);
            label3.TabIndex=74;
            label3.Text="Lozinka";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.White;
            label4.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(44, 259);
            label4.Name="label4";
            label4.Size=new Size(146, 28);
            label4.TabIndex=73;
            label4.Text="Korisničko Ime";
            // 
            // FormIzmjenaBibliotekara
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(461, 435);
            Controls.Add(textBoxIzmjenaLozinkaBibliotekara);
            Controls.Add(textBoxIzmjenaKorisnickoImeBibliotekara);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBoxIDBibliotekara);
            Controls.Add(label1);
            Controls.Add(textBoxIzmjenaPrezimeBibliotekara);
            Controls.Add(textBoxIzmjenaImeBibliotekara);
            Controls.Add(buttonIzmjenaBibliotekaraOdustani);
            Controls.Add(buttonIzmjenaBibliotekaraPotvrdi);
            Controls.Add(labelIzmjenaAutorPrezime);
            Controls.Add(labelIzmjenaAutorIme);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormIzmjenaBibliotekara";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormIzmjenaBibliotekara";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBoxIDBibliotekara;
        private Label label1;
        private TextBox textBoxIzmjenaPrezimeBibliotekara;
        private TextBox textBoxIzmjenaImeBibliotekara;
        private Button buttonIzmjenaBibliotekaraOdustani;
        private Button buttonIzmjenaBibliotekaraPotvrdi;
        private Label labelIzmjenaAutorPrezime;
        private Label labelIzmjenaAutorIme;
        private TextBox textBoxIzmjenaLozinkaBibliotekara;
        private TextBox textBoxIzmjenaKorisnickoImeBibliotekara;
        private Label label3;
        private Label label4;
    }
}