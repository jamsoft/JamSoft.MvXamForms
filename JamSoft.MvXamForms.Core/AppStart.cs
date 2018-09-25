using System.Threading.Tasks;
using JamSoft.MvXamForms.Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace JamSoft.MvXamForms.Core
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
            : base(app, mvxNavigationService)
        {}

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<HomeViewModel>();
        }
    }
}
