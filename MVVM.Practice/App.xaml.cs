using MVVM.Practice.View;

namespace MVVM.Practice
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}