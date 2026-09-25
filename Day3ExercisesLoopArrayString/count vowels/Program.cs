string vowels ="aeiouAEIOU";
int count =0;
Console.WriteLine("Enter the string:");
//bool isvalid = char.TryParse(Console.ReadLine(),out char input);
string input1= Console.ReadLine();

foreach (char c in input1)
{
    if(vowels.Contains(c))
    {
        count++;
    }
    
}
Console.WriteLine("no of vowels is :"+count);
