using Android.App;
using Android.Widget;
using Android.OS;

namespace JD.Android
{
    [Activity(Label = "JD.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }
    }
}

