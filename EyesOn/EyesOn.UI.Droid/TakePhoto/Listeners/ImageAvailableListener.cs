
using Android.Media;

using Java.IO;
using Java.Lang;
using Java.Nio;

using Emgu.CV;

namespace EyesOn.UI.Droid.TakePhoto.Listeners
{
    public class ImageAvailableListener : Java.Lang.Object, ImageReader.IOnImageAvailableListener
    {
        public File File { get; set; }
        public TakePhotoActivity3 Owner { get; set; }

        public void OnImageAvailable(ImageReader reader)
        {
            if (Owner.CLEAR_CANVAS)
            {
                Owner.mBackgroundHandler.Post(new ImageSaver(reader.AcquireNextImage(), Owner.mFile));
            }

            //Android.Util.Log.Error("ImageAvailableListener", "OnImageAvailable");
            Image image = reader.AcquireLatestImage();

            if (image != null)
            {
                ByteBuffer Y = image.GetPlanes()[0].Buffer;
                ByteBuffer U = image.GetPlanes()[1].Buffer;
                ByteBuffer V = image.GetPlanes()[2].Buffer;

                byte[] bytes = new byte[Y.Remaining()];
                Y.Get(bytes);
                
                Mat imgMat = new Mat(image.Height, image.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
                CvInvoke.Imdecode(bytes, Emgu.CV.CvEnum.ImreadModes.Grayscale, imgMat);
                image.Close();
                //Android.Util.Log.Error("ImageAvailableListener", "image.Close()");


                //Imgcodecs.imdecode(new MatOfByte(bytes), Imgcodecs.CV_LOAD_IMAGE_UNCHANGED);
                //var b2 = ByteBuffer.Wrap(bytes);
                //var bitmap = Android.Graphics.Bitmap.CreateBitmap(image.Width, image.Height, Android.Graphics.Bitmap.Config.Rgb565);
                //bitmap.CopyPixelsFromBuffer(b2);

                Owner.PreviewFrame(imgMat);


            }
        }

        // Saves a JPEG {@link Image} into the specified {@link File}.
        private class ImageSaver : Java.Lang.Object, IRunnable
        {
            // The JPEG image
            private Image mImage;

            // The file we save the image into.
            private File mFile;

            public ImageSaver(Image image, File file)
            {
                mImage = image;
                mFile = file;
            }

            public void Run()
            {
                ByteBuffer buffer = mImage.GetPlanes()[0].Buffer;
                byte[] bytes = new byte[buffer.Remaining()];
                buffer.Get(bytes);
                using (var output = new FileOutputStream(mFile))
                {
                    try
                    {
                        output.Write(bytes);
                    }
                    catch (IOException e)
                    {
                        e.PrintStackTrace();
                    }
                    finally
                    {
                        mImage.Close();
                    }
                }
            }
        }
    }
}