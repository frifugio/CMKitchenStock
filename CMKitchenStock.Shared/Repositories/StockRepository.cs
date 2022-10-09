using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CMKitchenStock.Shared.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly HttpClient _httpClient;

        public StockRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<StockItem> AddStockItemAsync(StockItem newStockItem)
        {
            await _httpClient.PostAsJsonAsync<StockItem>($"/api/AddStockItem", newStockItem);
            return newStockItem;
        }

        public async Task DeleteStockItem(Guid id)
        {
            await _httpClient.DeleteAsync($"/api/DeleteStockItem/{id}");
        }

        public async Task<StockItem[]> GetAllStockItemsAsync()
        {
            return await _httpClient.GetFromJsonAsync<StockItem[]>("/api/GetAllStockItems") ?? Array.Empty<StockItem>();
        }

        public async Task<StockItem> UpdateStockItemAsync(StockItem stockItem)
        {
            _ = await _httpClient.PutAsJsonAsync<StockItem>($"/api/UpdateStockItem/{stockItem.Id}", stockItem);
            return stockItem;
        }
    }
}
