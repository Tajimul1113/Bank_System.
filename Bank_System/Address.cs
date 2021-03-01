using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class Address
    { 
      private string roadNo;
    private string houseNo;
    private string city;
    private string country;
    public Address(string roadNo, string houseNo, string city, string country)
    {
        this.roadNo = roadNo;
        this.houseNo = houseNo;
        this.city = city;
        this.country = country;
    }
    public string getAddress()
    {
        return $"House No: {houseNo}, Road: {roadNo}, City: {city}\nCountry: {country}";
    }
}
}
