int[] number ={10,20,10,30,20,40,40,40};
int count=0;
Console.WriteLine("Enter the Number:");
int countNumber =int.Parse(Console.ReadLine());
foreach (int n in number)
{
    if (n == countNumber)
    {
        
        count++;
    }
   
    
}
Console.WriteLine($"{countNumber}Appears:{count}Times");




