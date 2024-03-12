public class Load{
    string filePath;

    public void SetFilePath(){
        Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine();
                string filePath = @"C:\Users\izzyw\OneDrive\Documents\code\Class class\Templete\cse210-student-template\prove\Develop02\" + fileName + ".txt";
                if(File.Exists(filePath)){
                    Loading(filePath);
                }else{
                    Console.WriteLine("File does not exist");
                }
    }

    private void Loading(string filePath){
        using StreamReader reader = new StreamReader(filePath);
        string line;
        while((line = reader.ReadLine()) != null){
            Console.WriteLine(line);
        }
    }
}