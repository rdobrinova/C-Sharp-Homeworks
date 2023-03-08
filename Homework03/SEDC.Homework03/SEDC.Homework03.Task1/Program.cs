// See https://aka.ms/new-console-template for more information

//Task 1
//Take one string from the input and print its last 5 characters.

Console.WriteLine("Enter string:");
string stringFromInput = Console.ReadLine();
bool isNumber = int.TryParse(stringFromInput, out int number);

if (!isNumber)
{
    if (stringFromInput.Length > 5)
    {
        string lastFiveCharacters = stringFromInput.Substring(stringFromInput.Length - 5);
        Console.WriteLine($"The last 5 characters are: {lastFiveCharacters}");
    }
    else
    {
        Console.WriteLine("The string must be larger than 5!");

    }

}
else
{
    Console.WriteLine("Not a valid input!");
}

