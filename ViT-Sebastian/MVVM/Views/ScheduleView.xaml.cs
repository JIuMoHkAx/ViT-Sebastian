using ViT_Sebastian.MVVM.ViewModels;

namespace ViT_Sebastian.MVVM.Views;

public partial class ScheduleView : ContentPage
{
	public ScheduleView()
	{
		InitializeComponent();
        BindingContext = new ScheduleVM();
    }
}