internal class Program
{
    private static void Main(string[] args)
    {
        ShowMessage("Hello");
        int result = sum(1, 2);
        ShowMessage(result);
        
    }
    static int sum(int a, int b)
        {
            return a + b;
        }
        static void ShowMessage(int message)
        {
            Console.WriteLine(message);
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
}