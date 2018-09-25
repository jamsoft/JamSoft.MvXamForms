using MvvmCross.Navigation;

namespace JamSoft.MvXamForms.Core.ViewModels
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class HomeViewModel : BaseViewModel
    {
        // ReSharper disable once NotAccessedField.Local
        private readonly IMvxNavigationService _navigationService;
        private string _message;

        public HomeViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        // ReSharper disable once UnusedMember.Global
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public override void Start()
        {
            base.Start();

            Message = "Welcome to MvXamForms!";
        }
    }
}