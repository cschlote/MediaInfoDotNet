using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaInfoDotNet.WFClient
{
    public partial class FormMain : Form
    {
        List<MediaInfoDotNet.MediaFile> mediaFiles = new List<MediaFile>();

        public FormMain()
        {
            InitializeComponent();
            //bindingSource1.DataSource = mediaFiles;
            Column1.DataPropertyName = "filePath";
            Column1.Name = "FilePath";
        }

        private void loadMediaFiles(object sender, EventArgs e)
        {
            MediaInfoDotNet.MediaFile mf;
            DialogResult rc = openFileDialog1.ShowDialog();
            if (rc == System.Windows.Forms.DialogResult.OK)
            {
                mf = new MediaFile(openFileDialog1.FileName);
                mediaFiles.Add(mf);
                bindingSource1.Add(mf);
            }
        }

        #region WinForm Events Callbacks

        private void button1_Click(object sender, EventArgs e)
        {
            loadMediaFiles(sender, e);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadMediaFiles(sender, e);
        }

        #endregion

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.Write("Booh");
            textBox1.Text = mediaFiles[e.RowIndex].miInform();
            textBox2.Text = mediaFiles[e.RowIndex].miInform();
            propertyGrid1.SelectedObject = mediaFiles[e.RowIndex];
        }


    }
}
