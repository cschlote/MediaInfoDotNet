/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2013 Carsten Schlote
 ******************************************************************************
 * UserControl to display a MediaObject in a conveniant way for MediaInfo.Net
 * FIXME Move to core library
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaInfoDotNet.Models;

namespace MediaInfoDotNet.WFClient
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public partial class UserControlStreamsViewer : UserControl
	{
		public UserControlStreamsViewer() {
			InitializeComponent();
			SelectedStreamList = null;
			SelectedMediaFile = null;
		}
//FIXME: Create Custom GetProperty overload to show allstreams as subproperties
		protected MediaFile selectedMediaFile;
		[Bindable(true)]
		[Description("MediaFile object to display"), Category("Data")]
		public MediaFile SelectedMediaFile {
			get { return selectedMediaFile; }
			set {
				selectedMediaFile = value;
			}
		}

		protected object datasource;
		[Bindable(true)]
		[Description("MediaFile Streamlist to display"), Category("Data")]
		public object SelectedStreamList {
			get { return datasource; }
			set {
				bsCollection.DataSource = value;

				int streamCount = 0;
				if (bsCollection.List != null && bsCollection.List.Count > 0) {
					streamCount = bsCollection.List.Count;
					propertyGridStreamElement.SelectedObject = bsCollection.List[0];
					propertyGridStreamElement.Enabled = true;
					numericUpDownStreamIndex.Minimum = 0;
					numericUpDownStreamIndex.Value = 0;
					numericUpDownStreamIndex.Maximum = streamCount - 1;
					numericUpDownStreamIndex.Enabled = true;
				}
				else {
					propertyGridStreamElement.SelectedObject = null;
					propertyGridStreamElement.Enabled = false;
					numericUpDownStreamIndex.Minimum = 0;
					numericUpDownStreamIndex.Value = 0;
					numericUpDownStreamIndex.Maximum = 0;
					numericUpDownStreamIndex.Enabled = false;
				}
				labelStream.Text = String.Format("There are {0} streams.", streamCount);
			}
		}

		private void numericUpDownStreamIndex_ValueChanged(object sender, EventArgs e) {
			decimal idx = numericUpDownStreamIndex.Value;
			if (idx >= 0 && bsCollection.List != null && idx < bsCollection.List.Count) {
				propertyGridStreamElement.SelectedObject = bsCollection.List[(int)idx];
			}
		}

	}

}
