using System;
using dotnet_test.Enums;
using dotnet_test.Interfaces;
namespace dotnet_test.Models;



// access modifiers 访问修饰符，控制参数，类，方法访问权限

// public --> 允许外部访问
//private --> 只允许内部访问


public class PaintProduct :IEntity
{
    //参数要大写
    //name, price,type

    public PaintProduct(decimal price, string name, PaintType paintType)
    {
        Price = price;
        Name = name;
        PaintType = paintType;
    }


    public int Id {get; set;}

    public int GetId()
    {
        return Id;
    }
    
    public string Name { get; private set; }


    //properties, C# agvantage
    //OOP --->>> Encapsulation 封装
    public decimal Price { get; private set; } 


    public PaintType PaintType;
    



    //方法
    public void PrintPaintInfo()
    {
        string descriptionImproved = $"Name:{Name}, Price:{Price},Type.:{PaintType}";
        Console.WriteLine(descriptionImproved);
    }

    public void SetPrice(decimal price)
    {
        Price = price;
    }
}
