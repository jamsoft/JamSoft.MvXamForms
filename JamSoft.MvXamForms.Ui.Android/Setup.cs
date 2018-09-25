using System.Collections.Generic;
using System.Reflection;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using JamSoft.MvXamForms.Core;
using JamSoft.MvXamForms.Ui.Droid.MvxBindings;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Forms.Platforms.Android.Core;

namespace JamSoft.MvXamForms.Ui.Droid
{
    public class Setup : MvxFormsAndroidSetup<CoreApp, App>
    {
        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
        {
            typeof(NavigationView).Assembly,
            typeof(CoordinatorLayout).Assembly,
            typeof(FloatingActionButton).Assembly,
            typeof(Toolbar).Assembly,
            typeof(DrawerLayout).Assembly,
            typeof(ViewPager).Assembly,
            //typeof(MvxRecyclerView).Assembly,
            typeof(MvxSwipeRefreshLayout).Assembly
        };

        // ReSharper disable once RedundantOverriddenMember
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            // register an instance
            //Mvx.IoCProvider.RegisterType(() => UserDialogs.Instance);

            // register a type
            //Mvx.IoCProvider.RegisterType<IMyService, MyService>();
        }

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            MvxAppCompatSetupHelper.FillTargetFactories(registry);
            base.FillTargetFactories(registry);

            registry.RegisterFactory(new MvxCustomBindingFactory<SwipeRefreshLayout>("IsRefreshing", (swipeRefreshLayout) => new SwipeRefreshLayoutIsRefreshingTargetBinding(swipeRefreshLayout)));
        }
    }
}