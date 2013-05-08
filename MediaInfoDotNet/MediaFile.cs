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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using MediaInfoDotNet.Models;
using MediaInfoLib;

namespace MediaInfoDotNet
{
	///<summary>Represents a media file and all of its content streams.</summary>
    public sealed class MediaFile
    {
        ///<summary>MediaFile constructor.</summary>
        ///<param name="filePath">Complete path and name of a file.</param>
        ///<example>"c:\pics\me.jpg", "/home/charles/me.mkv"</example>
        public MediaFile (string filePath) {
            if (filePath == null)
                throw new ArgumentNullException ("File name cannot be null.");
            this.mediaInfo = new MediaInfo ();
            mediaInfo.Open (filePath);
            this.filePath = filePath;
        }

        ///<summary>Complete path to the current media file.</summary>
        [Description ("Complete path to the current media file."), Category ("MediaFile")]
        public string filePath { get; private set; }

        ///<summary>MediaInfo object</summary>
        MediaInfo mediaInfo;

        GeneralStream _General;
        /// <summary>
        /// General Stream for this media file
        /// </summary>
        [Description ("General information stream"), Category ("Streams")]
        public GeneralStream General {
            get {
                if (_General == null) {
                    _General = new GeneralStream (mediaInfo, 0); 
                }
                return _General;
            }
        }

		/// <summary>
		/// Determines if an opend file contains streams at all. It is very likely that
		/// a file isn't a media file, if this method returns false.
		/// </summary>
		[Description ("Determine, if there are any media streams in a file"), Category ("Streams")]
		public bool hasStreams {
			get {
                return General.videoCount > 0 || General.audioCount > 0 || General.textCount > 0 ||
                    General.chapterCount > 0 || General.imageCount > 0 || General.menuCount > 0;
			}
		}

        IDictionary<int, VideoStream> _Video;
        ///<summary>Video streams in this file.</summary>
        [Description ("Video streams in this file."), Category ("Streams")]
        public IDictionary<int, VideoStream> Video {
            get {
                if (_Video == null) {
                    _Video = new Dictionary<int, VideoStream> (General.videoCount);
                    for (int id = 0; id < General.videoCount; ++id) {
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
                    _Audio = new Dictionary<int, AudioStream> (General.audioCount);
                    for (int id = 0; id < General.audioCount; ++id) {
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
                    _Text = new Dictionary<int, TextStream> (General.textCount);
                    for (int id = 0; id < General.textCount; ++id) {
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
                    _Image = new Dictionary<int, ImageStream> (General.imageCount);
                    for (int id = 0; id < General.imageCount; ++id) {
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
                    _Other = new Dictionary<int, OtherStream> (General.chapterCount);
                    for (int id = 0; id < General.chapterCount; ++id) {
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
                    _Menu = new Dictionary<int, MenuStream> (General.menuCount);
                    for (int id = 0; id < General.menuCount; ++id) {
                        _Menu.Add (id, new MenuStream (mediaInfo, id));
                    }
                }
                return _Menu;
            }
        }

    }
}
