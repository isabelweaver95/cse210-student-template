public class Save
{
    // Save will update inventory/created a new inventory
    // Save will update cookBook/created a new cookBook
    // Save will update shoppingList/created a new shoppingList
    string filePath;
    public void SetFilePath(CookBook cookBook, Inventory inventory){
        Console.WriteLine("What would you like to save?");
        Console.WriteLine("1. Inventory");
        Console.WriteLine("2. CookBook");
        Console.WriteLine("3. ShoppingList");
        int input = int.Parse(Console.ReadLine());

        string fileName;
        Console.WriteLine("What would you like to name the file?");
                    fileName = Console.ReadLine();
                    filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\final\FinalProject\" + fileName + ".txt";

                    // Check if the file already exists
                    if (File.Exists(filePath))
                    {
                        // File already exists Ask user if they want to add to it
                        Console.WriteLine("File already exists. Would you like to add to it? (y/n)");
                        string answer = Console.ReadLine();

                        if(answer == "y" || answer == "Y"){
                            if(input == 1){
                                savingToExistingFileInventory(inventory);
                            }else
                                savingToExistingFileCookbook(cookBook);
                        }else{
                            // Create a new text file and open it for writing, because user said no
                            Console.WriteLine("What would you like to name the file?");
                            fileName = Console.ReadLine();
                            filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\final\FinalProject\" + fileName + ".txt";

                            if(input == 1){
                                savingToNewFileInventory(inventory);
                            }else
                                savingToNewFilecookbook(cookBook);
                        }
                    }
                    else
                    {
                        // Create a new text file and open it for writing
                        // Your code for creating the file goes here

                        if(input == 1){
                            savingToExistingFileInventory(inventory);
                        }else
                            savingToExistingFileCookbook(cookBook);
                    }
    }

    private void savingToExistingFileCookbook(CookBook cookBook){
        // Create a new text file and open it for writing
        // Your code for creating the file goes here

        using StreamWriter writer = new StreamWriter(filePath);

        foreach(Recipe recipe in cookBook._recipes){
            writer.WriteLine(recipe._name);
            writer.WriteLine(recipe._instructions);
            foreach(Food food in recipe._ingredients){ 
                writer.WriteLine(food._name + ":" + food._quantity);
            }
        }

        writer.Close();
    }

    private void savingToNewFilecookbook(CookBook cookBook){
        using StreamWriter writer = new StreamWriter(filePath, true);
        
        foreach(Recipe recipe in cookBook._recipes){
            writer.WriteLine(recipe._name);
            writer.WriteLine(recipe._instructions);
            foreach(Food food in recipe._ingredients){ 
                writer.WriteLine(food._name + ":" + food._quantity);
            }
        }

        writer.Close();
    }

    private void savingToExistingFileInventory(Inventory inventory){
        using StreamWriter writer = new StreamWriter(filePath);

        foreach(Food food in inventory._inventory){
            writer.WriteLine(food._name + ":" + food._quantity);
        }
    }

    private void savingToNewFileInventory(Inventory inventory){
        using StreamWriter writer = new StreamWriter(filePath, true);
        foreach(Food food in inventory._inventory){
            writer.WriteLine(food._name + ":" + food._quantity);
        }
    }
}