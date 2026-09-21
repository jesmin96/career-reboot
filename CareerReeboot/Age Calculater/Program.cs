
Console.WriteLine("Enter Your Name");
string? name = Console.ReadLine();

Console.WriteLine("Enter Your Birth Year");

int birthYear = int.Parse(Console.ReadLine() ?? "");

int currentAge = 2026-birthYear;
Console.WriteLine(" Your name is :"+name);
Console.WriteLine(" Your birth year is :"+birthYear);
Console.WriteLine(" Your age is :"+currentAge);
