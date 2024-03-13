public class Load{
    string filePath;
    string fileName;

    public void SetFilePath(List<Goal> goals){
        Console.WriteLine("What is the name of the file?");
                fileName = Console.ReadLine();
                filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\prove\Develop02\" + fileName + ".txt";
                if(File.Exists(filePath)){
                    Loading(goals);
                }else{
                    Console.WriteLine("File does not exist");
                }
    }

    private void Loading(List<Goal> goals){
        using StreamReader reader = new StreamReader(filePath);
        string line;
        while((line = reader.ReadLine()) != null){
            Console.WriteLine(line);
        }
    }
}