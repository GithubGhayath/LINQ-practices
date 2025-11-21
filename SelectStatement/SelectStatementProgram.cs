using Repository.Entities;
using Repository.Repos;

namespace SelectStatement;

internal class SelectStatementProgram
{
    public static void Main(string[]args )
    {
        Console.WriteLine("Employees with Name IT:\n");
        GetEmployeesName();
        Console.WriteLine("\n\n");



        Console.WriteLine("Employees with Name and department IT:\n");
        EmployeesWithNameAndDepartment();
        Console.WriteLine("\n\n");




        Console.WriteLine("Employees with Name and Years of experience IT:\n");
        EmployeesWithNameAndYearsOfExperience();
        Console.WriteLine("\n\n");

    }


    // Problem 1
    public static void GetEmployeesName()
    {
        var emps = Employees.GetEmployees();

        var EmployeesName = emps.Select(e => e.Name).ToList();

        EmployeesName.ForEach(e => Console.WriteLine(e));
    }


    // Problem 2 
    public static void EmployeesWithNameAndDepartment()
    {
        var emps = Employees.GetEmployees();

        var EmployeesWithNameAndDepartment = emps.Select(e => new { e.Name, e.DepartmentId });

        foreach (var emp in EmployeesWithNameAndDepartment)
            Console.WriteLine($"Name: {emp.Name,-15} | Dept: {emp.DepartmentId}");

    }

    // Problem 3 
    public static void EmployeesWithNameAndYearsOfExperience()
    {
        var emps = Employees.GetEmployees();

        var EmployeesWithNameAndYearsOfExperience = emps .Select(e => new
        {
            e.Name,
            YearsOfExperience = (int)((DateTime.Now - e.HireDate).TotalDays / 365)
        });

        foreach (var emp in EmployeesWithNameAndYearsOfExperience)
            Console.WriteLine($"Name: {emp.Name,-15} | Experience: {emp.YearsOfExperience} years");

    }

    // Problem 4
    public static void EmployeesWithSkills(string Skill)
    {
        var emps = Employees.GetEmployees();

        var EmployeesWithSkills = emps.Select(e => new 
        {
            e.Name,
            e.Skills
        });
    }


}
