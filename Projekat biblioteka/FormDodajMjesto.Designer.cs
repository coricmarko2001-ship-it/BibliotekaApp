namespace Projekat_biblioteka
{
    partial class FormDodajMjesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajMjesto));
            labelNazivDodajMjesto=new Label();
            label1=new Label();
            labelPostanskiBrojDodajMjesto=new Label();
            textBoxNazivDodajMjesto=new TextBox();
            textBoxPostanskiBrojDodajMjesto=new TextBox();
            buttonDodajMjesto=new Button();
            buttonOdustaniDodavanjeMjesta=new Button();
            SuspendLayout();
            // 
            // labelNazivDodajMjesto
            // 
            labelNazivDodajMjesto.AutoSize=true;
            labelNazivDodajMjesto.BackColor=Color.White;
            labelNazivDodajMjesto.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNazivDodajMjesto.Location=new Point(69, 138);
            labelNazivDodajMjesto.Name="labelNazivDodajMjesto";
            labelNazivDodajMjesto.Size=new Size(62, 28);
            labelNazivDodajMjesto.TabIndex=0;
            labelNazivDodajMjesto.Text="Naziv";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(134, 42);
            label1.Name="label1";
            label1.Size=new Size(168, 35);
            label1.TabIndex=1;
            label1.Text="Dodaj Mjesto";
            // 
            // labelPostanskiBrojDodajMjesto
            // 
            labelPostanskiBrojDodajMjesto.AutoSize=true;
            labelPostanskiBrojDodajMjesto.BackColor=Color.White;
            labelPostanskiBrojDodajMjesto.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelPostanskiBrojDodajMjesto.Location=new Point(69, 204);
            labelPostanskiBrojDodajMjesto.Name="labelPostanskiBrojDodajMjesto";
            labelPostanskiBrojDodajMjesto.Size=new Size(143, 28);
            labelPostanskiBrojDodajMjesto.TabIndex=2;
            labelPostanskiBrojDodajMjesto.Text="Poštanski broj";
            // 
            // textBoxNazivDodajMjesto
            // 
            textBoxNazivDodajMjesto.Location=new Point(231, 141);
            textBoxNazivDodajMjesto.Name="textBoxNazivDodajMjesto";
            textBoxNazivDodajMjesto.Size=new Size(125, 27);
            textBoxNazivDodajMjesto.TabIndex=3;
            // 
            // textBoxPostanskiBrojDodajMjesto
            // 
            textBoxPostanskiBrojDodajMjesto.Location=new Point(231, 207);
            textBoxPostanskiBrojDodajMjesto.Name="textBoxPostanskiBrojDodajMjesto";
            textBoxPostanskiBrojDodajMjesto.Size=new Size(125, 27);
            textBoxPostanskiBrojDodajMjesto.TabIndex=4;
            // 
            // buttonDodajMjesto
            // 
            buttonDodajMjesto.BackColor=Color.FromArgb(128, 255, 128);
            buttonDodajMjesto.Location=new Point(85, 299);
            buttonDodajMjesto.Name="buttonDodajMjesto";
            buttonDodajMjesto.Size=new Size(94, 29);
            buttonDodajMjesto.TabIndex=5;
            buttonDodajMjesto.Text="Dodaj";
            buttonDodajMjesto.UseVisualStyleBackColor=false;
            buttonDodajMjesto.Click+=buttonDodajMjesto_Click;
            // 
            // buttonOdustaniDodavanjeMjesta
            // 
            buttonOdustaniDodavanjeMjesta.BackColor=Color.FromArgb(255, 128, 128);
            buttonOdustaniDodavanjeMjesta.ForeColor=SystemColors.ControlText;
            buttonOdustaniDodavanjeMjesta.Location=new Point(245, 299);
            buttonOdustaniDodavanjeMjesta.Name="buttonOdustaniDodavanjeMjesta";
            buttonOdustaniDodavanjeMjesta.Size=new Size(94, 29);
            buttonOdustaniDodavanjeMjesta.TabIndex=6;
            buttonOdustaniDodavanjeMjesta.Text="Odustani";
            buttonOdustaniDodavanjeMjesta.UseVisualStyleBackColor=false;
            buttonOdustaniDodavanjeMjesta.Click+=buttonOdustaniDodavanjeMjesta_Click;
            // 
            // FormDodajMjesto
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(437, 395);
            Controls.Add(buttonOdustaniDodavanjeMjesta);
            Controls.Add(buttonDodajMjesto);
            Controls.Add(textBoxPostanskiBrojDodajMjesto);
            Controls.Add(textBoxNazivDodajMjesto);
            Controls.Add(labelPostanskiBrojDodajMjesto);
            Controls.Add(label1);
            Controls.Add(labelNazivDodajMjesto);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormDodajMjesto";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormDodajMjesto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNazivDodajMjesto;
        private Label label1;
        private Label labelPostanskiBrojDodajMjesto;
        private TextBox textBoxNazivDodajMjesto;
        private TextBox textBoxPostanskiBrojDodajMjesto;
        private Button buttonDodajMjesto;
        private Button buttonOdustaniDodavanjeMjesta;
    }
}