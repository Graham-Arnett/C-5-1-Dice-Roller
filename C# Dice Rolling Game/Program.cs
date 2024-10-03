namespace C__Dice_Rolling_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //displays at top on running
            Console.WriteLine("Hello, why don't you have fun and roll some dice?");
            //this will check for snake-eyes and boxcars, don't need anything fancy for either just a sum

            Random random = new Random();
            //int total; //I will probably remove this, but total just adds both rolls
            string playagain;
            do { //dice
                //Console.Write($"Die 1: "); //the $ lets us interpolate the string
                //Console.WriteLine($"Die 2: ");//that means we can print variables inside
                //Console.WriteLine($"Total: ");
                int total = 0;
                int totalrolls = 2;
                for (int i = 0; i < totalrolls; i++) 
                {
                    int roll = random.Next(1, 7); //we set it like this because lowerband is inclusive, upper is exclusive
                    Console.WriteLine($"Roll {i + 1}: {roll} ");
                    total += roll;
                }
                Console.WriteLine($"Total: {total}");
                if (total ==2)
                {
                    Console.WriteLine("Snake eyes!");
                }
                else if (total == 12)
                {
                    Console.WriteLine("Boxcars!");
                }
                else { }
                Console.Write("Would you like to play again? (y/n) ");
                playagain = Console.ReadLine().Trim().ToLower();
            }while (playagain == "y");
        }
    }
}
