namespace Projekat_biblioteka
{
    partial class FormPregledKnjiga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledKnjiga));
            labelPregledKnjiga=new Label();
            labelPretraziPoImeniKnjige=new Label();
            textBoxPretraziPoImenuKnjige=new TextBox();
            buttonDodajKnjiguPregledKnjiga=new Button();
            dataGridViewPregledKnjiga=new DataGridView();
            buttonIzadjiPregledKnjiga=new Button();
            buttonIzmijeniKnjigu=new Button();
            buttonObrisiKnjigu=new Button();
            buttonOsvjeziPregledKnjiga=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledKnjiga).BeginInit();
            SuspendLayout();
            // 
            // labelPregledKnjiga
            // 
            labelPregledKnjiga.AutoSize=true;
            labelPregledKnjiga.BackColor=Color.White;
            labelPregledKnjiga.Font=new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPregledKnjiga.Location=new Point(485, 34);
            labelPregledKnjiga.Name="labelPregledKnjiga";
            labelPregledKnjiga.Size=new Size(228, 45);
            labelPregledKnjiga.TabIndex=0;
            labelPregledKnjiga.Text="Pregled Knjiga";
            // 
            // labelPretraziPoImeniKnjige
            // 
            labelPretraziPoImeniKnjige.AutoSize=true;
            labelPretraziPoImeniKnjige.BackColor=Color.White;
            labelPretraziPoImeniKnjige.Font=new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPretraziPoImeniKnjige.Location=new Point(328, 120);
            labelPretraziPoImeniKnjige.Name="labelPretraziPoImeniKnjige";
            labelPretraziPoImeniKnjige.Size=new Size(134, 35);
            labelPretraziPoImeniKnjige.TabIndex=1;
            labelPretraziPoImeniKnjige.Text="Ime Knjige";
            // 
            // textBoxPretraziPoImenuKnjige
            // 
            textBoxPretraziPoImenuKnjige.Location=new Point(485, 128);
            textBoxPretraziPoImenuKnjige.Name="textBoxPretraziPoImenuKnjige";
            textBoxPretraziPoImenuKnjige.Size=new Size(228, 27);
            textBoxPretraziPoImenuKnjige.TabIndex=2;
            textBoxPretraziPoImenuKnjige.TextChanged+=textBoxPretraziPoImenuKnjige_TextChanged;
            // 
            // buttonDodajKnjiguPregledKnjiga
            // 
            buttonDodajKnjiguPregledKnjiga.Location=new Point(510, 574);
            buttonDodajKnjiguPregledKnjiga.Name="buttonDodajKnjiguPregledKnjiga";
            buttonDodajKnjiguPregledKnjiga.Size=new Size(126, 29);
            buttonDodajKnjiguPregledKnjiga.TabIndex=4;
            buttonDodajKnjiguPregledKnjiga.Text="Dodaj Knjigu";
            buttonDodajKnjiguPregledKnjiga.UseVisualStyleBackColor=true;
            buttonDodajKnjiguPregledKnjiga.Click+=buttonDodajKnjiguPregledKnjiga_Click;
            // 
            // dataGridViewPregledKnjiga
            // 
            dataGridViewPregledKnjiga.BackgroundColor=Color.White;
            dataGridViewPregledKnjiga.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPregledKnjiga.Location=new Point(49, 211);
            dataGridViewPregledKnjiga.Name="dataGridViewPregledKnjiga";
            dataGridViewPregledKnjiga.RowHeadersWidth=51;
            dataGridViewPregledKnjiga.RowTemplate.Height=29;
            dataGridViewPregledKnjiga.Size=new Size(1061, 341);
            dataGridViewPregledKnjiga.TabIndex=5;
            // 
            // buttonIzadjiPregledKnjiga
            // 
            buttonIzadjiPregledKnjiga.Location=new Point(1016, 574);
            buttonIzadjiPregledKnjiga.Name="buttonIzadjiPregledKnjiga";
            buttonIzadjiPregledKnjiga.Size=new Size(94, 29);
            buttonIzadjiPregledKnjiga.TabIndex=6;
            buttonIzadjiPregledKnjiga.Text="Izađi";
            buttonIzadjiPregledKnjiga.UseVisualStyleBackColor=true;
            buttonIzadjiPregledKnjiga.Click+=buttonIzadjiPregledKnjiga_Click;
            // 
            // buttonIzmijeniKnjigu
            // 
            buttonIzmijeniKnjigu.Location=new Point(348, 574);
            buttonIzmijeniKnjigu.Name="buttonIzmijeniKnjigu";
            buttonIzmijeniKnjigu.Size=new Size(94, 29);
            buttonIzmijeniKnjigu.TabIndex=13;
            buttonIzmijeniKnjigu.Text="Izmijeni";
            buttonIzmijeniKnjigu.UseVisualStyleBackColor=true;
            buttonIzmijeniKnjigu.Click+=buttonIzmijeniKnjigu_Click;
            // 
            // buttonObrisiKnjigu
            // 
            buttonObrisiKnjigu.Location=new Point(714, 574);
            buttonObrisiKnjigu.Name="buttonObrisiKnjigu";
            buttonObrisiKnjigu.Size=new Size(94, 29);
            buttonObrisiKnjigu.TabIndex=12;
            buttonObrisiKnjigu.Text="Obriši";
            buttonObrisiKnjigu.UseVisualStyleBackColor=true;
            buttonObrisiKnjigu.Click+=buttonObrisiKnjigu_Click;
            // 
            // buttonOsvjeziPregledKnjiga
            // 
            buttonOsvjeziPregledKnjiga.Location=new Point(49, 574);
            buttonOsvjeziPregledKnjiga.Name="buttonOsvjeziPregledKnjiga";
            buttonOsvjeziPregledKnjiga.Size=new Size(70, 29);
            buttonOsvjeziPregledKnjiga.TabIndex=11;
            buttonOsvjeziPregledKnjiga.Text="Osvježi";
            buttonOsvjeziPregledKnjiga.UseVisualStyleBackColor=true;
            buttonOsvjeziPregledKnjiga.Click+=buttonOsvjeziPregledKnjiga_Click;
            // 
            // FormPregledKnjiga
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(1166, 615);
            ControlBox=false;
            Controls.Add(buttonIzmijeniKnjigu);
            Controls.Add(buttonObrisiKnjigu);
            Controls.Add(buttonOsvjeziPregledKnjiga);
            Controls.Add(buttonIzadjiPregledKnjiga);
            Controls.Add(dataGridViewPregledKnjiga);
            Controls.Add(buttonDodajKnjiguPregledKnjiga);
            Controls.Add(textBoxPretraziPoImenuKnjige);
            Controls.Add(labelPretraziPoImeniKnjige);
            Controls.Add(labelPregledKnjiga);
            ForeColor=SystemColors.ControlText;
            FormBorderStyle=FormBorderStyle.None;
            Name="FormPregledKnjiga";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormPregledKnjiga";
            Load+=FormPregledKnjiga_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledKnjiga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPregledKnjiga;
        private Label labelPretraziPoImeniKnjige;
        private TextBox textBoxPretraziPoImenuKnjige;
        private Button buttonDodajKnjiguPregledKnjiga;
        private DataGridView dataGridViewPregledKnjiga;
        private Button buttonIzadjiPregledKnjiga;
        private Button buttonIzmijeniKnjigu;
        private Button buttonObrisiKnjigu;
        private Button buttonOsvjeziPregledKnjiga;
    }
}