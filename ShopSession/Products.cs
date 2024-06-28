using System.Drawing;

namespace ShopSession;

public class Products
{
    public int id { get; set; }
    public int IDProduct { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public string quantity { get; set; }
    public string measureUnit { get; set; }
    public string manufacturer { get; set; }
    public string price { get; set; }
    public string description { get; set; }
    public string fileName { get; set; }

    public Bitmap productImage
    {
        get { return new Bitmap(fileName); }
        set { }
    }
}