public class WritingAssignment : Assignment
{
    private string _title;

    public string GetWritingInformation()
    {
        return _title;
    }

    public void SetTitle(string title){
        _title = title;
    }
}