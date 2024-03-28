using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    public partial class DiscountsPage : Page
    {
        private DiscountsTableAdapter disc = new DiscountsTableAdapter();

        public DiscountsPage()
        {
            InitializeComponent();
            DiscGrd.ItemsSource = disc.GetData();

        }



        private void DiscGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DiscGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)DiscGrd.SelectedItem;
                DataRow row = rowView.Row;

                NameTbx.Text = row["DiscountName"].ToString();
                ProcTbx.Text = row["PercentageDiscount"].ToString();

            }
        }

        private void ProcTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    if (int.TryParse(textBox.Text + e.Text, out int enteredNumber))
                    {
                        if (enteredNumber > 100)
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }

                int maxLength = 3;
                if (textBox.Text.Length >= maxLength)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[0-9]+$"))
            {
                e.Handled = true;
            }
        }


        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string discountName = NameTbx.Text.Trim();
            int percentageDiscount;

            if (!int.TryParse(ProcTbx.Text.Trim(), out percentageDiscount))
            {
                MessageBox.Show("Введите корректное значение процента скидки", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(discountName) && percentageDiscount > 0)
            {
                try
                {
                    disc.Insert(percentageDiscount, discountName);
                    DiscGrd.ItemsSource = disc.GetData(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении скидки: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля корректно", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
