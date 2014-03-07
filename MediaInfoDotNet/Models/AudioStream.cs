/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * Copyright (C) 2013 Carsten Schlote
 ******************************************************************************
 * AudioStream.cs
 * 
 * Presents information and functionality specific to an audio stream.
 ******************************************************************************
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	///<summary>Represents a single audio stream.</summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public sealed class AudioStream : BaseStreamCommons
	{
		///<summary>AudioStream constructor.</summary>
		///<param name="mediaInfo">A MediaInfo object.</param>
		///<param name="id">The MediaInfo ID for this audio stream.</param>
		public AudioStream(MediaInfo mediaInfo, int id)
			: base(mediaInfo, StreamKind.Audio, id) {
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

		#region GeneralVideoAudioTextMenu

		///<summary>Stream delay (e.g. to sync audio/video) in ms.</summary>
		[Description("Stream delay (e.g. to sync audio/video) in ms."), Category("GeneralVideoAudioTextMenu")]
		public int Delay { get { return this.delay; } }

		///<summary>Duration of the stream in milliseconds.</summary>
		[Description("Duration of the stream in milliseconds."), Category("GeneralVideoAudioTextMenu")]
		public int Duration { get { return this.duration; } }

		#endregion

		#region VideoAudioTextCommon

		///<summary>The bit rate of this stream, in bits per second</summary>
		[Description("The bit rate of this stream, in bits per second"), Category("VideoAudioTextCommon")]
		public int BitRate { get { return this.bitRate; } }

		///<summary>The maximum bitrate of this stream in BPS.</summary>
		[Description("The maximum bitrate of this stream in BPS."), Category("VideoAudioTextCommon")]
		public int BitRateMaximum { get { return this.bitRateMaximum; } }

		///<summary>The minimum bitrate of this stream in BPS.</summary>
		[Description("The minimum bitrate of this stream in BPS."), Category("VideoAudioTextCommon")]
		public int BitRateMinimum { get { return this.bitRateMinimum; } }

		///<summary>The maximum allowed bitrate, in BPS, with the encoder
		/// settings used. Some encoders report the average BPS.</summary>
		[Description("The maximum allowed bitrate, in BPS, with the encoder settings used. Some encoders report the average BPS."), Category("VideoAudioTextCommon")]
		public int BitRateNominal { get { return this.bitRateNominal; } }

		///<summary>Mode (CBR, VBR) used for bit allocation.</summary>
		[Description("Mode (CBR, VBR) used for bit allocation."), Category("VideoAudioTextCommon")]
		public string BitRateMode { get { return this.bitRateMode; } }

		///<summary>How the stream is muxed into the container.</summary>
		[Description("How the stream is muxed into the container."), Category("VideoAudioTextCommon")]
		public string MuxingMode { get { return this.muxingMode; } }

		///<summary>The total number of frames (e.g. video frames).</summary>
		[Description("The total number of frames (e.g. video frames)."), Category("VideoAudioTextCommon")]
		public int FrameCount { get { return this.frameCount; } }

		///<summary>Frame rate of the stream in frames per second.</summary>
		[Description("Frame rate of the stream in frames per second."), Category("VideoAudioTextCommon")]
		public float FrameRate { get { return this.frameRate; } }

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

		#region AudioTextCommon

		///<summary>The Default flag for this stream.</summary>
		[Description("The Default flag for this stream."), Category("AudioTextCommon")]
		public bool Default { get { return this.default_track; } }

		///<summary>The Forced-Display flag for this stream.</summary>
		[Description("The Forced-Display flag for this stream."), Category("AudioTextCommon")]
		public bool Forced { get { return this.forced_track; } }

		#endregion

		#region Audio

		int _channels = int.MinValue;
		///<summary>Number of audio channels, e.g. 6 for 5.1 audio.</summary>
		[Description("Number of audio channels, e.g. 6 for 5.1 audio."), Category("Audio")]
		public int Channels {
			get {
				if (_channels == int.MinValue)
					_channels = miGetInt("Channel(s)");
				return _channels;
			}
		}

		int _sampleRate = int.MinValue;
		///<summary>Audio sample rate, e.g. 44100 for CD audio.</summary>
		[Description("Audio sample rate, e.g. 44100 for CD audio."), Category("Audio")]
		public int SampleRate {
			get {
				if (_sampleRate == int.MinValue)
					_sampleRate = miGetInt("SamplingRate");
				return _sampleRate;
			}
		}

		#endregion
	}
}
