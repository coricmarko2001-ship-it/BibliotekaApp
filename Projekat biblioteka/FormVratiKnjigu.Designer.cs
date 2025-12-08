namespace Projekat_biblioteka
{
    partial class FormVratiKnjigu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVratiKnjigu));
            buttonOdustaniVracanje=new Button();
            buttonPotvrdiVracanje=new Button();
            label4=new Label();
            labelBibliotekarVracanje=new Label();
            comboBoxBibliotekarVracanje=new ComboBox();
            comboBoxImeKorisnikaVracanje=new ComboBox();
            labelImeKorisnikaVracanje=new Label();
            comboBoxImeKnjigeVracanje=new ComboBox();
            labelImeKnjigeVracanje=new Label();
            SuspendLayout();
            // 
            // buttonOdustaniVracanje
            // 
            buttonOdustaniVracanje.BackColor=Color.FromArgb(255, 128, 128);
            buttonOdustaniVracanje.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdustaniVracanje.Location=new Point(382, 309);
            buttonOdustaniVracanje.Name="buttonOdustaniVracanje";
            buttonOdustaniVracanje.Size=new Size(102, 40);
            buttonOdustaniVracanje.TabIndex=88;
            buttonOdustaniVracanje.Text="Odustani";
            buttonOdustaniVracanje.UseVisualStyleBackColor=false;
            buttonOdustaniVracanje.Click+=buttonOdustaniVracanje_Click;
            // 
            // buttonPotvrdiVracanje
            // 
            buttonPotvrdiVracanje.BackColor=Color.FromArgb(128, 255, 128);
            buttonPotvrdiVracanje.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPotvrdiVracanje.Location=new Point(200, 309);
            buttonPotvrdiVracanje.Name="buttonPotvrdiVracanje";
            buttonPotvrdiVracanje.Size=new Size(101, 42);
            buttonPotvrdiVracanje.TabIndex=87;
            buttonPotvrdiVracanje.Text="Potvrdi";
            buttonPotvrdiVracanje.UseVisualStyleBackColor=false;
            buttonPotvrdiVracanje.Click+=buttonPotvrdiVracanje_Click;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.White;
            label4.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(262, 39);
            label4.Name="label4";
            label4.Size=new Size(180, 38);
            label4.TabIndex=86;
            label4.Text="Povrat Knjige";
            // 
            // labelBibliotekarVracanje
            // 
            labelBibliotekarVracanje.AutoSize=true;
            labelBibliotekarVracanje.BackColor=Color.White;
            labelBibliotekarVracanje.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBibliotekarVracanje.Location=new Point(102, 230);
            labelBibliotekarVracanje.Name="labelBibliotekarVracanje";
            labelBibliotekarVracanje.Size=new Size(112, 28);
            labelBibliotekarVracanje.TabIndex=81;
            labelBibliotekarVracanje.Text="Bibliotekar";
            // 
            // comboBoxBibliotekarVracanje
            // 
            comboBoxBibliotekarVracanje.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxBibliotekarVracanje.FormattingEnabled=true;
            comboBoxBibliotekarVracanje.Location=new Point(330, 230);
            comboBoxBibliotekarVracanje.Name="comboBoxBibliotekarVracanje";
            comboBoxBibliotekarVracanje.Size=new Size(250, 28);
            comboBoxBibliotekarVracanje.TabIndex=80;
            // 
            // comboBoxImeKorisnikaVracanje
            // 
            comboBoxImeKorisnikaVracanje.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxImeKorisnikaVracanje.FormattingEnabled=true;
            comboBoxImeKorisnikaVracanje.Location=new Point(330, 131);
            comboBoxImeKorisnikaVracanje.Name="comboBoxImeKorisnikaVracanje";
            comboBoxImeKorisnikaVracanje.Size=new Size(250, 28);
            comboBoxImeKorisnikaVracanje.TabIndex=79;
            // 
            // labelImeKorisnikaVracanje
            // 
            labelImeKorisnikaVracanje.AutoSize=true;
            labelImeKorisnikaVracanje.BackColor=Color.White;
            labelImeKorisnikaVracanje.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeKorisnikaVracanje.Location=new Point(102, 128);
            labelImeKorisnikaVracanje.Name="labelImeKorisnikaVracanje";
            labelImeKorisnikaVracanje.Size=new Size(222, 28);
            labelImeKorisnikaVracanje.TabIndex=78;
            labelImeKorisnikaVracanje.Text="Ime i prezime korisnika";
            // 
            // comboBoxImeKnjigeVracanje
            // 
            comboBoxImeKnjigeVracanje.DropDownStyle=ComboBoxStyle.DropDownList;
            comboBoxImeKnjigeVracanje.FormattingEnabled=true;
            comboBoxImeKnjigeVracanje.Location=new Point(330, 180);
            comboBoxImeKnjigeVracanje.Name="comboBoxImeKnjigeVracanje";
            comboBoxImeKnjigeVracanje.Size=new Size(250, 28);
            comboBoxImeKnjigeVracanje.TabIndex=77;
            // 
            // labelImeKnjigeVracanje
            // 
            labelImeKnjigeVracanje.AutoSize=true;
            labelImeKnjigeVracanje.BackColor=Color.White;
            labelImeKnjigeVracanje.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeKnjigeVracanje.Location=new Point(102, 180);
            labelImeKnjigeVracanje.Name="labelImeKnjigeVracanje";
            labelImeKnjigeVracanje.Size=new Size(107, 28);
            labelImeKnjigeVracanje.TabIndex=76;
            labelImeKnjigeVracanje.Text="Ime knjige";
            // 
            // FormVratiKnjigu
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(633, 414);
            Controls.Add(buttonOdustaniVracanje);
            Controls.Add(buttonPotvrdiVracanje);
            Controls.Add(label4);
            Controls.Add(labelBibliotekarVracanje);
            Controls.Add(comboBoxBibliotekarVracanje);
            Controls.Add(comboBoxImeKorisnikaVracanje);
            Controls.Add(labelImeKorisnikaVracanje);
            Controls.Add(comboBoxImeKnjigeVracanje);
            Controls.Add(labelImeKnjigeVracanje);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormVratiKnjigu";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormVratiKnjigu";
            Load+=FormVratiKnjigu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOdustaniVracanje;
        private Button buttonPotvrdiVracanje;
        private Label label4;
        private Label labelBibliotekarVracanje;
        private ComboBox comboBoxBibliotekarVracanje;
        private ComboBox comboBoxImeKorisnikaVracanje;
        private Label labelImeKorisnikaVracanje;
        private ComboBox comboBoxImeKnjigeVracanje;
        private Label labelImeKnjigeVracanje;
    }
}