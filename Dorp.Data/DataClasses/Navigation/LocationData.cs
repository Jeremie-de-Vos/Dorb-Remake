using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataClasses.Navigation
{
    public class LocationData
    {
        internal string PostalCode { get; set; }
        internal string StreetName { get; set; }
        internal int AdressNumber { get; set; }
        internal string Residence { get; set; }
        internal string Country { get; set; }
    }
}
