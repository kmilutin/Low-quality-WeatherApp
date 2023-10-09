using System;
using System.Net.Http;
using System.Text.Json;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    public class IndexViewModel
    {
        public static Root IndexViewMod()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "ksmiluti");
                client.BaseAddress = new Uri("https://api.weather.gov/points/29.2703,-94.8642");
                var jSonStuff = client.GetStringAsync(client.BaseAddress).Result;

                Root root = JsonSerializer.Deserialize<Root>(jSonStuff);

                return root;
            }
        }

    }
}
