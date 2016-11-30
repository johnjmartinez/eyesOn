
using Android.Graphics;
using Android.Util;
using Android.Views;

namespace EyesOn.UI.Droid.TakePhoto.Listeners
{
    public class Camera2BasicSurfaceTextureListener : Java.Lang.Object, TextureView.ISurfaceTextureListener
    {
        string TAG = "Camera2BasicSurfaceTextureListener";
        public TakePhotoActivity3 Owner { get; set; }

        public Camera2BasicSurfaceTextureListener(TakePhotoActivity3 owner)
        {
            Owner = owner;
        }

        public void OnSurfaceTextureAvailable(Android.Graphics.SurfaceTexture surface, int width, int height)
        {
            Log.Error(TAG, "OpenCamera:" + width + "," + height);
            Owner.OpenCamera(width, height); 
        }

        public bool OnSurfaceTextureDestroyed(Android.Graphics.SurfaceTexture surface)
        {
            Log.Error(TAG, "OnSurfaceTextureDestroyed!!!!!!!!!");
            return true;
        }

        public void OnSurfaceTextureSizeChanged(Android.Graphics.SurfaceTexture surface, int width, int height)
        {
            Log.Error(TAG, "ConfigureTransform:" + width + "," + height);
            Owner.ConfigureTransform(width, height);
        }

        public void OnSurfaceTextureUpdated(Android.Graphics.SurfaceTexture surface)
        {
            //Log.Error(TAG, "OnSurfaceTextureUpdated");  
            //Owner.PreviewFrame(surface);
        }
    }
}