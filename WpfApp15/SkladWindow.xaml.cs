using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp15.FurnitureStore3DataSet11TableAdapters;
using static MaterialDesignThemes.Wpf.Theme;
using System.Security.Principal;



namespace WpfApp15
{

    public partial class SkladWindow : Window
    {
        private SkladView5TableAdapter sklad = new SkladView5TableAdapter();
        private UsersTableAdapter usersTable = new UsersTableAdapter(); 

        public SkladWindow()
        {
            InitializeComponent();
            
            
        }
        private void SkladGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }






        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FurnitureBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new FurniturePage();
        }

        private void SkladBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new SkladPage();
        }
    }
}
