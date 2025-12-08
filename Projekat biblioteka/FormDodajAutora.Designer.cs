namespace Projekat_biblioteka
{
    partial class FormDodajAutora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajAutora));
            dateTimePickerDodajGodinaRodjenja=new DateTimePicker();
            label1=new Label();
            label4=new Label();
            textBoxDodajAutorPrezime=new TextBox();
            textBoxDodajImeAutora=new TextBox();
            buttonOdustaniDodajAutora=new Button();
            buttonDodajAutora=new Button();
            labelDodajGodinaRodjenja=new Label();
            labelDodajAutorPrezime=new Label();
            labelDodajAutorIme=new Label();
            SuspendLayout();
            // 
            // dateTimePickerDodajGodinaRodjenja
            // 
            dateTimePickerDodajGodinaRodjenja.Location=new Point(177, 218);
            dateTimePickerDodajGodinaRodjenja.Name="dateTimePickerDodajGodinaRodjenja";
            dateTimePickerDodajGodinaRodjenja.Size=new Size(242, 27);
            dateTimePickerDodajGodinaRodjenja.TabIndex=86;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Location=new Point(425, 223);
            label1.Name="label1";
            label1.Size=new Size(112, 20);
            label1.TabIndex=85;
            label1.Text="(nije obavezno)";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.White;
            label4.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(188, 33);
            label4.Name="label4";
            label4.Size=new Size(182, 38);
            label4.TabIndex=84;
            label4.Text="Dodaj Autora";
            // 
            // textBoxDodajAutorPrezime
            // 
            textBoxDodajAutorPrezime.Location=new Point(177, 168);
            textBoxDodajAutorPrezime.Name="textBoxDodajAutorPrezime";
            textBoxDodajAutorPrezime.Size=new Size(242, 27);
            textBoxDodajAutorPrezime.TabIndex=81;
            // 
            // textBoxDodajImeAutora
            // 
            textBoxDodajImeAutora.Location=new Point(177, 118);
            textBoxDodajImeAutora.Name="textBoxDodajImeAutora";
            textBoxDodajImeAutora.Size=new Size(242, 27);
            textBoxDodajImeAutora.TabIndex=80;
            // 
            // buttonOdustaniDodajAutora
            // 
            buttonOdustaniDodajAutora.BackColor=Color.FromArgb(255, 128, 128);
            buttonOdustaniDodajAutora.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdustaniDodajAutora.Location=new Point(295, 303);
            buttonOdustaniDodajAutora.Name="buttonOdustaniDodajAutora";
            buttonOdustaniDodajAutora.Size=new Size(102, 40);
            buttonOdustaniDodajAutora.TabIndex=79;
            buttonOdustaniDodajAutora.Text="Odustani";
            buttonOdustaniDodajAutora.UseVisualStyleBackColor=false;
            buttonOdustaniDodajAutora.Click+=buttonOdustaniDodajAutora_Click;
            // 
            // buttonDodajAutora
            // 
            buttonDodajAutora.BackColor=Color.FromArgb(128, 255, 128);
            buttonDodajAutora.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajAutora.Location=new Point(128, 302);
            buttonDodajAutora.Name="buttonDodajAutora";
            buttonDodajAutora.Size=new Size(101, 42);
            buttonDodajAutora.TabIndex=78;
            buttonDodajAutora.Text="Potvrdi";
            buttonDodajAutora.UseVisualStyleBackColor=false;
            buttonDodajAutora.Click+=buttonDodajAutora_Click;
            // 
            // labelDodajGodinaRodjenja
            // 
            labelDodajGodinaRodjenja.AutoSize=true;
            labelDodajGodinaRodjenja.BackColor=Color.White;
            labelDodajGodinaRodjenja.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDodajGodinaRodjenja.Location=new Point(18, 220);
            labelDodajGodinaRodjenja.Name="labelDodajGodinaRodjenja";
            labelDodajGodinaRodjenja.Size=new Size(157, 28);
            labelDodajGodinaRodjenja.TabIndex=77;
            labelDodajGodinaRodjenja.Text="Godina rođenja";
            // 
            // labelDodajAutorPrezime
            // 
            labelDodajAutorPrezime.AutoSize=true;
            labelDodajAutorPrezime.BackColor=Color.White;
            labelDodajAutorPrezime.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDodajAutorPrezime.Location=new Point(18, 168);
            labelDodajAutorPrezime.Name="labelDodajAutorPrezime";
            labelDodajAutorPrezime.Size=new Size(153, 28);
            labelDodajAutorPrezime.TabIndex=76;
            labelDodajAutorPrezime.Text="Prezime autora";
            // 
            // labelDodajAutorIme
            // 
            labelDodajAutorIme.AutoSize=true;
            labelDodajAutorIme.BackColor=Color.White;
            labelDodajAutorIme.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDodajAutorIme.Location=new Point(18, 118);
            labelDodajAutorIme.Name="labelDodajAutorIme";
            labelDodajAutorIme.Size=new Size(114, 28);
            labelDodajAutorIme.TabIndex=75;
            labelDodajAutorIme.Text="Ime autora";
            // 
            // FormDodajAutora
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(551, 387);
            Controls.Add(dateTimePickerDodajGodinaRodjenja);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBoxDodajAutorPrezime);
            Controls.Add(textBoxDodajImeAutora);
            Controls.Add(buttonOdustaniDodajAutora);
            Controls.Add(buttonDodajAutora);
            Controls.Add(labelDodajGodinaRodjenja);
            Controls.Add(labelDodajAutorPrezime);
            Controls.Add(labelDodajAutorIme);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormDodajAutora";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormDodajAutora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerDodajGodinaRodjenja;
        private Label label1;
        private Label label4;
        private TextBox textBoxDodajAutorPrezime;
        private TextBox textBoxDodajImeAutora;
        private Button buttonOdustaniDodajAutora;
        private Button buttonDodajAutora;
        private Label labelDodajGodinaRodjenja;
        private Label labelDodajAutorPrezime;
        private Label labelDodajAutorIme;
    }
}