
using Android.Hardware.Camera2;
using Android.Util;

namespace EyesOn.UI.Droid.TakePhoto.Listeners
{
    public class CameraCapturePreviewSessionCallback : CameraCaptureSession.CaptureCallback
    {
        private static readonly string TAG = "CamCaptPreviewSessionCllbck";

        public TakePhotoActivity3 Owner { get; set; }

        public CameraCapturePreviewSessionCallback(TakePhotoActivity3 owner)
        {
            Owner = owner;
        }

        public override void OnCaptureCompleted(CameraCaptureSession session, CaptureRequest request, TotalCaptureResult result)
        {
            //Owner.ShowToast("Saved: " + Owner.mFile);
            //Log.Debug(TAG, Owner.mFile.ToString());
            Log.Error(TAG, "OnCaptureCompleted");
            Owner.UnlockFocus();
        }
    }
}