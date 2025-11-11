using ConsoleApplication1.Exceptions;

namespace ConsoleApplication1.Models
{
    public class Classroom
    {
        public static int _counter = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public ClassroomType Type { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Classroom(string name, ClassroomType type)
        {
            Id = _counter++;
            Name = name;
            Type = type;
        }

        public Classroom() { } 

        public void AddStudent(Student student)
        {
            int limit = Type == ClassroomType.Backend ? 20 : 15;
            if (Students.Count >= limit)
                throw new Exception($"{Name} sinifinin limiti ({limit}) doludur!");

            Students.Add(student);
        }

        public Student FindId(int id) =>
            Students.FirstOrDefault(s => s.Id == id);

        public void Delete(int id)
        {
            var student = FindId(id);
            if (student == null)
                throw new StudentNotFoundException(id);
            Students.Remove(student);
        }
    }
}
