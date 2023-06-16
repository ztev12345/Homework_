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
    public partial class pictureviewer : Form
    {

        public pictureviewer()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            PictureForm pictureForm = new PictureForm(pictureBox1.Image);

            
            pictureForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureForm pictureForm = new PictureForm(pictureBox2.Image);


            pictureForm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureForm pictureForm = new PictureForm(pictureBox3.Image);


            pictureForm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureForm pictureForm = new PictureForm(pictureBox5.Image);


            pictureForm.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureForm pictureForm = new PictureForm(pictureBox7.Image);


            pictureForm.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureForm pictureForm = new PictureForm(pictureBox8.Image);


            pictureForm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureForm pictureForm = new PictureForm(pictureBox4.Image);


            pictureForm.ShowDialog();
        }
    }
}
