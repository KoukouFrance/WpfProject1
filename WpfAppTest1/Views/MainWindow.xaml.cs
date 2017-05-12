using System.Windows;
using WpfAppTest1.ViewModels;

namespace WpfAppTest1.Views
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CustomerViewModel(); 
        }
    }
}
