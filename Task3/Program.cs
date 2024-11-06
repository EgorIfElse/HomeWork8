internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\e.goncharenko\Desktop\test.txt";
        int CountChar = 0;
        int CountWords = 0;
        int CountLine= 0;
        using (StreamReader sr = new StreamReader(path))

        {

            string line;
            while ((line = sr.ReadLine()) != null)

            {
                CountLine++;
                CountChar += line.Length;

                string[] word = line.Split(new char[] { ' ', '\t', '\n' });
                CountWords += word.Length;
            }

            Console.WriteLine("Количество символов {0}", CountChar);
            Console.WriteLine("Количество строк {0}", CountLine);
            Console.WriteLine("Количество слов {0}", CountWords);



        }
    }
}