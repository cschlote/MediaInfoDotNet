/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * Copyright (C) 2013 Carsten Schlote
 ******************************************************************************
 * ImageStream.cs
 * 
 * Presents information and functionality specific to an image stream.
 ******************************************************************************
 */

using MediaInfoDotNet;
using MediaInfoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MediaInfoDotNet.Models
{
	///<summary>Represents a single image stream.</summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public sealed class ImageStream : BaseStreamCommons
	{
		///<summary>ImageStream constructor.</summary>
		///<param name="mediaInfo">A MediaInfo object.</param>
		///<param name="id">The MediaInfo ID for this image stream.</param>
		public ImageStream(MediaInfo mediaInfo, int id)
			: base(mediaInfo, StreamKind.Image, id) {
		}
		/// <summary>Overides base method to provide short summary of stream kind.</summary>
		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}", this.Format);
			if (!String.IsNullOrEmpty(this.FormatProfile)) sb.AppendFormat(" {0}", this.FormatProfile);
			sb.AppendFormat(", {0}x{1} px", this.Width, this.Height);
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

		#region GeneralVideoAudioTextImageMenuCommon

		///<summary>Codec ID available from some codecs.</summary>
		///<example>AAC audio:A_AAC, h.264 video:V_MPEG4/ISO/AVC</example>
		[Description("Codec ID available from some codecs."), Category("GeneralVideoAudioTextImageMenuCommon")]
		public string CodecId { get { return this.codecId; } }

		///<summary>Common name of the codec.</summary>
		[Description("Common name of the codec."), Category("GeneralVideoAudioTextImageMenuCommon")]
		public string CodecCommonName { get { return this.codecCommonName; } }

		#endregion

		#region GeneralVideoAudioTextImageCommon

		///<summary>Date and time stream encoding completed.</summary>
		[Description("Date and time stream encoding completed."), Category("GeneralVideoAudioTextImageCommon")]
		public DateTime EncodedDate { get { return this.encodedDate; } }

		///<summary>Software used to encode this stream.</summary>
		[Description("Software used to encode this stream."), Category("GeneralVideoAudioTextImageCommon")]
		public string EncodedLibrary { get { return this.encoderLibrary; } }

		///<summary>Media type of stream, formerly called MIME type.</summary>
		[Description("Media type of stream, formerly called MIME type."), Category("GeneralVideoAudioTextImageCommon")]
		public string InternetMediaType { get { return this.internetMediaType; } }

		///<summary>Size in bytes.</summary>
		[Description("Size in bytes."), Category("GeneralVideoAudioTextImageCommon")]
		public long Size { get { return this.size; } }

		///<summary>Encoder settings used for encoding this stream.
		///String format: name=value / name=value / ...</summary>
		[Description("Encoder settings used for encoding this stream. (Raw String)"), Category("GeneralVideoAudioTextImageCommon")]
		public string EncoderSettingsRaw { get { return this.encoderSettingsRaw; } }

		///<summary>Encoder settings used for encoding this stream (as dictionary).</summary>
		[Description("Encoder settings used for encoding this stream. (Dictionary)"), Category("GeneralVideoAudioTextImageCommon")]
		public IDictionary<string, string> EncoderSettings { get { return this.encoderSettings; } }

		#endregion

		#region VideoAudioTextImageCommon

		///<summary>Compression mode (lossy or lossless).</summary>
		[Description("Compression mode (lossy or lossless)."), Category("VideoAudioTextImageCommon")]
		public string CompressionMode { get { return this.compressionMode; } }

		///<summary>Ratio of current size to uncompressed size.</summary>
		[Description("Ratio of current size to uncompressed size."), Category("VideoAudioTextImageCommon")]
		public string CompressionRatio { get { return this.compressionRatio; } }

		///<example>Stream bit depth (16, 24, 32...)</example>
		[Description("Stream bit depth (16, 24, 32...)"), Category("VideoAudioTextImageCommon")]
		public int BitDepth { get { return this.bitDepth; } }

		#endregion

		#region VideoAudioTextImageMenuCommon

		///<summary>2-letter (if available) or 3-letter ISO code.</summary>
		[Description("2-letter (if available) or 3-letter ISO code."), Category("VideoAudioTextImageMenuCommon")]
		public string Language { get { return this.language; } }

		#endregion

		#region VideoImageCommon

		///<summary>Ratio of display width to display height.</summary>
		[Description("Ratio of display width to display height."), Category("VideoImageCommon")]
		public float DisplayAspectRatio { get { return this.displayAspectRatio; } }

		///<summary>Ratio of pixel width to pixel height.</summary>
		[Description("Ratio of pixel width to pixel height."), Category("VideoImageCommon")]
		public float PixelAspectRatio { get { return this.pixelAspectRatio; } }

		#endregion

		#region VideoTextImageCommon

		///<summary>Height in pixels.</summary>
		[Description("Height in pixels."), Category("VideoTextImageCommon")]
		public int Height { get { return this.height; } }

		///<summary>Width in pixels.</summary>
		[Description("Width in pixels."), Category("VideoTextImageCommon")]
		public int Width { get { return this.width; } }

		///<summary>Colorspace used for pixel encoding.</summary>
		[Description("Colorspace used for pixel encoding."), Category("VideoTextImageCommon")]
		public string ColorSpace { get { return this.colorspace; } }

		///<summary>ChromaSubsampling used for pixel encoding.</summary>
		[Description("ChromaSubsampling used for pixel encoding."), Category("VideoTextImageCommon")]
		public string ChromaSubsampling { get { return this.chromasubsampling; } }

		#endregion
	}
}
