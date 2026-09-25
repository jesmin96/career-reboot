int[] numbers={2,6,9,8};
int smallest = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (smallest > numbers[i])
    {
        smallest = numbers[i];
    }
}
Console.WriteLine($"Smallest is:{smallest}");