namespace IconGenFromSVG
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOpenSVG = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSaveIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSaveImage = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPriviousSize = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNextSize = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtSize = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtCurSize = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ckSize256 = new System.Windows.Forms.CheckBox();
			this.ckSize128 = new System.Windows.Forms.CheckBox();
			this.ckSize64 = new System.Windows.Forms.CheckBox();
			this.ckSize48 = new System.Windows.Forms.CheckBox();
			this.ckSize32 = new System.Windows.Forms.CheckBox();
			this.ckSize24 = new System.Windows.Forms.CheckBox();
			this.ckSize16 = new System.Windows.Forms.CheckBox();
			this.ckSize8 = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictConvertedImage = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictConvertedImage)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(850, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenSVG,
            this.toolStripSeparator1,
            this.mnuSaveIcon,
            this.mnuSaveImage,
            this.toolStripSeparator2,
            this.mnuExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
			// 
			// mnuOpenSVG
			// 
			this.mnuOpenSVG.Image = global::IconGenFromSVG.Properties.Resources.OpenFile_16x;
			this.mnuOpenSVG.Name = "mnuOpenSVG";
			this.mnuOpenSVG.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mnuOpenSVG.Size = new System.Drawing.Size(200, 22);
			this.mnuOpenSVG.Text = "Open SVG File...";
			this.mnuOpenSVG.Click += new System.EventHandler(this.mnuOpenSVG_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
			// 
			// mnuSaveIcon
			// 
			this.mnuSaveIcon.Image = global::IconGenFromSVG.Properties.Resources.Save_16x;
			this.mnuSaveIcon.Name = "mnuSaveIcon";
			this.mnuSaveIcon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mnuSaveIcon.Size = new System.Drawing.Size(200, 22);
			this.mnuSaveIcon.Text = "Save Icon File...";
			this.mnuSaveIcon.Click += new System.EventHandler(this.mnuSaveIcon_Click);
			// 
			// mnuSaveImage
			// 
			this.mnuSaveImage.Image = global::IconGenFromSVG.Properties.Resources.SaveAs_16x;
			this.mnuSaveImage.Name = "mnuSaveImage";
			this.mnuSaveImage.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.mnuSaveImage.Size = new System.Drawing.Size(200, 22);
			this.mnuSaveImage.Text = "Save As...";
			this.mnuSaveImage.Click += new System.EventHandler(this.mnuSaveImage_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.mnuExit.Size = new System.Drawing.Size(200, 22);
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCut,
            this.mnuCopy,
            this.toolStripSeparator3,
            this.mnuClear});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
			// 
			// mnuCut
			// 
			this.mnuCut.Image = global::IconGenFromSVG.Properties.Resources.Cut_16x;
			this.mnuCut.Name = "mnuCut";
			this.mnuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.mnuCut.Size = new System.Drawing.Size(144, 22);
			this.mnuCut.Text = "Cut";
			this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
			// 
			// mnuCopy
			// 
			this.mnuCopy.Image = global::IconGenFromSVG.Properties.Resources.Copy_16x;
			this.mnuCopy.Name = "mnuCopy";
			this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.mnuCopy.Size = new System.Drawing.Size(144, 22);
			this.mnuCopy.Text = "Copy";
			this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
			// 
			// mnuClear
			// 
			this.mnuClear.Image = global::IconGenFromSVG.Properties.Resources.CleanData_16x;
			this.mnuClear.Name = "mnuClear";
			this.mnuClear.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.mnuClear.Size = new System.Drawing.Size(144, 22);
			this.mnuClear.Text = "Clear";
			this.mnuClear.Click += new System.EventHandler(this.mnuClear_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPriviousSize,
            this.mnuNextSize,
            this.toolStripSeparator4,
            this.mnuSelect});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			this.viewToolStripMenuItem.DropDownOpening += new System.EventHandler(this.viewToolStripMenuItem_DropDownOpening);
			// 
			// mnuPriviousSize
			// 
			this.mnuPriviousSize.Image = global::IconGenFromSVG.Properties.Resources.Previous_16x;
			this.mnuPriviousSize.Name = "mnuPriviousSize";
			this.mnuPriviousSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
			this.mnuPriviousSize.Size = new System.Drawing.Size(179, 22);
			this.mnuPriviousSize.Text = "Previous Size";
			this.mnuPriviousSize.Click += new System.EventHandler(this.mnuPreviousSize_Click);
			// 
			// mnuNextSize
			// 
			this.mnuNextSize.Image = global::IconGenFromSVG.Properties.Resources.Next_16x;
			this.mnuNextSize.Name = "mnuNextSize";
			this.mnuNextSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
			this.mnuNextSize.Size = new System.Drawing.Size(179, 22);
			this.mnuNextSize.Text = "Next Size";
			this.mnuNextSize.Click += new System.EventHandler(this.mnuNextSize_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
			// 
			// mnuSelect
			// 
			this.mnuSelect.Image = global::IconGenFromSVG.Properties.Resources.ImageScale_16x;
			this.mnuSelect.Name = "mnuSelect";
			this.mnuSelect.Size = new System.Drawing.Size(179, 22);
			this.mnuSelect.Text = "Select Display Size...";
			this.mnuSelect.Click += new System.EventHandler(this.mnuSelect_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus,
            this.txtSize,
            this.txtCurSize});
			this.statusStrip1.Location = new System.Drawing.Point(0, 532);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(850, 24);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// txtStatus
			// 
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(591, 19);
			this.txtStatus.Spring = true;
			this.txtStatus.Text = "toolStripStatusLabel1";
			this.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSize
			// 
			this.txtSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.txtSize.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
			this.txtSize.Name = "txtSize";
			this.txtSize.Size = new System.Drawing.Size(122, 19);
			this.txtSize.Text = "toolStripStatusLabel2";
			// 
			// txtCurSize
			// 
			this.txtCurSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
			this.txtCurSize.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
			this.txtCurSize.Name = "txtCurSize";
			this.txtCurSize.Size = new System.Drawing.Size(122, 19);
			this.txtCurSize.Text = "toolStripStatusLabel3";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtFileName);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(743, 53);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input SVG File";
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(6, 22);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(721, 23);
			this.txtFileName.TabIndex = 0;
			this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ckSize256);
			this.groupBox2.Controls.Add(this.ckSize128);
			this.groupBox2.Controls.Add(this.ckSize64);
			this.groupBox2.Controls.Add(this.ckSize48);
			this.groupBox2.Controls.Add(this.ckSize32);
			this.groupBox2.Controls.Add(this.ckSize24);
			this.groupBox2.Controls.Add(this.ckSize16);
			this.groupBox2.Controls.Add(this.ckSize8);
			this.groupBox2.Location = new System.Drawing.Point(12, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(554, 43);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Select Desired Icon Sizes";
			// 
			// ckSize256
			// 
			this.ckSize256.AutoSize = true;
			this.ckSize256.Location = new System.Drawing.Point(466, 18);
			this.ckSize256.Name = "ckSize256";
			this.ckSize256.Size = new System.Drawing.Size(57, 19);
			this.ckSize256.TabIndex = 7;
			this.ckSize256.Text = "256px";
			this.ckSize256.UseVisualStyleBackColor = true;
			this.ckSize256.CheckedChanged += new System.EventHandler(this.sizeIconChanged);
			// 
			// ckSize128
			// 
			this.ckSize128.AutoSize = true;
			this.ckSize128.Location = new System.Drawing.Point(398, 18);
			this.ckSize128.Name = "ckSize128";
			this.ckSize128.Size = new System.Drawing.Size(57, 19);
			this.ckSize128.TabIndex = 6;
			this.ckSize128.Text = "128px";
			this.ckSize128.UseVisualStyleBackColor = true;
			this.ckSize128.CheckedChanged += new System.EventHandler(this.sizeIconChanged);
			// 
			// ckSize64
			// 
			this.ckSize64.AutoSize = true;
			this.ckSize64.Location = new System.Drawing.Point(336, 18);
			this.ckSize64.Name = "ckSize64";
			this.ckSize64.Size = new System.Drawing.Size(51, 19);
			this.ckSize64.TabIndex = 5;
			this.ckSize64.Text = "64px";
			this.ckSize64.UseVisualStyleBackColor = true;
			this.ckSize64.CheckedChanged += new System.EventHandler(this.sizeIconChanged);
			// 
			// ckSize48
			// 
			this.ckSize48.AutoSize = true;
			this.ckSize48.Location = new System.Drawing.Point(274, 18);
			this.ckSize48.Name = "ckSize48";
			this.ckSize48.Size = new System.Drawing.Size(51, 19);
			this.ckSize48.TabIndex = 4;
			this.ckSize48.Text = "48px";
			this.ckSize48.UseVisualStyleBackColor = true;
			this.ckSize48.CheckedChanged += new System.EventHandler(this.sizeIconChanged);
			// 
			// ckSize32
			// 
			this.ckSize32.AutoSize = true;
			this.ckSize32.Location = new System.Drawing.Point(212, 18);
			this.ckSize32.Name = "ckSize32";
			this.ckSize32.Size = new System.Drawing.Size(51, 19);
			this.ckSize32.TabIndex = 3;
			this.ckSize32.Text = "32px";
			this.ckSize32.UseVisualStyleBackColor = true;
			this.ckSize32.CheckedChanged += new System.EventHandler(this.sizeIconChanged);
			// 
			// ckSize24
			// 
			this.ckSize24.AutoSize = true;
			this.ckSize24.Location = new System.Drawing.Point(150, 18);
			this.ckSize24.Name = "ckSize24";
			this.ckSize24.Size = new System.Drawing.Size(51, 19);
			this.ckSize24.TabIndex = 2;
			this.ckSize24.Text = "24px";
			this.ckSize24.UseVisualStyleBackColor = true;
			this.ckSize24.CheckedChanged += new System.EventHandler(this.sizeIconChanged);
			// 
			// ckSize16
			// 
			this.ckSize16.AutoSize = true;
			this.ckSize16.Location = new System.Drawing.Point(88, 18);
			this.ckSize16.Name = "ckSize16";
			this.ckSize16.Size = new System.Drawing.Size(51, 19);
			this.ckSize16.TabIndex = 1;
			this.ckSize16.Text = "16px";
			this.ckSize16.UseVisualStyleBackColor = true;
			this.ckSize16.CheckedChanged += new System.EventHandler(this.sizeIconChanged);
			// 
			// ckSize8
			// 
			this.ckSize8.AutoSize = true;
			this.ckSize8.Location = new System.Drawing.Point(32, 18);
			this.ckSize8.Name = "ckSize8";
			this.ckSize8.Size = new System.Drawing.Size(45, 19);
			this.ckSize8.TabIndex = 0;
			this.ckSize8.Text = "8px";
			this.ckSize8.UseVisualStyleBackColor = true;
			this.ckSize8.CheckedChanged += new System.EventHandler(this.sizeIconChanged);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.pictConvertedImage);
			this.panel1.Location = new System.Drawing.Point(12, 135);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(826, 394);
			this.panel1.TabIndex = 4;
			// 
			// pictConvertedImage
			// 
			this.pictConvertedImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictConvertedImage.Location = new System.Drawing.Point(0, 0);
			this.pictConvertedImage.Name = "pictConvertedImage";
			this.pictConvertedImage.Size = new System.Drawing.Size(826, 394);
			this.pictConvertedImage.TabIndex = 0;
			this.pictConvertedImage.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "svg";
			this.openFileDialog1.Filter = "SVG File|*.svg|All Files|*.*";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "png";
			this.saveFileDialog1.Filter = "PNG File|*.png|JPG File|*.jpg|Bitmap File|*.bmp|All Files|*.*";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 556);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Icon File Generator from SVG Image";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictConvertedImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem mnuOpenSVG;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem mnuSaveIcon;
		private ToolStripMenuItem mnuSaveImage;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem mnuExit;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem mnuCut;
		private ToolStripMenuItem mnuCopy;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem mnuClear;
		private ToolStripMenuItem viewToolStripMenuItem;
		private ToolStripMenuItem mnuPriviousSize;
		private ToolStripMenuItem mnuNextSize;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripMenuItem mnuSelect;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel txtStatus;
		private ToolStripStatusLabel txtSize;
		private ToolStripStatusLabel txtCurSize;
		private GroupBox groupBox1;
		private TextBox txtFileName;
		private GroupBox groupBox2;
		private CheckBox ckSize256;
		private CheckBox ckSize128;
		private CheckBox ckSize64;
		private CheckBox ckSize48;
		private CheckBox ckSize32;
		private CheckBox ckSize24;
		private CheckBox ckSize16;
		private CheckBox ckSize8;
		private Panel panel1;
		private PictureBox pictConvertedImage;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog saveFileDialog1;
	}
}