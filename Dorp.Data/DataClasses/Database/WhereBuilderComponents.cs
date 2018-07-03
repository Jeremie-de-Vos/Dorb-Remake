using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataClasses.Database
{
    class WhereBuilderComponents
    {
        internal string Fieldname;
        internal string Variable;

        public WhereBuilderComponents(string fieldname, string variable)
        {
            Fieldname = fieldname;
            Variable = variable;
        }
    }
}
