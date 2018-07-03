using Dorp.Data.DataClasses.Account;
using Dorp.Data.DataRepository.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dorp.FrondEnd.WPF.Windows.Account
{
    public partial class Register : Window
    {
        static Control[] c;

        public Register()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            c = new Control[] {
            FirstName,
            MiddleName,
            LastName,
            DayOfBirth,
            Email,
            TelNr,
            Street,
            HouseNumber,
            PostalCode,
            Place,
            Country,
            Company_Private,
            CompanyName,
            IBAN,
            PasswordOne,
            PasswordTwo
        };

        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            //Create a new login window
            Login wd = new Login();
            wd.Show();

            //Close this window
            this.Close();
        }

        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            //Get all values from the Controls
            RegisterData i = new RegisterData(
            PasswordOne.Password.ToString(),
            FirstName.Text,
            MiddleName.Text,
            LastName.Text,
            DayOfBirth.Text,
            Email.Text,
            int.Parse(TelNr.Text),
            CustomerRoll.Private,
            int.Parse(IBAN.Text),
            PostalCode.Text,
            Street.Text,
            int.Parse(PostalCode.Text),
            Place.Text,
            Country.Text
            );

            //Check if all Controlss are filled
            if (ControlState.Execute(c, ControlStateVisuals.Colored))
                //If all controlls are filled
                RegisterController.RegisterNewCustomer(i);
            else
                //If all controll are not filled
                MessageBox.Show("Failed");
        }
    }
}
