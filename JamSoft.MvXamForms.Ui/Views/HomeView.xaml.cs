using MvvmCross.Forms.Views;
using Xamarin.Forms;

namespace JamSoft.MvXamForms.Ui.Views
{
    public partial class HomeView : MvxContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}