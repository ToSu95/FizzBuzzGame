using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new FizzBuzz();

            Console.WriteLine("Zagrajmy with FizzBuzz");          

            while (true)
            {
                Console.WriteLine("Podaj liczbę:");
                Console.WriteLine("Jeśli chcesz zakończyć grę naciśnij 'x'.");
                var userNumber = game.GetNumber();
                var gameResult = game.Result(userNumber);

                Console.WriteLine(gameResult);               
            }
        }

    }
}
