public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _completed = false;
    private string _type;

    public Goal(string type){
        _type = type;
    }
    public string GetType(){
        return _type;
    }

    public string GetName(){
        return _name;
    }

    public string GetDescription(){
        return _description;
    }

    public int GetTotalPoints(){
        return _points;
    }

    public bool GetComleted(){
        return _completed;
    }

    public void SetName(string name){
        _name = name;
    }

    public void SetDescription(string description){
        _description = description;
    }

    public void SetPoints(int points){
        _points = points;
    }

    public void SetCompleted(bool completed){
        _completed = completed;
    }
    public virtual bool IsCompleted(){
        return _completed;
    }

    public virtual int RecordEvent(){
        _completed = true;
        return _points;
    }

    public virtual void DisplayGoal(int index){
        if(IsCompleted() == true){
            Console.WriteLine($"{index}. [X] {_name} ({_description})");
        }else{
            Console.WriteLine($"{index}. [ ] {_name} ({_description})");
        }
        //Console.WriteLine($"{index}. [ ] {_name} ({_description})");
    }

    public virtual Goal SetGoal(){
        Console.WriteLine("What is the name of your goal?");
        SetName(Console.ReadLine());
        Console.WriteLine("What is a short description of it?");
        SetDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");
        SetPoints(int.Parse(Console.ReadLine()));
        return this;
    }
}