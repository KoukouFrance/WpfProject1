
using System.ComponentModel;

namespace WpfAppTest1.Models
{
    internal class Customer : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

      
  

        private double _salary;
        private string _firstLastName;

        private string v;

        public Customer(string name)
        {
            Name = name;
        }

        public double Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                _salary = value;
            }
        }
        public string Name
        {
            get { return _firstLastName; }
            set
            {
                _firstLastName = value;


                if (_firstLastName != value)
                {
                    _firstLastName = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(_firstLastName));
                }
            }
        }

    }
}
