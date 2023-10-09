using System;
using System.Net.Http;
using System.Text.Json;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    public class DailyForecastViewModel
    {
        public static Rootobject DailyForecastViewMod(Root index) 
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "ksmiluti");
                client.BaseAddress = new Uri(index.Properties.Forecast);
                var jSonStuff = client.GetStringAsync(client.BaseAddress).Result;

                Rootobject rootobject = JsonSerializer.Deserialize<Rootobject>(jSonStuff);

                return rootobject;
            }
        }
    }
}
