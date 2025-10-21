namespace NumericLeapfrogApp;
static class Helper
{
    private static readonly Random rand = new();

    public static int GetRandomNumber() => rand.Next(4, 50);
}
