using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class ClothingProduct
    {
        public string ProductName { get; }
        public double Price { get; }

        public ClothingProduct(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }

        public override string ToString()
        {
            return "ClothingProduct{" +
                   "productName='" + ProductName + '\'' +
                   ", price=" + Price +
                   '}';
        }
    }
}
