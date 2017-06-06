using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

	class Program
	{
		static void Main( string[] args )
		{
            Address address = new Address();
            address.Index="d4r3r";
            address.Country="ukraine";
            address.City="kiev";
            address.Street="cadw";

            Console.WriteLine(address.Index);
		}
	}

    class Address 
    {
        string index;
        string country;
        string city;
        string street;
        string house;
        string appartment;

        public string Index{
            get{ return index;}
            set{ index = value;}
        }

        public string Country{
            get{ return country;}
            set{ country = value;}
        }

        public string City{
            get{return city;}
            set{city = value;}
        }

        public string Street{
            get{return street;}
            set{street = value;}
        }

        public string House{
            get{return house;}
            set{house = value;}
        }

        public string Appartment{
            get{return appartment;}
            set{appartment = value;}
        }
        }
            

    }

}
}
