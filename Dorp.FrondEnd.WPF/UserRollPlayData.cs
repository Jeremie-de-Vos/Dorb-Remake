using Dorp.Data.DataClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.FrondEnd.WPF
{
    public class UserRollPlayData
    {
        internal static List<UserRollplayTables> Tables()
        {
            List<UserRollplayTables> Tables = new List<UserRollplayTables>
            {
                //Add all tables to the list where the system can check if there wass a account there
                new UserRollplayTables("klanten", "klant_id", "email", "wachtwoord", UserRollplays.Customer, LoginMatchOptions.Nothing),
                new UserRollplayTables("chauffeurs", "chauffeurs_id", "inlognaam", "wachtwoord", UserRollplays.Chauffeurs, LoginMatchOptions.Nothing),
                new UserRollplayTables("planners", "planners_id", "inlognaam", "wachtwoord", UserRollplays.Planner, LoginMatchOptions.Nothing),
                new UserRollplayTables("managers", "managers_id", "inlognaam", "wachtwoord", UserRollplays.Manager, LoginMatchOptions.Nothing)
            };
            return Tables;
        }

        internal static void Execution(UserRollplays rollplay, LoginMatchOptions matchOption, int ID)
        {
            switch (rollplay)
            {
                case UserRollplays.Chauffeurs:
                    switch (matchOption)
                    {
                        case LoginMatchOptions.OpenForm:
                            //Implement Code
                            break;
                        case LoginMatchOptions.OpenWindow:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowConsole:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowMessageBox:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowVSDebugger:
                            Debug.WriteLine("There is a match found with ID: ",ID);
                            break;
                    }
                    break;
                case UserRollplays.Customer:
                    switch (matchOption)
                    {
                        case LoginMatchOptions.OpenForm:
                            //Implement Code
                            break;
                        case LoginMatchOptions.OpenWindow:
                            Windows.Customer.MainWindow window = new Windows.Customer.MainWindow();
                            window.Show();
                            break;
                        case LoginMatchOptions.ShowConsole:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowMessageBox:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowVSDebugger:
                            Debug.WriteLine("There is a match found with ID: ", ID);
                            break;
                    }
                    break;
                case UserRollplays.Manager:
                    switch (matchOption)
                    {
                        case LoginMatchOptions.OpenForm:
                            //Implement Code
                            break;
                        case LoginMatchOptions.OpenWindow:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowConsole:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowMessageBox:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowVSDebugger:
                            Debug.WriteLine("There is a match found with ID: ", ID);
                            break;
                    }
                    break;
                case UserRollplays.Planner:
                    switch (matchOption)
                    {
                        case LoginMatchOptions.OpenForm:
                            //Implement Code
                            break;
                        case LoginMatchOptions.OpenWindow:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowConsole:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowMessageBox:
                            //Implement Code
                            break;
                        case LoginMatchOptions.ShowVSDebugger:
                            Debug.WriteLine("There is a match found with ID: ", ID);
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
