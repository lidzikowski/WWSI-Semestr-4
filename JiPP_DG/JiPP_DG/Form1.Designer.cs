namespace JiPP_DG
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxZiemia = new System.Windows.Forms.PictureBox();
            this.pictureBoxRura2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRura1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGracz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZiemia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGracz)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBoxZiemia
            // 
            this.pictureBoxZiemia.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxZiemia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxZiemia.Location = new System.Drawing.Point(0, 416);
            this.pictureBoxZiemia.Name = "pictureBoxZiemia";
            this.pictureBoxZiemia.Size = new System.Drawing.Size(800, 34);
            this.pictureBoxZiemia.TabIndex = 1;
            this.pictureBoxZiemia.TabStop = false;
            // 
            // pictureBoxRura2
            // 
            this.pictureBoxRura2.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBoxRura2.Location = new System.Drawing.Point(482, 311);
            this.pictureBoxRura2.Name = "pictureBoxRura2";
            this.pictureBoxRura2.Size = new System.Drawing.Size(39, 139);
            this.pictureBoxRura2.TabIndex = 3;
            this.pictureBoxRura2.TabStop = false;
            // 
            // pictureBoxRura1
            // 
            this.pictureBoxRura1.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBoxRura1.Location = new System.Drawing.Point(482, 0);
            this.pictureBoxRura1.Name = "pictureBoxRura1";
            this.pictureBoxRura1.Size = new System.Drawing.Size(39, 173);
            this.pictureBoxRura1.TabIndex = 4;
            this.pictureBoxRura1.TabStop = false;
            // 
            // pictureBoxGracz
            // 
            this.pictureBoxGracz.BackColor = System.Drawing.Color.Gold;
            this.pictureBoxGracz.Location = new System.Drawing.Point(164, 188);
            this.pictureBoxGracz.Name = "pictureBoxGracz";
            this.pictureBoxGracz.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxGracz.TabIndex = 5;
            this.pictureBoxGracz.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxGracz);
            this.Controls.Add(this.pictureBoxRura1);
            this.Controls.Add(this.pictureBoxRura2);
            this.Controls.Add(this.pictureBoxZiemia);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZiemia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGracz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxZiemia;
        private System.Windows.Forms.PictureBox pictureBoxRura2;
        private System.Windows.Forms.PictureBox pictureBoxRura1;
        private System.Windows.Forms.PictureBox pictureBoxGracz;
    }
}

