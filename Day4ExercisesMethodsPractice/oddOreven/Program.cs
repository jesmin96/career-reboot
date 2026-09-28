// Method name: IsEven
// Parameter: int number
// Return type: bool
//
//     If number is even → return true
// Otherwise → return false
//
// Call it with: 8
//
// Expected output:
// True
static bool IsEven(int numbers)
{
    if (numbers % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

    
}

bool num = IsEven(8);
Console.WriteLine(num);

