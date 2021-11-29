using Foundation;
using OTPControl.iOS.Renderer;
using OTPControl.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryControl), typeof(EntryControlRenderer))]
namespace OTPControl.iOS.Renderer
{
    public class EntryControlRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null && Element != null)
            {
                Control.BackgroundColor = Color.Transparent.ToUIColor();
                Control.Layer.BackgroundColor = Color.Transparent.ToCGColor();
                Control.BorderStyle = UITextBorderStyle.None;
                Control.InputAccessoryView = null;
                Control.TintColor = Color.Transparent.ToUIColor();
            }
        }
    }
}