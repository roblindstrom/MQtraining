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


namespace MQtraining.UI.Services.Items
{
    public class ItemDataService : ComponentBase, IItemDataService 
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        public ItemDataService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public async Task<ItemResponse> CreateItem(ItemRequest itemRequest)
        {
            var itemJson =
                new StringContent(JsonSerializer.Serialize(itemRequest), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/v1/item", itemJson);

            if (response.IsSuccessStatusCode)
            {
                _navigationManager.NavigateTo("items");
                
                return await JsonSerializer.DeserializeAsync<ItemResponse>(await response.Content.ReadAsStreamAsync());
            }
            else 
            {
                return null;
            }
        }

        public async Task<IEnumerable<ItemResponse>> GetAllItems()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ItemResponse>>
                (await _httpClient.GetStreamAsync($"api/v1/item"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateItem(ItemRequest item)
        {
            var itemJson =
                new StringContent(JsonSerializer.Serialize(item), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"api/v1/item", itemJson);
        }

        public async Task DeleteItem(Guid itemId)
        {

            var response = await _httpClient.DeleteAsync($"api/v1/item/{itemId}");

            if (response.IsSuccessStatusCode)
            {
                _navigationManager.NavigateTo("items", forceLoad: true);
            }

        }

        public async Task<ItemResponse> GetItemDetails(Guid itemId)
        {
            return await JsonSerializer.DeserializeAsync<ItemResponse>
                (await _httpClient.GetStreamAsync($"api/v1/item/{itemId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
