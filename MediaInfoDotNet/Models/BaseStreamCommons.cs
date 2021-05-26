﻿/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * Copyright (C) 2013 Carsten Schlote
 ******************************************************************************
 * MultiStreamCommon.cs
 *
 * Provides methods common to more then one stream type
 ******************************************************************************
 */

using System;
using System.Collections.Generic;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	/// <summary>Functionality common to more than one stream type.</summary>
	public class BaseStreamCommons : Media
	{
		///<summary>MultiStreamCommon constructor.</summary>
		///<param name="mediaInfo">A MediaInfo object.</param>
		///<param name="kind">A MediaInfo StreamKind.</param>
		///<param name="id">The MediaInfo ID for this audio stream.</param>
		public BaseStreamCommons(MediaInfo mediaInfo, StreamKind kind, int id)
			: base(mediaInfo, kind, id) {
		}

		#region AllStreamsCommon

		int _streamid = Int32.MinValue;
		///<summary>The ID of this stream in the file.</summary>
		public int streamid {
			get {
				if (_streamid == Int32.MinValue)
					_streamid = miGetInt("ID");
				return _streamid;
			}
		}

		string _format;
		///<summary>The format or container of this file or stream.</summary>
		public string format {
			get {
				if (_format == null)
					_format = miGetString("Format");
				return _format;
			}
		}

		string _format_info;
		///<summary>Additional format information for this stream.</summary>
		public string format_info {
			get {
				if (_format_info == null)
					_format_info = miGetString("Format/Info");
				return _format_info;
			}
		}

		string _format_profile;
		///<summary>Additional format information for this stream.</summary>
		public string format_profile {
			get {
				if (_format_profile == null)
					_format_profile = miGetString("Format_Profile");
				return _format_profile;
			}
		}

		string _format_version;
		///<summary>Additional format information for this stream.</summary>
		public string format_version {
			get {
				if (_format_version == null)
					_format_version = miGetString("Format_Version");
				return _format_version;
			}
		}

	    string _format_commercial;
	    ///<summary>Commercial format name.</summary>
	    public string format_commercial {
	        get {
	            if (_format_commercial == null)
	                _format_commercial = miGetString("Format_Commercial");
	            return _format_commercial;
	        }
	    }


		string _title;
		///<summary>The title of this stream.</summary>
		public string title {
			get {
				if (_title == null)
					_title = miGetString("Title"); //FIXME Why must this be uppercase? Bug?
				if (String.IsNullOrEmpty(_title)) {
					_title = miGetString("TITLE"); //FIXME Why must this be uppercase? Bug?
				}
				return _title;
			}
		}

		string _uniqueId;
		///<summary>This stream's globally unique ID (GUID).</summary>
		public string uniqueId {
			get {
				if (_uniqueId == null)
					_uniqueId = miGetString("UniqueID");
				return _uniqueId;
			}
		}

		#endregion

		#region GeneralVideoCommon

		string _encodedApplication;
		/// <summary>Encoding application for this file or stream.</summary>
		public string encodedApplication {
			get {
				if (String.IsNullOrEmpty(_encodedApplication))
					_encodedApplication = miGetString("Encoded_Application");
				return _encodedApplication;
			}
		}

		#endregion

		#region GeneralVideoAudioTextImageCommon

		DateTime _encodedDate = DateTime.MinValue;
		///<summary>Date and time stream encoding completed.</summary>
		public DateTime encodedDate {
			get {
				if (_encodedDate == DateTime.MinValue)
					_encodedDate = miGetDateTime("Encoded_Date");
				return _encodedDate;
			}
		}

		string _encoderLibrary = null;
		///<summary>Software used to encode this stream.</summary>
		public string encoderLibrary {
			get {
				if (_encoderLibrary == null)
					_encoderLibrary = miGetString("Encoded_Library");
				return _encoderLibrary;
			}
		}

		string _internetMediaType = null;
		///<summary>Media type of stream, formerly called MIME type.</summary>
		public string internetMediaType {
			get {
				if (_internetMediaType == null)
					_internetMediaType = miGetString("InternetMediaType");
				return _internetMediaType;
			}
		}

		long _size = long.MinValue;
		///<summary>Size in bytes.</summary>
		public long size {
			get {
				if (_size == long.MinValue) {
					if (kind == StreamKind.General)
						_size = miGetLong("FileSize");
					else
						_size = miGetLong("StreamSize");
				}
				return _size;
			}
		}

		string _encoderSettingsRaw = null;
		///<summary>Encoder settings used for encoding this stream.
		///String format: name=value / name=value / ...</summary>
		public string encoderSettingsRaw {
			get {
				if (_encoderSettingsRaw == null)
					_encoderSettingsRaw
						= miGetString("Encoded_Library_Settings");
				return _encoderSettingsRaw;
			}
		}

		IDictionary<string, string> _encoderSettings = null;
		///<summary>Encoder settings used for encoding this stream.</summary>
		public IDictionary<string, string> encoderSettings {
			get {
				if (_encoderSettings == null) {
					_encoderSettings = new Dictionary<string, string>();
					String settings = encoderSettingsRaw;
					foreach (var setting in settings.Split('/')) {
						var keyValue = setting.Trim().Split('=');
						if (keyValue.Length == 2) {
							if (!_encoderSettings.ContainsKey(keyValue[0]))
								_encoderSettings.Add(keyValue[0], keyValue[1]);
						}
					}
				}
				return _encoderSettings;
			}
		}

		#endregion

		#region GeneralVideoAudioTextImageMenuCommon

		string _codecId = null;
		///<summary>Codec ID available from some codecs.</summary>
		///<example>AAC audio:A_AAC, h.264 video:V_MPEG4/ISO/AVC</example>
		public string codecId {
			get {
				if (_codecId == null)
					_codecId = miGetString("CodecID");
				return _codecId;
			}
		}

		string _codecCommonName = null;
		///<summary>Common name of the codec.</summary>
		public string codecCommonName {
			get {
				if (_codecCommonName == null)
					_codecCommonName = miGetString("CodecID/Hint");
				return _codecCommonName;
			}
		}

		#endregion

		#region GeneralVideoAudioTextMenu

		int _delay = int.MinValue;
		///<summary>Stream delay (e.g. to sync audio/video) in ms.</summary>
		public int delay {
			get {
				if (_delay == int.MinValue)
					_delay = miGetInt("Delay");
				return _delay;
			}
		}

		double _duration = double.MinValue;
		///<summary>Duration of the stream in milliseconds.</summary>
		public double duration {
			get {
				if (_duration == double.MinValue)
					_duration = miGetDouble("Duration");
				return _duration;
			}
		}

		#endregion

		#region VideoAudioTextCommon

		string _bitRate = null;
		///<summary>The bit rate of this stream, in bits per second</summary>
		public string bitRate {
			get {
				if (String.IsNullOrEmpty(_bitRate))
					_bitRate = miGetString("BitRate");
				return _bitRate;
			}
		}

		int _bitRateMaximum = int.MinValue;
		///<summary>The maximum bitrate of this stream in BPS.</summary>
		public int bitRateMaximum {
			get {
				if (_bitRateMaximum == int.MinValue)
					_bitRateMaximum = miGetInt("BitRate_Maximum");
				return _bitRateMaximum;
			}
		}

		int _bitRateMinimum = int.MinValue;
		///<summary>The minimum bitrate of this stream in BPS.</summary>
		public int bitRateMinimum {
			get {
				if (_bitRateMinimum == int.MinValue)
					_bitRateMinimum = miGetInt("BitRate_Minimum");
				return _bitRateMinimum;
			}
		}

		int _bitRateNominal = int.MinValue;
		///<summary>The maximum allowed bitrate, in BPS, with the encoder
		/// settings used. Some encoders report the average BPS.</summary>
		public int bitRateNominal {
			get {
				if (_bitRateNominal == int.MinValue)
					_bitRateNominal = miGetInt("BitRate_Nominal");
				return _bitRateNominal;
			}
		}

		string _bitRateMode = null;
		///<summary>Mode (CBR, VBR) used for bit allocation.</summary>
		public string bitRateMode {
			get {
				if (_bitRateMode == null)
					_bitRateMode = miGetString("BitRate_Mode");
				return _bitRateMode;
			}
		}

		string _muxingMode = null;
		///<summary>How the stream is muxed into the container.</summary>
		public string muxingMode {
			get {
				if (_muxingMode == null)
					_muxingMode = miGetString("MuxingMode");
				return _muxingMode;
			}
		}

		int _frameCount = int.MinValue;
		///<summary>The total number of frames (e.g. video frames).</summary>
		public int frameCount {
			get {
				if (_frameCount == int.MinValue)
					_frameCount = miGetInt("FrameCount");
				return _frameCount;
			}
		}

		float _frameRate = float.MinValue;
		///<summary>Frame rate of the stream in frames per second.</summary>
		public float frameRate {
			get {
				if (_frameRate == float.MinValue)
					_frameRate = miGetFloat("FrameRate");
				return _frameRate;
			}
		}

		#endregion

		#region VideoAudioTextImageCommon

		string _compressionMode = null;
		///<summary>Compression mode (lossy or lossless).</summary>
		public string compressionMode {
			get {
				if (_compressionMode == null)
					_compressionMode = miGetString("Compression_Mode");
				return _compressionMode;
			}
		}

		string _compressionRatio = null;
		///<summary>Ratio of current size to uncompressed size.</summary>
		public string compressionRatio {
			get {
				if (_compressionRatio == null)
					_compressionRatio = miGetString("Compression_Ratio");
				//FIXME Never seen in tests. Derive from Streamsize_* parameters?
				return _compressionRatio;
			}
		}

		int _bitDepth = int.MinValue;
		///<example>Stream bit depth (16, 24, 32...)</example>
		public int bitDepth {
			get {
				if (_bitDepth == int.MinValue)
					_bitDepth = miGetInt("BitDepth");
				return _bitDepth;
			}
		}

		#endregion

		#region VideoAudioTextImageMenuCommon

		string _language = null;
		///<summary>2-letter (if available) or 3-letter ISO code.</summary>
		public string language {
			get {
				if (_language == null)
					_language = miGetString("Language");
				return _language;
			}
		}

		#endregion

		#region VideoImageCommon

		float _displayAspectRatio = float.MinValue;
		///<summary>Ratio of pixel width to pixel height.</summary>
		public float displayAspectRatio {
			get {
				if (_displayAspectRatio == float.MinValue)
					_displayAspectRatio = miGetFloat("DisplayAspectRatio");
				return _displayAspectRatio;
			}
		}

		float _pixelAspectRatio = float.MinValue;
		///<summary>Ratio of pixel width to pixel height.</summary>
		public float pixelAspectRatio {
			get {
				if (_pixelAspectRatio == float.MinValue)
					_pixelAspectRatio = miGetFloat("PixelAspectRatio");
				return _pixelAspectRatio;
			}
		}

		#endregion

		#region VideoTextCommon

		string _frameRateMode = null;
		///<summary>Frame rate mode (CFR, VFR) of stream.</summary>
		public string frameRateMode {
			get {
				if (_frameRateMode == null)
					_frameRateMode = miGetString("FrameRate_Mode");
				return _frameRateMode;
			}
		}

		#endregion

		#region VideoTextImageCommon

		int _height = int.MinValue;
		///<summary>Height in pixels.</summary>
		public int height {
			get {
				if (_height == int.MinValue)
					_height = miGetInt("Height");
				return _height;
			}
		}

		int _width = int.MinValue;
		///<summary>Width in pixels.</summary>
		public int width {
			get {
				if (_width == int.MinValue)
					_width = miGetInt("Width");
				return _width;
			}
		}

		string _colorspace;
		///<summary>Colorspace used for encoding.</summary>
		public string colorspace {
			get {
				if (String.IsNullOrEmpty(_colorspace))
					_colorspace = miGetString("ColorSpace");
				return _colorspace;
			}
		}

		string _chromasubsampling;
		///<summary>Colorspace used for encoding.</summary>
		public string chromasubsampling {
			get {
				if (String.IsNullOrEmpty(_chromasubsampling))
					_chromasubsampling = miGetString("ChromaSubsampling");
				return _chromasubsampling;
			}
		}

	    string _scantype;
	    ///<summary>Scan Type - Interlaced or Progressive</summary>
	    public string scantype
	    {
	        get
	        {
	            if (String.IsNullOrEmpty(_scantype))
	                _scantype = miGetString("ScanType");
	            return _scantype;
	        }
	    }

	    string _scanorder;
	    ///<summary>Scan Order - if Interlaced, the field order</summary>
        public string scanorder
        {
            get
            {
                if (String.IsNullOrEmpty(_scanorder))
                    _scanorder = miGetString("ScanOrder");
                return _scanorder;
            }
        }
		#endregion

		#region AudioTextCommon

		string _default;
		///<summary>Colorspace used for encoding.</summary>
		public bool default_track {
			get {
				if (String.IsNullOrEmpty(_default)) {
					_default = miGetString("Default");
				}
				return String.Compare(_default,"Yes",true)==0;
			}
		}

		string _forced;
		///<summary>Colorspace used for encoding.</summary>
		public bool forced_track {
			get {
				if (String.IsNullOrEmpty(_forced)) {
					_forced = miGetString("Forced");
				}
				return String.Compare(_forced, "Yes", true) == 0;
			}
		}

		#endregion

	}
}
