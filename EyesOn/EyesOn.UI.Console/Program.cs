using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EyesOn;
using EyesOn.Data.Model.Requests;

//using OpenCV.Core;
//using OpenCV.ObjDetect;

using OpenCvSharp;

namespace EyesOn.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Controller.Instance.Init();

            //run some test 
            //TODO: this could be repalced with a command factory

            //UserLoginTest();

            TestFace();

            System.Console.WriteLine("Press ENTER to exit");
            System.Console.ReadLine();
        }

        static void UserLoginTest()
        {
            var credentials = new UserCredentials();
            credentials.Email = "someuser@gmail.com";
            credentials.Password = "password";

            Task t = Controller.Instance.Login(credentials);
            t.Wait();
        }

        static void TestFace()
        {
            // Load the cascades
            var haarCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
            //var lbpCascade = new CascadeClassifier(FilePath.Text.LbpCascade);

            // Detect faces
            Mat haarResult = DetectFace(haarCascade);
            var bytes = haarResult.ToBytes(".png");

            ByteArrayToFile("lena2.png", bytes);
        }

        static Mat DetectFace(CascadeClassifier cascade)
        {
            Mat result;

            using (var src = new Mat("lena.jpg", ImreadModes.Color))
            using (var gray = new Mat())
            {
                result = src.Clone();
                Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);

                // Detect faces
                Rect[] faces = cascade.DetectMultiScale(gray, 1.08, 2, HaarDetectionType.ScaleImage, new Size(30, 30));

                // Render all detected faces
                foreach (Rect face in faces)
                {
                    var center = new Point
                    {
                        X = (int)(face.X + face.Width * 0.5),
                        Y = (int)(face.Y + face.Height * 0.5)
                    };
                    var axes = new Size
                    {
                        Width = (int)(face.Width * 0.5),
                        Height = (int)(face.Height * 0.5)
                    };
                    Cv2.Ellipse(result, center, axes, 0, 0, 360, new Scalar(255, 0, 255), 4);
                }
            }
            return result;
        }

        static bool ByteArrayToFile(string _FileName, byte[] _ByteArray)
        {
            try
            {
                // Open file for reading
                System.IO.FileStream _FileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                // Writes a block of bytes to this stream using data from
                // a byte array.
                _FileStream.Write(_ByteArray, 0, _ByteArray.Length);

                // close file stream
                _FileStream.Close();

                return true;
            }
            catch (Exception _Exception)
            {
                // Error
                System.Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
            }

            // error occured, return false
            return false;
        }
    }
}
