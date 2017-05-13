
using System.ComponentModel;

namespace WpfAppTest1.Models
{
    internal class Customer : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private double _salary;
        private string _name;
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
            get { return _name; }
            set
            {
                _name = value;


                if (_name != value)
                {
                    _name = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(_name));
                }
            }
        }

    }
}
