using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Screen : Form
    {
        private Thread thr;
        private bool keepR = true;
        private bool keepL = false;
        private bool keepT = false;
        private bool keepB = true;
        private Random rnd = new Random();
        private int counter = 0;
        private bool isClosing = false;
        private object lockObject = new object();

        public Screen()
        {
            InitializeComponent();
            this.Load += Screen_Load;
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            thr = new Thread(mainthr);
            thr.IsBackground = true;
            thr.Start();
        }

        private void Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosing = true;
            thr.Join();
        }

        private void Screen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainthr()
        {
            while (!isClosing)
            {
                int randomincr = rnd.Next(1, 3);
                bool hitR = false;
                bool hitL = false;
                bool hitT = false;
                bool hitB = false;
                int tPos = 0;
                int lPos = 0;

                if (!isClosing)
                {
                    lock (lockObject)
                    {
                        if (!isClosing)
                        {
                            tPos = memecat.Top;
                            lPos = memecat.Left;
                        }
                    }
                }

                int bPos = this.Height - tPos - memecat.Height;
                int rPos = this.Width - lPos - memecat.Width;

                if (!isClosing)
                {
                    if (lPos == 0)
                        hitL = true;
                    if (tPos == 0)
                        hitT = true;
                    if (rPos == 0)
                        hitR = true;
                    if (bPos == 0)
                        hitB = true;

                    if (hitL == false && keepL == true)
                        lPos -= randomincr;
                    else
                    {
                        lPos += randomincr;
                        keepL = false;
                        keepR = true;
                    }
                    if (hitR == false && keepR == true)
                        lPos += randomincr;
                    else
                    {
                        lPos -= randomincr;
                        keepL = true;
                        keepR = false;
                    }
                    if (hitT == false && keepT == true)
                        tPos -= randomincr;
                    else
                    {
                        tPos += randomincr;
                        keepT = false;
                        keepB = true;
                    }
                    if (hitB == false && keepB == true)
                        tPos += randomincr;
                    else
                    {
                        tPos -= randomincr;
                        keepB = false;
                        keepT = true;
                    }

                    if (lPos < 0)
                        lPos = 0;
                    if (lPos > this.Width - memecat.Width)
                        lPos = this.Width - memecat.Width;
                    if (tPos < 0)
                        tPos = 0;
                    if (tPos > this.Height - memecat.Height)
                        tPos = this.Height - memecat.Height;

                    if (!isClosing)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                if (!isClosing) 
                                {
                                    UpdateMemeCatPosition(tPos, lPos);
                                }
                            });
                        }
                        else
                        {
                            if (!isClosing) 
                            {
                                UpdateMemeCatPosition(tPos, lPos);
                            }
                        }

                        if ((lPos == 0 && tPos == 0) || (lPos == 0 && bPos == 0) || (rPos == 0 && tPos == 0) || (rPos == 0 && bPos == 0))
                        {
                            if (!isClosing) 
                            {
                                if (this.InvokeRequired)
                                {
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        counter++;
                                    });
                                }
                                else
                                {
                                    counter++;
                                }
                            }
                        }
                    }

                    if (isClosing) 
                        break;

                    Thread.Sleep(10);
                }
            }
        }

        private void UpdateMemeCatPosition(int top, int left)
        {
            if (!isClosing)
            {
                lock (lockObject)
                {
                    if (!isClosing)
                    {
                        memecat.Top = top;
                        memecat.Left = left;
                    }
                }
            }
        }
    }
}
