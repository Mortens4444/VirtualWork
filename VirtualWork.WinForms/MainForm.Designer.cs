namespace VirtualWork.WinForms
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Issues", 1, 1);
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Events", 3, 3);
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Meetings", 2, 2);
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Servers");
			this.pMain = new System.Windows.Forms.Panel();
			this.pContent = new System.Windows.Forms.Panel();
			this.pRight = new System.Windows.Forms.Panel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tpTaskboard = new System.Windows.Forms.TabPage();
			this.taskboard = new VirtualWork.WinForms.Controls.Taskboard();
			this.tpFileExplorer = new System.Windows.Forms.TabPage();
			this.pFileExplorerMain = new System.Windows.Forms.Panel();
			this.pFileExlorer = new System.Windows.Forms.Panel();
			this.pFileExplorerRight = new System.Windows.Forms.Panel();
			this.lvFileExplorerRight = new System.Windows.Forms.ListView();
			this.chFileExplorerRightFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFileExplorerRightFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.images = new System.Windows.Forms.ImageList(this.components);
			this.pFileExplorerRightHeader = new System.Windows.Forms.Panel();
			this.cbDrive2 = new System.Windows.Forms.ComboBox();
			this.lblDrive2 = new System.Windows.Forms.Label();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.pFileExplorerLeft = new System.Windows.Forms.Panel();
			this.lvFileExplorerLeft = new System.Windows.Forms.ListView();
			this.chFileExplorerLeftFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFileExplorerLeftFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pFileExplorerLeftHeader = new System.Windows.Forms.Panel();
			this.cbDrive = new System.Windows.Forms.ComboBox();
			this.lblDrive = new System.Windows.Forms.Label();
			this.pFileExplorerFooter = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnNewFolder = new System.Windows.Forms.Button();
			this.btnMove = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.cbCommandPrompt = new System.Windows.Forms.ComboBox();
			this.lblWorkingDirectory = new System.Windows.Forms.Label();
			this.tpBrowser = new System.Windows.Forms.TabPage();
			this.pBrowser = new System.Windows.Forms.Panel();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.pBrowserHeader = new System.Windows.Forms.Panel();
			this.btnVisit = new System.Windows.Forms.Button();
			this.tbWebAddress = new System.Windows.Forms.TextBox();
			this.tpCalendar = new System.Windows.Forms.TabPage();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.cbView = new System.Windows.Forms.ComboBox();
			this.lblView = new System.Windows.Forms.Label();
			this.dgvCalendar = new System.Windows.Forms.DataGridView();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pLeft = new System.Windows.Forms.Panel();
			this.tvItems = new System.Windows.Forms.TreeView();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmiNewIssue = new System.Windows.Forms.ToolStripMenuItem();
			this.cmiNewEvent = new System.Windows.Forms.ToolStripMenuItem();
			this.cmiNewMeeting = new System.Windows.Forms.ToolStripMenuItem();
			this.cmiCreateServer = new System.Windows.Forms.ToolStripMenuItem();
			this.cmiCreateCamera = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslPlaceHolder = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.tssbOpenCmd = new System.Windows.Forms.ToolStripSplitButton();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNewIssue = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNewEvent = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNewMeeting = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiNewServer = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNewCamera = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDatabaseSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEmailSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUserManagement = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUserProfile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUserSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.pMain.SuspendLayout();
			this.pContent.SuspendLayout();
			this.pRight.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tpTaskboard.SuspendLayout();
			this.tpFileExplorer.SuspendLayout();
			this.pFileExplorerMain.SuspendLayout();
			this.pFileExlorer.SuspendLayout();
			this.pFileExplorerRight.SuspendLayout();
			this.pFileExplorerRightHeader.SuspendLayout();
			this.pFileExplorerLeft.SuspendLayout();
			this.pFileExplorerLeftHeader.SuspendLayout();
			this.pFileExplorerFooter.SuspendLayout();
			this.tpBrowser.SuspendLayout();
			this.pBrowser.SuspendLayout();
			this.pBrowserHeader.SuspendLayout();
			this.tpCalendar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
			this.pLeft.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.pContent);
			this.pMain.Controls.Add(this.statusStrip);
			this.pMain.Controls.Add(this.menuStrip);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(941, 512);
			this.pMain.TabIndex = 0;
			// 
			// pContent
			// 
			this.pContent.Controls.Add(this.pRight);
			this.pContent.Controls.Add(this.splitter1);
			this.pContent.Controls.Add(this.pLeft);
			this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pContent.Location = new System.Drawing.Point(0, 24);
			this.pContent.Name = "pContent";
			this.pContent.Size = new System.Drawing.Size(941, 466);
			this.pContent.TabIndex = 2;
			// 
			// pRight
			// 
			this.pRight.Controls.Add(this.tabControl);
			this.pRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pRight.Location = new System.Drawing.Point(203, 0);
			this.pRight.Name = "pRight";
			this.pRight.Size = new System.Drawing.Size(738, 466);
			this.pRight.TabIndex = 2;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tpTaskboard);
			this.tabControl.Controls.Add(this.tpFileExplorer);
			this.tabControl.Controls.Add(this.tpBrowser);
			this.tabControl.Controls.Add(this.tpCalendar);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(738, 466);
			this.tabControl.TabIndex = 0;
			// 
			// tpTaskboard
			// 
			this.tpTaskboard.Controls.Add(this.taskboard);
			this.tpTaskboard.Location = new System.Drawing.Point(4, 22);
			this.tpTaskboard.Name = "tpTaskboard";
			this.tpTaskboard.Padding = new System.Windows.Forms.Padding(3);
			this.tpTaskboard.Size = new System.Drawing.Size(730, 440);
			this.tpTaskboard.TabIndex = 0;
			this.tpTaskboard.Text = "Taskboard";
			this.tpTaskboard.UseVisualStyleBackColor = true;
			// 
			// taskboard
			// 
			this.taskboard.AutoScroll = true;
			this.taskboard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskboard.Location = new System.Drawing.Point(3, 3);
			this.taskboard.Name = "taskboard";
			this.taskboard.Size = new System.Drawing.Size(724, 434);
			this.taskboard.TabIndex = 0;
			// 
			// tpFileExplorer
			// 
			this.tpFileExplorer.Controls.Add(this.pFileExplorerMain);
			this.tpFileExplorer.Location = new System.Drawing.Point(4, 22);
			this.tpFileExplorer.Name = "tpFileExplorer";
			this.tpFileExplorer.Padding = new System.Windows.Forms.Padding(3);
			this.tpFileExplorer.Size = new System.Drawing.Size(730, 440);
			this.tpFileExplorer.TabIndex = 1;
			this.tpFileExplorer.Text = "File explorer";
			this.tpFileExplorer.UseVisualStyleBackColor = true;
			// 
			// pFileExplorerMain
			// 
			this.pFileExplorerMain.Controls.Add(this.pFileExlorer);
			this.pFileExplorerMain.Controls.Add(this.pFileExplorerFooter);
			this.pFileExplorerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pFileExplorerMain.Location = new System.Drawing.Point(3, 3);
			this.pFileExplorerMain.Name = "pFileExplorerMain";
			this.pFileExplorerMain.Size = new System.Drawing.Size(724, 434);
			this.pFileExplorerMain.TabIndex = 0;
			// 
			// pFileExlorer
			// 
			this.pFileExlorer.Controls.Add(this.pFileExplorerRight);
			this.pFileExlorer.Controls.Add(this.splitter2);
			this.pFileExlorer.Controls.Add(this.pFileExplorerLeft);
			this.pFileExlorer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pFileExlorer.Location = new System.Drawing.Point(0, 0);
			this.pFileExlorer.Name = "pFileExlorer";
			this.pFileExlorer.Size = new System.Drawing.Size(724, 355);
			this.pFileExlorer.TabIndex = 3;
			this.pFileExlorer.SizeChanged += new System.EventHandler(this.PFileExlorer_SizeChanged);
			// 
			// pFileExplorerRight
			// 
			this.pFileExplorerRight.Controls.Add(this.lvFileExplorerRight);
			this.pFileExplorerRight.Controls.Add(this.pFileExplorerRightHeader);
			this.pFileExplorerRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pFileExplorerRight.Location = new System.Drawing.Point(289, 0);
			this.pFileExplorerRight.Name = "pFileExplorerRight";
			this.pFileExplorerRight.Size = new System.Drawing.Size(435, 355);
			this.pFileExplorerRight.TabIndex = 2;
			// 
			// lvFileExplorerRight
			// 
			this.lvFileExplorerRight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileExplorerRightFilename,
            this.chFileExplorerRightFileSize});
			this.lvFileExplorerRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvFileExplorerRight.FullRowSelect = true;
			this.lvFileExplorerRight.HideSelection = false;
			this.lvFileExplorerRight.Location = new System.Drawing.Point(0, 33);
			this.lvFileExplorerRight.Name = "lvFileExplorerRight";
			this.lvFileExplorerRight.Size = new System.Drawing.Size(435, 322);
			this.lvFileExplorerRight.SmallImageList = this.images;
			this.lvFileExplorerRight.TabIndex = 2;
			this.lvFileExplorerRight.UseCompatibleStateImageBehavior = false;
			this.lvFileExplorerRight.View = System.Windows.Forms.View.Details;
			this.lvFileExplorerRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LvFileExplorerRight_KeyPress);
			this.lvFileExplorerRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvFileExplorerRight_MouseDoubleClick);
			// 
			// chFileExplorerRightFilename
			// 
			this.chFileExplorerRightFilename.Text = "Name";
			this.chFileExplorerRightFilename.Width = 195;
			// 
			// chFileExplorerRightFileSize
			// 
			this.chFileExplorerRightFileSize.Text = "Size";
			this.chFileExplorerRightFileSize.Width = 85;
			// 
			// images
			// 
			this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
			this.images.TransparentColor = System.Drawing.Color.Transparent;
			this.images.Images.SetKeyName(0, "server");
			this.images.Images.SetKeyName(1, "issue");
			this.images.Images.SetKeyName(2, "clock");
			this.images.Images.SetKeyName(3, "event");
			this.images.Images.SetKeyName(4, "folder");
			this.images.Images.SetKeyName(5, "file");
			this.images.Images.SetKeyName(6, "mdb");
			this.images.Images.SetKeyName(7, "csv");
			this.images.Images.SetKeyName(8, "xls");
			this.images.Images.SetKeyName(9, "avi");
			this.images.Images.SetKeyName(10, "mp3");
			this.images.Images.SetKeyName(11, "pdf");
			this.images.Images.SetKeyName(12, "cpp");
			this.images.Images.SetKeyName(13, "cs");
			this.images.Images.SetKeyName(14, "php");
			this.images.Images.SetKeyName(15, "txt");
			this.images.Images.SetKeyName(16, "doc");
			this.images.Images.SetKeyName(17, "url");
			this.images.Images.SetKeyName(18, "xml");
			this.images.Images.SetKeyName(19, "exe");
			this.images.Images.SetKeyName(20, "com");
			this.images.Images.SetKeyName(21, "css");
			this.images.Images.SetKeyName(22, "html");
			this.images.Images.SetKeyName(23, "reg");
			this.images.Images.SetKeyName(24, "script");
			this.images.Images.SetKeyName(25, "msi");
			this.images.Images.SetKeyName(26, "wav");
			this.images.Images.SetKeyName(27, "image");
			this.images.Images.SetKeyName(28, "compress");
			this.images.Images.SetKeyName(29, "cursor.ico");
			this.images.Images.SetKeyName(30, "help");
			this.images.Images.SetKeyName(31, "security-camera.ico");
			this.images.Images.SetKeyName(32, "bug.ico");
			this.images.Images.SetKeyName(33, "tick.ico");
			// 
			// pFileExplorerRightHeader
			// 
			this.pFileExplorerRightHeader.Controls.Add(this.cbDrive2);
			this.pFileExplorerRightHeader.Controls.Add(this.lblDrive2);
			this.pFileExplorerRightHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pFileExplorerRightHeader.Location = new System.Drawing.Point(0, 0);
			this.pFileExplorerRightHeader.Name = "pFileExplorerRightHeader";
			this.pFileExplorerRightHeader.Size = new System.Drawing.Size(435, 33);
			this.pFileExplorerRightHeader.TabIndex = 1;
			// 
			// cbDrive2
			// 
			this.cbDrive2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDrive2.FormattingEnabled = true;
			this.cbDrive2.Location = new System.Drawing.Point(74, 6);
			this.cbDrive2.Name = "cbDrive2";
			this.cbDrive2.Size = new System.Drawing.Size(121, 21);
			this.cbDrive2.TabIndex = 3;
			this.cbDrive2.SelectedIndexChanged += new System.EventHandler(this.CbDrive2_SelectedIndexChanged);
			// 
			// lblDrive2
			// 
			this.lblDrive2.AutoSize = true;
			this.lblDrive2.Location = new System.Drawing.Point(6, 9);
			this.lblDrive2.Name = "lblDrive2";
			this.lblDrive2.Size = new System.Drawing.Size(32, 13);
			this.lblDrive2.TabIndex = 2;
			this.lblDrive2.Text = "Drive";
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(286, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 355);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// pFileExplorerLeft
			// 
			this.pFileExplorerLeft.Controls.Add(this.lvFileExplorerLeft);
			this.pFileExplorerLeft.Controls.Add(this.pFileExplorerLeftHeader);
			this.pFileExplorerLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pFileExplorerLeft.Location = new System.Drawing.Point(0, 0);
			this.pFileExplorerLeft.Name = "pFileExplorerLeft";
			this.pFileExplorerLeft.Size = new System.Drawing.Size(286, 355);
			this.pFileExplorerLeft.TabIndex = 0;
			// 
			// lvFileExplorerLeft
			// 
			this.lvFileExplorerLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileExplorerLeftFilename,
            this.chFileExplorerLeftFileSize});
			this.lvFileExplorerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvFileExplorerLeft.FullRowSelect = true;
			this.lvFileExplorerLeft.HideSelection = false;
			this.lvFileExplorerLeft.Location = new System.Drawing.Point(0, 33);
			this.lvFileExplorerLeft.Name = "lvFileExplorerLeft";
			this.lvFileExplorerLeft.Size = new System.Drawing.Size(286, 322);
			this.lvFileExplorerLeft.SmallImageList = this.images;
			this.lvFileExplorerLeft.TabIndex = 1;
			this.lvFileExplorerLeft.UseCompatibleStateImageBehavior = false;
			this.lvFileExplorerLeft.View = System.Windows.Forms.View.Details;
			this.lvFileExplorerLeft.Enter += new System.EventHandler(this.ListView_Enter);
			this.lvFileExplorerLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LvFileExplorerLeft_KeyPress);
			this.lvFileExplorerLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvFileExplorerLeft_MouseDoubleClick);
			// 
			// chFileExplorerLeftFilename
			// 
			this.chFileExplorerLeftFilename.Text = "Name";
			this.chFileExplorerLeftFilename.Width = 195;
			// 
			// chFileExplorerLeftFileSize
			// 
			this.chFileExplorerLeftFileSize.Text = "Size";
			this.chFileExplorerLeftFileSize.Width = 85;
			// 
			// pFileExplorerLeftHeader
			// 
			this.pFileExplorerLeftHeader.Controls.Add(this.cbDrive);
			this.pFileExplorerLeftHeader.Controls.Add(this.lblDrive);
			this.pFileExplorerLeftHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pFileExplorerLeftHeader.Location = new System.Drawing.Point(0, 0);
			this.pFileExplorerLeftHeader.Name = "pFileExplorerLeftHeader";
			this.pFileExplorerLeftHeader.Size = new System.Drawing.Size(286, 33);
			this.pFileExplorerLeftHeader.TabIndex = 0;
			// 
			// cbDrive
			// 
			this.cbDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDrive.FormattingEnabled = true;
			this.cbDrive.Location = new System.Drawing.Point(73, 7);
			this.cbDrive.Name = "cbDrive";
			this.cbDrive.Size = new System.Drawing.Size(121, 21);
			this.cbDrive.TabIndex = 1;
			this.cbDrive.SelectedIndexChanged += new System.EventHandler(this.CbDrive_SelectedIndexChanged);
			// 
			// lblDrive
			// 
			this.lblDrive.AutoSize = true;
			this.lblDrive.Location = new System.Drawing.Point(5, 10);
			this.lblDrive.Name = "lblDrive";
			this.lblDrive.Size = new System.Drawing.Size(32, 13);
			this.lblDrive.TabIndex = 0;
			this.lblDrive.Text = "Drive";
			// 
			// pFileExplorerFooter
			// 
			this.pFileExplorerFooter.Controls.Add(this.btnDelete);
			this.pFileExplorerFooter.Controls.Add(this.btnNewFolder);
			this.pFileExplorerFooter.Controls.Add(this.btnMove);
			this.pFileExplorerFooter.Controls.Add(this.btnCopy);
			this.pFileExplorerFooter.Controls.Add(this.cbCommandPrompt);
			this.pFileExplorerFooter.Controls.Add(this.lblWorkingDirectory);
			this.pFileExplorerFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pFileExplorerFooter.Location = new System.Drawing.Point(0, 355);
			this.pFileExplorerFooter.Name = "pFileExplorerFooter";
			this.pFileExplorerFooter.Size = new System.Drawing.Size(724, 79);
			this.pFileExplorerFooter.TabIndex = 2;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(251, 9);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Visible = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnNewFolder
			// 
			this.btnNewFolder.Location = new System.Drawing.Point(170, 9);
			this.btnNewFolder.Name = "btnNewFolder";
			this.btnNewFolder.Size = new System.Drawing.Size(75, 23);
			this.btnNewFolder.TabIndex = 4;
			this.btnNewFolder.Text = "New folder";
			this.btnNewFolder.UseVisualStyleBackColor = true;
			this.btnNewFolder.Visible = false;
			this.btnNewFolder.Click += new System.EventHandler(this.BtnNewFolder_Click);
			// 
			// btnMove
			// 
			this.btnMove.Location = new System.Drawing.Point(89, 9);
			this.btnMove.Name = "btnMove";
			this.btnMove.Size = new System.Drawing.Size(75, 23);
			this.btnMove.TabIndex = 3;
			this.btnMove.Text = "Move";
			this.btnMove.UseVisualStyleBackColor = true;
			this.btnMove.Visible = false;
			this.btnMove.Click += new System.EventHandler(this.BtnMove_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(8, 9);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 2;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
			// 
			// cbCommandPrompt
			// 
			this.cbCommandPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCommandPrompt.FormattingEnabled = true;
			this.cbCommandPrompt.Location = new System.Drawing.Point(8, 55);
			this.cbCommandPrompt.Name = "cbCommandPrompt";
			this.cbCommandPrompt.Size = new System.Drawing.Size(711, 21);
			this.cbCommandPrompt.TabIndex = 1;
			this.cbCommandPrompt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbCommandPrompt_KeyDown);
			// 
			// lblWorkingDirectory
			// 
			this.lblWorkingDirectory.AutoSize = true;
			this.lblWorkingDirectory.Location = new System.Drawing.Point(5, 38);
			this.lblWorkingDirectory.Name = "lblWorkingDirectory";
			this.lblWorkingDirectory.Size = new System.Drawing.Size(90, 13);
			this.lblWorkingDirectory.TabIndex = 0;
			this.lblWorkingDirectory.Text = "Working directory";
			// 
			// tpBrowser
			// 
			this.tpBrowser.Controls.Add(this.pBrowser);
			this.tpBrowser.Location = new System.Drawing.Point(4, 22);
			this.tpBrowser.Name = "tpBrowser";
			this.tpBrowser.Padding = new System.Windows.Forms.Padding(3);
			this.tpBrowser.Size = new System.Drawing.Size(730, 440);
			this.tpBrowser.TabIndex = 2;
			this.tpBrowser.Text = "Browser";
			this.tpBrowser.UseVisualStyleBackColor = true;
			// 
			// pBrowser
			// 
			this.pBrowser.Controls.Add(this.webBrowser);
			this.pBrowser.Controls.Add(this.pBrowserHeader);
			this.pBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pBrowser.Location = new System.Drawing.Point(3, 3);
			this.pBrowser.Name = "pBrowser";
			this.pBrowser.Size = new System.Drawing.Size(724, 434);
			this.pBrowser.TabIndex = 0;
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 26);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(724, 408);
			this.webBrowser.TabIndex = 1;
			this.webBrowser.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
			// 
			// pBrowserHeader
			// 
			this.pBrowserHeader.Controls.Add(this.btnVisit);
			this.pBrowserHeader.Controls.Add(this.tbWebAddress);
			this.pBrowserHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pBrowserHeader.Location = new System.Drawing.Point(0, 0);
			this.pBrowserHeader.Name = "pBrowserHeader";
			this.pBrowserHeader.Size = new System.Drawing.Size(724, 26);
			this.pBrowserHeader.TabIndex = 0;
			// 
			// btnVisit
			// 
			this.btnVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnVisit.Image = global::VirtualWork.WinForms.Properties.Resources.arrow_right_2;
			this.btnVisit.Location = new System.Drawing.Point(689, 1);
			this.btnVisit.Name = "btnVisit";
			this.btnVisit.Size = new System.Drawing.Size(31, 23);
			this.btnVisit.TabIndex = 1;
			this.btnVisit.UseVisualStyleBackColor = true;
			this.btnVisit.Click += new System.EventHandler(this.BtnVisit_Click);
			// 
			// tbWebAddress
			// 
			this.tbWebAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbWebAddress.Location = new System.Drawing.Point(2, 3);
			this.tbWebAddress.Name = "tbWebAddress";
			this.tbWebAddress.Size = new System.Drawing.Size(687, 20);
			this.tbWebAddress.TabIndex = 0;
			this.tbWebAddress.Text = "https://www.google.com";
			// 
			// tpCalendar
			// 
			this.tpCalendar.Controls.Add(this.monthCalendar1);
			this.tpCalendar.Controls.Add(this.cbView);
			this.tpCalendar.Controls.Add(this.lblView);
			this.tpCalendar.Controls.Add(this.dgvCalendar);
			this.tpCalendar.Controls.Add(this.dateTimePicker);
			this.tpCalendar.Location = new System.Drawing.Point(4, 22);
			this.tpCalendar.Name = "tpCalendar";
			this.tpCalendar.Padding = new System.Windows.Forms.Padding(3);
			this.tpCalendar.Size = new System.Drawing.Size(730, 440);
			this.tpCalendar.TabIndex = 3;
			this.tpCalendar.Text = "Calendar";
			this.tpCalendar.UseVisualStyleBackColor = true;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(12, 72);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 4;
			// 
			// cbView
			// 
			this.cbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbView.FormattingEnabled = true;
			this.cbView.Location = new System.Drawing.Point(78, 11);
			this.cbView.Name = "cbView";
			this.cbView.Size = new System.Drawing.Size(121, 21);
			this.cbView.TabIndex = 3;
			// 
			// lblView
			// 
			this.lblView.AutoSize = true;
			this.lblView.Location = new System.Drawing.Point(9, 14);
			this.lblView.Name = "lblView";
			this.lblView.Size = new System.Drawing.Size(30, 13);
			this.lblView.TabIndex = 2;
			this.lblView.Text = "View";
			// 
			// dgvCalendar
			// 
			this.dgvCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCalendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCalendar.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCalendar.Location = new System.Drawing.Point(214, 11);
			this.dgvCalendar.Name = "dgvCalendar";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCalendar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvCalendar.Size = new System.Drawing.Size(510, 423);
			this.dgvCalendar.TabIndex = 1;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(6, 40);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(193, 20);
			this.dateTimePicker.TabIndex = 0;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(200, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 466);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// pLeft
			// 
			this.pLeft.Controls.Add(this.tvItems);
			this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pLeft.Location = new System.Drawing.Point(0, 0);
			this.pLeft.Name = "pLeft";
			this.pLeft.Size = new System.Drawing.Size(200, 466);
			this.pLeft.TabIndex = 0;
			// 
			// tvItems
			// 
			this.tvItems.ContextMenuStrip = this.contextMenuStrip;
			this.tvItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvItems.ImageIndex = 0;
			this.tvItems.ImageList = this.images;
			this.tvItems.Location = new System.Drawing.Point(0, 0);
			this.tvItems.Name = "tvItems";
			treeNode1.ImageIndex = 1;
			treeNode1.Name = "Issues";
			treeNode1.SelectedImageIndex = 1;
			treeNode1.Text = "Issues";
			treeNode2.ImageIndex = 3;
			treeNode2.Name = "Events";
			treeNode2.SelectedImageIndex = 3;
			treeNode2.Text = "Events";
			treeNode3.ImageIndex = 2;
			treeNode3.Name = "Meetings";
			treeNode3.SelectedImageIndex = 2;
			treeNode3.Text = "Meetings";
			treeNode4.Name = "Servers";
			treeNode4.Text = "Servers";
			this.tvItems.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
			this.tvItems.SelectedImageIndex = 0;
			this.tvItems.Size = new System.Drawing.Size(200, 466);
			this.tvItems.TabIndex = 0;
			this.tvItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TvItems_MouseDown);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiNewIssue,
            this.cmiNewEvent,
            this.cmiNewMeeting,
            this.cmiCreateServer,
            this.cmiCreateCamera});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(181, 136);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
			// 
			// cmiNewIssue
			// 
			this.cmiNewIssue.Image = global::VirtualWork.WinForms.Properties.Resources.operation;
			this.cmiNewIssue.Name = "cmiNewIssue";
			this.cmiNewIssue.Size = new System.Drawing.Size(180, 22);
			this.cmiNewIssue.Text = "New issue";
			this.cmiNewIssue.Click += new System.EventHandler(this.TsmiNewIssue_Click);
			// 
			// cmiNewEvent
			// 
			this.cmiNewEvent.Image = global::VirtualWork.WinForms.Properties.Resources.event2;
			this.cmiNewEvent.Name = "cmiNewEvent";
			this.cmiNewEvent.Size = new System.Drawing.Size(180, 22);
			this.cmiNewEvent.Text = "New event";
			this.cmiNewEvent.Click += new System.EventHandler(this.TsmiNewEvent_Click);
			// 
			// cmiNewMeeting
			// 
			this.cmiNewMeeting.Image = global::VirtualWork.WinForms.Properties.Resources.clock;
			this.cmiNewMeeting.Name = "cmiNewMeeting";
			this.cmiNewMeeting.Size = new System.Drawing.Size(180, 22);
			this.cmiNewMeeting.Text = "New meeting";
			this.cmiNewMeeting.Click += new System.EventHandler(this.TsmiNewEvent_Click);
			// 
			// cmiCreateServer
			// 
			this.cmiCreateServer.Image = global::VirtualWork.WinForms.Properties.Resources.computer;
			this.cmiCreateServer.Name = "cmiCreateServer";
			this.cmiCreateServer.Size = new System.Drawing.Size(180, 22);
			this.cmiCreateServer.Text = "Create server";
			this.cmiCreateServer.Click += new System.EventHandler(this.TsmiNewServer_Click);
			// 
			// cmiCreateCamera
			// 
			this.cmiCreateCamera.Image = global::VirtualWork.WinForms.Properties.Resources.security_camera;
			this.cmiCreateCamera.Name = "cmiCreateCamera";
			this.cmiCreateCamera.Size = new System.Drawing.Size(180, 22);
			this.cmiCreateCamera.Text = "Create camera";
			this.cmiCreateCamera.Click += new System.EventHandler(this.TsmiNewCamera_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDate,
            this.tsslPlaceHolder,
            this.toolStripSplitButton1,
            this.tssbOpenCmd});
			this.statusStrip.Location = new System.Drawing.Point(0, 490);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(941, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// tsslDate
			// 
			this.tsslDate.Name = "tsslDate";
			this.tsslDate.Size = new System.Drawing.Size(0, 17);
			// 
			// tsslPlaceHolder
			// 
			this.tsslPlaceHolder.Name = "tsslPlaceHolder";
			this.tsslPlaceHolder.Size = new System.Drawing.Size(884, 17);
			this.tsslPlaceHolder.Spring = true;
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton1.DropDownButtonWidth = 0;
			this.toolStripSplitButton1.Image = global::VirtualWork.WinForms.Properties.Resources.powershell_ise;
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(21, 20);
			this.toolStripSplitButton1.Text = "PowerShell ISE";
			this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.TssbOpenPowerShellIse_ButtonClick);
			// 
			// tssbOpenCmd
			// 
			this.tssbOpenCmd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tssbOpenCmd.DropDownButtonWidth = 0;
			this.tssbOpenCmd.Image = ((System.Drawing.Image)(resources.GetObject("tssbOpenCmd.Image")));
			this.tssbOpenCmd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tssbOpenCmd.Name = "tssbOpenCmd";
			this.tssbOpenCmd.Size = new System.Drawing.Size(21, 20);
			this.tssbOpenCmd.Text = "Command prompt";
			this.tssbOpenCmd.ButtonClick += new System.EventHandler(this.TssbOpenCmd_ButtonClick);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiSettings,
            this.tsmiHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(941, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewIssue,
            this.tsmiNewEvent,
            this.tsmiNewMeeting,
            this.toolStripSeparator3,
            this.tsmiNewServer,
            this.tsmiNewCamera,
            this.toolStripSeparator2,
            this.tsmiSendEmail,
            this.toolStripSeparator1,
            this.tsmiExit});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(37, 20);
			this.tsmiFile.Text = "File";
			// 
			// tsmiNewIssue
			// 
			this.tsmiNewIssue.Image = global::VirtualWork.WinForms.Properties.Resources.operation;
			this.tsmiNewIssue.Name = "tsmiNewIssue";
			this.tsmiNewIssue.Size = new System.Drawing.Size(150, 22);
			this.tsmiNewIssue.Text = "New issue";
			this.tsmiNewIssue.Click += new System.EventHandler(this.TsmiNewIssue_Click);
			// 
			// tsmiNewEvent
			// 
			this.tsmiNewEvent.Image = global::VirtualWork.WinForms.Properties.Resources.event2;
			this.tsmiNewEvent.Name = "tsmiNewEvent";
			this.tsmiNewEvent.Size = new System.Drawing.Size(150, 22);
			this.tsmiNewEvent.Text = "New event";
			this.tsmiNewEvent.Click += new System.EventHandler(this.TsmiNewEvent_Click);
			// 
			// tsmiNewMeeting
			// 
			this.tsmiNewMeeting.Image = global::VirtualWork.WinForms.Properties.Resources.clock;
			this.tsmiNewMeeting.Name = "tsmiNewMeeting";
			this.tsmiNewMeeting.Size = new System.Drawing.Size(150, 22);
			this.tsmiNewMeeting.Text = "New meeting";
			this.tsmiNewMeeting.Click += new System.EventHandler(this.TsmiNewMeeting_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
			// 
			// tsmiNewServer
			// 
			this.tsmiNewServer.Image = global::VirtualWork.WinForms.Properties.Resources.computer;
			this.tsmiNewServer.Name = "tsmiNewServer";
			this.tsmiNewServer.Size = new System.Drawing.Size(150, 22);
			this.tsmiNewServer.Text = "Create server";
			this.tsmiNewServer.Click += new System.EventHandler(this.TsmiNewServer_Click);
			// 
			// tsmiNewCamera
			// 
			this.tsmiNewCamera.Image = global::VirtualWork.WinForms.Properties.Resources.security_camera;
			this.tsmiNewCamera.Name = "tsmiNewCamera";
			this.tsmiNewCamera.Size = new System.Drawing.Size(150, 22);
			this.tsmiNewCamera.Text = "Create camera";
			this.tsmiNewCamera.Click += new System.EventHandler(this.TsmiNewCamera_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
			// 
			// tsmiSendEmail
			// 
			this.tsmiSendEmail.Image = global::VirtualWork.WinForms.Properties.Resources.email;
			this.tsmiSendEmail.Name = "tsmiSendEmail";
			this.tsmiSendEmail.Size = new System.Drawing.Size(150, 22);
			this.tsmiSendEmail.Text = "Send e-mail";
			this.tsmiSendEmail.Click += new System.EventHandler(this.TsmiSendEmail_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Image = global::VirtualWork.WinForms.Properties.Resources.exit;
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(150, 22);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.TsmiExit_Click);
			// 
			// tsmiSettings
			// 
			this.tsmiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDatabaseSettings,
            this.tsmiEmailSettings,
            this.tsmiUserManagement,
            this.tsmiUserProfile,
            this.tsmiUserSettings});
			this.tsmiSettings.Image = global::VirtualWork.WinForms.Properties.Resources.options;
			this.tsmiSettings.Name = "tsmiSettings";
			this.tsmiSettings.Size = new System.Drawing.Size(77, 20);
			this.tsmiSettings.Text = "Settings";
			// 
			// tsmiDatabaseSettings
			// 
			this.tsmiDatabaseSettings.Image = global::VirtualWork.WinForms.Properties.Resources.database_100;
			this.tsmiDatabaseSettings.Name = "tsmiDatabaseSettings";
			this.tsmiDatabaseSettings.Size = new System.Drawing.Size(171, 22);
			this.tsmiDatabaseSettings.Text = "Database settings";
			this.tsmiDatabaseSettings.Click += new System.EventHandler(this.TsmiDatabaseSettings_Click);
			// 
			// tsmiEmailSettings
			// 
			this.tsmiEmailSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEmailSettings.Image")));
			this.tsmiEmailSettings.Name = "tsmiEmailSettings";
			this.tsmiEmailSettings.Size = new System.Drawing.Size(171, 22);
			this.tsmiEmailSettings.Text = "E-mail settings";
			this.tsmiEmailSettings.Click += new System.EventHandler(this.TsmiEmailSettings_Click);
			// 
			// tsmiUserManagement
			// 
			this.tsmiUserManagement.Image = global::VirtualWork.WinForms.Properties.Resources.group;
			this.tsmiUserManagement.Name = "tsmiUserManagement";
			this.tsmiUserManagement.Size = new System.Drawing.Size(171, 22);
			this.tsmiUserManagement.Text = "User management";
			this.tsmiUserManagement.Click += new System.EventHandler(this.TsmiUserManagement_Click);
			// 
			// tsmiUserProfile
			// 
			this.tsmiUserProfile.Image = global::VirtualWork.WinForms.Properties.Resources.profile;
			this.tsmiUserProfile.Name = "tsmiUserProfile";
			this.tsmiUserProfile.Size = new System.Drawing.Size(171, 22);
			this.tsmiUserProfile.Text = "User profile";
			this.tsmiUserProfile.Click += new System.EventHandler(this.TsmiUserProfile_Click);
			// 
			// tsmiUserSettings
			// 
			this.tsmiUserSettings.Image = global::VirtualWork.WinForms.Properties.Resources.useroptions;
			this.tsmiUserSettings.Name = "tsmiUserSettings";
			this.tsmiUserSettings.Size = new System.Drawing.Size(171, 22);
			this.tsmiUserSettings.Text = "User settings";
			this.tsmiUserSettings.Click += new System.EventHandler(this.TsmiUserSettings_Click);
			// 
			// tsmiHelp
			// 
			this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
			this.tsmiHelp.Image = global::VirtualWork.WinForms.Properties.Resources.help;
			this.tsmiHelp.Name = "tsmiHelp";
			this.tsmiHelp.Size = new System.Drawing.Size(60, 20);
			this.tsmiHelp.Text = "Help";
			// 
			// tsmiAbout
			// 
			this.tsmiAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAbout.Image")));
			this.tsmiAbout.Name = "tsmiAbout";
			this.tsmiAbout.Size = new System.Drawing.Size(107, 22);
			this.tsmiAbout.Text = "About";
			this.tsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(941, 512);
			this.Controls.Add(this.pMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VIRtual Work";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.pMain.ResumeLayout(false);
			this.pMain.PerformLayout();
			this.pContent.ResumeLayout(false);
			this.pRight.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tpTaskboard.ResumeLayout(false);
			this.tpFileExplorer.ResumeLayout(false);
			this.pFileExplorerMain.ResumeLayout(false);
			this.pFileExlorer.ResumeLayout(false);
			this.pFileExplorerRight.ResumeLayout(false);
			this.pFileExplorerRightHeader.ResumeLayout(false);
			this.pFileExplorerRightHeader.PerformLayout();
			this.pFileExplorerLeft.ResumeLayout(false);
			this.pFileExplorerLeftHeader.ResumeLayout(false);
			this.pFileExplorerLeftHeader.PerformLayout();
			this.pFileExplorerFooter.ResumeLayout(false);
			this.pFileExplorerFooter.PerformLayout();
			this.tpBrowser.ResumeLayout(false);
			this.pBrowser.ResumeLayout(false);
			this.pBrowserHeader.ResumeLayout(false);
			this.pBrowserHeader.PerformLayout();
			this.tpCalendar.ResumeLayout(false);
			this.tpCalendar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
			this.pLeft.ResumeLayout(false);
			this.contextMenuStrip.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Panel pContent;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
		private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
		private System.Windows.Forms.ToolStripMenuItem tsmiDatabaseSettings;
		private System.Windows.Forms.ToolStripMenuItem tsmiNewIssue;
		private System.Windows.Forms.ToolStripMenuItem tsmiUserManagement;
		private System.Windows.Forms.ToolStripMenuItem tsmiUserSettings;
		private System.Windows.Forms.ToolStripMenuItem tsmiUserProfile;
		private System.Windows.Forms.Panel pLeft;
		private System.Windows.Forms.Panel pRight;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TreeView tvItems;
		private System.Windows.Forms.ToolStripMenuItem tsmiNewEvent;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripStatusLabel tsslDate;
		private System.Windows.Forms.ToolStripMenuItem tsmiSendEmail;
		private System.Windows.Forms.ToolStripMenuItem tsmiEmailSettings;
		private System.Windows.Forms.ToolStripMenuItem tsmiNewMeeting;
		private System.Windows.Forms.ImageList images;
		private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tpTaskboard;
		private System.Windows.Forms.TabPage tpFileExplorer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem tsmiNewServer;
		private System.Windows.Forms.ToolStripMenuItem tsmiNewCamera;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSplitButton tssbOpenCmd;
		private System.Windows.Forms.ToolStripStatusLabel tsslPlaceHolder;
		private System.Windows.Forms.Panel pFileExplorerMain;
		private System.Windows.Forms.Panel pFileExlorer;
		private System.Windows.Forms.Panel pFileExplorerRight;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel pFileExplorerLeft;
		private System.Windows.Forms.Panel pFileExplorerFooter;
		private System.Windows.Forms.Label lblWorkingDirectory;
		private System.Windows.Forms.ComboBox cbCommandPrompt;
		private System.Windows.Forms.Panel pFileExplorerRightHeader;
		private System.Windows.Forms.Panel pFileExplorerLeftHeader;
		private System.Windows.Forms.ListView lvFileExplorerRight;
		private System.Windows.Forms.ListView lvFileExplorerLeft;
		private System.Windows.Forms.ColumnHeader chFileExplorerRightFilename;
		private System.Windows.Forms.ColumnHeader chFileExplorerRightFileSize;
		private System.Windows.Forms.ColumnHeader chFileExplorerLeftFilename;
		private System.Windows.Forms.ColumnHeader chFileExplorerLeftFileSize;
		private System.Windows.Forms.TabPage tpBrowser;
		private System.Windows.Forms.Panel pBrowser;
		private System.Windows.Forms.Panel pBrowserHeader;
		private System.Windows.Forms.Button btnVisit;
		private System.Windows.Forms.TextBox tbWebAddress;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.TabPage tpCalendar;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.ComboBox cbDrive2;
		private System.Windows.Forms.Label lblDrive2;
		private System.Windows.Forms.ComboBox cbDrive;
		private System.Windows.Forms.Label lblDrive;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnNewFolder;
		private System.Windows.Forms.Button btnMove;
		private System.Windows.Forms.DataGridView dgvCalendar;
		private System.Windows.Forms.ComboBox cbView;
		private System.Windows.Forms.Label lblView;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private Controls.Taskboard taskboard;
		private System.Windows.Forms.ToolStripMenuItem cmiNewIssue;
		private System.Windows.Forms.ToolStripMenuItem cmiNewEvent;
		private System.Windows.Forms.ToolStripMenuItem cmiNewMeeting;
		private System.Windows.Forms.ToolStripMenuItem cmiCreateServer;
		private System.Windows.Forms.ToolStripMenuItem cmiCreateCamera;
	}
}

