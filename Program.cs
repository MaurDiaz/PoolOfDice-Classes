using System;

namespace Activity4._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sides;
            PoolOfDice pool = new PoolOfDice();

            do {
                Console.WriteLine("Pool of Dice\nEnter one of the following commands:");
                Console.WriteLine("add (to add a die to the pool)");
                Console.WriteLine("roll (to roll all dice in the pool");
                Console.WriteLine("remove (to remove one die from the pool)");
                input = Console.ReadLine().ToLower();

                if(input == "add")
                {
                    Console.WriteLine("How many sides? Typically 4, 6, 8, 10, 12 or 20");
                    while(!int.TryParse(Console.ReadLine(), out sides))
                    {
                        Console.WriteLine("Invalid input. Try again...");
                    }
                    Dice aDie = new Dice(sides);
                    
                }


            } while(true);
        }
    }
}
