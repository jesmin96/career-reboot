Console.WriteLine("Enter the string");
string input = Console.ReadLine();
string reverseString = "";

for (int i = input.Length - 1; i >= 0; i--)
{
    reverseString =reverseString+ input[i];
}

//Console.WriteLine(reverseString);
if (input == reverseString)
{
    Console.WriteLine("Palindrome string");
}
else
{
    Console.WriteLine("Not Palindrome series");
}


