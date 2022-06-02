using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1,1000);
            Console.WriteLine("Enter a number to guess the winning number. Enter a number from 1-1000");
            var guess = Convert.ToInt32(Console.ReadLine());

            if(favNumber>guess){
                Console.WriteLine($"Too low. The number was {favNumber}");
            }

            else if(favNumber<guess){
                Console.WriteLine($"Too high. The number was {favNumber}");
            }

            else{
                Console.WriteLine("Correct! You guessed it!!");
            }

        }
    }
}
