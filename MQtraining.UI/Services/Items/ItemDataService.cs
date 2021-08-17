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
    public class ItemDataService : IItemDataService
    {
        private readonly HttpClient _httpClient;

        public ItemDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ItemResponse> CreateItem(ItemRequest itemRequest)
        {
            var itemJson =
                new StringContent(JsonSerializer.Serialize(itemRequest), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/v1/item", itemJson);

            if (response.IsSuccessStatusCode)
            {
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
    }
}
