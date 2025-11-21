using Repository.Repos;

namespace SelectManyStatement;

internal class SelectManyStatementProgram
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Employee's Skills:\n");
        GetAllSkills();
        Console.WriteLine("\n\n");


        Console.WriteLine("Employee's Unique Skills:\n");
        GetUniqueSkills();
        Console.WriteLine("\n\n");


        Console.WriteLine("Employee's name and skills:\n");
        GetEmployeeNameWithSkill();
        Console.WriteLine("\n\n");


        /*
        Console.WriteLine("Employee's Skills with select:\n");
        GetAllSkills01();
        Console.WriteLine("\n\n");
        */

    }

    // Problem 1
    public static void GetAllSkills()
    {
        var emps = Employees.GetEmployees();


        var Skills=emps.SelectMany(e=>e.Skills).ToList();

        Skills.ForEach(s => Console.WriteLine(s));
    }

    // Problem 2
    public static void GetUniqueSkills()
    {
        var emps = Employees.GetEmployees();

        var UniqueSkills = emps.SelectMany(e => e.Skills).Distinct().OrderBy(s => s).ToList();

        UniqueSkills.ForEach(s => Console.WriteLine(s));
    }

    // Problem 3 
    public static void GetEmployeeNameWithSkill()
    {
        var emps = Employees.GetEmployees();


        // The second lambda in SelectMany ==> lets you include data from both levels (outer + inner).
        var EmployeeNameWithSkill = emps.SelectMany(e => e.Skills, (e, skill) => new
        {
            e.Name,
            skill
        }).ToList();

        EmployeeNameWithSkill.ForEach(e => Console.WriteLine(e));
    }

    // Problem 1 with Select statement
    public static void GetAllSkills01()
    {
        var emps = Employees.GetEmployees();


        var Skills = emps.Select(e => e.Skills).ToList();

        Skills.ForEach(s => Console.WriteLine(s));
    }
}
