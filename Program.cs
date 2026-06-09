// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using dotnet_test.Models;
using dotnet_test.Enums;
string[] names = { "Alice", "Bob", "Charlie" };

foreach (var item in names)
{
    System.Console.WriteLine(item);
}



PaintType paintType = PaintType.HighSheen;


switch (paintType)
{
    case PaintType.Basic:
    System.Console.WriteLine("PaintType is basic");
    break;

    case PaintType.LowSheen:
    System.Console.WriteLine("PaintType is LowSheen");
    break;

    case PaintType.HighSheen:
    System.Console.WriteLine("PaintType is highSheen");
    break;

    default:
    System.Console.WriteLine("PaintType is N/A");
    break;
}

// 新对象 创建一个实体
// new PaintProduct() 是一个完整的实体/实例/对象

// 创建对象
PaintProduct paintProduct = new PaintProduct(19.99m,"Bob",paintType);
//给对象内的变量赋值
//读取对象
paintProduct.PrintPaintInfo();



User user = new User("Bob");
user.SetUserInfo("Bob",18);
user.DisplayUserInfo();
