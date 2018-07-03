using Dorp.FrondEnd.WPF.Windows.Customer.Page;
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

namespace Dorp.FrondEnd.WPF.Windows.Customer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }

        //Side-Menu-Handling
        private void NavCurrentOrder_Click(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            NavigationBar.Children.Clear();

            CurrentOrders page = new CurrentOrders();
            Content.Children.Add(page);
            page.Width = Content.Width;
            page.Height = Content.Height;
        }
        private void NavProjects_Click(object sender, RoutedEventArgs e)
        {
            Content.Children.Clear();
            NavigationBar.Children.Clear();

            NewOrder page = new NewOrder();
            Content.Children.Add(page);
            page.Width = Content.Width;
            page.Height = Content.Height;
        }


        //Set User name information Example: Name, Email
    }
}
