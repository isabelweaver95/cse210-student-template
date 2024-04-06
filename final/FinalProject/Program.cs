using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        Menu menu = new Menu();
        CookBook cookBook = new CookBook();
        ShoppingList shoppingList = new ShoppingList();
        Inventory inventory = new Inventory();
        while (input != 5)
        {

            input = menu.StartMenu();
            switch (input)
            {
                case 1:
                    inventory = menu.InventoryMenu(inventory);
                    break;
                case 2:
                    menu.ShoppingListMenu(shoppingList, inventory);
                    break;
                case 3:
                    menu.CookBookMenu(cookBook);
                    break;
                case 4:
                    Save save = new Save();
                    save.SetFilePath(cookBook, inventory);
                    break;
                case 5:
                    Load load = new Load();
                    Console.WriteLine("Would you like to open a file for a Cookbook or an Inventory?");
                    Console.WriteLine("1. Cookbook");
                    Console.WriteLine("2. Inventory");
                    int _input = int.Parse(Console.ReadLine());
                    if(_input == 1){
                        cookBook = load.SetFilePathCookbook();
                    }else if(_input == 2){
                        inventory = load.SetFilePathInventory();
                    }
                    break;
                case 6:
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            } 
            
            Console.Clear();
        }
    }       
}