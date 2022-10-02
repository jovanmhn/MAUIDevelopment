using MAUIDevelopment.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDevelopment.ViewModels
{
    public class DetailsViewModel : BaseViewModel
    {
        public ObservableCollection<Model.Types.artikal_dokument> lista { get; set; } = new();
        public ERPDatabase DB = new ERPDatabase("Data Source=jovan-matebook;Initial Catalog=development_abacus;User ID=sa;Password=Abacus331860;Persist Security Info=True;TrustServerCertificate=True;MultipleActiveResultSets=false");
        public Command GetDocumentsCommand { get; }
        public DetailsViewModel()
        {
            Title = "Dokumenti";
            GetDocumentsCommand = new Command(async () => await GetDocuments());
        }
        async Task GetDocuments()
        {
            if (IsBusy) return;
            try
            {
                IsBusy = true;
                lista.Clear();
                DateTime dat = new DateTime(2022, 6, 1);
                var art = DB.artikal_dokument.First();
                var temp = DB.artikal_dokument.Where(qq => qq.datum >= dat).Include(q => q.id_partnerNavigation).Take(100).ToList();
                foreach(var dok in temp)
                {
                    lista.Add(dok);
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Greska", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
