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
    public sealed class ImageStream : Media
    {
        readonly MultiStreamCommon streamCommon;

        ///<summary>ImageStream constructor.</summary>
        ///<param name="mediaInfo">A MediaInfo object.</param>
        ///<param name="id">The MediaInfo ID for this image stream.</param>
        public ImageStream (MediaInfo mediaInfo, int id)
            : base (mediaInfo, StreamKind.Image, id) {
            streamCommon = new MultiStreamCommon (mediaInfo, kind, id);
        }

        #region AllStreamsCommon

        ///<summary>The format or container of this file or stream.</summary>
        [Description ("The format or container of this file or stream."), Category ("AllStreamsCommon")]
        public string format { get { return streamCommon.format; } }

        ///<summary>The title of this stream.</summary>
        [Description ("The title of this stream."), Category ("AllStreamsCommon")]
        public string title { get { return streamCommon.title; } }

        ///<summary>This stream's globally unique ID (GUID).</summary>
        [Description ("This stream's globally unique ID (GUID)."), Category ("AllStreamsCommon")]
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
        [Description ("Media type of stream, formerly called MIME type."), Category ("GeneralVideoAudioTextImageCommon")]
        public string internetMediaType { get { return streamCommon.internetMediaType; } }

        ///<summary>Size in bytes.</summary>
        [Description ("Size in bytes."), Category ("GeneralVideoAudioTextImageCommon")]
        public long size { get { return streamCommon.size; } }

        ///<summary>Encoder settings used for encoding this stream.
        ///String format: name=value / name=value / ...</summary>
        [Description ("Encoder settings used for encoding this stream. (Raw String)"), Category ("GeneralVideoAudioTextImageCommon")]
        public string encoderSettingsRaw { get { return streamCommon.encoderSettingsRaw; } }

        ///<summary>Encoder settings used for encoding this stream (as dictionary).</summary>
        [Description ("Encoder settings used for encoding this stream. (Dictionary)"), Category ("GeneralVideoAudioTextImageCommon")]
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

        #region VideoAudioTextImageCommon

        ///<summary>Compression mode (lossy or lossless).</summary>
        [Description ("Compression mode (lossy or lossless)."), Category ("VideoAudioTextImageCommon")]
        public string compressionMode { get { return streamCommon.compressionMode; } }

        ///<summary>Ratio of current size to uncompressed size.</summary>
        [Description ("Ratio of current size to uncompressed size."), Category ("VideoAudioTextImageCommon")]
        public string compressionRatio { get { return streamCommon.compressionRatio; } }

        ///<example>Stream bit depth (16, 24, 32...)</example>
        [Description ("Stream bit depth (16, 24, 32...)"), Category ("VideoAudioTextImageCommon")]
        public int bitDepth { get { return streamCommon.bitDepth; } }

        #endregion

        #region VideoAudioTextImageMenuCommon

        ///<summary>2-letter (if available) or 3-letter ISO code.</summary>
        [Description ("2-letter (if available) or 3-letter ISO code."), Category ("VideoAudioTextImageMenuCommon")]
        public string language { get { return streamCommon.language; } }

        #endregion

        #region VideoTextCommon

        ///<summary>Frame rate mode (CFR, VFR) of stream.</summary>
        [Description ("Frame rate mode (CFR, VFR) of stream."), Category ("VideoTextCommon")]
        public string frameRateMode { get { return streamCommon.frameRateMode; } }

        #endregion

        #region VideoTextImageCommon

        ///<summary>Height in pixels.</summary>
        [Description ("Height in pixels."), Category ("VideoTextImageCommon")]
        public int height { get { return streamCommon.height; } }

        ///<summary>Width in pixels.</summary>
        [Description ("Width in pixels."), Category ("VideoTextImageCommon")]
        public int width { get { return streamCommon.width; } }

        #endregion
    }
}
