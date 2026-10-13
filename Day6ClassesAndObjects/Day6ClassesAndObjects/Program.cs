class Employe
{ 
    public string name{ get; set; }
    public int age { get; set; }
    public double Salary { get; set; }
    public string department { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine($"Your name is{name},age is{age} and your salary is{Salary}\n Your department is: {department}");
        
    }
   
    
}

class  Taskitem
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public void CompleteTask()
    {
        IsCompleted = true;
        
    }
}

class  Project
{
    public string projectName { get; set; }
    public bool IsCompleted { get; set; }

    public void completeProject()
    {
        IsCompleted = true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employe employe = new Employe();
        Employe employee2 = new Employe();
        Taskitem task1 = new Taskitem();
        Project proj= new Project();
        proj.projectName = "Interview Prepration";
        proj.completeProject();
        Console.WriteLine(proj.IsCompleted);
        Console.WriteLine(task1.IsCompleted);
        task1.CompleteTask();
        task1.Title = "Prepare for interview";
        Console.WriteLine(task1.IsCompleted);
        employee2.name = "Iyvin";
        employee2.age = 33;
        employee2.Salary = 8000;
        employee2.department = "Chemistery";
        employee2.DisplayDetails();
        employe.name = "Jesmin";
        employe.age = 30;
        employe.Salary = 4000;
        employe.department = "computerScience";
        employe.DisplayDetails();
        
        
    }
}
