using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using JamSoft.MvXamForms.Core;
using MvvmCross.Forms.Platforms.Android.Views;

namespace JamSoft.MvXamForms.Ui.Droid
{
    [Activity(Label = "JamSoft.MvXamForms.Ui", 
        Icon = "@mipmap/icon", 
        Theme = "@style/MainTheme", 
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        LaunchMode = LaunchMode.SingleTask)]
    // ReSharper disable once UnusedMember.Global
    public class MainActivity : MvxFormsAppCompatActivity<Setup, CoreApp, App>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            
            //RequestWindowFeature(WindowFeatures.NoTitle);

            //Window.RequestFeature(WindowFeatures.NoTitle);

            base.OnCreate(savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            //LoadApplication(new App()); // if you retrofit MvvmCross into an app remember to remove this line!
        }
    }
}