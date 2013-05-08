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
    public sealed class MenuStream : Media
    {
        readonly MultiStreamCommon streamCommon;

        ///<summary>MenuStream constructor.</summary>
        ///<param name="mediaInfo">A MediaInfo object which has already opened a media file.</param>
        ///<param name="id">The MediaInfo ID for this menu stream.</param>
        public MenuStream (MediaInfo mediaInfo, int id)
            : base (mediaInfo, StreamKind.Menu, id) {
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

        #region VideoAudioTextImageMenuCommon

        ///<summary>2-letter (if available) or 3-letter ISO code.</summary>
        [Description ("2-letter (if available) or 3-letter ISO code."), Category ("VideoAudioTextImageMenuCommon")]
        public string language { get { return streamCommon.language; } }

        #endregion
    }
}
