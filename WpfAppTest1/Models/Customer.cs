
using System.ComponentModel;

namespace WpfAppTest1.Models
{
    internal class Customer : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private string _firstLastName;
        private string v;

        public Customer(string name)
        {
            Name = name;
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
