//CONFIRMED by Maxim Ivanov

//+------------------------------------------------------------------+
//|                    	 CharacterStats.cs 		 					 |
//|        							Created by Maxim Ivanov          |
// https://github.com/GithubExcercise/Problems/Intro-and-Basic-Syntax|
//+------------------------------------------------------------------+

//Entering name.
name = str(input())
//Entering health.
a = int(input())
//Entering healthMax.
a1 = int(input())
//Entering energy.
b = int(input())
//Entering name.
b1 = int(input())

//Create a picture of current health.
health = '|' + '|'*a +'.' *(a1-a) + '|'
//Create a picture of current energy.
energy = '|' + '|'*b + '.'*(b1-b) + '|'

//Printing on the console.
print('Name: ' + n)
print('Health: ' + health)
print('Energy: ' + energy)
