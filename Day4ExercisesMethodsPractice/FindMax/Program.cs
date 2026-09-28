// Method name: FindMax
// Parameter: int[] numbers
// Return type: int
//
//     Input array:
// { 12, 45, 7, 89, 23 }
//
// Expected return:
// 89
static int FindMax(int[] numbers)
{
    int large = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > large)
        {
            large = numbers[i];
        }
    }

    return large;
}
int[] numbers1 = {10,4,8,20,60};
int  largeNo = FindMax(numbers1);
Console.WriteLine("Largest No is:"+largeNo);
