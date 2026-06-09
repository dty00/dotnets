using System;
using System.Reflection.Metadata.Ecma335;
using dotnet_test.Interfaces;

namespace dotnet_test.Models;

public class User : IEntity 
{

    // Constructor 构造函数--是一个方法，为了创造一些东西，是类的成员，类里面的小函数
    //没有返回值的函数
    //名字必须是类的名字
    //定义对象在创建的初始化的内容
    public User(string userName)
    {
        UserName = userName;
    }

    public int Id {get; set;}
    public int GetId()
    {
        return Id;
    }

    public string UserName {get; private set;}
    public int UserAge {get; private set;}



    public Address Address{get; set;}
    public void DisplayUserInfo()
    {
        string UserInfo = $"User Name is {UserName}, and User age is {UserAge}.";
        Console.WriteLine(UserInfo);
    }

    public void SetUserInfo(string name, int age)
    {
        UserName = name;
        UserAge = age;
    }

}
