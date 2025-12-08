namespace Projekat_biblioteka
{
    partial class FormPregledIzdavaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledIzdavaca));
            buttonIzmijeniIzdavaca=new Button();
            buttonObrisiIzdavaca=new Button();
            buttonOsvjeziPregledIzdavaca=new Button();
            buttonDodajIzdavacaPregledIzdavaca=new Button();
            buttonIzadjiPregledIzdavaca=new Button();
            textBoxPregledPoImenuIzdavaca=new TextBox();
            labelImeIzdavaca=new Label();
            labelPregledAutora=new Label();
            dataGridViewPregledIzdavaca=new DataGridView();
            labelPregledIzdavaca=new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledIzdavaca).BeginInit();
            SuspendLayout();
            // 
            // buttonIzmijeniIzdavaca
            // 
            buttonIzmijeniIzdavaca.Location=new Point(212, 514);
            buttonIzmijeniIzdavaca.Name="buttonIzmijeniIzdavaca";
            buttonIzmijeniIzdavaca.Size=new Size(94, 29);
            buttonIzmijeniIzdavaca.TabIndex=26;
            buttonIzmijeniIzdavaca.Text="Izmijeni";
            buttonIzmijeniIzdavaca.UseVisualStyleBackColor=true;
            buttonIzmijeniIzdavaca.Click+=buttonIzmijeniIzdavaca_Click;
            // 
            // buttonObrisiIzdavaca
            // 
            buttonObrisiIzdavaca.Location=new Point(502, 514);
            buttonObrisiIzdavaca.Name="buttonObrisiIzdavaca";
            buttonObrisiIzdavaca.Size=new Size(94, 29);
            buttonObrisiIzdavaca.TabIndex=25;
            buttonObrisiIzdavaca.Text="Obriši";
            buttonObrisiIzdavaca.UseVisualStyleBackColor=true;
            buttonObrisiIzdavaca.Click+=buttonObrisiIzdavaca_Click;
            // 
            // buttonOsvjeziPregledIzdavaca
            // 
            buttonOsvjeziPregledIzdavaca.Location=new Point(81, 514);
            buttonOsvjeziPregledIzdavaca.Name="buttonOsvjeziPregledIzdavaca";
            buttonOsvjeziPregledIzdavaca.Size=new Size(70, 29);
            buttonOsvjeziPregledIzdavaca.TabIndex=24;
            buttonOsvjeziPregledIzdavaca.Text="Osvježi";
            buttonOsvjeziPregledIzdavaca.UseVisualStyleBackColor=true;
            buttonOsvjeziPregledIzdavaca.Click+=buttonOsvjeziPregledIzdavaca_Click;
            // 
            // buttonDodajIzdavacaPregledIzdavaca
            // 
            buttonDodajIzdavacaPregledIzdavaca.Location=new Point(338, 514);
            buttonDodajIzdavacaPregledIzdavaca.Name="buttonDodajIzdavacaPregledIzdavaca";
            buttonDodajIzdavacaPregledIzdavaca.Size=new Size(126, 29);
            buttonDodajIzdavacaPregledIzdavaca.TabIndex=23;
            buttonDodajIzdavacaPregledIzdavaca.Text="Dodaj Izdavača";
            buttonDodajIzdavacaPregledIzdavaca.UseVisualStyleBackColor=true;
            buttonDodajIzdavacaPregledIzdavaca.Click+=buttonDodajIzdavacaPregledIzdavaca_Click;
            // 
            // buttonIzadjiPregledIzdavaca
            // 
            buttonIzadjiPregledIzdavaca.Location=new Point(630, 514);
            buttonIzadjiPregledIzdavaca.Name="buttonIzadjiPregledIzdavaca";
            buttonIzadjiPregledIzdavaca.Size=new Size(94, 29);
            buttonIzadjiPregledIzdavaca.TabIndex=22;
            buttonIzadjiPregledIzdavaca.Text="Izađi";
            buttonIzadjiPregledIzdavaca.UseVisualStyleBackColor=true;
            buttonIzadjiPregledIzdavaca.Click+=buttonIzadjiPregledIzdavaca_Click;
            // 
            // textBoxPregledPoImenuIzdavaca
            // 
            textBoxPregledPoImenuIzdavaca.Location=new Point(354, 98);
            textBoxPregledPoImenuIzdavaca.Name="textBoxPregledPoImenuIzdavaca";
            textBoxPregledPoImenuIzdavaca.Size=new Size(242, 27);
            textBoxPregledPoImenuIzdavaca.TabIndex=21;
            textBoxPregledPoImenuIzdavaca.TextChanged+=textBoxPregledPoImenuIzdavaca_TextChanged;
            // 
            // labelImeIzdavaca
            // 
            labelImeIzdavaca.AutoSize=true;
            labelImeIzdavaca.BackColor=Color.White;
            labelImeIzdavaca.Font=new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeIzdavaca.Location=new Point(188, 91);
            labelImeIzdavaca.Name="labelImeIzdavaca";
            labelImeIzdavaca.Size=new Size(160, 35);
            labelImeIzdavaca.TabIndex=20;
            labelImeIzdavaca.Text="Ime Izdavača";
            // 
            // labelPregledAutora
            // 
            labelPregledAutora.AutoSize=true;
            labelPregledAutora.Font=new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPregledAutora.Location=new Point(290, -52);
            labelPregledAutora.Name="labelPregledAutora";
            labelPregledAutora.Size=new Size(242, 45);
            labelPregledAutora.TabIndex=19;
            labelPregledAutora.Text="Pregled Autora";
            // 
            // dataGridViewPregledIzdavaca
            // 
            dataGridViewPregledIzdavaca.BackgroundColor=Color.White;
            dataGridViewPregledIzdavaca.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPregledIzdavaca.Location=new Point(81, 157);
            dataGridViewPregledIzdavaca.Name="dataGridViewPregledIzdavaca";
            dataGridViewPregledIzdavaca.RowHeadersWidth=51;
            dataGridViewPregledIzdavaca.RowTemplate.Height=29;
            dataGridViewPregledIzdavaca.Size=new Size(643, 341);
            dataGridViewPregledIzdavaca.TabIndex=18;
            // 
            // labelPregledIzdavaca
            // 
            labelPregledIzdavaca.AutoSize=true;
            labelPregledIzdavaca.BackColor=Color.White;
            labelPregledIzdavaca.Font=new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelPregledIzdavaca.Location=new Point(275, 18);
            labelPregledIzdavaca.Name="labelPregledIzdavaca";
            labelPregledIzdavaca.Size=new Size(247, 41);
            labelPregledIzdavaca.TabIndex=27;
            labelPregledIzdavaca.Text="Pregled Izdavača";
            // 
            // FormPregledIzdavaca
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(828, 558);
            Controls.Add(labelPregledIzdavaca);
            Controls.Add(buttonIzmijeniIzdavaca);
            Controls.Add(buttonObrisiIzdavaca);
            Controls.Add(buttonOsvjeziPregledIzdavaca);
            Controls.Add(buttonDodajIzdavacaPregledIzdavaca);
            Controls.Add(buttonIzadjiPregledIzdavaca);
            Controls.Add(textBoxPregledPoImenuIzdavaca);
            Controls.Add(labelImeIzdavaca);
            Controls.Add(labelPregledAutora);
            Controls.Add(dataGridViewPregledIzdavaca);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormPregledIzdavaca";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormPregledIzdavaca";
            Load+=FormPregledIzdavaca_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledIzdavaca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIzmijeniIzdavaca;
        private Button buttonObrisiIzdavaca;
        private Button buttonOsvjeziPregledIzdavaca;
        private Button buttonDodajIzdavacaPregledIzdavaca;
        private Button buttonIzadjiPregledIzdavaca;
        private TextBox textBoxPregledPoImenuIzdavaca;
        private Label labelImeIzdavaca;
        private Label labelPregledAutora;
        private DataGridView dataGridViewPregledIzdavaca;
        private Label labelPregledIzdavaca;
    }
}