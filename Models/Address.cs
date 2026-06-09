using System;

namespace dotnet_test.Models;

public class Address
{

    public Address()
    {
        CreateDate = DateTime.Now;
    
    }
    public  const string Country = "Australia";
    public readonly DateTime CreateDate;
    public string Street {get; set;}
    public string City {get; set;}

}
