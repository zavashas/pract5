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
using WpfApp15.FurnitureStore3DataSet12TableAdapters;


namespace WpfApp15
{
    public partial class FurniturePage : Page
    {
        private FurnitureViewTableAdapter viewfur = new FurnitureViewTableAdapter();   
        private FurnitureTableAdapter fur = new FurnitureTableAdapter();
        private ManufacturersTableAdapter manufacturers = new ManufacturersTableAdapter();
        private FurnitureCategoriesTableAdapter cat = new FurnitureCategoriesTableAdapter();   
        private DiscountsTableAdapter discounts = new DiscountsTableAdapter();  

        public FurniturePage()
        {
            InitializeComponent();
            SkladGrd.ItemsSource = viewfur.GetData();
            ManufacturerCbx.ItemsSource = manufacturers.GetData();
            CategoryCbx.ItemsSource= cat.GetData();
            DiscountsCbx.ItemsSource = discounts.GetData();
        }
        private void SkladGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SkladGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)SkladGrd.SelectedItem;
                DataRow row = rowView.Row;

                NameTbx.Text = row["FurnitureName"].ToString();
                DescriptTbx.Text = row["DescriptionFurniture"].ToString();
               
                PriceTbx.Text = row["Price"].ToString();


            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTbx.Text) || string.IsNullOrWhiteSpace(DescriptTbx.Text) 
                || string.IsNullOrWhiteSpace(PriceTbx.Text) || ManufacturerCbx.SelectedItem == null || CategoryCbx.SelectedItem == null 
                )
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
               

                DataRowView selectedMan = ManufacturerCbx.SelectedItem as DataRowView;
                int manId = selectedMan != null ? Convert.ToInt32(selectedMan["ID_Manufacturer"]) : -1;

                DataRowView selectedCat = CategoryCbx.SelectedItem as DataRowView;
                int catId = selectedCat != null ? Convert.ToInt32(selectedCat["ID_Category"]) : -1;

                DataRowView selectedDisc = DiscountsCbx.SelectedItem as DataRowView;
                int discId = selectedDisc != null ? Convert.ToInt32(selectedDisc["ID_Discount"]) : -1;


                decimal price = decimal.TryParse(PriceTbx.Text, out decimal parsedPrice) ? parsedPrice : 0;
                fur.InsertQuery(NameTbx.Text, DescriptTbx.Text, price, manId, catId, discId);


                SkladGrd.ItemsSource = viewfur.GetData();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void NameTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
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

        private void QuantityTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[0-9]+$"))
            {
                e.Handled = true;
            }
        }

        private void PriceTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[0-9.,]+$"))
            {
                e.Handled = true;
            }
        }
    }
}
