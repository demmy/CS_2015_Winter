using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1adress
{
    class Adress
    {
        int index;
        string country;
        string city;
        string street;
        int house;
        int apartment;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }


        public string Street
        {
            get { return street; }
            set { street = value; }
        }


        public int House
        {
            get { return house; }
            set { house = value; }
        }

        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public void RecordInfo(int index, string country, string city, string street, int house, int apartment)
        {

            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Index: {0}\nCountry: {1}\nCity: {2}\nStreet: {3}\nHouse: {4}\nApartment: {5}",
                              Index, Country, City, Street, House, Apartment);
            Console.ReadLine();
        }

    }
}
