using Dorp.Data.DataClasses.Account;
using Dorp.Data.DataRepository;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace Dorp.Data.Services
{
    public class CustomerCRUD
    {
        //Insert a new Driver to the database
        public void Insert(CustomerData customerdata)
        {
            //Create Connection
            MySqlConnection con = DatabaseConfig.GetConnection();

            //try to connect to database
            try
            {
                //Build MySQLcommand
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `klanten`(" +
                    "`klant_id`, `voornaam`, `tussenvoegsel`, `achternaam`, ` geboortedatum`, `email`, ` telefoonNr`, ` postcode`, ` straatnaam`, ` huisNr`, ` plaats`, ` land`, `bedrijf_particulier`, ` iban_nr`, `wachtwoord`) " +
                    "VALUES (ID,FirstName,Insertion,LastName,DayOfBirth,Email,TelephoneNumber,PostalCode,StreetName,AdressNumber,Residence,Country,PrivateCompany,IBAN,Password))", con);

                //Create Parameters
                cmd.Parameters.AddWithValue("ID", customerdata.ID);
                cmd.Parameters.AddWithValue("FirstName", customerdata.Firstname);
                cmd.Parameters.AddWithValue("Insertion", customerdata.Insertion);
                cmd.Parameters.AddWithValue("LastName", customerdata.LastName);
                cmd.Parameters.AddWithValue("DayOfBirth", customerdata.DayOfBirth);
                cmd.Parameters.AddWithValue("Email", customerdata.Email);
                cmd.Parameters.AddWithValue("TelephoneNumber", customerdata.TelephoneNumber);
                cmd.Parameters.AddWithValue("PrivateCompany", customerdata.CustomerRoll);
                cmd.Parameters.AddWithValue("Password", customerdata.Password);
                cmd.Parameters.AddWithValue("IBAN", customerdata.IbanNumber);

                cmd.Parameters.AddWithValue("PostalCode", customerdata.PostalCode);
                cmd.Parameters.AddWithValue("StreetName", customerdata.StreetName);
                cmd.Parameters.AddWithValue("AdressNumber", customerdata.AdressNumber);
                cmd.Parameters.AddWithValue("Residence", customerdata.Residence);
                cmd.Parameters.AddWithValue("Country", customerdata.Country);


                //Execute and get Effectedrows
                int RowsEffected = cmd.ExecuteNonQuery();

                //Check if insertion wass succesfull
                if (RowsEffected == 0)
                    Debug.WriteLine("Insert was NOT Succesfull");
                else
                    Debug.WriteLine("Insert was Succesfull");

            }
            catch (Exception e)
            {
                //Write down the exception
                Debug.WriteLine(e);
            }
            finally
            {
                //Close Connection
                con.Clone();
            }
        }
        //Update Driver Data in database
        public void Update(CustomerData customerdata)
        {
            //Create Connection
            MySqlConnection con = DatabaseConfig.GetConnection();

            //try to connect to database
            try
            {
                //Build MySQLcommand
                MySqlCommand cmd = new MySqlCommand("UPDATE `klanten` SET " +
                    "`klant_id`=ID,`voornaam`=FirstName,`tussenvoegsel`=Insertion," +
                    "`achternaam`=LastName,` geboortedatum`=DayOfBirth,`email`=Email," +
                    "` telefoonNr`=TelephoneNumber,` postcode`=PostalCode,` straatnaam`=StreetName," +
                    "` huisNr`=AdressNumber,` plaats`=Residence,` land`=Country," +
                    "`bedrijf_particulier`=PrivateCompany,` iban_nr`=IBAN," +
                    "`wachtwoord`=[value-15] WHERE ID", con);

                //Create Parameters
                cmd.Parameters.AddWithValue("ID", customerdata.ID);
                cmd.Parameters.AddWithValue("FirstName", customerdata.Firstname);
                cmd.Parameters.AddWithValue("Insertion", customerdata.Insertion);
                cmd.Parameters.AddWithValue("LastName", customerdata.LastName);
                cmd.Parameters.AddWithValue("DayOfBirth", customerdata.DayOfBirth);
                cmd.Parameters.AddWithValue("Email", customerdata.Email);
                cmd.Parameters.AddWithValue("TelephoneNumber", customerdata.TelephoneNumber);
                cmd.Parameters.AddWithValue("PrivateCompany", customerdata.CustomerRoll);
                cmd.Parameters.AddWithValue("Password", customerdata.Password);
                cmd.Parameters.AddWithValue("IBAN", customerdata.IbanNumber);

                cmd.Parameters.AddWithValue("PostalCode", customerdata.PostalCode);
                cmd.Parameters.AddWithValue("StreetName", customerdata.StreetName);
                cmd.Parameters.AddWithValue("AdressNumber", customerdata.AdressNumber);
                cmd.Parameters.AddWithValue("Residence", customerdata.Residence);
                cmd.Parameters.AddWithValue("Country", customerdata.Country);

                //Execute and get Effectedrows
                int RowsEffected = cmd.ExecuteNonQuery();

                //Check if insertion wass succesfull
                if (RowsEffected == 0)
                    Debug.WriteLine("Update was NOT Succesfull");
                else
                    Debug.WriteLine("Uodate was Succesfull");

            }
            catch (Exception e)
            {
                //Write down the exception
                Debug.WriteLine(e);
            }
            finally
            {
                //Close Connection
                con.Clone();
            }
        }

        //Delete a Driver from the database
        public void Delete(CustomerData customerdata)
        {
            //Create Connection
            MySqlConnection con = DatabaseConfig.GetConnection();

            //try to connect to database
            try
            {
                //Build MySQLcommand
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `klanten` WHERE ID", con);

                //Cretae Parameters
                cmd.Parameters.AddWithValue("ID", customerdata.ID);

                //Execute and get Effectedrows
                int RowsEffected = cmd.ExecuteNonQuery();

                //Check if insertion wass succesfull
                if (RowsEffected == 0)
                    Debug.WriteLine("Delete was NOT Succesfull");
                else
                    Debug.WriteLine("Delete was Succesfull");

            }
            catch (Exception e)
            {
                //Write down the exception
                Debug.WriteLine(e);
            }
            finally
            {
                //Close Connection
                con.Clone();
            }
        }
        public void Delete(int ID)
        {
            //Create Connection
            MySqlConnection con = DatabaseConfig.GetConnection();

            //try to connect to database
            try
            {
                //Build MySQLcommand
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `klanten` WHERE ID", con);

                //Cretae Parameters
                cmd.Parameters.AddWithValue("ID", ID);

                //Execute and get Effectedrows
                int RowsEffected = cmd.ExecuteNonQuery();

                //Check if insertion wass succesfull
                if (RowsEffected == 0)
                    Debug.WriteLine("Delete was NOT Succesfull");
                else
                    Debug.WriteLine("Delete was Succesfull");

            }
            catch (Exception e)
            {
                //Write down the exception
                Debug.WriteLine(e);
            }
            finally
            {
                //Close Connection
                con.Clone();
            }
        }
    }
}
