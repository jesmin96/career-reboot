class Program
{
  


    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    static void Main()
    {
        int mul = Multiply(1, 2, 3);
        int mul1 = Multiply(5, 8);
        Console.WriteLine(mul);
        Console.WriteLine(mul1);
    }
    


}