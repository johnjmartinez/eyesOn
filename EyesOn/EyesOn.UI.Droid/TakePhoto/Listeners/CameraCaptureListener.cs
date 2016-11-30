
using Android.Hardware.Camera2;
using Android.Util;

using Java.IO;
using Java.Lang;

namespace EyesOn.UI.Droid.TakePhoto.Listeners
{
    public class CameraCaptureListener : CameraCaptureSession.CaptureCallback
    {
        public TakePhotoActivity3 Owner { get; set; }
        public File File { get; set; }
        string TAG = "CamCaptListener";

        public override void OnCaptureCompleted(CameraCaptureSession session, CaptureRequest request, TotalCaptureResult result)
        {
            Log.Error(TAG, "OnCaptureCompleted");
            Process(result);
        }

        public override void OnCaptureProgressed(CameraCaptureSession session, CaptureRequest request, CaptureResult partialResult)
        {
            Log.Error(TAG, "OnCaptureProgressed");
            Process(partialResult);
        }

        public override void OnCaptureStarted(CameraCaptureSession session, CaptureRequest request, long timestamp, long frameNumber)
        {
            Log.Error(TAG, "OnCaptureStarted");
            base.OnCaptureStarted(session, request, timestamp, frameNumber);
        }

        public override void OnCaptureSequenceCompleted(CameraCaptureSession session, int sequenceId, long frameNumber)
        {
            Log.Error(TAG, "OnCaptureSequenceCompleted");
            base.OnCaptureSequenceCompleted(session, sequenceId, frameNumber);
        }

        private void Process(CaptureResult result)
        {
            switch (Owner.mState)
            {
                case TakePhotoActivity3.STATE_PREVIEW:
                    {
                        //Owner.CapturePreviewShot();
                        Log.Error(TAG, "STATE_PREVIEW");
                        break;
                    }
                case TakePhotoActivity3.STATE_WAITING_LOCK:
                    {
                        Log.Error(TAG, "STATE_WAITING_LOCK");

                        Integer afState = (Integer)result.Get(CaptureResult.ControlAfState);
                        if (afState == null)
                        {
                            Owner.CaptureStillPicture();
                        }

                        else if ((((int)ControlAFState.FocusedLocked) == afState.IntValue()) ||
                                   (((int)ControlAFState.NotFocusedLocked) == afState.IntValue()))
                        {
                            // ControlAeState can be null on some devices
                            Integer aeState = (Integer)result.Get(CaptureResult.ControlAeState);
                            if (aeState == null ||
                                    aeState.IntValue() == ((int)ControlAEState.Converged))
                            {
                                Owner.mState = TakePhotoActivity3.STATE_PICTURE_TAKEN;
                                Owner.CaptureStillPicture();
                            }
                            else
                            {
                                Owner.RunPrecaptureSequence();
                            }
                        }
                        break;
                    }
                case TakePhotoActivity3.STATE_WAITING_PRECAPTURE:
                    {
                        Log.Error(TAG, "STATE_WAITING_PRECAPTURE");

                        // ControlAeState can be null on some devices
                        Integer aeState = (Integer)result.Get(CaptureResult.ControlAeState);
                        if (aeState == null ||
                                aeState.IntValue() == ((int)ControlAEState.Precapture) ||
                                aeState.IntValue() == ((int)ControlAEState.FlashRequired))
                        {
                            Owner.mState = TakePhotoActivity3.STATE_WAITING_NON_PRECAPTURE;
                        }
                        break;
                    }
                case TakePhotoActivity3.STATE_WAITING_NON_PRECAPTURE:
                    {
                        Log.Error(TAG, "STATE_WAITING_NON_PRECAPTURE");

                        // ControlAeState can be null on some devices
                        Integer aeState = (Integer)result.Get(CaptureResult.ControlAeState);
                        if (aeState == null || aeState.IntValue() != ((int)ControlAEState.Precapture))
                        {
                            Owner.mState = TakePhotoActivity3.STATE_PICTURE_TAKEN;
                            Owner.CaptureStillPicture();
                        }
                        break;
                    }
            }
        }
    }
}