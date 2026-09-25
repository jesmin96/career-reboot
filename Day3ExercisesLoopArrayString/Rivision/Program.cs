//Array search
int[] numbers={1,8,90,40};
Console.WriteLine("Enter the no to search:");
int searchno = int.Parse(Console.ReadLine());
bool found = false;
foreach (int no in numbers)
{
    if ( searchno == no)
    {
        found = true;
    }

}

    if (found)
    {
        Console.WriteLine("the no is found");
    }
    else
    {
        Console.WriteLine("the no is not found");
    }
    



