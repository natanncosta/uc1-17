namespace ex2
{
    public class CustomerRepository
    {
        private static Customer[] customers = new Customer[0];

        public void Add(Customer customer)
        {
            Customer[] copy = new Customer[customers.Length + 1];
            for (int i = 0; i < customers.Length; i++)
                copy[i] = customers[i];
            copy[^1] = customer;
            customers = copy;
        }

        public Customer[] GetAll()
        {
            return customers.Clone() as Customer[];
        }
    }
}
