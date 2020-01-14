using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose minimum bound for Guessing Game.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose maximum bound for Guessing Game.");
            int y = Convert.ToInt32(Console.ReadLine());
            bool wrong = true;
            int count = 0;
            Random random = new Random();
            int rand = random.Next(x,y);
            Console.WriteLine("I am thinking of a number between " + x + " and " + y + ".");
            while (wrong)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess < rand)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                if (guess > rand)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                if (guess == rand)
                {
                    wrong = false;
                    Console.WriteLine("Correct! You guessed it!");
                }
                count++;
            }
            Console.WriteLine("You made " + count + " guesses total.");
            return;
        }
    }
}
