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
            string characterName = "Sean";
            int characterAge = 29;

            Console.WriteLine("There once was a man named " + characterName + ".");
            Console.WriteLine("He was " + characterAge + " years old.");
            Console.WriteLine("He liked the name " + characterName + ".");

            characterAge = 30;
            Console.WriteLine("But he didn't like that he was about to turn " + characterAge + "." );

            Console.ReadLine();
        }
    }
}
