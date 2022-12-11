using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeriDonusummApp.Models
{
    public class Repository
    {
        private static List<Customer> customers = new List<Customer>();
        public static List<Customer> Customers
        {
            get
            {
                return customers;
            }
        }
        public static void AddCustomer(Customer customer) 
        {
            customers.Add(customer);
        }
    }
}
