using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class Inventory<T>
    {
        private Dictionary<T, int> stock;
        private Dictionary<T, double> price;

        public Inventory()
        {
            stock = new Dictionary<T, int>();
            price = new Dictionary<T, double>();
        }

        public void AddProduct(T product, int quantity)
        {
            if (stock.ContainsKey(product))
                stock[product] += quantity;
            else
                stock.Add(product, quantity);
        }

        public bool RemoveProduct(T product, int quantity)
        {
            if (stock.ContainsKey(product) && stock[product] >= quantity)
            {
                stock[product] -= quantity;
                return true;
            }
            return false;
        }

        public int CheckStock(T product)
        {
            return stock.ContainsKey(product) ? stock[product] : 0;
        }

        public bool IsProductAvailable(T product, int quantity)
        {
            return stock.ContainsKey(product) && stock[product] >= quantity;
        }

        public List<T> GetAvailableProducts()
        {
            List<T> availableProducts = new List<T>();
            foreach (var product in stock.Keys)
            {
                if (stock[product] > 0)
                    availableProducts.Add(product);
            }
            return availableProducts;
        }

        public void SetProductPrice(T product, double productPrice)
        {
            if (price.ContainsKey(product))
                price[product] = productPrice;
            else
                price.Add(product, productPrice);
        }
    }
}
