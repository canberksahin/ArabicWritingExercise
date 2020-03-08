namespace ArabicWritingExercise
{
    partial class Baslangic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baslangic));
            this.nudHarfSayisi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnSozluk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarfSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // nudHarfSayisi
            // 
            this.nudHarfSayisi.Location = new System.Drawing.Point(11, 67);
            this.nudHarfSayisi.Name = "nudHarfSayisi";
            this.nudHarfSayisi.Size = new System.Drawing.Size(120, 20);
            this.nudHarfSayisi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaç harf ile çalışmak istiyorsunuz?";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(11, 93);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnSozluk
            // 
            this.btnSozluk.Location = new System.Drawing.Point(224, 67);
            this.btnSozluk.Name = "btnSozluk";
            this.btnSozluk.Size = new System.Drawing.Size(123, 23);
            this.btnSozluk.TabIndex = 3;
            this.btnSozluk.Text = "SÖZLÜK";
            this.btnSozluk.UseVisualStyleBackColor = true;
            this.btnSozluk.Click += new System.EventHandler(this.btnSozluk_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "KENDİNİ TEST ET";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "YAZI ÇALIŞMASI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(221, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "KELİME ÇALIŞMASI";
            // 
            // Baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 162);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSozluk);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudHarfSayisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baslangic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arapça Öğreniyorum";
            ((System.ComponentModel.ISupportInitialize)(this.nudHarfSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudHarfSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnSozluk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}