using ConverterAPI.Interfaces;
using Newtonsoft.Json;


namespace ConverterAPI.Service
{
    public class ConversionRateService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "08a384b4f334fd51973e5365"; 

        public ConversionRateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IConversionRate> GetUsdToBrlRateAsync()
        {
            var response = await _httpClient.GetAsync($"https://v6.exchangerate-api.com/v6/{_apiKey}/pair/USD/BRL");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ExchangeRateResponse>(jsonString);

                return new ConversionRate { BRL = result.conversion_rate };
            }
            else
            {
                throw new HttpRequestException("Não foi possível obter a taxa de conversão.");
            }
        }
    }

    public class ExchangeRateResponse
    {
        public double conversion_rate { get; set; }
    }

}
