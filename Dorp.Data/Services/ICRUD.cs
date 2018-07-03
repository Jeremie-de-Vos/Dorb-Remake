using Dorp.Data.DataClasses.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.Services
{
    interface ICRUD
    {
        void Insert();
        void Update();
        void Delete();
    }
}