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
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnAlfabe = new System.Windows.Forms.Button();
            this.lblHarf1 = new System.Windows.Forms.Label();
            this.lblHarf3 = new System.Windows.Forms.Label();
            this.lblHarf2 = new System.Windows.Forms.Label();
            this.btnHarfleriGöster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(195, 255);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 3;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnAlfabe
            // 
            this.btnAlfabe.Location = new System.Drawing.Point(294, 255);
            this.btnAlfabe.Name = "btnAlfabe";
            this.btnAlfabe.Size = new System.Drawing.Size(75, 23);
            this.btnAlfabe.TabIndex = 4;
            this.btnAlfabe.Text = "Alfabe";
            this.btnAlfabe.UseVisualStyleBackColor = true;
            this.btnAlfabe.Click += new System.EventHandler(this.btnAlfabe_Click);
            // 
            // lblHarf1
            // 
            this.lblHarf1.AutoSize = true;
            this.lblHarf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarf1.Location = new System.Drawing.Point(91, 208);
            this.lblHarf1.Name = "lblHarf1";
            this.lblHarf1.Size = new System.Drawing.Size(51, 20);
            this.lblHarf1.TabIndex = 5;
            this.lblHarf1.Text = "label1";
            this.lblHarf1.Visible = false;
            // 
            // lblHarf3
            // 
            this.lblHarf3.AutoSize = true;
            this.lblHarf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarf3.Location = new System.Drawing.Point(547, 208);
            this.lblHarf3.Name = "lblHarf3";
            this.lblHarf3.Size = new System.Drawing.Size(51, 20);
            this.lblHarf3.TabIndex = 6;
            this.lblHarf3.Text = "label2";
            this.lblHarf3.Visible = false;
            // 
            // lblHarf2
            // 
            this.lblHarf2.AutoSize = true;
            this.lblHarf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarf2.Location = new System.Drawing.Point(316, 208);
            this.lblHarf2.Name = "lblHarf2";
            this.lblHarf2.Size = new System.Drawing.Size(51, 20);
            this.lblHarf2.TabIndex = 7;
            this.lblHarf2.Text = "label3";
            this.lblHarf2.Visible = false;
            // 
            // btnHarfleriGöster
            // 
            this.btnHarfleriGöster.Location = new System.Drawing.Point(388, 255);
            this.btnHarfleriGöster.Name = "btnHarfleriGöster";
            this.btnHarfleriGöster.Size = new System.Drawing.Size(138, 23);
            this.btnHarfleriGöster.TabIndex = 8;
            this.btnHarfleriGöster.Text = "Harflerin Adlarını Göster";
            this.btnHarfleriGöster.UseVisualStyleBackColor = true;
            this.btnHarfleriGöster.Click += new System.EventHandler(this.btnHarfleriGöster_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(80, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 71);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(523, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 77);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(308, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 77);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 396);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHarfleriGöster);
            this.Controls.Add(this.lblHarf2);
            this.Controls.Add(this.lblHarf3);
            this.Controls.Add(this.lblHarf1);
            this.Controls.Add(this.btnAlfabe);
            this.Controls.Add(this.btnGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnAlfabe;
        private System.Windows.Forms.Label lblHarf1;
        private System.Windows.Forms.Label lblHarf3;
        private System.Windows.Forms.Label lblHarf2;
        private System.Windows.Forms.Button btnHarfleriGöster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

