public class ChecklistGoal : Goal
{
    private int _amount_of_times;
    private int _amount_done;



    public void SetAmountOfTimes(int amount){
        _amount_of_times = amount;
    }

    public void SetAmountDone(int amount){
        _amount_done = amount;
    }

    public override bool IsCompleted(){
        if(_amount_done == _amount_of_times){
            return true;
        }
        else{
            return false;
        }
    }

    public override void RecordEvent()
    {
        if(IsCompleted() == false){
            _amount_done += 1;
        }else{
            Console.WriteLine("Goal already completed");
        }
    }
    
    
}