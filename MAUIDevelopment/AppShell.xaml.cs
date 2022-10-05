using MAUIDevelopment.Views;

namespace MAUIDevelopment;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.ListView), typeof(Views.ListView));
        Routing.RegisterRoute(nameof(Views.DetailsPage), typeof(Views.DetailsPage));
        Routing.RegisterRoute(nameof(Views.DevExpressPage), typeof(Views.DevExpressPage));
        Routing.RegisterRoute(nameof(Views.DevExpressGridPage), typeof(Views.DevExpressGridPage));
    }
}
