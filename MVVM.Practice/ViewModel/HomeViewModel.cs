#region "Usings"
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Practice.BL;
using MVVM.Practice.Model;
using MVVM.Practice.ViewModel.Base;
#endregion

namespace MVVM.Practice.ViewModel;
public partial class HomeViewModel : ViewModelBase
{
    public HomeViewModel() { }

    [ObservableProperty]
    private string _textEntry;

    [ObservableProperty]
    private string _textLabel;

    [ObservableProperty]
    private Palabras _palabras = new Palabras();

    [RelayCommand]
    private void ShowString()
    {
        HomeBL homeBL = new HomeBL();
        var response = homeBL.GetString();
        TextLabel = TextEntry;
    }

    [RelayCommand]
    private void ShowInLabelAndEntry()
    {
        TextLabel = Palabras.Text1;
        TextEntry = Palabras.Text2;
    }

}

