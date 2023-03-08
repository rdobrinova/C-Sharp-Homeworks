// See https://aka.ms/new-console-template for more information


//EXERCISE4
//● Print the date that is 3 days from now
//● Print the date that is one month from now
//● Print the date that is one month and 3 days from now
//● Print 1 year and 2 months ago from today
//● Print only the current month of today
//● Print only the current year of today


//● Print the date that is 3 days from now
DateTime currentLocalDateTime = DateTime.Now;
Console.WriteLine($"Now is: {currentLocalDateTime}");
DateTime addedDays = currentLocalDateTime.AddDays(3);
Console.WriteLine($"Three days from now is: {addedDays}");

Console.WriteLine();

//● Print the date that is one month from now
DateTime currentLocalDateTime1 = DateTime.Now;
Console.WriteLine($"Now is: {currentLocalDateTime1}");
DateTime addedMonths = currentLocalDateTime1.AddMonths(1);
Console.WriteLine($"One month from now is: {addedMonths}");

Console.WriteLine();

//● Print the date that is one month and 3 days from now
DateTime currentLocalDateTime2= DateTime.Now;
Console.WriteLine($"Now is: {currentLocalDateTime2}");
DateTime addedMonthsAndDays1 = currentLocalDateTime2.AddDays(3).AddMonths(1);
Console.WriteLine($"One month and 3 days from now is: {addedMonthsAndDays1}");

Console.WriteLine();

//● Print 1 year and 2 months ago from today
DateTime currentLocalDateTime3 = DateTime.Today;
Console.WriteLine($"Today is: {currentLocalDateTime3}");
DateTime addedMonthsAndYears1 = currentLocalDateTime3.AddYears(-1).AddMonths(-2);
Console.WriteLine($"One year and 2 months ago from today is: {addedMonthsAndYears1}");

Console.WriteLine();

//● Print only the current month of today
DateTime currentLocalDateTime4 = DateTime.Today;
int month = currentLocalDateTime4.Month;
Console.WriteLine($"Today is: {month} month of this year");

Console.WriteLine();

//● Print only the current year of today
DateTime currentLocalDateTime5 = DateTime.Today;
int year = currentLocalDateTime5.Year;
Console.WriteLine($"Today is: {year} year");