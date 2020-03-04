namespace ArabicWritingExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnAlfabe = new System.Windows.Forms.Button();
            this.btnHarfleriGöster = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.txtYazilis = new System.Windows.Forms.TextBox();
            this.btnYazilis = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(12, 182);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(226, 49);
            this.btnGetir.TabIndex = 3;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnAlfabe
            // 
            this.btnAlfabe.Location = new System.Drawing.Point(12, 237);
            this.btnAlfabe.Name = "btnAlfabe";
            this.btnAlfabe.Size = new System.Drawing.Size(94, 38);
            this.btnAlfabe.TabIndex = 4;
            this.btnAlfabe.Text = "Alfabe";
            this.btnAlfabe.UseVisualStyleBackColor = true;
            this.btnAlfabe.Click += new System.EventHandler(this.btnAlfabe_Click);
            // 
            // btnHarfleriGöster
            // 
            this.btnHarfleriGöster.Location = new System.Drawing.Point(113, 237);
            this.btnHarfleriGöster.Name = "btnHarfleriGöster";
            this.btnHarfleriGöster.Size = new System.Drawing.Size(125, 38);
            this.btnHarfleriGöster.TabIndex = 8;
            this.btnHarfleriGöster.Text = "Harfleri Göster";
            this.btnHarfleriGöster.UseVisualStyleBackColor = true;
            this.btnHarfleriGöster.Click += new System.EventHandler(this.btnHarfleriGöster_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(12, 282);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(226, 44);
            this.btnSol.TabIndex = 12;
            this.btnSol.Text = "Sol ile Birleşmeyen Harfleri Göster";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // txtYazilis
            // 
            this.txtYazilis.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtYazilis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYazilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazilis.Location = new System.Drawing.Point(258, 271);
            this.txtYazilis.Multiline = true;
            this.txtYazilis.Name = "txtYazilis";
            this.txtYazilis.Size = new System.Drawing.Size(232, 93);
            this.txtYazilis.TabIndex = 13;
            this.txtYazilis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYazilis.Visible = false;
            // 
            // btnYazilis
            // 
            this.btnYazilis.Location = new System.Drawing.Point(12, 333);
            this.btnYazilis.Name = "btnYazilis";
            this.btnYazilis.Size = new System.Drawing.Size(226, 31);
            this.btnYazilis.TabIndex = 14;
            this.btnYazilis.Text = "Yazılışını Göster";
            this.btnYazilis.UseVisualStyleBackColor = true;
            this.btnYazilis.Click += new System.EventHandler(this.btnYazilis_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(12, 332);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(226, 32);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Visible = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 396);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYazilis);
            this.Controls.Add(this.txtYazilis);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnHarfleriGöster);
            this.Controls.Add(this.btnAlfabe);
            this.Controls.Add(this.btnGetir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arapça Yazı Çalışması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnAlfabe;
        private System.Windows.Forms.Button btnHarfleriGöster;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.TextBox txtYazilis;
        private System.Windows.Forms.Button btnYazilis;
        private System.Windows.Forms.Button btnKapat;
    }
}

