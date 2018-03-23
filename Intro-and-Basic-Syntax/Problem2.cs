//CONFIRMED by Maxim Ivanov

//+------------------------------------------------------------------+
//|                    	 RectangleArea.cs 		 											 |
//|        							Created by Maxim Ivanov                      |
// https://github.com/GithubExcercise/Problems/Intro-and-Basic-Syntax|
//+------------------------------------------------------------------+

namespace _02._Rectangle_Area
{
	using System;

    public class Program
    {
        public static void Main()
        {
			//Initiation side A.
            double sideA = double.Parse(Console.ReadLine());

			//Initiation side B.
            double sideB = double.Parse(Console.ReadLine());

			//Calculating the area of rectangle.
            double rectangleArea = sideA * sideB;

			//Printing the area of rectangle.
            Console.WriteLine($"{area:F2}");
        }
    }
}
