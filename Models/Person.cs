using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myTestApp.Models
{
    public class Person
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public PeronalPhones Phones { get; set; }

        public Person()
        {
            name = "Jeffrey Charles Bryant";
            address = "6229 SW Erickson Avenue";
            city = "Beaverton";
            state = "Oregon";
            Phones = new PeronalPhones(){Home="503-430-5984",Cell="971-645-6207"};
        }
    }

    public class PeronalPhones
    {
        public string Home { get; set; }
        public string Cell { get; set; }
    }
}

