using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataClasses.Account
{
    public class RegisterData : CustomerData
    {
        internal string Password { get; set; }

        public RegisterData(string password, string name, string insertion, string lastName, string dayOfBirth, string email, int telephoneNumber, CustomerRoll customerRoll, int ibanNumber, string postalCode, string streetName, int adressNumber, string residence, string country)
        {
            Password = password;

            Firstname = name;
            Insertion = insertion;
            LastName = lastName;
            DayOfBirth = dayOfBirth;
            Email = email;
            TelephoneNumber = telephoneNumber;
            CustomerRoll = customerRoll;
            IbanNumber = ibanNumber;

            PostalCode = postalCode;
            StreetName = streetName;
            AdressNumber = adressNumber;
            Residence = residence;
            Country = country;
        }
    }
}
