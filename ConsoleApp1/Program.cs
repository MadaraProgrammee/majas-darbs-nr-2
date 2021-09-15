using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           



            //--------1.uzdevums--------------------

            Console.WriteLine("------UZDEVUMS #1------");

            Console.WriteLine("Kā Tevi sauc?");

            string userName1 = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName1 + "!");


            //--------2.uzdevums--------------------

            Console.WriteLine("------UZDEVUMS #2------");

            Console.WriteLine("Kāds ir Tavs vecums?");

            string userAge = Console.ReadLine();
            int age = int.Parse(userAge);

            int ageNextYear = userAge + 1;
            bool isAdult1 = userAge >= 18;


            Console.WriteLine("Tavs vecums ir " + userAge + "nākamgad Tev paliks "+ ageNextYear + "Tu esi pieaugušais" + isAdult1);



        }
    }
}
