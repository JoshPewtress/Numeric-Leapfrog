namespace NumericLeapfrogApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Numeric Leapfrog!");
            Console.WriteLine("The system will pick a number between 1 - 50.");
            Console.WriteLine("We track your number and add your next guess to it.");
            Console.WriteLine("Get within 3 of the random number without going over to win!\n");

            do
            {
                Helper.PlayGame();
                Console.Write("\nPlay again? Y/N: ");
            } while (Console.ReadLine()?.Trim().ToUpper() == "Y");
        }
    }
}
