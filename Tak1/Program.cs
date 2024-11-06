internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\e.goncharenko\Desktop\ПКрабстол";
        string[] files = Directory.GetFiles(path,"",SearchOption.AllDirectories);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
    }
}