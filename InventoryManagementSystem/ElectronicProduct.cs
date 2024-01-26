using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class ElectronicProduct
    {
        public string ProductName { get; }
        public double Price { get; }

        public ElectronicProduct(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }

        public override string ToString()
        {
            return "ElectronicProduct{" +
                   "productName='" + ProductName + '\'' +
                   ", price=" + Price +
                   '}';
        }
    }

}
