namespace ex2
{
    public class CreateCustomerUseCase
    {
        private readonly CustomerRepository _repository;

        public CreateCustomerUseCase(CustomerRepository repository)
            => this._repository = repository;

        public void Execute(Customer customer) => _repository.Add(customer);
    }
}
