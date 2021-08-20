using Microsoft.AspNetCore.Components;
using MQtraining.Shared.RequestModels;
using MQtraining.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MQtraining.UI.Services.LineItems
{
    public class LineItemDataService : ILineItemDataService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        public LineItemDataService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public async Task<LineItemResponse> CreateLineItem(LineItemRequest lineItemRequest)
        {
            var lineItemJson =
                new StringContent(JsonSerializer.Serialize(lineItemRequest), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/v1/lineitem", lineItemJson);

            if (response.IsSuccessStatusCode)
            {
                _navigationManager.NavigateTo("items");

                return await JsonSerializer.DeserializeAsync<LineItemResponse>(await response.Content.ReadAsStreamAsync());
            }
            else
            {
                return null;
            }
        }
    }
}
