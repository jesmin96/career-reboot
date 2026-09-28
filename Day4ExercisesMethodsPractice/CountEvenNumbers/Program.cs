// Method name: CountEven
// Parameter: int[] numbers
// Return type: int
//
// Input:
// { 10, 7, 4, 9, 12, 5
static int CountEven(int[] numbers)
{
    int count = 0;
    foreach ( int n in numbers)
    {
        if (n % 2 == 0)
        {
            count++;
        }
        
    }

    return count;
}
int[] numbers1= {2,6,4,1,8,9,12};
int countnum = CountEven(numbers1);
Console.WriteLine("Even No count is"+countnum);