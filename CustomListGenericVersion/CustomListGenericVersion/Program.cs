using CustomListGenericVersion;

CustomList<string> names = new CustomList<string>();

names.Add("Aysen");
names.Add("Amrah");
names.Add("Leyla");
names.Add("Rauf");

Console.WriteLine("CustomList:");
names.GetAll();

names.AddRange("Elvin", "Aygun", "Kamal");
Console.WriteLine("\nAfter AddRange:");
names.GetAll();


names.Insert(2, "NEW");
Console.WriteLine("\nAfter Insert (index 2, 'NEW'):");
names.GetAll();

names.InsertRange(1, "Salam");
Console.WriteLine("\nAfter InsertRange (index 1, 'Salam'):");
names.GetAll();

names.Remove("Rauf");
Console.WriteLine("\nAfter Remove('Rauf'):");
names.GetAll();

names.RemoveAt(0);
Console.WriteLine("\nAfter RemoveAt(0):");
names.GetAll();

names.Clear();
Console.WriteLine("\nAfter Clear:");
names.GetAll();

Console.WriteLine("\nCount after Clear: " + names.Count);