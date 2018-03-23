//CONFIRMED by Maxim Ivanov

//+------------------------------------------------------------------+
//|                    	 BeverageLabels.cs 		 											 |
//|        							Created by Maxim Ivanov                      |
// https://github.com/GithubExcercise/Problems/Intro-and-Basic-Syntax|
//+------------------------------------------------------------------+

namespace _04._Beverage_Labels
{
	using System;

    public class Program
    {
        public static void Main()
        {
            //Declares the variables.
            string drink = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100 = int.Parse(Console.ReadLine());
            int sugarContentPer100 = int.Parse(Console.ReadLine());

            //Calculates.
            double energyTotal = (double)(energyContentPer100) * volume / 100;
            double sugarTotal = (double)(sugarContentPer100) * volume / 100;

            //Prints the result.
            Console.WriteLine($"{volume}ml {drink}:\r\n{energyTotal}kcal, {sugarTotal}g sugars");
        }
    }
}
