namespace ArabicWritingExercise
{
    partial class Sozluk
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
            this.dgvSozluk = new System.Windows.Forms.DataGridView();
            this.txtArapca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKelimeSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozluk)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSozluk
            // 
            this.dgvSozluk.AllowUserToAddRows = false;
            this.dgvSozluk.AllowUserToDeleteRows = false;
            this.dgvSozluk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSozluk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSozluk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSozluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSozluk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSozluk.Location = new System.Drawing.Point(2, 68);
            this.dgvSozluk.MultiSelect = false;
            this.dgvSozluk.Name = "dgvSozluk";
            this.dgvSozluk.ReadOnly = true;
            this.dgvSozluk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSozluk.Size = new System.Drawing.Size(408, 367);
            this.dgvSozluk.TabIndex = 0;
            this.dgvSozluk.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSozluk_CellMouseDoubleClick);
            this.dgvSozluk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSozluk_KeyDown);
            // 
            // txtArapca
            // 
            this.txtArapca.Location = new System.Drawing.Point(68, 12);
            this.txtArapca.Name = "txtArapca";
            this.txtArapca.Size = new System.Drawing.Size(100, 20);
            this.txtArapca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARAPÇA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÜRKÇE :";
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(68, 38);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(100, 20);
            this.txtTurkce.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(182, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 46);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MEVCUT KELİME SAYISI";
            // 
            // lblKelimeSayisi
            // 
            this.lblKelimeSayisi.AutoSize = true;
            this.lblKelimeSayisi.Location = new System.Drawing.Point(316, 32);
            this.lblKelimeSayisi.Name = "lblKelimeSayisi";
            this.lblKelimeSayisi.Size = new System.Drawing.Size(35, 13);
            this.lblKelimeSayisi.TabIndex = 7;
            this.lblKelimeSayisi.Text = "label4";
            // 
            // Sozluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 459);
            this.Controls.Add(this.lblKelimeSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArapca);
            this.Controls.Add(this.dgvSozluk);
            this.Name = "Sozluk";
            this.Text = "Sozluk";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSozluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSozluk;
        private System.Windows.Forms.TextBox txtArapca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKelimeSayisi;
    }
}