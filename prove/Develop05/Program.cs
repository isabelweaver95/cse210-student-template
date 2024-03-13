using System;

class Program
{
    static void Main(string[] args)
    {
        bool quiting = true;
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;
        while(quiting){
            Console.WriteLine($"You have {totalPoints} points \n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.WriteLine("Select a choice from the menu: ");

            int input = int.Parse(Console.ReadLine());

            switch(input){
                case 1:{
                    break;
                }
                case 2:{
                    foreach(Goal goal in goals){
                        goal.DisplayGoal();
                    }
                    break;
                }
                case 3:{
                    Save save = new Save();
                    save.SetFilePath(goals);
                    break;
                }
                case 4:{
                    Load load = new Load();
                    load.SetFilePath(goals);
                    break;
                }
                case 5:{

                    break;
                }
                case 6:{
                    quiting = false;
                    break;
                }
                default:{
                    Console.WriteLine("Please enter a valid choice.");
                    break;
                }
            }
        }
    }

    public static List<Goal> AddGoal(List<Goal> goals){
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Back");
        Console.Write("Which type of goal would you like to create?");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:{
                SimpleGoal simple = new SimpleGoal();
                goals.Add(simple);
                return goals;
            }
            case 2:{
                EternalGoal eternal = new EternalGoal();
                goals.Add(eternal);
                return goals;
            }
            case 3:{
                ChecklistGoal checklist = new ChecklistGoal();
                goals.Add(checklist);
                return goals;
            }
            case 4:{
                return goals;
            }
            default:{
                return goals;
            }
        }
    }
}