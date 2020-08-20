using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            while (guess != secretWord && !outOfGuesses);

            if (outOfGuesses)
            {
                Console.Write("Oh no, you ran out of guesses!");
            }
            else
            {
                Console.Write("You guessed right!");
            }

            Console.ReadLine();
        }

    }
}
