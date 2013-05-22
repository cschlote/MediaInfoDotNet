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

using System;
using System.ComponentModel;
using MediaInfoDotNet.Models;
using MediaInfoLib;

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

		#region AllStreamsCommon

		///<summary>The format or container of this file or stream.</summary>
		[Description("The format or container of this file or stream."), Category("AllStreamsCommon")]
		public string Format { get { return this.format; } }

		///<summary>The title of this stream.</summary>
		[Description("The title of this stream."), Category("AllStreamsCommon")]
		public string Title { get { return this.title; } }

		///<summary>This stream's globally unique ID (GUID).</summary>
		[Description("This stream's globally unique ID (GUID)."), Category("AllStreamsCommon")]
		public string UniqueId { get { return this.uniqueId; } }

		#endregion
	}
}
