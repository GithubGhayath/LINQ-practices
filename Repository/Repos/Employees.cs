using Repository.Dtos;
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

public static class Meetings
{
    public static List<Meeting> GetMeetings()
    {
        return new List<Meeting>
    {
        new Meeting
        {
            Title = "Project Kickoff",
            Date = new DateOnly(2025, 1, 10),
            StartAt = new TimeOnly(9, 0),
            EndAt = new TimeOnly(10, 0),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E001", Name="Alice" },
                new EmployeeDto{ EmployeeNo = "E002", Name="Bob" },
                new EmployeeDto{ EmployeeNo = "E003", Name="Charlie" },
                new EmployeeDto{ EmployeeNo = "E004", Name="Diana" },
            }
        },

        new Meeting
        {
            Title = "Design Review",
            Date = new DateOnly(2025, 1, 11),
            StartAt = new TimeOnly(13, 30),
            EndAt = new TimeOnly(15, 0),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E003", Name="Charlie" },
                new EmployeeDto{ EmployeeNo = "E005", Name="Edward" },
                new EmployeeDto{ EmployeeNo = "E006", Name="Fiona" },
                new EmployeeDto{ EmployeeNo = "E004", Name="Diana" },
            }
        },

        new Meeting
        {
            Title = "Weekly Sync",
            Date = new DateOnly(2025, 1, 12),
            StartAt = new TimeOnly(10, 0),
            EndAt = new TimeOnly(11, 0),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E001", Name="Alice" },
                new EmployeeDto{ EmployeeNo = "E007", Name="George" },
                new EmployeeDto{ EmployeeNo = "E002", Name="Bob" },
                new EmployeeDto{ EmployeeNo = "E008", Name="Helen" },
            }
        },

        new Meeting
        {
            Title = "Client Presentation",
            Date = new DateOnly(2025, 1, 13),
            StartAt = new TimeOnly(16, 0),
            EndAt = new TimeOnly(17, 0),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E005", Name="Edward" },
                new EmployeeDto{ EmployeeNo = "E009", Name="Ian" },
                new EmployeeDto{ EmployeeNo = "E003", Name="Charlie" },
                new EmployeeDto{ EmployeeNo = "E010", Name="Jack" },
            }
        },

        new Meeting
        {
            Title = "Backend Planning",
            Date = new DateOnly(2025, 1, 14),
            StartAt = new TimeOnly(9, 30),
            EndAt = new TimeOnly(11, 30),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E003", Name="Charlie" },
                new EmployeeDto{ EmployeeNo = "E006", Name="Fiona" },
                new EmployeeDto{ EmployeeNo = "E011", Name="Kevin" },
                new EmployeeDto{ EmployeeNo = "E001", Name="Alice" },
            }
        },

        new Meeting
        {
            Title = "Marketing Strategy",
            Date = new DateOnly(2025, 1, 15),
            StartAt = new TimeOnly(14, 0),
            EndAt = new TimeOnly(15, 30),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E007", Name="George" },
                new EmployeeDto{ EmployeeNo = "E012", Name="Laura" },
                new EmployeeDto{ EmployeeNo = "E009", Name="Ian" },
                new EmployeeDto{ EmployeeNo = "E013", Name="Maria" },
            }
        },

        new Meeting
        {
            Title = "HR Training",
            Date = new DateOnly(2025, 1, 16),
            StartAt = new TimeOnly(11, 0),
            EndAt = new TimeOnly(12, 0),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E008", Name="Helen" },
                new EmployeeDto{ EmployeeNo = "E009", Name="Ian" },
                new EmployeeDto{ EmployeeNo = "E014", Name="Natalie" },
                new EmployeeDto{ EmployeeNo = "E015", Name="Oscar" },
            }
        },

        new Meeting
        {
            Title = "Security Audit",
            Date = new DateOnly(2025, 1, 17),
            StartAt = new TimeOnly(15, 0),
            EndAt = new TimeOnly(17, 0),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E001", Name="Alice" },
                new EmployeeDto{ EmployeeNo = "E005", Name="Edward" },
                new EmployeeDto{ EmployeeNo = "E006", Name="Fiona" },
                new EmployeeDto{ EmployeeNo = "E010", Name="Jack" },
            }
        },

        new Meeting
        {
            Title = "DevOps Retrospective",
            Date = new DateOnly(2025, 1, 18),
            StartAt = new TimeOnly(9, 0),
            EndAt = new TimeOnly(10, 0),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E010", Name="Jack" },
                new EmployeeDto{ EmployeeNo = "E011", Name="Kevin" },
                new EmployeeDto{ EmployeeNo = "E012", Name="Laura" },
                new EmployeeDto{ EmployeeNo = "E013", Name="Maria" },
            }
        },

        new Meeting
        {
            Title = "Sales Forecast",
            Date = new DateOnly(2025, 1, 19),
            StartAt = new TimeOnly(10, 30),
            EndAt = new TimeOnly(11, 30),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E007", Name="George" },
                new EmployeeDto{ EmployeeNo = "E009", Name="Ian" },
                new EmployeeDto{ EmployeeNo = "E014", Name="Natalie" },
                new EmployeeDto{ EmployeeNo = "E006", Name="Fiona" },
            }
        },

        new Meeting
        {
            Title = "Budget Review",
            Date = new DateOnly(2025, 1, 20),
            StartAt = new TimeOnly(13, 0),
            EndAt = new TimeOnly(14, 0),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E006", Name="Fiona" },
                new EmployeeDto{ EmployeeNo = "E015", Name="Oscar" },
                new EmployeeDto{ EmployeeNo = "E005", Name="Edward" },
                new EmployeeDto{ EmployeeNo = "E001", Name="Alice" },
            }
        },

        new Meeting
        {
            Title = "Product Brainstorm",
            Date = new DateOnly(2025, 1, 21),
            StartAt = new TimeOnly(9, 30),
            EndAt = new TimeOnly(11, 0),
            Participants = new List<EmployeeDto>
            {
                new EmployeeDto{ EmployeeNo = "E001", Name="Alice" },
                new EmployeeDto{ EmployeeNo = "E003", Name="Charlie" },
                new EmployeeDto{ EmployeeNo = "E004", Name="Diana" },
                new EmployeeDto{ EmployeeNo = "E012", Name="Laura" },
            }
        }
    };
    }
}
public static class Employees
{
    private static readonly Random Rand = new();

    private static readonly string[] Names =
    {
        "Ahmad","Omar","Samer","Khaled","Rami","Fadi","Mahmoud","Tariq",
        "Nour","Yasser","Sleiman","Hassan","Bilal","Ziad","Nader",
        "Karim","Amer","Walid","Fares","Ghaith"
    };

    private static readonly string[] SkillPool =
    {
        "C#", "SQL", "Docker", "Kubernetes", "Java", "Python", "Problem Solving",
        "Teamwork", "Microservices", "API Design", "Security"
    };


    public static List<EmployeeExtension> GenerateEmployees(int count = 100)
    {
        var list = new List<EmployeeExtension>();

        for (int i = 1; i <= count; i++)
        {
            var skills = new List<string>();
            int skillCount = Rand.Next(1, 5); // 1–4 skills

            for (int s = 0; s < skillCount; s++)
            {
                var skill = SkillPool[Rand.Next(SkillPool.Length)];
                if (!skills.Contains(skill)) skills.Add(skill);
            }

            var employee = new EmployeeExtension
            {
                Id = i.ToString(),
                Name = Names[Rand.Next(Names.Length)],
                Age = Rand.Next(20, 60),
                DepartmentId = Rand.Next(1, 6),
                Salary = Rand.Next(800, 6000),
                HireDate = DateTime.Now.AddDays(-Rand.Next(100, 3000)),
                IsActive = Rand.Next(0, 2) == 1,
                Skills = skills,
                HasHealthInsurance = Rand.Next(0, 2) == 1,
                HasPensionPlan = Rand.Next(0, 2) == 1
            };

            list.Add(employee);
        }

        return list;
    }
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
