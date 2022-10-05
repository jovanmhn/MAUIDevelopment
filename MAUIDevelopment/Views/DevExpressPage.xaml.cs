using AndroidX.Lifecycle;
using MAUIDevelopment.ViewModels;
using DevExpress;

namespace MAUIDevelopment.Views;

public partial class DevExpressPage : ContentPage
{
	public DevExpressPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}