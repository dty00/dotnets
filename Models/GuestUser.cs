using System;

namespace dotnet_test.Models;

public class GuestUser : User
{
    public GuestUser(int id) : base(id)
    {
        
    }

    public override void DisplayUserInfo()
    {
        string UserInfo = $"Guest User Name is {UserName}, and User age is {UserAge}.";
        Console.WriteLine(UserInfo);
    }

    public override void TestUserTolarance()
    {
        throw new NotImplementedException();
    }
}
