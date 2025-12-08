namespace Projekat_biblioteka
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textBoxKorisnickoIme=new TextBox();
            textBoxLozinka=new TextBox();
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            panel1=new Panel();
            panel2=new Panel();
            buttonUlogujeSe=new Button();
            buttonOdustani=new Button();
            buttonRegistrujSe=new Button();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxKorisnickoIme
            // 
            textBoxKorisnickoIme.BackColor=Color.MediumSeaGreen;
            textBoxKorisnickoIme.BorderStyle=BorderStyle.None;
            textBoxKorisnickoIme.Font=new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKorisnickoIme.ForeColor=Color.Black;
            textBoxKorisnickoIme.Location=new Point(104, 116);
            textBoxKorisnickoIme.Name="textBoxKorisnickoIme";
            textBoxKorisnickoIme.Size=new Size(156, 21);
            textBoxKorisnickoIme.TabIndex=0;
            textBoxKorisnickoIme.Tag="";
            // 
            // textBoxLozinka
            // 
            textBoxLozinka.BackColor=Color.MediumSeaGreen;
            textBoxLozinka.BorderStyle=BorderStyle.None;
            textBoxLozinka.ForeColor=Color.Black;
            textBoxLozinka.Location=new Point(104, 193);
            textBoxLozinka.Name="textBoxLozinka";
            textBoxLozinka.PasswordChar='*';
            textBoxLozinka.Size=new Size(156, 20);
            textBoxLozinka.TabIndex=1;
            textBoxLozinka.KeyDown+=textBoxLozinka_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(36, 106);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(40, 40);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=2;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=(Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location=new Point(36, 178);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(40, 38);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=3;
            pictureBox2.TabStop=false;
            // 
            // panel1
            // 
            panel1.BackColor=Color.White;
            panel1.ForeColor=Color.Black;
            panel1.Location=new Point(104, 143);
            panel1.Name="panel1";
            panel1.Size=new Size(156, 1);
            panel1.TabIndex=4;
            // 
            // panel2
            // 
            panel2.BackColor=Color.White;
            panel2.ForeColor=Color.Black;
            panel2.Location=new Point(104, 215);
            panel2.Name="panel2";
            panel2.Size=new Size(156, 1);
            panel2.TabIndex=5;
            // 
            // buttonUlogujeSe
            // 
            buttonUlogujeSe.BackColor=Color.FromArgb(128, 255, 128);
            buttonUlogujeSe.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUlogujeSe.Location=new Point(128, 267);
            buttonUlogujeSe.Name="buttonUlogujeSe";
            buttonUlogujeSe.Size=new Size(156, 35);
            buttonUlogujeSe.TabIndex=6;
            buttonUlogujeSe.Text="Uloguj se";
            buttonUlogujeSe.UseVisualStyleBackColor=false;
            buttonUlogujeSe.Click+=buttonUlogujeSe_Click;
            // 
            // buttonOdustani
            // 
            buttonOdustani.BackColor=Color.FromArgb(255, 128, 128);
            buttonOdustani.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdustani.Location=new Point(128, 322);
            buttonOdustani.Name="buttonOdustani";
            buttonOdustani.Size=new Size(156, 36);
            buttonOdustani.TabIndex=7;
            buttonOdustani.Text="Odustani";
            buttonOdustani.UseVisualStyleBackColor=false;
            buttonOdustani.Click+=buttonOdustani_Click;
            // 
            // buttonRegistrujSe
            // 
            buttonRegistrujSe.BackColor=Color.FromArgb(128, 255, 255);
            buttonRegistrujSe.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrujSe.Location=new Point(128, 375);
            buttonRegistrujSe.Name="buttonRegistrujSe";
            buttonRegistrujSe.Size=new Size(153, 35);
            buttonRegistrujSe.TabIndex=8;
            buttonRegistrujSe.Text="Registruj se";
            buttonRegistrujSe.UseVisualStyleBackColor=false;
            buttonRegistrujSe.Click+=buttonRegistrujSe_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(128, 25);
            label1.Name="label1";
            label1.Size=new Size(138, 45);
            label1.TabIndex=9;
            label1.Text="PRIJAVA";
            label1.TextAlign=ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(279, 117);
            label2.Name="label2";
            label2.Size=new Size(114, 20);
            label2.TabIndex=10;
            label2.Text="(korisničko ime)";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(279, 193);
            label3.Name="label3";
            label3.Size=new Size(66, 20);
            label3.TabIndex=11;
            label3.Text="(lozinka)";
            // 
            // FormLogin
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.MediumSeaGreen;
            ClientSize=new Size(400, 445);
            ControlBox=false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRegistrujSe);
            Controls.Add(buttonOdustani);
            Controls.Add(buttonUlogujeSe);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxLozinka);
            Controls.Add(textBoxKorisnickoIme);
            FormBorderStyle=FormBorderStyle.None;
            Name="FormLogin";
            ShowIcon=false;
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxKorisnickoIme;
        private TextBox textBoxLozinka;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Button buttonUlogujeSe;
        private Button buttonOdustani;
        private Button buttonRegistrujSe;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}