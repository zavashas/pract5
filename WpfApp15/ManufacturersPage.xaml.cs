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
using WpfApp15.FurnitureStore3DataSet2TableAdapters;


namespace WpfApp15
{
    public partial class ManufacturersPage : Page
    {
        private ManufacturersTableAdapter mnf = new ManufacturersTableAdapter();
        private FurnitureTableAdapter furniture = new FurnitureTableAdapter();


        public ManufacturersPage()
        {
            InitializeComponent();
            SkladGrd.ItemsSource = mnf.GetData();
        }
        private void SkladGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SkladGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)SkladGrd.SelectedItem;
                DataRow row = rowView.Row;

                ManufacturerNameTbx.Text = row["ManufacturerName"].ToString();
                CountryTbx.Text = row["Country"].ToString();

            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string manufacturerName = ManufacturerNameTbx.Text.Trim();
            string country = CountryTbx.Text.Trim();

            if (!string.IsNullOrEmpty(manufacturerName) && !string.IsNullOrEmpty(country))
            {
                try
                {
                    mnf.Insert(manufacturerName, country);
                    SkladGrd.ItemsSource = mnf.GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении производителя: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SkladGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)SkladGrd.SelectedItem;
                DataRow row = rowView.Row;
                int manufacturerId = Convert.ToInt32(row["ID_Manufacturer"]);

                string manufacturerName = ManufacturerNameTbx.Text.Trim();
                string country = CountryTbx.Text.Trim();

                if (!string.IsNullOrEmpty(manufacturerName) && !string.IsNullOrEmpty(country))
                {
                    try
                    {
                        furniture.UpdateFur(manufacturerId);
                        mnf.UpdateQuery(manufacturerName, country, manufacturerId);
                        SkladGrd.ItemsSource = mnf.GetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении производителя: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите производителя для обновления", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SkladGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)SkladGrd.SelectedItem;
                DataRow row = rowView.Row;
                int manufacturerId = Convert.ToInt32(row["ID_Manufacturer"]);

                try
                {
                    furniture.UpdateFur(manufacturerId);

                    mnf.DeleteQuery(manufacturerId);

                    SkladGrd.ItemsSource = mnf.GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении производителя: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите производителя для удаления", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ManufacturerNameTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int maxLength = 100;

                if (textBox.Text.Length >= maxLength)
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    
        private void CountryTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int maxLength = 100;

                if (textBox.Text.Length >= maxLength)
                {
                    e.Handled = true;
                    return;
                }

                foreach (char c in e.Text)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        e.Handled = true;
                        return;
                    }
                }
            }
        }
    }
}
