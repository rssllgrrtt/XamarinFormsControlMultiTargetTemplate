using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsControlMultiTargetTemplate;
using XamarinFormsControlMultiTargetTemplate.Platform.Apple;

[assembly: ExportRenderer(typeof(ExampleLabel), typeof(ExampleLabelRenderer))]

namespace XamarinFormsControlMultiTargetTemplate.Platform.Apple
{
    public class ExampleLabelRenderer : LabelRenderer
    {
        public ExampleLabelRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Text = "Hello from iOS!";
            }
        }
    }
}