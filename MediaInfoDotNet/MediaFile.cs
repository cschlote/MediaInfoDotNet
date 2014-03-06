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
using System.Globalization;

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
		public string Inform {
			get {
				General.miOption("Complete", informComplete ? "1" : String.Empty);
				return General.miInform();
			}
		}

		bool informComplete;
		/// <summary>Gets the summary text for this object</summary>
		[Description("Enables the complete summary text for this object."), Category("MediaFile")]
		public bool InformComplete {
			get {
				//return String.IsNullOrEmpty(General.miOption("Complete")) ? true : false;
				return informComplete;
			}
			set {
				informComplete = value;
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
		[TypeConverter (typeof( StreamListConverter<VideoStream> ) )]
		public List<VideoStream> Video {
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
		[TypeConverter(typeof(StreamListConverter<AudioStream>))]
		public List<AudioStream> Audio {
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


		List<TextStream> textStreams;
        ///<summary>Text streams in this file.</summary>
        [Description ("Text streams in this file."), Category ("Streams")]
		[TypeConverter(typeof(StreamListConverter<TextStream>))]
		public List<TextStream> Text {
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


		List<ImageStream> imageStreams;
        ///<summary>Image streams in this file.</summary>
        [Description ("Image streams in this file."), Category ("Streams")]
		[TypeConverter(typeof(StreamListConverter<ImageStream>))]
		public List<ImageStream> Image {
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


		List<OtherStream> otherStreams;
        ///<summary>Other streams in this file.</summary>
        [Description ("Other streams in this file. (e.g. chapters)"), Category ("Streams")]
		[TypeConverter(typeof(StreamListConverter<OtherStream>))]
		public List<OtherStream> Other {
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


		List<MenuStream> menuStreams;
        ///<summary>Menu streams in this file.</summary>
        [Description ("Menu streams in this file."), Category ("Streams")]
		[TypeConverter(typeof(StreamListConverter<MenuStream>))]
		public List<MenuStream> Menu {
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

//#pragma warning disable 1591 // Disable XML documentation warnings

	/// <summary>
	/// TypeConverter for the generic lists above. We don't need an editor
	/// or setting of a value. 
	/// The list item are expanded into virtial Poperties for the PropertyGrid.
	/// </summary>
	/// <typeparam name="ItemType"></typeparam>
	public class StreamListConverter<ItemType> : ExpandableObjectConverter
	{
		/// <summary>
		/// Return true, if we can handle this detinationType, otherwise call base class.
		/// <see cref="System.ComponentModel.TypeConverter.CanConvertTo(ITypeDescriptorContext, Type)"/>
		/// </summary>
		public override bool CanConvertTo(ITypeDescriptorContext context,System.Type destinationType) {
			if (destinationType == typeof(List<ItemType>))
				return true;
			return base.CanConvertTo(context, destinationType);
		}
		/// <summary>
		/// Convert the list object into some humanreadble string...
		/// <see cref="System.ComponentModel.TypeConverter.ConvertTo(object, Type)"/>
		/// </summary>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture,object value,System.Type destinationType) {
			if (destinationType == typeof(System.String))
			{
				List<ItemType> list = (List<ItemType>)value;
				return "There are " + list.Count + " streams of type " + typeof(ItemType).Name;
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
		/// <summary>
		/// Return true, if we can handle sourceType. 
		/// We can'T, because item are static and can't be changed.
		/// <see cref="System.ComponentModel.TypeConverter.CanConvertFrom(ITypeDescriptorContext, Type)"/>
		/// </summary>
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) {
			//if (sourceType == typeof(string))
			//	return true;
			return base.CanConvertFrom(context, sourceType);
		}
		/// <summary>
		/// Return true, if we can handle sourceType. 
		/// We can'T, because item are static and can't be changed.
		/// <see cref="System.ComponentModel.TypeConverter.ConvertFrom(ITypeDescriptorContext, CultureInfo, object)"/>
		/// </summary>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) 
		{
			//if (value is string) {      // Nothing useful to do here.
			//}  
		    return base.ConvertFrom(context, culture, value);
		}

		/// <summary>
		/// Custom GetProperties method. Splits the List items into separate virtual Properties.
		/// <see cref="System.ComponentModel.TypeConverter.GetProperties(ITypeDescriptorContext, object, Attribute[])"/>
		/// </summary>
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object component, Attribute[] attrs) {
			// our list of props.
			ArrayList propList = new ArrayList();

			// add a property descriptor for each stream
			for (int i = 0; i < ((List<ItemType>)component).Count; i++) {
				propList.Add(new StreamListPropertyDescriptor<ItemType>(((List<ItemType>)component), i));
			}

			// return the collection of PropertyDescriptors.
			PropertyDescriptor[] props = (PropertyDescriptor[]) propList.ToArray(typeof(PropertyDescriptor));
			return new PropertyDescriptorCollection(props);
		}

		/// <summary>
		/// This PropertyDescriptor is used to expand the internal lists of stream into separate virtual
		/// properties for the stream. So the stream can be expanded in the property grid.
		/// </summary>
		private class StreamListPropertyDescriptor<StreamItemType> : PropertyDescriptor
		{
			List<StreamItemType> owner;
			int index;
			//System.Drawing.Design.UITypeEditor editor;

			/// <summary>
			/// Initialize our state.
			/// </summary>
			/// <param name="owner">The PropertyTab that created this Property</param>
			/// <param name="index">The vertex this PropertyDescriptor operates on.</param>
			public StreamListPropertyDescriptor(List<StreamItemType> owner, int index) :
				base("Stream " + index, new Attribute[] { CategoryAttribute.Data }) {
				this.owner = owner;
				this.index = index;
			}

			/// <summary>
			/// The type of component the framework expects for this property.  Notice
			/// This returns List'StreamItemType.  That is because the object that is being browsed
			/// when this property is shown is a List'StreamItemType.  So we are faking the PropertyGrid
			/// into thinking this is a property on that type, even though it isn't.
			/// </summary>	
			public override Type ComponentType {
				get {
					return typeof(List<StreamItemType>);
				}
			}

			/// <summary>
			/// Must override abstract properties.
			/// </summary>
			public override bool IsReadOnly {
				get {
					return true;
				}
			}


			/// <summary>
			/// This property is a StreamItemType type property.
			/// </summary>
			public override Type PropertyType {
				get {
					return typeof(StreamItemType);
				}
			}

			/// <summary>
			/// This allows us to specify the editor that will be used for this
			/// property.
			/// </summary>
			/// <param name="editorBaseType"></param>
			/// <returns></returns>
			public override object GetEditor(Type editorBaseType) {
				// make sure we're looking for a UITypeEditor.
				//
				//if (editorBaseType == typeof(System.Drawing.Design.UITypeEditor)) {
				//	// create and return one of our editors.
				//	//
				//	if (editor == null) {
				//		editor = new PointUIEditor(owner.target);
				//	}
				//	return editor;

				//}
				return base.GetEditor(editorBaseType);
			}


			/// <summary>
			/// Gets the value for the StreamList
			/// </summary>
			public override object GetValue(object o) {
				// Just as the the underlaying List<> for the item
				return ((List<StreamItemType>)o)[index];
			}

			/// <summary>
			/// Thsi routine should normale set a value from some object.
			/// Obviously we can't change the the data. So just do nothing.
			/// </summary>
			public override void SetValue(object o, object value) {
			}

			/// <summary>
			/// Abstract base members
			/// </summary>			
			public override void ResetValue(object o) { }

			public override bool CanResetValue(object o) {
				return false;
			}

			public override bool ShouldSerializeValue(object o) {
				return false;
			}
		}
	}
}
