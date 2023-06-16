namespace WindowsForms
{
    partial class Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.memecat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.memecat)).BeginInit();
            this.SuspendLayout();
            // 
            // memecat
            // 
            this.memecat.Image = ((System.Drawing.Image)(resources.GetObject("memecat.Image")));
            this.memecat.Location = new System.Drawing.Point(172, 88);
            this.memecat.Name = "memecat";
            this.memecat.Size = new System.Drawing.Size(168, 167);
            this.memecat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.memecat.TabIndex = 0;
            this.memecat.TabStop = false;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memecat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen";
            this.Text = "Screen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Screen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.memecat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox memecat;
    }
}