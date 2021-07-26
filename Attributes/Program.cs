using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Erdem", Age = 20 };
            CustomerDal customerdal = new CustomerDal();
            customerdal.Add(customer);

        }
    }
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }
    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}{1}{2}{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
}
