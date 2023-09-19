using MVVM.Practice.ViewModel.Base;

namespace MVVM.Practice.View;
public abstract class ContentPageBase : ContentPage
{
    #region Builder
    public ContentPageBase()
    {
        NavigationPage.SetBackButtonTitle(this, string.Empty);
    }
    #endregion

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if(BindingContext is not IViewModelBase ivmb)
        {
            return;
        }
        await ivmb.InitializeAsyncCommand.ExecuteAsync(null);
    }
}

