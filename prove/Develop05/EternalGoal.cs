public class EternalGoal : Goal
{
    public EternalGoal() : base("Eternal Goal"){
        
    }

    public override bool IsCompleted(){
        return false;
    }

    public override int RecordEvent(){
        return GetTotalPoints();
    }

    
}