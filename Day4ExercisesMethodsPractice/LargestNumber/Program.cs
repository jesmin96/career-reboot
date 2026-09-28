// Method name: FindLargest
// Parameters: int a, int b
// Return type: int
static int Largestnumber(int a, int b)
{
    if (a > b)
    {
        return a;
    }

    else
    {
        return b;
    }
}
int num = Largestnumber(5,9);
Console.WriteLine("Largestnumberis:"+num);