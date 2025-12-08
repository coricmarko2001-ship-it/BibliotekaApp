namespace Projekat_biblioteka
{
    partial class FormDodajZanr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajZanr));
            textBoxDodajZanrNazivZanra=new TextBox();
            label1=new Label();
            labelDodajZanrNazivZanra=new Label();
            buttonDodajZanrOdustani=new Button();
            buttonDodajZanrPotvrdi=new Button();
            SuspendLayout();
            // 
            // textBoxDodajZanrNazivZanra
            // 
            textBoxDodajZanrNazivZanra.Location=new Point(184, 127);
            textBoxDodajZanrNazivZanra.Name="textBoxDodajZanrNazivZanra";
            textBoxDodajZanrNazivZanra.Size=new Size(181, 27);
            textBoxDodajZanrNazivZanra.TabIndex=12;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.White;
            label1.Font=new Font("Calibri", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(134, 33);
            label1.Name="label1";
            label1.Size=new Size(154, 38);
            label1.TabIndex=11;
            label1.Text="Dodaj Žanr";
            // 
            // labelDodajZanrNazivZanra
            // 
            labelDodajZanrNazivZanra.AutoSize=true;
            labelDodajZanrNazivZanra.BackColor=Color.White;
            labelDodajZanrNazivZanra.Font=new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDodajZanrNazivZanra.Location=new Point(49, 126);
            labelDodajZanrNazivZanra.Name="labelDodajZanrNazivZanra";
            labelDodajZanrNazivZanra.Size=new Size(118, 28);
            labelDodajZanrNazivZanra.TabIndex=10;
            labelDodajZanrNazivZanra.Text="Naziv žanra";
            // 
            // buttonDodajZanrOdustani
            // 
            buttonDodajZanrOdustani.BackColor=Color.FromArgb(255, 128, 128);
            buttonDodajZanrOdustani.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajZanrOdustani.Location=new Point(250, 201);
            buttonDodajZanrOdustani.Name="buttonDodajZanrOdustani";
            buttonDodajZanrOdustani.Size=new Size(102, 40);
            buttonDodajZanrOdustani.TabIndex=14;
            buttonDodajZanrOdustani.Text="Odustani";
            buttonDodajZanrOdustani.UseVisualStyleBackColor=false;
            buttonDodajZanrOdustani.Click+=buttonDodajZanrOdustani_Click;
            // 
            // buttonDodajZanrPotvrdi
            // 
            buttonDodajZanrPotvrdi.BackColor=Color.FromArgb(128, 255, 128);
            buttonDodajZanrPotvrdi.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajZanrPotvrdi.Location=new Point(83, 201);
            buttonDodajZanrPotvrdi.Name="buttonDodajZanrPotvrdi";
            buttonDodajZanrPotvrdi.Size=new Size(101, 42);
            buttonDodajZanrPotvrdi.TabIndex=13;
            buttonDodajZanrPotvrdi.Text="Potvrdi";
            buttonDodajZanrPotvrdi.UseVisualStyleBackColor=false;
            buttonDodajZanrPotvrdi.Click+=buttonDodajZanrPotvrdi_Click;
            // 
            // FormDodajZanr
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGreen;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            ClientSize=new Size(434, 255);
            Controls.Add(buttonDodajZanrOdustani);
            Controls.Add(buttonDodajZanrPotvrdi);
            Controls.Add(textBoxDodajZanrNazivZanra);
            Controls.Add(label1);
            Controls.Add(labelDodajZanrNazivZanra);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormDodajZanr";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormDodajZanr";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDodajZanrNazivZanra;
        private Label label1;
        private Label labelDodajZanrNazivZanra;
        private Button buttonDodajZanrOdustani;
        private Button buttonDodajZanrPotvrdi;
    }
}