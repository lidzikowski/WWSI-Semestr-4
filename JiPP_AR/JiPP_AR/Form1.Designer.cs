namespace JiPP_AR
{
    partial class Form1
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
            this.groupBoxGracz1 = new System.Windows.Forms.GroupBox();
            this.buttonGracz1 = new System.Windows.Forms.Button();
            this.textBoxImie1 = new System.Windows.Forms.TextBox();
            this.labelImie1 = new System.Windows.Forms.Label();
            this.groupBoxGracz2 = new System.Windows.Forms.GroupBox();
            this.buttonGracz2 = new System.Windows.Forms.Button();
            this.textBoxImie2 = new System.Windows.Forms.TextBox();
            this.labelImie2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxGracz1.SuspendLayout();
            this.groupBoxGracz2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGracz1
            // 
            this.groupBoxGracz1.Controls.Add(this.buttonGracz1);
            this.groupBoxGracz1.Controls.Add(this.textBoxImie1);
            this.groupBoxGracz1.Controls.Add(this.labelImie1);
            this.groupBoxGracz1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGracz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGracz1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGracz1.Name = "groupBoxGracz1";
            this.groupBoxGracz1.Size = new System.Drawing.Size(380, 87);
            this.groupBoxGracz1.TabIndex = 7;
            this.groupBoxGracz1.TabStop = false;
            this.groupBoxGracz1.Text = "Gracz 1";
            // 
            // buttonGracz1
            // 
            this.buttonGracz1.Location = new System.Drawing.Point(255, 25);
            this.buttonGracz1.Name = "buttonGracz1";
            this.buttonGracz1.Size = new System.Drawing.Size(100, 34);
            this.buttonGracz1.TabIndex = 2;
            this.buttonGracz1.Text = "Dolacz";
            this.buttonGracz1.UseVisualStyleBackColor = true;
            this.buttonGracz1.Click += new System.EventHandler(this.buttonGracz1_Click);
            // 
            // textBoxImie1
            // 
            this.textBoxImie1.Location = new System.Drawing.Point(58, 29);
            this.textBoxImie1.Name = "textBoxImie1";
            this.textBoxImie1.Size = new System.Drawing.Size(191, 26);
            this.textBoxImie1.TabIndex = 1;
            // 
            // labelImie1
            // 
            this.labelImie1.AutoSize = true;
            this.labelImie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImie1.Location = new System.Drawing.Point(9, 29);
            this.labelImie1.Name = "labelImie1";
            this.labelImie1.Size = new System.Drawing.Size(43, 20);
            this.labelImie1.TabIndex = 0;
            this.labelImie1.Text = "Imie:";
            this.labelImie1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxGracz2
            // 
            this.groupBoxGracz2.Controls.Add(this.buttonGracz2);
            this.groupBoxGracz2.Controls.Add(this.textBoxImie2);
            this.groupBoxGracz2.Controls.Add(this.labelImie2);
            this.groupBoxGracz2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGracz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGracz2.Location = new System.Drawing.Point(0, 87);
            this.groupBoxGracz2.Name = "groupBoxGracz2";
            this.groupBoxGracz2.Size = new System.Drawing.Size(380, 87);
            this.groupBoxGracz2.TabIndex = 8;
            this.groupBoxGracz2.TabStop = false;
            this.groupBoxGracz2.Text = "Gracz 2";
            // 
            // buttonGracz2
            // 
            this.buttonGracz2.Location = new System.Drawing.Point(255, 25);
            this.buttonGracz2.Name = "buttonGracz2";
            this.buttonGracz2.Size = new System.Drawing.Size(100, 34);
            this.buttonGracz2.TabIndex = 2;
            this.buttonGracz2.Text = "Dolacz";
            this.buttonGracz2.UseVisualStyleBackColor = true;
            this.buttonGracz2.Click += new System.EventHandler(this.buttonGracz2_Click);
            // 
            // textBoxImie2
            // 
            this.textBoxImie2.Location = new System.Drawing.Point(58, 29);
            this.textBoxImie2.Name = "textBoxImie2";
            this.textBoxImie2.Size = new System.Drawing.Size(191, 26);
            this.textBoxImie2.TabIndex = 1;
            // 
            // labelImie2
            // 
            this.labelImie2.AutoSize = true;
            this.labelImie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImie2.Location = new System.Drawing.Point(9, 29);
            this.labelImie2.Name = "labelImie2";
            this.labelImie2.Size = new System.Drawing.Size(43, 20);
            this.labelImie2.TabIndex = 0;
            this.labelImie2.Text = "Imie:";
            this.labelImie2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(380, 148);
            this.textBox1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 322);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxGracz2);
            this.Controls.Add(this.groupBoxGracz1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxGracz1.ResumeLayout(false);
            this.groupBoxGracz1.PerformLayout();
            this.groupBoxGracz2.ResumeLayout(false);
            this.groupBoxGracz2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGracz1;
        private System.Windows.Forms.Button buttonGracz1;
        private System.Windows.Forms.TextBox textBoxImie1;
        private System.Windows.Forms.Label labelImie1;
        private System.Windows.Forms.GroupBox groupBoxGracz2;
        private System.Windows.Forms.Button buttonGracz2;
        private System.Windows.Forms.TextBox textBoxImie2;
        private System.Windows.Forms.Label labelImie2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

