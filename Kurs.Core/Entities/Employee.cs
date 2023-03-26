using Kurs.Core.Interface;

namespace Kurs.Core.Entities;

public class Employee : IEntity
{
    public int Id { get; set; } 
    public string Name { get; }
    public string SurName { get; }
    public decimal salary { get; }
    public int DepartmentId { get; internal set; }

    private static int _count;   

    public Employee()
    {
        Id = _count++;
    }

    public Employee(string name,string surname,decimal Salary):this()
    {
        Name = name;    
        SurName = surname;
        Salary = Salary;
    }
}
