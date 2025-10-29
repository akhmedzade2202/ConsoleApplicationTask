namespace Models
{
    public class Manager
    {
        protected Employee GetPromotion(Employee emp)
        {
            emp.Salary += 100; 
            return emp;
        }
    }
}
