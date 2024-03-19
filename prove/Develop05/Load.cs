using System.ComponentModel.DataAnnotations;

public class Load{
    string filePath;
    string fileName;

    public List<Goal> SetFilePath(List<Goal> goals){
        Console.WriteLine("What is the name of the file?");
                fileName = Console.ReadLine();
                filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\prove\Develop02\" + fileName + ".txt";
                if(File.Exists(filePath)){
                    goals =  Loading(goals);
                    int i = 0;
                    foreach(Goal goal in goals){
                        goal.DisplayGoal(i++);
                    }
                    return Loading(goals);
                }else{
                    Console.WriteLine("File does not exist");
                    return goals;
                }
    }

    private List<Goal> Loading(List<Goal> goals){
        using StreamReader reader = new StreamReader(filePath);
        string line;
        while((line = reader.ReadLine()) != null){
            string[] fields = line.Split(',', ':');
            goals.Add(WhatGoal(fields));
        }
        return goals;
    }

    private Goal WhatGoal(string[] fields){
        if(fields[0] == "EternalGoal"){
            EternalGoal eternal = new EternalGoal();
            eternal.SetName(fields[1]); //fields[1]
            eternal.SetDescription(fields[2]);
            eternal.SetPoints(int.Parse(fields[3])); 
            eternal.SetCompleted(bool.Parse(fields[4]));
            
            return eternal;
        }else if(fields[0] == "ChecklistGoal"){
            ChecklistGoal checklist = new ChecklistGoal();
            checklist.SetName(fields[1]); //fields[1]
            checklist.SetDescription(fields[2]);
            checklist.SetPoints(int.Parse(fields[3])); 
            checklist.SetCompleted(bool.Parse(fields[4]));
            return checklist;
        }else {
            Goal simple = new Goal("Simple Goal");
            simple.SetName(fields[1]); //fields[1]
            simple.SetDescription(fields[2]);
            simple.SetPoints(int.Parse(fields[3])); 
            simple.SetCompleted(bool.Parse(fields[4]));
            return simple;
        }
    }
}