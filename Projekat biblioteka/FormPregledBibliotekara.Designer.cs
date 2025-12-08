namespace Projekat_biblioteka
{
    partial class FormPregledBibliotekara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledBibliotekara));
            buttonIzmijeniBibliotekara=new Button();
            buttonObrisiBibliotekara=new Button();
            buttonOsvjeziPregledBibliotekara=new Button();
            buttonIzadjiPregledBibliotekara=new Button();
            textBoxPregledPoImenuBibliotekara=new TextBox();
            labelImeBibliotekara=new Label();
            labelPregledAutora=new Label();
            dataGridViewPregledBibliotekara=new DataGridView();
            labelPregledIzdavaca=new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledBibliotekara).BeginInit();
            SuspendLayout();
            // 
            // buttonIzmijeniBibliotekara
            // 
            buttonIzmijeniBibliotekara.Location=new Point(254, 523);
            buttonIzmijeniBibliotekara.Name="buttonIzmijeniBibliotekara";
            buttonIzmijeniBibliotekara.Size=new Size(94, 29);
            buttonIzmijeniBibliotekara.TabIndex=26;
            buttonIzmijeniBibliotekara.Text="Izmijeni ";
            buttonIzmijeniBibliotekara.UseVisualStyleBackColor=true;
            buttonIzmijeniBibliotekara.Click+=buttonIzmijeniBibliotekara_Click;
            // 
            // buttonObrisiBibliotekara
            // 
            buttonObrisiBibliotekara.Location=new Point(461, 523);
            buttonObrisiBibliotekara.Name="buttonObrisiBibliotekara";
            buttonObrisiBibliotekara.Size=new Size(94, 29);
            buttonObrisiBibliotekara.TabIndex=25;
            buttonObrisiBibliotekara.Text="Obriši";
            buttonObrisiBibliotekara.UseVisualStyleBackColor=true;
            buttonObrisiBibliotekara.Click+=buttonObrisiBibliotekara_Click;
            // 
            // buttonOsvjeziPregledBibliotekara
            // 
            buttonOsvjeziPregledBibliotekara.Location=new Point(81, 523);
            buttonOsvjeziPregledBibliotekara.Name="buttonOsvjeziPregledBibliotekara";
            buttonOsvjeziPregledBibliotekara.Size=new Size(70, 29);
            buttonOsvjeziPregledBibliotekara.TabIndex=24;
            buttonOsvjeziPregledBibliotekara.Text="Osvježi";
            buttonOsvjeziPregledBibliotekara.UseVisualStyleBackColor=true;
            buttonOsvjeziPregledBibliotekara.Click+=buttonOsvjeziPregledBibliotekara_Click;
            // 
            // buttonIzadjiPregledBibliotekara
            // 
            buttonIzadjiPregledBibliotekara.Location=new Point(630, 523);
            buttonIzadjiPregledBibliotekara.Name="buttonIzadjiPregledBibliotekara";
            buttonIzadjiPregledBibliotekara.Size=new Size(94, 29);
            buttonIzadjiPregledBibliotekara.TabIndex=22;
            buttonIzadjiPregledBibliotekara.Text="Izađi";
            buttonIzadjiPregledBibliotekara.UseVisualStyleBackColor=true;
            buttonIzadjiPregledBibliotekara.Click+=buttonIzadjiPregledBibliotekara_Click;
            // 
            // textBoxPregledPoImenuBibliotekara
            // 
            textBoxPregledPoImenuBibliotekara.Location=new Point(397, 105);
            textBoxPregledPoImenuBibliotekara.Name="textBoxPregledPoImenuBibliotekara";
            textBoxPregledPoImenuBibliotekara.Size=new Size(242, 27);
            textBoxPregledPoImenuBibliotekara.TabIndex=21;
            textBoxPregledPoImenuBibliotekara.TextChanged+=textBoxPregledPoImenuBibliotekara_TextChanged;
            // 
            // labelImeBibliotekara
            // 
            labelImeBibliotekara.AutoSize=true;
            labelImeBibliotekara.BackColor=Color.White;
            labelImeBibliotekara.Font=new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeBibliotekara.Location=new Point(193, 98);
            labelImeBibliotekara.Name="labelImeBibliotekara";
            labelImeBibliotekara.Size=new Size(198, 35);
            labelImeBibliotekara.TabIndex=20;
            labelImeBibliotekara.Text="Ime Bibliotekara";
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
            // dataGridViewPregledBibliotekara
            // 
            dataGridViewPregledBibliotekara.BackgroundColor=Color.White;
            dataGridViewPregledBibliotekara.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPregledBibliotekara.Location=new Point(81, 166);
            dataGridViewPregledBibliotekara.Name="dataGridViewPregledBibliotekara";
            dataGridViewPregledBibliotekara.RowHeadersWidth=51;
            dataGridViewPregledBibliotekara.RowTemplate.Height=29;
            dataGridViewPregledBibliotekara.Size=new Size(643, 341);
            dataGridViewPregledBibliotekara.TabIndex=18;
            // 
            // labelPregledIzdavaca
            // 
            labelPregledIzdavaca.AutoSize=true;
            labelPregledIzdavaca.BackColor=Color.White;
            labelPregledIzdavaca.Font=new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelPregledIzdavaca.Location=new Point(259, 26);
            labelPregledIzdavaca.Name="labelPregledIzdavaca";
            labelPregledIzdavaca.Size=new Size(296, 41);
            labelPregledIzdavaca.TabIndex=28;
            labelPregledIzdavaca.Text="Pregled Bibliotekara";
            // 
            // FormPregledBibliotekara
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(800, 568);
            Controls.Add(labelPregledIzdavaca);
            Controls.Add(buttonIzmijeniBibliotekara);
            Controls.Add(buttonObrisiBibliotekara);
            Controls.Add(buttonOsvjeziPregledBibliotekara);
            Controls.Add(buttonIzadjiPregledBibliotekara);
            Controls.Add(textBoxPregledPoImenuBibliotekara);
            Controls.Add(labelImeBibliotekara);
            Controls.Add(labelPregledAutora);
            Controls.Add(dataGridViewPregledBibliotekara);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormPregledBibliotekara";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormPregledBibliotekara";
            Load+=FormPregledBibliotekara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledBibliotekara).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIzmijeniBibliotekara;
        private Button buttonObrisiBibliotekara;
        private Button buttonOsvjeziPregledBibliotekara;
        private Button buttonIzadjiPregledBibliotekara;
        private TextBox textBoxPregledPoImenuBibliotekara;
        private Label labelImeBibliotekara;
        private Label labelPregledAutora;
        private DataGridView dataGridViewPregledBibliotekara;
        private Label labelPregledIzdavaca;
    }
}