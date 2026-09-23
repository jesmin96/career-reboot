// 90–100  → A
// 80–89   → B
// 70–79   → C
// 60–69   → D
// 0–59    → F
Console.WriteLine("Enter Mark");
bool isValid = double.TryParse(Console.ReadLine(),out double mark);
if (isValid)
{
    if (mark >= 0 && mark <= 59)
    {
        Console.WriteLine("Grade F");
    }
    else if (mark >= 60 && mark <= 69)
    {
        Console.WriteLine("Grade D");
    }
    else if (mark >= 70 && mark <= 79)
    {
        Console.WriteLine("Grade C");
    }
    else if (mark >= 80 && mark <= 89)
    {
        Console.WriteLine("Grade B");
    }
    else if (mark >= 90 && mark <= 100)
    {
        Console.WriteLine("Grade A");
    }
}
else
{
    Console.WriteLine("Invalid Input");
}