using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class FizzBuzz
    {       

        public int GetNumber()
        {
            while(true)
            {
                var userChoice = Console.ReadLine();
                if(userChoice.ToUpper() == "X")
                {
                    Environment.Exit(0);
                }

                if(!int.TryParse(userChoice, out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }
                return number;
            }
        }

        public string Result(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            else if (number % 3 == 0)
                return "Fizz";

            else if (number % 5 == 0)
                return "Buzz";

            else
                return number.ToString();
        }
    }
}
