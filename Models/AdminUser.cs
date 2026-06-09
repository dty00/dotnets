using System;

namespace dotnet_test.Models;

public class AdminUser : User
{
    public AdminUser(int id):base(id)
    {
        
    }
    public void DeleteAddress()
    {
        Address = null;
    }

    public override void DisplayUserInfo()
    {
        string UserInfo = $"Admin User - Name is {UserName}, and User age is {UserAge}.";
        Console.WriteLine(UserInfo);
    }

    public override void TestUserTolarance()
    {
        throw new NotImplementedException();
    }
}
