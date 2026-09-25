int[] numbers ={10,20,50,40,30};
int largest=0;
int secondLargest = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > largest)
    {
        secondLargest = largest;
        largest = numbers[i];

    }
    else if (numbers[i] > secondLargest)
    {
        secondLargest = numbers[i];
    }
}

Console.WriteLine("second Largest is"+secondLargest);
