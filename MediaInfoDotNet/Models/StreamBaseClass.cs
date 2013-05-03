/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 ******************************************************************************
 * StreamBaseClass.cs
 * 
 * Represents information and functionality common to all streams.
 * 
 ******************************************************************************
 */

using System;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	/// <summary>Implements features common to all media types.</summary>
	public abstract class StreamBaseClass : IDisposable
	{
		/// <summary>Used to create a stream-specific object, such as an audio
		/// stream, for use by an existing MediaInfo object.</summary>
		/// <param name="mediaInfo">A pre-initialized MediaInfo object.</param>
		/// <param name="id">The MediaInfo ID for this stream.</param>
		public StreamBaseClass(MediaInfo mediaInfo, int id) {
			string errorText;
			this.mediaInfo = mediaInfo;
			if(mediaInfo == null) {
				errorText = "MediaInfo object cannot be null.";
				throw new ArgumentNullException(errorText);
			}
			else if(!isMediaInfoDllCompatible()) {
				errorText = "Incompatible version of MediaInfo.DLL";
				throw new InvalidOperationException(errorText);
			}
			else {				
				this.id = id;
			}

		}

		/// <summary>Complete path to the currently opened media file.</summary>
		public string filePath { get; private set; }

		/// <summary>Initializes the initial MediaInfo object.</summary>
		/// <param name="filePath">Complete path and name of a file.</param>
		public StreamBaseClass(string filePath) {
			if(filePath == null)
				throw new ArgumentNullException("File name cannot be null.");
			this.mediaInfo = new MediaInfo();
			mediaInfo.Open(filePath);
			this.filePath = filePath;
		}


		/// <summary>MediaInfo object</summary>
		protected MediaInfo mediaInfo { get; private set; }

		/// <summary>MediaInfo ID for this stream kind.</summary>
		protected int id { get; private set; }

		/// <summary>MediaInfo stream kind.</summary>
		protected StreamKind streamKind;


		string _format;
		/// <summary>The format or container of this file or stream.</summary>
		///<example>Matroska, Windows Media, JPEG, MPEG-4.</example>
		public string format {
			get {
				if(_format == null)
					_format = mediaInfo.Get(streamKind, id, "Format");
				return _format;
			}
		}


		string _uniqueId;
		/// <summary>This stream's globally unique ID (GUID).</summary>
		public string uniqueId {
			get {
				if(_uniqueId == null)
					_uniqueId = mediaInfo.Get(streamKind, id, "UniqueID");
				return _uniqueId;
			}
		}


		/// <summary>Returns a MediaInfo value as a long, 0 if error.</summary>
		/// <param name="parameter">The MediaInfo parameter.</param>
		public long miGetLong(string parameter) {
			long parsedValue;
			string miResult = mediaInfo.Get(streamKind, id, parameter);
			long.TryParse(miResult, out parsedValue);
			return parsedValue;
		}


		/// <summary>Returns a MediaInfo value as an int, 0 if error.</summary>
		/// <param name="parameter">The MediaInfo parameter.</param>
		public int miGetInt(string parameter) {
			int parsedValue;
			string miResult = mediaInfo.Get(streamKind, id, parameter);
			int.TryParse(miResult, out parsedValue);
			return parsedValue;
		}


		/// <summary>Returns a MediaInfo date, Minval if error.</summary>
		/// <param name="parameter">The MediaInfo parameter.</param>
		public DateTime miGetDateTime(string parameter) {
			DateTime parsedValue;
			string miResult = mediaInfo.Get(streamKind, id, parameter);
			DateTime.TryParse(miResult, out parsedValue);
			return parsedValue;
		}


		/// <summary>Returns a MediaInfo value, "" if error.</summary>
		/// <param name="parameter">The MediaInfo parameter.</param>
		public string miGetString(string parameter) {
			string miResult = mediaInfo.Get(streamKind, id, parameter);
			return miResult == null ? string.Empty : miResult;
		}


		/// <summary>Destructor. Disposes of resources.</summary>
		~StreamBaseClass() {
			Dispose();
		}


		bool disposed = false;
		/// <summary>Ensures resource disposal.</summary>
		public void Dispose() {
			if(disposed == false) {
				disposed = true;
				mediaInfo.Close();
				GC.SuppressFinalize(this);
			}
		}


		/// <summary>Returns true if MediaInfo.dll is compatible.</summary>
		bool isMediaInfoDllCompatible() {
			String ToDisplay =
				mediaInfo.Option("Info_Version", "0.7.0.0;MediaInfo.Net;0.1");
			return (ToDisplay.Length > 0 ? true : false);
		}

	}
}
