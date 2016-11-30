
using Android.App;
using Android.Hardware.Camera2;
using Android.Util;

namespace EyesOn.UI.Droid.TakePhoto.Listeners
{
    public class CameraStateListener : CameraDevice.StateCallback
    {
        public TakePhotoActivity3 owner;
        string TAG = "CameraStateListener";

        public override void OnOpened(CameraDevice cameraDevice)
        {
          Log.Error(TAG, "OnOpened");

            // This method is called when the camera is opened.  We start camera preview here.
            owner.mCameraOpenCloseLock.Release();
            owner.mCameraDevice = cameraDevice;
            owner.CreateCameraPreviewSession();
        }

        public override void OnDisconnected(CameraDevice cameraDevice)
        {
            Log.Error(TAG, "OnDisconnected");

            owner.mCameraOpenCloseLock.Release();
            cameraDevice.Close();
            owner.mCameraDevice = null;
        }

        public override void OnError(CameraDevice cameraDevice, CameraError error)
        {
            Log.Error(TAG, "OnError");

            owner.mCameraOpenCloseLock.Release();
            cameraDevice.Close();
            owner.mCameraDevice = null;

            if (owner == null)
                return;

            //Activity activity = owner.Activity;
            //if (activity != null)
            //{
            //    activity.Finish();
            //}

            if(owner != null)
                owner.Finish();
        }
    }
}