using Microsoft.EntityFrameworkCore;

namespace MAUIDevelopment.Views;

public partial class ListView : ContentPage
{
	public ListView()
	{
		InitializeComponent();
        Model.ERPDatabase DB = new Model.ERPDatabase("Data Source=jovan-matebook;Initial Catalog=development_abacus;User ID=sa;Password=Abacus331860;Persist Security Info=True;TrustServerCertificate=True;MultipleActiveResultSets=false");
        DateTime dat = new DateTime(2022, 6, 1);
        var art = DB.artikal_dokument.First();
        var lista = DB.artikal_dokument.Where(qq => qq.datum >= dat).Include(q=> q.id_partnerNavigation).Take(100).ToList();

        ColView1.ItemsSource = lista;
    }
}