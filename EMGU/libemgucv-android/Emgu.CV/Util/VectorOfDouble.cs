﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2016 by EMGU Corporation. All rights reserved.
//
//  Vector of Double
//
//  This file is automatically generated, do not modify.
//----------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Emgu.CV.Structure;
#if !NETFX_CORE
using System.Runtime.Serialization;
#endif

namespace Emgu.CV.Util
{
   /// <summary>
   /// Wrapped class of the C++ standard vector of Double.
   /// </summary>
#if !NETFX_CORE
   [Serializable]
   [DebuggerTypeProxy(typeof(VectorOfDouble.DebuggerProxy))]
#endif
   public partial class VectorOfDouble : Emgu.Util.UnmanagedObject, IInputOutputArray
#if !NETFX_CORE
   , ISerializable
#endif
   {
      private readonly bool _needDispose;
   
      static VectorOfDouble()
      {
         CvInvoke.CheckLibraryLoaded();
         Debug.Assert(Emgu.Util.Toolbox.SizeOf<double>() == SizeOfItemInBytes, "Size do not match");
      }

#if !NETFX_CORE
      /// <summary>
      /// Constructor used to deserialize runtime serialized object
      /// </summary>
      /// <param name="info">The serialization info</param>
      /// <param name="context">The streaming context</param>
      public VectorOfDouble(SerializationInfo info, StreamingContext context)
         : this()
      {
         Push((double[])info.GetValue("DoubleArray", typeof(double[])));
      }
	  
	   /// <summary>
      /// A function used for runtime serialization of the object
      /// </summary>
      /// <param name="info">Serialization info</param>
      /// <param name="context">Streaming context</param>
      public void GetObjectData(SerializationInfo info, StreamingContext context)
      {
         info.AddValue("DoubleArray", ToArray());
      }
#endif

      /// <summary>
      /// Create an empty standard vector of Double
      /// </summary>
      public VectorOfDouble()
         : this(VectorOfDoubleCreate(), true)
      {
      }
	  
	   internal VectorOfDouble(IntPtr ptr, bool needDispose)
      {
         _ptr = ptr;
         _needDispose = needDispose;
      }

      /// <summary>
      /// Create an standard vector of Double of the specific size
      /// </summary>
      /// <param name="size">The size of the vector</param>
      public VectorOfDouble(int size)
         : this( VectorOfDoubleCreateSize(size), true)
      {
      }
	  
	   /// <summary>
      /// Create an standard vector of Double with the initial values
      /// </summary>
      /// <param name="values">The initial values</param>
	   public VectorOfDouble(double[] values)
         :this()
      {
         Push(values);
      }
	  
      /// <summary>
      /// Push an array of value into the standard vector
      /// </summary>
      /// <param name="value">The value to be pushed to the vector</param>
      public void Push(double[] value)
      {
         if (value.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(value, GCHandleType.Pinned);
            VectorOfDoublePushMulti(_ptr, handle.AddrOfPinnedObject(), value.Length);
            handle.Free();
         }
      }
      
      /// <summary>
      /// Push multiple values from the other vector into this vector
      /// </summary>
      /// <param name="other">The other vector, from which the values will be pushed to the current vector</param>
      public void Push(VectorOfDouble other)
      {
         VectorOfDoublePushVector(_ptr, other);
      }
	  
	   /// <summary>
      /// Convert the standard vector to an array of Double
      /// </summary>
      /// <returns>An array of Double</returns>
      public double[] ToArray()
      {
         double[] res = new double[Size];
         if (res.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(res, GCHandleType.Pinned);
            VectorOfDoubleCopyData(_ptr, handle.AddrOfPinnedObject());
            handle.Free();
         }
         return res;
      }

      /// <summary>
      /// Get the size of the vector
      /// </summary>
      public int Size
      {
         get
         {
            return VectorOfDoubleGetSize(_ptr);
         }
      }

      /// <summary>
      /// Clear the vector
      /// </summary>
      public void Clear()
      {
         VectorOfDoubleClear(_ptr);
      }

      /// <summary>
      /// The pointer to the first element on the vector. In case of an empty vector, IntPtr.Zero will be returned.
      /// </summary>
      public IntPtr StartAddress
      {
         get
         {
            return VectorOfDoubleGetStartAddress(_ptr);
         }
      }
	  
	   /// <summary>
      /// Get the item in the specific index
      /// </summary>
      /// <param name="index">The index</param>
      /// <returns>The item in the specific index</returns>
      public double this[int index]
      {
         get
         {
            double result = new double();
            VectorOfDoubleGetItem(_ptr, index, ref result);
            return result;
         }
      }

      /// <summary>
      /// Release the standard vector
      /// </summary>
      protected override void DisposeObject()
      {
         if (_needDispose && _ptr != IntPtr.Zero)
            VectorOfDoubleRelease(ref _ptr);
      }

	   /// <summary>
      /// Get the pointer to cv::_InputArray
      /// </summary>
      public InputArray GetInputArray()
      {
         return new InputArray( cvInputArrayFromVectorOfDouble(_ptr) );
      }
	  
	   /// <summary>
      /// Get the pointer to cv::_OutputArray
      /// </summary>
      public OutputArray GetOutputArray()
      {
         return new OutputArray( cvOutputArrayFromVectorOfDouble(_ptr) );
      }

	   /// <summary>
      /// Get the pointer to cv::_InputOutputArray
      /// </summary>
      public InputOutputArray GetInputOutputArray()
      {
         return new InputOutputArray( cvInputOutputArrayFromVectorOfDouble(_ptr) );
      }
      
      /// <summary>
      /// The size of the item in this Vector, counted as size in bytes.
      /// </summary>
      public static int SizeOfItemInBytes
      {
         get { return VectorOfDoubleSizeOfItemInBytes(); }
      }
	  
      internal class DebuggerProxy
      {
         private VectorOfDouble _v;

         public DebuggerProxy(VectorOfDouble v)
         {
            _v = v;
         }

         public double[] Values
         {
            get { return _v.ToArray(); }
         }
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfDoubleCreate();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfDoubleCreateSize(int size);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfDoubleRelease(ref IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfDoubleGetSize(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfDoubleCopyData(IntPtr v, IntPtr data);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfDoubleGetStartAddress(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfDoublePushMulti(IntPtr v, IntPtr values, int count);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfDoublePushVector(IntPtr ptr, IntPtr otherPtr);
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfDoubleClear(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfDoubleGetItem(IntPtr vec, int index, ref double element);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfDoubleSizeOfItemInBytes();
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputArrayFromVectorOfDouble(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvOutputArrayFromVectorOfDouble(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputOutputArrayFromVectorOfDouble(IntPtr vec);
   }
}
