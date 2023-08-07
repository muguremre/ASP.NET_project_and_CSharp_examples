namespace Futbol
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
            cmdUlke = new ComboBox();
            txtIsim = new TextBox();
            btnSec = new Button();
            btnSutAt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 0;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 1;
            label2.Text = "Ülke";
            // 
            // cmdUlke
            // 
            cmdUlke.FormattingEnabled = true;
            cmdUlke.Items.AddRange(new object[] { "Brezilya", "İngiltere", "İspanya" });
            cmdUlke.Location = new Point(87, 114);
            cmdUlke.Name = "cmdUlke";
            cmdUlke.Size = new Size(182, 33);
            cmdUlke.TabIndex = 2;
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(87, 48);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(182, 31);
            txtIsim.TabIndex = 3;
            // 
            // btnSec
            // 
            btnSec.Location = new Point(583, 34);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(156, 45);
            btnSec.TabIndex = 4;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnSutAt
            // 
            btnSutAt.Location = new Point(583, 114);
            btnSutAt.Name = "btnSutAt";
            btnSutAt.Size = new Size(156, 45);
            btnSutAt.TabIndex = 5;
            btnSutAt.Text = "Şut At";
            btnSutAt.UseVisualStyleBackColor = true;
            btnSutAt.Click += btnSutAt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSutAt);
            Controls.Add(btnSec);
            Controls.Add(txtIsim);
            Controls.Add(cmdUlke);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmdUlke;
        private TextBox txtIsim;
        private Button btnSec;
        private Button btnSutAt;
    }
}