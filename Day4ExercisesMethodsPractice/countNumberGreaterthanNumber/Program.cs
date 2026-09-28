static int CountGreater(int[] numbers, int value)
{
    int count = 0;
    foreach (int n in numbers)
    {
        if (n > value)
        {
            count++;
        }
        
    }
    
    return count;
}
int[] number1 = {50,40,90,30,20,10};
int countgreat = CountGreater(number1,20);
Console.WriteLine(countgreat);
