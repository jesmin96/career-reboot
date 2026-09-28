static double Average(int[] numbers)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum = sum + numbers[i];
        count++;
    }

    double average = sum / count;

    return average;
}

int[] number1 = { 10, 23, 60 };
double avrno =Average(number1);
Console.WriteLine(avrno);
