using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userInput = "0";

        while (userInput != "5")
        {

            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            userInput = Console.ReadLine();


            switch (userInput)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    //create new entry and add to the member variable
                    Entry entry = new Entry();
                    entry.prompt = prompt;
                    entry._response = response;

                    //add entry to journal
                    journal._entries.Add(entry);

                    break;
                case "2":
                    if (journal._entries.Count == 0)
                    {
                        Console.WriteLine("No entries yet");
                    }
                    else
                    {
                        journal.Display();
                    }
                    break;
                case "3":
                    Console.WriteLine("What is the name of the file?");
                    string fileName = Console.ReadLine();
                    string filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\prove\Develop02\" + fileName + ".txt";
                    if(File.Exists(filePath)){
                        journal.Load(filePath);
                    }else{
                        Console.WriteLine("File does not exist");
                    }
                    break;
                case "4":
                    Console.WriteLine("What would you like to name the file?");
                    fileName = Console.ReadLine();
                    filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\prove\Develop02\" + fileName + ".txt";

                    // Check if the file already exists
                    if (File.Exists(filePath))
                    {
                        // File already exists Ask user if they want to add to it
                        Console.WriteLine("File already exists. Would you like to add to it? (y/n)");
                        string answer = Console.ReadLine();
                        if(answer == "y" || answer == "Y"){
                            journal.savingToExistingFile(filePath);
                        }else{
                            // Create a new text file and open it for writing, because user said no
                            Console.WriteLine("What would you like to name the file?");
                            fileName = Console.ReadLine();
                            filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\prove\Develop02\" + fileName + ".txt";
                            journal.savingToNewFile(filePath);
                        }
                    }
                    else
                    {
                        // Create a new text file and open it for writing
                        // Your code for creating the file goes here
                        journal.savingToNewFile(filePath);
                        
                    }
                    break; // Add this break statement to exit the switch block
                case "5":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
    }

}