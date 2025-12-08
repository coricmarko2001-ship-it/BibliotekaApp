namespace Projekat_biblioteka
{
    partial class FormPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPocetna));
            menuStrip1=new MenuStrip();
            knjigeToolStripMenuItem=new ToolStripMenuItem();
            pogledajKnjiguToolStripMenuItem=new ToolStripMenuItem();
            korisnikToolStripMenuItem=new ToolStripMenuItem();
            pregledKorisnikaToolStripMenuItem=new ToolStripMenuItem();
            pregledBibliotekaraToolStripMenuItem=new ToolStripMenuItem();
            pregledBibliotekaraToolStripMenuItem1=new ToolStripMenuItem();
            autoriToolStripMenuItem=new ToolStripMenuItem();
            pregledAutoraToolStripMenuItem=new ToolStripMenuItem();
            izdavanjeToolStripMenuItem=new ToolStripMenuItem();
            pregledIzdatihKnjigaToolStripMenuItem=new ToolStripMenuItem();
            rezervisiKnjiguToolStripMenuItem=new ToolStripMenuItem();
            vratiKnjiguToolStripMenuItem=new ToolStripMenuItem();
            izdavačiToolStripMenuItem=new ToolStripMenuItem();
            pregledIzdavačaToolStripMenuItem=new ToolStripMenuItem();
            izadjiToolStripMenuItem=new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize=new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { knjigeToolStripMenuItem, korisnikToolStripMenuItem, pregledBibliotekaraToolStripMenuItem, autoriToolStripMenuItem, izdavanjeToolStripMenuItem, izdavačiToolStripMenuItem, izadjiToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(955, 69);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // knjigeToolStripMenuItem
            // 
            knjigeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pogledajKnjiguToolStripMenuItem });
            knjigeToolStripMenuItem.Image=(Image)resources.GetObject("knjigeToolStripMenuItem.Image");
            knjigeToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            knjigeToolStripMenuItem.Name="knjigeToolStripMenuItem";
            knjigeToolStripMenuItem.Size=new Size(130, 65);
            knjigeToolStripMenuItem.Text="Knjige";
            // 
            // pogledajKnjiguToolStripMenuItem
            // 
            pogledajKnjiguToolStripMenuItem.Image=(Image)resources.GetObject("pogledajKnjiguToolStripMenuItem.Image");
            pogledajKnjiguToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            pogledajKnjiguToolStripMenuItem.Name="pogledajKnjiguToolStripMenuItem";
            pogledajKnjiguToolStripMenuItem.Size=new Size(239, 68);
            pogledajKnjiguToolStripMenuItem.Text="Pogledaj Knjigu";
            pogledajKnjiguToolStripMenuItem.Click+=pogledajKnjiguToolStripMenuItem_Click;
            // 
            // korisnikToolStripMenuItem
            // 
            korisnikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pregledKorisnikaToolStripMenuItem });
            korisnikToolStripMenuItem.Image=(Image)resources.GetObject("korisnikToolStripMenuItem.Image");
            korisnikToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            korisnikToolStripMenuItem.Name="korisnikToolStripMenuItem";
            korisnikToolStripMenuItem.Size=new Size(138, 65);
            korisnikToolStripMenuItem.Text="Korisnik";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            pregledKorisnikaToolStripMenuItem.Image=(Image)resources.GetObject("pregledKorisnikaToolStripMenuItem.Image");
            pregledKorisnikaToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            pregledKorisnikaToolStripMenuItem.Name="pregledKorisnikaToolStripMenuItem";
            pregledKorisnikaToolStripMenuItem.Size=new Size(248, 68);
            pregledKorisnikaToolStripMenuItem.Text="Pregled Korisnika";
            pregledKorisnikaToolStripMenuItem.Click+=pregledKorisnikaToolStripMenuItem_Click;
            // 
            // pregledBibliotekaraToolStripMenuItem
            // 
            pregledBibliotekaraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pregledBibliotekaraToolStripMenuItem1 });
            pregledBibliotekaraToolStripMenuItem.Image=(Image)resources.GetObject("pregledBibliotekaraToolStripMenuItem.Image");
            pregledBibliotekaraToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            pregledBibliotekaraToolStripMenuItem.Name="pregledBibliotekaraToolStripMenuItem";
            pregledBibliotekaraToolStripMenuItem.Size=new Size(155, 65);
            pregledBibliotekaraToolStripMenuItem.Text="Bibliotekari";
            // 
            // pregledBibliotekaraToolStripMenuItem1
            // 
            pregledBibliotekaraToolStripMenuItem1.Image=(Image)resources.GetObject("pregledBibliotekaraToolStripMenuItem1.Image");
            pregledBibliotekaraToolStripMenuItem1.ImageScaling=ToolStripItemImageScaling.None;
            pregledBibliotekaraToolStripMenuItem1.Name="pregledBibliotekaraToolStripMenuItem1";
            pregledBibliotekaraToolStripMenuItem1.Size=new Size(268, 66);
            pregledBibliotekaraToolStripMenuItem1.Text="Pregled Bibliotekara";
            pregledBibliotekaraToolStripMenuItem1.Click+=pregledBibliotekaraToolStripMenuItem1_Click;
            // 
            // autoriToolStripMenuItem
            // 
            autoriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pregledAutoraToolStripMenuItem });
            autoriToolStripMenuItem.Image=(Image)resources.GetObject("autoriToolStripMenuItem.Image");
            autoriToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            autoriToolStripMenuItem.Name="autoriToolStripMenuItem";
            autoriToolStripMenuItem.Size=new Size(121, 65);
            autoriToolStripMenuItem.Text="Autori";
            // 
            // pregledAutoraToolStripMenuItem
            // 
            pregledAutoraToolStripMenuItem.Image=(Image)resources.GetObject("pregledAutoraToolStripMenuItem.Image");
            pregledAutoraToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            pregledAutoraToolStripMenuItem.Name="pregledAutoraToolStripMenuItem";
            pregledAutoraToolStripMenuItem.Size=new Size(237, 68);
            pregledAutoraToolStripMenuItem.Text="Pregled Autora";
            pregledAutoraToolStripMenuItem.Click+=pregledAutoraToolStripMenuItem_Click;
            // 
            // izdavanjeToolStripMenuItem
            // 
            izdavanjeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pregledIzdatihKnjigaToolStripMenuItem, rezervisiKnjiguToolStripMenuItem, vratiKnjiguToolStripMenuItem });
            izdavanjeToolStripMenuItem.Image=(Image)resources.GetObject("izdavanjeToolStripMenuItem.Image");
            izdavanjeToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            izdavanjeToolStripMenuItem.Name="izdavanjeToolStripMenuItem";
            izdavanjeToolStripMenuItem.Size=new Size(139, 65);
            izdavanjeToolStripMenuItem.Text="Izdavanje";
            // 
            // pregledIzdatihKnjigaToolStripMenuItem
            // 
            pregledIzdatihKnjigaToolStripMenuItem.Image=(Image)resources.GetObject("pregledIzdatihKnjigaToolStripMenuItem.Image");
            pregledIzdatihKnjigaToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            pregledIzdatihKnjigaToolStripMenuItem.Name="pregledIzdatihKnjigaToolStripMenuItem";
            pregledIzdatihKnjigaToolStripMenuItem.Size=new Size(275, 66);
            pregledIzdatihKnjigaToolStripMenuItem.Text="Pregled izdatih knjiga";
            pregledIzdatihKnjigaToolStripMenuItem.Click+=pregledIzdatihKnjigaToolStripMenuItem_Click;
            // 
            // rezervisiKnjiguToolStripMenuItem
            // 
            rezervisiKnjiguToolStripMenuItem.Image=(Image)resources.GetObject("rezervisiKnjiguToolStripMenuItem.Image");
            rezervisiKnjiguToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            rezervisiKnjiguToolStripMenuItem.Name="rezervisiKnjiguToolStripMenuItem";
            rezervisiKnjiguToolStripMenuItem.Size=new Size(275, 66);
            rezervisiKnjiguToolStripMenuItem.Text="Rezervisi Knjigu";
            rezervisiKnjiguToolStripMenuItem.Click+=rezervisiKnjiguToolStripMenuItem_Click;
            // 
            // vratiKnjiguToolStripMenuItem
            // 
            vratiKnjiguToolStripMenuItem.Image=(Image)resources.GetObject("vratiKnjiguToolStripMenuItem.Image");
            vratiKnjiguToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            vratiKnjiguToolStripMenuItem.Name="vratiKnjiguToolStripMenuItem";
            vratiKnjiguToolStripMenuItem.Size=new Size(275, 66);
            vratiKnjiguToolStripMenuItem.Text="Vrati Knjigu";
            vratiKnjiguToolStripMenuItem.Click+=vratiKnjiguToolStripMenuItem_Click;
            // 
            // izdavačiToolStripMenuItem
            // 
            izdavačiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pregledIzdavačaToolStripMenuItem });
            izdavačiToolStripMenuItem.Image=(Image)resources.GetObject("izdavačiToolStripMenuItem.Image");
            izdavačiToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            izdavačiToolStripMenuItem.Name="izdavačiToolStripMenuItem";
            izdavačiToolStripMenuItem.Size=new Size(140, 65);
            izdavačiToolStripMenuItem.Text="Izdavači";
            // 
            // pregledIzdavačaToolStripMenuItem
            // 
            pregledIzdavačaToolStripMenuItem.Image=(Image)resources.GetObject("pregledIzdavačaToolStripMenuItem.Image");
            pregledIzdavačaToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            pregledIzdavačaToolStripMenuItem.Name="pregledIzdavačaToolStripMenuItem";
            pregledIzdavačaToolStripMenuItem.Size=new Size(264, 62);
            pregledIzdavačaToolStripMenuItem.Text="Pregled Izdavača";
            pregledIzdavačaToolStripMenuItem.Click+=pregledIzdavačaToolStripMenuItem_Click;
            // 
            // izadjiToolStripMenuItem
            // 
            izadjiToolStripMenuItem.Image=(Image)resources.GetObject("izadjiToolStripMenuItem.Image");
            izadjiToolStripMenuItem.ImageScaling=ToolStripItemImageScaling.None;
            izadjiToolStripMenuItem.Name="izadjiToolStripMenuItem";
            izadjiToolStripMenuItem.Size=new Size(112, 65);
            izadjiToolStripMenuItem.Text="Izadji";
            izadjiToolStripMenuItem.Click+=izadjiToolStripMenuItem_Click;
            // 
            // FormPocetna
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout=ImageLayout.Stretch;
            ClientSize=new Size(955, 401);
            Controls.Add(menuStrip1);
            FormBorderStyle=FormBorderStyle.None;
            MainMenuStrip=menuStrip1;
            Name="FormPocetna";
            StartPosition=FormStartPosition.CenterScreen;
            Text="FormPocetna";
            WindowState=FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem knjigeToolStripMenuItem;
        private ToolStripMenuItem pogledajKnjiguToolStripMenuItem;
        private ToolStripMenuItem korisnikToolStripMenuItem;
        private ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private ToolStripMenuItem autoriToolStripMenuItem;
        private ToolStripMenuItem pregledAutoraToolStripMenuItem;
        private ToolStripMenuItem izdavanjeToolStripMenuItem;
        private ToolStripMenuItem rezervisiKnjiguToolStripMenuItem;
        private ToolStripMenuItem vratiKnjiguToolStripMenuItem;
        private ToolStripMenuItem izadjiToolStripMenuItem;
        private ToolStripMenuItem pregledIzdatihKnjigaToolStripMenuItem;
        private ToolStripMenuItem pregledBibliotekaraToolStripMenuItem;
        private ToolStripMenuItem pregledBibliotekaraToolStripMenuItem1;
        private ToolStripMenuItem izdavačiToolStripMenuItem;
        private ToolStripMenuItem pregledIzdavačaToolStripMenuItem;
    }
}