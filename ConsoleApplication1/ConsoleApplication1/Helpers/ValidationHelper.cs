namespace ConsoleApplication1.Helpers
{
    public static class ValidationExtensions
    {
        public static bool IsValidName(this string name)
        {
            return !string.IsNullOrWhiteSpace(name)
                   && name.Length >= 3
                   && !name.Contains(" ")
                   && char.IsUpper(name[0]);
        }

        public static bool IsValidSurname(this string surname)
        {
            return !string.IsNullOrWhiteSpace(surname)
                   && surname.Length >= 3
                   && !surname.Contains(" ")
                   && char.IsUpper(surname[0]);
        }

        public static bool IsValidClassName(this string className)
        {
            return className.Length == 5 &&
                   className.Take(2).All(char.IsUpper) &&
                   className.Skip(2).All(char.IsDigit);
        }
    }
}
