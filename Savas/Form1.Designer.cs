namespace Savas
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOyuncu = new TextBox();
            txtSilah = new TextBox();
            txtBrans = new TextBox();
            txtIrk = new TextBox();
            btnSec = new Button();
            pictureBox1 = new PictureBox();
            btnSaldir = new Button();
            lblDusmanCani = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Oyuncu İsmi:   ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 1;
            label2.Text = "Irk:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 2;
            label3.Text = "Brans:   ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 3;
            label4.Text = "Silah:   ";
            // 
            // txtOyuncu
            // 
            txtOyuncu.Location = new Point(138, 46);
            txtOyuncu.Name = "txtOyuncu";
            txtOyuncu.Size = new Size(120, 31);
            txtOyuncu.TabIndex = 4;
            // 
            // txtSilah
            // 
            txtSilah.Location = new Point(138, 163);
            txtSilah.Name = "txtSilah";
            txtSilah.Size = new Size(120, 31);
            txtSilah.TabIndex = 5;
            // 
            // txtBrans
            // 
            txtBrans.Location = new Point(138, 126);
            txtBrans.Name = "txtBrans";
            txtBrans.Size = new Size(120, 31);
            txtBrans.TabIndex = 6;
            // 
            // txtIrk
            // 
            txtIrk.Location = new Point(138, 85);
            txtIrk.Name = "txtIrk";
            txtIrk.Size = new Size(120, 31);
            txtIrk.TabIndex = 7;
            // 
            // btnSec
            // 
            btnSec.Location = new Point(381, 51);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(212, 106);
            btnSec.TabIndex = 8;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kurtadam;
            pictureBox1.Location = new Point(746, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 178);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnSaldir
            // 
            btnSaldir.BackColor = SystemColors.GradientActiveCaption;
            btnSaldir.Location = new Point(390, 277);
            btnSaldir.Name = "btnSaldir";
            btnSaldir.Size = new Size(203, 87);
            btnSaldir.TabIndex = 11;
            btnSaldir.Text = "Saldır";
            btnSaldir.UseVisualStyleBackColor = false;
            btnSaldir.Click += btnSaldir_Click;
            // 
            // lblDusmanCani
            // 
            lblDusmanCani.BackColor = Color.DarkRed;
            lblDusmanCani.Location = new Point(793, 67);
            lblDusmanCani.Name = "lblDusmanCani";
            lblDusmanCani.Size = new Size(300, 25);
            lblDusmanCani.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 450);
            Controls.Add(lblDusmanCani);
            Controls.Add(btnSaldir);
            Controls.Add(pictureBox1);
            Controls.Add(btnSec);
            Controls.Add(txtIrk);
            Controls.Add(txtBrans);
            Controls.Add(txtSilah);
            Controls.Add(txtOyuncu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOyuncu;
        private TextBox txtSilah;
        private TextBox txtBrans;
        private TextBox txtIrk;
        private Button btnSec;
        private PictureBox pictureBox1;
        private Button btnSaldir;
        private Label lblDusmanCani;
    }
}