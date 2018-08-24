namespace JiPP_MK
{
    partial class NowyUczen
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
            this.labelImie = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKlasa = new System.Windows.Forms.ComboBox();
            this.comboBoxPlec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.Location = new System.Drawing.Point(12, 9);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(100, 23);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imie";
            this.labelImie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(118, 12);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(110, 20);
            this.textBoxImie.TabIndex = 1;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(15, 126);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(213, 37);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj ucznia";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(118, 38);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(110, 20);
            this.textBoxNazwisko.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwisko";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Klasa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plec";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxKlasa
            // 
            this.comboBoxKlasa.FormattingEnabled = true;
            this.comboBoxKlasa.Items.AddRange(new object[] {
            "Pierwsza",
            "Druga",
            "Trzecia",
            "Czwarta",
            "Piata"});
            this.comboBoxKlasa.Location = new System.Drawing.Point(107, 91);
            this.comboBoxKlasa.Name = "comboBoxKlasa";
            this.comboBoxKlasa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKlasa.TabIndex = 8;
            // 
            // comboBoxPlec
            // 
            this.comboBoxPlec.FormattingEnabled = true;
            this.comboBoxPlec.Items.AddRange(new object[] {
            "Chlopiec",
            "Dziewczynka"});
            this.comboBoxPlec.Location = new System.Drawing.Point(107, 64);
            this.comboBoxPlec.Name = "comboBoxPlec";
            this.comboBoxPlec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlec.TabIndex = 9;
            // 
            // NowyUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 175);
            this.Controls.Add(this.comboBoxPlec);
            this.Controls.Add(this.comboBoxKlasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelImie);
            this.Name = "NowyUczen";
            this.Text = "NowyUczen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKlasa;
        private System.Windows.Forms.ComboBox comboBoxPlec;
    }
}