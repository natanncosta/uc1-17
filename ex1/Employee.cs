namespace ex1
{
    public class Employee
    {
        private static int _id = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            _id++;
            this.Id = _id;
            this.Name = name;
            this.Salary = salary;
        }
    }
}
