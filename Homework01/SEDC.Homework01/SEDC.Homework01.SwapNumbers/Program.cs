// See https://aka.ms/new-console-template for more information

using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;

//Task 3:
//Create new console application “SwapNumbers”. 
//Input 2 numbers from the console and then swap the values of 
//the variables so that the first variable has the second value and the second 
//variable the first value. Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5


Console.Write("Input the First number: ");
bool isNumber1Parsed = int.TryParse(Console.ReadLine(), out int number1);

Console.Write("Input the Second number: ");
bool isNumber2Parsed = int.TryParse(Console.ReadLine(), out int number2);

if (isNumber1Parsed && isNumber2Parsed)
{
    Console.WriteLine("After Swapping:");

    int number = number1;
    number1 = number2;
    number2 = number;

    Console.WriteLine("First number: " + number1);
    Console.WriteLine("Second number: " + number2);

}
else
{
    Console.WriteLine("Please enter a valid input!");
}
