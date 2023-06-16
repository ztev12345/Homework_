namespace WindowsForms
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnOpenHello = new System.Windows.Forms.Button();
            this.btnscreensaver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.btnpictureviewer = new System.Windows.Forms.Button();
            this.btncalculator = new System.Windows.Forms.Button();
            this.btnpaint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenHello
            // 
            this.btnOpenHello.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOpenHello.Location = new System.Drawing.Point(122, 12);
            this.btnOpenHello.Name = "btnOpenHello";
            this.btnOpenHello.Size = new System.Drawing.Size(170, 27);
            this.btnOpenHello.TabIndex = 0;
            this.btnOpenHello.Text = "Hello";
            this.btnOpenHello.UseVisualStyleBackColor = true;
            this.btnOpenHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnscreensaver
            // 
            this.btnscreensaver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnscreensaver.Location = new System.Drawing.Point(123, 45);
            this.btnscreensaver.Name = "btnscreensaver";
            this.btnscreensaver.Size = new System.Drawing.Size(169, 27);
            this.btnscreensaver.TabIndex = 1;
            this.btnscreensaver.Text = "螢幕保護";
            this.btnscreensaver.UseVisualStyleBackColor = true;
            this.btnscreensaver.Click += new System.EventHandler(this.btnscreensaver_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(122, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "圈圈叉叉";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ooxx_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-2, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(1033, 600);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button3);
            this.splitContainer2.Panel1.Controls.Add(this.btnpictureviewer);
            this.splitContainer2.Panel1.Controls.Add(this.btncalculator);
            this.splitContainer2.Panel1.Controls.Add(this.btnpaint);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btnscreensaver);
            this.splitContainer2.Panel1.Controls.Add(this.btnOpenHello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Size = new System.Drawing.Size(230, 600);
            this.splitContainer2.SplitterDistance = 232;
            this.splitContainer2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "筆記本";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnnotepad);
            // 
            // btnpictureviewer
            // 
            this.btnpictureviewer.Location = new System.Drawing.Point(122, 177);
            this.btnpictureviewer.Name = "btnpictureviewer";
            this.btnpictureviewer.Size = new System.Drawing.Size(169, 27);
            this.btnpictureviewer.TabIndex = 5;
            this.btnpictureviewer.Text = "圖片顯示";
            this.btnpictureviewer.UseVisualStyleBackColor = true;
            this.btnpictureviewer.Click += new System.EventHandler(this.btnAlarm);
            // 
            // btncalculator
            // 
            this.btncalculator.Location = new System.Drawing.Point(122, 144);
            this.btncalculator.Name = "btncalculator";
            this.btncalculator.Size = new System.Drawing.Size(169, 27);
            this.btncalculator.TabIndex = 4;
            this.btncalculator.Text = "簡易計算機";
            this.btncalculator.UseVisualStyleBackColor = true;
            this.btncalculator.Click += new System.EventHandler(this.btncalculator_Click);
            // 
            // btnpaint
            // 
            this.btnpaint.Location = new System.Drawing.Point(122, 111);
            this.btnpaint.Name = "btnpaint";
            this.btnpaint.Size = new System.Drawing.Size(169, 27);
            this.btnpaint.TabIndex = 3;
            this.btnpaint.Text = "小畫家";
            this.btnpaint.UseVisualStyleBackColor = true;
            this.btnpaint.Click += new System.EventHandler(this.btnpaint_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 599);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "作業";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHello;
        private System.Windows.Forms.Button btnscreensaver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnpaint;
        private System.Windows.Forms.Button btncalculator;
        private System.Windows.Forms.Button btnpictureviewer;
        private System.Windows.Forms.Button button3;
    }
}

