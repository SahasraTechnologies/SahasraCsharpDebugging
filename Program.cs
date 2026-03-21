using SahasraDebuggingMaster.Helpers;
using SahasraDebuggingMaster.Models;
using SahasraDebuggingMaster.Modules;
using SahasraDebuggingMaster.Services;

StudentService service = new StudentService();
Seed(service);

bool run = true;

while (run)
{
    ConsoleHelper.Header("Sahasra Technologies - C# Debugging Master Pack");
    Console.WriteLine("1. Student CRUD Bug Practice");
    Console.WriteLine("2. String Bug Module");
    Console.WriteLine("3. Array Bug Module");
    Console.WriteLine("4. LINQ Bug Module");
    Console.WriteLine("5. File Bug Module");
    Console.WriteLine("6. Date Bug Module");
    Console.WriteLine("7. Calculation Bug Module");
    Console.WriteLine("8. Async Bug Module");
    Console.WriteLine("9. List Modification Bug Module");
    Console.WriteLine("10. Parse Bug Module");
    Console.WriteLine("11. Null Collection Bug Module");
    Console.WriteLine("12. Logical Condition Bug Module");
    Console.WriteLine("13. Exit");

    string choice = ConsoleHelper.ReadText("Enter choice: ");

    switch (choice)
    {
        case "1":
            RunStudentCrud(service);
            break;
        case "2":
            StringBugModule.Run();
            break;
        case "3":
            ArrayBugModule.Run();
            break;
        case "4":
            LinqBugModule.Run();
            break;
        case "5":
            FileBugModule.Run();
            break;
        case "6":
            DateBugModule.Run();
            break;
        case "7":
            CalculationBugModule.Run();
            break;
        case "8":
            await AsyncBugModule.Run();
            break;
        case "9":
            ListModificationBugModule.Run();
            break;
        case "10":
            ParseBugModule.Run();
            break;
        case "11":
            NullCollectionBugModule.Run();
            break;
        case "12":
            LogicalConditionBugModule.Run();
            break;
        case "13":
            run = false;
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
}

static void RunStudentCrud(StudentService service)
{
    bool back = false;

    while (!back)
    {
        ConsoleHelper.Header("Student CRUD Bug Practice");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. List Students");
        Console.WriteLine("3. Get Student By Id");
        Console.WriteLine("4. Update Fee");
        Console.WriteLine("5. Delete Student");
        Console.WriteLine("6. Mark Fee Paid");
        Console.WriteLine("7. Search By Course");
        Console.WriteLine("8. Highest Fee Students");
        Console.WriteLine("9. Average Fee");
        Console.WriteLine("10. Back");

        string choice = ConsoleHelper.ReadText("Enter choice: ");

        switch (choice)
        {
            case "1":
                AddStudent(service);
                break;
            case "2":
                foreach (var s in service.GetAllStudents())
                    Console.WriteLine($"{s.Id} | {s.Name} | {s.Course} | {s.Fee} | Paid:{s.IsFeePaid}");
                break;
            case "3":
                var id = ConsoleHelper.ReadInt("Enter Id: ");
                var student = service.GetStudentById(id);
                Console.WriteLine($"{student.Id} | {student.Name} | {student.Course}");
                break;
            case "4":
                service.UpdateFee(ConsoleHelper.ReadInt("Enter Id: "), ConsoleHelper.ReadDecimal("Enter New Fee: "));
                Console.WriteLine("Updated.");
                break;
            case "5":
                service.DeleteStudent(ConsoleHelper.ReadInt("Enter Id: "));
                Console.WriteLine("Deleted.");
                break;
            case "6":
                service.MarkFeePaid(ConsoleHelper.ReadInt("Enter Id: "));
                Console.WriteLine("Fee status changed.");
                break;
            case "7":
                var course = ConsoleHelper.ReadText("Enter Course: ");
                foreach (var s in service.SearchByCourse(course))
                    Console.WriteLine($"{s.Id} | {s.Name} | {s.Course}");
                break;
            case "8":
                foreach (var s in service.GetStudentsByHighestFee())
                    Console.WriteLine($"{s.Name} | {s.Fee}");
                break;
            case "9":
                Console.WriteLine(service.GetAverageFee());
                break;
            case "10":
                back = true;
                break;
        }
    }
}

static void AddStudent(StudentService service)
{
    Student s = new Student
    {
        Id = ConsoleHelper.ReadInt("Enter Id: "),
        Name = ConsoleHelper.ReadText("Enter Name: "),
        Age = ConsoleHelper.ReadInt("Enter Age: "),
        Course = ConsoleHelper.ReadText("Enter Course: "),
        Fee = ConsoleHelper.ReadDecimal("Enter Fee: "),
        Email = ConsoleHelper.ReadText("Enter Email: ")
    };
    service.AddStudent(s);
    Console.WriteLine("Student added.");
}

static void Seed(StudentService service)
{
    service.AddStudent(new Student { Id = 1, Name = "Ravi", Age = 21, Course = "C#", Fee = 15000, IsFeePaid = false, Email = "ravi@test.com" });
    service.AddStudent(new Student { Id = 2, Name = "Sita", Age = 22, Course = "SQL", Fee = 12000, IsFeePaid = true, Email = "sita@test.com" });
    service.AddStudent(new Student { Id = 3, Name = "Kiran", Age = 20, Course = "ASP.NET", Fee = 18000, IsFeePaid = false, Email = "kiran@test.com" });
}
