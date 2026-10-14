class Employee
{
    public string name { get; set; }
    private int _age;

    public int age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be negative");
            }

            _age = value;
        }
    }
    
    public Employee(string name,int age)
    {
        this.name = name;
        if (age < 0)
        {
            throw new ArgumentException("Age cannot be negative");
        }
        this.age = age;
    }

    public Employee(string name)
    {
        this.name = name;
    }

    public Employee()
    {
        this.name = "Unknown";
        this.age = 0;

    }
    public readonly int EmployeeId;

    public Employee(int id)
    {
        EmployeeId = id;
    }

    public Employee(int id,string name,int age)
    {
        this.name = name;
        this.age = age;
        this.EmployeeId = id;

    }
    
}

class Program
{
    public static void Main(String[] args)
    {
        Employee emp1 = new Employee("Jesmin", 29);
        Employee emp2 = new Employee("Iyvin", 33);
        Employee emp3 = new Employee("John");
        Employee emp4 = new Employee();
        Employee emp5 = new Employee("victor", 25);
        Employee emp7 = new Employee(101, "Ammu", 28);
        //emp7.EmployeeId = 200; error

        emp5.age = 30;
        Employee emp6 = new Employee(101);
        Console.WriteLine($"Updated age: {emp5.age}");
        Console.WriteLine($"Employee 1 Name and age is{emp1.name}{emp1.age}");
        Console.WriteLine($"Employee 2 Name and age is{emp2.name}{emp2.age}");
        Console.WriteLine($" EMPLOYEE 3 NAME IS:{emp3.name}");
        Console.WriteLine($"Employee 4 Name and age is{emp4.name}{emp4.age}");
        Console.WriteLine($"EmployeeId:{emp6.EmployeeId}"); // 101
        Console.WriteLine($"EmployeeId:{emp7.EmployeeId},EmployeeName:{emp7.name},EmployeeAge:{emp7.age}");
    }
    
}