// See https://aka.ms/new-console-template for more information

//Task 2
//Take a sentence as input and print its words.

Console.WriteLine("Enter a sentence: ");
string sentenceFromUser = Console.ReadLine();

string[] wordsInSentence = sentenceFromUser.Split(' ');

Console.WriteLine("Words in the sentence are:");
foreach (string word in wordsInSentence)
{
    Console.WriteLine(word);
}
