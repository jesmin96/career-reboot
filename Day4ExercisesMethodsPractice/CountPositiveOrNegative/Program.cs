static int CountPositive(int[] numbers)
{
    int count =0;
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i]==0)
        {
            count++;
        }
    }
    return count;
}
int[] number1 ={-1,-4,6,0,0,-3};
int num = CountPositive(number1);
Console.WriteLine(num);