using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ShopSession;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        SigninButton.Click += Signin_Click;
    }
    private void Signin_Click(object? sender, RoutedEventArgs e)
    {
       
       AddProduct addWindow = new AddProduct();
        addWindow.Show();
        Close();
    }
}