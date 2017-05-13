using System;
using System.Windows.Input;
using WpfAppTest1.ViewModels;


namespace WpfAppTest1.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {
        private double metrics;
        private CustomerViewModel _customerViewModel;

        public double Metrics  { get; set; }

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
