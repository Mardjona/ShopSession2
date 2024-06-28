using System;
using System.Drawing;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ShopSession;

public partial class Shop : Window

{
    public Shop()
    {

        InitializeComponent();
        UserName.Text = "";
        foreach (Products product in DataLists.Products)
        {
            if (product.fileName == null)
            {
                product.fileName = AppDomain.CurrentDomain.BaseDirectory + "/assets/no_picture.png";
                product.productImage = new Bitmap(product.fileName);
            }
        }

        ShoppingCart.ItemsSource = DataLists.Products.ToList();
        // ItemQuantity.Text = $"{ShoppingCart.ItemCount} �� {DataLists.Products.Count}";
        AddButton.IsVisible = false;
    }

    public Shop(int? id)
    {
        InitializeComponent();
        UserName.Text = DataLists.Users[Convert.ToInt32(id)].username;
        foreach (Products product in DataLists.Products)
        {
            if (product.fileName == null)
            {
                product.fileName = AppDomain.CurrentDomain.BaseDirectory + "/assets/no_picture.png";
                product.productImage = new Bitmap(product.fileName);
            }
        }

        ShoppingCart.ItemsSource = DataLists.Products.ToList();
        // ItemQuantity.Text = $"{ShoppingCart.ItemCount} �� {DataLists.Products.Count}";
        if (DataLists.Users[Convert.ToInt32(id)].role != "Admin")
        {
            AddButton.IsVisible = false;
        }
    }

    public void Exit(object sender, RoutedEventArgs args) // выход
    {
        DataLists.currentUserId = null;
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }

    public void ProductAdd(object sender, RoutedEventArgs args) // добавление нового товара
    {
        AddProduct adding = new AddProduct();
        adding.Show();
        Close();
    }

    public void Edit(object? sender, PointerReleasedEventArgs e) //редактирование
    {
        int id = Convert.ToInt32(DataLists.currentUserId);
        if (DataLists.Users[id].role == "Admin" && DataLists.currentUserId != null)
        {
            DataLists.currentProductId = ShoppingCart.SelectedIndex;
            AddProduct editWindow = new AddProduct(Convert.ToInt32(DataLists.currentProductId));
            editWindow.Show();
            Close();
        }
    }

    public void Basket(object? sender, RoutedEventArgs routedEventArgs) // корзина
    {
        int id = Convert.ToInt32(DataLists.currentUserId);
        if (DataLists.Users[id].role == "User" && DataLists.currentUserId != null)
        {
           
           // Busket busket = new Busket();
           // busket.Show();
            Close();
        }
    }

    public void Delite(object? sender, RoutedEventArgs args) // удаление
    {
       
            {
                int id = (int)(sender as Button).Tag;
                foreach (Products product in DataLists.Products)
                {
                    if (id == product.IDProduct)
                    {
                        DataLists.Products.RemoveAt(product.IDProduct);
                        break;
                    }
                }
                foreach (Products product in DataLists.Products)
                {
                    product.IDProduct = DataLists.Products.IndexOf(product);
                }
                ShoppingCart.ItemsSource = DataLists.Products.ToList();
                
            }



    }

    public void AddBusket(object? sender, RoutedEventArgs args) // добавление в корзину
    {
       
           // new Busket().Show();
            Close();
    }
}