using MAUIDevelopment.ViewModels;

namespace MAUIDevelopment.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}