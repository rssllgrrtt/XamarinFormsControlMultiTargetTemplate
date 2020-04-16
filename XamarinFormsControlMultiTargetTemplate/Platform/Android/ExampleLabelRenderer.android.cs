using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsControlMultiTargetTemplate.Platform.Android;
using XamarinFormsControlMultiTargetTemplate;

[assembly: ExportRenderer(typeof(ExampleLabel), typeof(ExampleLabelRenderer))]

namespace XamarinFormsControlMultiTargetTemplate.Platform.Android
{
    public class ExampleLabelRenderer : LabelRenderer
    {
        public ExampleLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Text = "Hello from Android!";
            }
        }
    }
}