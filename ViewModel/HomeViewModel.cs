using AirQualify.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using AirQualify.Model;
using AirQualify.Services;
using System;

namespace AirQualify.ViewModel
{



    public class HomeViewModel : ObservableObject
    {

        #region Свойства 

        private string _searchValue;
        private string? _searchResult = null;

        #region SearchValue
        public string SearchValue
        {
            get { return _searchValue; }
            set
            {

                _searchValue = value;
                OnPropertyChanged();
                //if (_searchValue != value)
                //{
                //    SearchResult = null;
                //    _searchValue = value;
                //    OnPropertyChanged();
                //}
            }

        }
        #endregion

        public string? SearchResult { get => _searchResult; private set { _searchResult = value; OnPropertyChanged(); } }
        #endregion

        #region Команды
        private RelayCommand? _getAQi;
        public RelayCommand GetAQi => _getAQi ??= new RelayCommand(GetInfo);
        #endregion

        #region Методы
        private async void GetInfo(object par)
        {
            HttpClient? client = new HttpClient();
            HttpRequestMessage? request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"http://api.waqi.info/feed/{SearchValue}/?token=795089feaf4570da25cbe9896ff551e54eaff9bc"),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject? json = JObject.Parse(body);
                string? StatusResponse = (string?)json["status"];
                if (StatusResponse == "ok")
                {
                    #region Переменные
                    var aqiValue = json["data"]["aqi"];
                    var indx = json["data"]["idx"];
                    var NameCity = json["data"]["city"]["name"];
                    #region Идеи
                    //   var COvalue = json["data"]["iaqi"]["co"]["v"];
                    //   var NO2value = json["data"]["iaqi"]["no2"]["v"];
                    //   var SO2value = json["data"]["iaqi"]["so2"]["v"];
                    //   var O3value = json["data"]["iaqi"]["o3"]["v"];
                    #endregion
                    var TempValue = json["data"]["iaqi"]["t"]["v"];

                    #endregion
                    // string? result = $"Название: {SearchValue}\n" +
                    SearchResult = $"Название: {SearchValue}\n" +
                        $"Индекс: {indx}\n" +
                        $"AQI: {aqiValue}\n" +
                        $"Температура: {TempValue}\n";
                    #region Идеи в ответе
                    //     $"CO: {COvalue}\n" +
                    //     $"NO2: {NO2value}\n" +
                    //     $"o3: {O3value}\n" +
                    //     $"SO2: {SO2value}"
                    #endregion
                    //  SearchResult = result;
                }
                else
                {

                    SearchResult = "Ничего не найдено";

                }
            }

        }
        #endregion


    }

}
