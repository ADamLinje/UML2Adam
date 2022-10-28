using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Adam
{
    public class CustomerList
    {
        #region Instance Fields
        private List<Customer> _customers;
        #endregion

        #region Constructor
        public CustomerList()
        {
            _customers = new List<Customer>();
        }
        #endregion
        
        #region Properties
        public int Count
        { 
            get { return _customers.Count; } 
        }
        #endregion

        #region Methods
        public void AddCustomer(Customer customer1)
        {
            Customer foundCustomer = LookupCustomer(customer1.ID);
            if (foundCustomer == null)
                _customers.Add(customer1);
        }

        public void DeleteCustomer(string ID)
        {
           Customer item = LookupCustomer(ID);
            _customers.Remove(item);            

        }

        public void UpdateCustomer(string ID, Customer customerToUpdate)
        {
            
            int d = 0;
            while (d <_customers.Count)
            {
                if (_customers[d].ID == ID)
                {
                    _customers[d] = customerToUpdate;
                    break;
                }
                d++;
            }
        }

        public Customer LookupCustomer(string ID)
        {
            
            foreach (Customer item in _customers)
            {
                if (ID == item.Name)
                    return item;
            }
            return null;
        }

        public void PrintCustomer()
        {
            
            foreach (Customer item in _customers)
            {
                Console.WriteLine(item);
            }

        }
        #endregion
    }
}
