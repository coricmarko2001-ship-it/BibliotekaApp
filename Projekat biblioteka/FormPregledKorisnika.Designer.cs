namespace Projekat_biblioteka
{
    partial class FormPregledKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledKorisnika));
            dataGridViewPregledKorisnika=new DataGridView();
            buttonIzadjiPregledKorisnika=new Button();
            labelPregledKorisnika=new Label();
            labelPretraziPoIdKorisnika=new Label();
            textBoxPretraziPoIdKorisnika=new TextBox();
            buttonRegistrujKorisnika=new Button();
            buttonOsvjeziPregledKorisnika=new Button();
            buttonObrisiKorisnika=new Button();
            buttonIzmijeniKorisnika=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledKorisnika).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPregledKorisnika
            // 
            dataGridViewPregledKorisnika.BackgroundColor=Color.White;
            dataGridViewPregledKorisnika.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPregledKorisnika.Location=new Point(34, 220);
            dataGridViewPregledKorisnika.Name="dataGridViewPregledKorisnika";
            dataGridViewPregledKorisnika.RowHeadersWidth=51;
            dataGridViewPregledKorisnika.RowTemplate.Height=29;
            dataGridViewPregledKorisnika.Size=new Size(937, 341);
            dataGridViewPregledKorisnika.TabIndex=0;
            // 
            // buttonIzadjiPregledKorisnika
            // 
            buttonIzadjiPregledKorisnika.Location=new Point(867, 574);
            buttonIzadjiPregledKorisnika.Name="buttonIzadjiPregledKorisnika";
            buttonIzadjiPregledKorisnika.Size=new Size(104, 29);
            buttonIzadjiPregledKorisnika.TabIndex=1;
            buttonIzadjiPregledKorisnika.Text="Izađi";
            buttonIzadjiPregledKorisnika.UseVisualStyleBackColor=true;
            buttonIzadjiPregledKorisnika.Click+=buttonIzadjiPregledKorisnika_Click;
            // 
            // labelPregledKorisnika
            // 
            labelPregledKorisnika.AutoSize=true;
            labelPregledKorisnika.BackColor=Color.White;
            labelPregledKorisnika.Font=new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPregledKorisnika.Location=new Point(394, 39);
            labelPregledKorisnika.Name="labelPregledKorisnika";
            labelPregledKorisnika.Size=new Size(274, 45);
            labelPregledKorisnika.TabIndex=2;
            labelPregledKorisnika.Text="Pregled Korisnika";
            // 
            // labelPretraziPoIdKorisnika
            // 
            labelPretraziPoIdKorisnika.AutoSize=true;
            labelPretraziPoIdKorisnika.BackColor=Color.White;
            labelPretraziPoIdKorisnika.Font=new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPretraziPoIdKorisnika.Location=new Point(240, 119);
            labelPretraziPoIdKorisnika.Name="labelPretraziPoIdKorisnika";
            labelPretraziPoIdKorisnika.Size=new Size(148, 35);
            labelPretraziPoIdKorisnika.TabIndex=3;
            labelPretraziPoIdKorisnika.Text="ID Korisnika";
            // 
            // textBoxPretraziPoIdKorisnika
            // 
            textBoxPretraziPoIdKorisnika.Location=new Point(394, 127);
            textBoxPretraziPoIdKorisnika.Name="textBoxPretraziPoIdKorisnika";
            textBoxPretraziPoIdKorisnika.Size=new Size(274, 27);
            textBoxPretraziPoIdKorisnika.TabIndex=4;
            textBoxPretraziPoIdKorisnika.TextChanged+=textBoxPretraziPoIdKorisnika_TextChanged;
            // 
            // buttonRegistrujKorisnika
            // 
            buttonRegistrujKorisnika.Location=new Point(420, 574);
            buttonRegistrujKorisnika.Name="buttonRegistrujKorisnika";
            buttonRegistrujKorisnika.Size=new Size(154, 29);
            buttonRegistrujKorisnika.TabIndex=5;
            buttonRegistrujKorisnika.Text="Registruj Korisnika";
            buttonRegistrujKorisnika.UseVisualStyleBackColor=true;
            buttonRegistrujKorisnika.Click+=buttonRegistrujKorisnika_Click;
            // 
            // buttonOsvjeziPregledKorisnika
            // 
            buttonOsvjeziPregledKorisnika.Location=new Point(34, 574);
            buttonOsvjeziPregledKorisnika.Name="buttonOsvjeziPregledKorisnika";
            buttonOsvjeziPregledKorisnika.Size=new Size(70, 29);
            buttonOsvjeziPregledKorisnika.TabIndex=6;
            buttonOsvjeziPregledKorisnika.Text="Osvježi";
            buttonOsvjeziPregledKorisnika.UseVisualStyleBackColor=true;
            buttonOsvjeziPregledKorisnika.Click+=buttonOsvjeziPregledKorisnika_Click;
            // 
            // buttonObrisiKorisnika
            // 
            buttonObrisiKorisnika.Location=new Point(611, 574);
            buttonObrisiKorisnika.Name="buttonObrisiKorisnika";
            buttonObrisiKorisnika.Size=new Size(94, 29);
            buttonObrisiKorisnika.TabIndex=7;
            buttonObrisiKorisnika.Text="Obriši";
            buttonObrisiKorisnika.UseVisualStyleBackColor=true;
            buttonObrisiKorisnika.Click+=buttonObrisiKorisnika_Click;
            // 
            // buttonIzmijeniKorisnika
            // 
            buttonIzmijeniKorisnika.Location=new Point(294, 574);
            buttonIzmijeniKorisnika.Name="buttonIzmijeniKorisnika";
            buttonIzmijeniKorisnika.Size=new Size(94, 29);
            buttonIzmijeniKorisnika.TabIndex=8;
            buttonIzmijeniKorisnika.Text="Izmijeni";
            buttonIzmijeniKorisnika.UseVisualStyleBackColor=true;
            buttonIzmijeniKorisnika.Click+=buttonIzmijeniKorisnika_Click;
            // 
            // FormPregledKorisnika
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(1016, 615);
            ControlBox=false;
            Controls.Add(buttonIzmijeniKorisnika);
            Controls.Add(buttonObrisiKorisnika);
            Controls.Add(buttonOsvjeziPregledKorisnika);
            Controls.Add(buttonRegistrujKorisnika);
            Controls.Add(textBoxPretraziPoIdKorisnika);
            Controls.Add(labelPretraziPoIdKorisnika);
            Controls.Add(labelPregledKorisnika);
            Controls.Add(buttonIzadjiPregledKorisnika);
            Controls.Add(dataGridViewPregledKorisnika);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormPregledKorisnika";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormPregledKorisnika";
            Load+=FormPregledKorisnika_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledKorisnika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPregledKorisnika;
        private Button buttonIzadjiPregledKorisnika;
        private Label labelPregledKorisnika;
        private Label labelPretraziPoIdKorisnika;
        private TextBox textBoxPretraziPoIdKorisnika;
        private Button buttonRegistrujKorisnika;
        private Button buttonOsvjeziPregledKorisnika;
        private Button buttonObrisiKorisnika;
        private Button buttonIzmijeniKorisnika;
    }
}