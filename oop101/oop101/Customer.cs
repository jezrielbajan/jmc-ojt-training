using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop101
{
    class Customer : VIPCustomer
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string EmailAddress { get; set; }

        //Method
        public void SaveCustomer()
        {
            // todo
            // Connect TO DB
            // Collect The Data.. 

        }

        public void RemoveCustomer()
        {

        }

        public void SendCustomerAnEmail()
        {

        }
    }
}
