//CONFIRMED by Maxim Ivanov

//+------------------------------------------------------------------+
//|                    	 MilesToKilometers.cs 		 				 |
//|        				Created by Maxim Ivanov                      |
// https://github.com/GithubExcercise/Problems/Intro-and-Basic-Syntax|
//+------------------------------------------------------------------+

//Entering miles.
miles = float(input())
//Converts miles to kilometers.
b = miles*1.60934
//Form the output to the second decimal.
b = format(b, '.2f')

//Printing on the console.
print(b)
