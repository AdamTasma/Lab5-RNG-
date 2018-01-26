using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome, to the Circus of Value!");
            HighRoller();
        }
        public static void HighRoller()
        {
            Console.WriteLine("How many sides do your dice have?");
            int input = int.Parse(Console.ReadLine());
            int side = input + 1;
            Random random = new Random();
            int roll1 = random.Next(1, side);
            int roll2 = random.Next(1, side);
            Console.WriteLine("You rolled...");
            Console.WriteLine(roll1 + " and " + roll2);
            if (roll1 + roll2 == 2)
            {
                Console.WriteLine("Snake Eyes!");
            }
            if ((roll1 == 6) && (roll2 == 6))
            {
                Console.WriteLine("Box Car!");
            }
            //repeat
            Console.WriteLine("Would you like to continue? (y/n)");
            char repeat = char.Parse(Console.ReadLine().ToUpper());
            if (repeat.Equals(Char.Parse("Y")))
            {
                HighRoller();
            }
            else
            {
                Console.WriteLine("Ok goodbye");
                Console.ReadLine();
            }
        }
    }
}
