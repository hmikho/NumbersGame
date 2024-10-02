using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();
            int number = random.Next(1, 20);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Välj ett tal mellan 1 till 20: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }

                else if (guess < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                }

                else
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }

                if (i == 4)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }
            }

            Console.ReadLine();
        }
    }
}
