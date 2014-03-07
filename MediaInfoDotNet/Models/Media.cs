/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * Copyright (C) 2013 Carsten Schlote
 * 
 ******************************************************************************
 * StreamBaseClass.cs
 * 
 * Represents information and functionality common to all streams.
 * 
 ******************************************************************************
 */

using System;
using System.ComponentModel;
using System.Globalization;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	///<summary>Implements features common to all stream types.</summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public abstract class Media : IDisposable
	{
		///<summary>Used to create a stream-specific object, such as an audio
		///stream, for use by an existing MediaFile object.</summary>
		///<param name="mediaInfo">A pre-initialized MediaInfo object.</param>
		///<param name="kind">A defined value from StreamKind enum.</param>
		///<param name="id">The MediaInfo ID for this stream.</param>
		public Media(MediaInfo mediaInfo, StreamKind kind, int id) {
			string errorText;
			this.mediaInfo = mediaInfo;
			if (mediaInfo == null) {
				errorText = "MediaInfo object cannot be null.";
				throw new ArgumentNullException(errorText);
			}
			if (!isMediaInfoDllCompatible()) {
				errorText = "Incompatible version of MediaInfo.DLL";
				throw new InvalidOperationException(errorText);
			}
			this.kind = kind;
			if (!Enum.IsDefined(typeof(StreamKind), (object)kind)) {
				errorText = "Invalid value for StreamKind";
				throw new ArgumentOutOfRangeException(errorText);
			}
			this.id = id;
		}

		///<summary>Preinitialized MediaInfo object passed in on instanciation</summary>
		protected MediaInfo mediaInfo { get; private set; }

		///<summary>MediaInfo stream kind.</summary>
		protected StreamKind kind { get; private set; }

		///<summary>MediaInfo ID for this stream kind.</summary>
		protected int id { get; private set; }

		#region MediaInfoLib Calls to unmanged code and type conversion

		/// <summary>Returns an information text containing all detected properties.</summary>
		/// <returns>A string containing all information about a file.</returns>
		public string miInform() {
			string miResult = mediaInfo.Inform();
			return miResult == null ? string.Empty : miResult;
		}

		/// <summary>Returns information about MediaInfo.</summary>
		/// <param name="parameter">Option such as Info_Parameters</param>
		/// <param name="val">Optional argument for parameter, e.g. Opetion("Complete", "Yes") to enable debug Inform() output.</param>
		public string miOption(string parameter, string val = "") {
			string miResult = mediaInfo.Option(parameter, val);
			return miResult == null ? string.Empty : miResult;
		}

		///<summary>Returns a MediaInfo value, "" if error.</summary>
		///<param name="parameter">The MediaInfo parameter.</param>
		public string miGetString(string parameter) {
			string miResult = mediaInfo.Get(kind, id, parameter);
			return miResult == null ? string.Empty : miResult;
		}


		///<summary>Returns a MediaInfo value as a long, 0 if error.</summary>
		///<param name="parameter">The MediaInfo parameter.</param>
		protected long miGetLong(string parameter) {
			long parsedValue;
			string miResult = mediaInfo.Get(kind, id, parameter);
			bool rc = long.TryParse(miResult, NumberStyles.Number,
				System.Globalization.CultureInfo.InvariantCulture, out parsedValue);
			return rc ? parsedValue : 0;
		}


		///<summary>Returns a MediaInfo value as an int, 0 if error.</summary>
		///<param name="parameter">The MediaInfo parameter.</param>
		protected int miGetInt(string parameter) {
			int parsedValue;
			string miResult = mediaInfo.Get(kind, id, parameter);
			bool rc = int.TryParse(miResult, NumberStyles.Number,
				System.Globalization.CultureInfo.InvariantCulture, out parsedValue);
			if (!String.IsNullOrEmpty(miResult) && !rc) {
				System.Diagnostics.Debug.WriteLine("MediaInfo.dll returned NAN for parameter {0}", parameter);
				System.Diagnostics.Debugger.Break();
			}
			return rc ? parsedValue : 0;
		}

		///<summary>Returns a MediaInfo value as a float, 0.0 if error.</summary>
		///<param name="parameter">The MediaInfo parameter.</param>
		protected float miGetFloat(string parameter) {
			float parsedValue;
			string miResult = mediaInfo.Get(kind, id, parameter);
			bool rc = float.TryParse(miResult, NumberStyles.Float,
				System.Globalization.CultureInfo.InvariantCulture, out parsedValue);
			if (!String.IsNullOrEmpty(miResult) && !rc) {
				System.Diagnostics.Debug.WriteLine("MediaInfo.dll returned NAN for parameter {0}", parameter);
				System.Diagnostics.Debugger.Break();
			}
			return rc ? parsedValue : 0.0f;
		}

		///<summary>Returns a MediaInfo value as a float, 0.0 if error.</summary>
		///<param name="parameter">The MediaInfo parameter.</param>
		protected double miGetDouble(string parameter) {
			double parsedValue;
			string miResult = mediaInfo.Get(kind, id, parameter);
			bool rc = double.TryParse(miResult, NumberStyles.Float,
				System.Globalization.CultureInfo.InvariantCulture, out parsedValue);
			if (!String.IsNullOrEmpty(miResult) && !rc) {
				System.Diagnostics.Debug.WriteLine("MediaInfo.dll returned NAN for parameter {0}", parameter);
				System.Diagnostics.Debugger.Break();
			}
			return rc ? parsedValue : 0.0;
		}

		///<summary>Returns a MediaInfo date, Minval if error.</summary>
		///<param name="parameter">The MediaInfo parameter.</param>
		///<param name="format">The DateTime format for TryParseExact()</param>
		protected DateTime miGetDateTime(string parameter,
			string format = "'UTC' yyyy-MM-dd HH:mm:ss") {
			DateTime parsedValue = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc);
			string miResult = mediaInfo.Get(kind, id, parameter);
			bool rc = DateTime.TryParseExact(miResult, format,
				DateTimeFormatInfo.InvariantInfo,
				DateTimeStyles.AssumeUniversal, out parsedValue);
			if (!String.IsNullOrEmpty(miResult) && !rc) {
				System.Diagnostics.Debug.WriteLine("MediaInfo.dll returned NAN for parameter {0}", parameter);
				System.Diagnostics.Debugger.Break();
			}
			return rc ? parsedValue.ToUniversalTime() : DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc);
		}

		#endregion

		#region MediaInfo Version check and Version info
		/// <summary>Cached return value for option Info_Version. Represents
		/// the MediaInfoLib Version</summary>
		protected string miLibVersion = null;

		///<summary>Returns true if MediaInfo.dll is compatible.</summary>
		protected bool isMediaInfoDllCompatible() {
			if (miLibVersion == null)
				miLibVersion = mediaInfo.Option("Info_Version", "0.7.0.0;MediaInfo.Net;0.1");
			return (miLibVersion.Length > 0 ? true : false);
		}
		/// <summary>Returns the version string of the loaded mediainfo DLL</summary>
		/// <returns>The version string returned by mediaInfo.Option()</returns>
		protected string getMediaInfoVersion() {
			if (miLibVersion == null)
				isMediaInfoDllCompatible();
			return miLibVersion;
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>Flag to prevent multiple disposes.</summary>
		private bool disposed = false;
		/// <summary>Internal dispose method.</summary>
		private void Dispose(bool disposing) {
			if (disposed == false) {
				if (disposing) {
					// Dispose managed resources here. NA here.
				}
				disposed = true;
				mediaInfo.Close();
				GC.SuppressFinalize(this);
			}
		}
		///<summary>Destructor. Disposes of resources.</summary>
		~Media() {
			Dispose(false);
		}
		///<summary>Ensures resource disposal.</summary>
		public void Dispose() {
			Dispose(true);
		}

		#endregion
	}
}
