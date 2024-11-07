using MediSeen.MVVM.Views.Android;
using MediSeen.MVVM.Views.Windows;
using MediSeen.IViews;
using MediSeen.Services;

namespace MediSeen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(ViewServices.ResolvePage<IMainPage>());

        }
    }
}
