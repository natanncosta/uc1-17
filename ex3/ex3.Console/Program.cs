using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Employee employee;

            Console.Write("Informe o nome do funcionário: ");
            string name = Console.ReadLine();

            double salary;
            while (true)
            {
                try
                {
                    Console.Write("Informe o salário: ");
                    salary = Convert.ToDouble(Console.ReadLine());
                    employee = new(name, salary);
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("O sálario precisa ser um valor numérico.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{employee.Name} => id: {employee.Id}");
        }
    }
}
