using Dorp.Data.DataClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataClasses.Account
{
    class UserRollPlayData
    {
        internal static List<UserRollplayTables> Tables()
        {
            List<UserRollplayTables> Tables = new List<UserRollplayTables>
            {
                //Add all tables to the list where the system can check if there wass a account there
                new UserRollplayTables("klanten", "klant_id", "email", "wachtwoord", UserRollplays.Customer, LoginMatchOptions.OpenWindow),
                new UserRollplayTables("chauffeurs", "chauffeurs_id", "inlognaam", "wachtwoord", UserRollplays.Chauffeurs, LoginMatchOptions.OpenWindow),
                new UserRollplayTables("planners", "planners_id", "inlognaam", "wachtwoord", UserRollplays.Planner, LoginMatchOptions.OpenWindow),
                new UserRollplayTables("managers", "managers_id", "inlognaam", "wachtwoord", UserRollplays.Manager, LoginMatchOptions.OpenWindow)
            };
            return Tables;
        }
    }
}
