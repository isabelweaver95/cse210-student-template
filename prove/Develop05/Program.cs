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
                    goals = AddGoal(goals);
                    break;
                }
                case 2:{
                    int i = 1;
                    foreach(Goal goal in goals){
                        goal.DisplayGoal(i);
                        i++;
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
                    goals = load.SetFilePath(goals);
                    break;
                }
                case 5:{
                    Console.WriteLine("Which goal did you accomplish?");
                    input = int.Parse(Console.ReadLine());
                    totalPoints += goals[input-1].RecordEvent();
                    Console.WriteLine($"You now have {totalPoints} points");
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
                Goal simple = new Goal("Simple Goal");
                goals.Add(simple.SetGoal());
                return goals;
            }
            case 2:{
                EternalGoal eternal = new EternalGoal();
                goals.Add(eternal.SetGoal());
                return goals;
            }
            case 3:{
                ChecklistGoal checklist = new ChecklistGoal();
                goals.Add(checklist.SetGoal());
                return goals;
            }
            case 4:{
                return goals;
            }
            default:{
                Console.WriteLine("Choice not valid. Going to home screen");
                return goals;
            }
        }
    }
}