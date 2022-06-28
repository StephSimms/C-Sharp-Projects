using System;

namespace Operator_Overload_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "Steph";
            employee1.LastName = "Simms";

            Employee employee2 = new Employee();
            employee2.Id = 1;
            employee2.FirstName = "Joe";
            employee2.LastName = "Buck";

            if (employee1 == employee2)
            {
                Console.WriteLine("employee1 is equal to employee2");
            }
            else
            {
                Console.WriteLine("employee1 is not equal to employee2");
            }
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id.Equals(employee2.Id))
        {
            return true;
        }
        return false;
        }
    public static bool operator !=(Employee employee1, Employee employee2)
        {
        if (!employee1.Id.Equals(employee2.Id))
        {
            return true;
        }
        return false;
        }
    }
}
            