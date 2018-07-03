using Dorp.Data.DataRepository;
using Dorp.Data.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataClasses.Driver
{
    public class DriverData : UsersTableAditionalData
    {
        //Give the 
        internal string FirstName { get; set; }
        internal string Insertion { get; set; }
        internal string LastName { get; set; }
        internal string KindLicense { get; set; }
        internal string LicenseNationalitie { get; set; }
        internal int BusinessDays { get; set; }
    }
}
