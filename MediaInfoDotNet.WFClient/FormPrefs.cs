using MediaInfoDotNet.WFClient.Properties;
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
	public partial class FormPrefs : Form
	{
		public FormPrefs() {
			InitializeComponent();
		}

		private void FormPrefs_Load(object sender, EventArgs e) {
			propertyGrid1.SelectedObject = Settings.Default;
			this.Size = Settings.Default.WinSizePrefs;
		}

		private void FormPrefs_FormClosing(object sender, FormClosingEventArgs e) {
			Settings.Default.WinSizePrefs = this.Size;
		}
	}
}
