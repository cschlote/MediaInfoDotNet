/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * Copyright (C) 2013 Carsten Schlote
 * 
 ******************************************************************************
 * MenuStream.cs
 * 
 * Presents information and functionality specific to a menu stream.
 * 
 ******************************************************************************
 */

using System;
using MediaInfoLib;
using MediaInfoDotNet.Models;
using System.ComponentModel;

namespace MediaInfoDotNet.Models
{
	///<summary>Represents a single menu stream.</summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public sealed class MenuStream : BaseStreamCommons
	{
		///<summary>MenuStream constructor.</summary>
		///<param name="mediaInfo">A MediaInfo object which has already opened a media file.</param>
		///<param name="id">The MediaInfo ID for this menu stream.</param>
		public MenuStream(MediaInfo mediaInfo, int id)
			: base(mediaInfo, StreamKind.Menu, id) {
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

		#region GeneralVideoAudioTextImageMenuCommon

		///<summary>Codec ID available from some codecs.</summary>
		///<example>AAC audio:A_AAC, h.264 video:V_MPEG4/ISO/AVC</example>
		[Description("Codec ID available from some codecs."), Category("GeneralVideoAudioTextImageMenuCommon")]
		public string CodecId { get { return this.codecId; } }

		///<summary>Common name of the codec.</summary>
		[Description("Common name of the codec."), Category("GeneralVideoAudioTextImageMenuCommon")]
		public string CodecCommonName { get { return this.codecCommonName; } }

		#endregion

		#region GeneralVideoAudioTextMenu

		///<summary>Stream delay (e.g. to sync audio/video) in ms.</summary>
		[Description("Stream delay (e.g. to sync audio/video) in ms."), Category("GeneralVideoAudioTextMenu")]
		public int Delay { get { return this.delay; } }

		///<summary>Duration of the stream in milliseconds.</summary>
		[Description("Duration of the stream in milliseconds."), Category("GeneralVideoAudioTextMenu")]
		public int Duration { get { return this.duration; } }

		#endregion

		#region VideoAudioTextImageMenuCommon

		///<summary>2-letter (if available) or 3-letter ISO code.</summary>
		[Description("2-letter (if available) or 3-letter ISO code."), Category("VideoAudioTextImageMenuCommon")]
		public string Language { get { return this.language; } }

		#endregion
	}
}
