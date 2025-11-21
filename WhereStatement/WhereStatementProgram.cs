using Repository.Entities;
using Repository.Repos;

namespace WhereStatement;

public class WhereStatementProgram
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Employees with department IT:\n");
        EmployeesWithDepartment_IT();
        Console.WriteLine("\n\n");

        Console.WriteLine("Employees Older Then 30 And Active:\n");
        EmployeesOlderThen30AndActive();
        Console.WriteLine("\n\n");



        Console.WriteLine("Employees Hired After Jan And Salary More 4000:\n");
        EmployeesHiredAfterJanAndSalaryMore3000();
        Console.WriteLine("\n\n");


        Console.WriteLine("Employees with C# skill:\n");
        GetAllEmployeesBySkill("C#");
        Console.WriteLine("\n\n");
    }




    // Problem 1
    public static void EmployeesWithDepartment_IT()
    {
        List<Employee> emps = Employees.GetEmployees();

        var EmployeesWithDepartment_IT = emps.Where(e => e.DepartmentId == 1);

        foreach (var item in EmployeesWithDepartment_IT)
        {
            Console.WriteLine(item);
        }
    }


    // Problem 2
    public static void EmployeesOlderThen30AndActive()
    {
        var emps = Employees.GetEmployees();

        var EmployeesOlderThen30AndActive = emps.Where(e => e.IsActive == true && e.Age > 30);

        foreach (var item in EmployeesOlderThen30AndActive)
        {
            Console.WriteLine(item);
        }
    }


    // Problem 3 
    public static void EmployeesHiredAfterJanAndSalaryMore3000()
    {
        var emps = Employees.GetEmployees();

        var EmployeesHiredAfterJanAndSalaryMore40000 = emps.Where(e => e.Salary >= 3000 && e.HireDate > new DateTime(2020, 1, 1));


        foreach (var item in EmployeesHiredAfterJanAndSalaryMore40000)
        {
            Console.WriteLine(item);
        }
    }

    // Problem 4 
    public static void GetAllEmployeesBySkill(string Skill)
    {
        var emps = Employees.GetEmployees();

        var EmployeesWithSkill = emps.Where(e => e.Skills.Contains(Skill)).ToList();

        EmployeesWithSkill.ForEach(e => Console.WriteLine(e));
    }
}
