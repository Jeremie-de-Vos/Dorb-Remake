using Dorp.Data.DataClasses.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataClasses.Customer
{
    public class CustomerData : LocationData
    {
        internal int ID { get; set; }
        internal string FirstName { get; set; }
        internal string Insertion { get; set; }
        internal string Lastname { get; set; }
        internal DateTime DayofBirth { get; set; }
        internal string Email { get; set; }
        internal int TelphoneNumber { get; set; }
        internal bool PrivateCompany { get; set; }
        internal string Password { get; set; }
    }
}
