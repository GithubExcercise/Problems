//CONFIRMED by Maxim Ivanov

//+------------------------------------------------------------------+
//|                                             Debit Card Number.cs |
//|        Created by Maxim Ivanov                                   |
// https://github.com/GithubExcercise/Problems/Intro-and-Basic-Syntax|
//+------------------------------------------------------------------+

namespace DebitCardNumber
{
	using System;

    public class StartUp
    {
        public static void Main()
        {
            //declares the variables
            int a1 = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            //returns the result
            Console.WriteLine($"{a1:d4} {b:d4} {c:d4} {d:d4}");
        }
    }
}
