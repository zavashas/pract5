using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp15.FurnitureStore3DataSet1TableAdapters;


namespace WpfApp15
{
    public partial class DataPage : Page
    {
        private UsersTableAdapter users = new UsersTableAdapter();

        public DataPage()
        {
            InitializeComponent();
            DataGrd.ItemsSource = users.GetData();
            SurnameCbx.ItemsSource = users.GetData();

        }
        private void DataGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)DataGrd.SelectedItem;
                DataRow row = rowView.Row;

                LoginTbx.Text = row["UserLogin"].ToString();
                PasswordTbx.Text = row["PasswordHash"].ToString();


            }
        }
       

    }
}
