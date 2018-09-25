using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace JamSoft.MvXamForms.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterCustomAppStart<AppStart>();
        }
    }
}