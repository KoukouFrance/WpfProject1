
using System.ComponentModel;

namespace WpfAppTest1.Models
{
    internal class Customer : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private string v;

        public Customer(string name)
        {
            Name = name;
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
