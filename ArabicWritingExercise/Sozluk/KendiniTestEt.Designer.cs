namespace ArabicWritingExercise
{
    partial class KendiniTestEt
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiradaki = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lblArapca = new System.Windows.Forms.Label();
            this.lblTurkce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TÜRKÇE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ARAPÇA :";
            // 
            // btnSiradaki
            // 
            this.btnSiradaki.Location = new System.Drawing.Point(12, 67);
            this.btnSiradaki.Name = "btnSiradaki";
            this.btnSiradaki.Size = new System.Drawing.Size(106, 24);
            this.btnSiradaki.TabIndex = 9;
            this.btnSiradaki.Text = "SIRADAKİ";
            this.btnSiradaki.UseVisualStyleBackColor = true;
            this.btnSiradaki.Click += new System.EventHandler(this.btnSiradaki_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(12, 96);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(106, 24);
            this.btnGoster.TabIndex = 8;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lblArapca
            // 
            this.lblArapca.AutoSize = true;
            this.lblArapca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArapca.Location = new System.Drawing.Point(72, 15);
            this.lblArapca.Name = "lblArapca";
            this.lblArapca.Size = new System.Drawing.Size(46, 17);
            this.lblArapca.TabIndex = 6;
            this.lblArapca.Text = "label1";
            // 
            // lblTurkce
            // 
            this.lblTurkce.AutoSize = true;
            this.lblTurkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkce.Location = new System.Drawing.Point(72, 38);
            this.lblTurkce.Name = "lblTurkce";
            this.lblTurkce.Size = new System.Drawing.Size(46, 17);
            this.lblTurkce.TabIndex = 12;
            this.lblTurkce.Text = "label1";
            this.lblTurkce.Visible = false;
            // 
            // KendiniTestEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.lblTurkce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSiradaki);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblArapca);
            this.Name = "KendiniTestEt";
            this.Text = "KendiniTestEt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiradaki;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label lblArapca;
        private System.Windows.Forms.Label lblTurkce;
    }
}