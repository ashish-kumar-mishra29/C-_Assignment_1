using System;

namespace Assignmet_1
{
    public class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter Employee Id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Department Name:");
            string departmentName = Console.ReadLine();

            Employee employee = new Employee(id, name, departmentName);

            // Subscribe to the MethodCalled event
            employee.MethodCalled += (methodName) => Console.WriteLine(methodName);

            // Printing properties using methods
            Console.WriteLine("Id: " + employee.GetId());
            Console.WriteLine("Name: " + employee.GetName());
            Console.WriteLine("Department Name: " + employee.GetDepartmentName());

            // Update properties
            employee.UpdateId(1001);
            employee.UpdateName("John Doe");
            employee.UpdateDepartmentName("Engineering");

            // Printing updated properties
            Console.WriteLine("\nAfter Update:");
            Console.WriteLine("Id: " + employee.GetId());
            Console.WriteLine("Name: " + employee.GetName());
            Console.WriteLine("Department Name: " + employee.GetDepartmentName());

        }
    }
}