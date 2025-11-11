namespace ConsoleApplication1.Exceptions
{
    public class ClassroomNotFoundException : Exception
    {
        public ClassroomNotFoundException()
            : base("Heç bir sinif tapılmadı. Əvvəlcə sinif yaradın.")
        {
        }
    }
}
