using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ImgProc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']"
	[global::Android.Runtime.Register ("org/opencv/imgproc/Imgproc", DoNotGenerateAcw=true)]
	public partial class Imgproc : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='ADAPTIVE_THRESH_GAUSSIAN_C']"
		[Register ("ADAPTIVE_THRESH_GAUSSIAN_C")]
		public const int AdaptiveThreshGaussianC = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='ADAPTIVE_THRESH_MEAN_C']"
		[Register ("ADAPTIVE_THRESH_MEAN_C")]
		public const int AdaptiveThreshMeanC = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CC_STAT_AREA']"
		[Register ("CC_STAT_AREA")]
		public const int CcStatArea = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CC_STAT_HEIGHT']"
		[Register ("CC_STAT_HEIGHT")]
		public const int CcStatHeight = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CC_STAT_LEFT']"
		[Register ("CC_STAT_LEFT")]
		public const int CcStatLeft = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CC_STAT_MAX']"
		[Register ("CC_STAT_MAX")]
		public const int CcStatMax = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CC_STAT_TOP']"
		[Register ("CC_STAT_TOP")]
		public const int CcStatTop = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CC_STAT_WIDTH']"
		[Register ("CC_STAT_WIDTH")]
		public const int CcStatWidth = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CHAIN_APPROX_NONE']"
		[Register ("CHAIN_APPROX_NONE")]
		public const int ChainApproxNone = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CHAIN_APPROX_SIMPLE']"
		[Register ("CHAIN_APPROX_SIMPLE")]
		public const int ChainApproxSimple = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CHAIN_APPROX_TC89_KCOS']"
		[Register ("CHAIN_APPROX_TC89_KCOS")]
		public const int ChainApproxTc89Kcos = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CHAIN_APPROX_TC89_L1']"
		[Register ("CHAIN_APPROX_TC89_L1")]
		public const int ChainApproxTc89L1 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_AUTUMN']"
		[Register ("COLORMAP_AUTUMN")]
		public const int ColormapAutumn = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_BONE']"
		[Register ("COLORMAP_BONE")]
		public const int ColormapBone = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_COOL']"
		[Register ("COLORMAP_COOL")]
		public const int ColormapCool = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_HOT']"
		[Register ("COLORMAP_HOT")]
		public const int ColormapHot = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_HSV']"
		[Register ("COLORMAP_HSV")]
		public const int ColormapHsv = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_JET']"
		[Register ("COLORMAP_JET")]
		public const int ColormapJet = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_OCEAN']"
		[Register ("COLORMAP_OCEAN")]
		public const int ColormapOcean = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_PARULA']"
		[Register ("COLORMAP_PARULA")]
		public const int ColormapParula = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_PINK']"
		[Register ("COLORMAP_PINK")]
		public const int ColormapPink = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_RAINBOW']"
		[Register ("COLORMAP_RAINBOW")]
		public const int ColormapRainbow = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_SPRING']"
		[Register ("COLORMAP_SPRING")]
		public const int ColormapSpring = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_SUMMER']"
		[Register ("COLORMAP_SUMMER")]
		public const int ColormapSummer = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLORMAP_WINTER']"
		[Register ("COLORMAP_WINTER")]
		public const int ColormapWinter = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2BGR555']"
		[Register ("COLOR_BGR2BGR555")]
		public const int ColorBgr2bgr555 = (int) 22;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2BGR565']"
		[Register ("COLOR_BGR2BGR565")]
		public const int ColorBgr2bgr565 = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2BGRA']"
		[Register ("COLOR_BGR2BGRA")]
		public const int ColorBgr2bgra = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2GRAY']"
		[Register ("COLOR_BGR2GRAY")]
		public const int ColorBgr2gray = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2HLS']"
		[Register ("COLOR_BGR2HLS")]
		public const int ColorBgr2hls = (int) 52;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2HLS_FULL']"
		[Register ("COLOR_BGR2HLS_FULL")]
		public const int ColorBgr2hlsFull = (int) 68;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2HSV']"
		[Register ("COLOR_BGR2HSV")]
		public const int ColorBgr2hsv = (int) 40;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2HSV_FULL']"
		[Register ("COLOR_BGR2HSV_FULL")]
		public const int ColorBgr2hsvFull = (int) 66;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2Lab']"
		[Register ("COLOR_BGR2Lab")]
		public const int COLORBGR2Lab = (int) 44;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2Luv']"
		[Register ("COLOR_BGR2Luv")]
		public const int COLORBGR2Luv = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2RGB']"
		[Register ("COLOR_BGR2RGB")]
		public const int ColorBgr2rgb = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2RGBA']"
		[Register ("COLOR_BGR2RGBA")]
		public const int ColorBgr2rgba = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2XYZ']"
		[Register ("COLOR_BGR2XYZ")]
		public const int ColorBgr2xyz = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2YCrCb']"
		[Register ("COLOR_BGR2YCrCb")]
		public const int COLORBGR2YCrCb = (int) 36;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2YUV']"
		[Register ("COLOR_BGR2YUV")]
		public const int ColorBgr2yuv = (int) 82;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2YUV_I420']"
		[Register ("COLOR_BGR2YUV_I420")]
		public const int ColorBgr2yuvI420 = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2YUV_IYUV']"
		[Register ("COLOR_BGR2YUV_IYUV")]
		public const int ColorBgr2yuvIyuv = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR2YUV_YV12']"
		[Register ("COLOR_BGR2YUV_YV12")]
		public const int ColorBgr2yuvYv12 = (int) 132;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5552BGR']"
		[Register ("COLOR_BGR5552BGR")]
		public const int ColorBgr5552bgr = (int) 24;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5552BGRA']"
		[Register ("COLOR_BGR5552BGRA")]
		public const int ColorBgr5552bgra = (int) 28;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5552GRAY']"
		[Register ("COLOR_BGR5552GRAY")]
		public const int ColorBgr5552gray = (int) 31;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5552RGB']"
		[Register ("COLOR_BGR5552RGB")]
		public const int ColorBgr5552rgb = (int) 25;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5552RGBA']"
		[Register ("COLOR_BGR5552RGBA")]
		public const int ColorBgr5552rgba = (int) 29;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5652BGR']"
		[Register ("COLOR_BGR5652BGR")]
		public const int ColorBgr5652bgr = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5652BGRA']"
		[Register ("COLOR_BGR5652BGRA")]
		public const int ColorBgr5652bgra = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5652GRAY']"
		[Register ("COLOR_BGR5652GRAY")]
		public const int ColorBgr5652gray = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5652RGB']"
		[Register ("COLOR_BGR5652RGB")]
		public const int ColorBgr5652rgb = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGR5652RGBA']"
		[Register ("COLOR_BGR5652RGBA")]
		public const int ColorBgr5652rgba = (int) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGRA2BGR']"
		[Register ("COLOR_BGRA2BGR")]
		public const int ColorBgra2bgr = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGRA2BGR555']"
		[Register ("COLOR_BGRA2BGR555")]
		public const int ColorBgra2bgr555 = (int) 26;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGRA2BGR565']"
		[Register ("COLOR_BGRA2BGR565")]
		public const int ColorBgra2bgr565 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGRA2GRAY']"
		[Register ("COLOR_BGRA2GRAY")]
		public const int ColorBgra2gray = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGRA2RGB']"
		[Register ("COLOR_BGRA2RGB")]
		public const int ColorBgra2rgb = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGRA2RGBA']"
		[Register ("COLOR_BGRA2RGBA")]
		public const int ColorBgra2rgba = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGRA2YUV_I420']"
		[Register ("COLOR_BGRA2YUV_I420")]
		public const int ColorBgra2yuvI420 = (int) 130;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGRA2YUV_IYUV']"
		[Register ("COLOR_BGRA2YUV_IYUV")]
		public const int ColorBgra2yuvIyuv = (int) 130;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BGRA2YUV_YV12']"
		[Register ("COLOR_BGRA2YUV_YV12")]
		public const int ColorBgra2yuvYv12 = (int) 134;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerBG2BGR']"
		[Register ("COLOR_BayerBG2BGR")]
		public const int COLORBayerBG2BGR = (int) 46;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerBG2BGR_EA']"
		[Register ("COLOR_BayerBG2BGR_EA")]
		public const int COLORBayerBG2BGREA = (int) 135;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerBG2BGR_VNG']"
		[Register ("COLOR_BayerBG2BGR_VNG")]
		public const int COLORBayerBG2BGRVNG = (int) 62;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerBG2GRAY']"
		[Register ("COLOR_BayerBG2GRAY")]
		public const int COLORBayerBG2GRAY = (int) 86;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerBG2RGB']"
		[Register ("COLOR_BayerBG2RGB")]
		public const int COLORBayerBG2RGB = (int) 48;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerBG2RGB_EA']"
		[Register ("COLOR_BayerBG2RGB_EA")]
		public const int COLORBayerBG2RGBEA = (int) 137;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerBG2RGB_VNG']"
		[Register ("COLOR_BayerBG2RGB_VNG")]
		public const int COLORBayerBG2RGBVNG = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGB2BGR']"
		[Register ("COLOR_BayerGB2BGR")]
		public const int COLORBayerGB2BGR = (int) 47;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGB2BGR_EA']"
		[Register ("COLOR_BayerGB2BGR_EA")]
		public const int COLORBayerGB2BGREA = (int) 136;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGB2BGR_VNG']"
		[Register ("COLOR_BayerGB2BGR_VNG")]
		public const int COLORBayerGB2BGRVNG = (int) 63;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGB2GRAY']"
		[Register ("COLOR_BayerGB2GRAY")]
		public const int COLORBayerGB2GRAY = (int) 87;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGB2RGB']"
		[Register ("COLOR_BayerGB2RGB")]
		public const int COLORBayerGB2RGB = (int) 49;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGB2RGB_EA']"
		[Register ("COLOR_BayerGB2RGB_EA")]
		public const int COLORBayerGB2RGBEA = (int) 138;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGB2RGB_VNG']"
		[Register ("COLOR_BayerGB2RGB_VNG")]
		public const int COLORBayerGB2RGBVNG = (int) 65;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGR2BGR']"
		[Register ("COLOR_BayerGR2BGR")]
		public const int COLORBayerGR2BGR = (int) 49;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGR2BGR_EA']"
		[Register ("COLOR_BayerGR2BGR_EA")]
		public const int COLORBayerGR2BGREA = (int) 138;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGR2BGR_VNG']"
		[Register ("COLOR_BayerGR2BGR_VNG")]
		public const int COLORBayerGR2BGRVNG = (int) 65;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGR2GRAY']"
		[Register ("COLOR_BayerGR2GRAY")]
		public const int COLORBayerGR2GRAY = (int) 89;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGR2RGB']"
		[Register ("COLOR_BayerGR2RGB")]
		public const int COLORBayerGR2RGB = (int) 47;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGR2RGB_EA']"
		[Register ("COLOR_BayerGR2RGB_EA")]
		public const int COLORBayerGR2RGBEA = (int) 136;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerGR2RGB_VNG']"
		[Register ("COLOR_BayerGR2RGB_VNG")]
		public const int COLORBayerGR2RGBVNG = (int) 63;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerRG2BGR']"
		[Register ("COLOR_BayerRG2BGR")]
		public const int COLORBayerRG2BGR = (int) 48;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerRG2BGR_EA']"
		[Register ("COLOR_BayerRG2BGR_EA")]
		public const int COLORBayerRG2BGREA = (int) 137;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerRG2BGR_VNG']"
		[Register ("COLOR_BayerRG2BGR_VNG")]
		public const int COLORBayerRG2BGRVNG = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerRG2GRAY']"
		[Register ("COLOR_BayerRG2GRAY")]
		public const int COLORBayerRG2GRAY = (int) 88;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerRG2RGB']"
		[Register ("COLOR_BayerRG2RGB")]
		public const int COLORBayerRG2RGB = (int) 46;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerRG2RGB_EA']"
		[Register ("COLOR_BayerRG2RGB_EA")]
		public const int COLORBayerRG2RGBEA = (int) 135;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_BayerRG2RGB_VNG']"
		[Register ("COLOR_BayerRG2RGB_VNG")]
		public const int COLORBayerRG2RGBVNG = (int) 62;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_COLORCVT_MAX']"
		[Register ("COLOR_COLORCVT_MAX")]
		public const int ColorColorcvtMax = (int) 139;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_GRAY2BGR']"
		[Register ("COLOR_GRAY2BGR")]
		public const int ColorGray2bgr = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_GRAY2BGR555']"
		[Register ("COLOR_GRAY2BGR555")]
		public const int ColorGray2bgr555 = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_GRAY2BGR565']"
		[Register ("COLOR_GRAY2BGR565")]
		public const int ColorGray2bgr565 = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_GRAY2BGRA']"
		[Register ("COLOR_GRAY2BGRA")]
		public const int ColorGray2bgra = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_GRAY2RGB']"
		[Register ("COLOR_GRAY2RGB")]
		public const int ColorGray2rgb = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_GRAY2RGBA']"
		[Register ("COLOR_GRAY2RGBA")]
		public const int ColorGray2rgba = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_HLS2BGR']"
		[Register ("COLOR_HLS2BGR")]
		public const int ColorHls2bgr = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_HLS2BGR_FULL']"
		[Register ("COLOR_HLS2BGR_FULL")]
		public const int ColorHls2bgrFull = (int) 72;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_HLS2RGB']"
		[Register ("COLOR_HLS2RGB")]
		public const int ColorHls2rgb = (int) 61;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_HLS2RGB_FULL']"
		[Register ("COLOR_HLS2RGB_FULL")]
		public const int ColorHls2rgbFull = (int) 73;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_HSV2BGR']"
		[Register ("COLOR_HSV2BGR")]
		public const int ColorHsv2bgr = (int) 54;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_HSV2BGR_FULL']"
		[Register ("COLOR_HSV2BGR_FULL")]
		public const int ColorHsv2bgrFull = (int) 70;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_HSV2RGB']"
		[Register ("COLOR_HSV2RGB")]
		public const int ColorHsv2rgb = (int) 55;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_HSV2RGB_FULL']"
		[Register ("COLOR_HSV2RGB_FULL")]
		public const int ColorHsv2rgbFull = (int) 71;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_LBGR2Lab']"
		[Register ("COLOR_LBGR2Lab")]
		public const int COLORLBGR2Lab = (int) 74;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_LBGR2Luv']"
		[Register ("COLOR_LBGR2Luv")]
		public const int COLORLBGR2Luv = (int) 76;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_LRGB2Lab']"
		[Register ("COLOR_LRGB2Lab")]
		public const int COLORLRGB2Lab = (int) 75;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_LRGB2Luv']"
		[Register ("COLOR_LRGB2Luv")]
		public const int COLORLRGB2Luv = (int) 77;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_Lab2BGR']"
		[Register ("COLOR_Lab2BGR")]
		public const int COLORLab2BGR = (int) 56;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_Lab2LBGR']"
		[Register ("COLOR_Lab2LBGR")]
		public const int COLORLab2LBGR = (int) 78;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_Lab2LRGB']"
		[Register ("COLOR_Lab2LRGB")]
		public const int COLORLab2LRGB = (int) 79;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_Lab2RGB']"
		[Register ("COLOR_Lab2RGB")]
		public const int COLORLab2RGB = (int) 57;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_Luv2BGR']"
		[Register ("COLOR_Luv2BGR")]
		public const int COLORLuv2BGR = (int) 58;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_Luv2LBGR']"
		[Register ("COLOR_Luv2LBGR")]
		public const int COLORLuv2LBGR = (int) 80;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_Luv2LRGB']"
		[Register ("COLOR_Luv2LRGB")]
		public const int COLORLuv2LRGB = (int) 81;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_Luv2RGB']"
		[Register ("COLOR_Luv2RGB")]
		public const int COLORLuv2RGB = (int) 59;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2BGR']"
		[Register ("COLOR_RGB2BGR")]
		public const int ColorRgb2bgr = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2BGR555']"
		[Register ("COLOR_RGB2BGR555")]
		public const int ColorRgb2bgr555 = (int) 23;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2BGR565']"
		[Register ("COLOR_RGB2BGR565")]
		public const int ColorRgb2bgr565 = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2BGRA']"
		[Register ("COLOR_RGB2BGRA")]
		public const int ColorRgb2bgra = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2GRAY']"
		[Register ("COLOR_RGB2GRAY")]
		public const int ColorRgb2gray = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2HLS']"
		[Register ("COLOR_RGB2HLS")]
		public const int ColorRgb2hls = (int) 53;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2HLS_FULL']"
		[Register ("COLOR_RGB2HLS_FULL")]
		public const int ColorRgb2hlsFull = (int) 69;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2HSV']"
		[Register ("COLOR_RGB2HSV")]
		public const int ColorRgb2hsv = (int) 41;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2HSV_FULL']"
		[Register ("COLOR_RGB2HSV_FULL")]
		public const int ColorRgb2hsvFull = (int) 67;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2Lab']"
		[Register ("COLOR_RGB2Lab")]
		public const int COLORRGB2Lab = (int) 45;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2Luv']"
		[Register ("COLOR_RGB2Luv")]
		public const int COLORRGB2Luv = (int) 51;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2RGBA']"
		[Register ("COLOR_RGB2RGBA")]
		public const int ColorRgb2rgba = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2XYZ']"
		[Register ("COLOR_RGB2XYZ")]
		public const int ColorRgb2xyz = (int) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2YCrCb']"
		[Register ("COLOR_RGB2YCrCb")]
		public const int COLORRGB2YCrCb = (int) 37;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2YUV']"
		[Register ("COLOR_RGB2YUV")]
		public const int ColorRgb2yuv = (int) 83;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2YUV_I420']"
		[Register ("COLOR_RGB2YUV_I420")]
		public const int ColorRgb2yuvI420 = (int) 127;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2YUV_IYUV']"
		[Register ("COLOR_RGB2YUV_IYUV")]
		public const int ColorRgb2yuvIyuv = (int) 127;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGB2YUV_YV12']"
		[Register ("COLOR_RGB2YUV_YV12")]
		public const int ColorRgb2yuvYv12 = (int) 131;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2BGR']"
		[Register ("COLOR_RGBA2BGR")]
		public const int ColorRgba2bgr = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2BGR555']"
		[Register ("COLOR_RGBA2BGR555")]
		public const int ColorRgba2bgr555 = (int) 27;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2BGR565']"
		[Register ("COLOR_RGBA2BGR565")]
		public const int ColorRgba2bgr565 = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2BGRA']"
		[Register ("COLOR_RGBA2BGRA")]
		public const int ColorRgba2bgra = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2GRAY']"
		[Register ("COLOR_RGBA2GRAY")]
		public const int ColorRgba2gray = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2RGB']"
		[Register ("COLOR_RGBA2RGB")]
		public const int ColorRgba2rgb = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2YUV_I420']"
		[Register ("COLOR_RGBA2YUV_I420")]
		public const int ColorRgba2yuvI420 = (int) 129;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2YUV_IYUV']"
		[Register ("COLOR_RGBA2YUV_IYUV")]
		public const int ColorRgba2yuvIyuv = (int) 129;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2YUV_YV12']"
		[Register ("COLOR_RGBA2YUV_YV12")]
		public const int ColorRgba2yuvYv12 = (int) 133;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_RGBA2mRGBA']"
		[Register ("COLOR_RGBA2mRGBA")]
		public const int COLORRGBA2mRGBA = (int) 125;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_XYZ2BGR']"
		[Register ("COLOR_XYZ2BGR")]
		public const int ColorXyz2bgr = (int) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_XYZ2RGB']"
		[Register ("COLOR_XYZ2RGB")]
		public const int ColorXyz2rgb = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YCrCb2BGR']"
		[Register ("COLOR_YCrCb2BGR")]
		public const int COLORYCrCb2BGR = (int) 38;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YCrCb2RGB']"
		[Register ("COLOR_YCrCb2RGB")]
		public const int COLORYCrCb2RGB = (int) 39;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR']"
		[Register ("COLOR_YUV2BGR")]
		public const int ColorYuv2bgr = (int) 84;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_I420']"
		[Register ("COLOR_YUV2BGRA_I420")]
		public const int ColorYuv2bgraI420 = (int) 105;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_IYUV']"
		[Register ("COLOR_YUV2BGRA_IYUV")]
		public const int ColorYuv2bgraIyuv = (int) 105;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_NV12']"
		[Register ("COLOR_YUV2BGRA_NV12")]
		public const int ColorYuv2bgraNv12 = (int) 95;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_NV21']"
		[Register ("COLOR_YUV2BGRA_NV21")]
		public const int ColorYuv2bgraNv21 = (int) 97;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_UYNV']"
		[Register ("COLOR_YUV2BGRA_UYNV")]
		public const int ColorYuv2bgraUynv = (int) 112;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_UYVY']"
		[Register ("COLOR_YUV2BGRA_UYVY")]
		public const int ColorYuv2bgraUyvy = (int) 112;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_Y422']"
		[Register ("COLOR_YUV2BGRA_Y422")]
		public const int ColorYuv2bgraY422 = (int) 112;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_YUNV']"
		[Register ("COLOR_YUV2BGRA_YUNV")]
		public const int ColorYuv2bgraYunv = (int) 120;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_YUY2']"
		[Register ("COLOR_YUV2BGRA_YUY2")]
		public const int ColorYuv2bgraYuy2 = (int) 120;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_YUYV']"
		[Register ("COLOR_YUV2BGRA_YUYV")]
		public const int ColorYuv2bgraYuyv = (int) 120;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_YV12']"
		[Register ("COLOR_YUV2BGRA_YV12")]
		public const int ColorYuv2bgraYv12 = (int) 103;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGRA_YVYU']"
		[Register ("COLOR_YUV2BGRA_YVYU")]
		public const int ColorYuv2bgraYvyu = (int) 122;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_I420']"
		[Register ("COLOR_YUV2BGR_I420")]
		public const int ColorYuv2bgrI420 = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_IYUV']"
		[Register ("COLOR_YUV2BGR_IYUV")]
		public const int ColorYuv2bgrIyuv = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_NV12']"
		[Register ("COLOR_YUV2BGR_NV12")]
		public const int ColorYuv2bgrNv12 = (int) 91;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_NV21']"
		[Register ("COLOR_YUV2BGR_NV21")]
		public const int ColorYuv2bgrNv21 = (int) 93;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_UYNV']"
		[Register ("COLOR_YUV2BGR_UYNV")]
		public const int ColorYuv2bgrUynv = (int) 108;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_UYVY']"
		[Register ("COLOR_YUV2BGR_UYVY")]
		public const int ColorYuv2bgrUyvy = (int) 108;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_Y422']"
		[Register ("COLOR_YUV2BGR_Y422")]
		public const int ColorYuv2bgrY422 = (int) 108;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_YUNV']"
		[Register ("COLOR_YUV2BGR_YUNV")]
		public const int ColorYuv2bgrYunv = (int) 116;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_YUY2']"
		[Register ("COLOR_YUV2BGR_YUY2")]
		public const int ColorYuv2bgrYuy2 = (int) 116;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_YUYV']"
		[Register ("COLOR_YUV2BGR_YUYV")]
		public const int ColorYuv2bgrYuyv = (int) 116;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_YV12']"
		[Register ("COLOR_YUV2BGR_YV12")]
		public const int ColorYuv2bgrYv12 = (int) 99;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2BGR_YVYU']"
		[Register ("COLOR_YUV2BGR_YVYU")]
		public const int ColorYuv2bgrYvyu = (int) 118;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_420']"
		[Register ("COLOR_YUV2GRAY_420")]
		public const int ColorYuv2gray420 = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_I420']"
		[Register ("COLOR_YUV2GRAY_I420")]
		public const int ColorYuv2grayI420 = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_IYUV']"
		[Register ("COLOR_YUV2GRAY_IYUV")]
		public const int ColorYuv2grayIyuv = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_NV12']"
		[Register ("COLOR_YUV2GRAY_NV12")]
		public const int ColorYuv2grayNv12 = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_NV21']"
		[Register ("COLOR_YUV2GRAY_NV21")]
		public const int ColorYuv2grayNv21 = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_UYNV']"
		[Register ("COLOR_YUV2GRAY_UYNV")]
		public const int ColorYuv2grayUynv = (int) 123;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_UYVY']"
		[Register ("COLOR_YUV2GRAY_UYVY")]
		public const int ColorYuv2grayUyvy = (int) 123;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_Y422']"
		[Register ("COLOR_YUV2GRAY_Y422")]
		public const int ColorYuv2grayY422 = (int) 123;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_YUNV']"
		[Register ("COLOR_YUV2GRAY_YUNV")]
		public const int ColorYuv2grayYunv = (int) 124;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_YUY2']"
		[Register ("COLOR_YUV2GRAY_YUY2")]
		public const int ColorYuv2grayYuy2 = (int) 124;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_YUYV']"
		[Register ("COLOR_YUV2GRAY_YUYV")]
		public const int ColorYuv2grayYuyv = (int) 124;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_YV12']"
		[Register ("COLOR_YUV2GRAY_YV12")]
		public const int ColorYuv2grayYv12 = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2GRAY_YVYU']"
		[Register ("COLOR_YUV2GRAY_YVYU")]
		public const int ColorYuv2grayYvyu = (int) 124;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB']"
		[Register ("COLOR_YUV2RGB")]
		public const int ColorYuv2rgb = (int) 85;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_I420']"
		[Register ("COLOR_YUV2RGBA_I420")]
		public const int ColorYuv2rgbaI420 = (int) 104;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_IYUV']"
		[Register ("COLOR_YUV2RGBA_IYUV")]
		public const int ColorYuv2rgbaIyuv = (int) 104;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_NV12']"
		[Register ("COLOR_YUV2RGBA_NV12")]
		public const int ColorYuv2rgbaNv12 = (int) 94;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_NV21']"
		[Register ("COLOR_YUV2RGBA_NV21")]
		public const int ColorYuv2rgbaNv21 = (int) 96;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_UYNV']"
		[Register ("COLOR_YUV2RGBA_UYNV")]
		public const int ColorYuv2rgbaUynv = (int) 111;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_UYVY']"
		[Register ("COLOR_YUV2RGBA_UYVY")]
		public const int ColorYuv2rgbaUyvy = (int) 111;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_Y422']"
		[Register ("COLOR_YUV2RGBA_Y422")]
		public const int ColorYuv2rgbaY422 = (int) 111;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_YUNV']"
		[Register ("COLOR_YUV2RGBA_YUNV")]
		public const int ColorYuv2rgbaYunv = (int) 119;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_YUY2']"
		[Register ("COLOR_YUV2RGBA_YUY2")]
		public const int ColorYuv2rgbaYuy2 = (int) 119;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_YUYV']"
		[Register ("COLOR_YUV2RGBA_YUYV")]
		public const int ColorYuv2rgbaYuyv = (int) 119;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_YV12']"
		[Register ("COLOR_YUV2RGBA_YV12")]
		public const int ColorYuv2rgbaYv12 = (int) 102;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGBA_YVYU']"
		[Register ("COLOR_YUV2RGBA_YVYU")]
		public const int ColorYuv2rgbaYvyu = (int) 121;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_I420']"
		[Register ("COLOR_YUV2RGB_I420")]
		public const int ColorYuv2rgbI420 = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_IYUV']"
		[Register ("COLOR_YUV2RGB_IYUV")]
		public const int ColorYuv2rgbIyuv = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_NV12']"
		[Register ("COLOR_YUV2RGB_NV12")]
		public const int ColorYuv2rgbNv12 = (int) 90;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_NV21']"
		[Register ("COLOR_YUV2RGB_NV21")]
		public const int ColorYuv2rgbNv21 = (int) 92;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_UYNV']"
		[Register ("COLOR_YUV2RGB_UYNV")]
		public const int ColorYuv2rgbUynv = (int) 107;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_UYVY']"
		[Register ("COLOR_YUV2RGB_UYVY")]
		public const int ColorYuv2rgbUyvy = (int) 107;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_Y422']"
		[Register ("COLOR_YUV2RGB_Y422")]
		public const int ColorYuv2rgbY422 = (int) 107;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_YUNV']"
		[Register ("COLOR_YUV2RGB_YUNV")]
		public const int ColorYuv2rgbYunv = (int) 115;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_YUY2']"
		[Register ("COLOR_YUV2RGB_YUY2")]
		public const int ColorYuv2rgbYuy2 = (int) 115;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_YUYV']"
		[Register ("COLOR_YUV2RGB_YUYV")]
		public const int ColorYuv2rgbYuyv = (int) 115;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_YV12']"
		[Register ("COLOR_YUV2RGB_YV12")]
		public const int ColorYuv2rgbYv12 = (int) 98;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV2RGB_YVYU']"
		[Register ("COLOR_YUV2RGB_YVYU")]
		public const int ColorYuv2rgbYvyu = (int) 117;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420p2BGR']"
		[Register ("COLOR_YUV420p2BGR")]
		public const int COLORYUV420p2BGR = (int) 99;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420p2BGRA']"
		[Register ("COLOR_YUV420p2BGRA")]
		public const int COLORYUV420p2BGRA = (int) 103;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420p2GRAY']"
		[Register ("COLOR_YUV420p2GRAY")]
		public const int COLORYUV420p2GRAY = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420p2RGB']"
		[Register ("COLOR_YUV420p2RGB")]
		public const int COLORYUV420p2RGB = (int) 98;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420p2RGBA']"
		[Register ("COLOR_YUV420p2RGBA")]
		public const int COLORYUV420p2RGBA = (int) 102;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420sp2BGR']"
		[Register ("COLOR_YUV420sp2BGR")]
		public const int COLORYUV420sp2BGR = (int) 93;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420sp2BGRA']"
		[Register ("COLOR_YUV420sp2BGRA")]
		public const int COLORYUV420sp2BGRA = (int) 97;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420sp2GRAY']"
		[Register ("COLOR_YUV420sp2GRAY")]
		public const int COLORYUV420sp2GRAY = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420sp2RGB']"
		[Register ("COLOR_YUV420sp2RGB")]
		public const int COLORYUV420sp2RGB = (int) 92;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_YUV420sp2RGBA']"
		[Register ("COLOR_YUV420sp2RGBA")]
		public const int COLORYUV420sp2RGBA = (int) 96;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='COLOR_mRGBA2RGBA']"
		[Register ("COLOR_mRGBA2RGBA")]
		public const int COLORMRGBA2RGBA = (int) 126;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_BILATERAL']"
		[Register ("CV_BILATERAL")]
		public const int CvBilateral = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_BLUR']"
		[Register ("CV_BLUR")]
		public const int CvBlur = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_BLUR_NO_SCALE']"
		[Register ("CV_BLUR_NO_SCALE")]
		public const int CvBlurNoScale = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_CANNY_L2_GRADIENT']"
		[Register ("CV_CANNY_L2_GRADIENT")]
		public const int CvCannyL2Gradient = (int) -2147483648;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_CHAIN_CODE']"
		[Register ("CV_CHAIN_CODE")]
		public const int CvChainCode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_CLOCKWISE']"
		[Register ("CV_CLOCKWISE")]
		public const int CvClockwise = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_COMP_BHATTACHARYYA']"
		[Register ("CV_COMP_BHATTACHARYYA")]
		public const int CvCompBhattacharyya = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_COMP_CHISQR']"
		[Register ("CV_COMP_CHISQR")]
		public const int CvCompChisqr = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_COMP_CHISQR_ALT']"
		[Register ("CV_COMP_CHISQR_ALT")]
		public const int CvCompChisqrAlt = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_COMP_CORREL']"
		[Register ("CV_COMP_CORREL")]
		public const int CvCompCorrel = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_COMP_HELLINGER']"
		[Register ("CV_COMP_HELLINGER")]
		public const int CvCompHellinger = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_COMP_INTERSECT']"
		[Register ("CV_COMP_INTERSECT")]
		public const int CvCompIntersect = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_COMP_KL_DIV']"
		[Register ("CV_COMP_KL_DIV")]
		public const int CvCompKlDiv = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_CONTOURS_MATCH_I1']"
		[Register ("CV_CONTOURS_MATCH_I1")]
		public const int CvContoursMatchI1 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_CONTOURS_MATCH_I2']"
		[Register ("CV_CONTOURS_MATCH_I2")]
		public const int CvContoursMatchI2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_CONTOURS_MATCH_I3']"
		[Register ("CV_CONTOURS_MATCH_I3")]
		public const int CvContoursMatchI3 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_COUNTER_CLOCKWISE']"
		[Register ("CV_COUNTER_CLOCKWISE")]
		public const int CvCounterClockwise = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_C']"
		[Register ("CV_DIST_C")]
		public const int CvDistC = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_FAIR']"
		[Register ("CV_DIST_FAIR")]
		public const int CvDistFair = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_HUBER']"
		[Register ("CV_DIST_HUBER")]
		public const int CvDistHuber = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_L1']"
		[Register ("CV_DIST_L1")]
		public const int CvDistL1 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_L12']"
		[Register ("CV_DIST_L12")]
		public const int CvDistL12 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_L2']"
		[Register ("CV_DIST_L2")]
		public const int CvDistL2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_LABEL_CCOMP']"
		[Register ("CV_DIST_LABEL_CCOMP")]
		public const int CvDistLabelCcomp = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_LABEL_PIXEL']"
		[Register ("CV_DIST_LABEL_PIXEL")]
		public const int CvDistLabelPixel = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_MASK_3']"
		[Register ("CV_DIST_MASK_3")]
		public const int CvDistMask3 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_MASK_5']"
		[Register ("CV_DIST_MASK_5")]
		public const int CvDistMask5 = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_MASK_PRECISE']"
		[Register ("CV_DIST_MASK_PRECISE")]
		public const int CvDistMaskPrecise = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_USER']"
		[Register ("CV_DIST_USER")]
		public const int CvDistUser = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_DIST_WELSCH']"
		[Register ("CV_DIST_WELSCH")]
		public const int CvDistWelsch = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_GAUSSIAN']"
		[Register ("CV_GAUSSIAN")]
		public const int CvGaussian = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_GAUSSIAN_5x5']"
		[Register ("CV_GAUSSIAN_5x5")]
		public const int CVGAUSSIAN5x5 = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_HOUGH_GRADIENT']"
		[Register ("CV_HOUGH_GRADIENT")]
		public const int CvHoughGradient = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_HOUGH_MULTI_SCALE']"
		[Register ("CV_HOUGH_MULTI_SCALE")]
		public const int CvHoughMultiScale = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_HOUGH_PROBABILISTIC']"
		[Register ("CV_HOUGH_PROBABILISTIC")]
		public const int CvHoughProbabilistic = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_HOUGH_STANDARD']"
		[Register ("CV_HOUGH_STANDARD")]
		public const int CvHoughStandard = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_LINK_RUNS']"
		[Register ("CV_LINK_RUNS")]
		public const int CvLinkRuns = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_MAX_SOBEL_KSIZE']"
		[Register ("CV_MAX_SOBEL_KSIZE")]
		public const int CvMaxSobelKsize = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_MEDIAN']"
		[Register ("CV_MEDIAN")]
		public const int CvMedian = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_POLY_APPROX_DP']"
		[Register ("CV_POLY_APPROX_DP")]
		public const int CvPolyApproxDp = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_RGBA2mRGBA']"
		[Register ("CV_RGBA2mRGBA")]
		public const int CVRGBA2mRGBA = (int) 125;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_SCHARR']"
		[Register ("CV_SCHARR")]
		public const int CvScharr = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_SHAPE_CROSS']"
		[Register ("CV_SHAPE_CROSS")]
		public const int CvShapeCross = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_SHAPE_CUSTOM']"
		[Register ("CV_SHAPE_CUSTOM")]
		public const int CvShapeCustom = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_SHAPE_ELLIPSE']"
		[Register ("CV_SHAPE_ELLIPSE")]
		public const int CvShapeEllipse = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_SHAPE_RECT']"
		[Register ("CV_SHAPE_RECT")]
		public const int CvShapeRect = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_WARP_FILL_OUTLIERS']"
		[Register ("CV_WARP_FILL_OUTLIERS")]
		public const int CvWarpFillOutliers = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_WARP_INVERSE_MAP']"
		[Register ("CV_WARP_INVERSE_MAP")]
		public const int CvWarpInverseMap = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='CV_mRGBA2RGBA']"
		[Register ("CV_mRGBA2RGBA")]
		public const int CVMRGBA2RGBA = (int) 126;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_C']"
		[Register ("DIST_C")]
		public const int DistC = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_FAIR']"
		[Register ("DIST_FAIR")]
		public const int DistFair = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_HUBER']"
		[Register ("DIST_HUBER")]
		public const int DistHuber = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_L1']"
		[Register ("DIST_L1")]
		public const int DistL1 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_L12']"
		[Register ("DIST_L12")]
		public const int DistL12 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_L2']"
		[Register ("DIST_L2")]
		public const int DistL2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_LABEL_CCOMP']"
		[Register ("DIST_LABEL_CCOMP")]
		public const int DistLabelCcomp = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_LABEL_PIXEL']"
		[Register ("DIST_LABEL_PIXEL")]
		public const int DistLabelPixel = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_MASK_3']"
		[Register ("DIST_MASK_3")]
		public const int DistMask3 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_MASK_5']"
		[Register ("DIST_MASK_5")]
		public const int DistMask5 = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_MASK_PRECISE']"
		[Register ("DIST_MASK_PRECISE")]
		public const int DistMaskPrecise = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_USER']"
		[Register ("DIST_USER")]
		public const int DistUser = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='DIST_WELSCH']"
		[Register ("DIST_WELSCH")]
		public const int DistWelsch = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='FLOODFILL_FIXED_RANGE']"
		[Register ("FLOODFILL_FIXED_RANGE")]
		public const int FloodfillFixedRange = (int) 65536;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='FLOODFILL_MASK_ONLY']"
		[Register ("FLOODFILL_MASK_ONLY")]
		public const int FloodfillMaskOnly = (int) 131072;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='GC_BGD']"
		[Register ("GC_BGD")]
		public const int GcBgd = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='GC_EVAL']"
		[Register ("GC_EVAL")]
		public const int GcEval = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='GC_FGD']"
		[Register ("GC_FGD")]
		public const int GcFgd = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='GC_INIT_WITH_MASK']"
		[Register ("GC_INIT_WITH_MASK")]
		public const int GcInitWithMask = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='GC_INIT_WITH_RECT']"
		[Register ("GC_INIT_WITH_RECT")]
		public const int GcInitWithRect = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='GC_PR_BGD']"
		[Register ("GC_PR_BGD")]
		public const int GcPrBgd = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='GC_PR_FGD']"
		[Register ("GC_PR_FGD")]
		public const int GcPrFgd = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HISTCMP_BHATTACHARYYA']"
		[Register ("HISTCMP_BHATTACHARYYA")]
		public const int HistcmpBhattacharyya = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HISTCMP_CHISQR']"
		[Register ("HISTCMP_CHISQR")]
		public const int HistcmpChisqr = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HISTCMP_CHISQR_ALT']"
		[Register ("HISTCMP_CHISQR_ALT")]
		public const int HistcmpChisqrAlt = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HISTCMP_CORREL']"
		[Register ("HISTCMP_CORREL")]
		public const int HistcmpCorrel = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HISTCMP_HELLINGER']"
		[Register ("HISTCMP_HELLINGER")]
		public const int HistcmpHellinger = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HISTCMP_INTERSECT']"
		[Register ("HISTCMP_INTERSECT")]
		public const int HistcmpIntersect = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HISTCMP_KL_DIV']"
		[Register ("HISTCMP_KL_DIV")]
		public const int HistcmpKlDiv = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HOUGH_GRADIENT']"
		[Register ("HOUGH_GRADIENT")]
		public const int HoughGradient = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HOUGH_MULTI_SCALE']"
		[Register ("HOUGH_MULTI_SCALE")]
		public const int HoughMultiScale = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HOUGH_PROBABILISTIC']"
		[Register ("HOUGH_PROBABILISTIC")]
		public const int HoughProbabilistic = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='HOUGH_STANDARD']"
		[Register ("HOUGH_STANDARD")]
		public const int HoughStandard = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTERSECT_FULL']"
		[Register ("INTERSECT_FULL")]
		public const int IntersectFull = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTERSECT_NONE']"
		[Register ("INTERSECT_NONE")]
		public const int IntersectNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTERSECT_PARTIAL']"
		[Register ("INTERSECT_PARTIAL")]
		public const int IntersectPartial = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_AREA']"
		[Register ("INTER_AREA")]
		public const int InterArea = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_BITS']"
		[Register ("INTER_BITS")]
		public const int InterBits = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_BITS2']"
		[Register ("INTER_BITS2")]
		public const int InterBits2 = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_CUBIC']"
		[Register ("INTER_CUBIC")]
		public const int InterCubic = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_LANCZOS4']"
		[Register ("INTER_LANCZOS4")]
		public const int InterLanczos4 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_LINEAR']"
		[Register ("INTER_LINEAR")]
		public const int InterLinear = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_MAX']"
		[Register ("INTER_MAX")]
		public const int InterMax = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_NEAREST']"
		[Register ("INTER_NEAREST")]
		public const int InterNearest = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_TAB_SIZE']"
		[Register ("INTER_TAB_SIZE")]
		public const int InterTabSize = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='INTER_TAB_SIZE2']"
		[Register ("INTER_TAB_SIZE2")]
		public const int InterTabSize2 = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='LINE_4']"
		[Register ("LINE_4")]
		public const int Line4 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='LINE_8']"
		[Register ("LINE_8")]
		public const int Line8 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='LINE_AA']"
		[Register ("LINE_AA")]
		public const int LineAa = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='LSD_REFINE_ADV']"
		[Register ("LSD_REFINE_ADV")]
		public const int LsdRefineAdv = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='LSD_REFINE_NONE']"
		[Register ("LSD_REFINE_NONE")]
		public const int LsdRefineNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='LSD_REFINE_STD']"
		[Register ("LSD_REFINE_STD")]
		public const int LsdRefineStd = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MARKER_CROSS']"
		[Register ("MARKER_CROSS")]
		public const int MarkerCross = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MARKER_DIAMOND']"
		[Register ("MARKER_DIAMOND")]
		public const int MarkerDiamond = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MARKER_SQUARE']"
		[Register ("MARKER_SQUARE")]
		public const int MarkerSquare = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MARKER_STAR']"
		[Register ("MARKER_STAR")]
		public const int MarkerStar = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MARKER_TILTED_CROSS']"
		[Register ("MARKER_TILTED_CROSS")]
		public const int MarkerTiltedCross = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MARKER_TRIANGLE_DOWN']"
		[Register ("MARKER_TRIANGLE_DOWN")]
		public const int MarkerTriangleDown = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MARKER_TRIANGLE_UP']"
		[Register ("MARKER_TRIANGLE_UP")]
		public const int MarkerTriangleUp = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_BLACKHAT']"
		[Register ("MORPH_BLACKHAT")]
		public const int MorphBlackhat = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_CLOSE']"
		[Register ("MORPH_CLOSE")]
		public const int MorphClose = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_CROSS']"
		[Register ("MORPH_CROSS")]
		public const int MorphCross = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_DILATE']"
		[Register ("MORPH_DILATE")]
		public const int MorphDilate = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_ELLIPSE']"
		[Register ("MORPH_ELLIPSE")]
		public const int MorphEllipse = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_ERODE']"
		[Register ("MORPH_ERODE")]
		public const int MorphErode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_GRADIENT']"
		[Register ("MORPH_GRADIENT")]
		public const int MorphGradient = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_HITMISS']"
		[Register ("MORPH_HITMISS")]
		public const int MorphHitmiss = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_OPEN']"
		[Register ("MORPH_OPEN")]
		public const int MorphOpen = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_RECT']"
		[Register ("MORPH_RECT")]
		public const int MorphRect = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='MORPH_TOPHAT']"
		[Register ("MORPH_TOPHAT")]
		public const int MorphTophat = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='PROJ_SPHERICAL_EQRECT']"
		[Register ("PROJ_SPHERICAL_EQRECT")]
		public const int ProjSphericalEqrect = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='PROJ_SPHERICAL_ORTHO']"
		[Register ("PROJ_SPHERICAL_ORTHO")]
		public const int ProjSphericalOrtho = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='RETR_CCOMP']"
		[Register ("RETR_CCOMP")]
		public const int RetrCcomp = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='RETR_EXTERNAL']"
		[Register ("RETR_EXTERNAL")]
		public const int RetrExternal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='RETR_FLOODFILL']"
		[Register ("RETR_FLOODFILL")]
		public const int RetrFloodfill = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='RETR_LIST']"
		[Register ("RETR_LIST")]
		public const int RetrList = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='RETR_TREE']"
		[Register ("RETR_TREE")]
		public const int RetrTree = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='THRESH_BINARY']"
		[Register ("THRESH_BINARY")]
		public const int ThreshBinary = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='THRESH_BINARY_INV']"
		[Register ("THRESH_BINARY_INV")]
		public const int ThreshBinaryInv = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='THRESH_MASK']"
		[Register ("THRESH_MASK")]
		public const int ThreshMask = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='THRESH_OTSU']"
		[Register ("THRESH_OTSU")]
		public const int ThreshOtsu = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='THRESH_TOZERO']"
		[Register ("THRESH_TOZERO")]
		public const int ThreshTozero = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='THRESH_TOZERO_INV']"
		[Register ("THRESH_TOZERO_INV")]
		public const int ThreshTozeroInv = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='THRESH_TRIANGLE']"
		[Register ("THRESH_TRIANGLE")]
		public const int ThreshTriangle = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='THRESH_TRUNC']"
		[Register ("THRESH_TRUNC")]
		public const int ThreshTrunc = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='TM_CCOEFF']"
		[Register ("TM_CCOEFF")]
		public const int TmCcoeff = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='TM_CCOEFF_NORMED']"
		[Register ("TM_CCOEFF_NORMED")]
		public const int TmCcoeffNormed = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='TM_CCORR']"
		[Register ("TM_CCORR")]
		public const int TmCcorr = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='TM_CCORR_NORMED']"
		[Register ("TM_CCORR_NORMED")]
		public const int TmCcorrNormed = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='TM_SQDIFF']"
		[Register ("TM_SQDIFF")]
		public const int TmSqdiff = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='TM_SQDIFF_NORMED']"
		[Register ("TM_SQDIFF_NORMED")]
		public const int TmSqdiffNormed = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='WARP_FILL_OUTLIERS']"
		[Register ("WARP_FILL_OUTLIERS")]
		public const int WarpFillOutliers = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/field[@name='WARP_INVERSE_MAP']"
		[Register ("WARP_INVERSE_MAP")]
		public const int WarpInverseMap = (int) 16;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/imgproc/Imgproc", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Imgproc); }
		}

		protected Imgproc (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/constructor[@name='Imgproc' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Imgproc ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Imgproc)) {
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

		static IntPtr id_Canny_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Canny' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("Canny", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DD)V", "")]
		public static unsafe void Canny (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3)
		{
			if (id_Canny_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD == IntPtr.Zero)
				id_Canny_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD = JNIEnv.GetStaticMethodID (class_ref, "Canny", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DD)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Canny_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD, __args);
			} finally {
			}
		}

		static IntPtr id_Canny_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Canny' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int'] and parameter[6][@type='boolean']]"
		[Register ("Canny", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDIZ)V", "")]
		public static unsafe void Canny (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4, bool p5)
		{
			if (id_Canny_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIZ == IntPtr.Zero)
				id_Canny_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIZ = JNIEnv.GetStaticMethodID (class_ref, "Canny", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDIZ)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Canny_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIZ, __args);
			} finally {
			}
		}

		static IntPtr id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='GaussianBlur' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double']]"
		[Register ("GaussianBlur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;D)V", "")]
		public static unsafe void GaussianBlur (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, double p3)
		{
			if (id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_D == IntPtr.Zero)
				id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_D = JNIEnv.GetStaticMethodID (class_ref, "GaussianBlur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;D)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_D, __args);
			} finally {
			}
		}

		static IntPtr id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='GaussianBlur' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register ("GaussianBlur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DD)V", "")]
		public static unsafe void GaussianBlur (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, double p3, double p4)
		{
			if (id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DD == IntPtr.Zero)
				id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DD = JNIEnv.GetStaticMethodID (class_ref, "GaussianBlur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DD)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DD, __args);
			} finally {
			}
		}

		static IntPtr id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='GaussianBlur' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='int']]"
		[Register ("GaussianBlur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DDI)V", "")]
		public static unsafe void GaussianBlur (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, double p3, double p4, int p5)
		{
			if (id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDI == IntPtr.Zero)
				id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDI = JNIEnv.GetStaticMethodID (class_ref, "GaussianBlur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DDI)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_GaussianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDI, __args);
			} finally {
			}
		}

		static IntPtr id_HoughCircles_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='HoughCircles' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register ("HoughCircles", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDD)V", "")]
		public static unsafe void HoughCircles (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, double p3, double p4)
		{
			if (id_HoughCircles_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD == IntPtr.Zero)
				id_HoughCircles_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD = JNIEnv.GetStaticMethodID (class_ref, "HoughCircles", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDD)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_HoughCircles_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD, __args);
			} finally {
			}
		}

		static IntPtr id_HoughCircles_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDDDII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='HoughCircles' and count(parameter)=9 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='double'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("HoughCircles", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDDDDII)V", "")]
		public static unsafe void HoughCircles (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, double p3, double p4, double p5, double p6, int p7, int p8)
		{
			if (id_HoughCircles_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDDDII == IntPtr.Zero)
				id_HoughCircles_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDDDII = JNIEnv.GetStaticMethodID (class_ref, "HoughCircles", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDDDDII)V");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_HoughCircles_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDDDII, __args);
			} finally {
			}
		}

		static IntPtr id_HoughLines_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='HoughLines' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("HoughLines", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDI)V", "")]
		public static unsafe void HoughLines (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4)
		{
			if (id_HoughLines_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI == IntPtr.Zero)
				id_HoughLines_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI = JNIEnv.GetStaticMethodID (class_ref, "HoughLines", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_HoughLines_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI, __args);
			} finally {
			}
		}

		static IntPtr id_HoughLines_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIDDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='HoughLines' and count(parameter)=9 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int'] and parameter[6][@type='double'] and parameter[7][@type='double'] and parameter[8][@type='double'] and parameter[9][@type='double']]"
		[Register ("HoughLines", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDIDDDD)V", "")]
		public static unsafe void HoughLines (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4, double p5, double p6, double p7, double p8)
		{
			if (id_HoughLines_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIDDDD == IntPtr.Zero)
				id_HoughLines_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIDDDD = JNIEnv.GetStaticMethodID (class_ref, "HoughLines", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDIDDDD)V");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_HoughLines_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIDDDD, __args);
			} finally {
			}
		}

		static IntPtr id_HoughLinesP_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='HoughLinesP' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("HoughLinesP", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDI)V", "")]
		public static unsafe void HoughLinesP (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4)
		{
			if (id_HoughLinesP_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI == IntPtr.Zero)
				id_HoughLinesP_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI = JNIEnv.GetStaticMethodID (class_ref, "HoughLinesP", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_HoughLinesP_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI, __args);
			} finally {
			}
		}

		static IntPtr id_HoughLinesP_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='HoughLinesP' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int'] and parameter[6][@type='double'] and parameter[7][@type='double']]"
		[Register ("HoughLinesP", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDIDD)V", "")]
		public static unsafe void HoughLinesP (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4, double p5, double p6)
		{
			if (id_HoughLinesP_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIDD == IntPtr.Zero)
				id_HoughLinesP_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIDD = JNIEnv.GetStaticMethodID (class_ref, "HoughLinesP", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDIDD)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_HoughLinesP_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIDD, __args);
			} finally {
			}
		}

		static IntPtr id_HuMoments_Lorg_opencv_imgproc_Moments_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='HuMoments' and count(parameter)=2 and parameter[1][@type='org.opencv.imgproc.Moments'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("HuMoments", "(Lorg/opencv/imgproc/Moments;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void HuMoments (global::OpenCV.ImgProc.Moments p0, global::OpenCV.Core.Mat p1)
		{
			if (id_HuMoments_Lorg_opencv_imgproc_Moments_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_HuMoments_Lorg_opencv_imgproc_Moments_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "HuMoments", "(Lorg/opencv/imgproc/Moments;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_HuMoments_Lorg_opencv_imgproc_Moments_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Laplacian' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("Laplacian", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Laplacian (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "Laplacian", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Laplacian' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("Laplacian", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIDD)V", "")]
		public static unsafe void Laplacian (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, double p4, double p5)
		{
			if (id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDD == IntPtr.Zero)
				id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDD = JNIEnv.GetStaticMethodID (class_ref, "Laplacian", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIDD)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDD, __args);
			} finally {
			}
		}

		static IntPtr id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Laplacian' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='int']]"
		[Register ("Laplacian", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIDDI)V", "")]
		public static unsafe void Laplacian (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, double p4, double p5, int p6)
		{
			if (id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDDI == IntPtr.Zero)
				id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDDI = JNIEnv.GetStaticMethodID (class_ref, "Laplacian", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIDDI)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Laplacian_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDDI, __args);
			} finally {
			}
		}

		static IntPtr id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Scharr' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("Scharr", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V", "")]
		public static unsafe void Scharr (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4)
		{
			if (id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III == IntPtr.Zero)
				id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III = JNIEnv.GetStaticMethodID (class_ref, "Scharr", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III, __args);
			} finally {
			}
		}

		static IntPtr id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Scharr' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='double'] and parameter[7][@type='double']]"
		[Register ("Scharr", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIDD)V", "")]
		public static unsafe void Scharr (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4, double p5, double p6)
		{
			if (id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIDD == IntPtr.Zero)
				id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIDD = JNIEnv.GetStaticMethodID (class_ref, "Scharr", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIDD)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIDD, __args);
			} finally {
			}
		}

		static IntPtr id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIDDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Scharr' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='double'] and parameter[7][@type='double'] and parameter[8][@type='int']]"
		[Register ("Scharr", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIDDI)V", "")]
		public static unsafe void Scharr (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4, double p5, double p6, int p7)
		{
			if (id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIDDI == IntPtr.Zero)
				id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIDDI = JNIEnv.GetStaticMethodID (class_ref, "Scharr", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIDDI)V");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Scharr_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIDDI, __args);
			} finally {
			}
		}

		static IntPtr id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Sobel' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("Sobel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V", "")]
		public static unsafe void Sobel (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4)
		{
			if (id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III == IntPtr.Zero)
				id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III = JNIEnv.GetStaticMethodID (class_ref, "Sobel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III, __args);
			} finally {
			}
		}

		static IntPtr id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Sobel' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='double'] and parameter[8][@type='double']]"
		[Register ("Sobel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIIDD)V", "")]
		public static unsafe void Sobel (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4, int p5, double p6, double p7)
		{
			if (id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIDD == IntPtr.Zero)
				id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIDD = JNIEnv.GetStaticMethodID (class_ref, "Sobel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIIDD)V");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIDD, __args);
			} finally {
			}
		}

		static IntPtr id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIDDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='Sobel' and count(parameter)=9 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='double'] and parameter[8][@type='double'] and parameter[9][@type='int']]"
		[Register ("Sobel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIIDDI)V", "")]
		public static unsafe void Sobel (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4, int p5, double p6, double p7, int p8)
		{
			if (id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIDDI == IntPtr.Zero)
				id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIDDI = JNIEnv.GetStaticMethodID (class_ref, "Sobel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIIDDI)V");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Sobel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIDDI, __args);
			} finally {
			}
		}

		static IntPtr id_accumulate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='accumulate' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("accumulate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Accumulate (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_accumulate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_accumulate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "accumulate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_accumulate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_accumulate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='accumulate' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("accumulate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Accumulate (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_accumulate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_accumulate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "accumulate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_accumulate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_accumulateProduct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='accumulateProduct' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("accumulateProduct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void AccumulateProduct (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_accumulateProduct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_accumulateProduct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "accumulateProduct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_accumulateProduct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_accumulateProduct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='accumulateProduct' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("accumulateProduct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void AccumulateProduct (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_accumulateProduct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_accumulateProduct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "accumulateProduct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_accumulateProduct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_accumulateSquare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='accumulateSquare' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("accumulateSquare", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void AccumulateSquare (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_accumulateSquare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_accumulateSquare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "accumulateSquare", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_accumulateSquare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_accumulateSquare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='accumulateSquare' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("accumulateSquare", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void AccumulateSquare (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_accumulateSquare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_accumulateSquare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "accumulateSquare", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_accumulateSquare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_accumulateWeighted_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='accumulateWeighted' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double']]"
		[Register ("accumulateWeighted", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void AccumulateWeighted (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2)
		{
			if (id_accumulateWeighted_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_accumulateWeighted_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "accumulateWeighted", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_accumulateWeighted_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_accumulateWeighted_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='accumulateWeighted' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("accumulateWeighted", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;)V", "")]
		public static unsafe void AccumulateWeighted (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, global::OpenCV.Core.Mat p3)
		{
			if (id_accumulateWeighted_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_ == IntPtr.Zero)
				id_accumulateWeighted_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "accumulateWeighted", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_accumulateWeighted_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_adaptiveThreshold_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DIIID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='adaptiveThreshold' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='double']]"
		[Register ("adaptiveThreshold", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DIIID)V", "")]
		public static unsafe void AdaptiveThreshold (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, int p3, int p4, int p5, double p6)
		{
			if (id_adaptiveThreshold_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DIIID == IntPtr.Zero)
				id_adaptiveThreshold_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DIIID = JNIEnv.GetStaticMethodID (class_ref, "adaptiveThreshold", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DIIID)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_adaptiveThreshold_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DIIID, __args);
			} finally {
			}
		}

		static IntPtr id_applyColorMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='applyColorMap' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("applyColorMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void ApplyColorMap (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_applyColorMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_applyColorMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "applyColorMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_applyColorMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_approxPolyDP_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_DZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='approxPolyDP' and count(parameter)=4 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='double'] and parameter[4][@type='boolean']]"
		[Register ("approxPolyDP", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;DZ)V", "")]
		public static unsafe void ApproxPolyDP (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1, double p2, bool p3)
		{
			if (id_approxPolyDP_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_DZ == IntPtr.Zero)
				id_approxPolyDP_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_DZ = JNIEnv.GetStaticMethodID (class_ref, "approxPolyDP", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;DZ)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_approxPolyDP_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_DZ, __args);
			} finally {
			}
		}

		static IntPtr id_arcLength_Lorg_opencv_core_MatOfPoint2f_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='arcLength' and count(parameter)=2 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='boolean']]"
		[Register ("arcLength", "(Lorg/opencv/core/MatOfPoint2f;Z)D", "")]
		public static unsafe double ArcLength (global::OpenCV.Core.MatOfPoint2f p0, bool p1)
		{
			if (id_arcLength_Lorg_opencv_core_MatOfPoint2f_Z == IntPtr.Zero)
				id_arcLength_Lorg_opencv_core_MatOfPoint2f_Z = JNIEnv.GetStaticMethodID (class_ref, "arcLength", "(Lorg/opencv/core/MatOfPoint2f;Z)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_arcLength_Lorg_opencv_core_MatOfPoint2f_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_arrowedLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='arrowedLine' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar']]"
		[Register ("arrowedLine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)V", "")]
		public static unsafe void ArrowedLine (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3)
		{
			if (id_arrowedLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_arrowedLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "arrowedLine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_arrowedLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_arrowedLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_IIID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='arrowedLine' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='double']]"
		[Register ("arrowedLine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;IIID)V", "")]
		public static unsafe void ArrowedLine (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3, int p4, int p5, int p6, double p7)
		{
			if (id_arrowedLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_IIID == IntPtr.Zero)
				id_arrowedLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_IIID = JNIEnv.GetStaticMethodID (class_ref, "arrowedLine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;IIID)V");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_arrowedLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_IIID, __args);
			} finally {
			}
		}

		static IntPtr id_bilateralFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='bilateralFilter' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register ("bilateralFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDD)V", "")]
		public static unsafe void BilateralFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, double p3, double p4)
		{
			if (id_bilateralFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD == IntPtr.Zero)
				id_bilateralFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD = JNIEnv.GetStaticMethodID (class_ref, "bilateralFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDD)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bilateralFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD, __args);
			} finally {
			}
		}

		static IntPtr id_bilateralFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='bilateralFilter' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='int']]"
		[Register ("bilateralFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDDI)V", "")]
		public static unsafe void BilateralFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, double p3, double p4, int p5)
		{
			if (id_bilateralFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDI == IntPtr.Zero)
				id_bilateralFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDI = JNIEnv.GetStaticMethodID (class_ref, "bilateralFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDDI)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bilateralFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDI, __args);
			} finally {
			}
		}

		static IntPtr id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='blur' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size']]"
		[Register ("blur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V", "")]
		public static unsafe void Blur (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2)
		{
			if (id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "blur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='blur' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Point']]"
		[Register ("blur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Point;)V", "")]
		public static unsafe void Blur (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Point p3)
		{
			if (id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_ = JNIEnv.GetStaticMethodID (class_ref, "blur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Point;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_, __args);
			} finally {
			}
		}

		static IntPtr id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='blur' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Point'] and parameter[5][@type='int']]"
		[Register ("blur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Point;I)V", "")]
		public static unsafe void Blur (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Point p3, int p4)
		{
			if (id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_I == IntPtr.Zero)
				id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_I = JNIEnv.GetStaticMethodID (class_ref, "blur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Point;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_blur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_I, __args);
			} finally {
			}
		}

		static IntPtr id_boundingRect_Lorg_opencv_core_MatOfPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='boundingRect' and count(parameter)=1 and parameter[1][@type='org.opencv.core.MatOfPoint']]"
		[Register ("boundingRect", "(Lorg/opencv/core/MatOfPoint;)Lorg/opencv/core/Rect;", "")]
		public static unsafe global::OpenCV.Core.Rect BoundingRect (global::OpenCV.Core.MatOfPoint p0)
		{
			if (id_boundingRect_Lorg_opencv_core_MatOfPoint_ == IntPtr.Zero)
				id_boundingRect_Lorg_opencv_core_MatOfPoint_ = JNIEnv.GetStaticMethodID (class_ref, "boundingRect", "(Lorg/opencv/core/MatOfPoint;)Lorg/opencv/core/Rect;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.Rect __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_boundingRect_Lorg_opencv_core_MatOfPoint_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='boxFilter' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Size']]"
		[Register ("boxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;)V", "")]
		public static unsafe void BoxFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Size p3)
		{
			if (id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_ == IntPtr.Zero)
				id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "boxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='boxFilter' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='org.opencv.core.Point'] and parameter[6][@type='boolean']]"
		[Register ("boxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;Lorg/opencv/core/Point;Z)V", "")]
		public static unsafe void BoxFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Size p3, global::OpenCV.Core.Point p4, bool p5)
		{
			if (id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_Z == IntPtr.Zero)
				id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_Z = JNIEnv.GetStaticMethodID (class_ref, "boxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;Lorg/opencv/core/Point;Z)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_Z, __args);
			} finally {
			}
		}

		static IntPtr id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='boxFilter' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='org.opencv.core.Point'] and parameter[6][@type='boolean'] and parameter[7][@type='int']]"
		[Register ("boxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;Lorg/opencv/core/Point;ZI)V", "")]
		public static unsafe void BoxFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Size p3, global::OpenCV.Core.Point p4, bool p5, int p6)
		{
			if (id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ZI == IntPtr.Zero)
				id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ZI = JNIEnv.GetStaticMethodID (class_ref, "boxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;Lorg/opencv/core/Point;ZI)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_boxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ZI, __args);
			} finally {
			}
		}

		static IntPtr id_boxPoints_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='boxPoints' and count(parameter)=2 and parameter[1][@type='org.opencv.core.RotatedRect'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("boxPoints", "(Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void BoxPoints (global::OpenCV.Core.RotatedRect p0, global::OpenCV.Core.Mat p1)
		{
			if (id_boxPoints_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_boxPoints_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "boxPoints", "(Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_boxPoints_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_calcBackProject_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='calcBackProject' and count(parameter)=6 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.MatOfInt'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.MatOfFloat'] and parameter[6][@type='double']]"
		[Register ("calcBackProject", "(Ljava/util/List;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;D)V", "")]
		public static unsafe void CalcBackProject (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.MatOfInt p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.MatOfFloat p4, double p5)
		{
			if (id_calcBackProject_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_D == IntPtr.Zero)
				id_calcBackProject_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_D = JNIEnv.GetStaticMethodID (class_ref, "calcBackProject", "(Ljava/util/List;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;D)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calcBackProject_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_D, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_calcHist_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfFloat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='calcHist' and count(parameter)=6 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.MatOfInt'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.MatOfInt'] and parameter[6][@type='org.opencv.core.MatOfFloat']]"
		[Register ("calcHist", "(Ljava/util/List;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfFloat;)V", "")]
		public static unsafe void CalcHist (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.MatOfInt p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.MatOfInt p4, global::OpenCV.Core.MatOfFloat p5)
		{
			if (id_calcHist_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfFloat_ == IntPtr.Zero)
				id_calcHist_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfFloat_ = JNIEnv.GetStaticMethodID (class_ref, "calcHist", "(Ljava/util/List;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfFloat;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calcHist_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfFloat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_calcHist_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfFloat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='calcHist' and count(parameter)=7 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.MatOfInt'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.MatOfInt'] and parameter[6][@type='org.opencv.core.MatOfFloat'] and parameter[7][@type='boolean']]"
		[Register ("calcHist", "(Ljava/util/List;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfFloat;Z)V", "")]
		public static unsafe void CalcHist (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.MatOfInt p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.MatOfInt p4, global::OpenCV.Core.MatOfFloat p5, bool p6)
		{
			if (id_calcHist_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfFloat_Z == IntPtr.Zero)
				id_calcHist_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfFloat_Z = JNIEnv.GetStaticMethodID (class_ref, "calcHist", "(Ljava/util/List;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfFloat;Z)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calcHist_Ljava_util_List_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfFloat_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='circle' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Scalar']]"
		[Register ("circle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;ILorg/opencv/core/Scalar;)V", "")]
		public static unsafe void Circle (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, int p2, global::OpenCV.Core.Scalar p3)
		{
			if (id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "circle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;ILorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='circle' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int']]"
		[Register ("circle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;ILorg/opencv/core/Scalar;I)V", "")]
		public static unsafe void Circle (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, int p2, global::OpenCV.Core.Scalar p3, int p4)
		{
			if (id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "circle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;ILorg/opencv/core/Scalar;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_I, __args);
			} finally {
			}
		}

		static IntPtr id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='circle' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("circle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;ILorg/opencv/core/Scalar;III)V", "")]
		public static unsafe void Circle (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, int p2, global::OpenCV.Core.Scalar p3, int p4, int p5, int p6)
		{
			if (id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_III == IntPtr.Zero)
				id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_III = JNIEnv.GetStaticMethodID (class_ref, "circle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;ILorg/opencv/core/Scalar;III)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_circle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ILorg_opencv_core_Scalar_III, __args);
			} finally {
			}
		}

		static IntPtr id_clipLine_Lorg_opencv_core_Rect_Lorg_opencv_core_Point_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='clipLine' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Rect'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Point']]"
		[Register ("clipLine", "(Lorg/opencv/core/Rect;Lorg/opencv/core/Point;Lorg/opencv/core/Point;)Z", "")]
		public static unsafe bool ClipLine (global::OpenCV.Core.Rect p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Point p2)
		{
			if (id_clipLine_Lorg_opencv_core_Rect_Lorg_opencv_core_Point_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_clipLine_Lorg_opencv_core_Rect_Lorg_opencv_core_Point_Lorg_opencv_core_Point_ = JNIEnv.GetStaticMethodID (class_ref, "clipLine", "(Lorg/opencv/core/Rect;Lorg/opencv/core/Point;Lorg/opencv/core/Point;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_clipLine_Lorg_opencv_core_Rect_Lorg_opencv_core_Point_Lorg_opencv_core_Point_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_compareHist_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='compareHist' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("compareHist", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D", "")]
		public static unsafe double CompareHist (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_compareHist_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_compareHist_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "compareHist", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_compareHist_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_connectedComponents_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='connectedComponents' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("connectedComponents", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int ConnectedComponents (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_connectedComponents_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_connectedComponents_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "connectedComponents", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_connectedComponents_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_connectedComponents_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='connectedComponents' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("connectedComponents", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)I", "")]
		public static unsafe int ConnectedComponents (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_connectedComponents_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_connectedComponents_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "connectedComponents", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_connectedComponents_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_connectedComponentsWithStats_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='connectedComponentsWithStats' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("connectedComponentsWithStats", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int ConnectedComponentsWithStats (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_connectedComponentsWithStats_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_connectedComponentsWithStats_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "connectedComponentsWithStats", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_connectedComponentsWithStats_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_connectedComponentsWithStats_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='connectedComponentsWithStats' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("connectedComponentsWithStats", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)I", "")]
		public static unsafe int ConnectedComponentsWithStats (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4, int p5)
		{
			if (id_connectedComponentsWithStats_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_connectedComponentsWithStats_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "connectedComponentsWithStats", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)I");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_connectedComponentsWithStats_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_contourArea_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='contourArea' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("contourArea", "(Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double ContourArea (global::OpenCV.Core.Mat p0)
		{
			if (id_contourArea_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_contourArea_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "contourArea", "(Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_contourArea_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_contourArea_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='contourArea' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='boolean']]"
		[Register ("contourArea", "(Lorg/opencv/core/Mat;Z)D", "")]
		public static unsafe double ContourArea (global::OpenCV.Core.Mat p0, bool p1)
		{
			if (id_contourArea_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_contourArea_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "contourArea", "(Lorg/opencv/core/Mat;Z)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_contourArea_Lorg_opencv_core_Mat_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_convertMaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='convertMaps' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int']]"
		[Register ("convertMaps", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void ConvertMaps (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4)
		{
			if (id_convertMaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_convertMaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "convertMaps", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convertMaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_convertMaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='convertMaps' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int'] and parameter[6][@type='boolean']]"
		[Register ("convertMaps", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IZ)V", "")]
		public static unsafe void ConvertMaps (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4, bool p5)
		{
			if (id_convertMaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IZ == IntPtr.Zero)
				id_convertMaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IZ = JNIEnv.GetStaticMethodID (class_ref, "convertMaps", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IZ)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convertMaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_convexHull_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='convexHull' and count(parameter)=2 and parameter[1][@type='org.opencv.core.MatOfPoint'] and parameter[2][@type='org.opencv.core.MatOfInt']]"
		[Register ("convexHull", "(Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfInt;)V", "")]
		public static unsafe void ConvexHull (global::OpenCV.Core.MatOfPoint p0, global::OpenCV.Core.MatOfInt p1)
		{
			if (id_convexHull_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_ == IntPtr.Zero)
				id_convexHull_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_ = JNIEnv.GetStaticMethodID (class_ref, "convexHull", "(Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfInt;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convexHull_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_, __args);
			} finally {
			}
		}

		static IntPtr id_convexHull_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='convexHull' and count(parameter)=3 and parameter[1][@type='org.opencv.core.MatOfPoint'] and parameter[2][@type='org.opencv.core.MatOfInt'] and parameter[3][@type='boolean']]"
		[Register ("convexHull", "(Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfInt;Z)V", "")]
		public static unsafe void ConvexHull (global::OpenCV.Core.MatOfPoint p0, global::OpenCV.Core.MatOfInt p1, bool p2)
		{
			if (id_convexHull_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_Z == IntPtr.Zero)
				id_convexHull_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_Z = JNIEnv.GetStaticMethodID (class_ref, "convexHull", "(Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfInt;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convexHull_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_Z, __args);
			} finally {
			}
		}

		static IntPtr id_convexityDefects_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfInt4_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='convexityDefects' and count(parameter)=3 and parameter[1][@type='org.opencv.core.MatOfPoint'] and parameter[2][@type='org.opencv.core.MatOfInt'] and parameter[3][@type='org.opencv.core.MatOfInt4']]"
		[Register ("convexityDefects", "(Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfInt4;)V", "")]
		public static unsafe void ConvexityDefects (global::OpenCV.Core.MatOfPoint p0, global::OpenCV.Core.MatOfInt p1, global::OpenCV.Core.MatOfInt4 p2)
		{
			if (id_convexityDefects_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfInt4_ == IntPtr.Zero)
				id_convexityDefects_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfInt4_ = JNIEnv.GetStaticMethodID (class_ref, "convexityDefects", "(Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfInt4;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convexityDefects_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfInt4_, __args);
			} finally {
			}
		}

		static IntPtr id_cornerEigenValsAndVecs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cornerEigenValsAndVecs' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("cornerEigenValsAndVecs", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void CornerEigenValsAndVecs (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_cornerEigenValsAndVecs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_cornerEigenValsAndVecs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "cornerEigenValsAndVecs", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cornerEigenValsAndVecs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_cornerEigenValsAndVecs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cornerEigenValsAndVecs' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("cornerEigenValsAndVecs", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V", "")]
		public static unsafe void CornerEigenValsAndVecs (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4)
		{
			if (id_cornerEigenValsAndVecs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III == IntPtr.Zero)
				id_cornerEigenValsAndVecs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III = JNIEnv.GetStaticMethodID (class_ref, "cornerEigenValsAndVecs", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cornerEigenValsAndVecs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III, __args);
			} finally {
			}
		}

		static IntPtr id_cornerHarris_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cornerHarris' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='double']]"
		[Register ("cornerHarris", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IID)V", "")]
		public static unsafe void CornerHarris (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, double p4)
		{
			if (id_cornerHarris_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IID == IntPtr.Zero)
				id_cornerHarris_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IID = JNIEnv.GetStaticMethodID (class_ref, "cornerHarris", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IID)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cornerHarris_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IID, __args);
			} finally {
			}
		}

		static IntPtr id_cornerHarris_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cornerHarris' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='double'] and parameter[6][@type='int']]"
		[Register ("cornerHarris", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIDI)V", "")]
		public static unsafe void CornerHarris (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, double p4, int p5)
		{
			if (id_cornerHarris_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDI == IntPtr.Zero)
				id_cornerHarris_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDI = JNIEnv.GetStaticMethodID (class_ref, "cornerHarris", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIDI)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cornerHarris_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIDI, __args);
			} finally {
			}
		}

		static IntPtr id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cornerMinEigenVal' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("cornerMinEigenVal", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void CornerMinEigenVal (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "cornerMinEigenVal", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cornerMinEigenVal' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("cornerMinEigenVal", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void CornerMinEigenVal (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "cornerMinEigenVal", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cornerMinEigenVal' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("cornerMinEigenVal", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V", "")]
		public static unsafe void CornerMinEigenVal (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4)
		{
			if (id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III == IntPtr.Zero)
				id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III = JNIEnv.GetStaticMethodID (class_ref, "cornerMinEigenVal", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cornerMinEigenVal_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III, __args);
			} finally {
			}
		}

		static IntPtr id_cornerSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_TermCriteria_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cornerSubPix' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='org.opencv.core.TermCriteria']]"
		[Register ("cornerSubPix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/TermCriteria;)V", "")]
		public static unsafe void CornerSubPix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfPoint2f p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Size p3, global::OpenCV.Core.TermCriteria p4)
		{
			if (id_cornerSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_TermCriteria_ == IntPtr.Zero)
				id_cornerSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_TermCriteria_ = JNIEnv.GetStaticMethodID (class_ref, "cornerSubPix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/TermCriteria;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cornerSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_TermCriteria_, __args);
			} finally {
			}
		}

		static IntPtr id_createCLAHE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='createCLAHE' and count(parameter)=0]"
		[Register ("createCLAHE", "()Lorg/opencv/imgproc/CLAHE;", "")]
		public static unsafe global::OpenCV.ImgProc.CLAHE CreateCLAHE ()
		{
			if (id_createCLAHE == IntPtr.Zero)
				id_createCLAHE = JNIEnv.GetStaticMethodID (class_ref, "createCLAHE", "()Lorg/opencv/imgproc/CLAHE;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.CLAHE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCLAHE), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createCLAHE_DLorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='createCLAHE' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='org.opencv.core.Size']]"
		[Register ("createCLAHE", "(DLorg/opencv/core/Size;)Lorg/opencv/imgproc/CLAHE;", "")]
		public static unsafe global::OpenCV.ImgProc.CLAHE CreateCLAHE (double p0, global::OpenCV.Core.Size p1)
		{
			if (id_createCLAHE_DLorg_opencv_core_Size_ == IntPtr.Zero)
				id_createCLAHE_DLorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "createCLAHE", "(DLorg/opencv/core/Size;)Lorg/opencv/imgproc/CLAHE;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.ImgProc.CLAHE __ret = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.CLAHE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCLAHE_DLorg_opencv_core_Size_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createHanningWindow_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='createHanningWindow' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='int']]"
		[Register ("createHanningWindow", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V", "")]
		public static unsafe void CreateHanningWindow (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, int p2)
		{
			if (id_createHanningWindow_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_createHanningWindow_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "createHanningWindow", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createHanningWindow_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I, __args);
			} finally {
			}
		}

		static IntPtr id_createLineSegmentDetector;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='createLineSegmentDetector' and count(parameter)=0]"
		[Register ("createLineSegmentDetector", "()Lorg/opencv/imgproc/LineSegmentDetector;", "")]
		public static unsafe global::OpenCV.ImgProc.LineSegmentDetector CreateLineSegmentDetector ()
		{
			if (id_createLineSegmentDetector == IntPtr.Zero)
				id_createLineSegmentDetector = JNIEnv.GetStaticMethodID (class_ref, "createLineSegmentDetector", "()Lorg/opencv/imgproc/LineSegmentDetector;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.LineSegmentDetector> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLineSegmentDetector), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createLineSegmentDetector_IDDDDDDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='createLineSegmentDetector' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='double'] and parameter[8][@type='int']]"
		[Register ("createLineSegmentDetector", "(IDDDDDDI)Lorg/opencv/imgproc/LineSegmentDetector;", "")]
		public static unsafe global::OpenCV.ImgProc.LineSegmentDetector CreateLineSegmentDetector (int p0, double p1, double p2, double p3, double p4, double p5, double p6, int p7)
		{
			if (id_createLineSegmentDetector_IDDDDDDI == IntPtr.Zero)
				id_createLineSegmentDetector_IDDDDDDI = JNIEnv.GetStaticMethodID (class_ref, "createLineSegmentDetector", "(IDDDDDDI)Lorg/opencv/imgproc/LineSegmentDetector;");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				return global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.LineSegmentDetector> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLineSegmentDetector_IDDDDDDI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cvtColor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cvtColor' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("cvtColor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void CvtColor (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_cvtColor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_cvtColor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "cvtColor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cvtColor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_cvtColor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='cvtColor' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("cvtColor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void CvtColor (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_cvtColor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_cvtColor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "cvtColor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cvtColor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_demosaicing_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='demosaicing' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("demosaicing", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Demosaicing (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_demosaicing_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_demosaicing_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "demosaicing", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_demosaicing_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_demosaicing_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='demosaicing' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("demosaicing", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void Demosaicing (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_demosaicing_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_demosaicing_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "demosaicing", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_demosaicing_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='dilate' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("dilate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Dilate (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "dilate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='dilate' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Point'] and parameter[5][@type='int']]"
		[Register ("dilate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;I)V", "")]
		public static unsafe void Dilate (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Point p3, int p4)
		{
			if (id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_I == IntPtr.Zero)
				id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_I = JNIEnv.GetStaticMethodID (class_ref, "dilate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_I, __args);
			} finally {
			}
		}

		static IntPtr id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='dilate' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Point'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Scalar']]"
		[Register ("dilate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;IILorg/opencv/core/Scalar;)V", "")]
		public static unsafe void Dilate (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Point p3, int p4, int p5, global::OpenCV.Core.Scalar p6)
		{
			if (id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "dilate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;IILorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dilate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_distanceTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='distanceTransform' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("distanceTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void DistanceTransform (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_distanceTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_distanceTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "distanceTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_distanceTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_distanceTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='distanceTransform' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("distanceTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V", "")]
		public static unsafe void DistanceTransform (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4)
		{
			if (id_distanceTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III == IntPtr.Zero)
				id_distanceTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III = JNIEnv.GetStaticMethodID (class_ref, "distanceTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_distanceTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III, __args);
			} finally {
			}
		}

		static IntPtr id_distanceTransformWithLabels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='distanceTransformWithLabels' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("distanceTransformWithLabels", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void DistanceTransformWithLabels (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, int p4)
		{
			if (id_distanceTransformWithLabels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_distanceTransformWithLabels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "distanceTransformWithLabels", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_distanceTransformWithLabels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_distanceTransformWithLabels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='distanceTransformWithLabels' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("distanceTransformWithLabels", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V", "")]
		public static unsafe void DistanceTransformWithLabels (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, int p4, int p5)
		{
			if (id_distanceTransformWithLabels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III == IntPtr.Zero)
				id_distanceTransformWithLabels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III = JNIEnv.GetStaticMethodID (class_ref, "distanceTransformWithLabels", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_distanceTransformWithLabels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III, __args);
			} finally {
			}
		}

		static IntPtr id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='drawContours' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Scalar']]"
		[Register ("drawContours", "(Lorg/opencv/core/Mat;Ljava/util/List;ILorg/opencv/core/Scalar;)V", "")]
		public static unsafe void DrawContours (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, int p2, global::OpenCV.Core.Scalar p3)
		{
			if (id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "drawContours", "(Lorg/opencv/core/Mat;Ljava/util/List;ILorg/opencv/core/Scalar;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='drawContours' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int']]"
		[Register ("drawContours", "(Lorg/opencv/core/Mat;Ljava/util/List;ILorg/opencv/core/Scalar;I)V", "")]
		public static unsafe void DrawContours (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, int p2, global::OpenCV.Core.Scalar p3, int p4)
		{
			if (id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "drawContours", "(Lorg/opencv/core/Mat;Ljava/util/List;ILorg/opencv/core/Scalar;I)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_IILorg_opencv_core_Mat_ILorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='drawContours' and count(parameter)=9 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='int'] and parameter[9][@type='org.opencv.core.Point']]"
		[Register ("drawContours", "(Lorg/opencv/core/Mat;Ljava/util/List;ILorg/opencv/core/Scalar;IILorg/opencv/core/Mat;ILorg/opencv/core/Point;)V", "")]
		public static unsafe void DrawContours (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, int p2, global::OpenCV.Core.Scalar p3, int p4, int p5, global::OpenCV.Core.Mat p6, int p7, global::OpenCV.Core.Point p8)
		{
			if (id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_IILorg_opencv_core_Mat_ILorg_opencv_core_Point_ == IntPtr.Zero)
				id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_IILorg_opencv_core_Mat_ILorg_opencv_core_Point_ = JNIEnv.GetStaticMethodID (class_ref, "drawContours", "(Lorg/opencv/core/Mat;Ljava/util/List;ILorg/opencv/core/Scalar;IILorg/opencv/core/Mat;ILorg/opencv/core/Point;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawContours_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Scalar_IILorg_opencv_core_Mat_ILorg_opencv_core_Point_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_drawMarker_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='drawMarker' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Scalar']]"
		[Register ("drawMarker", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)V", "")]
		public static unsafe void DrawMarker (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Scalar p2)
		{
			if (id_drawMarker_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_drawMarker_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "drawMarker", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawMarker_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_drawMarker_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='drawMarker' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Scalar'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("drawMarker", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;IIII)V", "")]
		public static unsafe void DrawMarker (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Scalar p2, int p3, int p4, int p5, int p6)
		{
			if (id_drawMarker_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_IIII == IntPtr.Zero)
				id_drawMarker_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_IIII = JNIEnv.GetStaticMethodID (class_ref, "drawMarker", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;IIII)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawMarker_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_ellipse2Poly_Lorg_opencv_core_Point_Lorg_opencv_core_Size_IIIILorg_opencv_core_MatOfPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='ellipse2Poly' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Point'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.MatOfPoint']]"
		[Register ("ellipse2Poly", "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;IIIILorg/opencv/core/MatOfPoint;)V", "")]
		public static unsafe void Ellipse2Poly (global::OpenCV.Core.Point p0, global::OpenCV.Core.Size p1, int p2, int p3, int p4, int p5, global::OpenCV.Core.MatOfPoint p6)
		{
			if (id_ellipse2Poly_Lorg_opencv_core_Point_Lorg_opencv_core_Size_IIIILorg_opencv_core_MatOfPoint_ == IntPtr.Zero)
				id_ellipse2Poly_Lorg_opencv_core_Point_Lorg_opencv_core_Size_IIIILorg_opencv_core_MatOfPoint_ = JNIEnv.GetStaticMethodID (class_ref, "ellipse2Poly", "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;IIIILorg/opencv/core/MatOfPoint;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_ellipse2Poly_Lorg_opencv_core_Point_Lorg_opencv_core_Size_IIIILorg_opencv_core_MatOfPoint_, __args);
			} finally {
			}
		}

		static IntPtr id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='ellipse' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='org.opencv.core.Scalar']]"
		[Register ("ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Size;DDDLorg/opencv/core/Scalar;)V", "")]
		public static unsafe void Ellipse (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Size p2, double p3, double p4, double p5, global::OpenCV.Core.Scalar p6)
		{
			if (id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Size;DDDLorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='ellipse' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='org.opencv.core.Scalar'] and parameter[8][@type='int']]"
		[Register ("ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Size;DDDLorg/opencv/core/Scalar;I)V", "")]
		public static unsafe void Ellipse (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Size p2, double p3, double p4, double p5, global::OpenCV.Core.Scalar p6, int p7)
		{
			if (id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Size;DDDLorg/opencv/core/Scalar;I)V");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_I, __args);
			} finally {
			}
		}

		static IntPtr id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='ellipse' and count(parameter)=10 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='org.opencv.core.Scalar'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Size;DDDLorg/opencv/core/Scalar;III)V", "")]
		public static unsafe void Ellipse (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Size p2, double p3, double p4, double p5, global::OpenCV.Core.Scalar p6, int p7, int p8, int p9)
		{
			if (id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_III == IntPtr.Zero)
				id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_III = JNIEnv.GetStaticMethodID (class_ref, "ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Size;DDDLorg/opencv/core/Scalar;III)V");
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Size_DDDLorg_opencv_core_Scalar_III, __args);
			} finally {
			}
		}

		static IntPtr id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='ellipse' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.RotatedRect'] and parameter[3][@type='org.opencv.core.Scalar']]"
		[Register ("ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Scalar;)V", "")]
		public static unsafe void Ellipse (global::OpenCV.Core.Mat p0, global::OpenCV.Core.RotatedRect p1, global::OpenCV.Core.Scalar p2)
		{
			if (id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='ellipse' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.RotatedRect'] and parameter[3][@type='org.opencv.core.Scalar'] and parameter[4][@type='int']]"
		[Register ("ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Scalar;I)V", "")]
		public static unsafe void Ellipse (global::OpenCV.Core.Mat p0, global::OpenCV.Core.RotatedRect p1, global::OpenCV.Core.Scalar p2, int p3)
		{
			if (id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Scalar;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_I, __args);
			} finally {
			}
		}

		static IntPtr id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='ellipse' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.RotatedRect'] and parameter[3][@type='org.opencv.core.Scalar'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Scalar;II)V", "")]
		public static unsafe void Ellipse (global::OpenCV.Core.Mat p0, global::OpenCV.Core.RotatedRect p1, global::OpenCV.Core.Scalar p2, int p3, int p4)
		{
			if (id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_II == IntPtr.Zero)
				id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_II = JNIEnv.GetStaticMethodID (class_ref, "ellipse", "(Lorg/opencv/core/Mat;Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Scalar;II)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_ellipse_Lorg_opencv_core_Mat_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Scalar_II, __args);
			} finally {
			}
		}

		static IntPtr id_equalizeHist_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='equalizeHist' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("equalizeHist", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void EqualizeHist (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_equalizeHist_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_equalizeHist_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "equalizeHist", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_equalizeHist_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='erode' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("erode", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Erode (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "erode", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='erode' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Point'] and parameter[5][@type='int']]"
		[Register ("erode", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;I)V", "")]
		public static unsafe void Erode (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Point p3, int p4)
		{
			if (id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_I == IntPtr.Zero)
				id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_I = JNIEnv.GetStaticMethodID (class_ref, "erode", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_I, __args);
			} finally {
			}
		}

		static IntPtr id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='erode' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Point'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Scalar']]"
		[Register ("erode", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;IILorg/opencv/core/Scalar;)V", "")]
		public static unsafe void Erode (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Point p3, int p4, int p5, global::OpenCV.Core.Scalar p6)
		{
			if (id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "erode", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;IILorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_erode_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_fillConvexPoly_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='fillConvexPoly' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfPoint'] and parameter[3][@type='org.opencv.core.Scalar']]"
		[Register ("fillConvexPoly", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/Scalar;)V", "")]
		public static unsafe void FillConvexPoly (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfPoint p1, global::OpenCV.Core.Scalar p2)
		{
			if (id_fillConvexPoly_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_fillConvexPoly_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "fillConvexPoly", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fillConvexPoly_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_fillConvexPoly_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_Scalar_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='fillConvexPoly' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfPoint'] and parameter[3][@type='org.opencv.core.Scalar'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("fillConvexPoly", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/Scalar;II)V", "")]
		public static unsafe void FillConvexPoly (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfPoint p1, global::OpenCV.Core.Scalar p2, int p3, int p4)
		{
			if (id_fillConvexPoly_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_Scalar_II == IntPtr.Zero)
				id_fillConvexPoly_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_Scalar_II = JNIEnv.GetStaticMethodID (class_ref, "fillConvexPoly", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/Scalar;II)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fillConvexPoly_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_Scalar_II, __args);
			} finally {
			}
		}

		static IntPtr id_fillPoly_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='fillPoly' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='org.opencv.core.Scalar']]"
		[Register ("fillPoly", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Scalar;)V", "")]
		public static unsafe void FillPoly (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, global::OpenCV.Core.Scalar p2)
		{
			if (id_fillPoly_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_fillPoly_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "fillPoly", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Scalar;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fillPoly_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Scalar_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_fillPoly_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Scalar_IILorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='fillPoly' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='org.opencv.core.Scalar'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='org.opencv.core.Point']]"
		[Register ("fillPoly", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Scalar;IILorg/opencv/core/Point;)V", "")]
		public static unsafe void FillPoly (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, global::OpenCV.Core.Scalar p2, int p3, int p4, global::OpenCV.Core.Point p5)
		{
			if (id_fillPoly_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Scalar_IILorg_opencv_core_Point_ == IntPtr.Zero)
				id_fillPoly_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Scalar_IILorg_opencv_core_Point_ = JNIEnv.GetStaticMethodID (class_ref, "fillPoly", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Scalar;IILorg/opencv/core/Point;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fillPoly_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Scalar_IILorg_opencv_core_Point_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='filter2D' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("filter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)V", "")]
		public static unsafe void Filter2D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3)
		{
			if (id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "filter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='filter2D' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Point'] and parameter[6][@type='double']]"
		[Register ("filter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Point;D)V", "")]
		public static unsafe void Filter2D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Point p4, double p5)
		{
			if (id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_D == IntPtr.Zero)
				id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_D = JNIEnv.GetStaticMethodID (class_ref, "filter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Point;D)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_D, __args);
			} finally {
			}
		}

		static IntPtr id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='filter2D' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Point'] and parameter[6][@type='double'] and parameter[7][@type='int']]"
		[Register ("filter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Point;DI)V", "")]
		public static unsafe void Filter2D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Point p4, double p5, int p6)
		{
			if (id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_DI == IntPtr.Zero)
				id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_DI = JNIEnv.GetStaticMethodID (class_ref, "filter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Point;DI)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_filter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_DI, __args);
			} finally {
			}
		}

		static IntPtr id_findContours_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='findContours' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("findContours", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void FindContours (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, global::OpenCV.Core.Mat p2, int p3, int p4)
		{
			if (id_findContours_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_findContours_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "findContours", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Mat;II)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_findContours_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Mat_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_findContours_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='findContours' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='org.opencv.core.Point']]"
		[Register ("findContours", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Mat;IILorg/opencv/core/Point;)V", "")]
		public static unsafe void FindContours (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, global::OpenCV.Core.Mat p2, int p3, int p4, global::OpenCV.Core.Point p5)
		{
			if (id_findContours_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_Point_ == IntPtr.Zero)
				id_findContours_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_Point_ = JNIEnv.GetStaticMethodID (class_ref, "findContours", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Mat;IILorg/opencv/core/Point;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_findContours_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_Point_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_fitEllipse_Lorg_opencv_core_MatOfPoint2f_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='fitEllipse' and count(parameter)=1 and parameter[1][@type='org.opencv.core.MatOfPoint2f']]"
		[Register ("fitEllipse", "(Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/RotatedRect;", "")]
		public static unsafe global::OpenCV.Core.RotatedRect FitEllipse (global::OpenCV.Core.MatOfPoint2f p0)
		{
			if (id_fitEllipse_Lorg_opencv_core_MatOfPoint2f_ == IntPtr.Zero)
				id_fitEllipse_Lorg_opencv_core_MatOfPoint2f_ = JNIEnv.GetStaticMethodID (class_ref, "fitEllipse", "(Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/RotatedRect;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.RotatedRect __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.RotatedRect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fitEllipse_Lorg_opencv_core_MatOfPoint2f_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fitLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='fitLine' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("fitLine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDDD)V", "")]
		public static unsafe void FitLine (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, double p3, double p4, double p5)
		{
			if (id_fitLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDD == IntPtr.Zero)
				id_fitLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDD = JNIEnv.GetStaticMethodID (class_ref, "fitLine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDDD)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fitLine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDD, __args);
			} finally {
			}
		}

		static IntPtr id_floodFill_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='floodFill' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar']]"
		[Register ("floodFill", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)I", "")]
		public static unsafe int FloodFill (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3)
		{
			if (id_floodFill_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_floodFill_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "floodFill", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_floodFill_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_floodFill_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_Lorg_opencv_core_Rect_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='floodFill' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='org.opencv.core.Rect'] and parameter[6][@type='org.opencv.core.Scalar'] and parameter[7][@type='org.opencv.core.Scalar'] and parameter[8][@type='int']]"
		[Register ("floodFill", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;Lorg/opencv/core/Rect;Lorg/opencv/core/Scalar;Lorg/opencv/core/Scalar;I)I", "")]
		public static unsafe int FloodFill (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3, global::OpenCV.Core.Rect p4, global::OpenCV.Core.Scalar p5, global::OpenCV.Core.Scalar p6, int p7)
		{
			if (id_floodFill_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_Lorg_opencv_core_Rect_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_floodFill_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_Lorg_opencv_core_Rect_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "floodFill", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;Lorg/opencv/core/Rect;Lorg/opencv/core/Scalar;Lorg/opencv/core/Scalar;I)I");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_floodFill_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_Lorg_opencv_core_Rect_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAffineTransform_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getAffineTransform' and count(parameter)=2 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f']]"
		[Register ("getAffineTransform", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetAffineTransform (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1)
		{
			if (id_getAffineTransform_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ == IntPtr.Zero)
				id_getAffineTransform_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ = JNIEnv.GetStaticMethodID (class_ref, "getAffineTransform", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAffineTransform_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDefaultNewCameraMatrix_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getDefaultNewCameraMatrix' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("getDefaultNewCameraMatrix", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetDefaultNewCameraMatrix (global::OpenCV.Core.Mat p0)
		{
			if (id_getDefaultNewCameraMatrix_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_getDefaultNewCameraMatrix_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "getDefaultNewCameraMatrix", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultNewCameraMatrix_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDefaultNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getDefaultNewCameraMatrix' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='boolean']]"
		[Register ("getDefaultNewCameraMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Z)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetDefaultNewCameraMatrix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, bool p2)
		{
			if (id_getDefaultNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Z == IntPtr.Zero)
				id_getDefaultNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Z = JNIEnv.GetStaticMethodID (class_ref, "getDefaultNewCameraMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Z)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDerivKernels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getDerivKernels' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("getDerivKernels", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V", "")]
		public static unsafe void GetDerivKernels (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4)
		{
			if (id_getDerivKernels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III == IntPtr.Zero)
				id_getDerivKernels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III = JNIEnv.GetStaticMethodID (class_ref, "getDerivKernels", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getDerivKernels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III, __args);
			} finally {
			}
		}

		static IntPtr id_getDerivKernels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getDerivKernels' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='int']]"
		[Register ("getDerivKernels", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIZI)V", "")]
		public static unsafe void GetDerivKernels (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4, bool p5, int p6)
		{
			if (id_getDerivKernels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIZI == IntPtr.Zero)
				id_getDerivKernels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIZI = JNIEnv.GetStaticMethodID (class_ref, "getDerivKernels", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIZI)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getDerivKernels_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIZI, __args);
			} finally {
			}
		}

		static IntPtr id_getGaborKernel_Lorg_opencv_core_Size_DDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getGaborKernel' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register ("getGaborKernel", "(Lorg/opencv/core/Size;DDDD)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetGaborKernel (global::OpenCV.Core.Size p0, double p1, double p2, double p3, double p4)
		{
			if (id_getGaborKernel_Lorg_opencv_core_Size_DDDD == IntPtr.Zero)
				id_getGaborKernel_Lorg_opencv_core_Size_DDDD = JNIEnv.GetStaticMethodID (class_ref, "getGaborKernel", "(Lorg/opencv/core/Size;DDDD)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGaborKernel_Lorg_opencv_core_Size_DDDD, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getGaborKernel_Lorg_opencv_core_Size_DDDDDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getGaborKernel' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='int']]"
		[Register ("getGaborKernel", "(Lorg/opencv/core/Size;DDDDDI)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetGaborKernel (global::OpenCV.Core.Size p0, double p1, double p2, double p3, double p4, double p5, int p6)
		{
			if (id_getGaborKernel_Lorg_opencv_core_Size_DDDDDI == IntPtr.Zero)
				id_getGaborKernel_Lorg_opencv_core_Size_DDDDDI = JNIEnv.GetStaticMethodID (class_ref, "getGaborKernel", "(Lorg/opencv/core/Size;DDDDDI)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGaborKernel_Lorg_opencv_core_Size_DDDDDI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getGaussianKernel_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getGaussianKernel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("getGaussianKernel", "(ID)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetGaussianKernel (int p0, double p1)
		{
			if (id_getGaussianKernel_ID == IntPtr.Zero)
				id_getGaussianKernel_ID = JNIEnv.GetStaticMethodID (class_ref, "getGaussianKernel", "(ID)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGaussianKernel_ID, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getGaussianKernel_IDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getGaussianKernel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("getGaussianKernel", "(IDI)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetGaussianKernel (int p0, double p1, int p2)
		{
			if (id_getGaussianKernel_IDI == IntPtr.Zero)
				id_getGaussianKernel_IDI = JNIEnv.GetStaticMethodID (class_ref, "getGaussianKernel", "(IDI)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGaussianKernel_IDI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getPerspectiveTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getPerspectiveTransform' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("getPerspectiveTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetPerspectiveTransform (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_getPerspectiveTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_getPerspectiveTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "getPerspectiveTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPerspectiveTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRectSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getRectSubPix' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("getRectSubPix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Point;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void GetRectSubPix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Mat p3)
		{
			if (id_getRectSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_getRectSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "getRectSubPix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Point;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getRectSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_getRectSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getRectSubPix' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int']]"
		[Register ("getRectSubPix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Point;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void GetRectSubPix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Mat p3, int p4)
		{
			if (id_getRectSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_getRectSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "getRectSubPix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Point;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getRectSubPix_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_getRotationMatrix2D_Lorg_opencv_core_Point_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getRotationMatrix2D' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Point'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("getRotationMatrix2D", "(Lorg/opencv/core/Point;DD)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetRotationMatrix2D (global::OpenCV.Core.Point p0, double p1, double p2)
		{
			if (id_getRotationMatrix2D_Lorg_opencv_core_Point_DD == IntPtr.Zero)
				id_getRotationMatrix2D_Lorg_opencv_core_Point_DD = JNIEnv.GetStaticMethodID (class_ref, "getRotationMatrix2D", "(Lorg/opencv/core/Point;DD)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRotationMatrix2D_Lorg_opencv_core_Point_DD, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getStructuringElement_ILorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getStructuringElement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.opencv.core.Size']]"
		[Register ("getStructuringElement", "(ILorg/opencv/core/Size;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetStructuringElement (int p0, global::OpenCV.Core.Size p1)
		{
			if (id_getStructuringElement_ILorg_opencv_core_Size_ == IntPtr.Zero)
				id_getStructuringElement_ILorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "getStructuringElement", "(ILorg/opencv/core/Size;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStructuringElement_ILorg_opencv_core_Size_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getStructuringElement_ILorg_opencv_core_Size_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getStructuringElement' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.Point']]"
		[Register ("getStructuringElement", "(ILorg/opencv/core/Size;Lorg/opencv/core/Point;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetStructuringElement (int p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.Point p2)
		{
			if (id_getStructuringElement_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_getStructuringElement_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ = JNIEnv.GetStaticMethodID (class_ref, "getStructuringElement", "(ILorg/opencv/core/Size;Lorg/opencv/core/Point;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStructuringElement_ILorg_opencv_core_Size_Lorg_opencv_core_Point_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTextSize_Ljava_lang_String_IDIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='getTextSize' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='int'] and parameter[5][@type='int[]']]"
		[Register ("getTextSize", "(Ljava/lang/String;IDI[I)Lorg/opencv/core/Size;", "")]
		public static unsafe global::OpenCV.Core.Size GetTextSize (string p0, int p1, double p2, int p3, int[] p4)
		{
			if (id_getTextSize_Ljava_lang_String_IDIarrayI == IntPtr.Zero)
				id_getTextSize_Ljava_lang_String_IDIarrayI = JNIEnv.GetStaticMethodID (class_ref, "getTextSize", "(Ljava/lang/String;IDI[I)Lorg/opencv/core/Size;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				global::OpenCV.Core.Size __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTextSize_Ljava_lang_String_IDIarrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static IntPtr id_goodFeaturesToTrack_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='goodFeaturesToTrack' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfPoint'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register ("goodFeaturesToTrack", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;IDD)V", "")]
		public static unsafe void GoodFeaturesToTrack (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfPoint p1, int p2, double p3, double p4)
		{
			if (id_goodFeaturesToTrack_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_IDD == IntPtr.Zero)
				id_goodFeaturesToTrack_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_IDD = JNIEnv.GetStaticMethodID (class_ref, "goodFeaturesToTrack", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;IDD)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_goodFeaturesToTrack_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_IDD, __args);
			} finally {
			}
		}

		static IntPtr id_goodFeaturesToTrack_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_IDDLorg_opencv_core_Mat_IZD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='goodFeaturesToTrack' and count(parameter)=9 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfPoint'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='int'] and parameter[8][@type='boolean'] and parameter[9][@type='double']]"
		[Register ("goodFeaturesToTrack", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;IDDLorg/opencv/core/Mat;IZD)V", "")]
		public static unsafe void GoodFeaturesToTrack (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfPoint p1, int p2, double p3, double p4, global::OpenCV.Core.Mat p5, int p6, bool p7, double p8)
		{
			if (id_goodFeaturesToTrack_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_IDDLorg_opencv_core_Mat_IZD == IntPtr.Zero)
				id_goodFeaturesToTrack_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_IDDLorg_opencv_core_Mat_IZD = JNIEnv.GetStaticMethodID (class_ref, "goodFeaturesToTrack", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;IDDLorg/opencv/core/Mat;IZD)V");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_goodFeaturesToTrack_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_IDDLorg_opencv_core_Mat_IZD, __args);
			} finally {
			}
		}

		static IntPtr id_grabCut_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='grabCut' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Rect'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='int']]"
		[Register ("grabCut", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void GrabCut (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Rect p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, int p5)
		{
			if (id_grabCut_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_grabCut_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "grabCut", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_grabCut_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_grabCut_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='grabCut' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Rect'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("grabCut", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void GrabCut (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Rect p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, int p5, int p6)
		{
			if (id_grabCut_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_grabCut_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "grabCut", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_grabCut_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_initUndistortRectifyMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='initUndistortRectifyMap' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Size'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Mat']]"
		[Register ("initUndistortRectifyMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void InitUndistortRectifyMap (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Size p4, int p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Mat p7)
		{
			if (id_initUndistortRectifyMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_initUndistortRectifyMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "initUndistortRectifyMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initUndistortRectifyMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_initWideAngleProjMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='initWideAngleProjMap' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat']]"
		[Register ("initWideAngleProjMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;IILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)F", "")]
		public static unsafe float InitWideAngleProjMap (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, int p3, int p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6)
		{
			if (id_initWideAngleProjMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_initWideAngleProjMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "initWideAngleProjMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;IILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)F");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_initWideAngleProjMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initWideAngleProjMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='initWideAngleProjMap' and count(parameter)=9 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='int'] and parameter[9][@type='double']]"
		[Register ("initWideAngleProjMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;IILorg/opencv/core/Mat;Lorg/opencv/core/Mat;ID)F", "")]
		public static unsafe float InitWideAngleProjMap (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, int p3, int p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, int p7, double p8)
		{
			if (id_initWideAngleProjMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ID == IntPtr.Zero)
				id_initWideAngleProjMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ID = JNIEnv.GetStaticMethodID (class_ref, "initWideAngleProjMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;IILorg/opencv/core/Mat;Lorg/opencv/core/Mat;ID)F");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_initWideAngleProjMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ID, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_integral2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='integral2' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("integral2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Integral2 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_integral2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_integral2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "integral2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_integral2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_integral2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='integral2' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("integral2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void Integral2 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, int p4)
		{
			if (id_integral2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_integral2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "integral2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_integral2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_integral3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='integral3' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("integral3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Integral3 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_integral3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_integral3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "integral3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_integral3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_integral3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='integral3' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("integral3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void Integral3 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4, int p5)
		{
			if (id_integral3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_integral3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "integral3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_integral3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_integral_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='integral' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("integral", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Integral (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_integral_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_integral_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "integral", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_integral_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_integral_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='integral' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("integral", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Integral (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_integral_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_integral_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "integral", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_integral_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_intersectConvexConvex_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='intersectConvexConvex' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("intersectConvexConvex", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)F", "")]
		public static unsafe float IntersectConvexConvex (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_intersectConvexConvex_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_intersectConvexConvex_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "intersectConvexConvex", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)F");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_intersectConvexConvex_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_intersectConvexConvex_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='intersectConvexConvex' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='boolean']]"
		[Register ("intersectConvexConvex", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)F", "")]
		public static unsafe float IntersectConvexConvex (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, bool p3)
		{
			if (id_intersectConvexConvex_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_intersectConvexConvex_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "intersectConvexConvex", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)F");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_intersectConvexConvex_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_invertAffineTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='invertAffineTransform' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("invertAffineTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void InvertAffineTransform (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_invertAffineTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_invertAffineTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "invertAffineTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_invertAffineTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_isContourConvex_Lorg_opencv_core_MatOfPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='isContourConvex' and count(parameter)=1 and parameter[1][@type='org.opencv.core.MatOfPoint']]"
		[Register ("isContourConvex", "(Lorg/opencv/core/MatOfPoint;)Z", "")]
		public static unsafe bool IsContourConvex (global::OpenCV.Core.MatOfPoint p0)
		{
			if (id_isContourConvex_Lorg_opencv_core_MatOfPoint_ == IntPtr.Zero)
				id_isContourConvex_Lorg_opencv_core_MatOfPoint_ = JNIEnv.GetStaticMethodID (class_ref, "isContourConvex", "(Lorg/opencv/core/MatOfPoint;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isContourConvex_Lorg_opencv_core_MatOfPoint_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='line' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar']]"
		[Register ("line", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)V", "")]
		public static unsafe void Line (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3)
		{
			if (id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "line", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='line' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int']]"
		[Register ("line", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;I)V", "")]
		public static unsafe void Line (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3, int p4)
		{
			if (id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "line", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_I, __args);
			} finally {
			}
		}

		static IntPtr id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='line' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("line", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;III)V", "")]
		public static unsafe void Line (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3, int p4, int p5, int p6)
		{
			if (id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_III == IntPtr.Zero)
				id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_III = JNIEnv.GetStaticMethodID (class_ref, "line", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;III)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_line_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_III, __args);
			} finally {
			}
		}

		static IntPtr id_linearPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='linearPolar' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("linearPolar", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;DI)V", "")]
		public static unsafe void LinearPolar (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Point p2, double p3, int p4)
		{
			if (id_linearPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI == IntPtr.Zero)
				id_linearPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI = JNIEnv.GetStaticMethodID (class_ref, "linearPolar", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;DI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_linearPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI, __args);
			} finally {
			}
		}

		static IntPtr id_logPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='logPolar' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("logPolar", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;DI)V", "")]
		public static unsafe void LogPolar (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Point p2, double p3, int p4)
		{
			if (id_logPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI == IntPtr.Zero)
				id_logPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI = JNIEnv.GetStaticMethodID (class_ref, "logPolar", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;DI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI, __args);
			} finally {
			}
		}

		static IntPtr id_matchShapes_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='matchShapes' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='double']]"
		[Register ("matchShapes", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ID)D", "")]
		public static unsafe double MatchShapes (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, double p3)
		{
			if (id_matchShapes_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ID == IntPtr.Zero)
				id_matchShapes_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ID = JNIEnv.GetStaticMethodID (class_ref, "matchShapes", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ID)D");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_matchShapes_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ID, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_matchTemplate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='matchTemplate' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("matchTemplate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void MatchTemplate (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_matchTemplate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_matchTemplate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "matchTemplate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_matchTemplate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_matchTemplate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='matchTemplate' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("matchTemplate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)V", "")]
		public static unsafe void MatchTemplate (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, global::OpenCV.Core.Mat p4)
		{
			if (id_matchTemplate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_matchTemplate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "matchTemplate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_matchTemplate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_medianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='medianBlur' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("medianBlur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void MedianBlur (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_medianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_medianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "medianBlur", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_medianBlur_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_minAreaRect_Lorg_opencv_core_MatOfPoint2f_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='minAreaRect' and count(parameter)=1 and parameter[1][@type='org.opencv.core.MatOfPoint2f']]"
		[Register ("minAreaRect", "(Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/RotatedRect;", "")]
		public static unsafe global::OpenCV.Core.RotatedRect MinAreaRect (global::OpenCV.Core.MatOfPoint2f p0)
		{
			if (id_minAreaRect_Lorg_opencv_core_MatOfPoint2f_ == IntPtr.Zero)
				id_minAreaRect_Lorg_opencv_core_MatOfPoint2f_ = JNIEnv.GetStaticMethodID (class_ref, "minAreaRect", "(Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/RotatedRect;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.RotatedRect __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.RotatedRect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_minAreaRect_Lorg_opencv_core_MatOfPoint2f_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_minEnclosingCircle_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Point_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='minEnclosingCircle' and count(parameter)=3 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='float[]']]"
		[Register ("minEnclosingCircle", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Point;[F)V", "")]
		public static unsafe void MinEnclosingCircle (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.Point p1, float[] p2)
		{
			if (id_minEnclosingCircle_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Point_arrayF == IntPtr.Zero)
				id_minEnclosingCircle_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Point_arrayF = JNIEnv.GetStaticMethodID (class_ref, "minEnclosingCircle", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Point;[F)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_minEnclosingCircle_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Point_arrayF, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_minEnclosingTriangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='minEnclosingTriangle' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("minEnclosingTriangle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double MinEnclosingTriangle (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_minEnclosingTriangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_minEnclosingTriangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "minEnclosingTriangle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_minEnclosingTriangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_moments_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='moments' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("moments", "(Lorg/opencv/core/Mat;)Lorg/opencv/imgproc/Moments;", "")]
		public static unsafe global::OpenCV.ImgProc.Moments Moments (global::OpenCV.Core.Mat p0)
		{
			if (id_moments_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_moments_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "moments", "(Lorg/opencv/core/Mat;)Lorg/opencv/imgproc/Moments;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.ImgProc.Moments __ret = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (JNIEnv.CallStaticObjectMethod  (class_ref, id_moments_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_moments_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='moments' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='boolean']]"
		[Register ("moments", "(Lorg/opencv/core/Mat;Z)Lorg/opencv/imgproc/Moments;", "")]
		public static unsafe global::OpenCV.ImgProc.Moments Moments (global::OpenCV.Core.Mat p0, bool p1)
		{
			if (id_moments_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_moments_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "moments", "(Lorg/opencv/core/Mat;Z)Lorg/opencv/imgproc/Moments;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.ImgProc.Moments __ret = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (JNIEnv.CallStaticObjectMethod  (class_ref, id_moments_Lorg_opencv_core_Mat_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='morphologyEx' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("morphologyEx", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)V", "")]
		public static unsafe void MorphologyEx (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3)
		{
			if (id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "morphologyEx", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='morphologyEx' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Point'] and parameter[6][@type='int']]"
		[Register ("morphologyEx", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Point;I)V", "")]
		public static unsafe void MorphologyEx (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Point p4, int p5)
		{
			if (id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_I == IntPtr.Zero)
				id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_I = JNIEnv.GetStaticMethodID (class_ref, "morphologyEx", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Point;I)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_I, __args);
			} finally {
			}
		}

		static IntPtr id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='morphologyEx' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Point'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='org.opencv.core.Scalar']]"
		[Register ("morphologyEx", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Point;IILorg/opencv/core/Scalar;)V", "")]
		public static unsafe void MorphologyEx (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Point p4, int p5, int p6, global::OpenCV.Core.Scalar p7)
		{
			if (id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "morphologyEx", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Point;IILorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_morphologyEx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Point_IILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_phaseCorrelate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='phaseCorrelate' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("phaseCorrelate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Point;", "")]
		public static unsafe global::OpenCV.Core.Point PhaseCorrelate (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_phaseCorrelate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_phaseCorrelate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "phaseCorrelate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Point;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Point __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_phaseCorrelate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_phaseCorrelate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='phaseCorrelate' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double[]']]"
		[Register ("phaseCorrelate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;[D)Lorg/opencv/core/Point;", "")]
		public static unsafe global::OpenCV.Core.Point PhaseCorrelate (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, double[] p3)
		{
			if (id_phaseCorrelate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_arrayD == IntPtr.Zero)
				id_phaseCorrelate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_arrayD = JNIEnv.GetStaticMethodID (class_ref, "phaseCorrelate", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;[D)Lorg/opencv/core/Point;");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::OpenCV.Core.Point __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_phaseCorrelate_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_arrayD, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_pointPolygonTest_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Point_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='pointPolygonTest' and count(parameter)=3 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='boolean']]"
		[Register ("pointPolygonTest", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Point;Z)D", "")]
		public static unsafe double PointPolygonTest (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.Point p1, bool p2)
		{
			if (id_pointPolygonTest_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Point_Z == IntPtr.Zero)
				id_pointPolygonTest_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Point_Z = JNIEnv.GetStaticMethodID (class_ref, "pointPolygonTest", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Point;Z)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_pointPolygonTest_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Point_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='polylines' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='org.opencv.core.Scalar']]"
		[Register ("polylines", "(Lorg/opencv/core/Mat;Ljava/util/List;ZLorg/opencv/core/Scalar;)V", "")]
		public static unsafe void Polylines (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, bool p2, global::OpenCV.Core.Scalar p3)
		{
			if (id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "polylines", "(Lorg/opencv/core/Mat;Ljava/util/List;ZLorg/opencv/core/Scalar;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='polylines' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int']]"
		[Register ("polylines", "(Lorg/opencv/core/Mat;Ljava/util/List;ZLorg/opencv/core/Scalar;I)V", "")]
		public static unsafe void Polylines (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, bool p2, global::OpenCV.Core.Scalar p3, int p4)
		{
			if (id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "polylines", "(Lorg/opencv/core/Mat;Ljava/util/List;ZLorg/opencv/core/Scalar;I)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='polylines' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("polylines", "(Lorg/opencv/core/Mat;Ljava/util/List;ZLorg/opencv/core/Scalar;III)V", "")]
		public static unsafe void Polylines (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1, bool p2, global::OpenCV.Core.Scalar p3, int p4, int p5, int p6)
		{
			if (id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_III == IntPtr.Zero)
				id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_III = JNIEnv.GetStaticMethodID (class_ref, "polylines", "(Lorg/opencv/core/Mat;Ljava/util/List;ZLorg/opencv/core/Scalar;III)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_polylines_Lorg_opencv_core_Mat_Ljava_util_List_ZLorg_opencv_core_Scalar_III, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_preCornerDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='preCornerDetect' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("preCornerDetect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void PreCornerDetect (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_preCornerDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_preCornerDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "preCornerDetect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_preCornerDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_preCornerDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='preCornerDetect' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("preCornerDetect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void PreCornerDetect (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_preCornerDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_preCornerDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "preCornerDetect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_preCornerDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='putText' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='int'] and parameter[5][@type='double'] and parameter[6][@type='org.opencv.core.Scalar']]"
		[Register ("putText", "(Lorg/opencv/core/Mat;Ljava/lang/String;Lorg/opencv/core/Point;IDLorg/opencv/core/Scalar;)V", "")]
		public static unsafe void PutText (global::OpenCV.Core.Mat p0, string p1, global::OpenCV.Core.Point p2, int p3, double p4, global::OpenCV.Core.Scalar p5)
		{
			if (id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "putText", "(Lorg/opencv/core/Mat;Ljava/lang/String;Lorg/opencv/core/Point;IDLorg/opencv/core/Scalar;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='putText' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='int'] and parameter[5][@type='double'] and parameter[6][@type='org.opencv.core.Scalar'] and parameter[7][@type='int']]"
		[Register ("putText", "(Lorg/opencv/core/Mat;Ljava/lang/String;Lorg/opencv/core/Point;IDLorg/opencv/core/Scalar;I)V", "")]
		public static unsafe void PutText (global::OpenCV.Core.Mat p0, string p1, global::OpenCV.Core.Point p2, int p3, double p4, global::OpenCV.Core.Scalar p5, int p6)
		{
			if (id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "putText", "(Lorg/opencv/core/Mat;Ljava/lang/String;Lorg/opencv/core/Point;IDLorg/opencv/core/Scalar;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='putText' and count(parameter)=9 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='int'] and parameter[5][@type='double'] and parameter[6][@type='org.opencv.core.Scalar'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='boolean']]"
		[Register ("putText", "(Lorg/opencv/core/Mat;Ljava/lang/String;Lorg/opencv/core/Point;IDLorg/opencv/core/Scalar;IIZ)V", "")]
		public static unsafe void PutText (global::OpenCV.Core.Mat p0, string p1, global::OpenCV.Core.Point p2, int p3, double p4, global::OpenCV.Core.Scalar p5, int p6, int p7, bool p8)
		{
			if (id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_IIZ == IntPtr.Zero)
				id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_IIZ = JNIEnv.GetStaticMethodID (class_ref, "putText", "(Lorg/opencv/core/Mat;Ljava/lang/String;Lorg/opencv/core/Point;IDLorg/opencv/core/Scalar;IIZ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_putText_Lorg_opencv_core_Mat_Ljava_lang_String_Lorg_opencv_core_Point_IDLorg_opencv_core_Scalar_IIZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='pyrDown' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("pyrDown", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void PyrDown (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "pyrDown", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='pyrDown' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size']]"
		[Register ("pyrDown", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V", "")]
		public static unsafe void PyrDown (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2)
		{
			if (id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "pyrDown", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='pyrDown' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='int']]"
		[Register ("pyrDown", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V", "")]
		public static unsafe void PyrDown (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, int p3)
		{
			if (id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "pyrDown", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pyrDown_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I, __args);
			} finally {
			}
		}

		static IntPtr id_pyrMeanShiftFiltering_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='pyrMeanShiftFiltering' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("pyrMeanShiftFiltering", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DD)V", "")]
		public static unsafe void PyrMeanShiftFiltering (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3)
		{
			if (id_pyrMeanShiftFiltering_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD == IntPtr.Zero)
				id_pyrMeanShiftFiltering_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD = JNIEnv.GetStaticMethodID (class_ref, "pyrMeanShiftFiltering", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DD)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pyrMeanShiftFiltering_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD, __args);
			} finally {
			}
		}

		static IntPtr id_pyrMeanShiftFiltering_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDILorg_opencv_core_TermCriteria_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='pyrMeanShiftFiltering' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int'] and parameter[6][@type='org.opencv.core.TermCriteria']]"
		[Register ("pyrMeanShiftFiltering", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDILorg/opencv/core/TermCriteria;)V", "")]
		public static unsafe void PyrMeanShiftFiltering (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4, global::OpenCV.Core.TermCriteria p5)
		{
			if (id_pyrMeanShiftFiltering_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDILorg_opencv_core_TermCriteria_ == IntPtr.Zero)
				id_pyrMeanShiftFiltering_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDILorg_opencv_core_TermCriteria_ = JNIEnv.GetStaticMethodID (class_ref, "pyrMeanShiftFiltering", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDILorg/opencv/core/TermCriteria;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pyrMeanShiftFiltering_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDILorg_opencv_core_TermCriteria_, __args);
			} finally {
			}
		}

		static IntPtr id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='pyrUp' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("pyrUp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void PyrUp (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "pyrUp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='pyrUp' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size']]"
		[Register ("pyrUp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V", "")]
		public static unsafe void PyrUp (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2)
		{
			if (id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "pyrUp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='pyrUp' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='int']]"
		[Register ("pyrUp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V", "")]
		public static unsafe void PyrUp (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, int p3)
		{
			if (id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "pyrUp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pyrUp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I, __args);
			} finally {
			}
		}

		static IntPtr id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='rectangle' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar']]"
		[Register ("rectangle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)V", "")]
		public static unsafe void Rectangle (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3)
		{
			if (id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "rectangle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='rectangle' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int']]"
		[Register ("rectangle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;I)V", "")]
		public static unsafe void Rectangle (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3, int p4)
		{
			if (id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "rectangle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_I, __args);
			} finally {
			}
		}

		static IntPtr id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='rectangle' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Point'] and parameter[3][@type='org.opencv.core.Point'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("rectangle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;III)V", "")]
		public static unsafe void Rectangle (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Point p1, global::OpenCV.Core.Point p2, global::OpenCV.Core.Scalar p3, int p4, int p5, int p6)
		{
			if (id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_III == IntPtr.Zero)
				id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_III = JNIEnv.GetStaticMethodID (class_ref, "rectangle", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Point;Lorg/opencv/core/Scalar;III)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_rectangle_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Lorg_opencv_core_Scalar_III, __args);
			} finally {
			}
		}

		static IntPtr id_remap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='remap' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int']]"
		[Register ("remap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Remap (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4)
		{
			if (id_remap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_remap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "remap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_remap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_remap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IILorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='remap' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Scalar']]"
		[Register ("remap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IILorg/opencv/core/Scalar;)V", "")]
		public static unsafe void Remap (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4, int p5, global::OpenCV.Core.Scalar p6)
		{
			if (id_remap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IILorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_remap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IILorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "remap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IILorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_remap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_resize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='resize' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size']]"
		[Register ("resize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V", "")]
		public static unsafe void Resize (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2)
		{
			if (id_resize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_resize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "resize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_resize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_resize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='resize' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='int']]"
		[Register ("resize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DDI)V", "")]
		public static unsafe void Resize (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, double p3, double p4, int p5)
		{
			if (id_resize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDI == IntPtr.Zero)
				id_resize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDI = JNIEnv.GetStaticMethodID (class_ref, "resize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DDI)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_resize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDI, __args);
			} finally {
			}
		}

		static IntPtr id_rotatedRectangleIntersection_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='rotatedRectangleIntersection' and count(parameter)=3 and parameter[1][@type='org.opencv.core.RotatedRect'] and parameter[2][@type='org.opencv.core.RotatedRect'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("rotatedRectangleIntersection", "(Lorg/opencv/core/RotatedRect;Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int RotatedRectangleIntersection (global::OpenCV.Core.RotatedRect p0, global::OpenCV.Core.RotatedRect p1, global::OpenCV.Core.Mat p2)
		{
			if (id_rotatedRectangleIntersection_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_rotatedRectangleIntersection_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "rotatedRectangleIntersection", "(Lorg/opencv/core/RotatedRect;Lorg/opencv/core/RotatedRect;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_rotatedRectangleIntersection_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_RotatedRect_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='sepFilter2D' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("sepFilter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void SepFilter2D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "sepFilter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='sepFilter2D' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Point'] and parameter[7][@type='double']]"
		[Register ("sepFilter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;D)V", "")]
		public static unsafe void SepFilter2D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Point p5, double p6)
		{
			if (id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_D == IntPtr.Zero)
				id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_D = JNIEnv.GetStaticMethodID (class_ref, "sepFilter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;D)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_D, __args);
			} finally {
			}
		}

		static IntPtr id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='sepFilter2D' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Point'] and parameter[7][@type='double'] and parameter[8][@type='int']]"
		[Register ("sepFilter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;DI)V", "")]
		public static unsafe void SepFilter2D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Point p5, double p6, int p7)
		{
			if (id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI == IntPtr.Zero)
				id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI = JNIEnv.GetStaticMethodID (class_ref, "sepFilter2D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;DI)V");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sepFilter2D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_DI, __args);
			} finally {
			}
		}

		static IntPtr id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='spatialGradient' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("spatialGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void SpatialGradient (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "spatialGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='spatialGradient' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("spatialGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void SpatialGradient (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "spatialGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='spatialGradient' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("spatialGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void SpatialGradient (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, int p4)
		{
			if (id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "spatialGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_spatialGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='sqrBoxFilter' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Size']]"
		[Register ("sqrBoxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;)V", "")]
		public static unsafe void SqrBoxFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Size p3)
		{
			if (id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_ == IntPtr.Zero)
				id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "sqrBoxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='sqrBoxFilter' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='org.opencv.core.Point'] and parameter[6][@type='boolean']]"
		[Register ("sqrBoxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;Lorg/opencv/core/Point;Z)V", "")]
		public static unsafe void SqrBoxFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Size p3, global::OpenCV.Core.Point p4, bool p5)
		{
			if (id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_Z == IntPtr.Zero)
				id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_Z = JNIEnv.GetStaticMethodID (class_ref, "sqrBoxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;Lorg/opencv/core/Point;Z)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_Z, __args);
			} finally {
			}
		}

		static IntPtr id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='sqrBoxFilter' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='org.opencv.core.Point'] and parameter[6][@type='boolean'] and parameter[7][@type='int']]"
		[Register ("sqrBoxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;Lorg/opencv/core/Point;ZI)V", "")]
		public static unsafe void SqrBoxFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Size p3, global::OpenCV.Core.Point p4, bool p5, int p6)
		{
			if (id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ZI == IntPtr.Zero)
				id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ZI = JNIEnv.GetStaticMethodID (class_ref, "sqrBoxFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Size;Lorg/opencv/core/Point;ZI)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sqrBoxFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Size_Lorg_opencv_core_Point_ZI, __args);
			} finally {
			}
		}

		static IntPtr id_threshold_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='threshold' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("threshold", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDI)D", "")]
		public static unsafe double Threshold (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4)
		{
			if (id_threshold_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI == IntPtr.Zero)
				id_threshold_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI = JNIEnv.GetStaticMethodID (class_ref, "threshold", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDI)D");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_threshold_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_undistort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='undistort' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("undistort", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Undistort (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_undistort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_undistort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "undistort", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_undistort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_undistort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='undistort' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("undistort", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Undistort (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_undistort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_undistort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "undistort", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_undistort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_undistortPoints_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='undistortPoints' and count(parameter)=4 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("undistortPoints", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void UndistortPoints (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_undistortPoints_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_undistortPoints_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "undistortPoints", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_undistortPoints_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_undistortPoints_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='undistortPoints' and count(parameter)=6 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("undistortPoints", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void UndistortPoints (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5)
		{
			if (id_undistortPoints_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_undistortPoints_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "undistortPoints", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_undistortPoints_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='warpAffine' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Size']]"
		[Register ("warpAffine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V", "")]
		public static unsafe void WarpAffine (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Size p3)
		{
			if (id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "warpAffine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='warpAffine' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='int']]"
		[Register ("warpAffine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V", "")]
		public static unsafe void WarpAffine (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Size p3, int p4)
		{
			if (id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "warpAffine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I, __args);
			} finally {
			}
		}

		static IntPtr id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='warpAffine' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Scalar']]"
		[Register ("warpAffine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;IILorg/opencv/core/Scalar;)V", "")]
		public static unsafe void WarpAffine (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Size p3, int p4, int p5, global::OpenCV.Core.Scalar p6)
		{
			if (id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "warpAffine", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;IILorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_warpAffine_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='warpPerspective' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Size']]"
		[Register ("warpPerspective", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V", "")]
		public static unsafe void WarpPerspective (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Size p3)
		{
			if (id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "warpPerspective", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='warpPerspective' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='int']]"
		[Register ("warpPerspective", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V", "")]
		public static unsafe void WarpPerspective (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Size p3, int p4)
		{
			if (id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "warpPerspective", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_I, __args);
			} finally {
			}
		}

		static IntPtr id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='warpPerspective' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Scalar']]"
		[Register ("warpPerspective", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;IILorg/opencv/core/Scalar;)V", "")]
		public static unsafe void WarpPerspective (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Size p3, int p4, int p5, global::OpenCV.Core.Scalar p6)
		{
			if (id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "warpPerspective", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;IILorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_warpPerspective_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_IILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_watershed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Imgproc']/method[@name='watershed' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("watershed", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Watershed (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_watershed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_watershed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "watershed", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_watershed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

	}
}
