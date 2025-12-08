namespace Projekat_biblioteka
{
    partial class FormIzmjenaAutora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzmjenaAutora));
            label4=new Label();
            textBoxIDAutora=new TextBox();
            label1=new Label();
            textBoxIzmjenaAutorPrezime=new TextBox();
            textBoxIzmjenaImeAutora=new TextBox();
            buttonRegistrujSeOdustani=new Button();
            buttonRegistrujSePotvrdi=new Button();
            labelIzmjenaGodinaRodjenja=new Label();
            labelIzmjenaAutorPrezime=new Label();
            labelIzmjenaAutorIme=new Label();
            label2=new Label();
            label3=new Label();
            dateTimePickerIzmjenaGodinaRodjenja=new DateTimePicker();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(275, -41);
            label4.Name="label4";
            label4.Size=new Size(234, 38);
            label4.TabIndex=59;
            label4.Text="Izmjena Korisnika";
            // 
            // textBoxIDAutora
            // 
            textBoxIDAutora.Location=new Point(226, 125);
            textBoxIDAutora.Name="textBoxIDAutora";
            textBoxIDAutora.Size=new Size(242, 27);
            textBoxIDAutora.TabIndex=58;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(67, 125);
            label1.Name="label1";
            label1.Size=new Size(101, 28);
            label1.TabIndex=57;
            label1.Text="ID Autora";
            // 
            // textBoxIzmjenaAutorPrezime
            // 
            textBoxIzmjenaAutorPrezime.Location=new Point(226, 225);
            textBoxIzmjenaAutorPrezime.Name="textBoxIzmjenaAutorPrezime";
            textBoxIzmjenaAutorPrezime.Size=new Size(242, 27);
            textBoxIzmjenaAutorPrezime.TabIndex=49;
            // 
            // textBoxIzmjenaImeAutora
            // 
            textBoxIzmjenaImeAutora.Location=new Point(226, 175);
            textBoxIzmjenaImeAutora.Name="textBoxIzmjenaImeAutora";
            textBoxIzmjenaImeAutora.Size=new Size(242, 27);
            textBoxIzmjenaImeAutora.TabIndex=48;
            // 
            // buttonRegistrujSeOdustani
            // 
            buttonRegistrujSeOdustani.BackColor=Color.FromArgb(255, 128, 128);
            buttonRegistrujSeOdustani.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrujSeOdustani.Location=new Point(353, 367);
            buttonRegistrujSeOdustani.Name="buttonRegistrujSeOdustani";
            buttonRegistrujSeOdustani.Size=new Size(102, 40);
            buttonRegistrujSeOdustani.TabIndex=47;
            buttonRegistrujSeOdustani.Text="Odustani";
            buttonRegistrujSeOdustani.UseVisualStyleBackColor=false;
            buttonRegistrujSeOdustani.Click+=buttonRegistrujSeOdustani_Click;
            // 
            // buttonRegistrujSePotvrdi
            // 
            buttonRegistrujSePotvrdi.BackColor=Color.FromArgb(128, 255, 128);
            buttonRegistrujSePotvrdi.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrujSePotvrdi.Location=new Point(179, 365);
            buttonRegistrujSePotvrdi.Name="buttonRegistrujSePotvrdi";
            buttonRegistrujSePotvrdi.Size=new Size(101, 42);
            buttonRegistrujSePotvrdi.TabIndex=46;
            buttonRegistrujSePotvrdi.Text="Potvrdi";
            buttonRegistrujSePotvrdi.UseVisualStyleBackColor=false;
            buttonRegistrujSePotvrdi.Click+=buttonRegistrujSePotvrdi_Click;
            // 
            // labelIzmjenaGodinaRodjenja
            // 
            labelIzmjenaGodinaRodjenja.AutoSize=true;
            labelIzmjenaGodinaRodjenja.BackColor=Color.White;
            labelIzmjenaGodinaRodjenja.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelIzmjenaGodinaRodjenja.Location=new Point(67, 277);
            labelIzmjenaGodinaRodjenja.Name="labelIzmjenaGodinaRodjenja";
            labelIzmjenaGodinaRodjenja.Size=new Size(157, 28);
            labelIzmjenaGodinaRodjenja.TabIndex=43;
            labelIzmjenaGodinaRodjenja.Text="Godina rođenja";
            // 
            // labelIzmjenaAutorPrezime
            // 
            labelIzmjenaAutorPrezime.AutoSize=true;
            labelIzmjenaAutorPrezime.BackColor=Color.White;
            labelIzmjenaAutorPrezime.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelIzmjenaAutorPrezime.Location=new Point(67, 225);
            labelIzmjenaAutorPrezime.Name="labelIzmjenaAutorPrezime";
            labelIzmjenaAutorPrezime.Size=new Size(153, 28);
            labelIzmjenaAutorPrezime.TabIndex=42;
            labelIzmjenaAutorPrezime.Text="Prezime autora";
            // 
            // labelIzmjenaAutorIme
            // 
            labelIzmjenaAutorIme.AutoSize=true;
            labelIzmjenaAutorIme.BackColor=Color.White;
            labelIzmjenaAutorIme.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelIzmjenaAutorIme.Location=new Point(67, 175);
            labelIzmjenaAutorIme.Name="labelIzmjenaAutorIme";
            labelIzmjenaAutorIme.Size=new Size(114, 28);
            labelIzmjenaAutorIme.TabIndex=41;
            labelIzmjenaAutorIme.Text="Ime autora";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.White;
            label2.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(207, 38);
            label2.Name="label2";
            label2.Size=new Size(207, 38);
            label2.TabIndex=60;
            label2.Text="Izmjena Autora";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.White;
            label3.Location=new Point(474, 280);
            label3.Name="label3";
            label3.Size=new Size(112, 20);
            label3.TabIndex=61;
            label3.Text="(nije obavezno)";
            // 
            // dateTimePickerIzmjenaGodinaRodjenja
            // 
            dateTimePickerIzmjenaGodinaRodjenja.Location=new Point(226, 275);
            dateTimePickerIzmjenaGodinaRodjenja.Name="dateTimePickerIzmjenaGodinaRodjenja";
            dateTimePickerIzmjenaGodinaRodjenja.Size=new Size(242, 27);
            dateTimePickerIzmjenaGodinaRodjenja.TabIndex=62;
            // 
            // FormIzmjenaAutora
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(609, 461);
            Controls.Add(dateTimePickerIzmjenaGodinaRodjenja);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBoxIDAutora);
            Controls.Add(label1);
            Controls.Add(textBoxIzmjenaAutorPrezime);
            Controls.Add(textBoxIzmjenaImeAutora);
            Controls.Add(buttonRegistrujSeOdustani);
            Controls.Add(buttonRegistrujSePotvrdi);
            Controls.Add(labelIzmjenaGodinaRodjenja);
            Controls.Add(labelIzmjenaAutorPrezime);
            Controls.Add(labelIzmjenaAutorIme);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormIzmjenaAutora";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormIzmjenaAutora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBoxIDAutora;
        private Label label1;
        private TextBox textBoxIzmjenaAutorPrezime;
        private TextBox textBoxIzmjenaImeAutora;
        private Button buttonRegistrujSeOdustani;
        private Button buttonRegistrujSePotvrdi;
        private Label labelIzmjenaGodinaRodjenja;
        private Label labelIzmjenaAutorPrezime;
        private Label labelIzmjenaAutorIme;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerIzmjenaGodinaRodjenja;
    }
}