// Method name: FindSum
// Parameter: int[] numbers
// Return type: int
//
//     Input array:
// { 10, 20, 30, 40 }
//
// Expected return:
// 100
static int findsum(int[] numbers)
{
    
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum = sum + numbers[i];
    }

    return sum;
}

int[] numbers1 = { 10, 70, 5 };
int sum = findsum(numbers1);
Console.WriteLine(sum);