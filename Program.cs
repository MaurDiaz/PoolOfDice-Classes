using System;
using System.Collections.Generic;
namespace Activity4._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sides;
            PoolOfDice pool = new PoolOfDice();

            Console.Clear();

            do {
                Console.WriteLine("Pool of Dice\nEnter one of the following commands:");
                Console.WriteLine("add (to add a die to the pool)");
                Console.WriteLine("remove (to remove one die from the pool)");
                Console.WriteLine("roll (to roll all dice in the pool)");
                Console.WriteLine("exit (to end)");
               
                input = Console.ReadLine().ToLower();

                if(input == "add")
                {
                    Console.WriteLine("How many sides? Typically 4, 6, 8, 10, 12 or 20");
                    while(!int.TryParse(Console.ReadLine(), out sides))
                    {
                        Console.WriteLine("Invalid input. Try again...");
                    }
                    Dice aDie = new Dice(sides);
                    pool.Add(aDie);
                    Console.WriteLine($"You have {pool.Count} dice in the pool");
                }
                else if(input == "remove")
                {
                    if(pool.Count == 0)
                    {
                        Console.WriteLine("There aren't dice in the pool. Add at least one...");
                    }
                    else
                    {
                        pool.Remove();
                    }
                    Console.WriteLine($"You have {pool.Count} dice in the pool");
                }
                else if(input == "roll")
                {
                    if(pool.Count == 0)
                    {
                        Console.WriteLine("There aren't dice in the pool. Add at least one...");
                    }
                    else
                    {
                        int total, sumSides, roll;
                        total = 0;
                        sumSides = 0;
                        Console.WriteLine("Rolling... ");
                        foreach(var die in pool.ListOfDice)
                        {
                            roll = die.Roll();
                            Console.Write($"{roll}/{die.Sides} ");
                            total += roll;
                            sumSides += die.Sides;
                        }
                        Console.Write($"= {total}/{sumSides}\n");
                    }
                }
                else if(input == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again...");
                }  
            } while(true);
        }
    }
}
