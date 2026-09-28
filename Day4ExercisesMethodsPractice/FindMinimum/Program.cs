static int minimumNumber(int[] numbers)
{
    int minNo1 = numbers[0];
    for(int i=0;i<numbers.Length;i++)
    {
        if (minNo1>numbers[i])
        {
            minNo1 = numbers[i];
        }

        
    }

    return minNo1;
}
int[] number1 = {2,8,6,1,3};
int minino = minimumNumber(number1);
Console.WriteLine("MinimumNo is:"+minino);