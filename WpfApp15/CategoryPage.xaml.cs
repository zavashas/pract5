using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
using WpfApp15.FurnitureStore3DataSetTableAdapters;
using Newtonsoft.Json;



namespace WpfApp15
{
    public partial class CategoryPage : Page
    {
        private FurnitureCategoriesTableAdapter ctg = new FurnitureCategoriesTableAdapter();

        public CategoryPage()
        {
            InitializeComponent();
            SkladGrd.ItemsSource = ctg.GetData();

        }

        private void SkladGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SkladGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)SkladGrd.SelectedItem;
                DataRow row = rowView.Row;

                CategoryTbx.Text = row["CategoryName"].ToString();
            }
        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string ctgName = CategoryTbx.Text.Trim();
            if (!string.IsNullOrEmpty(ctgName))
            {
                try
                {
                    ctg.Insert(ctgName);
                    SkladGrd.ItemsSource = ctg.GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении роли: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите название категории", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SkladGrd.SelectedItem != null)
            {
                try
                {
                    DataRowView rowView = (DataRowView)SkladGrd.SelectedItem;
                    int ctgId = Convert.ToInt32(rowView["ID_Category"]);
                    string ctgName = rowView["CategoryName"].ToString();

                    FurnitureTableAdapter furnitureAdapter = new FurnitureTableAdapter();
                    furnitureAdapter.UpdateQuery(ctgId);

                    ctg.Delete(ctgId, ctgName);

                    SkladGrd.ItemsSource = ctg.GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении категории: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите категорию для удаления", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        public class FurnitureCategoriesModel
        {
            public string CategoryName { get; set; }
        }




      



        private void Import_Click(object sender, RoutedEventArgs e)
        {
           
        }





        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            string ctgName = CategoryTbx.Text.Trim();
            if (!string.IsNullOrEmpty(ctgName) && SkladGrd.SelectedItem != null)
            {
                try
                {
                    DataRowView rowView = (DataRowView)SkladGrd.SelectedItem;
                    FurnitureStore3DataSet.FurnitureCategoriesDataTable ctgDataTable = ctg.GetData();
                    FurnitureStore3DataSet.FurnitureCategoriesRow rowToUpdate = ctgDataTable.FindByID_Category(Convert.ToInt32(rowView["ID_Category"]));
                    if (rowToUpdate != null)
                    {
                        rowToUpdate.CategoryName = ctgName;
                        ctg.Update(rowToUpdate);
                        SkladGrd.ItemsSource = ctg.GetData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении роли: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите роль для изменения и введите новое название роли", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CategoryTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
