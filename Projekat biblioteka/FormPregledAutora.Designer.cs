namespace Projekat_biblioteka
{
    partial class FormPregledAutora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregledAutora));
            dataGridViewPregledAutora=new DataGridView();
            textBoxPregledPoImenuAutora=new TextBox();
            labelImeAutora=new Label();
            labelPregledAutora=new Label();
            buttonIzadjiPregledAutora=new Button();
            buttonIzmijeniAutora=new Button();
            buttonObrisiAutora=new Button();
            buttonOsvjeziPregledAutora=new Button();
            buttonDodajAutoraPregledAutora=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledAutora).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPregledAutora
            // 
            dataGridViewPregledAutora.BackgroundColor=Color.White;
            dataGridViewPregledAutora.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPregledAutora.Location=new Point(39, 204);
            dataGridViewPregledAutora.Name="dataGridViewPregledAutora";
            dataGridViewPregledAutora.RowHeadersWidth=51;
            dataGridViewPregledAutora.RowTemplate.Height=29;
            dataGridViewPregledAutora.Size=new Size(643, 341);
            dataGridViewPregledAutora.TabIndex=0;
            // 
            // textBoxPregledPoImenuAutora
            // 
            textBoxPregledPoImenuAutora.Location=new Point(321, 126);
            textBoxPregledPoImenuAutora.Name="textBoxPregledPoImenuAutora";
            textBoxPregledPoImenuAutora.Size=new Size(242, 27);
            textBoxPregledPoImenuAutora.TabIndex=7;
            textBoxPregledPoImenuAutora.TextChanged+=textBoxPregledPoImenuAutora_TextChanged;
            // 
            // labelImeAutora
            // 
            labelImeAutora.AutoSize=true;
            labelImeAutora.BackColor=Color.White;
            labelImeAutora.Font=new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelImeAutora.Location=new Point(151, 126);
            labelImeAutora.Name="labelImeAutora";
            labelImeAutora.Size=new Size(141, 35);
            labelImeAutora.TabIndex=6;
            labelImeAutora.Text="Ime Autora";
            // 
            // labelPregledAutora
            // 
            labelPregledAutora.AutoSize=true;
            labelPregledAutora.BackColor=Color.White;
            labelPregledAutora.Font=new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPregledAutora.Location=new Point(250, 36);
            labelPregledAutora.Name="labelPregledAutora";
            labelPregledAutora.Size=new Size(242, 45);
            labelPregledAutora.TabIndex=5;
            labelPregledAutora.Text="Pregled Autora";
            // 
            // buttonIzadjiPregledAutora
            // 
            buttonIzadjiPregledAutora.Location=new Point(588, 561);
            buttonIzadjiPregledAutora.Name="buttonIzadjiPregledAutora";
            buttonIzadjiPregledAutora.Size=new Size(94, 29);
            buttonIzadjiPregledAutora.TabIndex=8;
            buttonIzadjiPregledAutora.Text="Izađi";
            buttonIzadjiPregledAutora.UseVisualStyleBackColor=true;
            buttonIzadjiPregledAutora.Click+=buttonIzadjiPregledAutora_Click;
            // 
            // buttonIzmijeniAutora
            // 
            buttonIzmijeniAutora.Location=new Point(170, 561);
            buttonIzmijeniAutora.Name="buttonIzmijeniAutora";
            buttonIzmijeniAutora.Size=new Size(94, 29);
            buttonIzmijeniAutora.TabIndex=17;
            buttonIzmijeniAutora.Text="Izmijeni";
            buttonIzmijeniAutora.UseVisualStyleBackColor=true;
            buttonIzmijeniAutora.Click+=buttonIzmijeniAutora_Click;
            // 
            // buttonObrisiAutora
            // 
            buttonObrisiAutora.Location=new Point(460, 561);
            buttonObrisiAutora.Name="buttonObrisiAutora";
            buttonObrisiAutora.Size=new Size(94, 29);
            buttonObrisiAutora.TabIndex=16;
            buttonObrisiAutora.Text="Obriši";
            buttonObrisiAutora.UseVisualStyleBackColor=true;
            buttonObrisiAutora.Click+=buttonObrisiAutora_Click;
            // 
            // buttonOsvjeziPregledAutora
            // 
            buttonOsvjeziPregledAutora.Location=new Point(39, 561);
            buttonOsvjeziPregledAutora.Name="buttonOsvjeziPregledAutora";
            buttonOsvjeziPregledAutora.Size=new Size(70, 29);
            buttonOsvjeziPregledAutora.TabIndex=15;
            buttonOsvjeziPregledAutora.Text="Osvježi";
            buttonOsvjeziPregledAutora.UseVisualStyleBackColor=true;
            buttonOsvjeziPregledAutora.Click+=buttonOsvjeziPregledAutora_Click;
            // 
            // buttonDodajAutoraPregledAutora
            // 
            buttonDodajAutoraPregledAutora.Location=new Point(296, 561);
            buttonDodajAutoraPregledAutora.Name="buttonDodajAutoraPregledAutora";
            buttonDodajAutoraPregledAutora.Size=new Size(126, 29);
            buttonDodajAutoraPregledAutora.TabIndex=14;
            buttonDodajAutoraPregledAutora.Text="Dodaj Autora";
            buttonDodajAutoraPregledAutora.UseVisualStyleBackColor=true;
            buttonDodajAutoraPregledAutora.Click+=buttonDodajAutoraPregledAutora_Click;
            // 
            // FormPregledAutora
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(738, 602);
            ControlBox=false;
            Controls.Add(buttonIzmijeniAutora);
            Controls.Add(buttonObrisiAutora);
            Controls.Add(buttonOsvjeziPregledAutora);
            Controls.Add(buttonDodajAutoraPregledAutora);
            Controls.Add(buttonIzadjiPregledAutora);
            Controls.Add(textBoxPregledPoImenuAutora);
            Controls.Add(labelImeAutora);
            Controls.Add(labelPregledAutora);
            Controls.Add(dataGridViewPregledAutora);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormPregledAutora";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormPregledAutora";
            Load+=FormPregledAutora_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledAutora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPregledAutora;
        private TextBox textBoxPregledPoImenuAutora;
        private Label labelImeAutora;
        private Label labelPregledAutora;
        private Button buttonIzadjiPregledAutora;
        private Button buttonIzmijeniAutora;
        private Button buttonObrisiAutora;
        private Button buttonOsvjeziPregledAutora;
        private Button buttonDodajAutoraPregledAutora;
    }
}