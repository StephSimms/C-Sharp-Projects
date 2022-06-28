using System;

namespace IQuittable_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = "Stephanie";
            employee.lastName = "Simms";
            employee.ID = 13;

            employee.SayName(employee.firstName, employee.lastName);

            employee.Quit();

            IQuittable Emp1 = new Employee();
            
            Emp1.Quit();

            Console.ReadLine();
        }
    }
}
