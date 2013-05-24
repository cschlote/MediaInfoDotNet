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
using System.Collections;

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

		/// <summary>Gets the summary text for this object</summary>
		[Description("Gets the summary text for this object."), Category("MediaFile")]
		public string Inform { get { return General.miInform(); } }

		/// <summary>Gets the summary text for this object</summary>
		[Description("Gets the summary text for this object."), Category("MediaFile")]
		public bool InformComplete {
			get {
				return String.IsNullOrEmpty(General.miOption("Complete")) ? true : false;
			}
			set {
				General.miOption("Complete", value ? "1" : String.Empty);
			}
		}

		/// <summary>Gets the summary text of parameters provided by MediaInfo.dll.</summary>
		[Description("Gets the summary text of parameters provided by MediaInfo.dll."), Category("MediaFile")]
		public string InfoParameters { get { return General.miOption("Info_Parameters"); } }

		/// <summary>Gets the summary text of codecs known by MediaInfo.dll.</summary>
		[Description("Gets the summary text of codecs known by MediaInfo.dll."), Category("MediaFile")]
		public string InfoCodecs { get { return General.miOption("Info_Codecs"); } }

		/// <summary>Gets the version of MediaInfo.dll.</summary>
		[Description("Gets the version of MediaInfo.dll."), Category("MediaFile")]
		public string InfoVersion { get { return General.miOption("Info_Version"); } }

		/// <summary>Gets the project URL of MediaInfo.dll.</summary>
		[Description("Gets the project URL of MediaInfo.dll."), Category("MediaFile")]
		public string InfoUrl { get { return General.miOption("Info_Url"); } }

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
		public bool HasStreams {
			get {
                return General.VideoCount > 0 || General.AudioCount > 0 || General.TextCount > 0 ||
                    General.OtherCount > 0 || General.ImageCount > 0 || General.MenuCount > 0;
			}
		}

		List<VideoStream> videoStreams;
        ///<summary>Video streams in this file.</summary>
        [Description ("Video streams in this file."), Category ("Streams")]
		public IList<VideoStream> Video {
            get {
                if (videoStreams == null) {
					videoStreams = new List<VideoStream>(General.VideoCount);
					for (int id = 0; id < General.VideoCount; ++id) {
                        videoStreams.Add (new VideoStream (mediaInfo, id));
                    }
                }
                return videoStreams;
            }
        }

		List<AudioStream> audioStreams;
        ///<summary>Audio streams in this file.</summary>
        [Description ("Audio streams in this file."), Category ("Streams")]
		public IList<AudioStream> Audio {
            get {
                if (audioStreams == null) {
					audioStreams = new List<AudioStream>(General.AudioCount);
					for (int id = 0; id < General.AudioCount; ++id) {
                        audioStreams.Add (new AudioStream (mediaInfo, id));
                    }
                }
                return audioStreams;
            }
        }


		IList<TextStream> textStreams;
        ///<summary>Text streams in this file.</summary>
        [Description ("Text streams in this file."), Category ("Streams")]
		public IList<TextStream> Text {
            get {
                if (textStreams == null) {
					textStreams = new List<TextStream>(General.TextCount);
                    for (int id = 0; id < General.TextCount; ++id) {
                        textStreams.Add (new TextStream (mediaInfo, id));
                    }
                }
                return textStreams;
            }
        }


		IList<ImageStream> imageStreams;
        ///<summary>Image streams in this file.</summary>
        [Description ("Image streams in this file."), Category ("Streams")]
		public IList<ImageStream> Image {
            get {
                if (imageStreams == null) {
					imageStreams = new List<ImageStream>(General.ImageCount);
                    for (int id = 0; id < General.ImageCount; ++id) {
                        imageStreams.Add (new ImageStream (mediaInfo, id));
                    }
                }
                return imageStreams;
            }
        }


		IList<OtherStream> otherStreams;
        ///<summary>Other streams in this file.</summary>
        [Description ("Other streams in this file. (e.g. chapters)"), Category ("Streams")]
		public IList<OtherStream> Other {
            get {
                if (otherStreams == null) {
					otherStreams = new List<OtherStream>(General.OtherCount);
                    for (int id = 0; id < General.OtherCount; ++id) {
                        otherStreams.Add (new OtherStream (mediaInfo, id));
                    }
                }
                return otherStreams;
            }
        }


		IList<MenuStream> menuStreams;
        ///<summary>Menu streams in this file.</summary>
        [Description ("Menu streams in this file."), Category ("Streams")]
		public IList<MenuStream> Menu {
            get {
                if (menuStreams == null) {
					menuStreams = new List<MenuStream>(General.MenuCount);
                    for (int id = 0; id < General.MenuCount; ++id) {
                        menuStreams.Add (new MenuStream (mediaInfo, id));
                    }
                }
                return menuStreams;
            }
        }

    }
}
