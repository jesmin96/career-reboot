int[] numbers = {89,99,76,56};
int evencount =0;
int oddcount = 0;


foreach (int c in numbers)
    
{
    if (c % 2 == 0)
    {
        evencount++;
    }
    else
    {
        oddcount++;
    }
}
Console.WriteLine($"EvenCount is:{evencount}");  
Console.WriteLine($"OddCount is:{oddcount}");         
