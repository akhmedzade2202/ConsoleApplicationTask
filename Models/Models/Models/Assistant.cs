namespace Models
{
    public class Assistant : Manager
    {
        public void GetFeedBack(Employee emp)
        {
            if (emp.IsSuccessful)
            {
                GetPromotion(emp);
                Console.WriteLine($"{emp.Name} ugurlu oldu! Maasi artirildi.");
            }
            else
            {
                Console.WriteLine($"{emp.Name} ugurlu deyil. Maas deyismedi.");
            }
        }
    }
}
