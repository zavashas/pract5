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
using WpfApp15.FurnitureStore3DataSetTableAdapters;

namespace WpfApp15
{
    public partial class RolePage : Page
    {
        private RolesTableAdapter role = new RolesTableAdapter();

        public RolePage()
        {
            InitializeComponent();
            RoleGrd.ItemsSource = role.GetData();

        }

        private void RoleGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoleGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)RoleGrd.SelectedItem;
                DataRow row = rowView.Row;

                RoleTbx.Text = row["RoleName"].ToString();
                
            }
        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string roleName = RoleTbx.Text.Trim();
            if (!string.IsNullOrEmpty(roleName))
            {
                try
                {
                    role.Insert(roleName);
                    RoleGrd.ItemsSource = role.GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении роли: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите название роли", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (RoleGrd.SelectedItem != null)
            {
                try
                {
                    DataRowView rowView = (DataRowView)RoleGrd.SelectedItem;
                    int roleId = Convert.ToInt32(rowView["ID_Role"]);
                    string roleName = rowView["RoleName"].ToString();
                    role.Delete(roleId, roleName);
                    RoleGrd.ItemsSource = role.GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении роли: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите роль для удаления", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            string roleName = RoleTbx.Text.Trim();
            if (!string.IsNullOrEmpty(roleName) && RoleGrd.SelectedItem != null)
            {
                try
                {
                    DataRowView rowView = (DataRowView)RoleGrd.SelectedItem;
                    FurnitureStore3DataSet.RolesDataTable rolesDataTable = role.GetData();
                    FurnitureStore3DataSet.RolesRow rowToUpdate = rolesDataTable.FindByID_Role(Convert.ToInt32(rowView["ID_Role"]));
                    if (rowToUpdate != null)
                    {
                        rowToUpdate.RoleName = roleName;
                        role.Update(rowToUpdate);
                        RoleGrd.ItemsSource = role.GetData();
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

        private void RoleTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int maxLength = 50;

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
