public class ChecklistGoal : Goal
{
    private int _amount_of_times;
    private int _amount_done;

    private int _bonus;

    public ChecklistGoal() : base("Checklist"){

    }

    public void SetBonus(int bonus){
        _bonus = bonus;
    }

    public void SetAmountOfTimes(int amount){
        _amount_of_times = amount;
    }

    public void SetAmountDone(int amount){
        _amount_done = amount;
    }
    public int GetAmountOfTimes(){
        return _amount_of_times;
    }

    public int GetAmountDone(){
        return _amount_done;
    }
    public override bool IsCompleted(){
        if(_amount_done == _amount_of_times){
            return true;
        }
        else{
            return false;
        }
    }

    public override int RecordEvent()
    {
        if(IsCompleted() == false){
            _amount_done += 1;
            if(_amount_done == _amount_of_times){
                return _bonus;
            }else if(_amount_done == 1){
                return GetTotalPoints();
            }
            return 0;
        }else{
            Console.WriteLine("Goal already completed");
            return 0;
        }
    }
    
    public override void DisplayGoal(int index){
        if(IsCompleted() == true){
            Console.WriteLine($"{index}. [X] {GetName()} ({GetDescription()}) -- completed {_amount_done} of {_amount_of_times}");
        }else{
            Console.WriteLine($"{index}. [ ] {GetName()} ({GetDescription()}) -- curently completed {_amount_done} of {_amount_of_times}");
        }
        //Console.WriteLine($"{index}. [ ] {_name} ({_description})");
    }

    public override Goal SetGoal(){
        Console.WriteLine("What is the name of your goal?");
        SetName(Console.ReadLine());
        Console.WriteLine("What is a short description of it?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");
        SetPoints(int.Parse(Console.ReadLine()));
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        SetAmountOfTimes(int.Parse(Console.ReadLine()));
        Console.WriteLine("What is the bonus for completing it in that number of times?");
        SetBonus(int.Parse(Console.ReadLine()));
        return this;
    }
}