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
using System.Collections;
using System.Reflection;

//TODO: Create Custom GetProperty overload to show allstreams as subproperties?

namespace MediaInfoDotNet.WFClient
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public partial class UserControlStreamsViewer : UserControl
	{
		public UserControlStreamsViewer() {
			InitializeComponent();
			DataSource = null;

			//propertyGridStreamElement.DataBindings.Add("SelectedObject", bsCollection, "Current", false, DataSourceUpdateMode.Never, null);
		}

		protected List<Models.BaseStreamCommons> datasource;
		protected Type datatype;

		[Bindable(true)]
		[Description("MediaFile Streamlist to display"), Category("Data")]
		public List<Models.BaseStreamCommons> DataSource {
			get { return (List<Models.BaseStreamCommons>)datasource; }
			set {
				if (value != null) {
					Type item_type = GetListItemType(value);
					datasource = value as List<Models.BaseStreamCommons>;
					datatype = item_type;
				}
				else {
					datasource = null;
					datatype = null;
				}
				bsCollection.DataSource = value;
			}
		}

		#region DataSource type checks and conversion

		static Type GetListItemType(object list) {
			foreach (Type iface in list.GetType().GetInterfaces()) {
				System.Diagnostics.Debug.WriteLine("Iface: {0}", iface.Name);
				if (iface.IsGenericType && iface.GetGenericTypeDefinition() == typeof(IList<>))
					return iface.GetGenericArguments()[0];
			}
			System.Diagnostics.Debug.WriteLine("Type: {0}", list.GetType().FullName);
			if (list is IList) {
				PropertyInfo item_property = GetItemProperty(list.GetType());
				if (item_property == null)
					// `Item' could be interface-explicit, and thus private
					return typeof(object);
				else
					return item_property.PropertyType;
			}
			else
				throw new ArgumentException("Type {0} does not implement IList or IList<>", list.GetType().FullName);
		}

		static PropertyInfo GetItemProperty(Type type) {
			foreach (PropertyInfo prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
				if (prop.Name == "Item")
					return prop;

			return null;
		}

		#endregion

		private void bsCollection_CurrentChanged(object sender, EventArgs e) {
			propertyGridStreamElement.SelectedObject = bsCollection.Current;
		}
	}
}
