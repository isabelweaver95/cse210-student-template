public class Scripture{
    private List<Word> _words = new List<Word>();
    private Referance _referance;

    public Scripture(String scripture, String referance){
        string[] words = scripture.Split(' ');
        foreach(String sWord in words){
            Word word = new Word(sWord);
            _words.Add(word);
        }

        _referance = new Referance(referance);
    }

    public void HideWord(){
        Random random = new Random();
        int index;
        int count = 0;
        for(; count != _words.Count()/5;){
            index = random.Next(_words.Count());
            if(!_words[index].IsHidden()){
                _words[index].SetHidden();
                count++;
            }
        }
    }

    public void GetRenderedText(){
        Console.Write(_referance.GetReferance() + " ");

        foreach(Word word in _words){
            word.GetRenderedWord();
            //Console.Write(word.GetWord() + " ");
        }
    }

    public void ClearWords(){
        foreach(Word word in _words){
            word.clearWord();
        }
    }

    public bool AllHidden(){
        foreach(Word word in _words){
            if(word.IsHidden() == false){
                return false;
            }
        }

        return true;
    }
}