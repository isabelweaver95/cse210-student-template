using System;
using System.IO;
public class Load
{
    //Load will allow the user to upload a cookBook.
    //Load will the user to upload an inventory.
    string filePath;
    string fileName;

    public CookBook SetFilePathCookbook(){

        Console.WriteLine("What is the name of the file?");
                fileName = Console.ReadLine();
                filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\final\FinalProject\" + fileName + ".txt";
                if(File.Exists(filePath)){

                    return LoadingCookBook();

                }else{
                    Console.WriteLine("File does not exist");
                    return new CookBook();
                }
    }
    public Inventory SetFilePathInventory(){

        Console.WriteLine("What is the name of the file?");
                fileName = Console.ReadLine();
                filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\final\FinalProject\" + fileName + ".txt";
                if(File.Exists(filePath)){

                    return LoadingInventory();

                }else{
                    Console.WriteLine("File does not exist");
                    return new Inventory();
                }
    }
    private CookBook LoadingCookBook(){
        using StreamReader reader = new StreamReader(filePath);
        string fileContent = File.ReadAllText(filePath);
        string[] segments = fileContent.Split('#');
        CookBook cookBook = new CookBook();

        foreach (string segment in segments)
        {
            // Split the segment by lines
            string[] lines = segment.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            
            Recipe recipe = new Recipe();
            recipe._name = lines[0];
            recipe._instructions = lines[1];
            // Process each line in the segment
            for(int i = 2; i < lines.Length; i++){
                string[] line = lines[i].Split(':');
                Food food = new Food();
                food._name = line[0];
                food._quantity = int.Parse(line[1]);
                food.units = line[2];
                recipe._ingredients.Add(food);
            }

            cookBook.AddRecipe(recipe);
        }
        return cookBook;
    }

    private Inventory LoadingInventory(){
        //This one we can load by line
        using StreamReader reader = new StreamReader(filePath);
        string file = reader.ReadToEnd();
        string[] lines = file.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        Inventory inventory = new Inventory();
        foreach (string line in lines){
            Food food = new Food();
            string[] parts = line.Split(':');
            food._name = parts[0];
            food._quantity = int.Parse(parts[1]);
            food.units = parts[2];
            inventory.AddFood(food);
        }
        return inventory;
    }
}