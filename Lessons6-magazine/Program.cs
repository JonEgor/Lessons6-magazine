using Lessons6_magazine;
using System.ComponentModel;

Initializator initializator = new Initializator();
Inventorycs inventory = initializator.Initialize();

initializator.Initialize();
inventory.PrintAllProduct();

Console.WriteLine("_____________________");
Console.WriteLine("Sort by Food:");
List<Food> result = inventory.SortByType<Food>();

// By. Thanks Nikita ( Methods used ) 