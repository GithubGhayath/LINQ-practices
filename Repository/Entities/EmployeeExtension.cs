namespace Repository.Entities;

public class EmployeeExtension : Employee
{
    public bool HasHealthInsurance { get; set; }

    public bool HasPensionPlan { get; set; }

    public override string ToString()
    {
        return $"{Id,-3} | {Name,-15} | Age: {Age,-2} | Dept: {DepartmentId,-10} | Salary: {Salary,7:C0} | Hired: {HireDate:yyyy-MM-dd} | Active: {IsActive} | Skills: {string.Join(", ", Skills)} |  HasPensionPlan: {HasPensionPlan} | Has Health Insurance: {HasHealthInsurance}";
    }
}
