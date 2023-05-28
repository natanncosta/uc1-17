using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Employee employee1 = new("John", 10000);
            Employee employee2 = new("Natan", 999999999);
            Employee employee3 = new("Isaac", 4900);
            Employee employee4 = new("Barry", 4900);

            Console.WriteLine($"{employee1.Name} => id: {employee1.Id}");
            Console.WriteLine($"{employee2.Name} => id: {employee2.Id}");
            Console.WriteLine($"{employee3.Name} => id: {employee3.Id}");
            Console.WriteLine($"{employee4.Name} => id: {employee4.Id}");
        }
    }
}
