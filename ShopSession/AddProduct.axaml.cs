using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using SkiaSharp;
using Avalonia.Media;
using Avalonia.Platform.Storage;
using System;
using System.Collections.Generic;
using System.IO;


namespace ShopSession;

public partial class AddProduct : Window
{
    public AddProduct()
    {
        InitializeComponent();
        
    }

    public void Add_Product(object? sender, RoutedEventArgs routedEventArgs)
    {
        Shop shop = new Shop();
        shop.Show();
        this.Close();
    }

    //public AddProduct(int id)
   // {
    //    InitializeComponent();
      
   // }
}