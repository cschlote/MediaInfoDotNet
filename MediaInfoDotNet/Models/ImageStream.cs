/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * Copyright (C) 2013 Carsten Schlote
 * 
 ******************************************************************************
 *
 * ImageStream.cs
 * 
 * Presents information and functionality specific to an image stream.
 * 
 ******************************************************************************
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using MediaInfoDotNet;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
    ///<summary>Represents a single image stream.</summary>
	public sealed class ImageStream : BaseStreamCommons
    {
        ///<summary>ImageStream constructor.</summary>
        ///<param name="mediaInfo">A MediaInfo object.</param>
        ///<param name="id">The MediaInfo ID for this image stream.</param>
        public ImageStream (MediaInfo mediaInfo, int id)
            : base (mediaInfo, StreamKind.Image, id) {
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

		#region VideoTextCommon

		///<summary>Frame rate mode (CFR, VFR) of stream.</summary>
		[Description("Frame rate mode (CFR, VFR) of stream."), Category("VideoTextCommon")]
		public string FrameRateMode { get { return this.frameRateMode; } }

		#endregion

		#region VideoTextImageCommon

		///<summary>Height in pixels.</summary>
		[Description("Height in pixels."), Category("VideoTextImageCommon")]
		public int Height { get { return this.height; } }

		///<summary>Width in pixels.</summary>
		[Description("Width in pixels."), Category("VideoTextImageCommon")]
		public int Width { get { return this.width; } }

		#endregion
	}
}
