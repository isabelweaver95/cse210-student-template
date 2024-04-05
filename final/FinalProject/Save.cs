public class Save
{
    // Save will update inventory/created a new inventory
    // Save will update cookBook/created a new cookBook
    // Save will update shoppingList/created a new shoppingList
    string filePath;
    public void SetFilePath(){
        string fileName;
        Console.WriteLine("What would you like to name the file?");
                    fileName = Console.ReadLine();
                    filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\prove\Develop05\" + fileName + ".txt";

                    // Check if the file already exists
                    if (File.Exists(filePath))
                    {
                        // File already exists Ask user if they want to add to it
                        Console.WriteLine("File already exists. Would you like to add to it? (y/n)");
                        string answer = Console.ReadLine();
                        if(answer == "y" || answer == "Y"){
                            savingToExistingFile();
                        }else{
                            // Create a new text file and open it for writing, because user said no
                            Console.WriteLine("What would you like to name the file?");
                            fileName = Console.ReadLine();
                            filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\prove\Develop05\" + fileName + ".txt";
                            savingToNewFile();
                        }
                    }
                    else
                    {
                        // Create a new text file and open it for writing
                        // Your code for creating the file goes here
                        savingToNewFile();
                        
                    }
    }

    private void savingToExistingFile(){
                // Create a new text file and open it for writing
        // Your code for creating the file goes here

        using StreamWriter writer = new StreamWriter(filePath);

    }

    private void savingToNewFile(){
        using StreamWriter writer = new StreamWriter(filePath, true);
        
    }
}