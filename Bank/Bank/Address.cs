using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Address
    {
        private string roadNo;
        private string houseNo;
        private string city;
        private string country;
        public Address()
        {

        }
        public Address(string roadNo,string houseNo,string city,string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }
        public string RoadNo { get => roadNo; set => roadNo = value; }
        public string HouseNo { get => houseNo; set => houseNo = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }

        public void getAddress()
        {
            Console.WriteLine("Road no:"+this.RoadNo);
            Console.WriteLine("House No:"+this.HouseNo);
            Console.WriteLine("City:"+this.City);
            Console.WriteLine("Country:"+this.Country);
          
        }
    }
}
