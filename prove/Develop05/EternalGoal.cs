public class EternalGoal : Goal
{

    public override bool IsCompleted(){
        return false;
    }

    public override void RecordEvent(){
        SetCompleted(false);
    }
}