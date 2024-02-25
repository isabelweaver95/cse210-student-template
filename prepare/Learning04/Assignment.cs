public class Assignment
{
    public string _studentName;
    public string _topic;

    public string GetSummary(){
        return _studentName + " - " + _topic;
    }
}