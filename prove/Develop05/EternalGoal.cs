public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override bool IsCompleted(){
        return false;
    }

    public override void RecordEvent(){
        SetCompleted(false);
    }
}