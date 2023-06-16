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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            splitContainer1.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hello f2 = new Hello();
            f2.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(f2);
            f2.BringToFront();
            f2.Show();
        }

        private void btnscreensaver_Click(object sender, EventArgs e)
        {
            Screen screen = new Screen();
            screen.Show();
        }

        private void ooxx_Click_1(object sender, EventArgs e)
        {
            ooxx ooxx = new ooxx();
            ooxx.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(ooxx);
            ooxx.BringToFront();
            ooxx.Show();
        }

        private void btnpaint_Click(object sender, EventArgs e)
        {
            Paint paint = new Paint();
            paint.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(paint);
            paint.BringToFront();
            paint.Show();
        }

        private void btncalculator_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(calculator);
            calculator.BringToFront();
            calculator.Show();
        }

        private void btnAlarm(object sender, EventArgs e)
        {
            pictureviewer pictureviewer = new pictureviewer();
            pictureviewer.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(pictureviewer);
            pictureviewer.BringToFront();
            pictureviewer.Show();
        }

        private void btnnotepad(object sender, EventArgs e)
        {
            frmNotepad notepad = new frmNotepad();
            notepad.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
                splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(notepad);
            notepad.BringToFront();
            notepad.Show();
        }
    }
}
