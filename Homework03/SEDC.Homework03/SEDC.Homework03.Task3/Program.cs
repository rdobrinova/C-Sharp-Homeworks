// See https://aka.ms/new-console-template for more information

//Task 3
//Create a function that takes a number as input.
//This method should return the sum of the digits in the number.

void SumOfTheDigitsInNumber()
{
    Console.Write("Enter number: ");
    string userInput = Console.ReadLine();

    char[] chars = userInput.ToCharArray();
    int sum = 0;
    foreach (char number in chars)
    {
        //Console.WriteLine(number);
        sum += int.Parse(number.ToString());
    }
    Console.WriteLine($"Sum of the digits in the number is: {sum}");
}
SumOfTheDigitsInNumber();