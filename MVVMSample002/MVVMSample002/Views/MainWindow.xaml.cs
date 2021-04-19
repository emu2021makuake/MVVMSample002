using MVVMSample002.ViewModels;
using System.Windows;

namespace MVVMSample002.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
