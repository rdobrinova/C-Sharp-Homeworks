// See https://aka.ms/new-console-template for more information


using System.Threading.Tasks;

//EXERCISE3
//● In the existing Console Application create a new method called Substrings
//● In that method enter the following string :
//"Hello from SEDC Codecademy 2021"
//● Ask the user to enter a number n.
//● Print the first n characters from that string and print the length of the new string.
//● Try to handle all the scenarios.

void Substrings()
{
    string sentence = "Hello from SEDC Codecademy 2021";
    //Console.WriteLine(sentence.Length);

    Console.Write("Enter a number: ");
    bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

    if (isNumber && userInput <= sentence.Length && userInput > 0)
    {
        string part = sentence.Substring(0, userInput);
        Console.WriteLine(part);
        Console.WriteLine($"Length of the string is: {part.Length}");
    }
    else
    {
        Console.WriteLine("Not a valid input!");
    }

}
Substrings();