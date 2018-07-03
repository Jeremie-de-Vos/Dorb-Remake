using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dorp.Data.DataRepository.Account;

namespace Dorp.FrondEnd.Forms.Forms
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {

        }
        public void Login_btn_Click(object sender, EventArgs e)
        {
            if(Email_txt.Text != string.Empty || Password_txt.Text != string.Empty)
            {
                Logingin(Email_txt.Text, Password_txt.Text);
            }
        }
        private void ForgotPassword_btn_Click(object sender, EventArgs e)
        {

        }
        private void Register_btn_Click(object sender, EventArgs e)
        {

        }


        private static void Logingin(string email, string password)
        {
            //LoginController.Login();
        }
    }
}
