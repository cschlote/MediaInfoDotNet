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
using System.Collections;

namespace MediaInfoDotNet.WFClient
{
	public partial class FormMain : Form
	{
		public FormMain() {
			InitializeComponent();
			loadAllStreamProps(null);
		}

		private void FormMain_Load(object sender, EventArgs e) {
			this.Size = Settings.Default.WinSize;
			this.Refresh();
			this.splitContainer1.SplitterDistance = Settings.Default.SplitterH;
			this.splitContainer2.SplitterDistance = Settings.Default.SplitterV;
		}
		private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
			Settings.Default.WinSize = this.Size;
			Settings.Default.SplitterH = this.splitContainer1.SplitterDistance;
			Settings.Default.SplitterV = this.splitContainer2.SplitterDistance;
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
				try { // FIXME: Workaround problem with Exception
					bindingSourceMediaFiles.Position = bindingSourceMediaFiles.Add(mf);
				}
				catch (Exception e2) {
					var xx = listBoxMediaFiles.SelectedIndex;
					var yy = listBoxMediaFiles.SelectedItem;
					System.Diagnostics.Debug.WriteLine(
						"Got Exception while adding new item to bindingSource\n" +
						"Exception: {0}", e2.Message);
				}
				updateTreeView();
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
				mf.General.miOption("Complete", checkBoxCOmpleteInform.Checked ? "1" : "");

			propertyGridMediaFile.SelectedObject = mf;

			// USES DATABINDING....
			//textBoxInform.Text = mf != null ? mf.Inform : "No data.";
			//textBoxInfoParms.Text = mf != null ? mf.InfoParameters : "No parameter data.";
			//textBoxCodecs.Text = mf != null ? mf.InfoCodecs : "No codec data.";
			//labelMediaInfoLibVersion.Text = mf != null ? mf.General.miOption("Info_Version") : "No version data.";
			//labelUrl.Text = mf != null ? mf.General.miOption("Info_Url") : "No URL data.";

			if (mf != null) {
				propertyGridGeneral.SelectedObject = mf.General;
				userControlStreamsViewerVideo.DataSource = new List<Models.BaseStreamCommons>(mf.Video);
				userControlStreamsViewerAudio.DataSource = new List<Models.BaseStreamCommons>(mf.Audio);
				userControlStreamsViewerText.DataSource = new List<Models.BaseStreamCommons>(mf.Text);
				userControlStreamsViewerImage.DataSource = new List<Models.BaseStreamCommons>(mf.Image);
				userControlStreamsViewerOther.DataSource = new List<Models.BaseStreamCommons>(mf.Other);
				userControlStreamsViewerMenus.DataSource = new List<Models.BaseStreamCommons>(mf.Menu);
			}
			else {
				propertyGridGeneral.SelectedObject = null;
				userControlStreamsViewerVideo.DataSource = null;
				userControlStreamsViewerAudio.DataSource = null;
				userControlStreamsViewerText.DataSource = null;
				userControlStreamsViewerImage.DataSource = null;
				userControlStreamsViewerOther.DataSource = null;
				userControlStreamsViewerMenus.DataSource = null;
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
			if (listBoxMediaFiles.SelectedIndex >= 0) {
				var selnode = bindingSourceMediaFiles.Current;
				if (selnode != null)
					this.bindingSourceMediaFiles.Remove(selnode);
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
			if (formHistogram != null) {
				formHistogram = new FormHistogram(bindingSourceMediaFiles);
			}
			formHistogram.Show();
		}

		private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e) {
			System.Diagnostics.Debug.WriteLine("Booh");
			//if (e.ListChangedType == ListChangedType.Reset) {
				updateTreeView();
			//}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			MediaFile mf = null;
			if (bindingSourceMediaFiles.List.Count > 0 && listBoxMediaFiles.SelectedIndex >= 0 && listBoxMediaFiles.SelectedIndex < bindingSourceMediaFiles.List.Count) {
				//mf = (MediaFile)listBoxMediaFiles.SelectedItem;
				mf = (MediaFile)listBoxMediaFiles.SelectedItem;
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
				}
				else {
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
			listBoxMediaFiles.Visible = false;
			this.Refresh();
			listBoxMediaFiles.BeginUpdate();
			foreach (MediaFile mf in newfiles)
				bindingSourceMediaFiles.Add(mf);
			listBoxMediaFiles.EndUpdate();
			listBoxMediaFiles.Visible = true;
			this.Refresh();
			newfiles.Clear();
			toolStripStatusLabel1.Text = "Finished loading.";
			updateTreeView();
		}

		private void abortOperationToolStripMenuItem_Click(object sender, EventArgs e) {
			backgroundWorker1.CancelAsync();
		}

		#endregion

		#region TreeViewF Code

		private void updateTreeView() {
			TreeNodeCollection tmpcol;
			TreeNode tmpnode;

			//Cursor.Current = new Cursor("MyWait.cur");
			treeViewFiles.BeginUpdate();
			treeViewFiles.Nodes.Clear();

			foreach (MediaFile mf in bindingSourceMediaFiles.List) {
				string path = Path.GetDirectoryName(mf.filePath);
				if (path.StartsWith("\\\\") == true)
					path = path.Replace("\\\\", "Network\\");
				string[] patharray = path.Split(new[] { Path.DirectorySeparatorChar },
					StringSplitOptions.None);

				tmpcol = treeViewFiles.Nodes;
				tmpnode = null;
				foreach (string dir in patharray) {
					TreeNode[] tmpnodes = tmpcol.Find(dir, false);
					if (tmpcol.ContainsKey(dir) == false) {
						tmpnode = new TreeNode(dir);
						tmpnode.Name = dir;
						tmpnode.Tag = dir;
						tmpcol.Add(tmpnode);
					}
					else
						tmpnode = tmpcol[dir];

					tmpnode.Expand();
					tmpcol = tmpnode.Nodes;
				}
			}
			//Cursor.Current = Cursors.Default;
			treeViewFiles.EndUpdate();
		}

		private void treeViewFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
			System.Diagnostics.Debug.Write("Booh");
			var xxx = sender;
			if (sender != null && sender is TreeView && e != null && e.Button == System.Windows.Forms.MouseButtons.Left) {
				TreeView tn = (TreeView)sender;
				string fullpath = tn.SelectedNode != null ? tn.SelectedNode.FullPath : "";
				fullpath = fullpath.Replace("Network\\", "\\\\");
				//filterMediaFileNodes(fullpath);
			}
		}
		private void treeViewFiles_AfterSelect(object sender, TreeViewEventArgs e) {
			System.Diagnostics.Debug.Write("Booh");
			var xxx = sender;
			if (sender != null && sender is TreeView && e != null && e.Action == TreeViewAction.ByMouse) {
				TreeView tn = (TreeView)sender;
				string fullpath = tn.SelectedNode != null ? tn.SelectedNode.FullPath : "";
				fullpath = fullpath.Replace("Network\\", "\\\\");
				if (fullpath == "Network") fullpath = "";
				filterMediaFileNodes(fullpath);
			}
		}

		private string filterpath;
		private void filterMediaFileNodes(string filter) { filterpath = filter; filterMediaFileNodes(); }
		private void filterMediaFileNodes() {
			listBoxMediaFiles.BeginUpdate();
			bindingSourceFilteredList.Clear();
			foreach (MediaFile mf in bindingSourceMediaFiles.List) {
				if (String.IsNullOrEmpty(filterpath) || mf.filePath.StartsWith(filterpath)) {
					bindingSourceFilteredList.Add(mf);
				}
			}
			listBoxMediaFiles.EndUpdate();
		}

		#endregion

		#region ToolStripMenu Callbacks (Window and Context Menus)

		private void toolStripMenuItemOpen_Click(object sender, EventArgs e) {
			if (bindingSourceMediaFiles.List.Count > 0 && listBoxMediaFiles.SelectedIndex >= 0 && listBoxMediaFiles.SelectedIndex < bindingSourceMediaFiles.List.Count) {
				MediaFile selnode = (MediaFile)listBoxMediaFiles.SelectedItem;
				if (selnode != null && File.Exists(selnode.filePath))
					System.Diagnostics.Process.Start(selnode.filePath);
			}
		}

		private void toolStripMenuItemOpenFolder_Click(object sender, EventArgs e) {
			if (bindingSourceMediaFiles.List.Count > 0 && listBoxMediaFiles.SelectedIndex >= 0 && listBoxMediaFiles.SelectedIndex < bindingSourceMediaFiles.List.Count) {
				MediaFile selnode = (MediaFile)listBoxMediaFiles.SelectedItem;
				if (selnode != null && File.Exists(selnode.filePath))
					System.Diagnostics.Process.Start(Path.GetDirectoryName(selnode.filePath));
			}
		}

		private void toolStripMenuItemMMG_Click(object sender, EventArgs e) {
			if (bindingSourceMediaFiles.List.Count > 0 && listBoxMediaFiles.SelectedIndex >= 0 && listBoxMediaFiles.SelectedIndex < bindingSourceMediaFiles.List.Count) {
				MediaFile selnode = (MediaFile)listBoxMediaFiles.SelectedItem;
				if (selnode != null) {
					System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
					string cmd = Path.Combine(Settings.Default.MKVPath, "mmg.exe");
					startInfo.FileName = cmd;
					startInfo.Arguments = "\"" + selnode.filePath + "\"";
					startInfo.WorkingDirectory = Settings.Default.MKVPath;
					try { System.Diagnostics.Process.Start(startInfo); }
					catch (Exception ex) { MessageBox.Show(ex.Message); };
				}
			}
		}

		private void toolStripMenuItemHandbrake_Click(object sender, EventArgs e) {
			if (bindingSourceMediaFiles.List.Count > 0 && listBoxMediaFiles.SelectedIndex >= 0 && listBoxMediaFiles.SelectedIndex < bindingSourceMediaFiles.List.Count) {
				MediaFile selnode = (MediaFile)listBoxMediaFiles.SelectedItem;
				if (selnode != null) {
					System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
					string cmd = Path.Combine(Settings.Default.HandbrakePath, "Handbrake.exe");
					startInfo.FileName = cmd;
					startInfo.Arguments = "\"" + selnode.filePath + "\"";
					startInfo.WorkingDirectory = Settings.Default.HandbrakePath; 
					try { System.Diagnostics.Process.Start(startInfo); }
					catch (Exception ex) { MessageBox.Show(ex.Message); };
				}
			}
		}

		#endregion

	}
}
