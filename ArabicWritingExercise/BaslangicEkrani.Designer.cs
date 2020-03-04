namespace ArabicWritingExercise
{
    partial class BaslangicEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaslangicEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.nudHarfSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnBasla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarfSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaç harf ile çalışmak istiyorsunuz :";
            // 
            // nudHarfSayisi
            // 
            this.nudHarfSayisi.Location = new System.Drawing.Point(15, 41);
            this.nudHarfSayisi.Name = "nudHarfSayisi";
            this.nudHarfSayisi.Size = new System.Drawing.Size(85, 20);
            this.nudHarfSayisi.TabIndex = 1;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(15, 74);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(164, 23);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // BaslangicEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 109);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.nudHarfSayisi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaslangicEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arapça Yazı Çalışması";
            ((System.ComponentModel.ISupportInitialize)(this.nudHarfSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHarfSayisi;
        private System.Windows.Forms.Button btnBasla;
    }
}