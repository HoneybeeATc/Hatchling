using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAndroid
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate(bundle);
            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;

            var aLabel = new TextView(this);
            aLabel.SetText(Resource.String.Hello);

            var aButton = new Button(this);
            aButton.SetText(Resource.String.aButton);
            aButton.Click += (sender, e) => {
                aLabel.SetText(Resource.String.aLabel);};
            
            var resetButton = new Button(this);
            resetButton.SetText(Resource.String.resetButton);
            resetButton.Click += (sender, e) => {
                aLabel.SetText(Resource.String.Hello);};

            layout.AddView(aButton);
            layout.AddView(aLabel);
            layout.AddView(resetButton);
            SetContentView(layout);      
            
        }
    }
}

