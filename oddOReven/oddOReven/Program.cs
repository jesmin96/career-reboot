// Enter a number: 8
// 8 is an even number.
Console.WriteLine("Enter a number");

bool isnumberValid =int.TryParse(Console.ReadLine(),out int number);
if (isnumberValid && number%2 ==0) 
{
    Console.WriteLine("Even number");
}
else if (isnumberValid && number%2 !=0) 

{
    Console.WriteLine("You entered an odd number");
}
else
{
    Console.WriteLine("Can you please enter an integer?");
}