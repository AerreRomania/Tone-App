using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using Tone.iOS.Renderer;
using Tone.Render;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryiOS))]
namespace Tone.iOS.Renderer
{
    class CustomEntryiOS: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 10;
                Control.Layer.BorderWidth = 2f;
                Control.Layer.BorderColor = Color.FromHex("#06bbdc").ToCGColor();
                Control.BackgroundColor = Color.White.ToUIColor();
                //Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                //Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
           
        }
    }
}