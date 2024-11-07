using CommunityToolkit.Mvvm.Input;
using MediSeen.IViews;
using MediSeen.Services;
using MediSeen.MVVM.Views.Android;
using MediSeen.MVVM.Views.Windows;
using System;

namespace MediSeen.MVVM.ViewModels
{
    public partial class MainPageViewModel
    {
        private INavigation _navigationService;
        public MainPageViewModel(INavigation navigation)
        {
            this._navigationService = navigation;
        }

        [RelayCommand]
        private async void NavigateToSecondPage()
        {
            await _navigationService.PushAsync(ViewServices.ResolvePage<ISecondPage>("Test Data"));
        }
    }
}
