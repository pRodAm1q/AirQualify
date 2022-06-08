using AirQualify.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using AirQualify.Model;
using AirQualify.Services;
namespace AirQualify.ViewModel
{


   
    public class HomeViewModel : ObservableObject
    {
        private RelayCommand _searchCity;
        


        private readonly SearchGetAQI search = new SearchGetAQI();

      //  public RelayCommand SearchCity => _searchCity ?? (_searchCity = new RelayCommand<string>(SearchMethod));
       

    }

}
