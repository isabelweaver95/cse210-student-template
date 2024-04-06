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
                Console.WriteLine("What are the ingredients?");
                Console.WriteLine("Please enter the name of the ingredients, then the amount of that ingredient (ex. Egg 1, Milk 2)");
                Console.WriteLine("When you are done, type 'done'");
                
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
        Console.WriteLine("4. Save options");
        Console.WriteLine("5. Load Options");
        _input = int.Parse(Console.ReadLine());
        return _input;
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
                Console.WriteLine("What food would you like to add?");
                food = Console.ReadLine();
                Console.WriteLine("What is the amount would you like to add?");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the units?");
                units = Console.ReadLine();
                inventory.AddFood(new Food(food, amount, units));
                return inventory;
            case 4:
                return inventory;
            default:
                Console.WriteLine("Invalid input");
                return inventory;
        }
    }

    public void LoadOptions(Inventory inventory, CookBook cookBook){
        Console.WriteLine("What file would you like to load?");
        Console.WriteLine("1. Inventory");
        Console.WriteLine("2. CookBook");
        _input = int.Parse(Console.ReadLine());
        switch(_input){
            case 1:
                
                return;
            case 2:
                
                return;
            default:
                Console.WriteLine("Invalid input");
                return;
        }
    }
}