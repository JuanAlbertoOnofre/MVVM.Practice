using MVVM.Practice.ViewModel;

namespace MVVM.Practice.View;

public partial class HomePage : ContentPage
{
	//Dependency injection
	private readonly HomeViewModel _viewModel;
	public HomePage(HomeViewModel viewModel)
	{
		BindingContext = _viewModel = viewModel;
		InitializeComponent();
	}

	public HomePage() { }
}