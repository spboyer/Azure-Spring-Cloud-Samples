using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Microsoft.Azure.SpringCloud.Sample.WeatherApp
{
    public class SolarSystemService : ISolarSystemService
    {
        private const string SERVICE_URL = "https://solar-system-weather/weatherforecast";
        private HttpClient _client;

        public SolarSystemService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<KeyValuePair<string, string>>> GetPlanetWeather()
        {
            return await _client.GetFromJsonAsync<IEnumerable<KeyValuePair<string, string>>>(SERVICE_URL);
        }

    }

    public interface ISolarSystemService
    {
        Task<IEnumerable<KeyValuePair<string, string>>> GetPlanetWeather();
    }
}
