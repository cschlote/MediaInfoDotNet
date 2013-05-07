/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.dll
 * 
 * New versions available from http://code.google.com/p/mediainfo-dot-net/
 * or from http://git.vahanus.net/?p=csc/MediaInfoDotNet.git
 * 
 * Use at your own risk, under the same license as MediaInfo itself.
 * 
 * If you want to make a donation to this project, instead make it to the 
 * MediaInfo project at: http://mediainfo.sourceforge.net
 * 
 * Copyright (C) Charles N. Burns
 * Copyright (C) 2013 Carsten Schlote
 * 
 ******************************************************************************
 * 
 * MediaInfo.cs
 * 
 * Library entrypoint.
 * 
 * To make this work in your .NET project:
 * 1) Add this DLL, MediaInfoDotNet.dll, to your project's "references"
 * 2) Copy MediaInfo.DLL into each subfolder of your project's "bin\" folder
 *    You can download it from http://mediainfo.sourceforge.net
 *    Do not try to add MediaInfo.dll to your "references". Wrong type of DLL.
 */

using System.Collections.Generic;
using System.ComponentModel;
using MediaInfoDotNet.Models;

namespace MediaInfoDotNet
{
	///<summary>Represents a media file and all of its content streams.</summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public sealed class MediaFile : GeneralStream
    {
        ///<summary>MediaFile constructor.</summary>
        ///<param name="filePath">Complete path and name of a file.</param>
        ///<example>"c:\pics\me.jpg", "/home/charles/me.mkv"</example>
        public MediaFile (string filePath)
            : base (filePath) {
        }


        IDictionary<int, VideoStream> _Video;
        ///<summary>Video streams in this file.</summary>
        [Description ("Video streams in this file."), Category ("Streams")]
        public IDictionary<int, VideoStream> Video {
            get {
                if (_Video == null) {
                    _Video = new Dictionary<int, VideoStream> (videoCount);
                    for (int id = 0; id < videoCount; ++id) {
                        _Video.Add (id, new VideoStream (mediaInfo, id));
                    }
                }
                return _Video;
            }
        }

        IDictionary<int, AudioStream> _Audio;
        ///<summary>Audio streams in this file.</summary>
        [Description ("Audio streams in this file."), Category ("Streams")]
        public IDictionary<int, AudioStream> Audio {
            get {
                if (_Audio == null) {
                    _Audio = new Dictionary<int, AudioStream> (audioCount);
                    for (int id = 0; id < audioCount; ++id) {
                        _Audio.Add (id, new AudioStream (mediaInfo, id));
                    }
                }
                return _Audio;
            }
        }


        IDictionary<int, TextStream> _Text;
        ///<summary>Text streams in this file.</summary>
        [Description ("Text streams in this file."), Category ("Streams")]
        public IDictionary<int, TextStream> Text {
            get {
                if (_Text == null) {
                    _Text = new Dictionary<int, TextStream> (textCount);
                    for (int id = 0; id < textCount; ++id) {
                        _Text.Add (id, new TextStream (mediaInfo, id));
                    }
                }
                return _Text;
            }
        }


        IDictionary<int, ImageStream> _Image;
        ///<summary>Image streams in this file.</summary>
        [Description ("Image streams in this file."), Category ("Streams")]
        public IDictionary<int, ImageStream> Image {
            get {
                if (_Image == null) {
                    _Image = new Dictionary<int, ImageStream> (imageCount);
                    for (int id = 0; id < imageCount; ++id) {
                        _Image.Add (id, new ImageStream (mediaInfo, id));
                    }
                }
                return _Image;
            }
        }


        IDictionary<int, OtherStream> _Other;
        ///<summary>Other streams in this file.</summary>
        [Description ("Other streams in this file. (e.g. chapters)"), Category ("Streams")]
        public IDictionary<int, OtherStream> Other {
            get {
                if (_Other == null) {
                    _Other = new Dictionary<int, OtherStream> (otherCount);
                    for (int id = 0; id < otherCount; ++id) {
                        _Other.Add (id, new OtherStream (mediaInfo, id));
                    }
                }
                return _Other;
            }
        }


        IDictionary<int, MenuStream> _Menu;
        ///<summary>Menu streams in this file.</summary>
        [Description ("Menu streams in this file."), Category ("Streams")]
        public IDictionary<int, MenuStream> Menu {
            get {
                if (_Menu == null) {
                    _Menu = new Dictionary<int, MenuStream> (menuCount);
                    for (int id = 0; id < menuCount; ++id) {
                        _Menu.Add (id, new MenuStream (mediaInfo, id));
                    }
                }
                return _Menu;
            }
        }

    }
}
