using Android.Graphics.Drawables;
using BaiTapDanhGia;
using BaiTapDanhGia.Droid;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete

namespace BaiTapDanhGia.Droid
{
    [Obsolete]
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                //Control.SetBackgroundResource(Resource.Layout.rounded_shape);
                var gradientDrawable = new GradientDrawable();
                //  gradientDrawable.SetCornerRadius(60f);
                //   gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
                gradientDrawable.SetColor(Android.Graphics.Color.Transparent);
                Control.SetBackground(gradientDrawable);
                //  Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight,
                //    Control.PaddingBottom);
            }
        }
    }
}