public class Save{
    string filePath;

    public void SetFilePath(List<Goal> goals){
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
                            savingToExistingFile(goals);
                        }else{
                            // Create a new text file and open it for writing, because user said no
                            Console.WriteLine("What would you like to name the file?");
                            fileName = Console.ReadLine();
                            filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\prove\Develop05\" + fileName + ".txt";
                            savingToNewFile(goals);
                        }
                    }
                    else
                    {
                        // Create a new text file and open it for writing
                        // Your code for creating the file goes here
                        savingToNewFile(goals);
                        
                    }
    }

    private void savingToExistingFile(List<Goal> goals){
                // Create a new text file and open it for writing
        // Your code for creating the file goes here

        using StreamWriter writer = new StreamWriter(filePath);
        foreach (Goal goal in goals){
            writer.Write($"{goal.GetType()}:{goal.GetName()},{goal.GetDescription()},{goal.GetTotalPoints()},{goal.GetComleted()}\n");
        }
    }

    private void savingToNewFile(List<Goal> goals){
        using StreamWriter writer = new StreamWriter(filePath, true);
        foreach (Goal goal in goals){
            writer.Write($"{goal.GetType()}:{goal.GetName()},{goal.GetDescription()},{goal.GetTotalPoints()},{goal.GetComleted()}\n");
        }
    }
}