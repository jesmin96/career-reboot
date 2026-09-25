int[] numbers ={10,20,30,40,8,70,80};
int count =0;
foreach (int c in numbers)
{
    if (c > 20)
    {
        count = count + 1;
    }
}
Console.WriteLine($"count greater than 20:{count}");