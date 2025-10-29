using Models;

Employee emp1 = new Employee("Emrah", true, 800);
Employee emp2 = new Employee("Sdmd", false, 900);

Assistant assistant = new Assistant();

assistant.GetFeedBack(emp1);
assistant.GetFeedBack(emp2);

Console.WriteLine();
Console.WriteLine("Result:");
Console.WriteLine(emp1);
Console.WriteLine(emp2);