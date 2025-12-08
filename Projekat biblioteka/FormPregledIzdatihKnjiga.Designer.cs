namespace Projekat_biblioteka
{
    partial class FormPregledIzdatihKnjiga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledIzdatihKnjiga));
            buttonIzmijeniIznajmljivanje=new Button();
            buttonObrisiiznajmljivanje=new Button();
            buttonOsvjeziPregledAutora=new Button();
            buttonIzadjiiznajmljivanje=new Button();
            textBoxPregledPoImenuKorisnika=new TextBox();
            labelImeKorisnika=new Label();
            labelPregledIzdatihKnjiga=new Label();
            dataGridViewPregledIzdatihKnjiga=new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledIzdatihKnjiga).BeginInit();
            SuspendLayout();
            // 
            // buttonIzmijeniIznajmljivanje
            // 
            buttonIzmijeniIznajmljivanje.Location=new Point(399, 541);
            buttonIzmijeniIznajmljivanje.Name="buttonIzmijeniIznajmljivanje";
            buttonIzmijeniIznajmljivanje.Size=new Size(94, 29);
            buttonIzmijeniIznajmljivanje.TabIndex=26;
            buttonIzmijeniIznajmljivanje.Text="Izmijeni";
            buttonIzmijeniIznajmljivanje.UseVisualStyleBackColor=true;
            buttonIzmijeniIznajmljivanje.Click+=buttonIzmijeniIznajmljivanje_Click;
            // 
            // buttonObrisiiznajmljivanje
            // 
            buttonObrisiiznajmljivanje.Location=new Point(688, 541);
            buttonObrisiiznajmljivanje.Name="buttonObrisiiznajmljivanje";
            buttonObrisiiznajmljivanje.Size=new Size(94, 29);
            buttonObrisiiznajmljivanje.TabIndex=25;
            buttonObrisiiznajmljivanje.Text="Obriši";
            buttonObrisiiznajmljivanje.UseVisualStyleBackColor=true;
            buttonObrisiiznajmljivanje.Click+=buttonObrisiiznajmljivanje_Click;
            // 
            // buttonOsvjeziPregledAutora
            // 
            buttonOsvjeziPregledAutora.Location=new Point(98, 541);
            buttonOsvjeziPregledAutora.Name="buttonOsvjeziPregledAutora";
            buttonOsvjeziPregledAutora.Size=new Size(70, 29);
            buttonOsvjeziPregledAutora.TabIndex=24;
            buttonOsvjeziPregledAutora.Text="Osvježi";
            buttonOsvjeziPregledAutora.UseVisualStyleBackColor=true;
            // 
            // buttonIzadjiiznajmljivanje
            // 
            buttonIzadjiiznajmljivanje.Location=new Point(957, 541);
            buttonIzadjiiznajmljivanje.Name="buttonIzadjiiznajmljivanje";
            buttonIzadjiiznajmljivanje.Size=new Size(94, 29);
            buttonIzadjiiznajmljivanje.TabIndex=22;
            buttonIzadjiiznajmljivanje.Text="Izađi";
            buttonIzadjiiznajmljivanje.UseVisualStyleBackColor=true;
            buttonIzadjiiznajmljivanje.Click+=buttonIzadjiiznajmljivanje_Click;
            // 
            // textBoxPregledPoImenuKorisnika
            // 
            textBoxPregledPoImenuKorisnika.Location=new Point(575, 116);
            textBoxPregledPoImenuKorisnika.Name="textBoxPregledPoImenuKorisnika";
            textBoxPregledPoImenuKorisnika.Size=new Size(242, 27);
            textBoxPregledPoImenuKorisnika.TabIndex=21;
            textBoxPregledPoImenuKorisnika.TextChanged+=textBoxPregledPoImenuKorisnika_TextChanged;
            // 
            // labelImeKorisnika
            // 
            labelImeKorisnika.AutoSize=true;
            labelImeKorisnika.BackColor=Color.White;
            labelImeKorisnika.Font=new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeKorisnika.Location=new Point(405, 109);
            labelImeKorisnika.Name="labelImeKorisnika";
            labelImeKorisnika.Size=new Size(167, 35);
            labelImeKorisnika.TabIndex=20;
            labelImeKorisnika.Text="Ime Korisnika";
            // 
            // labelPregledIzdatihKnjiga
            // 
            labelPregledIzdatihKnjiga.AutoSize=true;
            labelPregledIzdatihKnjiga.BackColor=Color.White;
            labelPregledIzdatihKnjiga.Font=new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPregledIzdatihKnjiga.Location=new Point(446, 25);
            labelPregledIzdatihKnjiga.Name="labelPregledIzdatihKnjiga";
            labelPregledIzdatihKnjiga.Size=new Size(336, 45);
            labelPregledIzdatihKnjiga.TabIndex=19;
            labelPregledIzdatihKnjiga.Text="Pregled Izdatih Knjiga";
            // 
            // dataGridViewPregledIzdatihKnjiga
            // 
            dataGridViewPregledIzdatihKnjiga.BackgroundColor=Color.White;
            dataGridViewPregledIzdatihKnjiga.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPregledIzdatihKnjiga.Location=new Point(98, 182);
            dataGridViewPregledIzdatihKnjiga.Name="dataGridViewPregledIzdatihKnjiga";
            dataGridViewPregledIzdatihKnjiga.RowHeadersWidth=51;
            dataGridViewPregledIzdatihKnjiga.RowTemplate.Height=29;
            dataGridViewPregledIzdatihKnjiga.Size=new Size(972, 341);
            dataGridViewPregledIzdatihKnjiga.TabIndex=18;
            // 
            // FormPregledIzdatihKnjiga
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(1173, 596);
            Controls.Add(buttonIzmijeniIznajmljivanje);
            Controls.Add(buttonObrisiiznajmljivanje);
            Controls.Add(buttonOsvjeziPregledAutora);
            Controls.Add(buttonIzadjiiznajmljivanje);
            Controls.Add(textBoxPregledPoImenuKorisnika);
            Controls.Add(labelImeKorisnika);
            Controls.Add(labelPregledIzdatihKnjiga);
            Controls.Add(dataGridViewPregledIzdatihKnjiga);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormPregledIzdatihKnjiga";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormPregledIzdatihKnjiga";
            Load+=FormPregledIzdatihKnjiga_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledIzdatihKnjiga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIzmijeniIznajmljivanje;
        private Button buttonObrisiiznajmljivanje;
        private Button buttonOsvjeziPregledAutora;
        private Button buttonIzadjiiznajmljivanje;
        private TextBox textBoxPregledPoImenuKorisnika;
        private Label labelImeKorisnika;
        private Label labelPregledIzdatihKnjiga;
        private DataGridView dataGridViewPregledIzdatihKnjiga;
    }
}