// Enter first number: 10
// Enter second number: 5
// Enter operator: *
//
//     Result: 50
Console.WriteLine("Enter first number:");
bool isvalidnumber1=  double.TryParse(Console.ReadLine(),out double number1);
Console.WriteLine("Enter second number:");
bool isvalidnumber2=  double.TryParse(Console.ReadLine(),out double number2);
Console.WriteLine("Enter operator");

string? operatorstr=Console.ReadLine();
if (isvalidnumber1 && isvalidnumber2)
{
    switch (operatorstr)
    {
        case "+":
            double sum =number1 + number2;
            Console.WriteLine($"Result is:{sum}");
            
            break;
        case"-":
            double sum1 =number1 - number2;
            Console.WriteLine($"Result is:{sum1}");
            break;
        case"*":
            double sum2 =number1 * number2;
            Console.WriteLine($"Result is:{sum2}");
            break;
        case"/":
            double sum3 =number1 / number2;
            Console.WriteLine($"Result is:{sum3}");
            break;
            
        default:
            Console.WriteLine("Invalid operator");
            break;
        
        
    }
    
}
else
{
    Console.WriteLine("Please enter a valid input");
}