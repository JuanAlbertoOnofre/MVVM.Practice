using MVVM.Practice.View;
using MVVM.Practice.ViewModel;

namespace MVVM.Practice
{
    public partial class MainPage : ContentPageBase
    {
        private readonly HomeViewModel _homeViewModel;
        public MainPage(HomeViewModel homeViewModel)
        {

            InitializeComponent();
            BindingContext = _homeViewModel = homeViewModel;
        }

    }
}