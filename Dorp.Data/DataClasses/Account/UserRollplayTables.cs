using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataClasses
{
    public class UserRollplayTables
    {
        public string Name;
        public string IDFieldName;
        public string PassFieldName;
        public string UserFieldName;
        public UserRollplays Rollplay = UserRollplays.None;
        public LoginMatchOptions MatchOption = LoginMatchOptions.Nothing;

        public UserRollplayTables(string name, string iDFieldName, string passFieldName, string userFieldName, UserRollplays rollplay, LoginMatchOptions matchOption)
        {
            Name = name;
            IDFieldName = iDFieldName;
            PassFieldName = passFieldName;
            UserFieldName = userFieldName;
            Rollplay = rollplay;
            MatchOption = matchOption;
        }
    }
}
