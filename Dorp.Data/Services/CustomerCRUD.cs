using Dorp.Data.DataClasses.Account;
using Dorp.Data.DataClasses.Driver;
using Dorp.Data.DataRepository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.Services
{
    public class CustomerCRUD
    {
        //Insert a new Driver to the database
        public void Insert(CustomerData CustomerData)
        {
            //Create Connection
            MySqlConnection con = DatabaseConfig.GetConnection();

            //try to connect to database
            try
            {
                //Build MySQLcommand
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `klanten`(`klant_id`, `voornaam`, `tussenvoegsel`, `achternaam`, ` geboortedatum`, `email`, ` telefoonNr`, ` postcode`, ` straatnaam`, ` huisNr`, ` plaats`, ` land`, `bedrijf_particulier`, ` iban_nr`, `wachtwoord`) " +
                    "VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6],[value-7],[value-8],[value-9],[value-10],[value-11],[value-12],[value-13],[value-14],[value-15]))", con);

                //Create Parameters
                cmd.Parameters.AddWithValue("ID", CustomerData.ID);
                cmd.Parameters.AddWithValue("FirstName", CustomerData.FirstName);
                cmd.Parameters.AddWithValue("Insertion", CustomerData.Insertion);
                cmd.Parameters.AddWithValue("LastName", CustomerData.LastName);
                cmd.Parameters.AddWithValue("KindLicense", CustomerData.KindLicense);
                cmd.Parameters.AddWithValue("LicenseNationalitie", CustomerData.LicenseNationalitie);
                cmd.Parameters.AddWithValue("BusinessDays", CustomerData.BusinessDays);
                cmd.Parameters.AddWithValue("Username", CustomerData.Username);
                cmd.Parameters.AddWithValue("Password", CustomerData.Password);

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
        public void Update(CustomerData CustomerData)
        {
            //Create Connection
            MySqlConnection con = DatabaseConfig.GetConnection();

            //try to connect to database
            try
            {
                //Build MySQLcommand
                MySqlCommand cmd = new MySqlCommand("UPDATE `chauffeurs` SET " +
                    "`voornaam`=FirstName,`tussenvoegsel`=Insertion,`achternaam`=LastName,`soortrijbewijs`=KindLicense,`nationaliteit_rijbewijs`=LicenseNationalitie," +
                    "`werkdagen`=BusinessDays,`inlognaam`=Username,`wachtwoord`=Password WHERE ID", con);

                //Create Parameters
                cmd.Parameters.AddWithValue("ID", Driverdata.ID);
                cmd.Parameters.AddWithValue("FirstName", Driverdata.FirstName);
                cmd.Parameters.AddWithValue("Insertion", Driverdata.Insertion);
                cmd.Parameters.AddWithValue("LastName", Driverdata.LastName);
                cmd.Parameters.AddWithValue("KindLicense", Driverdata.KindLicense);
                cmd.Parameters.AddWithValue("LicenseNationalitie", Driverdata.LicenseNationalitie);
                cmd.Parameters.AddWithValue("BusinessDays", Driverdata.BusinessDays);
                cmd.Parameters.AddWithValue("Username", Driverdata.Username);
                cmd.Parameters.AddWithValue("Password", Driverdata.Password);

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
        public void Delete(CustomerData CustomerData)
        {
            //Create Connection
            MySqlConnection con = DatabaseConfig.GetConnection();

            //try to connect to database
            try
            {
                //Build MySQLcommand
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `chauffeurs` WHERE ID", con);

                //Cretae Parameters
                cmd.Parameters.AddWithValue("ID", Driverdata.ID);

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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `chauffeurs` WHERE ID", con);

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
