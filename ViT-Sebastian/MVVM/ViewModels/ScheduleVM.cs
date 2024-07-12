using CommunityToolkit.Mvvm.ComponentModel;

namespace ViT_Sebastian.MVVM.ViewModels
{
    internal partial class ScheduleVM : BaseViewModel
    {
        [ObservableProperty]
        private DateTime _currentDate = DateTime.Now;
    }
}
