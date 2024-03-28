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
    public partial class ServicesPage : Page
    {
        private ServicessTableAdapter ser = new ServicessTableAdapter();

        public ServicesPage()
        {
            InitializeComponent();
            SkladGrd.ItemsSource = ser.GetData();

        }

        private void SkladGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SkladGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)SkladGrd.SelectedItem;
                DataRow row = rowView.Row;

                ServiceNameTbx.Text = row["ServiceName"].ToString();
                DescriptionServiceTbx.Text = row["DescriptionService"].ToString();
                PriceTbx.Text = row["Price"].ToString();

            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string serviceName = ServiceNameTbx.Text.Trim();
            string descriptionService = DescriptionServiceTbx.Text.Trim();
            decimal price = Convert.ToDecimal(PriceTbx.Text.Trim()); 

            if (!string.IsNullOrEmpty(serviceName) && !string.IsNullOrEmpty(descriptionService) && price > 0)
            {
                try
                {
                    ser.Insert(serviceName, descriptionService, price);
                    SkladGrd.ItemsSource = ser.GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении услуги: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля корректно", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ServiceNameTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

        private void DescriptionServiceTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void PriceTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int maxLength = 11;

                if (textBox.Text.Length >= maxLength)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[0-9.,]+$"))
            {
                e.Handled = true;
            }
        }
    }
}
