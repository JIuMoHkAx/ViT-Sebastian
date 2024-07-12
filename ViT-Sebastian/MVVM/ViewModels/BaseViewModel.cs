using CommunityToolkit.Mvvm.ComponentModel;

namespace ViT_Sebastian.MVVM.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {
            title = "TitleProp";
        }

        [ObservableProperty]
        string title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        public bool IsNotBusy => !IsBusy;
    }
}
