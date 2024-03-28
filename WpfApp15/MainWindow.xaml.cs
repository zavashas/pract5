using System;
using System.Collections.Generic;
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
using System.Security.Cryptography;
using WpfApp15.FurnitureStore3DataSetTableAdapters;


namespace WpfApp15
{
    public partial class MainWindow : Window
    {
        private UsersTableAdapter user = new UsersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var alluser = user.GetData().Rows;

            for (int i = 0; i < alluser.Count; i++)
            {
                if (alluser[i][4].ToString() == LoginTbx.Text &&
                    ComputeHash(PasswordTbx.Password) == alluser[i][5].ToString()) 
                {
                    int roleid = (int)alluser[i][6];

                    switch (roleid)
                    {
                        case 1:
                            AdminWindow adm = new AdminWindow();
                            adm.Show();
                            break;
                        case 2:
                            KassirWindow ksr = new KassirWindow();
                            ksr.Show();
                            break;
                        case 3:
                            SkladWindow skld = new SkladWindow();
                            skld.Show();
                            break;
                    }
                    return; 
                }
            }
            MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
