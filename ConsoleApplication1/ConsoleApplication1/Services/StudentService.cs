using ConsoleApplication1.Helpers;
using ConsoleApplication1.Models;
using ConsoleApplication1.Exceptions;
using ConsoleApplication1.Services.Interfaces;

namespace ConsoleApplication1.Services
{
    public class StudentService : IStudentService
    {
        public void CreateStudent(List<Classroom> data)
        {
            if (!data.Any()) throw new ClassroomNotFoundException();

            Console.WriteLine("Sinifler:");
            foreach (var cls in data)
                Console.WriteLine($"{cls.Id}. {cls.Name} ({cls.Type}) [{cls.Students.Count}]");

            Console.Write("Sinif id: ");
            int id = int.Parse(Console.ReadLine());
            var classroom = data.FirstOrDefault(x => x.Id == id);
            if (classroom == null)
                throw new ClassroomNotFoundException();

            string name, surname;

            do
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
            } while (!name.IsValidName());

            do
            {
                Console.Write("Surname: ");
                surname = Console.ReadLine();
            } while (!surname.IsValidSurname());

            var student = new Student(name, surname);
            classroom.AddStudent(student);
            Console.WriteLine($"{student.Name} {student.Surname} elave olundu.");
        }

        public void ShowAllStudents(List<Classroom> data)
        {
            foreach (var cls in data)
            {
                Console.WriteLine($"{cls.Name} ({cls.Type}):");
                foreach (var st in cls.Students)
                    Console.WriteLine($"  {st.Id}: {st.Name} {st.Surname}");
            }
        }

        public void ShowStudentsInClass(List<Classroom> data)
        {
            Console.Write("Sinif id: ");
            int id = int.Parse(Console.ReadLine());
            var cls = data.FirstOrDefault(x => x.Id == id);
            if (cls == null)
                throw new ClassroomNotFoundException();

            foreach (var st in cls.Students)
                Console.WriteLine($"{st.Id}: {st.Name} {st.Surname}");
        }

        public void DeleteStudent(List<Classroom> data)
        {
            Console.Write("Silinecek telebe id: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var cls in data)
            {
                var student = cls.FindId(id);
                if (student != null)
                {
                    cls.Delete(id);
                    Console.WriteLine($"{student.Name} silindi.");
                    return;
                }
            }

            throw new StudentNotFoundException(id);
        }
    }
}
