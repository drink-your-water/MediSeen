using MediSeen.MVVM.Views.Android;
using MediSeen.MVVM.Views.Windows;

namespace MediSeen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if ANDROID || IOS
            MainPage = new NavigationPage(new AndroidMainPage());
#else
    MainPage = new NavigationPage(new WindowsMainPage());
#endif
        }
    }
}
