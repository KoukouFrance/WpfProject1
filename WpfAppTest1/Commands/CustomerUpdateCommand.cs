using System;
using System.Windows.Input;
using WpfAppTest1.ViewModels;
using System.Collections.Generic;

namespace WpfAppTest1.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {
        private List<double> metrics;
        private CustomerViewModel _customerViewModel;

        public List<double> Metrics  { get; set; }

        public CustomerUpdateCommand(CustomerViewModel customerViewModel)
        {
            this._customerViewModel = customerViewModel; 
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            bool result = _customerViewModel.CanBeUpdated();
            return result;
        }

        public void Execute(object parameter)
        {
            _customerViewModel.SaveName();
        }
    }
}
