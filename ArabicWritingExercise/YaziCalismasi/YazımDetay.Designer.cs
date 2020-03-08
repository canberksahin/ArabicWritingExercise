namespace ArabicWritingExercise
{
    partial class YazımDetay
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
            this.pboYazımDetay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboYazımDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // pboYazımDetay
            // 
            this.pboYazımDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboYazımDetay.Location = new System.Drawing.Point(0, 0);
            this.pboYazımDetay.Name = "pboYazımDetay";
            this.pboYazımDetay.Size = new System.Drawing.Size(323, 403);
            this.pboYazımDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboYazımDetay.TabIndex = 0;
            this.pboYazımDetay.TabStop = false;
            // 
            // YazımDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 403);
            this.Controls.Add(this.pboYazımDetay);
            this.Name = "YazımDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YazımDetay";
            ((System.ComponentModel.ISupportInitialize)(this.pboYazımDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboYazımDetay;
    }
}