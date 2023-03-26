
namespace Kurs.Core.Entities;

public class Dpartament
{
    
    public static int nextId = 1;

    public int Id { get; }
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public int EmployeeCount { get; private set; }

    public Dpartament(string name, int employeeLimit)
    {
        Id = nextId++;
        Name = name;
        EmployeeLimit = employeeLimit;
        EmployeeCount = 0;
    }

    public override string ToString()
    {
        return $"{Id}: {Name}";
    }

    public void AddEmployee(Employee employee)
    {
        if (EmployeeCount >= EmployeeLimit)
        {
            throw new CapacityLimitException("Department capacity reached");
        }

        employee.DepartmentId = Id;
        EmployeeCount++;
    }

    public void UpdateDepartment(string newName, int employeeLimit)
    {
        Name = newName; 
        EmployeeLimit = employeeLimit;
    }
}

