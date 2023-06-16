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
    public partial class frmNotepad : Form
    {
        bool b = false;
        bool s = true;
        public frmNotepad()
        {
            InitializeComponent();
        }

        private void rtxtNotepad_TextChanged(object sender, EventArgs e)
        {
            s = false;
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            
            if (b == true || rtxtNotepad.Text.Trim() != "")
            {
                
                if (s == false)
                {
                    string result;
                    result = MessageBox.Show("文件尚未保存,是否保存?",
                        "保存文件", MessageBoxButtons.YesNoCancel).ToString();
                    switch (result)
                    {
                        case "Yes":
                            
                            if (b == true)
                            {
                                
                                rtxtNotepad.SaveFile(odlgNotepad.FileName);
                            }
                            
                            else if (sdlgNotepad.ShowDialog() == DialogResult.OK)
                            {
                                rtxtNotepad.SaveFile(sdlgNotepad.FileName);
                            }
                            s = true;
                            rtxtNotepad.Text = "";
                            break;
                        case "No":
                            b = false;
                            rtxtNotepad.Text = "";
                            break;
                    }
                }
            }

        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (b == true || rtxtNotepad.Text.Trim() != "")
            {
                if (s == false)
                {
                    string result;
                    result = MessageBox.Show("文件尚未保存,是否保存?",
                        "保存文件", MessageBoxButtons.YesNoCancel).ToString();
                    switch (result)
                    {
                        case "Yes":
                            if (b == true)
                            {
                                rtxtNotepad.SaveFile(odlgNotepad.FileName);
                            }
                            else if (sdlgNotepad.ShowDialog() == DialogResult.OK)
                            {
                                rtxtNotepad.SaveFile(sdlgNotepad.FileName);
                            }
                            s = true;
                            break;
                        case "No":
                            b = false;
                            rtxtNotepad.Text = "";
                            break;
                    }
                }
            }
            odlgNotepad.RestoreDirectory = true;
            if ((odlgNotepad.ShowDialog() == DialogResult.OK) && odlgNotepad.FileName != "")
            {
                rtxtNotepad.LoadFile(odlgNotepad.FileName);
                b = true;
            }
            s = true;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (b == true && rtxtNotepad.Modified == true)
            {
                rtxtNotepad.SaveFile(odlgNotepad.FileName);
                s = true;
            }
            else if (b == false && rtxtNotepad.Text.Trim() != "" &&
                sdlgNotepad.ShowDialog() == DialogResult.OK)
            {
                rtxtNotepad.SaveFile(sdlgNotepad.FileName);
                s = true;
                b = true;
                odlgNotepad.FileName = sdlgNotepad.FileName;
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (sdlgNotepad.ShowDialog() == DialogResult.OK)
            {
                rtxtNotepad.SaveFile(sdlgNotepad.FileName);
                s = true;
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            rtxtNotepad.Undo();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            rtxtNotepad.Cut();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            rtxtNotepad.Copy();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            rtxtNotepad.Paste();
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            rtxtNotepad.SelectAll();
        }

        private void tsmiAuto_Click(object sender, EventArgs e)
        {
            if (tsmiAuto.Checked == false)
            {
                tsmiAuto.Checked = true;            
                rtxtNotepad.WordWrap = true;        
            }
            else
            {
                tsmiAuto.Checked = false;
                rtxtNotepad.WordWrap = false;
            }
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            fdlgNotepad.ShowColor = true;
            if (fdlgNotepad.ShowDialog() == DialogResult.OK)
            {
                rtxtNotepad.SelectionColor = fdlgNotepad.Color;
                rtxtNotepad.SelectionFont = fdlgNotepad.Font;
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            frmAbout ob_FrmAbout = new frmAbout();
            ob_FrmAbout.Show();

        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            tsmiNew_Click(sender, e);
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            tsmiOpen_Click(sender, e);
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            tsmiSave_Click(sender, e);
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            tsmiCut_Click(sender, e);
        }


        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            tsmiPaste_Click(sender, e);
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) 
            {
                {
                    Color selectedColor = cd.Color;
                    rtxtNotepad.SelectionColor = selectedColor;
                }
            }
        }
    }
}
