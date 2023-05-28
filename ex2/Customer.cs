namespace ex2
{
    public class Customer
    {
        private static int _id = 0;

        public long Id { get; private set; }
        public string Name { get; set; }
        public uint Age { get; private set; }
        public Address Address { get; set; }

        public Customer(string name, uint age, Address address)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }

        public override string ToString()
        {
            return $"{Name} -- {Address.City} ({Address.State})";
        }
    }
}
