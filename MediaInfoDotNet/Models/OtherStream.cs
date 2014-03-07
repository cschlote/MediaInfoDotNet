/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * Copyright (C) 2013 Carsten Schlote
 ******************************************************************************
 * OtherStream.cs
 * 
 * Presents information and functionality specific to a 'other' stream.
 ******************************************************************************
 */

using MediaInfoDotNet.Models;
using MediaInfoLib;
using System;
using System.ComponentModel;
using System.Text;

namespace MediaInfoDotNet.Models
{
	///<summary>Represents a single 'other' stream.</summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public sealed class OtherStream : BaseStreamCommons
	{
		///<summary>OtherStream constructor.</summary>
		///<param name="mediaInfo">A MediaInfo object.</param>
		///<param name="id">The MediaInfo ID for this other stream.</param>
		public OtherStream(MediaInfo mediaInfo, int id)
			: base(mediaInfo, StreamKind.Other, id) {
		}
		/// <summary>Overides base method to provide short summary of stream kind.</summary>
		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat(", {0}", this.Format);
			if (!String.IsNullOrEmpty(this.FormatProfile)) sb.AppendFormat(" {0}", this.FormatProfile);
			if (!String.IsNullOrEmpty(this.title)) sb.AppendFormat(", '{0}'", this.Title);

			return sb.ToString();
		}


		#region AllStreamsCommon

		///<summary>The ID of this stream in the file.</summary>
		[Description("The ID of this stream in the file."), Category("AllStreamsCommon")]
		public int ID { get { return this.streamid; } }

		///<summary>The format or container of this file or stream.</summary>
		[Description("The format or container of this file or stream."), Category("AllStreamsCommon")]
		public string Format { get { return this.format; } }

		///<summary>Format information of this stream.</summary>
		[Description("Format information for this container or stream."), Category("AllStreamsCommon")]
		public string FormatInfo { get { return this.format_info; } }

		///<summary>Format profile of this stream.</summary>
		[Description("Format profile for this container or stream."), Category("AllStreamsCommon")]
		public string FormatProfile { get { return this.format_profile; } }

		///<summary>Format version of this stream.</summary>
		[Description("Format version for this container or stream."), Category("AllStreamsCommon")]
		public string FormatVersion { get { return this.format_version; } }

		///<summary>The title of this stream.</summary>
		[Description("The title of this container or stream."), Category("AllStreamsCommon")]
		public string Title { get { return this.title; } }

		///<summary>This stream's globally unique ID (GUID).</summary>
		[Description("This stream's or container's globally unique ID (GUID)."), Category("AllStreamsCommon")]
		public string UniqueId { get { return this.uniqueId; } }

		#endregion
	}
}
