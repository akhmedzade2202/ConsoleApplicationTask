using ConsoleApplication1.Models;

namespace ConsoleApplication.Services.Interfaces
{
    public interface IDatabaseService
    {
        List<Classroom> Load();
        void Save(List<Classroom> data);
    }
}
