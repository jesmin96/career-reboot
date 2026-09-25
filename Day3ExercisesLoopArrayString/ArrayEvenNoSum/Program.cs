int[] numbers ={10,1,3,8,7};
int arraysum=0;

for (int i = 0; i <numbers.Length; i++)
{
    if (numbers[i] % 2 == 0 )
    {
        arraysum = arraysum + numbers[i];
    }
}
Console.WriteLine("EvenSum:"+arraysum);

