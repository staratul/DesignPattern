using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.RepositoryPattern
{
    public class CustomerRepository : IRepository<Customer>
    {
        private List<Customer> _customers = new List<Customer>();
        public void Add(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine($"Customer {customer.Name} added.");
        }

        public void Delete(int id)
        {
            var customer = GetById(id); 
            if(customer != null) 
            {
                _customers.Remove(customer);
                Console.WriteLine($"Customer {customer.Name} deleted");
            } else
            {
                Console.WriteLine($"Customer {id} deleted");
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customers;
        }

        public Customer GetById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Customer customer)
        {
            var existingCustomer = GetById(customer.Id);
            if(existingCustomer != null)
            {
                existingCustomer.Name = customer.Name;
                existingCustomer.Email = customer.Email;
                Console.WriteLine($"Customer {customer.Id} updated");
            } else
            {
                Console.WriteLine($"Customer {customer.Id} Not found");
            }
        }
    }
}
