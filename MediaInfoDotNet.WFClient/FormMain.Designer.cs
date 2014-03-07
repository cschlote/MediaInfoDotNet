namespace MediaInfoDotNet.WFClient
{
    partial class FormMain
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.editPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSettingsNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.histogramInformOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.bindingSourceMediaFiles = new System.Windows.Forms.BindingSource(this.components);
			this.tabControlMediaFileProps = new System.Windows.Forms.TabControl();
			this.tabPageInform = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageInform2 = new System.Windows.Forms.TabPage();
			this.linkLabelUrl = new System.Windows.Forms.LinkLabel();
			this.checkBoxCOmpleteInform = new System.Windows.Forms.CheckBox();
			this.labelMediaInfoLibVersion = new System.Windows.Forms.Label();
			this.textBoxInform = new System.Windows.Forms.TextBox();
			this.tabPageAttrInfo = new System.Windows.Forms.TabPage();
			this.textBoxInfoParms = new System.Windows.Forms.TextBox();
			this.tabPageCodecs = new System.Windows.Forms.TabPage();
			this.textBoxCodecs = new System.Windows.Forms.TextBox();
			this.tabPageMediaFile = new System.Windows.Forms.TabPage();
			this.propertyGridMediaFile = new System.Windows.Forms.PropertyGrid();
			this.tabPageGeneral = new System.Windows.Forms.TabPage();
			this.propertyGridGeneral = new System.Windows.Forms.PropertyGrid();
			this.tabPageVideo = new System.Windows.Forms.TabPage();
			this.userControlStreamsViewerVideo = new MediaInfoDotNet.WFClient.UserControlStreamsViewer();
			this.tabPageAudio = new System.Windows.Forms.TabPage();
			this.userControlStreamsViewerAudio = new MediaInfoDotNet.WFClient.UserControlStreamsViewer();
			this.tabPageText = new System.Windows.Forms.TabPage();
			this.userControlStreamsViewerText = new MediaInfoDotNet.WFClient.UserControlStreamsViewer();
			this.tabPageImage = new System.Windows.Forms.TabPage();
			this.userControlStreamsViewerImage = new MediaInfoDotNet.WFClient.UserControlStreamsViewer();
			this.tabPageOther = new System.Windows.Forms.TabPage();
			this.userControlStreamsViewerOther = new MediaInfoDotNet.WFClient.UserControlStreamsViewer();
			this.tabPageMenus = new System.Windows.Forms.TabPage();
			this.userControlStreamsViewerMenus = new MediaInfoDotNet.WFClient.UserControlStreamsViewer();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.treeViewFiles = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.listBoxMediaFiles = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemMMG = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHandbrake = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSourceFilteredList = new System.Windows.Forms.BindingSource(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.abortOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediaFiles)).BeginInit();
			this.tabControlMediaFileProps.SuspendLayout();
			this.tabPageInform.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageInform2.SuspendLayout();
			this.tabPageAttrInfo.SuspendLayout();
			this.tabPageCodecs.SuspendLayout();
			this.tabPageMediaFile.SuspendLayout();
			this.tabPageGeneral.SuspendLayout();
			this.tabPageVideo.SuspendLayout();
			this.tabPageAudio.SuspendLayout();
			this.tabPageText.SuspendLayout();
			this.tabPageImage.SuspendLayout();
			this.tabPageOther.SuspendLayout();
			this.tabPageMenus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilteredList)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(658, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem});
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// openFileToolStripMenuItem
			// 
			this.openFileToolStripMenuItem.Image = global::MediaInfoDotNet.WFClient.Properties.Resources.FileOpen;
			this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
			this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openFileToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.openFileToolStripMenuItem.Text = "Open File";
			this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
			// 
			// openFolderToolStripMenuItem
			// 
			this.openFolderToolStripMenuItem.Image = global::MediaInfoDotNet.WFClient.Properties.Resources.FolderAdd;
			this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
			this.openFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
			this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.openFolderToolStripMenuItem.Text = "Open Folder";
			this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeFileToolStripMenuItem,
            this.closeAllToolStripMenuItem});
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.closeToolStripMenuItem.Text = "Close";
			// 
			// closeFileToolStripMenuItem
			// 
			this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
			this.closeFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.closeFileToolStripMenuItem.Text = "Close File";
			this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
			// 
			// closeAllToolStripMenuItem
			// 
			this.closeAllToolStripMenuItem.Image = global::MediaInfoDotNet.WFClient.Properties.Resources.FolderRemove;
			this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
			this.closeAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
			this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.closeAllToolStripMenuItem.Text = "Close All";
			this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = global::MediaInfoDotNet.WFClient.Properties.Resources.Exit;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.editPreferencesToolStripMenuItem,
            this.saveSettingsNowToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
			// 
			// editPreferencesToolStripMenuItem
			// 
			this.editPreferencesToolStripMenuItem.Image = global::MediaInfoDotNet.WFClient.Properties.Resources.Preferences;
			this.editPreferencesToolStripMenuItem.Name = "editPreferencesToolStripMenuItem";
			this.editPreferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.editPreferencesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.editPreferencesToolStripMenuItem.Text = "Preferences";
			this.editPreferencesToolStripMenuItem.Click += new System.EventHandler(this.editPreferencesToolStripMenuItem_Click);
			// 
			// saveSettingsNowToolStripMenuItem
			// 
			this.saveSettingsNowToolStripMenuItem.Checked = true;
			this.saveSettingsNowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.saveSettingsNowToolStripMenuItem.Name = "saveSettingsNowToolStripMenuItem";
			this.saveSettingsNowToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.saveSettingsNowToolStripMenuItem.Text = "Save Settings on Exit";
			this.saveSettingsNowToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsNowToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramInformOutputToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// histogramInformOutputToolStripMenuItem
			// 
			this.histogramInformOutputToolStripMenuItem.Name = "histogramInformOutputToolStripMenuItem";
			this.histogramInformOutputToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.histogramInformOutputToolStripMenuItem.Text = "Histogram Inform Output";
			this.histogramInformOutputToolStripMenuItem.Click += new System.EventHandler(this.histogramInformOutputToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.Description = "Select a directory to scan.";
			this.folderBrowserDialog1.SelectedPath = global::MediaInfoDotNet.WFClient.Properties.Settings.Default.LastLocation;
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = global::MediaInfoDotNet.WFClient.Properties.Settings.Default.LastFile;
			this.openFileDialog1.Title = "Load media file";
			// 
			// bindingSourceMediaFiles
			// 
			this.bindingSourceMediaFiles.AllowNew = true;
			this.bindingSourceMediaFiles.DataSource = typeof(MediaInfoDotNet.MediaFile);
			this.bindingSourceMediaFiles.Sort = "";
			this.bindingSourceMediaFiles.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource1_ListChanged);
			// 
			// tabControlMediaFileProps
			// 
			this.tabControlMediaFileProps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMediaFileProps.Controls.Add(this.tabPageInform);
			this.tabControlMediaFileProps.Controls.Add(this.tabPageMediaFile);
			this.tabControlMediaFileProps.Controls.Add(this.tabPageGeneral);
			this.tabControlMediaFileProps.Controls.Add(this.tabPageVideo);
			this.tabControlMediaFileProps.Controls.Add(this.tabPageAudio);
			this.tabControlMediaFileProps.Controls.Add(this.tabPageText);
			this.tabControlMediaFileProps.Controls.Add(this.tabPageImage);
			this.tabControlMediaFileProps.Controls.Add(this.tabPageOther);
			this.tabControlMediaFileProps.Controls.Add(this.tabPageMenus);
			this.tabControlMediaFileProps.Location = new System.Drawing.Point(3, 3);
			this.tabControlMediaFileProps.Name = "tabControlMediaFileProps";
			this.tabControlMediaFileProps.SelectedIndex = 0;
			this.tabControlMediaFileProps.Size = new System.Drawing.Size(437, 304);
			this.tabControlMediaFileProps.TabIndex = 4;
			// 
			// tabPageInform
			// 
			this.tabPageInform.Controls.Add(this.tabControl1);
			this.tabPageInform.Location = new System.Drawing.Point(4, 22);
			this.tabPageInform.Name = "tabPageInform";
			this.tabPageInform.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageInform.Size = new System.Drawing.Size(429, 278);
			this.tabPageInform.TabIndex = 0;
			this.tabPageInform.Text = "Inform";
			this.tabPageInform.ToolTipText = "Output from Inform()";
			this.tabPageInform.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPageInform2);
			this.tabControl1.Controls.Add(this.tabPageAttrInfo);
			this.tabControl1.Controls.Add(this.tabPageCodecs);
			this.tabControl1.Location = new System.Drawing.Point(6, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(417, 269);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPageInform2
			// 
			this.tabPageInform2.Controls.Add(this.linkLabelUrl);
			this.tabPageInform2.Controls.Add(this.checkBoxCOmpleteInform);
			this.tabPageInform2.Controls.Add(this.labelMediaInfoLibVersion);
			this.tabPageInform2.Controls.Add(this.textBoxInform);
			this.tabPageInform2.Location = new System.Drawing.Point(4, 22);
			this.tabPageInform2.Name = "tabPageInform2";
			this.tabPageInform2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageInform2.Size = new System.Drawing.Size(409, 243);
			this.tabPageInform2.TabIndex = 0;
			this.tabPageInform2.Text = "Inform";
			this.tabPageInform2.UseVisualStyleBackColor = true;
			// 
			// linkLabelUrl
			// 
			this.linkLabelUrl.AutoSize = true;
			this.linkLabelUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMediaFiles, "InfoUrl", true));
			this.linkLabelUrl.Location = new System.Drawing.Point(6, 16);
			this.linkLabelUrl.Name = "linkLabelUrl";
			this.linkLabelUrl.Size = new System.Drawing.Size(55, 13);
			this.linkLabelUrl.TabIndex = 4;
			this.linkLabelUrl.TabStop = true;
			this.linkLabelUrl.Text = "linkLabel1";
			// 
			// checkBoxCOmpleteInform
			// 
			this.checkBoxCOmpleteInform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxCOmpleteInform.AutoSize = true;
			this.checkBoxCOmpleteInform.Checked = true;
			this.checkBoxCOmpleteInform.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCOmpleteInform.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourceMediaFiles, "InformComplete", true));
			this.checkBoxCOmpleteInform.Location = new System.Drawing.Point(301, 6);
			this.checkBoxCOmpleteInform.Name = "checkBoxCOmpleteInform";
			this.checkBoxCOmpleteInform.Size = new System.Drawing.Size(102, 17);
			this.checkBoxCOmpleteInform.TabIndex = 3;
			this.checkBoxCOmpleteInform.Text = "Complete Inform";
			this.checkBoxCOmpleteInform.UseVisualStyleBackColor = true;
			this.checkBoxCOmpleteInform.CheckedChanged += new System.EventHandler(this.checkBoxCOmpleteInform_CheckedChanged);
			// 
			// labelMediaInfoLibVersion
			// 
			this.labelMediaInfoLibVersion.AutoSize = true;
			this.labelMediaInfoLibVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMediaFiles, "InfoVersion", true));
			this.labelMediaInfoLibVersion.Location = new System.Drawing.Point(6, 3);
			this.labelMediaInfoLibVersion.Name = "labelMediaInfoLibVersion";
			this.labelMediaInfoLibVersion.Size = new System.Drawing.Size(42, 13);
			this.labelMediaInfoLibVersion.TabIndex = 1;
			this.labelMediaInfoLibVersion.Text = "Version";
			// 
			// textBoxInform
			// 
			this.textBoxInform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInform.Font = new System.Drawing.Font("Courier New", 8.25F);
			this.textBoxInform.Location = new System.Drawing.Point(6, 32);
			this.textBoxInform.Multiline = true;
			this.textBoxInform.Name = "textBoxInform";
			this.textBoxInform.ReadOnly = true;
			this.textBoxInform.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxInform.Size = new System.Drawing.Size(397, 205);
			this.textBoxInform.TabIndex = 0;
			this.textBoxInform.WordWrap = false;
			// 
			// tabPageAttrInfo
			// 
			this.tabPageAttrInfo.Controls.Add(this.textBoxInfoParms);
			this.tabPageAttrInfo.Location = new System.Drawing.Point(4, 22);
			this.tabPageAttrInfo.Name = "tabPageAttrInfo";
			this.tabPageAttrInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAttrInfo.Size = new System.Drawing.Size(409, 243);
			this.tabPageAttrInfo.TabIndex = 1;
			this.tabPageAttrInfo.Text = "Info_Parameters";
			this.tabPageAttrInfo.UseVisualStyleBackColor = true;
			// 
			// textBoxInfoParms
			// 
			this.textBoxInfoParms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInfoParms.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMediaFiles, "InfoParameters", true));
			this.textBoxInfoParms.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxInfoParms.Location = new System.Drawing.Point(6, 6);
			this.textBoxInfoParms.Multiline = true;
			this.textBoxInfoParms.Name = "textBoxInfoParms";
			this.textBoxInfoParms.ReadOnly = true;
			this.textBoxInfoParms.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxInfoParms.Size = new System.Drawing.Size(397, 231);
			this.textBoxInfoParms.TabIndex = 1;
			this.textBoxInfoParms.WordWrap = false;
			// 
			// tabPageCodecs
			// 
			this.tabPageCodecs.Controls.Add(this.textBoxCodecs);
			this.tabPageCodecs.Location = new System.Drawing.Point(4, 22);
			this.tabPageCodecs.Name = "tabPageCodecs";
			this.tabPageCodecs.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCodecs.Size = new System.Drawing.Size(409, 243);
			this.tabPageCodecs.TabIndex = 2;
			this.tabPageCodecs.Text = "Info_Codecs";
			this.tabPageCodecs.UseVisualStyleBackColor = true;
			// 
			// textBoxCodecs
			// 
			this.textBoxCodecs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCodecs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMediaFiles, "InfoCodecs", true));
			this.textBoxCodecs.Font = new System.Drawing.Font("Courier New", 8.25F);
			this.textBoxCodecs.Location = new System.Drawing.Point(6, 6);
			this.textBoxCodecs.Multiline = true;
			this.textBoxCodecs.Name = "textBoxCodecs";
			this.textBoxCodecs.ReadOnly = true;
			this.textBoxCodecs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxCodecs.Size = new System.Drawing.Size(397, 231);
			this.textBoxCodecs.TabIndex = 2;
			this.textBoxCodecs.WordWrap = false;
			// 
			// tabPageMediaFile
			// 
			this.tabPageMediaFile.Controls.Add(this.propertyGridMediaFile);
			this.tabPageMediaFile.Location = new System.Drawing.Point(4, 22);
			this.tabPageMediaFile.Name = "tabPageMediaFile";
			this.tabPageMediaFile.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMediaFile.Size = new System.Drawing.Size(429, 278);
			this.tabPageMediaFile.TabIndex = 1;
			this.tabPageMediaFile.Text = "MediaFile";
			this.tabPageMediaFile.ToolTipText = "MediaFile properties";
			this.tabPageMediaFile.UseVisualStyleBackColor = true;
			// 
			// propertyGridMediaFile
			// 
			this.propertyGridMediaFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGridMediaFile.Location = new System.Drawing.Point(6, 6);
			this.propertyGridMediaFile.Name = "propertyGridMediaFile";
			this.propertyGridMediaFile.Size = new System.Drawing.Size(417, 266);
			this.propertyGridMediaFile.TabIndex = 1;
			// 
			// tabPageGeneral
			// 
			this.tabPageGeneral.Controls.Add(this.propertyGridGeneral);
			this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabPageGeneral.Name = "tabPageGeneral";
			this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGeneral.Size = new System.Drawing.Size(429, 278);
			this.tabPageGeneral.TabIndex = 2;
			this.tabPageGeneral.Text = "General";
			this.tabPageGeneral.ToolTipText = "GeneralStream properties";
			this.tabPageGeneral.UseVisualStyleBackColor = true;
			// 
			// propertyGridGeneral
			// 
			this.propertyGridGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGridGeneral.DataBindings.Add(new System.Windows.Forms.Binding("SelectedObject", this.bindingSourceMediaFiles, "General", true));
			this.propertyGridGeneral.Location = new System.Drawing.Point(6, 6);
			this.propertyGridGeneral.Name = "propertyGridGeneral";
			this.propertyGridGeneral.Size = new System.Drawing.Size(417, 266);
			this.propertyGridGeneral.TabIndex = 0;
			// 
			// tabPageVideo
			// 
			this.tabPageVideo.Controls.Add(this.userControlStreamsViewerVideo);
			this.tabPageVideo.Location = new System.Drawing.Point(4, 22);
			this.tabPageVideo.Name = "tabPageVideo";
			this.tabPageVideo.Size = new System.Drawing.Size(429, 278);
			this.tabPageVideo.TabIndex = 3;
			this.tabPageVideo.Text = "Video";
			this.tabPageVideo.ToolTipText = "Video streams and their properties";
			this.tabPageVideo.UseVisualStyleBackColor = true;
			// 
			// userControlStreamsViewerVideo
			// 
			this.userControlStreamsViewerVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userControlStreamsViewerVideo.DataSource = null;
			this.userControlStreamsViewerVideo.Location = new System.Drawing.Point(3, 3);
			this.userControlStreamsViewerVideo.Name = "userControlStreamsViewerVideo";
			this.userControlStreamsViewerVideo.Size = new System.Drawing.Size(423, 272);
			this.userControlStreamsViewerVideo.TabIndex = 4;
			// 
			// tabPageAudio
			// 
			this.tabPageAudio.Controls.Add(this.userControlStreamsViewerAudio);
			this.tabPageAudio.Location = new System.Drawing.Point(4, 22);
			this.tabPageAudio.Name = "tabPageAudio";
			this.tabPageAudio.Size = new System.Drawing.Size(429, 278);
			this.tabPageAudio.TabIndex = 4;
			this.tabPageAudio.Text = "Audio";
			this.tabPageAudio.ToolTipText = "Audio streams and their properties";
			this.tabPageAudio.UseVisualStyleBackColor = true;
			// 
			// userControlStreamsViewerAudio
			// 
			this.userControlStreamsViewerAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userControlStreamsViewerAudio.DataSource = null;
			this.userControlStreamsViewerAudio.Location = new System.Drawing.Point(3, 3);
			this.userControlStreamsViewerAudio.Name = "userControlStreamsViewerAudio";
			this.userControlStreamsViewerAudio.Size = new System.Drawing.Size(423, 272);
			this.userControlStreamsViewerAudio.TabIndex = 5;
			// 
			// tabPageText
			// 
			this.tabPageText.Controls.Add(this.userControlStreamsViewerText);
			this.tabPageText.Location = new System.Drawing.Point(4, 22);
			this.tabPageText.Name = "tabPageText";
			this.tabPageText.Size = new System.Drawing.Size(429, 278);
			this.tabPageText.TabIndex = 5;
			this.tabPageText.Text = "Text";
			this.tabPageText.ToolTipText = "Text streams and their properties";
			this.tabPageText.UseVisualStyleBackColor = true;
			// 
			// userControlStreamsViewerText
			// 
			this.userControlStreamsViewerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userControlStreamsViewerText.DataSource = null;
			this.userControlStreamsViewerText.Location = new System.Drawing.Point(3, 3);
			this.userControlStreamsViewerText.Name = "userControlStreamsViewerText";
			this.userControlStreamsViewerText.Size = new System.Drawing.Size(423, 272);
			this.userControlStreamsViewerText.TabIndex = 6;
			// 
			// tabPageImage
			// 
			this.tabPageImage.Controls.Add(this.userControlStreamsViewerImage);
			this.tabPageImage.Location = new System.Drawing.Point(4, 22);
			this.tabPageImage.Name = "tabPageImage";
			this.tabPageImage.Size = new System.Drawing.Size(429, 278);
			this.tabPageImage.TabIndex = 6;
			this.tabPageImage.Text = "Image";
			this.tabPageImage.ToolTipText = "Image streams and their properties";
			this.tabPageImage.UseVisualStyleBackColor = true;
			// 
			// userControlStreamsViewerImage
			// 
			this.userControlStreamsViewerImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userControlStreamsViewerImage.DataSource = null;
			this.userControlStreamsViewerImage.Location = new System.Drawing.Point(3, 3);
			this.userControlStreamsViewerImage.Name = "userControlStreamsViewerImage";
			this.userControlStreamsViewerImage.Size = new System.Drawing.Size(423, 272);
			this.userControlStreamsViewerImage.TabIndex = 6;
			// 
			// tabPageOther
			// 
			this.tabPageOther.Controls.Add(this.userControlStreamsViewerOther);
			this.tabPageOther.Location = new System.Drawing.Point(4, 22);
			this.tabPageOther.Name = "tabPageOther";
			this.tabPageOther.Size = new System.Drawing.Size(429, 278);
			this.tabPageOther.TabIndex = 7;
			this.tabPageOther.Text = "Other";
			this.tabPageOther.ToolTipText = "Other streams and their properties";
			this.tabPageOther.UseVisualStyleBackColor = true;
			// 
			// userControlStreamsViewerOther
			// 
			this.userControlStreamsViewerOther.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userControlStreamsViewerOther.DataSource = null;
			this.userControlStreamsViewerOther.Location = new System.Drawing.Point(3, 3);
			this.userControlStreamsViewerOther.Name = "userControlStreamsViewerOther";
			this.userControlStreamsViewerOther.Size = new System.Drawing.Size(423, 272);
			this.userControlStreamsViewerOther.TabIndex = 6;
			// 
			// tabPageMenus
			// 
			this.tabPageMenus.Controls.Add(this.userControlStreamsViewerMenus);
			this.tabPageMenus.Location = new System.Drawing.Point(4, 22);
			this.tabPageMenus.Name = "tabPageMenus";
			this.tabPageMenus.Size = new System.Drawing.Size(429, 278);
			this.tabPageMenus.TabIndex = 8;
			this.tabPageMenus.Text = "Menus";
			this.tabPageMenus.ToolTipText = "Menu streams and their properties";
			this.tabPageMenus.UseVisualStyleBackColor = true;
			// 
			// userControlStreamsViewerMenus
			// 
			this.userControlStreamsViewerMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userControlStreamsViewerMenus.DataSource = null;
			this.userControlStreamsViewerMenus.Location = new System.Drawing.Point(3, 3);
			this.userControlStreamsViewerMenus.Name = "userControlStreamsViewerMenus";
			this.userControlStreamsViewerMenus.Size = new System.Drawing.Size(423, 272);
			this.userControlStreamsViewerMenus.TabIndex = 6;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(0, 27);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControlMediaFileProps);
			this.splitContainer1.Size = new System.Drawing.Size(658, 310);
			this.splitContainer1.SplitterDistance = 210;
			this.splitContainer1.SplitterWidth = 8;
			this.splitContainer1.TabIndex = 5;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.treeViewFiles);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.listBoxMediaFiles);
			this.splitContainer2.Size = new System.Drawing.Size(210, 310);
			this.splitContainer2.SplitterDistance = 90;
			this.splitContainer2.TabIndex = 0;
			// 
			// treeViewFiles
			// 
			this.treeViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewFiles.ImageIndex = 0;
			this.treeViewFiles.ImageList = this.imageList1;
			this.treeViewFiles.Location = new System.Drawing.Point(0, 0);
			this.treeViewFiles.Name = "treeViewFiles";
			treeNode1.Name = "NodeRoot";
			treeNode1.Text = "Node0";
			this.treeViewFiles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.treeViewFiles.SelectedImageIndex = 0;
			this.treeViewFiles.Size = new System.Drawing.Size(210, 90);
			this.treeViewFiles.TabIndex = 0;
			this.treeViewFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterSelect);
			this.treeViewFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFiles_NodeMouseClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Folder.png");
			// 
			// listBoxMediaFiles
			// 
			this.listBoxMediaFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxMediaFiles.ContextMenuStrip = this.contextMenuStrip1;
			this.listBoxMediaFiles.DataSource = this.bindingSourceFilteredList;
			this.listBoxMediaFiles.DisplayMember = "filePath";
			this.listBoxMediaFiles.FormattingEnabled = true;
			this.listBoxMediaFiles.Location = new System.Drawing.Point(3, 1);
			this.listBoxMediaFiles.Name = "listBoxMediaFiles";
			this.listBoxMediaFiles.Size = new System.Drawing.Size(207, 212);
			this.listBoxMediaFiles.Sorted = true;
			this.listBoxMediaFiles.TabIndex = 4;
			this.listBoxMediaFiles.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemDeleteFile,
            this.toolStripMenuItemOpenFolder,
            this.toolStripMenuItemMMG,
            this.toolStripMenuItemHandbrake});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(195, 114);
			this.contextMenuStrip1.Text = "Options";
			// 
			// toolStripMenuItemOpen
			// 
			this.toolStripMenuItemOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
			this.toolStripMenuItemOpen.Size = new System.Drawing.Size(194, 22);
			this.toolStripMenuItemOpen.Text = "Open";
			this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
			// 
			// toolStripMenuItemDeleteFile
			// 
			this.toolStripMenuItemDeleteFile.Image = global::MediaInfoDotNet.WFClient.Properties.Resources.FolderRemove;
			this.toolStripMenuItemDeleteFile.Name = "toolStripMenuItemDeleteFile";
			this.toolStripMenuItemDeleteFile.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.toolStripMenuItemDeleteFile.Size = new System.Drawing.Size(194, 22);
			this.toolStripMenuItemDeleteFile.Text = "Remove";
			this.toolStripMenuItemDeleteFile.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
			// 
			// toolStripMenuItemOpenFolder
			// 
			this.toolStripMenuItemOpenFolder.Image = global::MediaInfoDotNet.WFClient.Properties.Resources.Folder;
			this.toolStripMenuItemOpenFolder.Name = "toolStripMenuItemOpenFolder";
			this.toolStripMenuItemOpenFolder.Size = new System.Drawing.Size(194, 22);
			this.toolStripMenuItemOpenFolder.Text = "Open Folder";
			this.toolStripMenuItemOpenFolder.Click += new System.EventHandler(this.toolStripMenuItemOpenFolder_Click);
			// 
			// toolStripMenuItemMMG
			// 
			this.toolStripMenuItemMMG.Name = "toolStripMenuItemMMG";
			this.toolStripMenuItemMMG.Size = new System.Drawing.Size(194, 22);
			this.toolStripMenuItemMMG.Text = "Open with MKV Merge";
			this.toolStripMenuItemMMG.Click += new System.EventHandler(this.toolStripMenuItemMMG_Click);
			// 
			// toolStripMenuItemHandbrake
			// 
			this.toolStripMenuItemHandbrake.Name = "toolStripMenuItemHandbrake";
			this.toolStripMenuItemHandbrake.Size = new System.Drawing.Size(194, 22);
			this.toolStripMenuItemHandbrake.Text = "Open with Handbrake";
			this.toolStripMenuItemHandbrake.Click += new System.EventHandler(this.toolStripMenuItemHandbrake_Click);
			// 
			// bindingSourceFilteredList
			// 
			this.bindingSourceFilteredList.AllowNew = true;
			this.bindingSourceFilteredList.DataSource = typeof(MediaInfoDotNet.MediaFile);
			this.bindingSourceFilteredList.Sort = "";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 340);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(658, 22);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abortOperationToolStripMenuItem});
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
			this.toolStripSplitButton1.Text = "toolStripSplitButton1";
			// 
			// abortOperationToolStripMenuItem
			// 
			this.abortOperationToolStripMenuItem.Name = "abortOperationToolStripMenuItem";
			this.abortOperationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.abortOperationToolStripMenuItem.Text = "Abort operation";
			this.abortOperationToolStripMenuItem.Click += new System.EventHandler(this.abortOperationToolStripMenuItem_Click);
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(509, 17);
			this.toolStripStatusLabel1.Spring = true;
			this.toolStripStatusLabel1.Text = "No pending jobs...";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 362);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.splitContainer1);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::MediaInfoDotNet.WFClient.Properties.Settings.Default, "WinPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Location = global::MediaInfoDotNet.WFClient.Properties.Settings.Default.WinPosition;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(640, 400);
			this.Name = "FormMain";
			this.Text = "MediaInfo.NET Test Application";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceMediaFiles)).EndInit();
			this.tabControlMediaFileProps.ResumeLayout(false);
			this.tabPageInform.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPageInform2.ResumeLayout(false);
			this.tabPageInform2.PerformLayout();
			this.tabPageAttrInfo.ResumeLayout(false);
			this.tabPageAttrInfo.PerformLayout();
			this.tabPageCodecs.ResumeLayout(false);
			this.tabPageCodecs.PerformLayout();
			this.tabPageMediaFile.ResumeLayout(false);
			this.tabPageGeneral.ResumeLayout(false);
			this.tabPageVideo.ResumeLayout(false);
			this.tabPageAudio.ResumeLayout(false);
			this.tabPageText.ResumeLayout(false);
			this.tabPageImage.ResumeLayout(false);
			this.tabPageOther.ResumeLayout(false);
			this.tabPageMenus.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilteredList)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editPreferencesToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource bindingSourceMediaFiles;
        private System.Windows.Forms.TabControl tabControlMediaFileProps;
        private System.Windows.Forms.TabPage tabPageInform;
        private System.Windows.Forms.TabPage tabPageMediaFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxInform;
        private System.Windows.Forms.TabPage tabPageGeneral;
		private System.Windows.Forms.PropertyGrid propertyGridGeneral;
        private System.Windows.Forms.TabPage tabPageVideo;
        private System.Windows.Forms.TabPage tabPageAudio;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.TabPage tabPageImage;
        private System.Windows.Forms.TabPage tabPageOther;
		private System.Windows.Forms.TabPage tabPageMenus;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsNowToolStripMenuItem;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PropertyGrid propertyGridMediaFile;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem histogramInformOutputToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem abortOperationToolStripMenuItem;
		private System.Windows.Forms.ListBox listBoxMediaFiles;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteFile;
		private UserControlStreamsViewer userControlStreamsViewerVideo;
		private UserControlStreamsViewer userControlStreamsViewerAudio;
		private UserControlStreamsViewer userControlStreamsViewerText;
		private UserControlStreamsViewer userControlStreamsViewerImage;
		private UserControlStreamsViewer userControlStreamsViewerOther;
		private UserControlStreamsViewer userControlStreamsViewerMenus;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageAttrInfo;
		private System.Windows.Forms.TabPage tabPageCodecs;
		private System.Windows.Forms.TabPage tabPageInform2;
		private System.Windows.Forms.Label labelMediaInfoLibVersion;
		private System.Windows.Forms.TextBox textBoxInfoParms;
		private System.Windows.Forms.TextBox textBoxCodecs;
		private System.Windows.Forms.CheckBox checkBoxCOmpleteInform;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TreeView treeViewFiles;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.LinkLabel linkLabelUrl;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFolder;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMMG;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHandbrake;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
		private System.Windows.Forms.BindingSource bindingSourceFilteredList;
    }
}

