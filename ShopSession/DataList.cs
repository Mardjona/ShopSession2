using System;
using System.Collections.Generic;
using System.Text;
using ShopSession;

public static class DataLists
{
    public static List<Users> Users = new List<Users>
    {
        new Users()
        {
            login = "admin",
            password = "admin",
            username = "Администратор",
            role = "Admin"
        },
           
        new Users()
        {
            login = "user",
            password = "user",
            username = " Юзер ",
            role = "User"
        }
    };
    public static List<Products> Products = new List<Products>
    {
        new Products()
        {
            id = 0,
            name = "\tЛада",
            category = "А\tвто",
            manufacturer = "\"ООО Машинки\"",
            quantity = "12",
            measureUnit = "1 шт",
            price = "89",
            description = "Лада седан, made in Russia."
        },
        new Products()
        {
            id = 1,
            name = "Хлеб",
            category = "Хлебокомбинат",
            manufacturer = "\"OOO хлеб всему голова \"",
            quantity = "134",
            measureUnit = "1 шт.",
            price = "33",
            description = "Хлеб! покупайте хлеб "
        },
        new Products()
        {
            id = 2,
            name = "Маска",
            category = "Косметика",
            manufacturer = "\"ООО счастливое лицо\"",
            quantity = "176",
            measureUnit = "2 шт",
            price = "303",
            description = "Для отдыха."
        }
    };
    public static int? currentUserId;
    public static int? currentProductId;
}