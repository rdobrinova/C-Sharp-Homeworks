// See https://aka.ms/new-console-template for more information

//Task 4
//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today


int AgeCalculator(DateTime birthdayDate)
{
    DateTime today = DateTime.Today;
    //Console.WriteLine(today);
    int age = (today.Year - birthdayDate.Year) - 1;

    if(today.Month >= birthdayDate.Month && today.Day >= birthdayDate.Day)
    {
        age += 1;
    } 


    //Console.WriteLine(age);
    return age;
}
DateTime myBirthday = new DateTime(2003, 03, 09);
Console.WriteLine($"You are {AgeCalculator(myBirthday)} years");

DateTime myBirthday1 = new DateTime(2003, 03, 08);
Console.WriteLine($"You are {AgeCalculator(myBirthday1)} years");




































