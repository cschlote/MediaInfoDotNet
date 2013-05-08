/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * Copyright (C) 2013 Carsten Schlote
 * 
 ******************************************************************************
 *
 * GeneralStream.cs
 * 
 * Presents information and functionality at the file-level.
 * 
 ******************************************************************************
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
    ///<summary>For inheritance by classes representing media files.</summary>
//    [TypeConverter (typeof (ExpandableObjectConverter))]
    public sealed class GeneralStream : Media
    {
        readonly MultiStreamCommon streamCommon;

        ///<summary>GeneralStream constructor.</summary>
        ///<param name="mediaInfo">A MediaInfo object.</param>
        ///<param name="id">The MediaInfo ID for this audio stream.</param>
        public GeneralStream (MediaInfo mediaInfo, int id)
            : base (mediaInfo, StreamKind.General, id) {
            streamCommon = new MultiStreamCommon (mediaInfo, kind, id);
        }

        #region AllStreamsCommon

        ///<summary>The format or container of this file or stream.</summary>
        [Description ("The format or container of this file or stream."), Category ("AllStreamCommon")]
        public string format { get { return streamCommon.format; } }

        ///<summary>The title of this stream.</summary>
        [Description ("The title of this stream."), Category ("AllStreamCommon")]
        public string title { get { return streamCommon.title; } }

        ///<summary>This stream's globally unique ID (GUID).</summary>
        [Description ("This stream's globally unique ID (GUID)."), Category ("AllStreamCommon")]
        public string uniqueId { get { return streamCommon.uniqueId; } }

        #endregion

        #region GeneralVideoAudioTextImageCommon

        ///<summary>Date and time stream encoding completed.</summary>
        [Description ("Date and time stream encoding completed."), Category ("GeneralVideoAudioTextImageCommon")]
        public DateTime encodedDate { get { return streamCommon.encodedDate; } }

        ///<summary>Software used to encode this stream.</summary>
        [Description ("Software used to encode this stream."), Category ("GeneralVideoAudioTextImageCommon")]
        public string encodedLibrary { get { return streamCommon.encoderLibrary; } }

        ///<summary>Media type of stream, formerly called MIME type.</summary>
        [Description (">Media type of stream, formerly called MIME type."), Category ("GeneralVideoAudioTextImageCommon")]
        public string internetMediaType { get { return streamCommon.internetMediaType; } }

        ///<summary>Size in bytes.</summary>
        [Description ("Size in bytes."), Category ("GeneralVideoAudioTextImageCommon")]
        public long size { get { return streamCommon.size; } }

        ///<summary>Encoder settings used for encoding this stream.
        ///String format: name=value / name=value / ...</summary>
        [Description ("Raw encoder settings used for encoding this stream."), Category ("GeneralVideoAudioTextImageCommon")]
        public string encoderSettingsRaw { get { return streamCommon.encoderSettingsRaw; } }

        ///<summary>Encoder settings used for encoding this stream.</summary>
        [Description ("Encoder settings used for encoding this stream."), Category ("GeneralVideoAudioTextImageCommon")]
        public IDictionary<string, string> encoderSettings { get { return streamCommon.encoderSettings; } }

        #endregion

        #region GeneralVideoAudioTextImageMenuCommon

        ///<summary>Codec ID available from some codecs.</summary>
        ///<example>AAC audio:A_AAC, h.264 video:V_MPEG4/ISO/AVC</example>
        [Description ("Codec ID available from some codecs."), Category ("GeneralVideoAudioTextImageMenuCommon")]
        public string codecId { get { return streamCommon.codecId; } }

        ///<summary>Common name of the codec.</summary>
        [Description ("Common name of the codec."), Category ("GeneralVideoAudioTextImageMenuCommon")]
        public string codecCommonName { get { return streamCommon.codecCommonName; } }

        #endregion

        #region GeneralVideoAudioTextMenu

        ///<summary>Stream delay (e.g. to sync audio/video) in ms.</summary>
        [Description ("Stream delay (e.g. to sync audio/video) in ms."), Category ("GeneralVideoAudioTextMenu")]
        public int delay { get { return streamCommon.delay; } }

        ///<summary>Duration of the stream in milliseconds.</summary>
        [Description ("Duration of the stream in milliseconds."), Category ("GeneralVideoAudioTextMenu")]
        public int duration { get { return streamCommon.duration; } }

        #endregion

        #region General

        string _encodedBy;
        ///<summary>Name of the person/group who encoded this file.</summary>
        [Description ("Name of the person/group who encoded this file."), Category ("General")]
        public string encodedBy {
            get {
                if (_encodedBy == null)
                    _encodedBy = miGetString ("EncodedBy");
                return _encodedBy;
            }
        }

        string _album;
        ///<summary>Album name, if the file represents an album.</summary>
        [Description ("Album name, if the file represents an album."), Category ("General")]
        public string album {
            get {
                if (_album == null)
                    _album = miGetString ("Album");
                return _album;
            }
        }

        string _iTunesGrouping = null;
        ///<summary>The grouping used by iTunes.</summary>
        [Description ("The grouping used by iTunes."), Category ("General")]
        public string iTunesGrouping {
            get {
                if (_iTunesGrouping == null)
                    _iTunesGrouping = miGetString ("Grouping");
                return _iTunesGrouping;
            }
        }

        string _iTunesCompilation = null;
        ///<summary>The compilation used by iTunes.</summary>
        [Description ("The compilation used by iTunes."), Category ("General")]
        public string iTunesCompilation {
            get {
                if (_iTunesCompilation == null)
                    _iTunesCompilation = miGetString ("Compilation");
                return _iTunesCompilation;
            }
        }

        int _bitRate = int.MinValue;
        ///<summary>Overall bitrate of all streams.</summary>
        [Description ("Overall bitrate of all streams."), Category ("General")]
        public int bitRate {
            get {
                if (_bitRate == int.MinValue)
                    _bitRate = miGetInt ("OverallBitRate");
                return _bitRate;
            }
        }

        int _bitRateMaximum = int.MinValue;
        ///<summary>Maximum overall bitrate of all streams.</summary>
        [Description ("Maximum overall bitrate of all streams."), Category ("General")]
        public int bitRateMaximum {
            get {
                if (_bitRateMaximum == int.MinValue)
                    _bitRateMaximum = miGetInt ("OverallBitRate_Maximum");
                return _bitRateMaximum;
            }
        }

        int _bitRateMinimum = int.MinValue;
        ///<summary>Minimum overall bitrate of all streams.</summary>
        [Description ("Minimum overall bitrate of all streams."), Category ("General")]
        public int bitRateMinimum {
            get {
                if (_bitRateMinimum == int.MinValue)
                    _bitRateMinimum = miGetInt ("OverallBitRate_Minimum");
                return _bitRateMinimum;
            }
        }

        int _bitRateNominal = int.MinValue;
        ///<summary>Maximum allowed overall bitrate of all streams.</summary>
        [Description ("Maximum allowed overall bitrate of all streams."), Category ("General")]
        public int bitRateNominal {
            get {
                if (_bitRateNominal == int.MinValue)
                    _bitRateNominal = miGetInt ("OverallBitRate_Nominal");
                return _bitRateNominal;
            }
        }
        #endregion

        #region General/Counts
        int _videoCount = int.MinValue;
        ///<summary>Number of video streams in this file.</summary>
        [Description ("Number of video streams."), Category ("General/Counts")]
        public int videoCount {
            get {
                if (_videoCount == int.MinValue)
                    _videoCount = miGetInt ("VideoCount");
                return _videoCount;
            }
        }

        int _audioCount = int.MinValue;
        ///<summary>Number of audio streams in this file.</summary>
        [Description ("Number of audio streams."), Category ("General/Counts")]
        public int audioCount {
            get {
                if (_audioCount == int.MinValue)
                    _audioCount = miGetInt ("AudioCount");
                return _audioCount;
            }
        }

        int _textCount = int.MinValue;
        ///<summary>Number of subtitles or other texts in this file.</summary>
        [Description ("Number of text streams."), Category ("General/Counts")]
        public int textCount {
            get {
                if (_textCount == int.MinValue)
                    _textCount = miGetInt ("TextCount");
                return _textCount;
            }
        }

        int _imageCount = int.MinValue;
        ///<summary>Number of images in this file.</summary>
        [Description ("Number of image streams."), Category ("General/Counts")]
        public int imageCount {
            get {
                if (_imageCount == int.MinValue)
                    _imageCount = miGetInt ("ImageCount");
                return _imageCount;
            }
        }

        int _chapterCount = int.MinValue;
        ///<summary>Number of others in this file.</summary>
        [Description ("Number of other streams."), Category ("General/Counts")]
        public int chapterCount {
            get {
                if (_chapterCount == int.MinValue)
                    _chapterCount = miGetInt ("ChapterCount");
                return _chapterCount;
            }
        }

        int _menuCount = int.MinValue;
        ///<summary>Number of menu streams in this file.</summary>
        [Description ("Number of menu streams."), Category ("General/Counts")]
        public int menuCount {
            get {
                if (_menuCount == int.MinValue)
                    _menuCount = miGetInt ("MenuCount");
                return _menuCount;
            }
        }
        #endregion
    }
}
