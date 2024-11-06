using System;

namespace MediSeen.MVVM.ViewModels
{
    public class StartPageViewModel
    {
        private INavigation _navigationService;
        public StartPageViewModel(INavigation navigation)
        {
            this._navigationService = navigation;
        }
    }
}
