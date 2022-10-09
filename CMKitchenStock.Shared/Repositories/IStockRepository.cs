using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CMKitchenStock.Shared.Repositories
{
    public interface IStockRepository
    {
        public Task<StockItem[]> GetAllStockItemsAsync();
        public Task<StockItem> AddStockItemAsync(StockItem stockItem);
        public Task<StockItem> UpdateStockItemAsync(StockItem stockItem);
        public Task DeleteStockItem(Guid id);

    }
}
