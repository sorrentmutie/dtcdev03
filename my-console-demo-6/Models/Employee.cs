namespace my_console_demo_6.Models;

public class Employee: IComparable
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty.ToString();
    public double Salary { get; set; }

    public int CompareTo(object? obj)
    {
        var employee = obj as Employee;
        if (employee == null)
        {
            throw new Exception("employee is not an instance of Employee");
        }
        return Salary.CompareTo(employee.Salary);
    }
}
