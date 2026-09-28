static int SecondLargest(int[] numbers)
{
    int largest = 0;
    int secondlargest = 0;
    
    for (int i = 0; i <numbers.Length; i++)
    {
        if (numbers[i]>largest)
        {
            secondlargest = largest ;
            largest = numbers[i];
        }
        else if (numbers[i] > secondlargest)
        {
            secondlargest = numbers[i];
        }
      
        
        
        
    }
    return secondlargest;
}
int[] number1 ={10,4,8,9,18};
int num = SecondLargest(number1);
Console.WriteLine(num);