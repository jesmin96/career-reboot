class program
{
    public static void Main(string[] args)

    {
        int[] number = { -15, -8, -42, -3, -27 };
        int sum = 0;
        int max =number[0];
        int min = number[0];
        for (int i = 0; i < number.Length; i++)
        {
            sum = sum + number[i];
            if (number[i] >max)
            {
                max = number[i];
            }

            if (number[i] < min)
            {
                min = number[i];
            }
                
        }
        Console.WriteLine($"Maximum is:{max}");
        Console.WriteLine($"Minimum is:{min}");
        
        Console.WriteLine($"sum:{sum}");
    }
}