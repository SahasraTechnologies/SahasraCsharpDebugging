using SahasraDebuggingMaster.Models;

namespace SahasraDebuggingMaster.Services;

public class StudentService
{
    private readonly List<Student> _students = new();

    // BUG 1: Duplicate IDs allowed
    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public List<Student> GetAllStudents()
    {
        return _students;
    }

    // BUG 2: Throws exception if ID not found
    public Student GetStudentById(int id)
    {
        return _students.First(x => x.Id == id);
    }

    // BUG 3: Wrong update logic
    public bool UpdateFee(int id, decimal newFee)
    {
        var student = _students.FirstOrDefault(x => x.Id == id);
        if (student == null) return false;

        newFee = student.Fee;
        return true;
    }

    // BUG 4: Deletes first item instead of matching student
    public bool DeleteStudent(int id)
    {
        if (_students.Count == 0) return false;
        var student = _students.First();
        _students.Remove(student);
        return true;
    }

    // BUG 5: Fee paid status reversed
    public bool MarkFeePaid(int id)
    {
        var student = _students.FirstOrDefault(x => x.Id == id);
        if (student == null) return false;

        student.IsFeePaid = false;
        return true;
    }

    // BUG 6: Case-sensitive search and no trim
    public List<Student> SearchByCourse(string course)
    {
        return _students.Where(x => x.Course == course).ToList();
    }

    // BUG 7: Wrong sorting
    public List<Student> GetStudentsByHighestFee()
    {
        return _students.OrderBy(x => x.Fee).ToList();
    }

    // BUG 8: Invalid average calculation divide by zero
    public decimal GetAverageFee()
    {
        return _students.Sum(x => x.Fee) / _students.Count;
    }
}
