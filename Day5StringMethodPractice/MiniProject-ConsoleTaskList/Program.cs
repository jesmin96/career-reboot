List<string> tasks = new List<string>();
Console.WriteLine("=== TASK LIST === \n1. AddTask\n2. List Tasks\n3. Complete Tasks\n4. Exit");

while(true)
{
    Console.WriteLine("Enter Your Choice:");
    int choice1 = Convert.ToInt32(Console.ReadLine());
    if (choice1 == 1)
    {
        Console.WriteLine("Enter your Task:");
        string addtask = Console.ReadLine();
        tasks.Add(addtask);
    }

    else if (choice1 == 2)
    {
        foreach (string task in tasks)
        {
            Console.WriteLine($"The Taskes are: {task}");
        }

    }
    else if (choice1 == 3)
    {
        Console.WriteLine("Enter task to complete:");
        string CompleteTask = Console.ReadLine();
         tasks.Remove(CompleteTask);
    }
    else if(choice1 ==4)
    {
         break;
    }
    
}