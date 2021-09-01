using Microsoft.AspNetCore.Components;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MQtraining.UI.Services.Orders
{
    public class OrderDataService : IOrderDataService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        public OrderDataService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public async Task<ICollection<OrderResponse>> GetAllOrders()
        {
            return await JsonSerializer.DeserializeAsync<ICollection<OrderResponse>>
                (await _httpClient.GetStreamAsync($"api/v1/order"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<OrderResponse> CreateOrder(OrderRequest orderRequest)
        {
            var orderJson =
                new StringContent(JsonSerializer.Serialize(orderRequest), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/v1/order", orderJson);

            if (response.IsSuccessStatusCode)
            {
                _navigationManager.NavigateTo("orders");

                return await JsonSerializer.DeserializeAsync<OrderResponse>(await response.Content.ReadAsStreamAsync());
            }
            else
            {
                return null;
            }
        }

        public async Task<OrderResponse> GetOrderById(Guid OrderId)
        {
            return await JsonSerializer.DeserializeAsync<OrderResponse>
                (await _httpClient.GetStreamAsync($"api/v1/order/{OrderId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
