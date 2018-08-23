namespace JiPP_LS
{
    partial class Menedzer
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
            this.groupBoxPracownicy = new System.Windows.Forms.GroupBox();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.listBoxPracownicy = new System.Windows.Forms.ListBox();
            this.groupBoxPracownik = new System.Windows.Forms.GroupBox();
            this.labelGotowka = new System.Windows.Forms.Label();
            this.labelZarobki = new System.Windows.Forms.Label();
            this.labelTypPracownika = new System.Windows.Forms.Label();
            this.labelWiek = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPracownicy.SuspendLayout();
            this.groupBoxPracownik.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPracownicy
            // 
            this.groupBoxPracownicy.Controls.Add(this.buttonEdytuj);
            this.groupBoxPracownicy.Controls.Add(this.buttonUsun);
            this.groupBoxPracownicy.Controls.Add(this.buttonDodaj);
            this.groupBoxPracownicy.Controls.Add(this.listBoxPracownicy);
            this.groupBoxPracownicy.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPracownicy.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPracownicy.Name = "groupBoxPracownicy";
            this.groupBoxPracownicy.Size = new System.Drawing.Size(200, 561);
            this.groupBoxPracownicy.TabIndex = 0;
            this.groupBoxPracownicy.TabStop = false;
            this.groupBoxPracownicy.Text = "Pracownicy";
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdytuj.Location = new System.Drawing.Point(3, 468);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(194, 30);
            this.buttonEdytuj.TabIndex = 3;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsun.Location = new System.Drawing.Point(3, 498);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(194, 30);
            this.buttonUsun.TabIndex = 2;
            this.buttonUsun.Text = "Usun";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(3, 528);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(194, 30);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // listBoxPracownicy
            // 
            this.listBoxPracownicy.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxPracownicy.FormattingEnabled = true;
            this.listBoxPracownicy.Location = new System.Drawing.Point(3, 16);
            this.listBoxPracownicy.Name = "listBoxPracownicy";
            this.listBoxPracownicy.Size = new System.Drawing.Size(194, 446);
            this.listBoxPracownicy.TabIndex = 0;
            this.listBoxPracownicy.SelectedIndexChanged += new System.EventHandler(this.listBoxPracownicy_SelectedIndexChanged);
            // 
            // groupBoxPracownik
            // 
            this.groupBoxPracownik.Controls.Add(this.labelGotowka);
            this.groupBoxPracownik.Controls.Add(this.labelZarobki);
            this.groupBoxPracownik.Controls.Add(this.labelTypPracownika);
            this.groupBoxPracownik.Controls.Add(this.labelWiek);
            this.groupBoxPracownik.Controls.Add(this.labelNazwisko);
            this.groupBoxPracownik.Controls.Add(this.labelImie);
            this.groupBoxPracownik.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPracownik.Location = new System.Drawing.Point(200, 0);
            this.groupBoxPracownik.Name = "groupBoxPracownik";
            this.groupBoxPracownik.Size = new System.Drawing.Size(584, 90);
            this.groupBoxPracownik.TabIndex = 1;
            this.groupBoxPracownik.TabStop = false;
            this.groupBoxPracownik.Text = "Pracownik {0}";
            // 
            // labelGotowka
            // 
            this.labelGotowka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGotowka.Location = new System.Drawing.Point(276, 62);
            this.labelGotowka.Name = "labelGotowka";
            this.labelGotowka.Size = new System.Drawing.Size(296, 23);
            this.labelGotowka.TabIndex = 5;
            this.labelGotowka.Text = "Gotowka: {0}";
            this.labelGotowka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelZarobki
            // 
            this.labelZarobki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZarobki.Location = new System.Drawing.Point(276, 39);
            this.labelZarobki.Name = "labelZarobki";
            this.labelZarobki.Size = new System.Drawing.Size(296, 23);
            this.labelZarobki.TabIndex = 4;
            this.labelZarobki.Text = "Zarobki: {0}";
            this.labelZarobki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTypPracownika
            // 
            this.labelTypPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypPracownika.Location = new System.Drawing.Point(276, 16);
            this.labelTypPracownika.Name = "labelTypPracownika";
            this.labelTypPracownika.Size = new System.Drawing.Size(296, 23);
            this.labelTypPracownika.TabIndex = 3;
            this.labelTypPracownika.Text = "Typ Pracownika: {0}";
            this.labelTypPracownika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWiek
            // 
            this.labelWiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWiek.Location = new System.Drawing.Point(6, 62);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(264, 23);
            this.labelWiek.TabIndex = 2;
            this.labelWiek.Text = "Wiek: {0}";
            this.labelWiek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazwisko.Location = new System.Drawing.Point(6, 39);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(264, 23);
            this.labelNazwisko.TabIndex = 1;
            this.labelNazwisko.Text = "Nazwisko: {0}";
            this.labelNazwisko.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelImie
            // 
            this.labelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImie.Location = new System.Drawing.Point(6, 16);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(264, 23);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imie: {0}";
            this.labelImie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 471);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Menedzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxPracownik);
            this.Controls.Add(this.groupBoxPracownicy);
            this.Name = "Menedzer";
            this.Text = "Menedzer";
            this.Load += new System.EventHandler(this.Menedzer_Load);
            this.groupBoxPracownicy.ResumeLayout(false);
            this.groupBoxPracownik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPracownicy;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.ListBox listBoxPracownicy;
        private System.Windows.Forms.GroupBox groupBoxPracownik;
        private System.Windows.Forms.Label labelZarobki;
        private System.Windows.Forms.Label labelTypPracownika;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelGotowka;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
    }
}