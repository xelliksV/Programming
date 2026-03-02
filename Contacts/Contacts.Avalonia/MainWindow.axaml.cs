using Avalonia.Controls;
using Contacts.viewModel;

namespace Contacts.Avalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainVM();
    }
}