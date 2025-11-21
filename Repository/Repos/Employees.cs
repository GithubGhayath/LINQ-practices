using Repository.Entities;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Repository.Repos;

public static class Departments
{
    public static List<Department> GetDepartments()
    {
        return new List<Department>
        {
            new Department{ Id = 1 , Name = "IT"},
            new Department{ Id = 2 , Name = "HR"},
            new Department{ Id = 3 , Name = "Sales"},
            new Department{ Id = 4 , Name = "Marketing"},
            new Department{ Id = 5 , Name = "Finance"}
        };
    }
}
public static class Employees
{
    public static List<Employee> GetEmployees()
    {
        return new List<Employee>
{
    new Employee { Id = "2022-AA-1234",  Name = "Ahmad Khaled", Age = 28, DepartmentId =1, Salary = 3200, HireDate = new DateTime(2020, 1, 15), IsActive = true, Skills = new List<string>{ "C#", "ASP.NET", "SQL" } },
    new Employee { Id = "2022-AA-1234",  Name = "Sara Hassan", Age = 34, DepartmentId = 2, Salary = 4100, HireDate = new DateTime(2018, 5, 22), IsActive = true, Skills = new List<string>{ "Recruitment", "Communication", "Payroll" } },
    new Employee { Id = "2022-AA-1236",  Name = "Omar Youssef", Age = 25, DepartmentId = 3, Salary = 2800, HireDate = new DateTime(2021, 3, 10), IsActive = true, Skills = new List<string>{ "HTML", "CSS", "JavaScript" } },
    new Employee { Id = "2022-AA-1237",  Name = "Lina Ahmad", Age = 30, DepartmentId = 4, Salary = 4500, HireDate = new DateTime(2019, 7, 1), IsActive = true, Skills = new List<string>{ "Excel", "Budgeting", "Taxation" } },
    new Employee { Id = "2022-AA-1238",  Name = "Hadi Alwan", Age = 42, DepartmentId = 2, Salary = 5200, HireDate = new DateTime(2015, 4, 11), IsActive = true, Skills = new List<string>{ "Negotiation", "CRM", "Product Knowledge" } },
    new Employee { Id = "2022-AA-1239",  Name = "Rana Suleiman", Age = 27, DepartmentId = 5, Salary = 3100, HireDate = new DateTime(2022, 1, 4), IsActive = true, Skills = new List<string>{ "Social Media", "SEO", "Content Writing" } },
    new Employee { Id = "2022-AA-1240",  Name = "Fadi Mansour", Age = 39, DepartmentId = 5, Salary = 6000, HireDate = new DateTime(2014, 9, 9), IsActive = true, Skills = new List<string>{ "C#", "Azure", "Docker" } },
    new Employee { Id = "2022-AA-1241",  Name = "Hala Saad", Age = 31, DepartmentId = 5, Salary = 4700, HireDate = new DateTime(2019, 11, 14), IsActive = true, Skills = new List<string>{ "Auditing", "Accounting", "Risk Analysis" } },
    new Employee { Id = "2022-AA-1242",  Name = "Ali Nasser", Age = 26, DepartmentId = 5, Salary = 2900, HireDate = new DateTime(2022, 6, 6), IsActive = true, Skills = new List<string>{ "Cold Calling", "Customer Service", "Negotiation" } },
    new Employee { Id = "2022-AA-1243",  Name = "Nour Fares", Age = 35, DepartmentId = 3, Salary = 4200, HireDate = new DateTime(2017, 2, 25), IsActive = true, Skills = new List<string>{ "Interviewing", "Team Management", "Policy Making" } },
    new Employee { Id = "2022-AA-1244",  Name = "Walid Khoury", Age = 45, DepartmentId = 3, Salary = 7000, HireDate = new DateTime(2010, 8, 3), IsActive = false, Skills = new List<string>{ "C#", "SQL", "System Architecture" } },
    new Employee { Id = "2022-AA-1245",  Name = "Mona Taha", Age = 29, DepartmentId = 2, Salary = 3300, HireDate = new DateTime(2021, 10, 10), IsActive = true, Skills = new List<string>{ "Copywriting", "Email Campaigns", "Analytics" } },
    new Employee { Id = "2022-AA-1246",  Name = "Hussein Barakat", Age = 38, DepartmentId = 1, Salary = 5600, HireDate = new DateTime(2016, 5, 20), IsActive = true, Skills = new List<string>{ "Financial Modeling", "Forecasting", "Auditing" } },
    new Employee { Id = "2022-AA-1247",  Name = "Nada Jaber", Age = 32, DepartmentId = 1, Salary = 3900, HireDate = new DateTime(2019, 3, 8), IsActive = true, Skills = new List<string>{ "Employee Relations", "Training", "Benefits Management" } },
    new Employee { Id = "2022-AA-1248",  Name = "Sami Issa", Age = 41, DepartmentId = 4, Salary = 4800, HireDate = new DateTime(2014, 1, 1), IsActive = false, Skills = new List<string>{ "Client Acquisition", "Negotiation", "Reporting" } },
    new Employee { Id = "2022-AA-1249",  Name = "Tala Kanaan", Age = 24, DepartmentId = 4, Salary = 2600, HireDate = new DateTime(2023, 2, 1), IsActive = true, Skills = new List<string>{ "HTML", "CSS", "React" } },
    new Employee { Id = "2022-AA-1250",  Name = "Majed Rida", Age = 37, DepartmentId = 4, Salary = 5300, HireDate = new DateTime(2018, 9, 13), IsActive = true, Skills = new List<string>{ "Accounting", "Reporting", "Excel" } },
    new Employee { Id = "2022-AA-1251",  Name = "Rima Abdallah", Age = 33, DepartmentId = 3, Salary = 3800, HireDate = new DateTime(2020, 12, 7), IsActive = true, Skills = new List<string>{ "Branding", "Design", "Market Research" } },
    new Employee { Id = "2022-AA-1252",  Name = "Ola Hamdan", Age = 40, DepartmentId = 3, Salary = 4600, HireDate = new DateTime(2015, 6, 16), IsActive = false, Skills = new List<string>{ "Conflict Resolution", "Recruitment", "Leadership" } },
    new Employee { Id = "2022-AA-1253",  Name = "Karim Zain", Age = 27, DepartmentId = 1, Salary = 3000, HireDate = new DateTime(2021, 1, 18), IsActive = true, Skills = new List<string>{ "Python", "APIs", "Unit Testing" } },
    new Employee { Id = "2022-AA-1254",  Name = "Layal Khateeb", Age = 28, DepartmentId = 3, Salary = 3200, HireDate = new DateTime(2020, 9, 9), IsActive = true, Skills = new List<string>{ "Presentation", "Negotiation", "CRM" } },
    new Employee { Id = "2022-AA-1255",  Name = "Adnan Bitar", Age = 50, DepartmentId = 3, Salary = 7500, HireDate = new DateTime(2009, 4, 1), IsActive = false, Skills = new List<string>{ "Strategy", "Accounting", "Tax Planning" } },
    new Employee { Id = "2022-AA-1256",  Name = "Hassan Ali", Age = 31, DepartmentId = 2, Salary = 4500, HireDate = new DateTime(2018, 8, 22), IsActive = true, Skills = new List<string>{ "C#", "SQL", "JavaScript" } },
    new Employee { Id = "2022-AA-1257",  Name = "Farah Haddad", Age = 36, DepartmentId = 2, Salary = 4000, HireDate = new DateTime(2017, 10, 2), IsActive = true, Skills = new List<string>{ "Social Media", "Brand Strategy", "Copywriting" } },
    new Employee { Id = "2022-AA-1257",  Name = "Repetad Haddad", Age = 36, DepartmentId = 1, Salary = 4000, HireDate = new DateTime(2017, 10, 2), IsActive = true, Skills = new List<string>{ "Social Media", "Brand Strategy", "Copywriting" } },
    new Employee { Id = "2022-AA-1258",  Name = "Nabil Omar", Age = 43, DepartmentId = 4, Salary = 5100, HireDate = new DateTime(2014, 12, 5), IsActive = true, Skills = new List<string>{ "B2B Sales", "Negotiation", "Customer Retention" } },
    new Employee { Id = "2022-AA-1259",  Name = "Razan Khalil", Age = 29, DepartmentId = 4, Salary = 3700, HireDate = new DateTime(2021, 3, 15), IsActive = true, Skills = new List<string>{ "Data Analysis", "Excel", "Reporting" } },
    new Employee { Id = "2022-AA-1260",  Name = "Samir Daher", Age = 34, DepartmentId = 1, Salary = 4300, HireDate = new DateTime(2017, 11, 10), IsActive = true, Skills = new List<string>{ "Interviewing", "Policy Writing", "Training" } },
    new Employee { Id = "2022-AA-1261",  Name = "Dana Abbas", Age = 25, DepartmentId = 1, Salary = 2800, HireDate = new DateTime(2022, 7, 20), IsActive = true, Skills = new List<string>{ "Design", "Video Editing", "Social Media" } },
    new Employee { Id = "2022-AA-1262",  Name = "Nadim Awad", Age = 38, DepartmentId = 2, Salary = 5400, HireDate = new DateTime(2016, 5, 5), IsActive = true, Skills = new List<string>{ "Java", "Spring Boot", "Microservices" } },
    new Employee { Id = "2022-AA-1263",  Name = "Yasmin Fadl", Age = 27, DepartmentId = 2, Salary = 3000, HireDate = new DateTime(2021, 11, 25), IsActive = true, Skills = new List<string>{ "Negotiation", "CRM", "Customer Service" } },
};
    }
    public static List<Employee> GetRange(int From,int To)
    {
        int Count = To - From;
        var Employees = GetEmployees();

        return Employees.GetRange(From, Count);
    }
}
