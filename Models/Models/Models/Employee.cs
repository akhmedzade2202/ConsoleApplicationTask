namespace Models
{
    public class Employee
    {
        public string Name { get; set; }
        public bool IsSuccessful { get; set; }

        public double Salary { get; internal set; }

        public Employee(string name, bool isSuccessful, double salary)
        {
            Name = name;
            IsSuccessful = isSuccessful;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name} | Successful: {IsSuccessful} | Salary: {Salary}";
        }
    }
}
