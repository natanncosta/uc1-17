using System;

namespace ex2
{
    class Program
    {
        static CustomerRepository repository = new();
        static CreateCustomerUseCase createCustomer = new(repository);
        static GetAllUseCase getAllUseCase = new(repository);

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("1- Cadastrar Cliente");
            Console.WriteLine("2- Listar Clientes");
            Console.WriteLine("3- sair");
            Console.Write("=> ");
            CallMethod(Console.ReadLine());
        }

        static void CallMethod(string option)
        {
            switch (option)
            {
                case "1":
                    Add(); break;
                case "2":
                    GetAll(); break;
                case "3":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Opcao inválida.");
                    Back(); break;
            }
        }

        static void Add()
        {
            Console.Clear();

            Console.Write("Digite o nome do cliente: ");
            string name = Console.ReadLine();
            Console.Write("Digite a idade do cliente: ");
            uint age = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Digite o nome da rua: ");
            string street = Console.ReadLine();
            Console.Write("Digite o número do seu endereco: ");
            string number = Console.ReadLine();
            Console.Write("Digite o nome do bairro: ");
            string neighborhood = Console.ReadLine();
            Console.Write("Digite o nome da cidade: ");
            string city = Console.ReadLine();
            Console.Write("Digite o nome do estado: ");
            string state = Console.ReadLine();

            Address address = new(street, number, neighborhood, city, state);
            Customer customer = new(name, age, address);

            createCustomer.Execute(customer);
            Back();
        }

        static void GetAll()
        {
            Console.Clear();

            Customer[] customers = getAllUseCase.Execute();
            for (int i = 0; i < customers.Length; i++)
                Console.WriteLine(customers[i].ToString());
            Back();
        }

        static void Back()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione um tecla para continuar...");
            Console.ReadKey();
            Menu();
        }
    }
}
