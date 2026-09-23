//whileloop
//int count = 1;
// do
// {
//     Console.WriteLine($"HelloWorld{count}");
//     count++;
// }while(count<=10);
//forloop
//print 1 to 10

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
//     
// }
//**Nested For Loop**
// for (int i = 1; i <= 10; i++)
// {
//     for (char j = 'a'; j <= 'j'; j++)
//     {
//         Console.WriteLine($"The cell is({i},{j})");
//     }
// }
//Switch

DayOfWeek day= DayOfWeek.Friday;
Console.WriteLine(day);
switch (day)
{
    case DayOfWeek.Saturday:
        case DayOfWeek.Sunday:
        Console.WriteLine("weekend day of");
        break;
    default:
        Console.WriteLine("Weekday");
        break;
}