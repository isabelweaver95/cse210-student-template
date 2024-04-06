using System.Net;

public class Menu
{  
    private int _input = 0;
    public CookBook CookBookMenu(CookBook cookBook)
    {
        Console.WriteLine("1. Add recipe");
        Console.WriteLine("2. Display all recipes name");
        Console.WriteLine("3. Display certain recipe");
        Console.WriteLine("4. Exit");
        _input = int.Parse(Console.ReadLine());

        switch(_input)
        {
            case 1:
                Recipe recipe = new Recipe();
                Console.WriteLine("What is the name of your recipe?");
                recipe._name = Console.ReadLine();
                string input = "";
                while(input != "done"){
                    Console.WriteLine("What are the ingredients?");
                    Console.WriteLine("Please enter the name of the ingredients, then the amount of that ingredient (ex. Egg 1, Milk 2 cups)");
                    Console.WriteLine("If the item does not have units please put a N/A");
                    Console.WriteLine("When you are done, type 'done'");
                    input = Console.ReadLine();

                    if(input != "done"){
                        string[] ingredient = input.Split();
                        recipe._ingredients.Add(new Food(ingredient[0], int.Parse(ingredient[1]), ingredient[2]));
                    }
                }
                Console.WriteLine("What is the instructions?");
                recipe._instructions = Console.ReadLine();
                cookBook._recipes.Add(recipe);
                
                return cookBook;
            case 2:
                cookBook.displayAllRecipesName();
                return cookBook;
            case 3:
                Console.WriteLine("What recipe would you like to display?");
                cookBook.DisplayCertainRecipe(Console.ReadLine());
                return cookBook;
            case 4:
                return cookBook;
            default:
                Console.WriteLine("Invalid input");
                return cookBook;
        }
    }

    public int StartMenu(){
        Console.WriteLine("Welcome to the Foodie Application");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Go to inventory options");
        Console.WriteLine("2. Go to shopping list options");
        Console.WriteLine("3. Go to cook book options");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Load");
        Console.WriteLine("6. Exit");
        _input = int.Parse(Console.ReadLine());
        return _input;
    }

    public ShoppingList ShoppingListMenu(ShoppingList shoppingList, Inventory inventory){
        Console.WriteLine("1. Add food to shopping list");
        Console.WriteLine("2. Display shopping list");
        Console.WriteLine("3. Add food that is gone from inventory to shopping list");
        Console.WriteLine("4. Exit");
        _input = int.Parse(Console.ReadLine());

        switch(_input){
            case 1:
                Console.WriteLine("What food would you like to add?");
                string name = Console.ReadLine();
                Console.WriteLine("What is the amount would you like to add?");
                int amount = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the units?");
                string units = Console.ReadLine();
                shoppingList.AddFood(new Food(name, amount, units));
                return shoppingList;
            case 2:
                shoppingList.DisplayInventory();
                return shoppingList;
            case 3:
                shoppingList.AddFoodFromInventory(inventory);
                return shoppingList;
            case 4:
                return shoppingList;
            default:
                return shoppingList;
        }
    }

    public Inventory InventoryMenu(Inventory inventory){
        Console.WriteLine("Here are is the Inventory Options");
        Console.WriteLine("1. Add food to inventory");
        Console.WriteLine("2. Dipsplay Inventory");
        Console.WriteLine("3. Use food from inventory");
        Console.WriteLine("4. Exit");
        _input = int.Parse(Console.ReadLine());

        switch(_input){
            case 1:
                Console.WriteLine("What food would you like to add?");
                string food = Console.ReadLine();
                Console.WriteLine("What is the amount would you like to add?");
                int amount = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the units?");
                string units = Console.ReadLine();
                inventory.AddFood(new Food(food, amount, units));
                return inventory;
            case 2:
                inventory.DisplayInventory();
                return inventory;
            case 3:
                Console.WriteLine("What food would you like to use?");
                food = Console.ReadLine();
                Console.WriteLine("What is the amount would you like to use?");
                amount = int.Parse(Console.ReadLine());
                inventory.UseFood(food, amount);
                return inventory;
            case 4:
                return inventory;
            default:
                Console.WriteLine("Invalid input");
                return inventory;
        }
    }
    
}