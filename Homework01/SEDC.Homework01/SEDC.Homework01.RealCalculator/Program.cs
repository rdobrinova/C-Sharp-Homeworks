// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System;

//Task 1
//Create new console application “RealCalculator” that takes two numbers from the 
//input and asks what operation would the user want to be done ( +, - , * , / ).
//Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

//With Switch-Case
Console.Write("Please enter first number: ");
bool isFirstNumberParsed = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.Write("Please enter second number: ");
bool isSecondNumberParsed = int.TryParse(Console.ReadLine(), out int secondNumber);

Console.Write("Please enter operation ( +, - , * , / ): ");
bool isOperationParsed = char.TryParse(Console.ReadLine(), out char operation);

if (isFirstNumberParsed && isSecondNumberParsed && isOperationParsed)
{
    int result = 0;
    switch (operation)
    {
        case '+':
            result = firstNumber + secondNumber;
            break;

        case '-':
            result = firstNumber - secondNumber;
            break;

        case '*':
            result = firstNumber * secondNumber;
            break;

        case '/':
            result = firstNumber / secondNumber;
            break;

        default:
            Console.WriteLine("Invalid operation!");
            break;

    }
    Console.WriteLine("The result is: " + result);

}
else
{
    Console.WriteLine("Not a valid input!");
}




//With If-Else
Console.Write("Please enter first number: ");
bool isFirstNumberParsed1 = int.TryParse(Console.ReadLine(), out int firstNumber1);

Console.Write("Please enter second number: ");
bool isSecondNumberParsed1 = int.TryParse(Console.ReadLine(), out int secondNumber1);

Console.Write("Please enter operation ( +, - , * , / ): ");
bool isOperationParsed1 = char.TryParse(Console.ReadLine(), out char operation1);

if (isFirstNumberParsed1 && isSecondNumberParsed1 && isOperationParsed1)
{
    int result1 = 0;
    if (operation1 == '+')
    {
        result1 = firstNumber1 + secondNumber1;
    }
    else if (operation1 == '-')
    {
        result1 = firstNumber1 - secondNumber1;
    }
    else if (operation1 == '*')
    {
        result1 = firstNumber1 * secondNumber1;
    }
    else if (operation1 == '/')
    {
        result1 = firstNumber1 / secondNumber1;
    }
    else
    {
        Console.WriteLine("Invalid operation!");
    }
    Console.WriteLine("The result is: " + result1);

}
else
{
    Console.WriteLine("Not a valid input!");
}

