public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _completed = false;

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
        return true;
    }

    public virtual void RecordEvent(){
        _completed = true;
    }

    public void DisplayGoal(){
        Console.WriteLine($"[ ] {_name}: {_description} ({_points} points)");
    
    }
}