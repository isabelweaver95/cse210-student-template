public class ShoppingList: Inventory
{
    public void AddFoodFromInventory(Inventory inventory){
        foreach(Food food in inventory._inventory){
            if(food._quantity == 0){
                AddFood(food);
                Console.WriteLine($"{food._name} has been added to your shopping list.");
                Console.WriteLine("How much would you like to buy?");
                food._quantity = int.Parse(Console.ReadLine());
                if(food._quantity == 0){
                    _inventory.Remove(food);
                }
            }
        }
    }

    override public void DisplayInventory(){
        foreach(Food food in _inventory){
            food.Display();
        }
    }

    public ShoppingList(){
        _inventory = new List<Food>();
    }
}