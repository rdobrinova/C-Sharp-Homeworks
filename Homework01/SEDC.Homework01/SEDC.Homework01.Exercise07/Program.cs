// See https://aka.ms/new-console-template for more information

using System.Numerics;

//EXERCISE7
//● Ask the user to enter a number from 1 to 3
//● If the user enters “1” write “You got a new car!”
//● If the user enters “2” write “You got a new plane!”
//● If the user enter “3” write “You got a new bike!”
//● If the user enters a wrong number or character write an error message in the console


////With Switch-Case
Console.Write("Enter a number from 1 to 3: ");
bool isUserInputParsed = int.TryParse(Console.ReadLine(), out int userInput);

if (isUserInputParsed)
{
    switch (userInput)
    {
        case 1:
            Console.WriteLine("You got a new car!");
            break;

        case 2:
            Console.WriteLine("You got a new plane!");
            break;

        case 3:
            Console.WriteLine("You got a new bike!");
            break;

        default:
            Console.WriteLine("There is no such number!");
            break;

    }
}
else
{
    Console.WriteLine("Not a valid input!");
}



//With If-Else
Console.Write("Enter a number from 1 to 3: ");
bool isUserInputParsed1 = int.TryParse(Console.ReadLine(), out int userInput1);

if (isUserInputParsed1)
{

    if (userInput1 == 1)
    {
        Console.WriteLine("You got a new car!");
    }
    else if (userInput1 == 2)
    {
        Console.WriteLine("You got a new plane!");
    }
    else if (userInput1 == 3)
    {
        Console.WriteLine("You got a new bike!");
    }
    else
    {
        Console.WriteLine("There is no such number!");
    }
}
else
{
    Console.WriteLine("Not a valid input!");
}
