
using Android.Hardware.Camera2;
using Android.Util;

namespace EyesOn.UI.Droid.TakePhoto.Listeners
{
    public class CameraCaptureSessionCallback : CameraCaptureSession.StateCallback
    {
        public TakePhotoActivity3 Owner { get; set; }
        string TAG = "CamCaptSessionCallback";

        public CameraCaptureSessionCallback(TakePhotoActivity3 owner)
        {
            Owner = owner;
        }

        public override void OnConfigureFailed(CameraCaptureSession session)
        {
            //Owner.ShowToast("Failed");            
            Log.Error(TAG, "OnConfigureFailed");
        }

        public override void OnConfigured(CameraCaptureSession session)
        {
            Log.Error(TAG, "OnConfigured");

            // The camera is already closed
            if (null == Owner.mCameraDevice)
                return;

            // When the session is ready, we start displaying the preview.
            Owner.mCaptureSession = session;
            try
            {
                Log.Error(TAG, "OnConfigured -- in session");

                // Auto focus should be continuous for camera preview.
                Owner.mPreviewRequestBuilder.Set(CaptureRequest.ControlAfMode, (int)ControlAFMode.ContinuousPicture);
                // Flash is automatically enabled when necessary.
                Owner.SetAutoFlash(Owner.mPreviewRequestBuilder);

                // Finally, we start displaying the camera preview.
                Owner.mPreviewRequest = Owner.mPreviewRequestBuilder.Build();
                Owner.mCaptureSession.SetRepeatingRequest(Owner.mPreviewRequest, Owner.mCaptureCallback, Owner.mBackgroundHandler);
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
        }
    }
}