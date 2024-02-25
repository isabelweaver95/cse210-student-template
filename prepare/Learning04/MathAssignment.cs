public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public string GetHomeworkList(){
        return _textbookSection  + _problems;
    }

    public void setTextBookSection(string textbookSection){
        _textbookSection = textbookSection;
    }

    public void setProblems(string problems){
        _problems = problems;
    }
}