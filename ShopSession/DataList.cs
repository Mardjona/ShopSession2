using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSession;

public static class DataList
{
    public static List<Users> Users = new List<Users>
    {
        new Users()
        {
            password = "user",
            username = "Покупатель",
            role = "User"

        },
        new Users()
        {
            password = "admin",
            username = "Администратор",
            role = "Admin"
        }
    };

    public static List<Products> Products = new List<Products>
    {
        new Products()
        {
            id = 1,
            name = "Машина",
            category = "Lada",
            provaider = "ООП",
            count = "45",
            unit = "1",
            price = 870,
            description = "Лада седан для вашего комфорта"







        },
    };

}