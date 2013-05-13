namespace MediaInfoDotNet.WFClient
{
	partial class FormHistogram
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistogram));
			this.tabKeywordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.tabKeywordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetHistogram = new MediaInfoDotNet.WFClient.DataSetHistogram();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tabKeywordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonStartAnalysis = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tabKeywordsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.tabKeywordsBindingNavigator)).BeginInit();
			this.tabKeywordsBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabKeywordsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetHistogram)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabKeywordsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tabKeywordsBindingNavigator
			// 
			this.tabKeywordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tabKeywordsBindingNavigator.BindingSource = this.tabKeywordsBindingSource;
			this.tabKeywordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tabKeywordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tabKeywordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabKeywordsBindingNavigatorSaveItem,
            this.toolStripButtonStartAnalysis,
            this.toolStripButton1});
			this.tabKeywordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.tabKeywordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tabKeywordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tabKeywordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tabKeywordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tabKeywordsBindingNavigator.Name = "tabKeywordsBindingNavigator";
			this.tabKeywordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tabKeywordsBindingNavigator.Size = new System.Drawing.Size(748, 25);
			this.tabKeywordsBindingNavigator.TabIndex = 0;
			this.tabKeywordsBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// tabKeywordsBindingSource
			// 
			this.tabKeywordsBindingSource.DataMember = "tabKeywords";
			this.tabKeywordsBindingSource.DataSource = this.dataSetHistogram;
			// 
			// dataSetHistogram
			// 
			this.dataSetHistogram.DataSetName = "DataSetHistogram";
			this.dataSetHistogram.Locale = new System.Globalization.CultureInfo("en");
			this.dataSetHistogram.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tabKeywordsBindingNavigatorSaveItem
			// 
			this.tabKeywordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabKeywordsBindingNavigatorSaveItem.Image")));
			this.tabKeywordsBindingNavigatorSaveItem.Name = "tabKeywordsBindingNavigatorSaveItem";
			this.tabKeywordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(80, 22);
			this.tabKeywordsBindingNavigatorSaveItem.Text = "Load Data";
			this.tabKeywordsBindingNavigatorSaveItem.ToolTipText = "Load Data";
			this.tabKeywordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabKeywordsBindingNavigatorLoadItem_Click);
			// 
			// toolStripButtonStartAnalysis
			// 
			this.toolStripButtonStartAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartAnalysis.Image")));
			this.toolStripButtonStartAnalysis.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStartAnalysis.Name = "toolStripButtonStartAnalysis";
			this.toolStripButtonStartAnalysis.Size = new System.Drawing.Size(113, 22);
			this.toolStripButtonStartAnalysis.Text = "Build Histogram";
			this.toolStripButtonStartAnalysis.Click += new System.EventHandler(this.toolStripButtonStartAnalysis_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(78, 22);
			this.toolStripButton1.Text = "Save Data";
			this.toolStripButton1.Click += new System.EventHandler(this.tabKeywordsBindingNavigatorSaveItem_Click);
			// 
			// tabKeywordsDataGridView
			// 
			this.tabKeywordsDataGridView.AllowUserToAddRows = false;
			this.tabKeywordsDataGridView.AllowUserToDeleteRows = false;
			this.tabKeywordsDataGridView.AutoGenerateColumns = false;
			this.tabKeywordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tabKeywordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.tabKeywordsDataGridView.DataSource = this.tabKeywordsBindingSource;
			this.tabKeywordsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabKeywordsDataGridView.Location = new System.Drawing.Point(0, 25);
			this.tabKeywordsDataGridView.Name = "tabKeywordsDataGridView";
			this.tabKeywordsDataGridView.Size = new System.Drawing.Size(748, 355);
			this.tabKeywordsDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Keyword";
			this.dataGridViewTextBoxColumn1.HeaderText = "Keyword";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 73;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "GeneralHits";
			this.dataGridViewTextBoxColumn2.HeaderText = "General";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 69;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "VideoHits";
			this.dataGridViewTextBoxColumn3.HeaderText = "Video";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 59;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "AudioHits";
			this.dataGridViewTextBoxColumn4.HeaderText = "Audio";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 59;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "TextHits";
			this.dataGridViewTextBoxColumn5.HeaderText = "Text";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 53;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "ImageHits";
			this.dataGridViewTextBoxColumn6.HeaderText = "Image";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 61;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "OtherHits";
			this.dataGridViewTextBoxColumn7.HeaderText = "Other";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.Width = 58;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "MenuHits";
			this.dataGridViewTextBoxColumn8.HeaderText = "Menu";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.Width = 59;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FormHistogram
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 380);
			this.Controls.Add(this.tabKeywordsDataGridView);
			this.Controls.Add(this.tabKeywordsBindingNavigator);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::MediaInfoDotNet.WFClient.Properties.Settings.Default, "WinPositionHisto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Location = global::MediaInfoDotNet.WFClient.Properties.Settings.Default.WinPositionHisto;
			this.Name = "FormHistogram";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormHistogram";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHistogram_FormClosing);
			this.Load += new System.EventHandler(this.FormHistogram_Load);
			((System.ComponentModel.ISupportInitialize)(this.tabKeywordsBindingNavigator)).EndInit();
			this.tabKeywordsBindingNavigator.ResumeLayout(false);
			this.tabKeywordsBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabKeywordsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetHistogram)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabKeywordsDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSetHistogram dataSetHistogram;
		private System.Windows.Forms.BindingSource tabKeywordsBindingSource;
		private System.Windows.Forms.BindingNavigator tabKeywordsBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton tabKeywordsBindingNavigatorSaveItem;
		private System.Windows.Forms.ToolStripButton toolStripButtonStartAnalysis;
		private System.Windows.Forms.DataGridView tabKeywordsDataGridView;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;

	}
}