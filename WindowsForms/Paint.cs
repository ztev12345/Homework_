using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Paint : Form
    {
        Brush PaintBrush = new SolidBrush(Color.FromName("Red"));
        public Paint()
        {
            InitializeComponent();
        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics graphics = this.CreateGraphics();
                graphics.FillEllipse(PaintBrush, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Brush b1 = new SolidBrush(this.BackColor);
                Graphics graphics = this.CreateGraphics();
                graphics.FillEllipse(b1, e.X, e.Y, 20, 20);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK) 
            {
                PaintBrush = new SolidBrush(cd.Color);
            }
        }
    }
}
