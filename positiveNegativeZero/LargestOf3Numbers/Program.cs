// Your program needs to:
//
// Ask for three numbers.
//     Use TryParse to validate them.
//     Determine which number is the largest.
// Do not use Math.Max().
//     Print the largest number.
//
//     Example:
//
// Enter first number: 25
// Enter second number: 67
// Enter third number: 41
//
// Largest number is: 67
Console.WriteLine("Enter First numbers");
bool IsvalidNumber1 = int.TryParse(Console.ReadLine(),out int num1);
Console.WriteLine("Enter Second numbers");
bool IsvalidNumber2 = int.TryParse(Console.ReadLine(),out int num2);
Console.WriteLine("Enter Third numbers");
bool IsvalidNumber3 = int.TryParse(Console.ReadLine(),out int num3);
if (IsvalidNumber1 && IsvalidNumber2 && IsvalidNumber3)
{
    if (num1 >= num2 && num1 >= num3)
    {
        Console.WriteLine($"Largest number is {num1}");
    }
    else if (num2 >= num3 && num2 >= num1)
        {
        Console.WriteLine($"Largest number is  {num2}");
        }
    else
    {
        Console.WriteLine($"Largest number is{num3}");
    }
    
}
else
{
    Console.WriteLine("Can You Please Enter a valid Number");
}
