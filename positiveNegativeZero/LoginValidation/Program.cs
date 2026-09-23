string correctUsername = "admin";
string correctPassword = "1234";

Console.WriteLine("Enter Username:");
string? username=Console.ReadLine();
Console.WriteLine("Enter Password:");
string? password = Console.ReadLine();
// if ()
// {

    if (correctUsername == username && correctPassword == password)
    {
        Console.WriteLine("Login Successful");
    }
    else
    {
        Console.WriteLine("Login Failed");
    }
//}
// else
// {
//     Console.WriteLine("Plesae  enter a valid input");
// }