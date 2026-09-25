int[] numbers = {10,20,30,40};
bool found = false;
Console.WriteLine("Enter Search no");
int searchno =int.Parse(Console.ReadLine());
foreach (int sn1 in numbers)
{
    if (searchno == sn1)
    {
        found = true;
    }
}

if (found)
{
    Console.WriteLine("number Found");
}
else
{
    Console.WriteLine("not Found");
}