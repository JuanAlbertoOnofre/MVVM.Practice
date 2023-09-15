#region "Usings"
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
#endregion

namespace MVVM.Practice.ViewModel.Base
{
    public abstract partial class ViewModelBase : ObservableObject, IViewModelBase
    {
        #region "Properties"
        private long _isBusy;
        public bool IsBusy => Interlocked.Read(ref _isBusy) > 0;
        public IAsyncRelayCommand InitializeAsyncCommand { get; }

        [ObservableProperty]
        private bool _isInitialized;
        #endregion

        #region "Bulder"
        public ViewModelBase()
        {
            InitializeAsyncCommand = new AsyncRelayCommand(async () =>
            {
                await IsBusyFor(InitializeAsync);
                IsInitialized = true;
            },
            AsyncRelayCommandOptions.FlowExceptionsToTaskScheduler);
        }
        #endregion

        #region "Methods"
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {

        }
        #endregion

        #region "Tasks"
        public Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        public async Task IsBusyFor(Func<Task> unitOfWork)
        {
            Interlocked.Increment(ref _isBusy);
            OnPropertyChanged(nameof(IsBusy));

            try
            {
                await unitOfWork();
            }
            finally
            {
                Interlocked.Decrement(ref _isBusy);
                OnPropertyChanged(nameof(IsBusy));
            }
        }
        #endregion
    }
}
