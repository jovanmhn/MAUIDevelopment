using MAUIDevelopment.Views;
using Microsoft.EntityFrameworkCore;

namespace MAUIDevelopment;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Views.ListView));
	}

	private async void List2Btn_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Views.DetailsPage));
    }

	private async void List2DX_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Views.DevExpressPage));
    }

	private async void List2DXGrid_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Views.DevExpressGridPage));
    }
}

