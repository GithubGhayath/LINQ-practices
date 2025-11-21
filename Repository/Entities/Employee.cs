namespace Repository.Entities;

public class Employee
{
    public string Id { get; set; }
    public required string Name { get; set; }
    public int Age { get; set; }
    public required int DepartmentId { get; set; }
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }
    public bool IsActive { get; set; }


    public required List<string> Skills { get; set; }

  
    public override string ToString()
    {
        return $"{Id,-3} | {Name,-15} | Age: {Age,-2} | Dept: {DepartmentId,-10} | Salary: {Salary,7:C0} | Hired: {HireDate:yyyy-MM-dd} | Active: {IsActive} | Skills: {string.Join(", ", Skills)}";
    }
}
