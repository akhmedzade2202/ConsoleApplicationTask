namespace ConsoleApplication1.Models
{
    public class Student
    {
        public static int _counter = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Id = _counter++;
            Name = name;
            Surname = surname;
        }

        public Student() { }
    }
}
