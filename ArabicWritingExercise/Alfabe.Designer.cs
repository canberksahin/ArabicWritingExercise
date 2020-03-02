namespace ArabicWritingExercise
{
    partial class Alfabe
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
            this.pcbAlfabe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlfabe)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbAlfabe
            // 
            this.pcbAlfabe.BackgroundImage = global::ArabicWritingExercise.Properties.Resources.alfabe;
            this.pcbAlfabe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbAlfabe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbAlfabe.Location = new System.Drawing.Point(0, 0);
            this.pcbAlfabe.Name = "pcbAlfabe";
            this.pcbAlfabe.Size = new System.Drawing.Size(669, 435);
            this.pcbAlfabe.TabIndex = 0;
            this.pcbAlfabe.TabStop = false;
            // 
            // Alfabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 435);
            this.Controls.Add(this.pcbAlfabe);
            this.Name = "Alfabe";
            this.Text = "Alfabe";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlfabe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbAlfabe;
    }
}