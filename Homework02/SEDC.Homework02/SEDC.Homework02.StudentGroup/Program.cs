// See https://aka.ms/new-console-template for more information

using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;

//Task 2
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Blagica", "Aneta", "Marija", "Anastasija", "Jana" };

Console.WriteLine("Enter student group: (there are 1 and 2 )");
bool isUserInputParsed = int.TryParse(Console.ReadLine(), out int userInput);

if (isUserInputParsed )
{
    if (userInput == 1)
    {
        Console.WriteLine("The Students in G1 are:");
        foreach(string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    } 
    else if (userInput == 2)
    {
        Console.WriteLine("The Students in G2 are:");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
    else
    {
        Console.WriteLine("There is no such number!");
    }
}
else
{
    Console.WriteLine("Not a valid input");    
}
