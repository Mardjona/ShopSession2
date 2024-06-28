using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ShopSession;

public partial class MainWindow : Window
{
    
        public MainWindow()
        {
            InitializeComponent();
        }
        public void LogIn(object sender, RoutedEventArgs args)
        {
            foreach (Users user in DataLists.Users)
            {
                if (user.login == Login.Text && user.password == Password.Text)
                {
                    DataLists.currentUserId = DataLists.Users.IndexOf(user);
                    GoToShop();
                }
                else
                {
                    ErrorLogIn.IsVisible = true;
                }
            }
        }

        public void GoToShop()
        {
            Shop shop = new Shop(DataLists.currentUserId);
            shop.Show();
            Close();
        }
        public void GusetLogIn(object sender, RoutedEventArgs args)
        {
            Shop shop = new Shop();
            shop.Show();
            Close();
        }
    }
