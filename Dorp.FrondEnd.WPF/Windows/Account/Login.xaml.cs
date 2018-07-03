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
using Dorp.Data.DataRepository.Account;

namespace Dorp.FrondEnd.WPF.Windows.Account
{
    public partial class Login : Window
    {

        //Main
        public Login()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        //Key-Handlers
        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            Control[] c = { LoginName_txt, Password_txt };
            if (ControlState.Execute(c, ControlStateVisuals.Colored))
                LoginNow(LoginName_txt.Text, Password_txt.Text, this);
        }

        public static void LoginNow(string loginname, string password, Window window)
        {
            LoginData data = LoginController.Login(loginname, password);

            if (data != null)
                UserRollPlayData.Execution(data.rollplay,data.matchOption, data.ID);
            else
            {
                MessageBox.Show("No match found");
            }
        }

        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            Register wd = new Register();
            wd.Show();
            this.Close();
        }
    }
}
