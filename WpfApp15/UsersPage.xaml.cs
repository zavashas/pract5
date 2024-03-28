using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using WpfApp15.FurnitureStore3DataSet4TableAdapters;
using static MaterialDesignThemes.Wpf.Theme;


namespace WpfApp15
{
    public partial class UsersPage : Page
    {
        private OrdersTableAdapter ordersAdapter = new OrdersTableAdapter();

        private RolesTableAdapter role = new RolesTableAdapter();
        private UsersView3TableAdapter users = new UsersView3TableAdapter();
        private UsersTableAdapter usersAdapter = new UsersTableAdapter();
        public UsersPage()
        {
            InitializeComponent();
            UsersGrd.ItemsSource = users.GetData();
            RoleCbx.ItemsSource = role.GetData();

        }

        private void UsersGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsersGrd.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)UsersGrd.SelectedItem;
                DataRow row = rowView.Row;

                SurnameTbx.Text = row["UserSurname"].ToString();
                NameTbx.Text = row["UserName"].ToString();
                MiddleNameTbx.Text = row["UserMiddleName"].ToString();

                LoginTbx.Text = row["UserLogin"].ToString();
                PasswordTbx.Password = row["PasswordHash"].ToString();

            }
        }


        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SurnameTbx.Text) || string.IsNullOrWhiteSpace(NameTbx.Text) || string.IsNullOrWhiteSpace(LoginTbx.Text) 
                || string.IsNullOrWhiteSpace(PasswordTbx.Password) || RoleCbx.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                string hashedPassword = HashPassword(PasswordTbx.Password);

                DataRowView selectedRole = RoleCbx.SelectedItem as DataRowView;
                int roleId = selectedRole != null ? Convert.ToInt32(selectedRole["ID_Role"]) : -1;

                usersAdapter.Insert(SurnameTbx.Text, NameTbx.Text, MiddleNameTbx.Text, LoginTbx.Text, hashedPassword, roleId);

                UsersGrd.ItemsSource = users.GetData();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении пользователя: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UsersGrd.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для изменения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DataRowView selectedUser = (DataRowView)UsersGrd.SelectedItem;
            int userId = Convert.ToInt32(selectedUser["ID_User"]);

            try
            {
                string hashedPassword = HashPassword(PasswordTbx.Password);

                DataRowView selectedRole = RoleCbx.SelectedItem as DataRowView;
                int roleId = selectedRole != null ? Convert.ToInt32(selectedRole["ID_Role"]) : -1;


                DataRowView currentSelectedUser = (DataRowView)UsersGrd.SelectedItem;
                int currentUserId = Convert.ToInt32(currentSelectedUser["ID_User"]);

                usersAdapter.UpdateQuery(SurnameTbx.Text, NameTbx.Text, MiddleNameTbx.Text,
                                    LoginTbx.Text, hashedPassword, roleId, currentUserId);


                UsersGrd.ItemsSource = users.GetData();

                MessageBox.Show("Пользователь успешно изменен.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Выберите роль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (UsersGrd.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DataRowView selectedUser = (DataRowView)UsersGrd.SelectedItem;
            int userId = Convert.ToInt32(selectedUser["ID_User"]);




            usersAdapter.DeleteQuery(userId);

            UsersGrd.ItemsSource = users.GetData();

            MessageBox.Show("Пользователь успешно удален.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        private void SurnameTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
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

        private void NameTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
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

        private void MiddleNameTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
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

        private void LoginTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            if (textBox != null)
            {
                int maxLength = 50;

                if (textBox.Text.Length >= maxLength)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void PasswordTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            if (textBox != null)
            {
                int maxLength = 300;

                if (textBox.Text.Length >= maxLength)
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }

}
    














    




