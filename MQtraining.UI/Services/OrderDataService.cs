using MQtraining.Services.ResponseModels;
using MQtraining.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MQtraining.UI.Services
{
    public class OrderDataService : IOrderDataService
    {
        private readonly HttpClient _httpClient;

        public OrderDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<OrderResponse>> GetAllOrders()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<OrderResponse>>
                (await _httpClient.GetStreamAsync($"api/v1/order"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

    }
}
