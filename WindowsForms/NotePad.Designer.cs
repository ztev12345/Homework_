namespace WindowsForms
{
    partial class frmNotepad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotepad));
            this.mnusNotepad = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.結束XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNotepad = new System.Windows.Forms.ToolStrip();
            this.新增NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.開啟OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.儲存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.列印PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.剪下UToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.複製CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.貼上PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.說明LToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rtxtNotepad = new System.Windows.Forms.RichTextBox();
            this.odlgNotepad = new System.Windows.Forms.OpenFileDialog();
            this.sdlgNotepad = new System.Windows.Forms.SaveFileDialog();
            this.fdlgNotepad = new System.Windows.Forms.FontDialog();
            this.tmrNotepad = new System.Windows.Forms.Timer(this.components);
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusNotepad.SuspendLayout();
            this.tlsNotepad.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnusNotepad
            // 
            this.mnusNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiFormat,
            this.tsmiHelp});
            this.mnusNotepad.Location = new System.Drawing.Point(0, 0);
            this.mnusNotepad.Name = "mnusNotepad";
            this.mnusNotepad.Size = new System.Drawing.Size(800, 24);
            this.mnusNotepad.TabIndex = 0;
            this.mnusNotepad.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.結束XToolStripMenuItem,
            this.tsmiClose});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.ShowShortcutKeys = false;
            this.tsmiFile.Size = new System.Drawing.Size(57, 20);
            this.tsmiFile.Text = "檔案(F)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(191, 22);
            this.tsmiNew.Text = "新增(N)          ";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(191, 22);
            this.tsmiOpen.Text = "開啟(O)          ";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(191, 22);
            this.tsmiSave.Text = "儲存(S)           ";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShowShortcutKeys = false;
            this.tsmiSaveAs.Size = new System.Drawing.Size(191, 22);
            this.tsmiSaveAs.Text = "另存新檔(A)";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // 結束XToolStripMenuItem
            // 
            this.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
            this.結束XToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.結束XToolStripMenuItem.Text = "____________________";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(191, 22);
            this.tsmiClose.Text = "結束(X)";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiSelectAll});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(58, 20);
            this.tsmiEdit.Text = "編輯(E)";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(184, 22);
            this.tsmiUndo.Text = "復原(U)        ";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(184, 22);
            this.tsmiCut.Text = "剪下(T)         ";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(184, 22);
            this.tsmiCopy.Text = "複製(C)         ";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(184, 22);
            this.tsmiPaste.Text = "貼上(P)         ";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.ShowShortcutKeys = false;
            this.tsmiSelectAll.Size = new System.Drawing.Size(184, 22);
            this.tsmiSelectAll.Text = "全選(A)";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAuto,
            this.tsmiFont,
            this.顏色ToolStripMenuItem});
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Size = new System.Drawing.Size(63, 20);
            this.tsmiFormat.Text = "格式(M)";
            // 
            // tsmiAuto
            // 
            this.tsmiAuto.Checked = true;
            this.tsmiAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiAuto.Name = "tsmiAuto";
            this.tsmiAuto.Size = new System.Drawing.Size(122, 22);
            this.tsmiAuto.Text = "自動換行";
            this.tsmiAuto.Click += new System.EventHandler(this.tsmiAuto_Click);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(122, 22);
            this.tsmiFont.Text = "字形(V)";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(60, 20);
            this.tsmiHelp.Text = "說明(H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(114, 22);
            this.tsmiAbout.Text = "關於(A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tlsNotepad
            // 
            this.tlsNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripButton,
            this.開啟OToolStripButton,
            this.儲存SToolStripButton,
            this.列印PToolStripButton,
            this.toolStripSeparator,
            this.剪下UToolStripButton,
            this.複製CToolStripButton,
            this.貼上PToolStripButton,
            this.toolStripSeparator1,
            this.說明LToolStripButton});
            this.tlsNotepad.Location = new System.Drawing.Point(0, 24);
            this.tlsNotepad.Name = "tlsNotepad";
            this.tlsNotepad.Size = new System.Drawing.Size(800, 25);
            this.tlsNotepad.TabIndex = 1;
            this.tlsNotepad.Text = "toolStrip1";
            // 
            // 新增NToolStripButton
            // 
            this.新增NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新增NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripButton.Image")));
            this.新增NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripButton.Name = "新增NToolStripButton";
            this.新增NToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.新增NToolStripButton.Text = "新增(&N)";
            this.新增NToolStripButton.Click += new System.EventHandler(this.新增NToolStripButton_Click);
            // 
            // 開啟OToolStripButton
            // 
            this.開啟OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.開啟OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripButton.Image")));
            this.開啟OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripButton.Name = "開啟OToolStripButton";
            this.開啟OToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.開啟OToolStripButton.Text = "開啟(&O)";
            this.開啟OToolStripButton.Click += new System.EventHandler(this.開啟OToolStripButton_Click);
            // 
            // 儲存SToolStripButton
            // 
            this.儲存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.儲存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripButton.Image")));
            this.儲存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripButton.Name = "儲存SToolStripButton";
            this.儲存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.儲存SToolStripButton.Text = "儲存(&S)";
            this.儲存SToolStripButton.Click += new System.EventHandler(this.儲存SToolStripButton_Click);
            // 
            // 列印PToolStripButton
            // 
            this.列印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.列印PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("列印PToolStripButton.Image")));
            this.列印PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.列印PToolStripButton.Name = "列印PToolStripButton";
            this.列印PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.列印PToolStripButton.Text = "列印(&P)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // 剪下UToolStripButton
            // 
            this.剪下UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪下UToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("剪下UToolStripButton.Image")));
            this.剪下UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪下UToolStripButton.Name = "剪下UToolStripButton";
            this.剪下UToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.剪下UToolStripButton.Text = "剪下(&U)";
            this.剪下UToolStripButton.Click += new System.EventHandler(this.剪下UToolStripButton_Click);
            // 
            // 複製CToolStripButton
            // 
            this.複製CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.複製CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("複製CToolStripButton.Image")));
            this.複製CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.複製CToolStripButton.Name = "複製CToolStripButton";
            this.複製CToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.複製CToolStripButton.Text = "複製(&C)";
            // 
            // 貼上PToolStripButton
            // 
            this.貼上PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.貼上PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("貼上PToolStripButton.Image")));
            this.貼上PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼上PToolStripButton.Name = "貼上PToolStripButton";
            this.貼上PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.貼上PToolStripButton.Text = "貼上(&P)";
            this.貼上PToolStripButton.Click += new System.EventHandler(this.貼上PToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // 說明LToolStripButton
            // 
            this.說明LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.說明LToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("說明LToolStripButton.Image")));
            this.說明LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.說明LToolStripButton.Name = "說明LToolStripButton";
            this.說明LToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.說明LToolStripButton.Text = "說明(&L)";
            // 
            // rtxtNotepad
            // 
            this.rtxtNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotepad.Location = new System.Drawing.Point(12, 52);
            this.rtxtNotepad.Name = "rtxtNotepad";
            this.rtxtNotepad.Size = new System.Drawing.Size(776, 386);
            this.rtxtNotepad.TabIndex = 2;
            this.rtxtNotepad.Text = "";
            this.rtxtNotepad.TextChanged += new System.EventHandler(this.rtxtNotepad_TextChanged);
            // 
            // odlgNotepad
            // 
            this.odlgNotepad.FileName = "openFileDialog1";
            this.odlgNotepad.Filter = "RTF文件|.rtf|所有文件|.*";
            // 
            // sdlgNotepad
            // 
            this.sdlgNotepad.Filter = "RTF文件|*.rtf";
            // 
            // tmrNotepad
            // 
            this.tmrNotepad.Enabled = true;
            this.tmrNotepad.Interval = 1000;
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.顏色ToolStripMenuItem.Text = "顏色(C)";
            this.顏色ToolStripMenuItem.Click += new System.EventHandler(this.顏色ToolStripMenuItem_Click);
            // 
            // frmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtNotepad);
            this.Controls.Add(this.tlsNotepad);
            this.Controls.Add(this.mnusNotepad);
            this.MainMenuStrip = this.mnusNotepad;
            this.Name = "frmNotepad";
            this.Text = "筆記本";
            this.mnusNotepad.ResumeLayout(false);
            this.mnusNotepad.PerformLayout();
            this.tlsNotepad.ResumeLayout(false);
            this.tlsNotepad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnusNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem 結束XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiAuto;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStrip tlsNotepad;
        private System.Windows.Forms.ToolStripButton 新增NToolStripButton;
        private System.Windows.Forms.ToolStripButton 開啟OToolStripButton;
        private System.Windows.Forms.ToolStripButton 儲存SToolStripButton;
        private System.Windows.Forms.ToolStripButton 列印PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton 剪下UToolStripButton;
        private System.Windows.Forms.ToolStripButton 複製CToolStripButton;
        private System.Windows.Forms.ToolStripButton 貼上PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 說明LToolStripButton;
        private System.Windows.Forms.RichTextBox rtxtNotepad;
        private System.Windows.Forms.OpenFileDialog odlgNotepad;
        private System.Windows.Forms.SaveFileDialog sdlgNotepad;
        private System.Windows.Forms.FontDialog fdlgNotepad;
        private System.Windows.Forms.Timer tmrNotepad;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
    }
}