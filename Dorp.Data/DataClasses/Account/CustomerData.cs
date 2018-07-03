using Dorp.Data.DataClasses.Driver;
using Dorp.Data.DataClasses.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataClasses.Account
{
    public class CustomerData : LocationData
    {
        internal string Firstname { get; set; }
        internal string Insertion { get; set; }
        internal string LastName { get; set; }
        internal string DayOfBirth { get; set; }
        internal string Email { get; set; }
        internal int TelephoneNumber { get; set; }
        internal CustomerRoll CustomerRoll { get; set; }
        internal int IbanNumber { get; set; }
    }
}
