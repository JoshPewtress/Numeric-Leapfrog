namespace NumericLeapfrogApp
{
    static class Helper
    {
        private static readonly Random rand = new();

        public static int GetRandomNumber() => rand.Next(1, 51);

        public static void PlayGame()
        {
            var targetNumber = GetRandomNumber();
            (bool result, int playerTotal, int guessCount) = GetPlayerGuesses(targetNumber);
            DisplayResults(result, playerTotal, guessCount, targetNumber);
        }

        private static void DisplayResults(bool result, int playerTotal, int guessCount, int targetNumber)
        {
            var outcome = result ? "Congratulations, you won!" : "Oh no, you lost!";
            Console.WriteLine($"\n{outcome}\nIn {guessCount} guesses your total was {playerTotal}, the target number was {targetNumber}.");
        }

        private static (bool result, int playerTotal, int guessCount) GetPlayerGuesses(int targetNumber)
        {
            var playerTotal = 0;
            int guessCount = 0;

            while (( playerTotal + 3 ) <= targetNumber)
            {
                Console.Write(playerTotal > 0
                    ? $"Your current total is {playerTotal}, how much to add: "
                    : "Enter your starting guess: ");

                if (!int.TryParse(Console.ReadLine(), out int guess) || guess < 1)
                {
                    Console.WriteLine("Invalid input. Please enter a number greater than 1.\n");
                    continue;
                }

                guessCount++;
                playerTotal += guess;
            }

            bool result = playerTotal <= targetNumber;
            return (result, playerTotal, guessCount);
        }
    }
}
