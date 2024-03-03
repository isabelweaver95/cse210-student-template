using System;

class Program
{
    static void Main(string[] args)
    {

        
        

        
        bool quiting = true;
        string choice = "";
        int input = 0;

        while(quiting){
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listening activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            input = int.Parse(choice); 
            
            switch(input){
                case 1:{
                    startBreathingActivity();
                    Console.Clear();
                break;
                }
                case 2:{
                    startRelcectionActivity();
                    Console.Clear();
                    break;
                }
                case 3:{
                    startListeningActivity();
                    Console.Clear();
                    break;
                }
                case 4:{
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

    public static void startBreathingActivity(){
        BreathingActivity breathingActivity = new BreathingActivity();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(breathingActivity.GetDeration());
        DateTime spinnerTime = startTime.AddSeconds(3);
        
        breathingActivity.DisplayStartMessage();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int input = int.Parse(Console.ReadLine());
        breathingActivity.SetDeration(input);
        Console.Clear();

        Console.WriteLine("Get ready...");
        //breathingActivity.DisplayBreathing();
        while(DateTime.Now < spinnerTime){
            breathingActivity.DisplaySpinner();
        }
        // input = input / 10;
        // Console.WriteLine($"{input}");
        breathingActivity.DisplayBreathing(input);

        breathingActivity.DisplayEndMessage();

        while(DateTime.Now < spinnerTime){
            breathingActivity.DisplaySpinner();
        }

        Console.Clear();
    }

    public static void startRelcectionActivity(){
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        DateTime startTime = DateTime.Now;
        DateTime spinnerTime = startTime.AddSeconds(3);

        reflectionActivity.DisplayStartMessage();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int input = int.Parse(Console.ReadLine());
        reflectionActivity.SetDeration(input);
        Console.Clear();

        Console.WriteLine("Get ready...");
        //breathingActivity.DisplayBreathing();
        while(DateTime.Now < spinnerTime){
            reflectionActivity.DisplaySpinner();
        }

        reflectionActivity.DisplayPrompt();
        Console.Clear();

        reflectionActivity.DisplayQuestion(input);

        reflectionActivity.DisplayEndMessage();

        startTime = DateTime.Now;
        spinnerTime = startTime.AddSeconds(3);
        while(DateTime.Now < spinnerTime){
            reflectionActivity.DisplaySpinner();
        }
        
        Console.Clear();
    }

    public static void startListeningActivity(){
        ListeningActivity listeningActivity = new ListeningActivity();
        DateTime startTime = DateTime.Now;
        //DateTime endTime = startTime.AddSeconds(listeningActivity.GetDeration());
        DateTime spinnerTime = startTime.AddSeconds(3);

        listeningActivity.DisplayStartMessage();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int input = int.Parse(Console.ReadLine());
        listeningActivity.SetDeration(input);
        Console.Clear();

        Console.WriteLine("Get ready...");
        //breathingActivity.DisplayBreathing();
        while(DateTime.Now < spinnerTime){
            listeningActivity.DisplaySpinner();
        }

        listeningActivity.DisplayQuestion();
        int entries = 0;
        DateTime endTime = startTime.AddSeconds(listeningActivity.GetDeration());
        while(DateTime.Now < endTime){
            Console.WriteLine("");
            Console.Write("> ");
            Console.ReadLine();
            entries++;
        }
        
        Console.WriteLine($"You listed {entries} items.");

        listeningActivity.DisplayEndMessage();

        startTime = DateTime.Now;
        spinnerTime = startTime.AddSeconds(3);

        while(DateTime.Now < spinnerTime){
            listeningActivity.DisplaySpinner();
        }

        Console.Clear();
    }
}