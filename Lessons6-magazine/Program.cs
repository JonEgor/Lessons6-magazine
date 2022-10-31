using Lessons6_magazine;
using System.ComponentModel;

Initializator initializator = new Initializator();
Inventorycs inventory = initializator.Initialize();
initializator.Initialize();
object value = inventory.PrintAllProduct();
inventory.SortForFoods<Food>();