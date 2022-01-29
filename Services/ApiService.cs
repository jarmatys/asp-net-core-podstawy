using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Test_web_app.Models;
using Test_web_app.Services.Interfaces;

namespace Test_web_app.Services
{
    public class ApiService : IApiService
    {
        private const string API_KEY = "TWÓJ_API_KEY";

        public WeatherResponse Get(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API_KEY}";

            var web = new WebClient();

            var response = web.DownloadString(url);

            var myDeserializedClass = JsonConvert.DeserializeObject<WeatherResponse>(response); // json2csharp

            myDeserializedClass.main.temp_min = myDeserializedClass.main.temp_min - 273.15;
            myDeserializedClass.main.temp_max = myDeserializedClass.main.temp_max - 273.15;

            return myDeserializedClass;
        }
    }
}
