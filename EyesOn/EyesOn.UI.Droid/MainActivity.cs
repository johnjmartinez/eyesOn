using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
//using Android.Hardware.Camera2;

using EyesOn;
using EyesOn.Data.Model.Server;

using EyesOn.UI.Droid.CameraCalibration;
using EyesOn.UI.Droid.CameraControl;
using EyesOn.UI.Droid.CameraPreview;
using EyesOn.UI.Droid.ColorBlobDetection;
using EyesOn.UI.Droid.TakePhoto;

namespace EyesOn.UI.Droid
{
    [Activity(Label = "EyesOn.UI.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //wire in controller events
            Controller.OnExit += Controller_OnExit;
            Controller.OnLoad += Controller_OnLoad;
            Controller.OnException += Controller_OnException;
            Controller.OnMain += Controller_OnMain;
            //Controller.OnLogin += Controller_OnLogin;
            Controller.OnCameraPreview += Controller_OnCameraPreview;
            Controller.OnCameraControl += Controller_OnCameraControl;
            Controller.OnCameraCalibration += Controller_OnCameraCalibrate;
            Controller.OnColorBlobDetection += Controller_OnColorBlobDetection;
            Controller.OnTakePhoto += Controller_OnTakePhoto;

            //init
            Controller.Instance.Init();
            CacheManager.Instance.Init(new DroidPlatformService(this));

            //load services like camera
        }

        private void Controller_OnTakePhoto()
        {
            StartActivity(typeof(TakePhotoActivity3));
        }

        private void Controller_OnColorBlobDetection()
        {
            StartActivity(typeof(ColorBlobDetectionActivity2));
        }

        private void Controller_OnCameraCalibrate()
        {
            StartActivity(typeof(CameraCalibrationActivity));
        }

        private void Controller_OnCameraControl()
        {
            StartActivity(typeof(CameraControlActivity));
        }

        private void Controller_OnCameraPreview()
        {
            StartActivity(typeof(CameraPreviewActivity));
        }

        private void Controller_OnLogin()
        {
            throw new NotImplementedException();
        }

        Photo NewPicture(byte[] bytes)
        {
            var pictureUpload = new Photo();
            //pictureUpload.Bits = bytes;
            //pictureUpload.StreamKey = Controller.Instance.CurrentStream.Key;
            //String locationProvider = LocationManager.GpsProvider;
            //Location lastKnownLocation = _locationManager.GetLastKnownLocation(locationProvider);
            //if (lastKnownLocation != null)
            //{
            //    pictureUpload.Latitude = lastKnownLocation.Latitude;
            //    pictureUpload.Longitude = lastKnownLocation.Longitude;
            //}
            return pictureUpload;
        }
        byte[] BitmapToByteArray(Bitmap bitmap)
        {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);
            byte[] bitmapData = stream.ToArray();
            return bitmapData;
        }


        private void Controller_OnMain()
        {
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.cameraPreview).Click += (s, e) => Controller.Instance.CameraPreview();
            FindViewById<Button>(Resource.Id.cameraControl).Click += (s, e) => Controller.Instance.CameraControl();
            FindViewById<Button>(Resource.Id.colorBlobDetection).Click += (s, e) => Controller.Instance.ColorBlobDetection();
            FindViewById<Button>(Resource.Id.cameraCalibration).Click += (s, e) => Controller.Instance.CameraCalibration();
            FindViewById<Button>(Resource.Id.takePhoto).Click += (s, e) => Controller.Instance.TakePhoto();
        }

        private void Controller_OnException(string obj)
        {
            throw new NotImplementedException();
        }

        //load routine
        private void Controller_OnLoad()
        {
            Controller.Instance.Loaded();
        }

        //controller wants to shut the app down
        private void Controller_OnExit()
        {
            System.Environment.Exit(0);
        }
    }
}

