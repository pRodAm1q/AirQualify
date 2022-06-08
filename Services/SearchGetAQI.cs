using AirQualify.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AirQualify.Services
{
    class SearchGetAQI
    {
        
        
        public async void SearchFunc(string? title)
        {
            // title = searchBox.Text;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new($"http://api.waqi.info/feed/{title}/?token=795089feaf4570da25cbe9896ff551e54eaff9bc"),
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(body);
                var aqiValue = json["data"]["aqi"];
                var searchCityName = json["data"]["city"]["name"];
                var wValue = json["data"]["iaqi"]["w"]["v"];


                //Console.WriteLine($"{searchCityName}\n " +
                //    $"{aqiValue}\n" +

                //    $"{wValue}");
                //MessageBox.Show($"Город: {searchCityName}\nAQI: {aqiValue}\nw: {wValue}");
            }
        }

    }
}

