using System.Collections.Generic;
using System.Diagnostics;
using Dorp.Data.DataClasses;
using Dorp.Data.DataClasses.Account;
using Dorp.Data.DataClasses.Database;
using MySql.Data.MySqlClient;

namespace Dorp.Data.DataRepository.Account
{
    public class LoginController
    {
        //List with all tables where the system can check for a login match
        private static List<UserRollplayTables> Tables = UserRollPlayData.Tables();

        //Handeling the login [checking for match in one of the tables from the table list]
        public static LoginData Login(string Username, string Password)
        {
            //If there is a match found in one of the tables
            bool match = false;
            LoginData logindata = null;

            //Looping true all tables
            for (int i = 0; i < Tables.Count; i++)
            {
                //if there is no match found
                if (!match)
                {
                    //Create MySQLconnection 
                    MySqlConnection connection = DatabaseConfig.GetConnection();

                    //loop true all tables from table list
                    foreach(UserRollplayTables table in Tables)
                    {
                        //Where Components Builder is used to create automaticly a full Where sentence to use in a SqlCommand
                        List<WhereBuilderComponents> BuilderComponents = new List<WhereBuilderComponents>
                        {
                            //Add The given username and password values given when function is called.
                            //And add the with table Field that belongs to this variable.
                            new WhereBuilderComponents(Tables[i].UserFieldName, Username),
                            new WhereBuilderComponents(Tables[i].PassFieldName, Password)
                        };

                        //try to connect to database
                        try
                        {
                            //Build MySQLcommand
                            MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + table.Name + " WHERE " + (WHERE_builder(BuilderComponents)), connection);

                            //Create new connection
                            MySqlCommand id_cmd = connection.CreateCommand();

                            //Create CommandText 
                            id_cmd.CommandText =
                                "SELECT `" + table.IDFieldName +
                                "` FROM `" + table.Name +
                                "` WHERE `" + table.UserFieldName + "` = '" + Username +
                                "' AND `" + table.PassFieldName + "` = '" + Password + "'";

                            //Create a Data reader
                            MySqlDataReader reader = id_cmd.ExecuteReader();

                            //If there is a match found
                            if (reader.HasRows){

                                //Make Sure the loop won't continue to search in other tables
                                match = true;

                                //Passing LoginData
                                logindata = new LoginData(0,table.Rollplay, table.MatchOption);

                                //Close Reader
                                reader.Close();

                                //Return LoginData
                                return logindata;
                            }
                            //Close Reader
                            reader.Close();

                        }
                        finally
                        {

                        }
                    }
                }
                //If no match wass found in any table
                else
                {
                    //Debug tables where there was no match found
                    Debug.WriteLine(LoadedTables_ToString());

                    //Return empty loginData
                    return logindata;
                }
            }
            //Return empty loginData
            return logindata;
        }

        //Where Components Builder is used to create automaticly a full "Where" statement to use in a SqlCommand
        private static string WHERE_builder(List<WhereBuilderComponents> list)
        {
            //Create empty string to store the WHereString
            string Wherestring = "";

            //Foeach Component in the Given List
            for (int i = 0; i < list.Count; i++)
            {
                //Add fieldname
                Wherestring += "`" + list[i].Fieldname + "` = ";
                //Add Variable/value
                Wherestring += "`" + list[i].Variable + "`";

                //AND if this item is not the final item of the list
                if (i < list.Count)
                    //add one extra AND
                    Wherestring += " AND ";
            }

            //Return the complete WhereString
            return Wherestring;
        }

        //Get all tables that where added to the table list
        private static string LoadedTables_ToString()
        {
            //Create a string to store the values
            string sentence = string.Empty;

            //Foreach table in the table list
            for (int i = 0; i < Tables.Count; i++)
            {
                //Add Table name
                sentence += "- " + Tables[i].Name;

                //if this item is not the finel item in the list
                if (i < Tables.Count)
                    //indicate there is a new sentence coming
                    sentence += "\n";
            }

            //Return the complete Result
            return sentence;
        }
    }
    public class LoginData
    {
        public int ID;
        public UserRollplays rollplay;
        public LoginMatchOptions matchOption;

        public LoginData(int iD, UserRollplays rollplay, LoginMatchOptions matchOption)
        {
            ID = iD;
            this.rollplay = rollplay;
            this.matchOption = matchOption;
        }
    }
}

//try amount
//Local or extern Database?
//Security methdoe [Hashed. dm5] for checking in database
