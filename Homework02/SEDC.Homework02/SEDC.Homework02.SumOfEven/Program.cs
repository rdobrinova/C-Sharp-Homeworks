// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

//Task 1
//Make a console application called SumOfEven. Inside it create an array of 6 integers.
//Get numbers from the input, find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14


int[] intNumbers = new int[6];
int sum = 0;
for (int i = 0; i < intNumbers.Length; i++)
{
    Console.WriteLine("Enter integer no." + (i + 1));
    bool isInputParsed = int.TryParse(Console.ReadLine(), out int numberFromInput);

    if (isInputParsed)
    {
        intNumbers[i] = numberFromInput;
        //Console.WriteLine(intNumbers[i] = numberFromInput);

        if (numberFromInput % 2 == 0)
        {
            sum += numberFromInput;
        }
        if (i == intNumbers.Length - 1)
        {
            Console.WriteLine("The result is: " + sum);
        }
    }
    else
    {
        Console.WriteLine("Not a valid input");
        break;
    }
}