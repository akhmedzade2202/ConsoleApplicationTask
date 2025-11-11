using ConsoleApplication1.Models;

namespace ConsoleApplication1.Services.Interfaces
{
    public interface IStudentService
    {
        void CreateStudent(List<Classroom> data);
        void ShowAllStudents(List<Classroom> data);
        void ShowStudentsInClass(List<Classroom> data);
        void DeleteStudent(List<Classroom> data);
    }
}
