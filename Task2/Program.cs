internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\e.goncharenko\Desktop\Goat.txt";
        Random r = new Random();
        using (StreamWriter sw = new StreamWriter(path, false))
        {
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(r.Next(-20, 20));
            }
        }
        int k = 0;
        using (StreamReader sr = new StreamReader(path))
        {
            for (int i = 0; i < 10; i++)
            {
                k+=Convert.ToInt32(sr.ReadLine());
                
                
            }
            Console.WriteLine(k);
        }
    }
}