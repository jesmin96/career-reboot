// Enter first number: 10
// Enter second number: 5
//
// Addition: 15
// Subtraction: 5
// Multiplication: 50
// Division: 2
Console.WriteLine("Enter first number:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
 double num2 = double.Parse(Console.ReadLine());

double addition = num1 + num2;
Console.WriteLine("Addition:"+addition);
double subtraction = num1 - num2;
Console.WriteLine("Substaction: "+subtraction);
double multiplication = num1 * num2;
Console.WriteLine("Multiplication: "+multiplication);
double division = num1 / num2;
Console.WriteLine("Division: "+division);