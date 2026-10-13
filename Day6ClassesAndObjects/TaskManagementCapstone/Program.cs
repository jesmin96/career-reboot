
using System.Reflection;

class TaskItem
{
    public string title { get; set; }
    public bool IsCompleted { get; set; }

    public void completeTask()
    {
        
        IsCompleted = true;
    }
    
}


class Project
{
    public string ProjectName { get; set; }
    public List<TaskItem> tasks { get; set; } = new List<TaskItem>();

    public void AddTask(TaskItem task)
    {
        tasks.Add(task);
    }

   
}
class Program
{
    static void Main(string[] args)
    {
        Project project1 = new Project();
        project1.ProjectName = "Holiday Lad";
        TaskItem task1 = new TaskItem();
        TaskItem task2 = new TaskItem();
        TaskItem task3 = new TaskItem();
        task1.title = "Prepare for interview";
        task2.title = "BookFlight";
        task3.title = "PackBags";
        project1.AddTask(task1);
        project1.AddTask(task2);
        project1.AddTask(task3);
        task3.completeTask();
        
     
        

        while (true)
        {
            Console.WriteLine("=== TASK MANAGEMENT ===");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. List Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1)
            {
                TaskItem newTask = new TaskItem();
                Console.WriteLine("Enter a task:");
                string taskTitle = Console.ReadLine();
                newTask.title = taskTitle;
                project1.AddTask(newTask);
                
               
                
            }

            if (choice == 2)
            {
                foreach (TaskItem task in project1.tasks)
                {
                    Console.WriteLine($"{task.title} - {task.IsCompleted}");
                }
            }

            if (choice == 3)
            {
                Console.WriteLine("Enter Task To Complete:");
                string completeTask = Console.ReadLine();
                foreach (TaskItem task in project1.tasks)
                {
                    if (task.title == completeTask)
                    {
                        task.completeTask();
                        Console.WriteLine($"{task.title}Completed Successfully");
                    }
                }
                
            }
            if (choice==4)
            {
                break;
            }

            
        }
      
    }
}