// See https://aka.ms/new-console-template for more information
using InventoryManagementSystem;

Inventory<ElectronicProduct> electronicInventory = new Inventory<ElectronicProduct>();
Inventory<ClothingProduct> clothingInventory = new Inventory<ClothingProduct>();

ElectronicProduct phone = new ElectronicProduct("Smartphone", 500.00);
ElectronicProduct laptop = new ElectronicProduct("Laptop", 1000.00);

ClothingProduct shirt = new ClothingProduct("T-Shirt", 20.0);
ClothingProduct jeans = new ClothingProduct("Jeans", 40.0);

electronicInventory.AddProduct(phone, 50);
electronicInventory.AddProduct(laptop, 30);

clothingInventory.AddProduct(shirt, 100);
clothingInventory.AddProduct(jeans, 80);

Console.WriteLine(string.Join(", ", electronicInventory.GetAvailableProducts()));
Console.WriteLine(string.Join(", ", clothingInventory.GetAvailableProducts()));

Console.WriteLine(electronicInventory.IsProductAvailable(phone, 20));

bool removed = electronicInventory.RemoveProduct(phone, 10);

Console.WriteLine(electronicInventory.CheckStock(phone));