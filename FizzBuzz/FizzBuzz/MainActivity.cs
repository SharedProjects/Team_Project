using Android.App;
using Android.Widget;
using Android.OS;

namespace FizzBuzz
{
    [Activity(Label = "FizzBuzz", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }//Chris Fababe - Can you see this?

    //yes!
    // Fababe confirmed.
    // Bennett confirmed.
    //Steve confirmed.
    //kuljit confirmed.
    //Tyler confirmed.
}

