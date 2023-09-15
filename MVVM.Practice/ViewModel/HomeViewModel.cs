#region "Usings"
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Practice.ViewModel.Base;
#endregion

namespace MVVM.Practice.ViewModel;
public partial class HomeViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _textEntry;

    [ObservableProperty]
    private string _textLabel;

    [RelayCommand]
    private void ShowString()
    {

    }

}

