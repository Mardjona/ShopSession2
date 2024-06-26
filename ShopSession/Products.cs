using System.Drawing;

namespace ShopSession;

public class Products
{
    public int id { get; set; }
    public string name { get; set;  }
    public string category { get; set; }
    public string unit { get; set; }
    public string provaider { get; set; }
    public string count { get; set; }
    public double price { get; set; }
    public string description { get; set; }
    public string namefile { get; set; }
    public Bitmap painting { get; set; }
}