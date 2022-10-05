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
        public ObservableCollection<Model.Types.artikal_dokument> lista_base { get; set; } = new();
        public ObservableCollection<Model.Types.artikal_dokument> lista { get; set; } = new();
        public string PartnerNameFilter { get; set; }
        public ERPDatabase DB = new ERPDatabase("Data Source=jovan-matebook;Initial Catalog=development_abacus;User ID=sa;Password=Abacus331860;Persist Security Info=True;TrustServerCertificate=True;MultipleActiveResultSets=false");
        public Command GetDocumentsCommand { get; }
        public Command FilterByPartnerNameCommand { get; }
        public DetailsViewModel()
        {
            Title = "Dokumenti";
            GetDocumentsCommand = new Command(async () => await GetDocuments());
            FilterByPartnerNameCommand = new Command(async () => await FilterByPartnerName(this.PartnerNameFilter));
        }
        async Task FilterByPartnerName(string filtertext)
        {
            if (IsBusy) return;
            try
            {
                IsBusy = true;
                lista.Clear();
                if(String.IsNullOrEmpty(filtertext)) foreach (var dok in lista_base) lista.Add(dok);
                else
                foreach (var dok in lista_base.Where(qq=> qq.id_partnerNavigation.naziv.Contains(filtertext))) lista.Add(dok);

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
        async Task GetDocuments()
        {
            if (IsBusy) return;
            try
            {

                IsBusy = true;
                lista.Clear();
                lista_base.Clear();
                DateTime dat = new DateTime(2022, 6, 1);
                var art = DB.artikal_dokument.First();
                var temp = DB.artikal_dokument.Where(ww=> ww.id_partner.HasValue).Where(qq => qq.datum >= dat).Include(q => q.id_partnerNavigation).Include(a=> a.id_vrstaNavigation).Take(100).ToList();
                foreach(var dok in temp)
                {
                    lista.Add(dok);
                    lista_base.Add(dok);
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
