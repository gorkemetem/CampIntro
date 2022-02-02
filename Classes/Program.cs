namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Adana";
            customer.Id = 1;
            customer.FirstName = "Etem";
            customer.LastName = "Irmak";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Görkem",
                LastName = "Irmak",
                City = "Adana"
            };

            System.Console.WriteLine(customer2.FirstName);
        }
    }
}
