using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using WpfApp15.FurnitureStore3DataSet9TableAdapters;

namespace WpfApp15
{
    public partial class CheksPage : Page
    {
        private Order_View111TableAdapter view = new Order_View111TableAdapter();

        public CheksPage()
        {
            InitializeComponent();
            ViewGrd.ItemsSource = view.GetData();
            CheckToFile.Click += CheckToFile_Click;
        }

        private void CheckToFile_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ViewGrd.SelectedItem as DataRowView;

            if (selectedItem != null)
            {
                var orderRow = selectedItem.Row as FurnitureStore3DataSet9.Order_View111Row;

                if (orderRow != null)
                {
                    List<CheckItem> checkItems = new List<CheckItem>();
                    checkItems.Add(new CheckItem { Name = orderRow.FurnitureName, Price = orderRow.PriceFurniture, Quantity = orderRow.QuantityFurniture });
                    if (!string.IsNullOrEmpty(orderRow.ServiceName))
                        checkItems.Add(new CheckItem { Name = orderRow.ServiceName, Price = orderRow.PriceService, Quantity = orderRow.QuantityService });

                    decimal totalPrice = 0;
                    decimal sumMoney = orderRow.SumMoneyClient;
                    decimal change = 0;

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Магазин мебели");
                    sb.AppendLine($"Кассовый чек №{orderRow.ID_Order}");
                    sb.AppendLine("Товар\t\t\tЦена\t\t\tКоличество\t\tСумма");
                    foreach (var item in checkItems)
                    {
                        decimal itemTotalPrice = item.Price * item.Quantity;
                        totalPrice += itemTotalPrice;
                        sb.AppendLine($"{item.Name}\t\t{item.Price}\t\t\t{item.Quantity}\t\t\t{itemTotalPrice}");
                    }
                    change = sumMoney - totalPrice;

                    sb.AppendLine($"Итого к оплате: {totalPrice}");
                    sb.AppendLine($"Внесено: {sumMoney}");
                    sb.AppendLine($"Сдача: {change}");

                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "Чек.txt");
                    File.WriteAllText(filePath, sb.ToString());

                    MessageBox.Show("Чек успешно сохранен.");
                }
                else
                {
                    MessageBox.Show("Не удалось получить данные для составления чека.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент из списка для составления чека.");
            }
        }


    }

    public class CheckItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
