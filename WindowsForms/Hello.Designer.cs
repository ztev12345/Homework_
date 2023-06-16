namespace WindowsForms
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.btnsayhello = new System.Windows.Forms.Button();
            this.btnsayhi = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.textengname = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textsex = new System.Windows.Forms.TextBox();
            this.labname = new System.Windows.Forms.Label();
            this.labengname = new System.Windows.Forms.Label();
            this.labsex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsayhello
            // 
            this.btnsayhello.Location = new System.Drawing.Point(91, 321);
            this.btnsayhello.Name = "btnsayhello";
            this.btnsayhello.Size = new System.Drawing.Size(123, 58);
            this.btnsayhello.TabIndex = 0;
            this.btnsayhello.Text = "Say Hello!!";
            this.btnsayhello.UseVisualStyleBackColor = true;
            this.btnsayhello.Click += new System.EventHandler(this.btnsayhello_Click);
            // 
            // btnsayhi
            // 
            this.btnsayhi.Location = new System.Drawing.Point(259, 321);
            this.btnsayhi.Name = "btnsayhi";
            this.btnsayhi.Size = new System.Drawing.Size(123, 58);
            this.btnsayhi.TabIndex = 1;
            this.btnsayhi.Text = "Say Hi!!";
            this.btnsayhi.UseVisualStyleBackColor = true;
            this.btnsayhi.Click += new System.EventHandler(this.btnsayhi_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(259, 87);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(131, 22);
            this.textname.TabIndex = 2;
            // 
            // textengname
            // 
            this.textengname.Location = new System.Drawing.Point(259, 134);
            this.textengname.Name = "textengname";
            this.textengname.Size = new System.Drawing.Size(131, 22);
            this.textengname.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(259, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textsex
            // 
            this.textsex.Location = new System.Drawing.Point(259, 188);
            this.textsex.Name = "textsex";
            this.textsex.Size = new System.Drawing.Size(131, 22);
            this.textsex.TabIndex = 5;
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.BackColor = System.Drawing.Color.Transparent;
            this.labname.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labname.ForeColor = System.Drawing.Color.Yellow;
            this.labname.Location = new System.Drawing.Point(99, 77);
            this.labname.Name = "labname";
            this.labname.Padding = new System.Windows.Forms.Padding(10);
            this.labname.Size = new System.Drawing.Size(77, 41);
            this.labname.TabIndex = 6;
            this.labname.Text = "姓名:";
            // 
            // labengname
            // 
            this.labengname.AutoSize = true;
            this.labengname.BackColor = System.Drawing.Color.Transparent;
            this.labengname.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labengname.ForeColor = System.Drawing.Color.Yellow;
            this.labengname.Location = new System.Drawing.Point(108, 134);
            this.labengname.Name = "labengname";
            this.labengname.Size = new System.Drawing.Size(127, 21);
            this.labengname.TabIndex = 7;
            this.labengname.Text = "English Name:";
            this.labengname.Click += new System.EventHandler(this.label2_Click);
            // 
            // labsex
            // 
            this.labsex.AutoSize = true;
            this.labsex.BackColor = System.Drawing.Color.Transparent;
            this.labsex.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labsex.ForeColor = System.Drawing.Color.Yellow;
            this.labsex.Location = new System.Drawing.Point(108, 189);
            this.labsex.Name = "labsex";
            this.labsex.Size = new System.Drawing.Size(57, 21);
            this.labsex.TabIndex = 8;
            this.labsex.Text = "性別:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(108, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "星座:";
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labsex);
            this.Controls.Add(this.labengname);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.textsex);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textengname);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.btnsayhi);
            this.Controls.Add(this.btnsayhello);
            this.Name = "Hello";
            this.Text = "你好C#!";
            //this.Click += new System.EventHandler(this.Hello_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsayhello;
        private System.Windows.Forms.Button btnsayhi;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textengname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textsex;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labengname;
        private System.Windows.Forms.Label labsex;
        private System.Windows.Forms.Label label4;
    }
}