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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp15.FurnitureStore3DataSet14TableAdapters;

namespace WpfApp15
{

    public partial class SkladPage : Page
    {
        private SkladTableAdapter sklad = new SkladTableAdapter();
        private SkladView2TableAdapter skld = new SkladView2TableAdapter();
        private FurnitureTableAdapter furniture = new FurnitureTableAdapter(); 
        private UsersTableAdapter users = new UsersTableAdapter();

        public SkladPage()
        {
            InitializeComponent();
            AaaGrd.ItemsSource = skld.GetData();
            FurnitureCbx.ItemsSource = furniture.GetData();
            UserSurnameCbx.ItemsSource = users.GetData();
        }

        private void AaaGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AaaGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)AaaGrd.SelectedItem;
                DataRow row = rowView.Row;

                QuentityTbx.Text = row["FurnitureName"].ToString();
               


            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(QuentityTbx.Text) 
                ||  UserSurnameCbx.SelectedItem == null || FurnitureCbx.SelectedItem == null
                )
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {


                DataRowView selectedMan = FurnitureCbx.SelectedItem as DataRowView;
                int manId = selectedMan != null ? Convert.ToInt32(selectedMan["ID_Furniture"]) : -1;

                DataRowView selectedCat = UserSurnameCbx.SelectedItem as DataRowView;
                int catId = selectedCat != null ? Convert.ToInt32(selectedCat["ID_User"]) : -1;

               


                int price = int.TryParse(QuentityTbx.Text, out int parsedPrice) ? parsedPrice : 0;
                sklad.Insert( price, manId, catId);


                AaaGrd.ItemsSource = skld.GetData();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void QuentityTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[0-9]+$"))
            {
                e.Handled = true;
            }
        }
    }
}
