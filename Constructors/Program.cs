using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1,"Etem","Irmak","Adana");
            Customer customer2 = new Customer { Id=2, FirstName="Görkem", LastName="Irmak", City="Adana" };
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
