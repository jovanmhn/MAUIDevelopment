using MAUIDevelopment.Model.Types;
using MAUIDevelopment.ViewModels;

namespace MAUIDevelopment.Views;

public partial class DevExpressGridPage : ContentPage
{
    public DevExpressGridPage(DetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void CheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        DevExDataGrid.ShowAutoFilterRow = dxCheckEdit.IsChecked.Value;
        if (dxCheckEdit.IsChecked.Value) BtnLoad.HeightRequest = 0;
        else BtnLoad.HeightRequest = 50;

    }

    private void DevExDataGrid_DoubleTap(object sender, DevExpress.Maui.DataGrid.DataGridGestureEventArgs e)
    {
        Shell.Current.DisplayAlert("Yo", $"Double tap detektovan, dok broj {((artikal_dokument)e.Item).broj.ToString()}", "OK KRALJU");
    }

    private void DevExDataGrid_LongPress(object sender, DevExpress.Maui.DataGrid.DataGridGestureEventArgs e)
    {
        Shell.Current.DisplayAlert("Yo", $"Long press detektovan, dok broj {((artikal_dokument)e.Item).broj.ToString()}", "OK KRALJU");
    }
}