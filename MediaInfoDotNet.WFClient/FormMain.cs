/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2013 Carsten Schlote
 ******************************************************************************
 * Test Application for MediaInfo.Net
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaInfoDotNet.WFClient.Properties;
using System.IO;

namespace MediaInfoDotNet.WFClient
{
	public partial class FormMain : Form
	{
		BindingList<MediaFile> _mediafiles;
		[ListBindable(true)]
		public BindingList<MediaFile> MediaFileCollection {
			get { if (_mediafiles == null) _mediafiles = new BindingList<MediaFile>(); return _mediafiles; }
			protected set { _mediafiles = value; }
		}

		public FormMain() {
			InitializeComponent();
			loadAllStreamProps(null);
		}

		private void FormMain_Load(object sender, EventArgs e) {
			this.Size = Settings.Default.WinSize;
		}
		private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
			Settings.Default.WinSize = this.Size;
		}
		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
			if (Settings.Default.SaveOnExit) {
				Settings.Default.Save();
			}
		}

		private void loadMediaFile(object sender, EventArgs e) {
			MediaInfoDotNet.MediaFile mf;
			DialogResult rc = openFileDialog1.ShowDialog();
			if (rc == System.Windows.Forms.DialogResult.OK) {
				Settings.Default.LastFile = openFileDialog1.FileName;
				mf = new MediaFile(openFileDialog1.FileName);
				int rc2 = bindingSourceMediaFiles.Add(mf);
				listBox1.SelectedIndex = rc2;
				updateTreeView();
				bindingSourceMediaFiles.Position = rc2;
			}
		}

		private void loadMediaFiles(object sender, EventArgs e) {
			folderBrowserDialog1.SelectedPath = Settings.Default.LastLocation;
			DialogResult rc = folderBrowserDialog1.ShowDialog();
			if (rc == System.Windows.Forms.DialogResult.OK) {
				Settings.Default.LastLocation = folderBrowserDialog1.SelectedPath;
				backgroundWorker1.RunWorkerAsync(folderBrowserDialog1.SelectedPath);
			}
		}

		#region LoadThePropertyGrids stuff


		private void loadAllStreamProps(MediaFile mf) {
			if (mf != null)
				mf.General.miOption("Complete", checkBoxCOmpleteInform.Checked ? "Yes" : "");

			textBoxInform.Text = mf != null ? mf.General.miInform() : "No data.";
			textBoxInfoParms.Text = mf != null ? mf.General.miOption("Info_Parameters") : "No parameter data.";
			textBoxCodecs.Text = mf != null ? mf.General.miOption("Info_Codecs") : "No codec data.";
			labelMediaInfoLibVersion.Text = mf != null ? mf.General.miOption("Info_Version") : "No version data.";
			labelUrl.Text = mf != null ? mf.General.miOption("Info_Url") : "No URL data.";

			propertyGridMediaFile.SelectedObject = mf;
			if (mf != null) {
				propertyGridGeneral.SelectedObject = mf.General;
				userControlStreamsViewerVideo.SelectedStreamList = new List<Models.BaseStreamCommons>(mf.Video);
				userControlStreamsViewerAudio.SelectedStreamList = new List<Models.BaseStreamCommons>(mf.Audio);
				userControlStreamsViewerText.SelectedStreamList = new List<Models.BaseStreamCommons>(mf.Text);
				userControlStreamsViewerImage.SelectedStreamList = new List<Models.BaseStreamCommons>(mf.Image);
				userControlStreamsViewerOther.SelectedStreamList = new List<Models.BaseStreamCommons>(mf.Other);
				userControlStreamsViewerMenus.SelectedStreamList = new List<Models.BaseStreamCommons>(mf.Menu);
			}
			else {
				propertyGridGeneral.SelectedObject = null;
				userControlStreamsViewerVideo.SelectedStreamList = (IList<Models.BaseStreamCommons>)null;
				userControlStreamsViewerAudio.SelectedStreamList = (IList<Models.BaseStreamCommons>)null;
				userControlStreamsViewerText.SelectedStreamList = (IList<Models.BaseStreamCommons>)null;
				userControlStreamsViewerImage.SelectedStreamList = (IList<Models.BaseStreamCommons>)null;
				userControlStreamsViewerOther.SelectedStreamList = (IList<Models.BaseStreamCommons>)null;
				userControlStreamsViewerMenus.SelectedStreamList = (IList<Models.BaseStreamCommons>)null;
			}
		}

		#endregion

		#region WinForm Events Callbacks

		private void openFileToolStripMenuItem_Click(object sender, EventArgs e) {
			loadMediaFile(sender, e);
		}

		private void openFolderToolStripMenuItem_Click(object sender, EventArgs e) {
			loadMediaFiles(sender, e);
		}

		private void closeAllToolStripMenuItem_Click(object sender, EventArgs e) {
			if (MessageBox.Show(
				"Delete all scanned entries?",
				"Delete all entries",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK) {
				this.bindingSourceMediaFiles.Clear();
			}
		}

		private void closeFileToolStripMenuItem_Click(object sender, EventArgs e) {
			if (listBox1.SelectedIndex >= 0) {
				this.bindingSourceMediaFiles.Remove(MediaFileCollection[listBox1.SelectedIndex]);
			}
		}

		private void saveSettingsNowToolStripMenuItem_Click(object sender, EventArgs e) {
			Settings.Default.Save();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
			System.Diagnostics.Debug.WriteLine("Booh");
		}

		private void editPreferencesToolStripMenuItem_Click(object sender, EventArgs e) {
			FormPrefs prefs = new FormPrefs();
			prefs.ShowDialog();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show(
				"This is a simple demo app to test and develop the MediaInfo.Net\n" +
				"classes.\n\n" +
				"The original code was written by Charles N. Burns\n" +
				"Modification and changes by Carsten Schlote\n\n",
				"Demo App for MediaInfo.Net",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		FormHistogram formHistogram;
		private void histogramInformOutputToolStripMenuItem_Click(object sender, EventArgs e) {
			System.Diagnostics.Debug.WriteLine("Booh");
			formHistogram = new FormHistogram(this.MediaFileCollection);
			formHistogram.Show();
		}

		private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e) {
			MediaFileCollection = (BindingList<MediaFile>)(bindingSourceMediaFiles.List);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			MediaFile mf = null;
			if (bindingSourceMediaFiles.List.Count > 0 && listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < bindingSourceMediaFiles.List.Count) {
				mf = (MediaFile)listBox1.SelectedItem;
			}
			loadAllStreamProps(mf);
		}
		private void checkBoxCOmpleteInform_CheckedChanged(object sender, EventArgs e) {
			listBox1_SelectedIndexChanged(sender, e);
		}

		#endregion

		#region OpenDirectory Backgroundworker

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
			MediaInfoDotNet.MediaFile mf;
			string selpath = (string)e.Argument;
			backgroundWorker1.ReportProgress(0, "Scanning directory...");
			string[] files = Directory.GetFiles(selpath, "*.*", SearchOption.AllDirectories);
			float progstep = 100.0f / files.Count(); float progress = 0.0f;
			foreach (string file in files) {
				progress += progstep;
				mf = new MediaFile(file);
				if (mf.HasStreams) {
					backgroundWorker1.ReportProgress((int)(progress), mf);
				} else {
					backgroundWorker1.ReportProgress((int)(progress), null);
				}
				if (backgroundWorker1.CancellationPending)
					break;
			}

		}
		List<MediaFile> newfiles = new List<MediaFile>();

		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
			if (e.UserState is String) {
				toolStripStatusLabel1.Text = (string)e.UserState;
			}
			if (e.UserState is MediaFile) {
				toolStripStatusLabel1.Text = String.Format("Scanned {0}", ((MediaFile)(e.UserState)).filePath);
				newfiles.Add((MediaFile)e.UserState);
			}
			toolStripProgressBar1.Value = e.ProgressPercentage <= 100 ? e.ProgressPercentage : 100;
			//this.Refresh();
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			toolStripProgressBar1.Value = 100;
			toolStripStatusLabel1.Text = "Adding files to listbox - for many files this can take a long time!";
			listBox1.Visible = false;
			listBox1.BeginUpdate();
			foreach (MediaFile mf in newfiles)
				bindingSourceMediaFiles.Add(mf);
			listBox1.EndUpdate();
			listBox1.Visible = true; 
			newfiles.Clear();
			toolStripStatusLabel1.Text = "Finished loading.";
			updateTreeView();
		}

		private void abortOperationToolStripMenuItem_Click(object sender, EventArgs e) {
			backgroundWorker1.CancelAsync();
		}

		#endregion

		private void updateTreeView() {
			TreeNodeCollection tmpcol;
			TreeNode tmpnode;

			// Display a wait cursor while the TreeNodes are being created.
			//Cursor.Current = new Cursor("MyWait.cur");

			// Suppress repainting the TreeView until all the objects have been created.
			treeViewFiles.BeginUpdate();

			// Clear the TreeView each time the method is called.
			treeViewFiles.Nodes.Clear();

			foreach (MediaFile mf in MediaFileCollection) {
				string path = Path.GetDirectoryName(mf.filePath);
				string[] patharray = path.Split(new [] {'\\'}, 
					StringSplitOptions.RemoveEmptyEntries);

				tmpcol = treeViewFiles.Nodes;
				foreach (string dir in patharray) {
					if (tmpcol.ContainsKey(dir) == false) {
						tmpnode = new TreeNode(dir);
						tmpnode.Name = dir;
						tmpcol.Add(tmpnode);
					}
					else
						tmpnode = tmpcol[dir];
					tmpcol = tmpnode.Nodes;
				}
			}
			// Reset the cursor to the default for all controls.
			//Cursor.Current = Cursors.Default;

			// Begin repainting the TreeView.
			treeViewFiles.EndUpdate();
		}

		private void treeViewFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
			System.Diagnostics.Debug.Write("Booh");
		}

	}
}
