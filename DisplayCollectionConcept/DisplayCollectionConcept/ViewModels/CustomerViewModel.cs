using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DisplayCollectionConcept.Models;

namespace DisplayCollectionConcept.ViewModels
{
     
    public class CustomerViewModel:ViewModel
    {
        public ICollection<Customer> Customers { get; set; }

        public CustomerViewModel()
        {
            Customers = new ObservableCollection<Customer>();

            AddCustomer("Van", "Le", "Van.Le@pridetek.com");
            AddCustomer("Duc", "Le", "Duc.Le@pridetek.com");
            AddCustomer("Thien", "Le", "Thien.Le@pridetek.com");

        }
        private void AddCustomer(string firstName, string lastName, string email)
        {  
                var customer = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email
                };

                Customers.Add(customer);
            }
        }
}
