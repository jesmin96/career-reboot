int[] marks ={40,100,90,70,50};
int sum=0;
int largest = 0;
int count = 0;
int average = 0;

foreach (int mark in marks)
{
    int length = marks.Length;
    sum = sum + mark;
    count++;
    average = sum / count;
    if (mark > largest)
    {
        largest = mark;
    }

}

Console.WriteLine($"Total:{sum}");
Console.WriteLine($"Average:{average}");
Console.WriteLine($"Highest:{largest}");