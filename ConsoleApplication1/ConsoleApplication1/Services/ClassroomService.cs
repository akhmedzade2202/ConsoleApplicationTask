using ConsoleApplication1.Helpers;
using ConsoleApplication1.Models;
using ConsoleApplication1.Services.Interfaces;

namespace ConsoleApplication1.Services
{
    public class ClassroomService : IClassroomService
    {
        public void CreateClassroom(List<Classroom> data)
        {
            string name;
            do
            {
                Console.Write("Classroom adi (AA123): ");
                name = Console.ReadLine();
            } while (!name.IsValidClassName());

            Console.Write("Type secin (1-Backend, 2-Frontend): ");
            int typeInput = int.Parse(Console.ReadLine());
            ClassroomType type = (ClassroomType)typeInput;

            var classroom = new Classroom(name, type);
            data.Add(classroom);
            Console.WriteLine($"{classroom.Name} sinifi yaradildi.");
        }
    }
}
