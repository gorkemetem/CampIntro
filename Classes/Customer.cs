using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }

        private string _firstname;
        public string FirstName {
            get { return "Mr." + _firstname; }
            set { _firstname = value; } 
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
