//bool isnumberValid =int.TryParse(Console.ReadLine(),
//out int number);
// Ask the user to enter a number.
//     Read the number.
//     Use TryParse so invalid input doesn't crash the program.
//     Use if / else if / else.
// Print one of these:
Console.WriteLine("Enter a number:");
bool isNumberValid =double.TryParse(Console.ReadLine(),out double number);
if (isNumberValid)
    
{
    if (number < 0)
    {
        Console.WriteLine("You Enter a negative Number");
        
    }
    else if (number == 0)
    {
        Console.WriteLine("You Enter a zero Number");
    }
    else
    {
        Console.WriteLine("You Enter a positive Number");
    }
}
else
{
    Console.WriteLine("Can You please enter a valid number");
}