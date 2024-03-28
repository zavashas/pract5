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

namespace WpfApp15
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            PageFrame.Content = new RolePage();
        }

        private void RoleBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new RolePage();
        }

        private void UsersBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new UsersPage();
        }

        private void DataBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new DataPage();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DiscountsBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new DiscountsPage();
        }
        private void CategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new CategoryPage();
        }

        private void ManufacturersBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ManufacturersPage();
        }

        private void ServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ServicesPage();
        }
    }
}
