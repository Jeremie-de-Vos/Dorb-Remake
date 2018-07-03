using Dorp.Data.DataClasses.Account;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataRepository.Account
{
    public class RegisterController
    {
        //Register a new customer account
        public static void RegisterNewCustomer(RegisterData data)
        {
            //Create MySQLconnection 
            MySqlConnection connection = DatabaseConfig.GetConnection();

            //try to connect to database
            try
            {
                //Build MySQLcommand
                MySqlCommand cmd = new MySqlCommand("" +
                        "INSERT INTO `klanten`(`voornaam`, `tussenvoegsel`, `achternaam`, ` geboortedatum`, `email`, ` telefoonNr`, ` postcode`, ` straatnaam`, ` huisNr`, ` plaats`, ` land`, `bedrijf_particulier`, ` iban_nr`, `wachtwoord`) " +
                                      "VALUES (@voornaam, @tussenvoegsel, @achternaam, @geboortedatum, @email, @telefoonNr, @postcode, @straatnaam, @huisNr, @plaats, @land, @bedrijf_particulier, @iban_nr, @wachtwoord)", connection);

                //Create parameters
                cmd.Parameters.AddWithValue("@klant_id", "");
                cmd.Parameters.AddWithValue("@voornaam", data.Firstname);
                cmd.Parameters.AddWithValue("@tussenvoegsel", data.Insertion);
                cmd.Parameters.AddWithValue("@achternaam", data.LastName);
                cmd.Parameters.AddWithValue("@geboortedatum", data.DayOfBirth);
                cmd.Parameters.AddWithValue("@email", data.Email);

                cmd.Parameters.AddWithValue("@telefoonNr", data.TelephoneNumber);
                cmd.Parameters.AddWithValue("@postcode", data.PostalCode);
                cmd.Parameters.AddWithValue("@straatnaam", data.StreetName);
                cmd.Parameters.AddWithValue("@huisNr", data.AdressNumber);

                cmd.Parameters.AddWithValue("@plaats", data.Residence);
                cmd.Parameters.AddWithValue("@land", data.Country);
                cmd.Parameters.AddWithValue("@bedrijf_particulier", data.CustomerRoll);
                cmd.Parameters.AddWithValue("@iban_nr", data.IbanNumber);
                cmd.Parameters.AddWithValue("@wachtwoord", data.Password);

                //Get count of all record that are affected and execute Query
                int recordsAffected = cmd.ExecuteNonQuery();

                //Check if the insertion was succesfull
                if (recordsAffected == 0)
                    SuccesFull();
                else
                    Failed();
            }
            //Catch any SQLException and show them in the compiler
            catch (SqlException e)
            {
                Debug.WriteLine("Data not inserted !" + e);
            }
        }

        //If the registration was succesfull
        private static void SuccesFull()
        {
            Debug.WriteLine("Data not inserted !");
        }
        //If the registration Failed
        private static void Failed()
        {
            Debug.WriteLine("Data succesfully inserted !");
        }
    }
}
