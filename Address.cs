using ExceptionLibrary;
using System;

namespace HW_21_03_23_properties
{
    public class Address
    {
        private string city;
        private string street;
        private string homeNumber;

        public Address(string city, string street, string homeNumber)
        {
            setCity(city);
            setStreet(street);
            setHomeNumber(homeNumber);
        }

        // setters
        public void setCity(string city)
        {
            if (String.IsNullOrEmpty(city) || String.IsNullOrWhiteSpace(city)) throw new StringException();
            this.city = city;
        }
        public void setStreet(string street)
        {
            if (String.IsNullOrEmpty(street) || String.IsNullOrWhiteSpace(street)) throw new StringException();
            this.street = street;
        }
        public void setHomeNumber(string homeNumber)
        {
            if (String.IsNullOrEmpty(homeNumber) || String.IsNullOrWhiteSpace(homeNumber)) throw new StringException();
            this.homeNumber = homeNumber;
        }

        // getters
        public string getCity() { return this.city; }
        public string getStreet() { return this.street; }
        public string getHomeNumber() { return this.homeNumber; }

        public override string ToString()
        {
            return ($"{getCity()}, {getStreet()} {getHomeNumber()}");
        }
    }
}
