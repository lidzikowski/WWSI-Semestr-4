namespace JiPP_MK
{
    partial class Szkola
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
            this.components = new System.ComponentModel.Container();
            this.listBoxUczniowie = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEmocje = new System.Windows.Forms.Panel();
            this.buttonDodajUcznia = new System.Windows.Forms.Button();
            this.buttonUsunUcznia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFrekwencja = new System.Windows.Forms.Label();
            this.labelUcieczki = new System.Windows.Forms.Label();
            this.labelOdbytychZajec = new System.Windows.Forms.Label();
            this.labelKlasa = new System.Windows.Forms.Label();
            this.labelPlec = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.textBoxKonsola = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1Frekwencja = new System.Windows.Forms.Label();
            this.label1Ucieklo = new System.Windows.Forms.Label();
            this.label1Uczniow = new System.Windows.Forms.Label();
            this.listBoxPierwsza = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2Frelwemcja = new System.Windows.Forms.Label();
            this.label2Ucieklo = new System.Windows.Forms.Label();
            this.label2Uczniow = new System.Windows.Forms.Label();
            this.listBoxDruga = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3Frekwencja = new System.Windows.Forms.Label();
            this.label3Ucieklo = new System.Windows.Forms.Label();
            this.label3Uczniow = new System.Windows.Forms.Label();
            this.listBoxTrzecia = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4Frekwencja = new System.Windows.Forms.Label();
            this.label4Ucieklo = new System.Windows.Forms.Label();
            this.label4Uczniow = new System.Windows.Forms.Label();
            this.listBoxCzwarta = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5Frekwencja = new System.Windows.Forms.Label();
            this.label5Ucieklo = new System.Windows.Forms.Label();
            this.label5Uczniow = new System.Windows.Forms.Label();
            this.listBoxPiata = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUczniowie
            // 
            this.listBoxUczniowie.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxUczniowie.FormattingEnabled = true;
            this.listBoxUczniowie.Location = new System.Drawing.Point(0, 0);
            this.listBoxUczniowie.Name = "listBoxUczniowie";
            this.listBoxUczniowie.Size = new System.Drawing.Size(252, 329);
            this.listBoxUczniowie.TabIndex = 0;
            this.listBoxUczniowie.SelectedIndexChanged += new System.EventHandler(this.listBoxUczniowie_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelEmocje);
            this.panel1.Controls.Add(this.buttonDodajUcznia);
            this.panel1.Controls.Add(this.buttonUsunUcznia);
            this.panel1.Controls.Add(this.listBoxUczniowie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 514);
            this.panel1.TabIndex = 1;
            // 
            // panelEmocje
            // 
            this.panelEmocje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmocje.Location = new System.Drawing.Point(0, 329);
            this.panelEmocje.Name = "panelEmocje";
            this.panelEmocje.Size = new System.Drawing.Size(252, 103);
            this.panelEmocje.TabIndex = 3;
            this.panelEmocje.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmocje_Paint);
            this.panelEmocje.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEmocje_MouseDown);
            this.panelEmocje.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEmocje_MouseMove);
            // 
            // buttonDodajUcznia
            // 
            this.buttonDodajUcznia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDodajUcznia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajUcznia.Location = new System.Drawing.Point(0, 432);
            this.buttonDodajUcznia.Name = "buttonDodajUcznia";
            this.buttonDodajUcznia.Size = new System.Drawing.Size(252, 41);
            this.buttonDodajUcznia.TabIndex = 2;
            this.buttonDodajUcznia.Text = "Dodaj ucznia";
            this.buttonDodajUcznia.UseVisualStyleBackColor = true;
            this.buttonDodajUcznia.Click += new System.EventHandler(this.buttonDodajUcznia_Click);
            // 
            // buttonUsunUcznia
            // 
            this.buttonUsunUcznia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUsunUcznia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsunUcznia.Location = new System.Drawing.Point(0, 473);
            this.buttonUsunUcznia.Name = "buttonUsunUcznia";
            this.buttonUsunUcznia.Size = new System.Drawing.Size(252, 41);
            this.buttonUsunUcznia.TabIndex = 1;
            this.buttonUsunUcznia.Text = "Usuń ucznia";
            this.buttonUsunUcznia.UseVisualStyleBackColor = true;
            this.buttonUsunUcznia.Click += new System.EventHandler(this.buttonUsunUcznia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFrekwencja);
            this.groupBox1.Controls.Add(this.labelUcieczki);
            this.groupBox1.Controls.Add(this.labelOdbytychZajec);
            this.groupBox1.Controls.Add(this.labelKlasa);
            this.groupBox1.Controls.Add(this.labelPlec);
            this.groupBox1.Controls.Add(this.labelNazwisko);
            this.groupBox1.Controls.Add(this.labelImie);
            this.groupBox1.Controls.Add(this.textBoxKonsola);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(252, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacje o uczniu";
            // 
            // labelFrekwencja
            // 
            this.labelFrekwencja.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFrekwencja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrekwencja.Location = new System.Drawing.Point(3, 160);
            this.labelFrekwencja.Name = "labelFrekwencja";
            this.labelFrekwencja.Size = new System.Drawing.Size(251, 24);
            this.labelFrekwencja.TabIndex = 7;
            this.labelFrekwencja.Text = "Frekwencja: ";
            this.labelFrekwencja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUcieczki
            // 
            this.labelUcieczki.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUcieczki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUcieczki.Location = new System.Drawing.Point(3, 136);
            this.labelUcieczki.Name = "labelUcieczki";
            this.labelUcieczki.Size = new System.Drawing.Size(251, 24);
            this.labelUcieczki.TabIndex = 6;
            this.labelUcieczki.Text = "Ucieczki: ";
            this.labelUcieczki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOdbytychZajec
            // 
            this.labelOdbytychZajec.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOdbytychZajec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOdbytychZajec.Location = new System.Drawing.Point(3, 112);
            this.labelOdbytychZajec.Name = "labelOdbytychZajec";
            this.labelOdbytychZajec.Size = new System.Drawing.Size(251, 24);
            this.labelOdbytychZajec.TabIndex = 5;
            this.labelOdbytychZajec.Text = "Odbytych zajec: ";
            this.labelOdbytychZajec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKlasa
            // 
            this.labelKlasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelKlasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKlasa.Location = new System.Drawing.Point(3, 88);
            this.labelKlasa.Name = "labelKlasa";
            this.labelKlasa.Size = new System.Drawing.Size(251, 24);
            this.labelKlasa.TabIndex = 4;
            this.labelKlasa.Text = "Klasa:";
            this.labelKlasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPlec
            // 
            this.labelPlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlec.Location = new System.Drawing.Point(3, 64);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(251, 24);
            this.labelPlec.TabIndex = 3;
            this.labelPlec.Text = "Plec: ";
            this.labelPlec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazwisko.Location = new System.Drawing.Point(3, 40);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(251, 24);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "Nazwisko: ";
            this.labelNazwisko.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelImie
            // 
            this.labelImie.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImie.Location = new System.Drawing.Point(3, 16);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(251, 24);
            this.labelImie.TabIndex = 1;
            this.labelImie.Text = "Imie: ";
            this.labelImie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxKonsola
            // 
            this.textBoxKonsola.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxKonsola.Location = new System.Drawing.Point(254, 16);
            this.textBoxKonsola.Multiline = true;
            this.textBoxKonsola.Name = "textBoxKonsola";
            this.textBoxKonsola.ReadOnly = true;
            this.textBoxKonsola.Size = new System.Drawing.Size(379, 168);
            this.textBoxKonsola.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1Frekwencja);
            this.groupBox2.Controls.Add(this.label1Ucieklo);
            this.groupBox2.Controls.Add(this.label1Uczniow);
            this.groupBox2.Controls.Add(this.listBoxPierwsza);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(252, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 327);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pierwsza";
            // 
            // label1Frekwencja
            // 
            this.label1Frekwencja.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1Frekwencja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Frekwencja.Location = new System.Drawing.Point(3, 279);
            this.label1Frekwencja.Name = "label1Frekwencja";
            this.label1Frekwencja.Size = new System.Drawing.Size(121, 45);
            this.label1Frekwencja.TabIndex = 2;
            this.label1Frekwencja.Text = "Frekwencja: ";
            this.label1Frekwencja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1Ucieklo
            // 
            this.label1Ucieklo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1Ucieklo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Ucieklo.Location = new System.Drawing.Point(3, 234);
            this.label1Ucieklo.Name = "label1Ucieklo";
            this.label1Ucieklo.Size = new System.Drawing.Size(121, 45);
            this.label1Ucieklo.TabIndex = 1;
            this.label1Ucieklo.Text = "Ucieklo:";
            this.label1Ucieklo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1Uczniow
            // 
            this.label1Uczniow.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1Uczniow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Uczniow.Location = new System.Drawing.Point(3, 189);
            this.label1Uczniow.Name = "label1Uczniow";
            this.label1Uczniow.Size = new System.Drawing.Size(121, 45);
            this.label1Uczniow.TabIndex = 0;
            this.label1Uczniow.Text = "Uczniow:";
            this.label1Uczniow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxPierwsza
            // 
            this.listBoxPierwsza.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxPierwsza.FormattingEnabled = true;
            this.listBoxPierwsza.Location = new System.Drawing.Point(3, 16);
            this.listBoxPierwsza.Name = "listBoxPierwsza";
            this.listBoxPierwsza.Size = new System.Drawing.Size(121, 173);
            this.listBoxPierwsza.Sorted = true;
            this.listBoxPierwsza.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2Frelwemcja);
            this.groupBox3.Controls.Add(this.label2Ucieklo);
            this.groupBox3.Controls.Add(this.label2Uczniow);
            this.groupBox3.Controls.Add(this.listBoxDruga);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(379, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 327);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Druga";
            // 
            // label2Frelwemcja
            // 
            this.label2Frelwemcja.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2Frelwemcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Frelwemcja.Location = new System.Drawing.Point(3, 279);
            this.label2Frelwemcja.Name = "label2Frelwemcja";
            this.label2Frelwemcja.Size = new System.Drawing.Size(121, 45);
            this.label2Frelwemcja.TabIndex = 5;
            this.label2Frelwemcja.Text = "Frekwencja: ";
            this.label2Frelwemcja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2Ucieklo
            // 
            this.label2Ucieklo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2Ucieklo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Ucieklo.Location = new System.Drawing.Point(3, 234);
            this.label2Ucieklo.Name = "label2Ucieklo";
            this.label2Ucieklo.Size = new System.Drawing.Size(121, 45);
            this.label2Ucieklo.TabIndex = 4;
            this.label2Ucieklo.Text = "Ucieklo:";
            this.label2Ucieklo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2Uczniow
            // 
            this.label2Uczniow.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2Uczniow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Uczniow.Location = new System.Drawing.Point(3, 189);
            this.label2Uczniow.Name = "label2Uczniow";
            this.label2Uczniow.Size = new System.Drawing.Size(121, 45);
            this.label2Uczniow.TabIndex = 3;
            this.label2Uczniow.Text = "Uczniow:";
            this.label2Uczniow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxDruga
            // 
            this.listBoxDruga.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxDruga.FormattingEnabled = true;
            this.listBoxDruga.Location = new System.Drawing.Point(3, 16);
            this.listBoxDruga.Name = "listBoxDruga";
            this.listBoxDruga.Size = new System.Drawing.Size(121, 173);
            this.listBoxDruga.Sorted = true;
            this.listBoxDruga.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3Frekwencja);
            this.groupBox4.Controls.Add(this.label3Ucieklo);
            this.groupBox4.Controls.Add(this.label3Uczniow);
            this.groupBox4.Controls.Add(this.listBoxTrzecia);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(506, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 327);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trzecia";
            // 
            // label3Frekwencja
            // 
            this.label3Frekwencja.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3Frekwencja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Frekwencja.Location = new System.Drawing.Point(3, 279);
            this.label3Frekwencja.Name = "label3Frekwencja";
            this.label3Frekwencja.Size = new System.Drawing.Size(121, 45);
            this.label3Frekwencja.TabIndex = 5;
            this.label3Frekwencja.Text = "Frekwencja: ";
            this.label3Frekwencja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3Ucieklo
            // 
            this.label3Ucieklo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3Ucieklo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Ucieklo.Location = new System.Drawing.Point(3, 234);
            this.label3Ucieklo.Name = "label3Ucieklo";
            this.label3Ucieklo.Size = new System.Drawing.Size(121, 45);
            this.label3Ucieklo.TabIndex = 4;
            this.label3Ucieklo.Text = "Ucieklo:";
            this.label3Ucieklo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3Uczniow
            // 
            this.label3Uczniow.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3Uczniow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Uczniow.Location = new System.Drawing.Point(3, 189);
            this.label3Uczniow.Name = "label3Uczniow";
            this.label3Uczniow.Size = new System.Drawing.Size(121, 45);
            this.label3Uczniow.TabIndex = 3;
            this.label3Uczniow.Text = "Uczniow:";
            this.label3Uczniow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxTrzecia
            // 
            this.listBoxTrzecia.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxTrzecia.FormattingEnabled = true;
            this.listBoxTrzecia.Location = new System.Drawing.Point(3, 16);
            this.listBoxTrzecia.Name = "listBoxTrzecia";
            this.listBoxTrzecia.Size = new System.Drawing.Size(121, 173);
            this.listBoxTrzecia.Sorted = true;
            this.listBoxTrzecia.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4Frekwencja);
            this.groupBox5.Controls.Add(this.label4Ucieklo);
            this.groupBox5.Controls.Add(this.label4Uczniow);
            this.groupBox5.Controls.Add(this.listBoxCzwarta);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(633, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 327);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Czwarta";
            // 
            // label4Frekwencja
            // 
            this.label4Frekwencja.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4Frekwencja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Frekwencja.Location = new System.Drawing.Point(3, 279);
            this.label4Frekwencja.Name = "label4Frekwencja";
            this.label4Frekwencja.Size = new System.Drawing.Size(121, 45);
            this.label4Frekwencja.TabIndex = 5;
            this.label4Frekwencja.Text = "Frekwencja: ";
            this.label4Frekwencja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4Ucieklo
            // 
            this.label4Ucieklo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4Ucieklo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Ucieklo.Location = new System.Drawing.Point(3, 234);
            this.label4Ucieklo.Name = "label4Ucieklo";
            this.label4Ucieklo.Size = new System.Drawing.Size(121, 45);
            this.label4Ucieklo.TabIndex = 4;
            this.label4Ucieklo.Text = "Ucieklo:";
            this.label4Ucieklo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4Uczniow
            // 
            this.label4Uczniow.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4Uczniow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Uczniow.Location = new System.Drawing.Point(3, 189);
            this.label4Uczniow.Name = "label4Uczniow";
            this.label4Uczniow.Size = new System.Drawing.Size(121, 45);
            this.label4Uczniow.TabIndex = 3;
            this.label4Uczniow.Text = "Uczniow:";
            this.label4Uczniow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxCzwarta
            // 
            this.listBoxCzwarta.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxCzwarta.FormattingEnabled = true;
            this.listBoxCzwarta.Location = new System.Drawing.Point(3, 16);
            this.listBoxCzwarta.Name = "listBoxCzwarta";
            this.listBoxCzwarta.Size = new System.Drawing.Size(121, 173);
            this.listBoxCzwarta.Sorted = true;
            this.listBoxCzwarta.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5Frekwencja);
            this.groupBox6.Controls.Add(this.label5Ucieklo);
            this.groupBox6.Controls.Add(this.label5Uczniow);
            this.groupBox6.Controls.Add(this.listBoxPiata);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(760, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(127, 327);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Piata";
            // 
            // label5Frekwencja
            // 
            this.label5Frekwencja.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5Frekwencja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Frekwencja.Location = new System.Drawing.Point(3, 279);
            this.label5Frekwencja.Name = "label5Frekwencja";
            this.label5Frekwencja.Size = new System.Drawing.Size(121, 45);
            this.label5Frekwencja.TabIndex = 5;
            this.label5Frekwencja.Text = "Frekwencja: ";
            this.label5Frekwencja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5Ucieklo
            // 
            this.label5Ucieklo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5Ucieklo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Ucieklo.Location = new System.Drawing.Point(3, 234);
            this.label5Ucieklo.Name = "label5Ucieklo";
            this.label5Ucieklo.Size = new System.Drawing.Size(121, 45);
            this.label5Ucieklo.TabIndex = 4;
            this.label5Ucieklo.Text = "Ucieklo:";
            this.label5Ucieklo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5Uczniow
            // 
            this.label5Uczniow.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5Uczniow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Uczniow.Location = new System.Drawing.Point(3, 189);
            this.label5Uczniow.Name = "label5Uczniow";
            this.label5Uczniow.Size = new System.Drawing.Size(121, 45);
            this.label5Uczniow.TabIndex = 3;
            this.label5Uczniow.Text = "Uczniow:";
            this.label5Uczniow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxPiata
            // 
            this.listBoxPiata.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxPiata.FormattingEnabled = true;
            this.listBoxPiata.Location = new System.Drawing.Point(3, 16);
            this.listBoxPiata.Name = "listBoxPiata";
            this.listBoxPiata.Size = new System.Drawing.Size(121, 173);
            this.listBoxPiata.Sorted = true;
            this.listBoxPiata.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Szkola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 514);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Szkola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szkola";
            this.Load += new System.EventHandler(this.Szkola_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUczniowie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDodajUcznia;
        private System.Windows.Forms.Button buttonUsunUcznia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1Frekwencja;
        private System.Windows.Forms.Label label1Ucieklo;
        private System.Windows.Forms.Label label1Uczniow;
        private System.Windows.Forms.ListBox listBoxPierwsza;
        private System.Windows.Forms.Label label2Frelwemcja;
        private System.Windows.Forms.Label label2Ucieklo;
        private System.Windows.Forms.Label label2Uczniow;
        private System.Windows.Forms.ListBox listBoxDruga;
        private System.Windows.Forms.Label label3Frekwencja;
        private System.Windows.Forms.Label label3Ucieklo;
        private System.Windows.Forms.Label label3Uczniow;
        private System.Windows.Forms.ListBox listBoxTrzecia;
        private System.Windows.Forms.Label label4Frekwencja;
        private System.Windows.Forms.Label label4Ucieklo;
        private System.Windows.Forms.Label label4Uczniow;
        private System.Windows.Forms.ListBox listBoxCzwarta;
        private System.Windows.Forms.Label label5Frekwencja;
        private System.Windows.Forms.Label label5Ucieklo;
        private System.Windows.Forms.Label label5Uczniow;
        private System.Windows.Forms.ListBox listBoxPiata;
        private System.Windows.Forms.TextBox textBoxKonsola;
        private System.Windows.Forms.Label labelFrekwencja;
        private System.Windows.Forms.Label labelUcieczki;
        private System.Windows.Forms.Label labelOdbytychZajec;
        private System.Windows.Forms.Label labelKlasa;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelPlec;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelEmocje;
    }
}

