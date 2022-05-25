using AirQualify.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace AirQualify.ViewModel
{


   
    public class HomeViewModel : ObservableObject
    {
    //    private string _searchValue;

    //    public string SearchValue { get => _searchValue ; set { _searchValue = value; OnPropertyChanged(); } }
       
    //    public async void GetData()
    //    {
    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new($"http://api.waqi.info/feed/{SearchValue}/?token=795089feaf4570da25cbe9896ff551e54eaff9bc"),
    //        };

    //        using (var response =  await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var body = await response.Content.ReadAsStringAsync();
    //            JObject json = JObject.Parse(body);
    //            var aqiValue = json["data"]["aqi"];
    //            var searchCityName = json["data"]["city"]["name"];
    //            var coValue = json["data"]["iaqi"]["co"]["v"];
    //            var no2Value = json["data"]["iaqi"]["no2"]["v"];           
    //            var o3Value = json["data"]["iaqi"]["o3"]["v"];
    //            var wValue = json["data"]["iaqi"]["w"]["v"];
    //        }

    //    }
    }

}
