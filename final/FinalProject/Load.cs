public class Load
{
    string filePath;
    string fileName;

    public void SetFilePath(){
        Console.WriteLine("What is the name of the file?");
                fileName = Console.ReadLine();
                filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\final\FinalProject\" + fileName + ".txt";
                if(File.Exists(filePath)){

                }else{

                }
    }

    private void Loading(){
        using StreamReader reader = new StreamReader(filePath);
        string line;
        while((line = reader.ReadLine()) != null){
            string[] fields = line.Split(',', ':');
            
        }
        
    }
}

