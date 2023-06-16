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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsayhello_Click(object sender, EventArgs e)
        {
            string name = textname.Text;
            string engname = textengname.Text;
            string sex = textsex.Text;
            string star = textBox3.Text;
            MessageBox.Show("Hello,我是 " + name + "\r\n" +
                            "我的英文名是 " + engname + "\r\n" +
                            "性別是 " + sex + "\r\n" +
                            "星座是 " + star + "\r\n" +
                            "很高興認識你");




        }

        private void btnsayhi_Click(object sender, EventArgs e)
        {
            string name = textname.Text;
            string engname = textengname.Text;
            string sex = textsex.Text;
            string star = textBox3.Text;
            MessageBox.Show("Hi,我是 " + name + "\r\n" +
                            "我的英文名是 " + engname + "\r\n" +
                            "性別是 " + sex + "\r\n" +
                            "星座是 " + star + "\r\n" +
                            "很高興認識你");
        }

       
    }
}
