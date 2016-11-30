using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.VideoIO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']"
	[global::Android.Runtime.Register ("org/opencv/videoio/Videoio", DoNotGenerateAcw=true)]
	public partial class Videoio : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_ANDROID']"
		[Register ("CAP_ANDROID")]
		public const int CapAndroid = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_ANY']"
		[Register ("CAP_ANY")]
		public const int CapAny = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_AVFOUNDATION']"
		[Register ("CAP_AVFOUNDATION")]
		public const int CapAvfoundation = (int) 1200;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_CMU1394']"
		[Register ("CAP_CMU1394")]
		public const int CapCmu1394 = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_DC1394']"
		[Register ("CAP_DC1394")]
		public const int CapDc1394 = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_DSHOW']"
		[Register ("CAP_DSHOW")]
		public const int CapDshow = (int) 700;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_FFMPEG']"
		[Register ("CAP_FFMPEG")]
		public const int CapFfmpeg = (int) 1900;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_FIREWARE']"
		[Register ("CAP_FIREWARE")]
		public const int CapFireware = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_FIREWIRE']"
		[Register ("CAP_FIREWIRE")]
		public const int CapFirewire = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_GIGANETIX']"
		[Register ("CAP_GIGANETIX")]
		public const int CapGiganetix = (int) 1300;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_GPHOTO2']"
		[Register ("CAP_GPHOTO2")]
		public const int CapGphoto2 = (int) 1700;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_GSTREAMER']"
		[Register ("CAP_GSTREAMER")]
		public const int CapGstreamer = (int) 1800;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_IEEE1394']"
		[Register ("CAP_IEEE1394")]
		public const int CapIeee1394 = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_IMAGES']"
		[Register ("CAP_IMAGES")]
		public const int CapImages = (int) 2000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_INTELPERC']"
		[Register ("CAP_INTELPERC")]
		public const int CapIntelperc = (int) 1500;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_INTELPERC_DEPTH_GENERATOR']"
		[Register ("CAP_INTELPERC_DEPTH_GENERATOR")]
		public const int CapIntelpercDepthGenerator = (int) 536870912;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_INTELPERC_DEPTH_MAP']"
		[Register ("CAP_INTELPERC_DEPTH_MAP")]
		public const int CapIntelpercDepthMap = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_INTELPERC_GENERATORS_MASK']"
		[Register ("CAP_INTELPERC_GENERATORS_MASK")]
		public const int CapIntelpercGeneratorsMask = (int) 805306368;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_INTELPERC_IMAGE']"
		[Register ("CAP_INTELPERC_IMAGE")]
		public const int CapIntelpercImage = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_INTELPERC_IMAGE_GENERATOR']"
		[Register ("CAP_INTELPERC_IMAGE_GENERATOR")]
		public const int CapIntelpercImageGenerator = (int) 268435456;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_INTELPERC_IR_MAP']"
		[Register ("CAP_INTELPERC_IR_MAP")]
		public const int CapIntelpercIrMap = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_INTELPERC_UVDEPTH_MAP']"
		[Register ("CAP_INTELPERC_UVDEPTH_MAP")]
		public const int CapIntelpercUvdepthMap = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_MODE_BGR']"
		[Register ("CAP_MODE_BGR")]
		public const int CapModeBgr = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_MODE_GRAY']"
		[Register ("CAP_MODE_GRAY")]
		public const int CapModeGray = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_MODE_RGB']"
		[Register ("CAP_MODE_RGB")]
		public const int CapModeRgb = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_MODE_YUYV']"
		[Register ("CAP_MODE_YUYV")]
		public const int CapModeYuyv = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_MSMF']"
		[Register ("CAP_MSMF")]
		public const int CapMsmf = (int) 1400;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI']"
		[Register ("CAP_OPENNI")]
		public const int CapOpenni = (int) 900;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI2']"
		[Register ("CAP_OPENNI2")]
		public const int CapOpenni2 = (int) 1600;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI2_ASUS']"
		[Register ("CAP_OPENNI2_ASUS")]
		public const int CapOpenni2Asus = (int) 1610;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_ASUS']"
		[Register ("CAP_OPENNI_ASUS")]
		public const int CapOpenniAsus = (int) 910;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_BGR_IMAGE']"
		[Register ("CAP_OPENNI_BGR_IMAGE")]
		public const int CapOpenniBgrImage = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_DEPTH_GENERATOR']"
		[Register ("CAP_OPENNI_DEPTH_GENERATOR")]
		public const int CapOpenniDepthGenerator = (int) -2147483648;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_DEPTH_GENERATOR_BASELINE']"
		[Register ("CAP_OPENNI_DEPTH_GENERATOR_BASELINE")]
		public const int CapOpenniDepthGeneratorBaseline = (int) -2147483546;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_DEPTH_GENERATOR_FOCAL_LENGTH']"
		[Register ("CAP_OPENNI_DEPTH_GENERATOR_FOCAL_LENGTH")]
		public const int CapOpenniDepthGeneratorFocalLength = (int) -2147483545;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION']"
		[Register ("CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION")]
		public const int CapOpenniDepthGeneratorRegistration = (int) -2147483544;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION_ON']"
		[Register ("CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION_ON")]
		public const int CapOpenniDepthGeneratorRegistrationOn = (int) -2147483544;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_DEPTH_MAP']"
		[Register ("CAP_OPENNI_DEPTH_MAP")]
		public const int CapOpenniDepthMap = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_DISPARITY_MAP']"
		[Register ("CAP_OPENNI_DISPARITY_MAP")]
		public const int CapOpenniDisparityMap = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_DISPARITY_MAP_32F']"
		[Register ("CAP_OPENNI_DISPARITY_MAP_32F")]
		public const int CapOpenniDisparityMap32f = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_GENERATORS_MASK']"
		[Register ("CAP_OPENNI_GENERATORS_MASK")]
		public const int CapOpenniGeneratorsMask = (int) -1073741824;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_GRAY_IMAGE']"
		[Register ("CAP_OPENNI_GRAY_IMAGE")]
		public const int CapOpenniGrayImage = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_IMAGE_GENERATOR']"
		[Register ("CAP_OPENNI_IMAGE_GENERATOR")]
		public const int CapOpenniImageGenerator = (int) 1073741824;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_IMAGE_GENERATOR_OUTPUT_MODE']"
		[Register ("CAP_OPENNI_IMAGE_GENERATOR_OUTPUT_MODE")]
		public const int CapOpenniImageGeneratorOutputMode = (int) 1073741924;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_IMAGE_GENERATOR_PRESENT']"
		[Register ("CAP_OPENNI_IMAGE_GENERATOR_PRESENT")]
		public const int CapOpenniImageGeneratorPresent = (int) 1073741933;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_POINT_CLOUD_MAP']"
		[Register ("CAP_OPENNI_POINT_CLOUD_MAP")]
		public const int CapOpenniPointCloudMap = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_QVGA_30HZ']"
		[Register ("CAP_OPENNI_QVGA_30HZ")]
		public const int CapOpenniQvga30hz = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_QVGA_60HZ']"
		[Register ("CAP_OPENNI_QVGA_60HZ")]
		public const int CapOpenniQvga60hz = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_SXGA_15HZ']"
		[Register ("CAP_OPENNI_SXGA_15HZ")]
		public const int CapOpenniSxga15hz = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_SXGA_30HZ']"
		[Register ("CAP_OPENNI_SXGA_30HZ")]
		public const int CapOpenniSxga30hz = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_VALID_DEPTH_MASK']"
		[Register ("CAP_OPENNI_VALID_DEPTH_MASK")]
		public const int CapOpenniValidDepthMask = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_OPENNI_VGA_30HZ']"
		[Register ("CAP_OPENNI_VGA_30HZ")]
		public const int CapOpenniVga30hz = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_APERTURE']"
		[Register ("CAP_PROP_APERTURE")]
		public const int CapPropAperture = (int) 17008;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_AUTOFOCUS']"
		[Register ("CAP_PROP_AUTOFOCUS")]
		public const int CapPropAutofocus = (int) 39;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_AUTO_EXPOSURE']"
		[Register ("CAP_PROP_AUTO_EXPOSURE")]
		public const int CapPropAutoExposure = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_BACKLIGHT']"
		[Register ("CAP_PROP_BACKLIGHT")]
		public const int CapPropBacklight = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_BRIGHTNESS']"
		[Register ("CAP_PROP_BRIGHTNESS")]
		public const int CapPropBrightness = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_BUFFERSIZE']"
		[Register ("CAP_PROP_BUFFERSIZE")]
		public const int CapPropBuffersize = (int) 38;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_CONTRAST']"
		[Register ("CAP_PROP_CONTRAST")]
		public const int CapPropContrast = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_CONVERT_RGB']"
		[Register ("CAP_PROP_CONVERT_RGB")]
		public const int CapPropConvertRgb = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_DC1394_MAX']"
		[Register ("CAP_PROP_DC1394_MAX")]
		public const int CapPropDc1394Max = (int) 31;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_DC1394_MODE_AUTO']"
		[Register ("CAP_PROP_DC1394_MODE_AUTO")]
		public const int CapPropDc1394ModeAuto = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_DC1394_MODE_MANUAL']"
		[Register ("CAP_PROP_DC1394_MODE_MANUAL")]
		public const int CapPropDc1394ModeManual = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_DC1394_MODE_ONE_PUSH_AUTO']"
		[Register ("CAP_PROP_DC1394_MODE_ONE_PUSH_AUTO")]
		public const int CapPropDc1394ModeOnePushAuto = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_DC1394_OFF']"
		[Register ("CAP_PROP_DC1394_OFF")]
		public const int CapPropDc1394Off = (int) -4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_EXPOSURE']"
		[Register ("CAP_PROP_EXPOSURE")]
		public const int CapPropExposure = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_EXPOSUREPROGRAM']"
		[Register ("CAP_PROP_EXPOSUREPROGRAM")]
		public const int CapPropExposureprogram = (int) 17009;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_FOCUS']"
		[Register ("CAP_PROP_FOCUS")]
		public const int CapPropFocus = (int) 28;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_FORMAT']"
		[Register ("CAP_PROP_FORMAT")]
		public const int CapPropFormat = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_FOURCC']"
		[Register ("CAP_PROP_FOURCC")]
		public const int CapPropFourcc = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_FPS']"
		[Register ("CAP_PROP_FPS")]
		public const int CapPropFps = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_FRAME_COUNT']"
		[Register ("CAP_PROP_FRAME_COUNT")]
		public const int CapPropFrameCount = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_FRAME_HEIGHT']"
		[Register ("CAP_PROP_FRAME_HEIGHT")]
		public const int CapPropFrameHeight = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_FRAME_WIDTH']"
		[Register ("CAP_PROP_FRAME_WIDTH")]
		public const int CapPropFrameWidth = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GAIN']"
		[Register ("CAP_PROP_GAIN")]
		public const int CapPropGain = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GAMMA']"
		[Register ("CAP_PROP_GAMMA")]
		public const int CapPropGamma = (int) 22;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GIGA_FRAME_HEIGH_MAX']"
		[Register ("CAP_PROP_GIGA_FRAME_HEIGH_MAX")]
		public const int CapPropGigaFrameHeighMax = (int) 10004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GIGA_FRAME_OFFSET_X']"
		[Register ("CAP_PROP_GIGA_FRAME_OFFSET_X")]
		public const int CapPropGigaFrameOffsetX = (int) 10001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GIGA_FRAME_OFFSET_Y']"
		[Register ("CAP_PROP_GIGA_FRAME_OFFSET_Y")]
		public const int CapPropGigaFrameOffsetY = (int) 10002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GIGA_FRAME_SENS_HEIGH']"
		[Register ("CAP_PROP_GIGA_FRAME_SENS_HEIGH")]
		public const int CapPropGigaFrameSensHeigh = (int) 10006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GIGA_FRAME_SENS_WIDTH']"
		[Register ("CAP_PROP_GIGA_FRAME_SENS_WIDTH")]
		public const int CapPropGigaFrameSensWidth = (int) 10005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GIGA_FRAME_WIDTH_MAX']"
		[Register ("CAP_PROP_GIGA_FRAME_WIDTH_MAX")]
		public const int CapPropGigaFrameWidthMax = (int) 10003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GPHOTO2_COLLECT_MSGS']"
		[Register ("CAP_PROP_GPHOTO2_COLLECT_MSGS")]
		public const int CapPropGphoto2CollectMsgs = (int) 17005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GPHOTO2_FLUSH_MSGS']"
		[Register ("CAP_PROP_GPHOTO2_FLUSH_MSGS")]
		public const int CapPropGphoto2FlushMsgs = (int) 17006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GPHOTO2_PREVIEW']"
		[Register ("CAP_PROP_GPHOTO2_PREVIEW")]
		public const int CapPropGphoto2Preview = (int) 17001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GPHOTO2_RELOAD_CONFIG']"
		[Register ("CAP_PROP_GPHOTO2_RELOAD_CONFIG")]
		public const int CapPropGphoto2ReloadConfig = (int) 17003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GPHOTO2_RELOAD_ON_CHANGE']"
		[Register ("CAP_PROP_GPHOTO2_RELOAD_ON_CHANGE")]
		public const int CapPropGphoto2ReloadOnChange = (int) 17004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GPHOTO2_WIDGET_ENUMERATE']"
		[Register ("CAP_PROP_GPHOTO2_WIDGET_ENUMERATE")]
		public const int CapPropGphoto2WidgetEnumerate = (int) 17002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GSTREAMER_QUEUE_LENGTH']"
		[Register ("CAP_PROP_GSTREAMER_QUEUE_LENGTH")]
		public const int CapPropGstreamerQueueLength = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_GUID']"
		[Register ("CAP_PROP_GUID")]
		public const int CapPropGuid = (int) 29;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_HUE']"
		[Register ("CAP_PROP_HUE")]
		public const int CapPropHue = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD']"
		[Register ("CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD")]
		public const int CapPropIntelpercDepthConfidenceThreshold = (int) 11005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ']"
		[Register ("CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ")]
		public const int CapPropIntelpercDepthFocalLengthHorz = (int) 11006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT']"
		[Register ("CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT")]
		public const int CapPropIntelpercDepthFocalLengthVert = (int) 11007;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE']"
		[Register ("CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE")]
		public const int CapPropIntelpercDepthLowConfidenceValue = (int) 11003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE']"
		[Register ("CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE")]
		public const int CapPropIntelpercDepthSaturationValue = (int) 11004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_INTELPERC_PROFILE_COUNT']"
		[Register ("CAP_PROP_INTELPERC_PROFILE_COUNT")]
		public const int CapPropIntelpercProfileCount = (int) 11001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_INTELPERC_PROFILE_IDX']"
		[Register ("CAP_PROP_INTELPERC_PROFILE_IDX")]
		public const int CapPropIntelpercProfileIdx = (int) 11002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_IOS_DEVICE_EXPOSURE']"
		[Register ("CAP_PROP_IOS_DEVICE_EXPOSURE")]
		public const int CapPropIosDeviceExposure = (int) 9002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_IOS_DEVICE_FLASH']"
		[Register ("CAP_PROP_IOS_DEVICE_FLASH")]
		public const int CapPropIosDeviceFlash = (int) 9003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_IOS_DEVICE_FOCUS']"
		[Register ("CAP_PROP_IOS_DEVICE_FOCUS")]
		public const int CapPropIosDeviceFocus = (int) 9001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_IOS_DEVICE_TORCH']"
		[Register ("CAP_PROP_IOS_DEVICE_TORCH")]
		public const int CapPropIosDeviceTorch = (int) 9005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_IOS_DEVICE_WHITEBALANCE']"
		[Register ("CAP_PROP_IOS_DEVICE_WHITEBALANCE")]
		public const int CapPropIosDeviceWhitebalance = (int) 9004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_IRIS']"
		[Register ("CAP_PROP_IRIS")]
		public const int CapPropIris = (int) 36;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_ISO_SPEED']"
		[Register ("CAP_PROP_ISO_SPEED")]
		public const int CapPropIsoSpeed = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_MODE']"
		[Register ("CAP_PROP_MODE")]
		public const int CapPropMode = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_MONOCHROME']"
		[Register ("CAP_PROP_MONOCHROME")]
		public const int CapPropMonochrome = (int) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI2_MIRROR']"
		[Register ("CAP_PROP_OPENNI2_MIRROR")]
		public const int CapPropOpenni2Mirror = (int) 111;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI2_SYNC']"
		[Register ("CAP_PROP_OPENNI2_SYNC")]
		public const int CapPropOpenni2Sync = (int) 110;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_APPROX_FRAME_SYNC']"
		[Register ("CAP_PROP_OPENNI_APPROX_FRAME_SYNC")]
		public const int CapPropOpenniApproxFrameSync = (int) 105;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_BASELINE']"
		[Register ("CAP_PROP_OPENNI_BASELINE")]
		public const int CapPropOpenniBaseline = (int) 102;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_CIRCLE_BUFFER']"
		[Register ("CAP_PROP_OPENNI_CIRCLE_BUFFER")]
		public const int CapPropOpenniCircleBuffer = (int) 107;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_FOCAL_LENGTH']"
		[Register ("CAP_PROP_OPENNI_FOCAL_LENGTH")]
		public const int CapPropOpenniFocalLength = (int) 103;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_FRAME_MAX_DEPTH']"
		[Register ("CAP_PROP_OPENNI_FRAME_MAX_DEPTH")]
		public const int CapPropOpenniFrameMaxDepth = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_GENERATOR_PRESENT']"
		[Register ("CAP_PROP_OPENNI_GENERATOR_PRESENT")]
		public const int CapPropOpenniGeneratorPresent = (int) 109;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_MAX_BUFFER_SIZE']"
		[Register ("CAP_PROP_OPENNI_MAX_BUFFER_SIZE")]
		public const int CapPropOpenniMaxBufferSize = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_MAX_TIME_DURATION']"
		[Register ("CAP_PROP_OPENNI_MAX_TIME_DURATION")]
		public const int CapPropOpenniMaxTimeDuration = (int) 108;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_OUTPUT_MODE']"
		[Register ("CAP_PROP_OPENNI_OUTPUT_MODE")]
		public const int CapPropOpenniOutputMode = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_REGISTRATION']"
		[Register ("CAP_PROP_OPENNI_REGISTRATION")]
		public const int CapPropOpenniRegistration = (int) 104;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_OPENNI_REGISTRATION_ON']"
		[Register ("CAP_PROP_OPENNI_REGISTRATION_ON")]
		public const int CapPropOpenniRegistrationOn = (int) 104;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_PAN']"
		[Register ("CAP_PROP_PAN")]
		public const int CapPropPan = (int) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_POS_AVI_RATIO']"
		[Register ("CAP_PROP_POS_AVI_RATIO")]
		public const int CapPropPosAviRatio = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_POS_FRAMES']"
		[Register ("CAP_PROP_POS_FRAMES")]
		public const int CapPropPosFrames = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_POS_MSEC']"
		[Register ("CAP_PROP_POS_MSEC")]
		public const int CapPropPosMsec = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_PVAPI_BINNINGX']"
		[Register ("CAP_PROP_PVAPI_BINNINGX")]
		public const int CapPropPvapiBinningx = (int) 304;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_PVAPI_BINNINGY']"
		[Register ("CAP_PROP_PVAPI_BINNINGY")]
		public const int CapPropPvapiBinningy = (int) 305;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_PVAPI_DECIMATIONHORIZONTAL']"
		[Register ("CAP_PROP_PVAPI_DECIMATIONHORIZONTAL")]
		public const int CapPropPvapiDecimationhorizontal = (int) 302;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_PVAPI_DECIMATIONVERTICAL']"
		[Register ("CAP_PROP_PVAPI_DECIMATIONVERTICAL")]
		public const int CapPropPvapiDecimationvertical = (int) 303;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_PVAPI_FRAMESTARTTRIGGERMODE']"
		[Register ("CAP_PROP_PVAPI_FRAMESTARTTRIGGERMODE")]
		public const int CapPropPvapiFramestarttriggermode = (int) 301;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_PVAPI_MULTICASTIP']"
		[Register ("CAP_PROP_PVAPI_MULTICASTIP")]
		public const int CapPropPvapiMulticastip = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_PVAPI_PIXELFORMAT']"
		[Register ("CAP_PROP_PVAPI_PIXELFORMAT")]
		public const int CapPropPvapiPixelformat = (int) 306;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_RECTIFICATION']"
		[Register ("CAP_PROP_RECTIFICATION")]
		public const int CapPropRectification = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_ROLL']"
		[Register ("CAP_PROP_ROLL")]
		public const int CapPropRoll = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_SATURATION']"
		[Register ("CAP_PROP_SATURATION")]
		public const int CapPropSaturation = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_SETTINGS']"
		[Register ("CAP_PROP_SETTINGS")]
		public const int CapPropSettings = (int) 37;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_SHARPNESS']"
		[Register ("CAP_PROP_SHARPNESS")]
		public const int CapPropSharpness = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_SPEED']"
		[Register ("CAP_PROP_SPEED")]
		public const int CapPropSpeed = (int) 17007;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_TEMPERATURE']"
		[Register ("CAP_PROP_TEMPERATURE")]
		public const int CapPropTemperature = (int) 23;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_TILT']"
		[Register ("CAP_PROP_TILT")]
		public const int CapPropTilt = (int) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_TRIGGER']"
		[Register ("CAP_PROP_TRIGGER")]
		public const int CapPropTrigger = (int) 24;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_TRIGGER_DELAY']"
		[Register ("CAP_PROP_TRIGGER_DELAY")]
		public const int CapPropTriggerDelay = (int) 25;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_VIEWFINDER']"
		[Register ("CAP_PROP_VIEWFINDER")]
		public const int CapPropViewfinder = (int) 17010;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_WHITE_BALANCE_BLUE_U']"
		[Register ("CAP_PROP_WHITE_BALANCE_BLUE_U")]
		public const int CapPropWhiteBalanceBlueU = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_WHITE_BALANCE_RED_V']"
		[Register ("CAP_PROP_WHITE_BALANCE_RED_V")]
		public const int CapPropWhiteBalanceRedV = (int) 26;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_AEAG']"
		[Register ("CAP_PROP_XI_AEAG")]
		public const int CapPropXiAeag = (int) 415;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_AEAG_LEVEL']"
		[Register ("CAP_PROP_XI_AEAG_LEVEL")]
		public const int CapPropXiAeagLevel = (int) 419;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_AE_MAX_LIMIT']"
		[Register ("CAP_PROP_XI_AE_MAX_LIMIT")]
		public const int CapPropXiAeMaxLimit = (int) 417;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_AG_MAX_LIMIT']"
		[Register ("CAP_PROP_XI_AG_MAX_LIMIT")]
		public const int CapPropXiAgMaxLimit = (int) 418;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_AUTO_WB']"
		[Register ("CAP_PROP_XI_AUTO_WB")]
		public const int CapPropXiAutoWb = (int) 414;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_DATA_FORMAT']"
		[Register ("CAP_PROP_XI_DATA_FORMAT")]
		public const int CapPropXiDataFormat = (int) 401;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_DOWNSAMPLING']"
		[Register ("CAP_PROP_XI_DOWNSAMPLING")]
		public const int CapPropXiDownsampling = (int) 400;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_EXP_PRIORITY']"
		[Register ("CAP_PROP_XI_EXP_PRIORITY")]
		public const int CapPropXiExpPriority = (int) 416;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_GPI_LEVEL']"
		[Register ("CAP_PROP_XI_GPI_LEVEL")]
		public const int CapPropXiGpiLevel = (int) 408;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_GPI_MODE']"
		[Register ("CAP_PROP_XI_GPI_MODE")]
		public const int CapPropXiGpiMode = (int) 407;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_GPI_SELECTOR']"
		[Register ("CAP_PROP_XI_GPI_SELECTOR")]
		public const int CapPropXiGpiSelector = (int) 406;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_GPO_MODE']"
		[Register ("CAP_PROP_XI_GPO_MODE")]
		public const int CapPropXiGpoMode = (int) 410;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_GPO_SELECTOR']"
		[Register ("CAP_PROP_XI_GPO_SELECTOR")]
		public const int CapPropXiGpoSelector = (int) 409;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_LED_MODE']"
		[Register ("CAP_PROP_XI_LED_MODE")]
		public const int CapPropXiLedMode = (int) 412;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_LED_SELECTOR']"
		[Register ("CAP_PROP_XI_LED_SELECTOR")]
		public const int CapPropXiLedSelector = (int) 411;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_MANUAL_WB']"
		[Register ("CAP_PROP_XI_MANUAL_WB")]
		public const int CapPropXiManualWb = (int) 413;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_OFFSET_X']"
		[Register ("CAP_PROP_XI_OFFSET_X")]
		public const int CapPropXiOffsetX = (int) 402;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_OFFSET_Y']"
		[Register ("CAP_PROP_XI_OFFSET_Y")]
		public const int CapPropXiOffsetY = (int) 403;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_TIMEOUT']"
		[Register ("CAP_PROP_XI_TIMEOUT")]
		public const int CapPropXiTimeout = (int) 420;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_TRG_SOFTWARE']"
		[Register ("CAP_PROP_XI_TRG_SOFTWARE")]
		public const int CapPropXiTrgSoftware = (int) 405;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_XI_TRG_SOURCE']"
		[Register ("CAP_PROP_XI_TRG_SOURCE")]
		public const int CapPropXiTrgSource = (int) 404;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PROP_ZOOM']"
		[Register ("CAP_PROP_ZOOM")]
		public const int CapPropZoom = (int) 27;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI']"
		[Register ("CAP_PVAPI")]
		public const int CapPvapi = (int) 800;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_DECIMATION_2OUTOF16']"
		[Register ("CAP_PVAPI_DECIMATION_2OUTOF16")]
		public const int CapPvapiDecimation2outof16 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_DECIMATION_2OUTOF4']"
		[Register ("CAP_PVAPI_DECIMATION_2OUTOF4")]
		public const int CapPvapiDecimation2outof4 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_DECIMATION_2OUTOF8']"
		[Register ("CAP_PVAPI_DECIMATION_2OUTOF8")]
		public const int CapPvapiDecimation2outof8 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_DECIMATION_OFF']"
		[Register ("CAP_PVAPI_DECIMATION_OFF")]
		public const int CapPvapiDecimationOff = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_FSTRIGMODE_FIXEDRATE']"
		[Register ("CAP_PVAPI_FSTRIGMODE_FIXEDRATE")]
		public const int CapPvapiFstrigmodeFixedrate = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_FSTRIGMODE_FREERUN']"
		[Register ("CAP_PVAPI_FSTRIGMODE_FREERUN")]
		public const int CapPvapiFstrigmodeFreerun = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_FSTRIGMODE_SOFTWARE']"
		[Register ("CAP_PVAPI_FSTRIGMODE_SOFTWARE")]
		public const int CapPvapiFstrigmodeSoftware = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_FSTRIGMODE_SYNCIN1']"
		[Register ("CAP_PVAPI_FSTRIGMODE_SYNCIN1")]
		public const int CapPvapiFstrigmodeSyncin1 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_FSTRIGMODE_SYNCIN2']"
		[Register ("CAP_PVAPI_FSTRIGMODE_SYNCIN2")]
		public const int CapPvapiFstrigmodeSyncin2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_PIXELFORMAT_BAYER16']"
		[Register ("CAP_PVAPI_PIXELFORMAT_BAYER16")]
		public const int CapPvapiPixelformatBayer16 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_PIXELFORMAT_BAYER8']"
		[Register ("CAP_PVAPI_PIXELFORMAT_BAYER8")]
		public const int CapPvapiPixelformatBayer8 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_PIXELFORMAT_BGR24']"
		[Register ("CAP_PVAPI_PIXELFORMAT_BGR24")]
		public const int CapPvapiPixelformatBgr24 = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_PIXELFORMAT_BGRA32']"
		[Register ("CAP_PVAPI_PIXELFORMAT_BGRA32")]
		public const int CapPvapiPixelformatBgra32 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_PIXELFORMAT_MONO16']"
		[Register ("CAP_PVAPI_PIXELFORMAT_MONO16")]
		public const int CapPvapiPixelformatMono16 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_PIXELFORMAT_MONO8']"
		[Register ("CAP_PVAPI_PIXELFORMAT_MONO8")]
		public const int CapPvapiPixelformatMono8 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_PIXELFORMAT_RGB24']"
		[Register ("CAP_PVAPI_PIXELFORMAT_RGB24")]
		public const int CapPvapiPixelformatRgb24 = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_PVAPI_PIXELFORMAT_RGBA32']"
		[Register ("CAP_PVAPI_PIXELFORMAT_RGBA32")]
		public const int CapPvapiPixelformatRgba32 = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_QT']"
		[Register ("CAP_QT")]
		public const int CapQt = (int) 500;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_UNICAP']"
		[Register ("CAP_UNICAP")]
		public const int CapUnicap = (int) 600;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_V4L']"
		[Register ("CAP_V4L")]
		public const int CapV4l = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_V4L2']"
		[Register ("CAP_V4L2")]
		public const int CapV4l2 = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_VFW']"
		[Register ("CAP_VFW")]
		public const int CapVfw = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_WINRT']"
		[Register ("CAP_WINRT")]
		public const int CapWinrt = (int) 1410;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CAP_XIAPI']"
		[Register ("CAP_XIAPI")]
		public const int CapXiapi = (int) 1100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_ANDROID']"
		[Register ("CV_CAP_ANDROID")]
		public const int CvCapAndroid = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_ANDROID_BACK']"
		[Register ("CV_CAP_ANDROID_BACK")]
		public const int CvCapAndroidBack = (int) 1099;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_ANDROID_FRONT']"
		[Register ("CV_CAP_ANDROID_FRONT")]
		public const int CvCapAndroidFront = (int) 1098;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_AVFOUNDATION']"
		[Register ("CV_CAP_AVFOUNDATION")]
		public const int CvCapAvfoundation = (int) 1200;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_FFMPEG']"
		[Register ("CV_CAP_FFMPEG")]
		public const int CvCapFfmpeg = (int) 1900;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_GIGANETIX']"
		[Register ("CV_CAP_GIGANETIX")]
		public const int CvCapGiganetix = (int) 1300;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_GPHOTO2']"
		[Register ("CV_CAP_GPHOTO2")]
		public const int CvCapGphoto2 = (int) 1700;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_GSTREAMER']"
		[Register ("CV_CAP_GSTREAMER")]
		public const int CvCapGstreamer = (int) 1800;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_IMAGES']"
		[Register ("CV_CAP_IMAGES")]
		public const int CvCapImages = (int) 2000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_MODE_BGR']"
		[Register ("CV_CAP_MODE_BGR")]
		public const int CvCapModeBgr = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_MODE_GRAY']"
		[Register ("CV_CAP_MODE_GRAY")]
		public const int CvCapModeGray = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_MODE_RGB']"
		[Register ("CV_CAP_MODE_RGB")]
		public const int CvCapModeRgb = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_MODE_YUYV']"
		[Register ("CV_CAP_MODE_YUYV")]
		public const int CvCapModeYuyv = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_MSMF']"
		[Register ("CV_CAP_MSMF")]
		public const int CvCapMsmf = (int) 1400;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_ANTIBANDING']"
		[Register ("CV_CAP_PROP_ANDROID_ANTIBANDING")]
		public const int CvCapPropAndroidAntibanding = (int) 8004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_EXPOSE_LOCK']"
		[Register ("CV_CAP_PROP_ANDROID_EXPOSE_LOCK")]
		public const int CvCapPropAndroidExposeLock = (int) 8009;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_FLASH_MODE']"
		[Register ("CV_CAP_PROP_ANDROID_FLASH_MODE")]
		public const int CvCapPropAndroidFlashMode = (int) 8001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_FOCAL_LENGTH']"
		[Register ("CV_CAP_PROP_ANDROID_FOCAL_LENGTH")]
		public const int CvCapPropAndroidFocalLength = (int) 8005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_FOCUS_DISTANCE_FAR']"
		[Register ("CV_CAP_PROP_ANDROID_FOCUS_DISTANCE_FAR")]
		public const int CvCapPropAndroidFocusDistanceFar = (int) 8008;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_FOCUS_DISTANCE_NEAR']"
		[Register ("CV_CAP_PROP_ANDROID_FOCUS_DISTANCE_NEAR")]
		public const int CvCapPropAndroidFocusDistanceNear = (int) 8006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_FOCUS_DISTANCE_OPTIMAL']"
		[Register ("CV_CAP_PROP_ANDROID_FOCUS_DISTANCE_OPTIMAL")]
		public const int CvCapPropAndroidFocusDistanceOptimal = (int) 8007;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_FOCUS_MODE']"
		[Register ("CV_CAP_PROP_ANDROID_FOCUS_MODE")]
		public const int CvCapPropAndroidFocusMode = (int) 8002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_WHITEBALANCE_LOCK']"
		[Register ("CV_CAP_PROP_ANDROID_WHITEBALANCE_LOCK")]
		public const int CvCapPropAndroidWhitebalanceLock = (int) 8010;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ANDROID_WHITE_BALANCE']"
		[Register ("CV_CAP_PROP_ANDROID_WHITE_BALANCE")]
		public const int CvCapPropAndroidWhiteBalance = (int) 8003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_APERTURE']"
		[Register ("CV_CAP_PROP_APERTURE")]
		public const int CvCapPropAperture = (int) 17008;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_AUTOFOCUS']"
		[Register ("CV_CAP_PROP_AUTOFOCUS")]
		public const int CvCapPropAutofocus = (int) 39;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_AUTOGRAB']"
		[Register ("CV_CAP_PROP_AUTOGRAB")]
		public const int CvCapPropAutograb = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_BACKLIGHT']"
		[Register ("CV_CAP_PROP_BACKLIGHT")]
		public const int CvCapPropBacklight = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_BUFFERSIZE']"
		[Register ("CV_CAP_PROP_BUFFERSIZE")]
		public const int CvCapPropBuffersize = (int) 38;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_FOCUS']"
		[Register ("CV_CAP_PROP_FOCUS")]
		public const int CvCapPropFocus = (int) 28;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_FRAME_HEIGHT']"
		[Register ("CV_CAP_PROP_FRAME_HEIGHT")]
		public const int CvCapPropFrameHeight = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_FRAME_WIDTH']"
		[Register ("CV_CAP_PROP_FRAME_WIDTH")]
		public const int CvCapPropFrameWidth = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GIGA_FRAME_HEIGH_MAX']"
		[Register ("CV_CAP_PROP_GIGA_FRAME_HEIGH_MAX")]
		public const int CvCapPropGigaFrameHeighMax = (int) 10004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GIGA_FRAME_OFFSET_X']"
		[Register ("CV_CAP_PROP_GIGA_FRAME_OFFSET_X")]
		public const int CvCapPropGigaFrameOffsetX = (int) 10001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GIGA_FRAME_OFFSET_Y']"
		[Register ("CV_CAP_PROP_GIGA_FRAME_OFFSET_Y")]
		public const int CvCapPropGigaFrameOffsetY = (int) 10002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GIGA_FRAME_SENS_HEIGH']"
		[Register ("CV_CAP_PROP_GIGA_FRAME_SENS_HEIGH")]
		public const int CvCapPropGigaFrameSensHeigh = (int) 10006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GIGA_FRAME_SENS_WIDTH']"
		[Register ("CV_CAP_PROP_GIGA_FRAME_SENS_WIDTH")]
		public const int CvCapPropGigaFrameSensWidth = (int) 10005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GIGA_FRAME_WIDTH_MAX']"
		[Register ("CV_CAP_PROP_GIGA_FRAME_WIDTH_MAX")]
		public const int CvCapPropGigaFrameWidthMax = (int) 10003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GPHOTO2_COLLECT_MSGS']"
		[Register ("CV_CAP_PROP_GPHOTO2_COLLECT_MSGS")]
		public const int CvCapPropGphoto2CollectMsgs = (int) 17005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GPHOTO2_FLUSH_MSGS']"
		[Register ("CV_CAP_PROP_GPHOTO2_FLUSH_MSGS")]
		public const int CvCapPropGphoto2FlushMsgs = (int) 17006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GPHOTO2_PREVIEW']"
		[Register ("CV_CAP_PROP_GPHOTO2_PREVIEW")]
		public const int CvCapPropGphoto2Preview = (int) 17001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GPHOTO2_RELOAD_CONFIG']"
		[Register ("CV_CAP_PROP_GPHOTO2_RELOAD_CONFIG")]
		public const int CvCapPropGphoto2ReloadConfig = (int) 17003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GPHOTO2_RELOAD_ON_CHANGE']"
		[Register ("CV_CAP_PROP_GPHOTO2_RELOAD_ON_CHANGE")]
		public const int CvCapPropGphoto2ReloadOnChange = (int) 17004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GPHOTO2_WIDGET_ENUMERATE']"
		[Register ("CV_CAP_PROP_GPHOTO2_WIDGET_ENUMERATE")]
		public const int CvCapPropGphoto2WidgetEnumerate = (int) 17002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_GUID']"
		[Register ("CV_CAP_PROP_GUID")]
		public const int CvCapPropGuid = (int) 29;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD']"
		[Register ("CV_CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD")]
		public const int CvCapPropIntelpercDepthConfidenceThreshold = (int) 11005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ']"
		[Register ("CV_CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ")]
		public const int CvCapPropIntelpercDepthFocalLengthHorz = (int) 11006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT']"
		[Register ("CV_CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT")]
		public const int CvCapPropIntelpercDepthFocalLengthVert = (int) 11007;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE']"
		[Register ("CV_CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE")]
		public const int CvCapPropIntelpercDepthLowConfidenceValue = (int) 11003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE']"
		[Register ("CV_CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE")]
		public const int CvCapPropIntelpercDepthSaturationValue = (int) 11004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_INTELPERC_PROFILE_COUNT']"
		[Register ("CV_CAP_PROP_INTELPERC_PROFILE_COUNT")]
		public const int CvCapPropIntelpercProfileCount = (int) 11001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_INTELPERC_PROFILE_IDX']"
		[Register ("CV_CAP_PROP_INTELPERC_PROFILE_IDX")]
		public const int CvCapPropIntelpercProfileIdx = (int) 11002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_IOS_DEVICE_EXPOSURE']"
		[Register ("CV_CAP_PROP_IOS_DEVICE_EXPOSURE")]
		public const int CvCapPropIosDeviceExposure = (int) 9002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_IOS_DEVICE_FLASH']"
		[Register ("CV_CAP_PROP_IOS_DEVICE_FLASH")]
		public const int CvCapPropIosDeviceFlash = (int) 9003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_IOS_DEVICE_FOCUS']"
		[Register ("CV_CAP_PROP_IOS_DEVICE_FOCUS")]
		public const int CvCapPropIosDeviceFocus = (int) 9001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_IOS_DEVICE_TORCH']"
		[Register ("CV_CAP_PROP_IOS_DEVICE_TORCH")]
		public const int CvCapPropIosDeviceTorch = (int) 9005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_IOS_DEVICE_WHITEBALANCE']"
		[Register ("CV_CAP_PROP_IOS_DEVICE_WHITEBALANCE")]
		public const int CvCapPropIosDeviceWhitebalance = (int) 9004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_IRIS']"
		[Register ("CV_CAP_PROP_IRIS")]
		public const int CvCapPropIris = (int) 36;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ISO_SPEED']"
		[Register ("CV_CAP_PROP_ISO_SPEED")]
		public const int CvCapPropIsoSpeed = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_OPENNI2_MIRROR']"
		[Register ("CV_CAP_PROP_OPENNI2_MIRROR")]
		public const int CvCapPropOpenni2Mirror = (int) 111;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_OPENNI2_SYNC']"
		[Register ("CV_CAP_PROP_OPENNI2_SYNC")]
		public const int CvCapPropOpenni2Sync = (int) 110;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_PAN']"
		[Register ("CV_CAP_PROP_PAN")]
		public const int CvCapPropPan = (int) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_PREVIEW_FORMAT']"
		[Register ("CV_CAP_PROP_PREVIEW_FORMAT")]
		public const int CvCapPropPreviewFormat = (int) 1026;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_PVAPI_BINNINGX']"
		[Register ("CV_CAP_PROP_PVAPI_BINNINGX")]
		public const int CvCapPropPvapiBinningx = (int) 304;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_PVAPI_BINNINGY']"
		[Register ("CV_CAP_PROP_PVAPI_BINNINGY")]
		public const int CvCapPropPvapiBinningy = (int) 305;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_PVAPI_DECIMATIONHORIZONTAL']"
		[Register ("CV_CAP_PROP_PVAPI_DECIMATIONHORIZONTAL")]
		public const int CvCapPropPvapiDecimationhorizontal = (int) 302;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_PVAPI_DECIMATIONVERTICAL']"
		[Register ("CV_CAP_PROP_PVAPI_DECIMATIONVERTICAL")]
		public const int CvCapPropPvapiDecimationvertical = (int) 303;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_PVAPI_FRAMESTARTTRIGGERMODE']"
		[Register ("CV_CAP_PROP_PVAPI_FRAMESTARTTRIGGERMODE")]
		public const int CvCapPropPvapiFramestarttriggermode = (int) 301;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_PVAPI_PIXELFORMAT']"
		[Register ("CV_CAP_PROP_PVAPI_PIXELFORMAT")]
		public const int CvCapPropPvapiPixelformat = (int) 306;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ROLL']"
		[Register ("CV_CAP_PROP_ROLL")]
		public const int CvCapPropRoll = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_SAR_DEN']"
		[Register ("CV_CAP_PROP_SAR_DEN")]
		public const int CvCapPropSarDen = (int) 41;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_SAR_NUM']"
		[Register ("CV_CAP_PROP_SAR_NUM")]
		public const int CvCapPropSarNum = (int) 40;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_SETTINGS']"
		[Register ("CV_CAP_PROP_SETTINGS")]
		public const int CvCapPropSettings = (int) 37;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_SPEED']"
		[Register ("CV_CAP_PROP_SPEED")]
		public const int CvCapPropSpeed = (int) 17007;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_TILT']"
		[Register ("CV_CAP_PROP_TILT")]
		public const int CvCapPropTilt = (int) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_VIEWFINDER']"
		[Register ("CV_CAP_PROP_VIEWFINDER")]
		public const int CvCapPropViewfinder = (int) 17010;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_ACQ_BUFFER_SIZE']"
		[Register ("CV_CAP_PROP_XI_ACQ_BUFFER_SIZE")]
		public const int CvCapPropXiAcqBufferSize = (int) 548;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_ACQ_BUFFER_SIZE_UNIT']"
		[Register ("CV_CAP_PROP_XI_ACQ_BUFFER_SIZE_UNIT")]
		public const int CvCapPropXiAcqBufferSizeUnit = (int) 549;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_ACQ_FRAME_BURST_COUNT']"
		[Register ("CV_CAP_PROP_XI_ACQ_FRAME_BURST_COUNT")]
		public const int CvCapPropXiAcqFrameBurstCount = (int) 499;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_ACQ_TIMING_MODE']"
		[Register ("CV_CAP_PROP_XI_ACQ_TIMING_MODE")]
		public const int CvCapPropXiAcqTimingMode = (int) 538;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_COMMIT']"
		[Register ("CV_CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_COMMIT")]
		public const int CvCapPropXiAcqTransportBufferCommit = (int) 552;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_SIZE']"
		[Register ("CV_CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_SIZE")]
		public const int CvCapPropXiAcqTransportBufferSize = (int) 550;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AEAG']"
		[Register ("CV_CAP_PROP_XI_AEAG")]
		public const int CvCapPropXiAeag = (int) 415;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AEAG_LEVEL']"
		[Register ("CV_CAP_PROP_XI_AEAG_LEVEL")]
		public const int CvCapPropXiAeagLevel = (int) 419;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AEAG_ROI_HEIGHT']"
		[Register ("CV_CAP_PROP_XI_AEAG_ROI_HEIGHT")]
		public const int CvCapPropXiAeagRoiHeight = (int) 442;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AEAG_ROI_OFFSET_X']"
		[Register ("CV_CAP_PROP_XI_AEAG_ROI_OFFSET_X")]
		public const int CvCapPropXiAeagRoiOffsetX = (int) 439;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AEAG_ROI_OFFSET_Y']"
		[Register ("CV_CAP_PROP_XI_AEAG_ROI_OFFSET_Y")]
		public const int CvCapPropXiAeagRoiOffsetY = (int) 440;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AEAG_ROI_WIDTH']"
		[Register ("CV_CAP_PROP_XI_AEAG_ROI_WIDTH")]
		public const int CvCapPropXiAeagRoiWidth = (int) 441;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AE_MAX_LIMIT']"
		[Register ("CV_CAP_PROP_XI_AE_MAX_LIMIT")]
		public const int CvCapPropXiAeMaxLimit = (int) 417;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AG_MAX_LIMIT']"
		[Register ("CV_CAP_PROP_XI_AG_MAX_LIMIT")]
		public const int CvCapPropXiAgMaxLimit = (int) 418;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_APPLY_CMS']"
		[Register ("CV_CAP_PROP_XI_APPLY_CMS")]
		public const int CvCapPropXiApplyCms = (int) 471;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AUTO_BANDWIDTH_CALCULATION']"
		[Register ("CV_CAP_PROP_XI_AUTO_BANDWIDTH_CALCULATION")]
		public const int CvCapPropXiAutoBandwidthCalculation = (int) 573;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AUTO_WB']"
		[Register ("CV_CAP_PROP_XI_AUTO_WB")]
		public const int CvCapPropXiAutoWb = (int) 414;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_AVAILABLE_BANDWIDTH']"
		[Register ("CV_CAP_PROP_XI_AVAILABLE_BANDWIDTH")]
		public const int CvCapPropXiAvailableBandwidth = (int) 539;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_BINNING_HORIZONTAL']"
		[Register ("CV_CAP_PROP_XI_BINNING_HORIZONTAL")]
		public const int CvCapPropXiBinningHorizontal = (int) 429;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_BINNING_PATTERN']"
		[Register ("CV_CAP_PROP_XI_BINNING_PATTERN")]
		public const int CvCapPropXiBinningPattern = (int) 430;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_BINNING_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_BINNING_SELECTOR")]
		public const int CvCapPropXiBinningSelector = (int) 427;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_BINNING_VERTICAL']"
		[Register ("CV_CAP_PROP_XI_BINNING_VERTICAL")]
		public const int CvCapPropXiBinningVertical = (int) 428;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_BPC']"
		[Register ("CV_CAP_PROP_XI_BPC")]
		public const int CvCapPropXiBpc = (int) 445;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_BUFFERS_QUEUE_SIZE']"
		[Register ("CV_CAP_PROP_XI_BUFFERS_QUEUE_SIZE")]
		public const int CvCapPropXiBuffersQueueSize = (int) 551;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_BUFFER_POLICY']"
		[Register ("CV_CAP_PROP_XI_BUFFER_POLICY")]
		public const int CvCapPropXiBufferPolicy = (int) 540;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_00']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_00")]
		public const int CvCapPropXiCcMatrix00 = (int) 479;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_01']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_01")]
		public const int CvCapPropXiCcMatrix01 = (int) 480;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_02']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_02")]
		public const int CvCapPropXiCcMatrix02 = (int) 481;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_03']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_03")]
		public const int CvCapPropXiCcMatrix03 = (int) 482;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_10']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_10")]
		public const int CvCapPropXiCcMatrix10 = (int) 483;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_11']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_11")]
		public const int CvCapPropXiCcMatrix11 = (int) 484;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_12']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_12")]
		public const int CvCapPropXiCcMatrix12 = (int) 485;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_13']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_13")]
		public const int CvCapPropXiCcMatrix13 = (int) 486;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_20']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_20")]
		public const int CvCapPropXiCcMatrix20 = (int) 487;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_21']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_21")]
		public const int CvCapPropXiCcMatrix21 = (int) 488;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_22']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_22")]
		public const int CvCapPropXiCcMatrix22 = (int) 489;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_23']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_23")]
		public const int CvCapPropXiCcMatrix23 = (int) 490;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_30']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_30")]
		public const int CvCapPropXiCcMatrix30 = (int) 491;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_31']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_31")]
		public const int CvCapPropXiCcMatrix31 = (int) 492;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_32']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_32")]
		public const int CvCapPropXiCcMatrix32 = (int) 493;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CC_MATRIX_33']"
		[Register ("CV_CAP_PROP_XI_CC_MATRIX_33")]
		public const int CvCapPropXiCcMatrix33 = (int) 494;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CHIP_TEMP']"
		[Register ("CV_CAP_PROP_XI_CHIP_TEMP")]
		public const int CvCapPropXiChipTemp = (int) 468;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_CMS']"
		[Register ("CV_CAP_PROP_XI_CMS")]
		public const int CvCapPropXiCms = (int) 470;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_COLOR_FILTER_ARRAY']"
		[Register ("CV_CAP_PROP_XI_COLOR_FILTER_ARRAY")]
		public const int CvCapPropXiColorFilterArray = (int) 475;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_COLUMN_FPN_CORRECTION']"
		[Register ("CV_CAP_PROP_XI_COLUMN_FPN_CORRECTION")]
		public const int CvCapPropXiColumnFpnCorrection = (int) 555;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_COOLING']"
		[Register ("CV_CAP_PROP_XI_COOLING")]
		public const int CvCapPropXiCooling = (int) 466;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_COUNTER_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_COUNTER_SELECTOR")]
		public const int CvCapPropXiCounterSelector = (int) 536;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_COUNTER_VALUE']"
		[Register ("CV_CAP_PROP_XI_COUNTER_VALUE")]
		public const int CvCapPropXiCounterValue = (int) 537;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DATA_FORMAT']"
		[Register ("CV_CAP_PROP_XI_DATA_FORMAT")]
		public const int CvCapPropXiDataFormat = (int) 401;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DEBOUNCE_EN']"
		[Register ("CV_CAP_PROP_XI_DEBOUNCE_EN")]
		public const int CvCapPropXiDebounceEn = (int) 507;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DEBOUNCE_POL']"
		[Register ("CV_CAP_PROP_XI_DEBOUNCE_POL")]
		public const int CvCapPropXiDebouncePol = (int) 510;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DEBOUNCE_T0']"
		[Register ("CV_CAP_PROP_XI_DEBOUNCE_T0")]
		public const int CvCapPropXiDebounceT0 = (int) 508;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DEBOUNCE_T1']"
		[Register ("CV_CAP_PROP_XI_DEBOUNCE_T1")]
		public const int CvCapPropXiDebounceT1 = (int) 509;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DEBUG_LEVEL']"
		[Register ("CV_CAP_PROP_XI_DEBUG_LEVEL")]
		public const int CvCapPropXiDebugLevel = (int) 572;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DECIMATION_HORIZONTAL']"
		[Register ("CV_CAP_PROP_XI_DECIMATION_HORIZONTAL")]
		public const int CvCapPropXiDecimationHorizontal = (int) 433;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DECIMATION_PATTERN']"
		[Register ("CV_CAP_PROP_XI_DECIMATION_PATTERN")]
		public const int CvCapPropXiDecimationPattern = (int) 434;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DECIMATION_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_DECIMATION_SELECTOR")]
		public const int CvCapPropXiDecimationSelector = (int) 431;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DECIMATION_VERTICAL']"
		[Register ("CV_CAP_PROP_XI_DECIMATION_VERTICAL")]
		public const int CvCapPropXiDecimationVertical = (int) 432;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DEFAULT_CC_MATRIX']"
		[Register ("CV_CAP_PROP_XI_DEFAULT_CC_MATRIX")]
		public const int CvCapPropXiDefaultCcMatrix = (int) 495;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DEVICE_MODEL_ID']"
		[Register ("CV_CAP_PROP_XI_DEVICE_MODEL_ID")]
		public const int CvCapPropXiDeviceModelId = (int) 521;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DEVICE_RESET']"
		[Register ("CV_CAP_PROP_XI_DEVICE_RESET")]
		public const int CvCapPropXiDeviceReset = (int) 554;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DEVICE_SN']"
		[Register ("CV_CAP_PROP_XI_DEVICE_SN")]
		public const int CvCapPropXiDeviceSn = (int) 522;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DOWNSAMPLING']"
		[Register ("CV_CAP_PROP_XI_DOWNSAMPLING")]
		public const int CvCapPropXiDownsampling = (int) 400;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_DOWNSAMPLING_TYPE']"
		[Register ("CV_CAP_PROP_XI_DOWNSAMPLING_TYPE")]
		public const int CvCapPropXiDownsamplingType = (int) 426;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_EXPOSURE']"
		[Register ("CV_CAP_PROP_XI_EXPOSURE")]
		public const int CvCapPropXiExposure = (int) 421;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_EXPOSURE_BURST_COUNT']"
		[Register ("CV_CAP_PROP_XI_EXPOSURE_BURST_COUNT")]
		public const int CvCapPropXiExposureBurstCount = (int) 422;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_EXP_PRIORITY']"
		[Register ("CV_CAP_PROP_XI_EXP_PRIORITY")]
		public const int CvCapPropXiExpPriority = (int) 416;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_FFS_ACCESS_KEY']"
		[Register ("CV_CAP_PROP_XI_FFS_ACCESS_KEY")]
		public const int CvCapPropXiFfsAccessKey = (int) 583;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_FRAMERATE']"
		[Register ("CV_CAP_PROP_XI_FRAMERATE")]
		public const int CvCapPropXiFramerate = (int) 535;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_FREE_FFS_SIZE']"
		[Register ("CV_CAP_PROP_XI_FREE_FFS_SIZE")]
		public const int CvCapPropXiFreeFfsSize = (int) 581;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_GAIN']"
		[Register ("CV_CAP_PROP_XI_GAIN")]
		public const int CvCapPropXiGain = (int) 424;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_GAIN_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_GAIN_SELECTOR")]
		public const int CvCapPropXiGainSelector = (int) 423;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_GAMMAC']"
		[Register ("CV_CAP_PROP_XI_GAMMAC")]
		public const int CvCapPropXiGammac = (int) 477;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_GAMMAY']"
		[Register ("CV_CAP_PROP_XI_GAMMAY")]
		public const int CvCapPropXiGammay = (int) 476;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_GPI_LEVEL']"
		[Register ("CV_CAP_PROP_XI_GPI_LEVEL")]
		public const int CvCapPropXiGpiLevel = (int) 408;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_GPI_MODE']"
		[Register ("CV_CAP_PROP_XI_GPI_MODE")]
		public const int CvCapPropXiGpiMode = (int) 407;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_GPI_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_GPI_SELECTOR")]
		public const int CvCapPropXiGpiSelector = (int) 406;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_GPO_MODE']"
		[Register ("CV_CAP_PROP_XI_GPO_MODE")]
		public const int CvCapPropXiGpoMode = (int) 410;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_GPO_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_GPO_SELECTOR")]
		public const int CvCapPropXiGpoSelector = (int) 409;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_HDR']"
		[Register ("CV_CAP_PROP_XI_HDR")]
		public const int CvCapPropXiHdr = (int) 559;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_HDR_KNEEPOINT_COUNT']"
		[Register ("CV_CAP_PROP_XI_HDR_KNEEPOINT_COUNT")]
		public const int CvCapPropXiHdrKneepointCount = (int) 560;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_HDR_T1']"
		[Register ("CV_CAP_PROP_XI_HDR_T1")]
		public const int CvCapPropXiHdrT1 = (int) 561;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_HDR_T2']"
		[Register ("CV_CAP_PROP_XI_HDR_T2")]
		public const int CvCapPropXiHdrT2 = (int) 562;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_HEIGHT']"
		[Register ("CV_CAP_PROP_XI_HEIGHT")]
		public const int CvCapPropXiHeight = (int) 452;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_HOUS_TEMP']"
		[Register ("CV_CAP_PROP_XI_HOUS_TEMP")]
		public const int CvCapPropXiHousTemp = (int) 469;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_HW_REVISION']"
		[Register ("CV_CAP_PROP_XI_HW_REVISION")]
		public const int CvCapPropXiHwRevision = (int) 571;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_IMAGE_BLACK_LEVEL']"
		[Register ("CV_CAP_PROP_XI_IMAGE_BLACK_LEVEL")]
		public const int CvCapPropXiImageBlackLevel = (int) 565;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_IMAGE_DATA_BIT_DEPTH']"
		[Register ("CV_CAP_PROP_XI_IMAGE_DATA_BIT_DEPTH")]
		public const int CvCapPropXiImageDataBitDepth = (int) 462;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_IMAGE_DATA_FORMAT']"
		[Register ("CV_CAP_PROP_XI_IMAGE_DATA_FORMAT")]
		public const int CvCapPropXiImageDataFormat = (int) 435;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_IMAGE_DATA_FORMAT_RGB32_ALPHA']"
		[Register ("CV_CAP_PROP_XI_IMAGE_DATA_FORMAT_RGB32_ALPHA")]
		public const int CvCapPropXiImageDataFormatRgb32Alpha = (int) 529;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_IMAGE_IS_COLOR']"
		[Register ("CV_CAP_PROP_XI_IMAGE_IS_COLOR")]
		public const int CvCapPropXiImageIsColor = (int) 474;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_IMAGE_PAYLOAD_SIZE']"
		[Register ("CV_CAP_PROP_XI_IMAGE_PAYLOAD_SIZE")]
		public const int CvCapPropXiImagePayloadSize = (int) 530;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_IS_COOLED']"
		[Register ("CV_CAP_PROP_XI_IS_COOLED")]
		public const int CvCapPropXiIsCooled = (int) 465;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_IS_DEVICE_EXIST']"
		[Register ("CV_CAP_PROP_XI_IS_DEVICE_EXIST")]
		public const int CvCapPropXiIsDeviceExist = (int) 547;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_KNEEPOINT1']"
		[Register ("CV_CAP_PROP_XI_KNEEPOINT1")]
		public const int CvCapPropXiKneepoint1 = (int) 563;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_KNEEPOINT2']"
		[Register ("CV_CAP_PROP_XI_KNEEPOINT2")]
		public const int CvCapPropXiKneepoint2 = (int) 564;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LED_MODE']"
		[Register ("CV_CAP_PROP_XI_LED_MODE")]
		public const int CvCapPropXiLedMode = (int) 412;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LED_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_LED_SELECTOR")]
		public const int CvCapPropXiLedSelector = (int) 411;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LENS_APERTURE_VALUE']"
		[Register ("CV_CAP_PROP_XI_LENS_APERTURE_VALUE")]
		public const int CvCapPropXiLensApertureValue = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LENS_FEATURE']"
		[Register ("CV_CAP_PROP_XI_LENS_FEATURE")]
		public const int CvCapPropXiLensFeature = (int) 518;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LENS_FEATURE_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_LENS_FEATURE_SELECTOR")]
		public const int CvCapPropXiLensFeatureSelector = (int) 517;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LENS_FOCAL_LENGTH']"
		[Register ("CV_CAP_PROP_XI_LENS_FOCAL_LENGTH")]
		public const int CvCapPropXiLensFocalLength = (int) 516;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LENS_FOCUS_DISTANCE']"
		[Register ("CV_CAP_PROP_XI_LENS_FOCUS_DISTANCE")]
		public const int CvCapPropXiLensFocusDistance = (int) 515;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LENS_FOCUS_MOVE']"
		[Register ("CV_CAP_PROP_XI_LENS_FOCUS_MOVE")]
		public const int CvCapPropXiLensFocusMove = (int) 514;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LENS_FOCUS_MOVEMENT_VALUE']"
		[Register ("CV_CAP_PROP_XI_LENS_FOCUS_MOVEMENT_VALUE")]
		public const int CvCapPropXiLensFocusMovementValue = (int) 513;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LENS_MODE']"
		[Register ("CV_CAP_PROP_XI_LENS_MODE")]
		public const int CvCapPropXiLensMode = (int) 511;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LIMIT_BANDWIDTH']"
		[Register ("CV_CAP_PROP_XI_LIMIT_BANDWIDTH")]
		public const int CvCapPropXiLimitBandwidth = (int) 459;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LUT_EN']"
		[Register ("CV_CAP_PROP_XI_LUT_EN")]
		public const int CvCapPropXiLutEn = (int) 541;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LUT_INDEX']"
		[Register ("CV_CAP_PROP_XI_LUT_INDEX")]
		public const int CvCapPropXiLutIndex = (int) 542;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_LUT_VALUE']"
		[Register ("CV_CAP_PROP_XI_LUT_VALUE")]
		public const int CvCapPropXiLutValue = (int) 543;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_MANUAL_WB']"
		[Register ("CV_CAP_PROP_XI_MANUAL_WB")]
		public const int CvCapPropXiManualWb = (int) 413;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_OFFSET_X']"
		[Register ("CV_CAP_PROP_XI_OFFSET_X")]
		public const int CvCapPropXiOffsetX = (int) 402;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_OFFSET_Y']"
		[Register ("CV_CAP_PROP_XI_OFFSET_Y")]
		public const int CvCapPropXiOffsetY = (int) 403;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_OUTPUT_DATA_BIT_DEPTH']"
		[Register ("CV_CAP_PROP_XI_OUTPUT_DATA_BIT_DEPTH")]
		public const int CvCapPropXiOutputDataBitDepth = (int) 461;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_OUTPUT_DATA_PACKING']"
		[Register ("CV_CAP_PROP_XI_OUTPUT_DATA_PACKING")]
		public const int CvCapPropXiOutputDataPacking = (int) 463;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_OUTPUT_DATA_PACKING_TYPE']"
		[Register ("CV_CAP_PROP_XI_OUTPUT_DATA_PACKING_TYPE")]
		public const int CvCapPropXiOutputDataPackingType = (int) 464;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_RECENT_FRAME']"
		[Register ("CV_CAP_PROP_XI_RECENT_FRAME")]
		public const int CvCapPropXiRecentFrame = (int) 553;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SENSOR_CLOCK_FREQ_HZ']"
		[Register ("CV_CAP_PROP_XI_SENSOR_CLOCK_FREQ_HZ")]
		public const int CvCapPropXiSensorClockFreqHz = (int) 532;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SENSOR_CLOCK_FREQ_INDEX']"
		[Register ("CV_CAP_PROP_XI_SENSOR_CLOCK_FREQ_INDEX")]
		public const int CvCapPropXiSensorClockFreqIndex = (int) 533;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SENSOR_DATA_BIT_DEPTH']"
		[Register ("CV_CAP_PROP_XI_SENSOR_DATA_BIT_DEPTH")]
		public const int CvCapPropXiSensorDataBitDepth = (int) 460;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SENSOR_FEATURE_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_SENSOR_FEATURE_SELECTOR")]
		public const int CvCapPropXiSensorFeatureSelector = (int) 585;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SENSOR_FEATURE_VALUE']"
		[Register ("CV_CAP_PROP_XI_SENSOR_FEATURE_VALUE")]
		public const int CvCapPropXiSensorFeatureValue = (int) 586;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SENSOR_MODE']"
		[Register ("CV_CAP_PROP_XI_SENSOR_MODE")]
		public const int CvCapPropXiSensorMode = (int) 558;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SENSOR_OUTPUT_CHANNEL_COUNT']"
		[Register ("CV_CAP_PROP_XI_SENSOR_OUTPUT_CHANNEL_COUNT")]
		public const int CvCapPropXiSensorOutputChannelCount = (int) 534;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SENSOR_TAPS']"
		[Register ("CV_CAP_PROP_XI_SENSOR_TAPS")]
		public const int CvCapPropXiSensorTaps = (int) 437;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SHARPNESS']"
		[Register ("CV_CAP_PROP_XI_SHARPNESS")]
		public const int CvCapPropXiSharpness = (int) 478;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_SHUTTER_TYPE']"
		[Register ("CV_CAP_PROP_XI_SHUTTER_TYPE")]
		public const int CvCapPropXiShutterType = (int) 436;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_TARGET_TEMP']"
		[Register ("CV_CAP_PROP_XI_TARGET_TEMP")]
		public const int CvCapPropXiTargetTemp = (int) 467;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_TIMEOUT']"
		[Register ("CV_CAP_PROP_XI_TIMEOUT")]
		public const int CvCapPropXiTimeout = (int) 420;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_TRANSPORT_PIXEL_FORMAT']"
		[Register ("CV_CAP_PROP_XI_TRANSPORT_PIXEL_FORMAT")]
		public const int CvCapPropXiTransportPixelFormat = (int) 531;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_TRG_DELAY']"
		[Register ("CV_CAP_PROP_XI_TRG_DELAY")]
		public const int CvCapPropXiTrgDelay = (int) 544;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_TRG_SELECTOR']"
		[Register ("CV_CAP_PROP_XI_TRG_SELECTOR")]
		public const int CvCapPropXiTrgSelector = (int) 498;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_TRG_SOFTWARE']"
		[Register ("CV_CAP_PROP_XI_TRG_SOFTWARE")]
		public const int CvCapPropXiTrgSoftware = (int) 405;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_TRG_SOURCE']"
		[Register ("CV_CAP_PROP_XI_TRG_SOURCE")]
		public const int CvCapPropXiTrgSource = (int) 404;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_TS_RST_MODE']"
		[Register ("CV_CAP_PROP_XI_TS_RST_MODE")]
		public const int CvCapPropXiTsRstMode = (int) 545;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_TS_RST_SOURCE']"
		[Register ("CV_CAP_PROP_XI_TS_RST_SOURCE")]
		public const int CvCapPropXiTsRstSource = (int) 546;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_USED_FFS_SIZE']"
		[Register ("CV_CAP_PROP_XI_USED_FFS_SIZE")]
		public const int CvCapPropXiUsedFfsSize = (int) 582;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_WB_KB']"
		[Register ("CV_CAP_PROP_XI_WB_KB")]
		public const int CvCapPropXiWbKb = (int) 450;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_WB_KG']"
		[Register ("CV_CAP_PROP_XI_WB_KG")]
		public const int CvCapPropXiWbKg = (int) 449;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_WB_KR']"
		[Register ("CV_CAP_PROP_XI_WB_KR")]
		public const int CvCapPropXiWbKr = (int) 448;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_XI_WIDTH']"
		[Register ("CV_CAP_PROP_XI_WIDTH")]
		public const int CvCapPropXiWidth = (int) 451;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_PROP_ZOOM']"
		[Register ("CV_CAP_PROP_ZOOM")]
		public const int CvCapPropZoom = (int) 27;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='CV_CAP_XIAPI']"
		[Register ("CV_CAP_XIAPI")]
		public const int CvCapXiapi = (int) 1100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='VIDEOWRITER_PROP_FRAMEBYTES']"
		[Register ("VIDEOWRITER_PROP_FRAMEBYTES")]
		public const int VideowriterPropFramebytes = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='VIDEOWRITER_PROP_NSTRIPES']"
		[Register ("VIDEOWRITER_PROP_NSTRIPES")]
		public const int VideowriterPropNstripes = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/field[@name='VIDEOWRITER_PROP_QUALITY']"
		[Register ("VIDEOWRITER_PROP_QUALITY")]
		public const int VideowriterPropQuality = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/videoio/Videoio", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Videoio); }
		}

		protected Videoio (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='Videoio']/constructor[@name='Videoio' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Videoio ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Videoio)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
