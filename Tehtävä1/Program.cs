using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            int number = dice.Throw(); // 1-6
            Console.WriteLine("How many times you want to throw the dice");
            int amount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < amount; i++)
            {
                number = dice.Throw();
                double average = number + amount;
                double ka = average / amount;
                
                Console.WriteLine("Dice is now thrown {0} times, number was {1} average is {2}", amount, number, ka);
            }
            number++;
            
        }
    }
}

