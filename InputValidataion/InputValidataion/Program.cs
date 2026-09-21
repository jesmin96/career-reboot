
Console.WriteLine("Enter Your age");

bool isAgeValid = double.TryParse(Console.ReadLine(), out double age);
if (isAgeValid)
{
    Console.WriteLine("Your age is " + age);
}
else
{
    Console.WriteLine("Your age is not valid Please enter a number");
    
}