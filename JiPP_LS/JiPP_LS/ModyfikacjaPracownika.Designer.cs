namespace JiPP_LS
{
    partial class ModyfikacjaPracownika
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
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.labelWiek = new System.Windows.Forms.Label();
            this.buttonLosujWiek = new System.Windows.Forms.Button();
            this.buttonOperacja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImie.Location = new System.Drawing.Point(12, 13);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(100, 20);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imie";
            this.labelImie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(118, 12);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(154, 20);
            this.textBoxImie.TabIndex = 1;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(118, 38);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(154, 20);
            this.textBoxNazwisko.TabIndex = 3;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazwisko.Location = new System.Drawing.Point(12, 38);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(100, 20);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "Nazwisko";
            this.labelNazwisko.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(118, 64);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(83, 20);
            this.textBoxWiek.TabIndex = 5;
            // 
            // labelWiek
            // 
            this.labelWiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWiek.Location = new System.Drawing.Point(12, 64);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(100, 20);
            this.labelWiek.TabIndex = 4;
            this.labelWiek.Text = "Wiek";
            this.labelWiek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonLosujWiek
            // 
            this.buttonLosujWiek.Location = new System.Drawing.Point(207, 62);
            this.buttonLosujWiek.Name = "buttonLosujWiek";
            this.buttonLosujWiek.Size = new System.Drawing.Size(65, 24);
            this.buttonLosujWiek.TabIndex = 6;
            this.buttonLosujWiek.Text = "Losuj wiek";
            this.buttonLosujWiek.UseVisualStyleBackColor = true;
            this.buttonLosujWiek.Click += new System.EventHandler(this.buttonLosujWiek_Click);
            // 
            // buttonOperacja
            // 
            this.buttonOperacja.Location = new System.Drawing.Point(118, 90);
            this.buttonOperacja.Name = "buttonOperacja";
            this.buttonOperacja.Size = new System.Drawing.Size(154, 29);
            this.buttonOperacja.TabIndex = 7;
            this.buttonOperacja.Text = "Operacja";
            this.buttonOperacja.UseVisualStyleBackColor = true;
            // 
            // ModyfikacjaPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.buttonOperacja);
            this.Controls.Add(this.buttonLosujWiek);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelImie);
            this.Name = "ModyfikacjaPracownika";
            this.Text = "DodajPracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.Button buttonLosujWiek;
        private System.Windows.Forms.Button buttonOperacja;
    }
}