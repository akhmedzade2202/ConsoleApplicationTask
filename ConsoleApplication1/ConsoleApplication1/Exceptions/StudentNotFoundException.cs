namespace ConsoleApplication1.Exceptions
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(int id)
            : base($"Id-si {id} olan telebe tapilmadi.")
        {
        }
    }
}
