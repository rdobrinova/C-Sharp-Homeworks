// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System;

//Task 2
//Create new console application “AverageNumber” that takes four numbers
//as input to calculate and prdouble the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18


Console.Write("Please enter first number: ");
bool isFirstNumberParsed = double.TryParse(Console.ReadLine(), out double firstNumber);

Console.Write("Please enter second number: ");
bool isSecondNumberParsed = double.TryParse(Console.ReadLine(), out double secondNumber);

Console.Write("Please enter third number: ");
bool isThirdNumberParsed = double.TryParse(Console.ReadLine(), out double thirdNumber);

Console.Write("Please enter fourth number: ");
bool isFourthNumberParsed = double.TryParse(Console.ReadLine(), out double fourthNumber);

if (isFirstNumberParsed && isSecondNumberParsed && isThirdNumberParsed && isFourthNumberParsed)
{
    double average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
    Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " and  " + fourthNumber + " is: " + average);
}
else
{
    Console.WriteLine("Invalid number!");
}


