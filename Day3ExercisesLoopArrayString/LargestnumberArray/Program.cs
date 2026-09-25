int[] numbers ={2,7,8,3,30};
int largestno =0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]>largestno)
    {
        largestno = numbers[i];
    }
}
Console.WriteLine($"Largest no is:{largestno}");