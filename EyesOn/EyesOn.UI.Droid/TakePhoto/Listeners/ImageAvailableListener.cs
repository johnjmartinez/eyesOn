
using Android.Media;

using Java.IO;
using Java.Lang;
using Java.Nio;

using Emgu.CV;
using Android.Graphics;

namespace EyesOn.UI.Droid.TakePhoto.Listeners
{
    public class ImageAvailableListener : Java.Lang.Object, ImageReader.IOnImageAvailableListener
    {
        public File File { get; set; }
        public TakePhotoActivity3 Owner { get; set; }

        public void OnImageAvailable(ImageReader reader)
        {
            //if (Owner.CLEAR_CANVAS)
            //    Owner.mBackgroundHandler.Post(new ImageSaver(reader.AcquireNextImage(), Owner.mFile));
            if (!Owner.isBusy)
                return;

            //Android.Util.Log.Error("ImageAvailableListener", "OnImageAvailable");
            Image image = reader.AcquireLatestImage();

            if (image != null)
            {
                ByteBuffer rgb = image.GetPlanes()[0].Buffer;
                //ByteBuffer Y = image.GetPlanes()[0].Buffer;
                //ByteBuffer U = image.GetPlanes()[1].Buffer;
                //ByteBuffer V = image.GetPlanes()[2].Buffer;

                byte[] data = new byte[rgb.Remaining()];
                rgb.Get(data);

                /*
                int p;
                int size = image.Height * image.Width;
                byte[] pixels = new byte[size];

                for (int i = 0; i < size; i++)
                {
                    p = data[i] & 0xFF;
                    //pixels[i] = 0xFF000000 | p << 16 | p << 8 | p;
                    //pixels[i] =  (byte) Color.Argb(0xFF, p, p, p);
                    pixels[i] = (byte)Color.Rgb(p, p, p);
                }

                Mat imgMat = new Mat(image.Height, image.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 3);
                */

                Mat imgMat = new Mat(image.Height, image.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
                CvInvoke.Imdecode(data, Emgu.CV.CvEnum.ImreadModes.Unchanged, imgMat);
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