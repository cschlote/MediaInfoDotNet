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
        List<MediaInfoDotNet.MediaFile> mediaFiles = new List<MediaFile> ();

        public FormMain () {
            InitializeComponent ();
            //bindingSource1.DataSource = mediaFiles;
            Column1.DataPropertyName = "filePath";
            Column1.Name = "FilePath";

            loadAllStreamProps (null);
        }

        private void loadMediaFile (object sender, EventArgs e) {
            MediaInfoDotNet.MediaFile mf;
            DialogResult rc = openFileDialog1.ShowDialog ();
            if (rc == System.Windows.Forms.DialogResult.OK) {
                mf = new MediaFile (openFileDialog1.FileName);
                mediaFiles.Add (mf);
                bindingSource1.Add (mf);
            }
        }
        private void loadMediaFiles (object sender, EventArgs e) {
            MediaInfoDotNet.MediaFile mf;
            DialogResult rc = folderBrowserDialog1.ShowDialog ();
            if (rc == System.Windows.Forms.DialogResult.OK) {
                string x = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles (x, "*.*", SearchOption.AllDirectories);
                foreach (string file in files) {
                    mf = new MediaFile (file);
                    if (mf.hasStreams) {
                        mediaFiles.Add (mf);
                        bindingSource1.Add (mf);
                        //break;
                    }
                }
            }
        }

        private void loadPropertyGridWithStream (NumericUpDown nudobj, PropertyGrid pgobj, decimal max, Object obj) {
            if (nudobj != null) {
                if (max > 0) {
                    nudobj.Enabled = true;
                    nudobj.Maximum = max - 1;
                    if (nudobj.Value < 0 || nudobj.Value >= max) nudobj.Value = 0;
                } else {
                    nudobj.Value = 0;
                    nudobj.Maximum = 0;
                    nudobj.Enabled = false;
                }
            }
            if (pgobj != null) {
                if (obj != null) {
                    pgobj.SelectedObject = obj;
                    pgobj.Enabled = true;
                } else {
                    pgobj.SelectedObject = null;
                    pgobj.Enabled = false;
                }
            }
        }

        private void loadGeneralStreamProps () {
            MediaFile mf = selectedMediaFile; Object obj = null;
            if (mf != null) obj = mf.General;
            loadPropertyGridWithStream (null, propertyGrid1, 0, obj);
        }
        private void loadVideoStreamProps () {
            MediaFile mf = selectedMediaFile;
            if (mf != null) {
                int val = (int)numericUpDown1.Value; Object obj = null;
                if (mf.Video.ContainsKey (val))
                    obj = mf.Video[val];
                loadPropertyGridWithStream (numericUpDown1, propertyGrid2, mf.Video.Count, obj);
            }
        }
        private void loadAudioStreamProps () {
            MediaFile mf = selectedMediaFile;
            if (mf != null) {
                int val = (int)numericUpDown2.Value; Object obj = null;
                if (mf.Audio.ContainsKey (val))
                    obj = mf.Audio[val];
                loadPropertyGridWithStream (numericUpDown2, propertyGrid3, mf.Audio.Count, obj);
            }
        }
        private void loadTextStreamProps () {
            MediaFile mf = selectedMediaFile;
            if (mf != null) {
                int val = (int)numericUpDown3.Value; Object obj = null;
                if (mf.Text.ContainsKey (val))
                    obj = mf.Text[val];
                loadPropertyGridWithStream (numericUpDown3, propertyGrid4, mf.Text.Count, obj);
            }
        }
        private void loadImageStreamProps () {
            MediaFile mf = selectedMediaFile;
            if (mf != null) {
                int val = (int)numericUpDown4.Value; Object obj = null;
                if (mf.Image.ContainsKey (val))
                    obj = mf.Image[val];
                loadPropertyGridWithStream (numericUpDown4, propertyGrid5, mf.Image.Count, obj);
            }
        }
        private void loadOtherStreamProps () {
            MediaFile mf = selectedMediaFile;
            if (mf != null) {
                int val = (int)numericUpDown5.Value; Object obj = null;
                if (mf.Other.ContainsKey (val))
                    obj = mf.Other[val];
                loadPropertyGridWithStream (numericUpDown5, propertyGrid6, mf.Other.Count, obj);
            }
        }
        private void loadMenuStreamProps () {
            MediaFile mf = selectedMediaFile;
            if (mf != null) {
                int val = (int)numericUpDown6.Value; Object obj = null;
                if (mf.Menu.ContainsKey (val))
                    obj = mf.Menu[val];
                loadPropertyGridWithStream (numericUpDown6, propertyGrid7, mf.Menu.Count, obj);
            }
        }
        private MediaFile selectedMediaFile; //FIXME
        private void loadAllStreamProps (MediaFile mf) {
            selectedMediaFile = mf;
            textBox1.Text = mf != null ? mf.General.miInform () : "No data.";

            propertyGrid8.SelectedObject = mf;
            propertyGrid8.Enabled = (mf == null) ? false : true;

            loadGeneralStreamProps ();
            loadVideoStreamProps ();
            loadAudioStreamProps ();
            loadTextStreamProps ();
            loadImageStreamProps ();
            loadOtherStreamProps ();
            loadMenuStreamProps ();
        }

        #region WinForm Events Callbacks

        private void openFileToolStripMenuItem_Click (object sender, EventArgs e) {
            loadMediaFile (sender, e);
        }

        private void openFolderToolStripMenuItem_Click (object sender, EventArgs e) {
            loadMediaFiles (sender, e);
        }

        private void dataGridView1_RowEnter (object sender, DataGridViewCellEventArgs e) {
            System.Diagnostics.Debug.Write ("Booh");

            MediaFile mf = mediaFiles[e.RowIndex];
            loadAllStreamProps (mf);
        }


        private void numericUpDown1_ValueChanged (object sender, EventArgs e) {
            loadVideoStreamProps ();
        }
        private void numericUpDown2_ValueChanged (object sender, EventArgs e) {
            loadAudioStreamProps ();
        }
        private void numericUpDown3_ValueChanged (object sender, EventArgs e) {
            loadTextStreamProps ();
        }
        private void numericUpDown4_ValueChanged (object sender, EventArgs e) {
            loadImageStreamProps ();
        }
        private void numericUpDown5_ValueChanged (object sender, EventArgs e) {
            loadOtherStreamProps ();
        }
        private void numericUpDown6_ValueChanged (object sender, EventArgs e) {
            loadMenuStreamProps ();
        }
        private void saveSettingsNowToolStripMenuItem_Click (object sender, EventArgs e) {
            Settings.Default.Save ();
        }

        #endregion

        private void exitToolStripMenuItem_Click (object sender, EventArgs e) {
            this.Close ();
        }

        private void backgroundWorker1_DoWork (object sender, DoWorkEventArgs e) {

        }

        private void backgroundWorker1_ProgressChanged (object sender, ProgressChangedEventArgs e) {

        }

        private void backgroundWorker1_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e) {

        }

    }
}
