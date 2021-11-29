using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using OTPControl.Droid.Renderer;
using OTPControl.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryControl), typeof(EntryControlRenderer))]
namespace OTPControl.Droid.Renderer
{
    public class EntryControlRenderer : EntryRenderer
    {
        public EntryControlRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null && Element != null)
            {
                Control.Background = null;
                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
            }
        }
    }
}