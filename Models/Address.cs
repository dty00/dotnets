using System;
using System.Diagnostics.Tracing;

namespace dotnet_test.Models;

public class Address
{

    public Address()
    {
        CreateDate = DateTime.Now;
    
    }
    public  const string Country = "Australia";
    public readonly DateTime CreateDate;
    public string Street {get; private set;}
    public string City {get; set;}

    public void ChangeAddress(string street)
    {
        if(string.IsNullOrEmpty(street))
            {
            throw new Exception("Address can not be null");  
            }
        Street = street;
    }


}
