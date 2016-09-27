using System.Collections.Generic;

namespace _10_Collections
{
    internal class MemoryStockRepository : IStockRepository
    {
        long id = 0;
        List<Stock> stockMemory;

        public MemoryStockRepository()
        {
            stockMemory = new List<Stock>();
        }
        public long NextId()
        {
            id++;
            return id;
        }

        public void SaveStock(Stock stock)
        {
            stockMemory.Add(stock);
        }

        public Stock LoadStock(long id)
        {
            //return stockMemory[(int)id];
            foreach(Stock stock in stockMemory)
            {
                if (stock.Id == id)
                    return stock;
            }
            return null;
        }

        public List<Stock> FindAllStocks()
        {
            return stockMemory;
        }

        public void Clear()
        {
            stockMemory.Clear();
        }
    }
}