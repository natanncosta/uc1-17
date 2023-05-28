namespace ex2
{
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Address
            (string street,
             string number,
             string neighborhood,
             string city,
             string state)
        {
            this.Street = street;
            this.Number = number;
            this.Neighborhood = neighborhood;
            this.City = city;
            this.State = state;
        }
    }
}
