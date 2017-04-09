using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAndroidXML
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivityXML : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            TextView aLabel = FindViewById<TextView>(Resource.Id.aLabel);
            Button aButton = FindViewById<Button>(Resource.Id.aButton);
            aButton.Click += (sender, e) =>
            {
                aLabel.SetText(Resource.String.aLabel);
            };
            Button resetButton = FindViewById<Button>(Resource.Id.resetButton);
            resetButton.Click += (sender, e) =>
            {
                aLabel.SetText(Resource.String.Hello);
            };
            // Set our view from the "main" layout resource

        }
    }
}

