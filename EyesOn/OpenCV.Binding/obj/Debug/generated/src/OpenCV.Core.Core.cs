using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']"
	[global::Android.Runtime.Register ("org/opencv/core/Core", DoNotGenerateAcw=true)]
	public partial class Core : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BORDER_CONSTANT']"
		[Register ("BORDER_CONSTANT")]
		public const int BorderConstant = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BORDER_DEFAULT']"
		[Register ("BORDER_DEFAULT")]
		public const int BorderDefault = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BORDER_ISOLATED']"
		[Register ("BORDER_ISOLATED")]
		public const int BorderIsolated = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BORDER_REFLECT']"
		[Register ("BORDER_REFLECT")]
		public const int BorderReflect = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BORDER_REFLECT101']"
		[Register ("BORDER_REFLECT101")]
		public const int BorderReflect101 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BORDER_REPLICATE']"
		[Register ("BORDER_REPLICATE")]
		public const int BorderReplicate = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BORDER_TRANSPARENT']"
		[Register ("BORDER_TRANSPARENT")]
		public const int BorderTransparent = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BORDER_WRAP']"
		[Register ("BORDER_WRAP")]
		public const int BorderWrap = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadAlign']"
		[Register ("BadAlign")]
		public const int BadAlign = (int) -21;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadAlphaChannel']"
		[Register ("BadAlphaChannel")]
		public const int BadAlphaChannel = (int) -18;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadCOI']"
		[Register ("BadCOI")]
		public const int BadCOI = (int) -24;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadCallBack']"
		[Register ("BadCallBack")]
		public const int BadCallBack = (int) -22;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadDataPtr']"
		[Register ("BadDataPtr")]
		public const int BadDataPtr = (int) -12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadDepth']"
		[Register ("BadDepth")]
		public const int BadDepth = (int) -17;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadImageSize']"
		[Register ("BadImageSize")]
		public const int BadImageSize = (int) -10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadModelOrChSeq']"
		[Register ("BadModelOrChSeq")]
		public const int BadModelOrChSeq = (int) -14;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadNumChannel1U']"
		[Register ("BadNumChannel1U")]
		public const int BadNumChannel1U = (int) -16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadNumChannels']"
		[Register ("BadNumChannels")]
		public const int BadNumChannels = (int) -15;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadOffset']"
		[Register ("BadOffset")]
		public const int BadOffset = (int) -11;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadOrder']"
		[Register ("BadOrder")]
		public const int BadOrder = (int) -19;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadOrigin']"
		[Register ("BadOrigin")]
		public const int BadOrigin = (int) -20;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadROISize']"
		[Register ("BadROISize")]
		public const int BadROISize = (int) -25;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadStep']"
		[Register ("BadStep")]
		public const int BadStep = (int) -13;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='BadTileSize']"
		[Register ("BadTileSize")]
		public const int BadTileSize = (int) -23;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='CMP_EQ']"
		[Register ("CMP_EQ")]
		public const int CmpEq = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='CMP_GE']"
		[Register ("CMP_GE")]
		public const int CmpGe = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='CMP_GT']"
		[Register ("CMP_GT")]
		public const int CmpGt = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='CMP_LE']"
		[Register ("CMP_LE")]
		public const int CmpLe = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='CMP_LT']"
		[Register ("CMP_LT")]
		public const int CmpLt = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='CMP_NE']"
		[Register ("CMP_NE")]
		public const int CmpNe = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='COVAR_COLS']"
		[Register ("COVAR_COLS")]
		public const int CovarCols = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='COVAR_NORMAL']"
		[Register ("COVAR_NORMAL")]
		public const int CovarNormal = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='COVAR_ROWS']"
		[Register ("COVAR_ROWS")]
		public const int CovarRows = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='COVAR_SCALE']"
		[Register ("COVAR_SCALE")]
		public const int CovarScale = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='COVAR_SCRAMBLED']"
		[Register ("COVAR_SCRAMBLED")]
		public const int CovarScrambled = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='COVAR_USE_AVG']"
		[Register ("COVAR_USE_AVG")]
		public const int CovarUseAvg = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DCT_INVERSE']"
		[Register ("DCT_INVERSE")]
		public const int DctInverse = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DCT_ROWS']"
		[Register ("DCT_ROWS")]
		public const int DctRows = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DECOMP_CHOLESKY']"
		[Register ("DECOMP_CHOLESKY")]
		public const int DecompCholesky = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DECOMP_EIG']"
		[Register ("DECOMP_EIG")]
		public const int DecompEig = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DECOMP_LU']"
		[Register ("DECOMP_LU")]
		public const int DecompLu = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DECOMP_NORMAL']"
		[Register ("DECOMP_NORMAL")]
		public const int DecompNormal = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DECOMP_QR']"
		[Register ("DECOMP_QR")]
		public const int DecompQr = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DECOMP_SVD']"
		[Register ("DECOMP_SVD")]
		public const int DecompSvd = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DFT_COMPLEX_OUTPUT']"
		[Register ("DFT_COMPLEX_OUTPUT")]
		public const int DftComplexOutput = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DFT_INVERSE']"
		[Register ("DFT_INVERSE")]
		public const int DftInverse = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DFT_REAL_OUTPUT']"
		[Register ("DFT_REAL_OUTPUT")]
		public const int DftRealOutput = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DFT_ROWS']"
		[Register ("DFT_ROWS")]
		public const int DftRows = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='DFT_SCALE']"
		[Register ("DFT_SCALE")]
		public const int DftScale = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FILLED']"
		[Register ("FILLED")]
		public const int Filled = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FONT_HERSHEY_COMPLEX']"
		[Register ("FONT_HERSHEY_COMPLEX")]
		public const int FontHersheyComplex = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FONT_HERSHEY_COMPLEX_SMALL']"
		[Register ("FONT_HERSHEY_COMPLEX_SMALL")]
		public const int FontHersheyComplexSmall = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FONT_HERSHEY_DUPLEX']"
		[Register ("FONT_HERSHEY_DUPLEX")]
		public const int FontHersheyDuplex = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FONT_HERSHEY_PLAIN']"
		[Register ("FONT_HERSHEY_PLAIN")]
		public const int FontHersheyPlain = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FONT_HERSHEY_SCRIPT_COMPLEX']"
		[Register ("FONT_HERSHEY_SCRIPT_COMPLEX")]
		public const int FontHersheyScriptComplex = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FONT_HERSHEY_SCRIPT_SIMPLEX']"
		[Register ("FONT_HERSHEY_SCRIPT_SIMPLEX")]
		public const int FontHersheyScriptSimplex = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FONT_HERSHEY_SIMPLEX']"
		[Register ("FONT_HERSHEY_SIMPLEX")]
		public const int FontHersheySimplex = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FONT_HERSHEY_TRIPLEX']"
		[Register ("FONT_HERSHEY_TRIPLEX")]
		public const int FontHersheyTriplex = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='FONT_ITALIC']"
		[Register ("FONT_ITALIC")]
		public const int FontItalic = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='GEMM_1_T']"
		[Register ("GEMM_1_T")]
		public const int Gemm1T = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='GEMM_2_T']"
		[Register ("GEMM_2_T")]
		public const int Gemm2T = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='GEMM_3_T']"
		[Register ("GEMM_3_T")]
		public const int Gemm3T = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='GpuApiCallError']"
		[Register ("GpuApiCallError")]
		public const int GpuApiCallError = (int) -217;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='GpuNotSupported']"
		[Register ("GpuNotSupported")]
		public const int GpuNotSupported = (int) -216;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='HeaderIsNull']"
		[Register ("HeaderIsNull")]
		public const int HeaderIsNull = (int) -9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='KMEANS_PP_CENTERS']"
		[Register ("KMEANS_PP_CENTERS")]
		public const int KmeansPpCenters = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='KMEANS_RANDOM_CENTERS']"
		[Register ("KMEANS_RANDOM_CENTERS")]
		public const int KmeansRandomCenters = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='KMEANS_USE_INITIAL_LABELS']"
		[Register ("KMEANS_USE_INITIAL_LABELS")]
		public const int KmeansUseInitialLabels = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='LINE_4']"
		[Register ("LINE_4")]
		public const int Line4 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='LINE_8']"
		[Register ("LINE_8")]
		public const int Line8 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='LINE_AA']"
		[Register ("LINE_AA")]
		public const int LineAa = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='MaskIsTiled']"
		[Register ("MaskIsTiled")]
		public const int MaskIsTiled = (int) -26;

		static IntPtr NATIVE_LIBRARY_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NATIVE_LIBRARY_NAME']"
		[Register ("NATIVE_LIBRARY_NAME")]
		public static string NativeLibraryName {
			get {
				if (NATIVE_LIBRARY_NAME_jfieldId == IntPtr.Zero)
					NATIVE_LIBRARY_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATIVE_LIBRARY_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NATIVE_LIBRARY_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NORM_HAMMING']"
		[Register ("NORM_HAMMING")]
		public const int NormHamming = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NORM_HAMMING2']"
		[Register ("NORM_HAMMING2")]
		public const int NormHamming2 = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NORM_INF']"
		[Register ("NORM_INF")]
		public const int NormInf = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NORM_L1']"
		[Register ("NORM_L1")]
		public const int NormL1 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NORM_L2']"
		[Register ("NORM_L2")]
		public const int NormL2 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NORM_L2SQR']"
		[Register ("NORM_L2SQR")]
		public const int NormL2sqr = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NORM_MINMAX']"
		[Register ("NORM_MINMAX")]
		public const int NormMinmax = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NORM_RELATIVE']"
		[Register ("NORM_RELATIVE")]
		public const int NormRelative = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='NORM_TYPE_MASK']"
		[Register ("NORM_TYPE_MASK")]
		public const int NormTypeMask = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='OpenCLApiCallError']"
		[Register ("OpenCLApiCallError")]
		public const int OpenCLApiCallError = (int) -220;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='OpenCLDoubleNotSupported']"
		[Register ("OpenCLDoubleNotSupported")]
		public const int OpenCLDoubleNotSupported = (int) -221;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='OpenCLInitError']"
		[Register ("OpenCLInitError")]
		public const int OpenCLInitError = (int) -222;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='OpenCLNoAMDBlasFft']"
		[Register ("OpenCLNoAMDBlasFft")]
		public const int OpenCLNoAMDBlasFft = (int) -223;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='OpenGlApiCallError']"
		[Register ("OpenGlApiCallError")]
		public const int OpenGlApiCallError = (int) -219;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='OpenGlNotSupported']"
		[Register ("OpenGlNotSupported")]
		public const int OpenGlNotSupported = (int) -218;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='REDUCE_AVG']"
		[Register ("REDUCE_AVG")]
		public const int ReduceAvg = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='REDUCE_MAX']"
		[Register ("REDUCE_MAX")]
		public const int ReduceMax = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='REDUCE_MIN']"
		[Register ("REDUCE_MIN")]
		public const int ReduceMin = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='REDUCE_SUM']"
		[Register ("REDUCE_SUM")]
		public const int ReduceSum = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='SORT_ASCENDING']"
		[Register ("SORT_ASCENDING")]
		public const int SortAscending = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='SORT_DESCENDING']"
		[Register ("SORT_DESCENDING")]
		public const int SortDescending = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='SORT_EVERY_COLUMN']"
		[Register ("SORT_EVERY_COLUMN")]
		public const int SortEveryColumn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='SORT_EVERY_ROW']"
		[Register ("SORT_EVERY_ROW")]
		public const int SortEveryRow = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='SVD_FULL_UV']"
		[Register ("SVD_FULL_UV")]
		public const int SvdFullUv = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='SVD_MODIFY_A']"
		[Register ("SVD_MODIFY_A")]
		public const int SvdModifyA = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='SVD_NO_UV']"
		[Register ("SVD_NO_UV")]
		public const int SvdNoUv = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsAssert']"
		[Register ("StsAssert")]
		public const int StsAssert = (int) -215;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsAutoTrace']"
		[Register ("StsAutoTrace")]
		public const int StsAutoTrace = (int) -8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsBackTrace']"
		[Register ("StsBackTrace")]
		public const int StsBackTrace = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsBadArg']"
		[Register ("StsBadArg")]
		public const int StsBadArg = (int) -5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsBadFlag']"
		[Register ("StsBadFlag")]
		public const int StsBadFlag = (int) -206;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsBadFunc']"
		[Register ("StsBadFunc")]
		public const int StsBadFunc = (int) -6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsBadMask']"
		[Register ("StsBadMask")]
		public const int StsBadMask = (int) -208;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsBadMemBlock']"
		[Register ("StsBadMemBlock")]
		public const int StsBadMemBlock = (int) -214;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsBadPoint']"
		[Register ("StsBadPoint")]
		public const int StsBadPoint = (int) -207;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsBadSize']"
		[Register ("StsBadSize")]
		public const int StsBadSize = (int) -201;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsDivByZero']"
		[Register ("StsDivByZero")]
		public const int StsDivByZero = (int) -202;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsError']"
		[Register ("StsError")]
		public const int StsError = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsFilterOffsetErr']"
		[Register ("StsFilterOffsetErr")]
		public const int StsFilterOffsetErr = (int) -31;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsFilterStructContentErr']"
		[Register ("StsFilterStructContentErr")]
		public const int StsFilterStructContentErr = (int) -29;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsInplaceNotSupported']"
		[Register ("StsInplaceNotSupported")]
		public const int StsInplaceNotSupported = (int) -203;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsInternal']"
		[Register ("StsInternal")]
		public const int StsInternal = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsKernelStructContentErr']"
		[Register ("StsKernelStructContentErr")]
		public const int StsKernelStructContentErr = (int) -30;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsNoConv']"
		[Register ("StsNoConv")]
		public const int StsNoConv = (int) -7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsNoMem']"
		[Register ("StsNoMem")]
		public const int StsNoMem = (int) -4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsNotImplemented']"
		[Register ("StsNotImplemented")]
		public const int StsNotImplemented = (int) -213;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsNullPtr']"
		[Register ("StsNullPtr")]
		public const int StsNullPtr = (int) -27;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsObjectNotFound']"
		[Register ("StsObjectNotFound")]
		public const int StsObjectNotFound = (int) -204;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsOk']"
		[Register ("StsOk")]
		public const int StsOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsOutOfRange']"
		[Register ("StsOutOfRange")]
		public const int StsOutOfRange = (int) -211;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsParseError']"
		[Register ("StsParseError")]
		public const int StsParseError = (int) -212;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsUnmatchedFormats']"
		[Register ("StsUnmatchedFormats")]
		public const int StsUnmatchedFormats = (int) -205;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsUnmatchedSizes']"
		[Register ("StsUnmatchedSizes")]
		public const int StsUnmatchedSizes = (int) -209;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsUnsupportedFormat']"
		[Register ("StsUnsupportedFormat")]
		public const int StsUnsupportedFormat = (int) -210;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='StsVecLengthErr']"
		[Register ("StsVecLengthErr")]
		public const int StsVecLengthErr = (int) -28;

		static IntPtr VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='VERSION']"
		[Register ("VERSION")]
		public static string Version {
			get {
				if (VERSION_jfieldId == IntPtr.Zero)
					VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VERSION_MAJOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='VERSION_MAJOR']"
		[Register ("VERSION_MAJOR")]
		public static int VersionMajor {
			get {
				if (VERSION_MAJOR_jfieldId == IntPtr.Zero)
					VERSION_MAJOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_MAJOR", "I");
				return JNIEnv.GetStaticIntField (class_ref, VERSION_MAJOR_jfieldId);
			}
		}

		static IntPtr VERSION_MINOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='VERSION_MINOR']"
		[Register ("VERSION_MINOR")]
		public static int VersionMinor {
			get {
				if (VERSION_MINOR_jfieldId == IntPtr.Zero)
					VERSION_MINOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_MINOR", "I");
				return JNIEnv.GetStaticIntField (class_ref, VERSION_MINOR_jfieldId);
			}
		}

		static IntPtr VERSION_REVISION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='VERSION_REVISION']"
		[Register ("VERSION_REVISION")]
		public static int VersionRevision {
			get {
				if (VERSION_REVISION_jfieldId == IntPtr.Zero)
					VERSION_REVISION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_REVISION", "I");
				return JNIEnv.GetStaticIntField (class_ref, VERSION_REVISION_jfieldId);
			}
		}

		static IntPtr VERSION_STATUS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/field[@name='VERSION_STATUS']"
		[Register ("VERSION_STATUS")]
		public static string VersionStatus {
			get {
				if (VERSION_STATUS_jfieldId == IntPtr.Zero)
					VERSION_STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_STATUS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_STATUS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Core.MinMaxLocResult']"
		[global::Android.Runtime.Register ("org/opencv/core/Core$MinMaxLocResult", DoNotGenerateAcw=true)]
		public partial class MinMaxLocResult : global::Java.Lang.Object {


			static IntPtr maxLoc_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core.MinMaxLocResult']/field[@name='maxLoc']"
			[Register ("maxLoc")]
			public global::OpenCV.Core.Point MaxLoc {
				get {
					if (maxLoc_jfieldId == IntPtr.Zero)
						maxLoc_jfieldId = JNIEnv.GetFieldID (class_ref, "maxLoc", "Lorg/opencv/core/Point;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, maxLoc_jfieldId);
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (maxLoc_jfieldId == IntPtr.Zero)
						maxLoc_jfieldId = JNIEnv.GetFieldID (class_ref, "maxLoc", "Lorg/opencv/core/Point;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxLoc_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr maxVal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core.MinMaxLocResult']/field[@name='maxVal']"
			[Register ("maxVal")]
			public double MaxVal {
				get {
					if (maxVal_jfieldId == IntPtr.Zero)
						maxVal_jfieldId = JNIEnv.GetFieldID (class_ref, "maxVal", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, maxVal_jfieldId);
				}
				set {
					if (maxVal_jfieldId == IntPtr.Zero)
						maxVal_jfieldId = JNIEnv.GetFieldID (class_ref, "maxVal", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxVal_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr minLoc_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core.MinMaxLocResult']/field[@name='minLoc']"
			[Register ("minLoc")]
			public global::OpenCV.Core.Point MinLoc {
				get {
					if (minLoc_jfieldId == IntPtr.Zero)
						minLoc_jfieldId = JNIEnv.GetFieldID (class_ref, "minLoc", "Lorg/opencv/core/Point;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, minLoc_jfieldId);
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (minLoc_jfieldId == IntPtr.Zero)
						minLoc_jfieldId = JNIEnv.GetFieldID (class_ref, "minLoc", "Lorg/opencv/core/Point;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, minLoc_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr minVal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Core.MinMaxLocResult']/field[@name='minVal']"
			[Register ("minVal")]
			public double MinVal {
				get {
					if (minVal_jfieldId == IntPtr.Zero)
						minVal_jfieldId = JNIEnv.GetFieldID (class_ref, "minVal", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, minVal_jfieldId);
				}
				set {
					if (minVal_jfieldId == IntPtr.Zero)
						minVal_jfieldId = JNIEnv.GetFieldID (class_ref, "minVal", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, minVal_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/opencv/core/Core$MinMaxLocResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MinMaxLocResult); }
			}

			protected MinMaxLocResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Core.MinMaxLocResult']/constructor[@name='Core.MinMaxLocResult' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MinMaxLocResult ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (MinMaxLocResult)) {
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/Core", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Core); }
		}

		protected Core (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/constructor[@name='Core' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Core ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Core)) {
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

		static IntPtr id_getBuildInformation;
		public static unsafe string BuildInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='getBuildInformation' and count(parameter)=0]"
			[Register ("getBuildInformation", "()Ljava/lang/String;", "GetGetBuildInformationHandler")]
			get {
				if (id_getBuildInformation == IntPtr.Zero)
					id_getBuildInformation = JNIEnv.GetStaticMethodID (class_ref, "getBuildInformation", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBuildInformation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCPUTickCount;
		public static unsafe long CPUTickCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='getCPUTickCount' and count(parameter)=0]"
			[Register ("getCPUTickCount", "()J", "GetGetCPUTickCountHandler")]
			get {
				if (id_getCPUTickCount == IntPtr.Zero)
					id_getCPUTickCount = JNIEnv.GetStaticMethodID (class_ref, "getCPUTickCount", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getCPUTickCount);
				} finally {
				}
			}
		}

		static IntPtr id_getNumThreads;
		static IntPtr id_setNumThreads_I;
		public static unsafe int NumThreads {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='getNumThreads' and count(parameter)=0]"
			[Register ("getNumThreads", "()I", "GetGetNumThreadsHandler")]
			get {
				if (id_getNumThreads == IntPtr.Zero)
					id_getNumThreads = JNIEnv.GetStaticMethodID (class_ref, "getNumThreads", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getNumThreads);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='setNumThreads' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumThreads", "(I)V", "GetSetNumThreads_IHandler")]
			set {
				if (id_setNumThreads_I == IntPtr.Zero)
					id_setNumThreads_I = JNIEnv.GetStaticMethodID (class_ref, "setNumThreads", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setNumThreads_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getNumberOfCPUs;
		public static unsafe int NumberOfCPUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='getNumberOfCPUs' and count(parameter)=0]"
			[Register ("getNumberOfCPUs", "()I", "GetGetNumberOfCPUsHandler")]
			get {
				if (id_getNumberOfCPUs == IntPtr.Zero)
					id_getNumberOfCPUs = JNIEnv.GetStaticMethodID (class_ref, "getNumberOfCPUs", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getNumberOfCPUs);
				} finally {
				}
			}
		}

		static IntPtr id_getThreadNum;
		public static unsafe int ThreadNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='getThreadNum' and count(parameter)=0]"
			[Register ("getThreadNum", "()I", "GetGetThreadNumHandler")]
			get {
				if (id_getThreadNum == IntPtr.Zero)
					id_getThreadNum = JNIEnv.GetStaticMethodID (class_ref, "getThreadNum", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getThreadNum);
				} finally {
				}
			}
		}

		static IntPtr id_getTickCount;
		public static unsafe long TickCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='getTickCount' and count(parameter)=0]"
			[Register ("getTickCount", "()J", "GetGetTickCountHandler")]
			get {
				if (id_getTickCount == IntPtr.Zero)
					id_getTickCount = JNIEnv.GetStaticMethodID (class_ref, "getTickCount", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getTickCount);
				} finally {
				}
			}
		}

		static IntPtr id_getTickFrequency;
		public static unsafe double TickFrequency {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='getTickFrequency' and count(parameter)=0]"
			[Register ("getTickFrequency", "()D", "GetGetTickFrequencyHandler")]
			get {
				if (id_getTickFrequency == IntPtr.Zero)
					id_getTickFrequency = JNIEnv.GetStaticMethodID (class_ref, "getTickFrequency", "()D");
				try {
					return JNIEnv.CallStaticDoubleMethod  (class_ref, id_getTickFrequency);
				} finally {
				}
			}
		}

		static IntPtr id_LUT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='LUT' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("LUT", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void LUT (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_LUT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_LUT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "LUT", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_LUT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_Mahalanobis_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='Mahalanobis' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("Mahalanobis", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double Mahalanobis (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_Mahalanobis_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_Mahalanobis_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "Mahalanobis", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_Mahalanobis_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_PCABackProject_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='PCABackProject' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("PCABackProject", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void PCABackProject (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_PCABackProject_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_PCABackProject_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "PCABackProject", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PCABackProject_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='PCACompute' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("PCACompute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void PCACompute (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "PCACompute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='PCACompute' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double']]"
		[Register ("PCACompute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void PCACompute (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, double p3)
		{
			if (id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "PCACompute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='PCACompute' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("PCACompute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void PCACompute (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "PCACompute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PCACompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_PCAProject_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='PCAProject' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("PCAProject", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void PCAProject (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_PCAProject_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_PCAProject_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "PCAProject", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PCAProject_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_PSNR_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='PSNR' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("PSNR", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double PSNR (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_PSNR_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_PSNR_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "PSNR", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_PSNR_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_SVBackSubst_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='SVBackSubst' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("SVBackSubst", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void SVBackSubst (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_SVBackSubst_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_SVBackSubst_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "SVBackSubst", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SVBackSubst_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_SVDecomp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='SVDecomp' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("SVDecomp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void SVDecomp (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_SVDecomp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_SVDecomp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "SVDecomp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SVDecomp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_SVDecomp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='SVDecomp' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int']]"
		[Register ("SVDecomp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void SVDecomp (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4)
		{
			if (id_SVDecomp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_SVDecomp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "SVDecomp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SVDecomp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_absdiff_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='absdiff' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("absdiff", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Absdiff (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_absdiff_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_absdiff_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "absdiff", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_absdiff_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_absdiff_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='absdiff' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("absdiff", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Absdiff (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2)
		{
			if (id_absdiff_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_absdiff_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "absdiff", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_absdiff_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='add' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Add (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='add' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Add (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='add' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int']]"
		[Register ("add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Add (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4)
		{
			if (id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='add' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Add (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2)
		{
			if (id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='add' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Add (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='add' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int']]"
		[Register ("add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Add (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4)
		{
			if (id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "add", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_add_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_addWeighted_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DDLorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='addWeighted' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("addWeighted", "(Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;DDLorg/opencv/core/Mat;)V", "")]
		public static unsafe void AddWeighted (global::OpenCV.Core.Mat p0, double p1, global::OpenCV.Core.Mat p2, double p3, double p4, global::OpenCV.Core.Mat p5)
		{
			if (id_addWeighted_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DDLorg_opencv_core_Mat_ == IntPtr.Zero)
				id_addWeighted_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DDLorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "addWeighted", "(Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;DDLorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addWeighted_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DDLorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_addWeighted_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DDLorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='addWeighted' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='int']]"
		[Register ("addWeighted", "(Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;DDLorg/opencv/core/Mat;I)V", "")]
		public static unsafe void AddWeighted (global::OpenCV.Core.Mat p0, double p1, global::OpenCV.Core.Mat p2, double p3, double p4, global::OpenCV.Core.Mat p5, int p6)
		{
			if (id_addWeighted_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DDLorg_opencv_core_Mat_I == IntPtr.Zero)
				id_addWeighted_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DDLorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "addWeighted", "(Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;DDLorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addWeighted_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DDLorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='batchDistance' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("batchDistance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)V", "")]
		public static unsafe void BatchDistance (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, global::OpenCV.Core.Mat p4)
		{
			if (id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "batchDistance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='batchDistance' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("batchDistance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;II)V", "")]
		public static unsafe void BatchDistance (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, global::OpenCV.Core.Mat p4, int p5, int p6)
		{
			if (id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_II == IntPtr.Zero)
				id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "batchDistance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_IILorg_opencv_core_Mat_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='batchDistance' and count(parameter)=10 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='org.opencv.core.Mat'] and parameter[9][@type='int'] and parameter[10][@type='boolean']]"
		[Register ("batchDistance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;IILorg/opencv/core/Mat;IZ)V", "")]
		public static unsafe void BatchDistance (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, global::OpenCV.Core.Mat p4, int p5, int p6, global::OpenCV.Core.Mat p7, int p8, bool p9)
		{
			if (id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_IILorg_opencv_core_Mat_IZ == IntPtr.Zero)
				id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_IILorg_opencv_core_Mat_IZ = JNIEnv.GetStaticMethodID (class_ref, "batchDistance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;IILorg/opencv/core/Mat;IZ)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_batchDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_IILorg_opencv_core_Mat_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_bitwise_and_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='bitwise_and' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("bitwise_and", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Bitwise_and (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_bitwise_and_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_bitwise_and_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "bitwise_and", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitwise_and_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_bitwise_and_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='bitwise_and' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("bitwise_and", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Bitwise_and (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_bitwise_and_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_bitwise_and_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "bitwise_and", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitwise_and_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_bitwise_not_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='bitwise_not' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("bitwise_not", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Bitwise_not (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_bitwise_not_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_bitwise_not_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "bitwise_not", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitwise_not_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_bitwise_not_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='bitwise_not' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("bitwise_not", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Bitwise_not (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_bitwise_not_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_bitwise_not_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "bitwise_not", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitwise_not_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_bitwise_or_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='bitwise_or' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("bitwise_or", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Bitwise_or (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_bitwise_or_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_bitwise_or_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "bitwise_or", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitwise_or_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_bitwise_or_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='bitwise_or' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("bitwise_or", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Bitwise_or (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_bitwise_or_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_bitwise_or_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "bitwise_or", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitwise_or_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_bitwise_xor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='bitwise_xor' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("bitwise_xor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Bitwise_xor (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_bitwise_xor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_bitwise_xor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "bitwise_xor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitwise_xor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_bitwise_xor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='bitwise_xor' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("bitwise_xor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Bitwise_xor (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_bitwise_xor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_bitwise_xor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "bitwise_xor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitwise_xor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_borderInterpolate_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='borderInterpolate' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("borderInterpolate", "(III)I", "")]
		public static unsafe int BorderInterpolate (int p0, int p1, int p2)
		{
			if (id_borderInterpolate_III == IntPtr.Zero)
				id_borderInterpolate_III = JNIEnv.GetStaticMethodID (class_ref, "borderInterpolate", "(III)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_borderInterpolate_III, __args);
			} finally {
			}
		}

		static IntPtr id_calcCovarMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='calcCovarMatrix' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("calcCovarMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void CalcCovarMatrix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_calcCovarMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_calcCovarMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "calcCovarMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calcCovarMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_calcCovarMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='calcCovarMatrix' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("calcCovarMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void CalcCovarMatrix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, int p4)
		{
			if (id_calcCovarMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_calcCovarMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "calcCovarMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calcCovarMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_cartToPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='cartToPolar' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("cartToPolar", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void CartToPolar (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_cartToPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_cartToPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "cartToPolar", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cartToPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_cartToPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='cartToPolar' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='boolean']]"
		[Register ("cartToPolar", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V", "")]
		public static unsafe void CartToPolar (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, bool p4)
		{
			if (id_cartToPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_cartToPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "cartToPolar", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cartToPolar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z, __args);
			} finally {
			}
		}

		static IntPtr id_checkRange_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='checkRange' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("checkRange", "(Lorg/opencv/core/Mat;)Z", "")]
		public static unsafe bool CheckRange (global::OpenCV.Core.Mat p0)
		{
			if (id_checkRange_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_checkRange_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "checkRange", "(Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkRange_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkRange_Lorg_opencv_core_Mat_ZDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='checkRange' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='boolean'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("checkRange", "(Lorg/opencv/core/Mat;ZDD)Z", "")]
		public static unsafe bool CheckRange (global::OpenCV.Core.Mat p0, bool p1, double p2, double p3)
		{
			if (id_checkRange_Lorg_opencv_core_Mat_ZDD == IntPtr.Zero)
				id_checkRange_Lorg_opencv_core_Mat_ZDD = JNIEnv.GetStaticMethodID (class_ref, "checkRange", "(Lorg/opencv/core/Mat;ZDD)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkRange_Lorg_opencv_core_Mat_ZDD, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_compare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='compare' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("compare", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Compare (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_compare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_compare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "compare", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_compare_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_compare_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='compare' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("compare", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Compare (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_compare_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_compare_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "compare", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_compare_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_completeSymm_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='completeSymm' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("completeSymm", "(Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void CompleteSymm (global::OpenCV.Core.Mat p0)
		{
			if (id_completeSymm_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_completeSymm_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "completeSymm", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_completeSymm_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_completeSymm_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='completeSymm' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='boolean']]"
		[Register ("completeSymm", "(Lorg/opencv/core/Mat;Z)V", "")]
		public static unsafe void CompleteSymm (global::OpenCV.Core.Mat p0, bool p1)
		{
			if (id_completeSymm_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_completeSymm_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "completeSymm", "(Lorg/opencv/core/Mat;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_completeSymm_Lorg_opencv_core_Mat_Z, __args);
			} finally {
			}
		}

		static IntPtr id_convertScaleAbs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='convertScaleAbs' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("convertScaleAbs", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ConvertScaleAbs (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_convertScaleAbs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_convertScaleAbs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "convertScaleAbs", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convertScaleAbs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_convertScaleAbs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='convertScaleAbs' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("convertScaleAbs", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DD)V", "")]
		public static unsafe void ConvertScaleAbs (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3)
		{
			if (id_convertScaleAbs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD == IntPtr.Zero)
				id_convertScaleAbs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD = JNIEnv.GetStaticMethodID (class_ref, "convertScaleAbs", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DD)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convertScaleAbs_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD, __args);
			} finally {
			}
		}

		static IntPtr id_copyMakeBorder_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='copyMakeBorder' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("copyMakeBorder", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIII)V", "")]
		public static unsafe void CopyMakeBorder (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4, int p5, int p6)
		{
			if (id_copyMakeBorder_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIII == IntPtr.Zero)
				id_copyMakeBorder_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIII = JNIEnv.GetStaticMethodID (class_ref, "copyMakeBorder", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIII)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyMakeBorder_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIII, __args);
			} finally {
			}
		}

		static IntPtr id_copyMakeBorder_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIILorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='copyMakeBorder' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='org.opencv.core.Scalar']]"
		[Register ("copyMakeBorder", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIIILorg/opencv/core/Scalar;)V", "")]
		public static unsafe void CopyMakeBorder (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4, int p5, int p6, global::OpenCV.Core.Scalar p7)
		{
			if (id_copyMakeBorder_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIILorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_copyMakeBorder_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIILorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "copyMakeBorder", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IIIIILorg/opencv/core/Scalar;)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyMakeBorder_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IIIIILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_countNonZero_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='countNonZero' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("countNonZero", "(Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int CountNonZero (global::OpenCV.Core.Mat p0)
		{
			if (id_countNonZero_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_countNonZero_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "countNonZero", "(Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_countNonZero_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_cubeRoot_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='cubeRoot' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("cubeRoot", "(F)F", "")]
		public static unsafe float CubeRoot (float p0)
		{
			if (id_cubeRoot_F == IntPtr.Zero)
				id_cubeRoot_F = JNIEnv.GetStaticMethodID (class_ref, "cubeRoot", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_cubeRoot_F, __args);
			} finally {
			}
		}

		static IntPtr id_dct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='dct' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("dct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Dct (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_dct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_dct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "dct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_dct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='dct' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("dct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Dct (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_dct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_dct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "dct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_determinant_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='determinant' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("determinant", "(Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double Determinant (global::OpenCV.Core.Mat p0)
		{
			if (id_determinant_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_determinant_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "determinant", "(Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_determinant_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_dft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='dft' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("dft", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Dft (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_dft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_dft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "dft", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_dft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='dft' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("dft", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void Dft (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_dft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_dft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "dft", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_divide_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='divide' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("divide", "(DLorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Divide (double p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_divide_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_divide_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "divide", "(DLorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_divide_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_divide_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='divide' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("divide", "(DLorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Divide (double p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_divide_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_divide_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "divide", "(DLorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_divide_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='divide' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Divide (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='divide' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double']]"
		[Register ("divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void Divide (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, double p3)
		{
			if (id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='divide' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DI)V", "")]
		public static unsafe void Divide (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, double p3, int p4)
		{
			if (id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI == IntPtr.Zero)
				id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI = JNIEnv.GetStaticMethodID (class_ref, "divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI, __args);
			} finally {
			}
		}

		static IntPtr id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='divide' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Divide (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2)
		{
			if (id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='divide' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double']]"
		[Register ("divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void Divide (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2, double p3)
		{
			if (id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='divide' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;DI)V", "")]
		public static unsafe void Divide (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2, double p3, int p4)
		{
			if (id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_DI == IntPtr.Zero)
				id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_DI = JNIEnv.GetStaticMethodID (class_ref, "divide", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;DI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_divide_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_DI, __args);
			} finally {
			}
		}

		static IntPtr id_eigen_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='eigen' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("eigen", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "")]
		public static unsafe bool Eigen (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_eigen_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_eigen_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "eigen", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_eigen_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_eigen_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='eigen' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("eigen", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "")]
		public static unsafe bool Eigen (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_eigen_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_eigen_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "eigen", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_eigen_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_exp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='exp' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("exp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Exp (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_exp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_exp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "exp", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_exp_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_extractChannel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='extractChannel' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("extractChannel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void ExtractChannel (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_extractChannel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_extractChannel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "extractChannel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_extractChannel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_fastAtan2_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='fastAtan2' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("fastAtan2", "(FF)F", "")]
		public static unsafe float FastAtan2 (float p0, float p1)
		{
			if (id_fastAtan2_FF == IntPtr.Zero)
				id_fastAtan2_FF = JNIEnv.GetStaticMethodID (class_ref, "fastAtan2", "(FF)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_fastAtan2_FF, __args);
			} finally {
			}
		}

		static IntPtr id_findNonZero_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='findNonZero' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("findNonZero", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void FindNonZero (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_findNonZero_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findNonZero_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "findNonZero", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_findNonZero_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_flip_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='flip' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("flip", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Flip (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_flip_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_flip_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "flip", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_flip_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_gemm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DLorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='gemm' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='double'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("gemm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;DLorg/opencv/core/Mat;)V", "")]
		public static unsafe void Gemm (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, global::OpenCV.Core.Mat p3, double p4, global::OpenCV.Core.Mat p5)
		{
			if (id_gemm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DLorg_opencv_core_Mat_ == IntPtr.Zero)
				id_gemm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DLorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "gemm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;DLorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_gemm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DLorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_gemm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DLorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='gemm' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='double'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='int']]"
		[Register ("gemm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;DLorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Gemm (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, global::OpenCV.Core.Mat p3, double p4, global::OpenCV.Core.Mat p5, int p6)
		{
			if (id_gemm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DLorg_opencv_core_Mat_I == IntPtr.Zero)
				id_gemm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DLorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "gemm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;DLorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_gemm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_DLorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_getOptimalDFTSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='getOptimalDFTSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOptimalDFTSize", "(I)I", "")]
		public static unsafe int GetOptimalDFTSize (int p0)
		{
			if (id_getOptimalDFTSize_I == IntPtr.Zero)
				id_getOptimalDFTSize_I = JNIEnv.GetStaticMethodID (class_ref, "getOptimalDFTSize", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getOptimalDFTSize_I, __args);
			} finally {
			}
		}

		static IntPtr id_hconcat_Ljava_util_List_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='hconcat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("hconcat", "(Ljava/util/List;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Hconcat (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1)
		{
			if (id_hconcat_Ljava_util_List_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_hconcat_Ljava_util_List_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "hconcat", "(Ljava/util/List;Lorg/opencv/core/Mat;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_hconcat_Ljava_util_List_Lorg_opencv_core_Mat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_idct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='idct' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("idct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Idct (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_idct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_idct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "idct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_idct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='idct' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("idct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Idct (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_idct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_idct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "idct", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idct_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_idft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='idft' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("idft", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Idft (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_idft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_idft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "idft", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_idft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='idft' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("idft", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void Idft (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_idft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_idft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "idft", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idft_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_inRange_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='inRange' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Scalar'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("inRange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void InRange (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Scalar p2, global::OpenCV.Core.Mat p3)
		{
			if (id_inRange_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_inRange_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "inRange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_inRange_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_insertChannel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='insertChannel' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("insertChannel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void InsertChannel (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_insertChannel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_insertChannel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "insertChannel", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_insertChannel_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_invert_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='invert' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("invert", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double Invert (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_invert_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_invert_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "invert", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_invert_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_invert_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='invert' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("invert", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D", "")]
		public static unsafe double Invert (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_invert_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_invert_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "invert", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_invert_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_kmeans_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_TermCriteria_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='kmeans' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.TermCriteria'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("kmeans", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/TermCriteria;II)D", "")]
		public static unsafe double Kmeans (global::OpenCV.Core.Mat p0, int p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.TermCriteria p3, int p4, int p5)
		{
			if (id_kmeans_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_TermCriteria_II == IntPtr.Zero)
				id_kmeans_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_TermCriteria_II = JNIEnv.GetStaticMethodID (class_ref, "kmeans", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/TermCriteria;II)D");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_kmeans_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_TermCriteria_II, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_kmeans_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_TermCriteria_IILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='kmeans' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.TermCriteria'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Mat']]"
		[Register ("kmeans", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/TermCriteria;IILorg/opencv/core/Mat;)D", "")]
		public static unsafe double Kmeans (global::OpenCV.Core.Mat p0, int p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.TermCriteria p3, int p4, int p5, global::OpenCV.Core.Mat p6)
		{
			if (id_kmeans_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_TermCriteria_IILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_kmeans_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_TermCriteria_IILorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "kmeans", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/TermCriteria;IILorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_kmeans_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_TermCriteria_IILorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_log_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='log' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("log", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Log (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_log_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_log_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_magnitude_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='magnitude' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("magnitude", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Magnitude (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_magnitude_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_magnitude_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "magnitude", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_magnitude_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_max_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='max' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("max", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Max (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_max_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_max_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "max", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_max_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_max_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='max' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("max", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Max (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2)
		{
			if (id_max_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_max_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "max", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_max_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_mean_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='mean' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("mean", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Scalar;", "")]
		public static unsafe global::OpenCV.Core.Scalar Mean (global::OpenCV.Core.Mat p0)
		{
			if (id_mean_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_mean_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "mean", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Scalar;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.Scalar __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mean_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mean_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='mean' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("mean", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Scalar;", "")]
		public static unsafe global::OpenCV.Core.Scalar Mean (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_mean_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_mean_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "mean", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Scalar;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Scalar __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mean_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_meanStdDev_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfDouble_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='meanStdDev' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfDouble'] and parameter[3][@type='org.opencv.core.MatOfDouble']]"
		[Register ("meanStdDev", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/MatOfDouble;)V", "")]
		public static unsafe void MeanStdDev (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfDouble p1, global::OpenCV.Core.MatOfDouble p2)
		{
			if (id_meanStdDev_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfDouble_ == IntPtr.Zero)
				id_meanStdDev_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfDouble_ = JNIEnv.GetStaticMethodID (class_ref, "meanStdDev", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/MatOfDouble;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_meanStdDev_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfDouble_, __args);
			} finally {
			}
		}

		static IntPtr id_meanStdDev_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='meanStdDev' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfDouble'] and parameter[3][@type='org.opencv.core.MatOfDouble'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("meanStdDev", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void MeanStdDev (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfDouble p1, global::OpenCV.Core.MatOfDouble p2, global::OpenCV.Core.Mat p3)
		{
			if (id_meanStdDev_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_meanStdDev_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "meanStdDev", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_meanStdDev_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_merge_Ljava_util_List_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='merge' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("merge", "(Ljava/util/List;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Merge (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1)
		{
			if (id_merge_Ljava_util_List_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_merge_Ljava_util_List_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "merge", "(Ljava/util/List;Lorg/opencv/core/Mat;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_merge_Ljava_util_List_Lorg_opencv_core_Mat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_min_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='min' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("min", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Min (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_min_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_min_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "min", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_min_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_min_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='min' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("min", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Min (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2)
		{
			if (id_min_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_min_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "min", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_min_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_minMaxLoc_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='minMaxLoc' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("minMaxLoc", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Core$MinMaxLocResult;", "")]
		public static unsafe global::OpenCV.Core.Core.MinMaxLocResult MinMaxLoc (global::OpenCV.Core.Mat p0)
		{
			if (id_minMaxLoc_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_minMaxLoc_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "minMaxLoc", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Core$MinMaxLocResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.Core.MinMaxLocResult __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Core.MinMaxLocResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_minMaxLoc_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_minMaxLoc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='minMaxLoc' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("minMaxLoc", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Core$MinMaxLocResult;", "")]
		public static unsafe global::OpenCV.Core.Core.MinMaxLocResult MinMaxLoc (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_minMaxLoc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_minMaxLoc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "minMaxLoc", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Core$MinMaxLocResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Core.MinMaxLocResult __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Core.MinMaxLocResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_minMaxLoc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mixChannels_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_MatOfInt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='mixChannels' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='org.opencv.core.MatOfInt']]"
		[Register ("mixChannels", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/MatOfInt;)V", "")]
		public static unsafe void MixChannels (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::OpenCV.Core.MatOfInt p2)
		{
			if (id_mixChannels_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_MatOfInt_ == IntPtr.Zero)
				id_mixChannels_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_MatOfInt_ = JNIEnv.GetStaticMethodID (class_ref, "mixChannels", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/MatOfInt;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_mixChannels_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_MatOfInt_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_mulSpectrums_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='mulSpectrums' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("mulSpectrums", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void MulSpectrums (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_mulSpectrums_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_mulSpectrums_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "mulSpectrums", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_mulSpectrums_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_mulSpectrums_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='mulSpectrums' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("mulSpectrums", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IZ)V", "")]
		public static unsafe void MulSpectrums (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, bool p4)
		{
			if (id_mulSpectrums_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IZ == IntPtr.Zero)
				id_mulSpectrums_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IZ = JNIEnv.GetStaticMethodID (class_ref, "mulSpectrums", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IZ)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_mulSpectrums_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='mulTransposed' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='boolean']]"
		[Register ("mulTransposed", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V", "")]
		public static unsafe void MulTransposed (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, bool p2)
		{
			if (id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "mulTransposed", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z, __args);
			} finally {
			}
		}

		static IntPtr id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZLorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='mulTransposed' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='boolean'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='double']]"
		[Register ("mulTransposed", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZLorg/opencv/core/Mat;D)V", "")]
		public static unsafe void MulTransposed (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, bool p2, global::OpenCV.Core.Mat p3, double p4)
		{
			if (id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZLorg_opencv_core_Mat_D == IntPtr.Zero)
				id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZLorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "mulTransposed", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZLorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZLorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZLorg_opencv_core_Mat_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='mulTransposed' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='boolean'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='double'] and parameter[6][@type='int']]"
		[Register ("mulTransposed", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZLorg/opencv/core/Mat;DI)V", "")]
		public static unsafe void MulTransposed (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, bool p2, global::OpenCV.Core.Mat p3, double p4, int p5)
		{
			if (id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZLorg_opencv_core_Mat_DI == IntPtr.Zero)
				id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZLorg_opencv_core_Mat_DI = JNIEnv.GetStaticMethodID (class_ref, "mulTransposed", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZLorg/opencv/core/Mat;DI)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_mulTransposed_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZLorg_opencv_core_Mat_DI, __args);
			} finally {
			}
		}

		static IntPtr id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='multiply' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Multiply (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='multiply' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double']]"
		[Register ("multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void Multiply (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, double p3)
		{
			if (id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='multiply' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DI)V", "")]
		public static unsafe void Multiply (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, double p3, int p4)
		{
			if (id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI == IntPtr.Zero)
				id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI = JNIEnv.GetStaticMethodID (class_ref, "multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI, __args);
			} finally {
			}
		}

		static IntPtr id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='multiply' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Multiply (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2)
		{
			if (id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='multiply' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double']]"
		[Register ("multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void Multiply (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2, double p3)
		{
			if (id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='multiply' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;DI)V", "")]
		public static unsafe void Multiply (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2, double p3, int p4)
		{
			if (id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_DI == IntPtr.Zero)
				id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_DI = JNIEnv.GetStaticMethodID (class_ref, "multiply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;DI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_multiply_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_DI, __args);
			} finally {
			}
		}

		static IntPtr id_norm_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='norm' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("norm", "(Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double Norm (global::OpenCV.Core.Mat p0)
		{
			if (id_norm_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_norm_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "norm", "(Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_norm_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_norm_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='norm' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int']]"
		[Register ("norm", "(Lorg/opencv/core/Mat;I)D", "")]
		public static unsafe double Norm (global::OpenCV.Core.Mat p0, int p1)
		{
			if (id_norm_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_norm_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "norm", "(Lorg/opencv/core/Mat;I)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_norm_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_norm_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='norm' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("norm", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)D", "")]
		public static unsafe double Norm (global::OpenCV.Core.Mat p0, int p1, global::OpenCV.Core.Mat p2)
		{
			if (id_norm_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_norm_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "norm", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_norm_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='norm' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("norm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double Norm (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "norm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='norm' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("norm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D", "")]
		public static unsafe double Norm (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "norm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='norm' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("norm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)D", "")]
		public static unsafe double Norm (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, global::OpenCV.Core.Mat p3)
		{
			if (id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "norm", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_norm_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='normalize' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("normalize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Normalize (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "normalize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='normalize' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("normalize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDI)V", "")]
		public static unsafe void Normalize (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4)
		{
			if (id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI == IntPtr.Zero)
				id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI = JNIEnv.GetStaticMethodID (class_ref, "normalize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDI, __args);
			} finally {
			}
		}

		static IntPtr id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='normalize' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("normalize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDII)V", "")]
		public static unsafe void Normalize (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4, int p5)
		{
			if (id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDII == IntPtr.Zero)
				id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDII = JNIEnv.GetStaticMethodID (class_ref, "normalize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDII)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDII, __args);
			} finally {
			}
		}

		static IntPtr id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='normalize' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Mat']]"
		[Register ("normalize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDIILorg/opencv/core/Mat;)V", "")]
		public static unsafe void Normalize (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, double p3, int p4, int p5, global::OpenCV.Core.Mat p6)
		{
			if (id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIILorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "normalize", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DDIILorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_normalize_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DDIILorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_patchNaNs_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='patchNaNs' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("patchNaNs", "(Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void PatchNaNs (global::OpenCV.Core.Mat p0)
		{
			if (id_patchNaNs_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_patchNaNs_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "patchNaNs", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_patchNaNs_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_patchNaNs_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='patchNaNs' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double']]"
		[Register ("patchNaNs", "(Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void PatchNaNs (global::OpenCV.Core.Mat p0, double p1)
		{
			if (id_patchNaNs_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_patchNaNs_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "patchNaNs", "(Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_patchNaNs_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_perspectiveTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='perspectiveTransform' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("perspectiveTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void PerspectiveTransform (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_perspectiveTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_perspectiveTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "perspectiveTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_perspectiveTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_phase_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='phase' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("phase", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Phase (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_phase_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_phase_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "phase", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_phase_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_phase_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='phase' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='boolean']]"
		[Register ("phase", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V", "")]
		public static unsafe void Phase (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, bool p3)
		{
			if (id_phase_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_phase_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "phase", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_phase_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z, __args);
			} finally {
			}
		}

		static IntPtr id_polarToCart_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='polarToCart' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("polarToCart", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void PolarToCart (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_polarToCart_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_polarToCart_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "polarToCart", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_polarToCart_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_polarToCart_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='polarToCart' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='boolean']]"
		[Register ("polarToCart", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V", "")]
		public static unsafe void PolarToCart (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, bool p4)
		{
			if (id_polarToCart_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_polarToCart_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "polarToCart", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_polarToCart_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z, __args);
			} finally {
			}
		}

		static IntPtr id_pow_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='pow' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("pow", "(Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;)V", "")]
		public static unsafe void Pow (global::OpenCV.Core.Mat p0, double p1, global::OpenCV.Core.Mat p2)
		{
			if (id_pow_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_ == IntPtr.Zero)
				id_pow_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "pow", "(Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pow_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_randShuffle_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='randShuffle' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("randShuffle", "(Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void RandShuffle (global::OpenCV.Core.Mat p0)
		{
			if (id_randShuffle_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_randShuffle_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "randShuffle", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_randShuffle_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_randShuffle_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='randShuffle' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double']]"
		[Register ("randShuffle", "(Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void RandShuffle (global::OpenCV.Core.Mat p0, double p1)
		{
			if (id_randShuffle_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_randShuffle_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "randShuffle", "(Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_randShuffle_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_randn_Lorg_opencv_core_Mat_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='randn' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("randn", "(Lorg/opencv/core/Mat;DD)V", "")]
		public static unsafe void Randn (global::OpenCV.Core.Mat p0, double p1, double p2)
		{
			if (id_randn_Lorg_opencv_core_Mat_DD == IntPtr.Zero)
				id_randn_Lorg_opencv_core_Mat_DD = JNIEnv.GetStaticMethodID (class_ref, "randn", "(Lorg/opencv/core/Mat;DD)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_randn_Lorg_opencv_core_Mat_DD, __args);
			} finally {
			}
		}

		static IntPtr id_randu_Lorg_opencv_core_Mat_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='randu' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("randu", "(Lorg/opencv/core/Mat;DD)V", "")]
		public static unsafe void Randu (global::OpenCV.Core.Mat p0, double p1, double p2)
		{
			if (id_randu_Lorg_opencv_core_Mat_DD == IntPtr.Zero)
				id_randu_Lorg_opencv_core_Mat_DD = JNIEnv.GetStaticMethodID (class_ref, "randu", "(Lorg/opencv/core/Mat;DD)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_randu_Lorg_opencv_core_Mat_DD, __args);
			} finally {
			}
		}

		static IntPtr id_reduce_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='reduce' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("reduce", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void Reduce (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_reduce_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_reduce_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "reduce", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reduce_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_reduce_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='reduce' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("reduce", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V", "")]
		public static unsafe void Reduce (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4)
		{
			if (id_reduce_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III == IntPtr.Zero)
				id_reduce_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III = JNIEnv.GetStaticMethodID (class_ref, "reduce", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reduce_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III, __args);
			} finally {
			}
		}

		static IntPtr id_repeat_Lorg_opencv_core_Mat_IILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='repeat' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("repeat", "(Lorg/opencv/core/Mat;IILorg/opencv/core/Mat;)V", "")]
		public static unsafe void Repeat (global::OpenCV.Core.Mat p0, int p1, int p2, global::OpenCV.Core.Mat p3)
		{
			if (id_repeat_Lorg_opencv_core_Mat_IILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_repeat_Lorg_opencv_core_Mat_IILorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "repeat", "(Lorg/opencv/core/Mat;IILorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_repeat_Lorg_opencv_core_Mat_IILorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_scaleAdd_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='scaleAdd' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("scaleAdd", "(Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ScaleAdd (global::OpenCV.Core.Mat p0, double p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_scaleAdd_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_scaleAdd_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "scaleAdd", "(Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_scaleAdd_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_setErrorVerbosity_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='setErrorVerbosity' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setErrorVerbosity", "(Z)V", "")]
		public static unsafe void SetErrorVerbosity (bool p0)
		{
			if (id_setErrorVerbosity_Z == IntPtr.Zero)
				id_setErrorVerbosity_Z = JNIEnv.GetStaticMethodID (class_ref, "setErrorVerbosity", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setErrorVerbosity_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setIdentity_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='setIdentity' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("setIdentity", "(Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void SetIdentity (global::OpenCV.Core.Mat p0)
		{
			if (id_setIdentity_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_setIdentity_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "setIdentity", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setIdentity_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_setIdentity_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='setIdentity' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar']]"
		[Register ("setIdentity", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;)V", "")]
		public static unsafe void SetIdentity (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1)
		{
			if (id_setIdentity_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_setIdentity_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_ = JNIEnv.GetStaticMethodID (class_ref, "setIdentity", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setIdentity_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_solve_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='solve' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("solve", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "")]
		public static unsafe bool Solve (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_solve_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_solve_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "solve", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_solve_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_solve_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='solve' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("solve", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)Z", "")]
		public static unsafe bool Solve (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_solve_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_solve_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "solve", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_solve_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_solveCubic_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='solveCubic' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("solveCubic", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int SolveCubic (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_solveCubic_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_solveCubic_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "solveCubic", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_solveCubic_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_solvePoly_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='solvePoly' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("solvePoly", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double SolvePoly (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_solvePoly_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_solvePoly_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "solvePoly", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_solvePoly_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_solvePoly_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='solvePoly' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("solvePoly", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D", "")]
		public static unsafe double SolvePoly (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_solvePoly_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_solvePoly_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "solvePoly", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_solvePoly_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='sort' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("sort", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Sort (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_sort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_sort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "sort", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sort_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_sortIdx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='sortIdx' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("sortIdx", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void SortIdx (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_sortIdx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_sortIdx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "sortIdx", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sortIdx_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_split_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='split' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("split", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Split (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1)
		{
			if (id_split_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_split_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "split", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_split_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sqrt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='sqrt' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("sqrt", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Sqrt (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_sqrt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_sqrt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "sqrt", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sqrt_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='subtract' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Subtract (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='subtract' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Subtract (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='subtract' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int']]"
		[Register ("subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Subtract (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4)
		{
			if (id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='subtract' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Subtract (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2)
		{
			if (id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='subtract' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Subtract (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='subtract' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Scalar'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='int']]"
		[Register ("subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void Subtract (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Scalar p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, int p4)
		{
			if (id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "subtract", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subtract_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_sumElems_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='sumElems' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("sumElems", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Scalar;", "")]
		public static unsafe global::OpenCV.Core.Scalar SumElems (global::OpenCV.Core.Mat p0)
		{
			if (id_sumElems_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_sumElems_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "sumElems", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Scalar;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.Scalar __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sumElems_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_trace_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='trace' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("trace", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Scalar;", "")]
		public static unsafe global::OpenCV.Core.Scalar Trace (global::OpenCV.Core.Mat p0)
		{
			if (id_trace_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_trace_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "trace", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Scalar;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.Scalar __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_trace_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_transform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='transform' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("transform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Transform (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_transform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_transform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "transform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_transform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_transpose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='transpose' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("transpose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Transpose (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_transpose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_transpose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "transpose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_transpose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_vconcat_Ljava_util_List_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Core']/method[@name='vconcat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("vconcat", "(Ljava/util/List;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Vconcat (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1)
		{
			if (id_vconcat_Ljava_util_List_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_vconcat_Ljava_util_List_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "vconcat", "(Ljava/util/List;Lorg/opencv/core/Mat;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_vconcat_Ljava_util_List_Lorg_opencv_core_Mat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
