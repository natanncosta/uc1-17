namespace ex2
{
    public class GetAllUseCase
    {
        private readonly CustomerRepository _repository;

        public GetAllUseCase(CustomerRepository repository)
            => this._repository = repository;

        public Customer[] Execute()
        {
            return _repository.GetAll().Clone() as Customer[];
        }
    }
}
