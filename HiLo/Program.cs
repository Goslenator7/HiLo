namespace HiLo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HiLo");
            Console.WriteLine($"Guess the numbers between 1 and {HiLoGame.MAXIMUM}");

            while (HiLoGame.GetPot() > 0)
            {
                Console.WriteLine("Press h if you think the next number is higher than the current number, l if it will be lower, or ? to buy a hint");
                Console.WriteLine($"Or any other key to quit with {HiLoGame.GetPot()}");
                char key = Console.ReadKey(true).KeyChar;

                if (key == 'h') HiLoGame.Guess(true);
                else if (key == 'l') HiLoGame.Guess(false);
                else if (key == '?') HiLoGame.Hint();
                else return;
            }
            Console.WriteLine("No money left in the pot! Game Over!");
        }
    }
}