namespace ViT_Sebastian.MVVM.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
        InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(ScheduleView)}");
    }
}