
using WpfAppTest1.Models;
using WpfAppTest1.Commands;
using System.Diagnostics;

namespace WpfAppTest1.ViewModels
{
    internal class CustomerViewModel
    {
        private Customer _customer;
        private CustomerUpdateCommand _customerUpdateCommand;

        public Customer Customer
        {
            get
            {
                return _customer;
            }

            set
            {
                _customer = value;
            }
        }

        public CustomerUpdateCommand CustomerUpdateCommand
        {
            get
            {
                return _customerUpdateCommand;
            }

            set
            {
                _customerUpdateCommand = value;
            }
        }

        internal void SaveName()
        {            
            Debug.Assert(false, string.Format("{0} is new name saved", Customer.Name));
        }

        internal bool CanBeUpdated()
        {
            bool result = true;
            if (Customer == null)
            {
                result = false;
            }
            else
            {
                result = !string.IsNullOrWhiteSpace(Customer.Name);
            }
            return result;
        }

        public CustomerViewModel()
        {
            Customer = new Customer("David");
            CustomerUpdateCommand = new CustomerUpdateCommand(this);
        }
    }
}
