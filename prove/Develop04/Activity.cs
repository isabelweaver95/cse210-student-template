public class Activity
{
    private string _name;
    private string _description;
    private int _deration;

    public Activity(string name, string description, int deration){
        _name = name;
        _description = description;
        _deration = deration;
    }

    public void DisplayStartMessage(){
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(" ");
        Console.WriteLine(_description);
    }

    public void DisplayEndMessage(){
        Console.WriteLine("Well Done!");
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_deration} seconds of the {_name}");
    }

    public void DisplayCountdown(int amount){
        for(int i = 0; i <= amount; i++){
            if(amount >= 10){
                Console.Write($"{amount - i}");

                Thread.Sleep(1000);

                Console.Write("\b \b \b"); // Erase the + character
            }
            
            Console.Write($"{amount - i}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
        }
    }

    public void DisplaySpinner(){
        List<string> spinner = new List<string>{
        "|", "/", "-", "\\","|", "/", "-", "\\"
        };

        foreach(string s in spinner){
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b"); // Erase the + character
        }
    }

    public void SetName(string name){
        _name = name;
    }    

    public void SetDescription(string description){
        _description = description;
    }

    public void SetDeration(int deration){
        _deration = deration;
    }

    public string GetName(){
        return _name;
    }

    public string GetDescription(){
        return _description;
    }

    public int GetDeration(){
        return _deration;
    }


}