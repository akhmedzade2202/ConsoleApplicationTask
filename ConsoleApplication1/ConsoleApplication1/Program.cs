using ConsoleApplication.Services.Interfaces;
using ConsoleApplication1.Services;
using ConsoleApplication1.Services.Interfaces;

IDatabaseService db = new DatabaseService();
IClassroomService classroomService = new ClassroomService();
IStudentService studentService = new StudentService();

var data = db.Load();

while (true)
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Classroom yarat");
    Console.WriteLine("2. Student yarat");
    Console.WriteLine("3. Butun telebeleri goster");
    Console.WriteLine("4. Secilmis sinifde telebeleri goster");
    Console.WriteLine("5. Telebe sil");
    Console.WriteLine("0. Cixis");
    Console.Write("Secim: ");
    string secim = Console.ReadLine();

    try
    {
        switch (secim)
        {
            case "1":
                classroomService.CreateClassroom(data);
                break;
            case "2":
                studentService.CreateStudent(data);
                break;
            case "3":
                studentService.ShowAllStudents(data);
                break;
            case "4":
                studentService.ShowStudentsInClass(data);
                break;
            case "5":
                studentService.DeleteStudent(data);
                break;
            case "0":
                db.Save(data);
                Console.WriteLine(" Melumatlar yadda saxlanildi. Proqram baglanir...");
                return;
            default:
                Console.WriteLine("Yanlis secim etmisiniz.");
                break;
        }

        db.Save(data);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Xeta: {ex.Message}");
    }
}