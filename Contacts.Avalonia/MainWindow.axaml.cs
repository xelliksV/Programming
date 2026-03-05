using Avalonia.Controls;
using Avalonia.Interactivity;
using Contacts.viewModel;

namespace Contacts.Avalonia
{
    public partial class MainWindow : Window
    {
        private MainVM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainVM();
            DataContext = vm;
        }
    }
}
