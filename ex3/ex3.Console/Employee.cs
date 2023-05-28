using System;

namespace ex3
{
    public class Employee
    {
        private static int _id = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            if (name == null)
                throw new ArgumentException("Nome é obrigatório");
            if (salary < 1300)
                throw new ArgumentException("Salário abaixo do mínimo");

            Id = _id;
            Name = name;
            Salary = salary;
            _id++;
        }
    }
}
