using Repository.Entities;
using Repository.Repos;
using System.ComponentModel;
namespace OrderByStatement;
internal class OrderByStatementProgram
{
    public static void Main(string[]args)
    {
        Console.WriteLine("EmployeesOrderBySalaryAsc:\n");
        EmployeesOrderBySalaryAsc();


        Console.WriteLine("\n\n\nEmployeesOrderByFirstName:\n");
        EmployeesOrderByFirstName();

        Console.WriteLine("\n\n\nEmployeesOrderByFirstNameAscAndSalaryDesc:\n");
        EmployeesOrderByFirstNameAscAndSalaryDesc();

        Console.WriteLine("\n\n\nEmployeesOrderByIDSpecial():\n");
        EmployeesOrderByIDSpecial();
    }

    public static void EmployeesOrderBySalaryAsc()
    {
        var Emps = Employees.GetEmployees();

        var EmployeesOrderBySalaryAsc = Emps.OrderBy(e => e.Salary).ToList();

        EmployeesOrderBySalaryAsc.ForEach(e=>Console.WriteLine(e));
    }

    public static void EmployeesOrderByFirstName()
    {
        var emps = Employees.GetEmployees();

        var EmployeesOrderByFirstName = emps.OrderBy(e=>e.Name).ToList();

        EmployeesOrderByFirstName.ForEach(emps => Console.WriteLine(emps));
    }

    public static void EmployeesOrderByFirstNameAscAndSalaryDesc()
    {
        var emps = Employees.GetEmployees();

        var EmployeesOrderByFirstNameAscAndSalaryDesc = emps.OrderBy(e => e.Name).ThenByDescending(e => e.Salary).ToList();

        EmployeesOrderByFirstNameAscAndSalaryDesc.ForEach(e => Console.WriteLine(e));
    }

    public static void EmployeesOrderByIDSpecial()
    {
        var emps = Employees.GetEmployees();
        // Sort the employees, not just by a single property  but using my own rules written inside the EmployeeComparer class.
        var EmployeesOrderByIDSpecial = emps.OrderBy(e => e, new EmployeeComparer()).ToList();

        EmployeesOrderByIDSpecial.ForEach(emps => Console.WriteLine(emps));

    }
   
}




public class EmployeeComparer : IComparer<Employee>
{

    // This method is called many times by .OrderBy() while sorting.
    public int Compare(Employee? e1, Employee? e2)
    {
        // "2022-IT-1236" ==> "2022", "IT" , "1234"


        var e1Year = e1!.Id.Split("-")[0];
        var e2Year = e2!.Id.Split("-")[0];


        var e1Department = e1.Id.Split("-")[1];
        var e2Department = e2.Id.Split("-")[1];


        var e1NoID = e1.Id.Split("-")[2];
        var e2NoID = e2.Id.Split("-")[2];


        int result = 0;

        if(e1Year == e2Year)
        {
            if (e1Department == e2Department) 
            {
                result = e1NoID.CompareTo(e2NoID);
            }
            else
            {

                /*
                 They are different ("IT" vs "HR"),
                            so result = e1Department.CompareTo(e2Department);

                            "IT".CompareTo("HR") returns a positive number
                            (because "I" comes after "H" alphabetically).
                            That means "HR" will appear before "IT" in the sorted list.
                 
                 */
                result = e1Department.CompareTo(e2Department);
            }
        }
        else
        {
            result = e1Year.CompareTo(e2Year);
        }

        return result;
    }


}