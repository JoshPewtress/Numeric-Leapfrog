namespace NumericLeapfrogApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    static class Helper
    {
        private static readonly Random rand = new();

        public static int GetRandomNumber() => rand.Next(4, 50);
    }
}
