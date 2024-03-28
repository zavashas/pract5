using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using static MaterialDesignThemes.Wpf.Theme.ToolBar;
using WpfApp15.FurnitureStore3DataSet9TableAdapters;

    namespace WpfApp15
    {
        public partial class BuyPage : Page
        {
            private readonly OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();
            private readonly UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        private readonly OrderDetailsTableAdapter orderDetailsTableAdapter;
        private readonly SkladTableAdapter skladTableAdapter;
        private readonly FurnitureTableAdapter furnitureTableAdapter;
        private readonly ServicessTableAdapter servicessTableAdapter;
        private readonly DiscountsTableAdapter discountsTableAdapter;

        public BuyPage()
            {
                InitializeComponent();
               
            }

            
           
        }
    }
