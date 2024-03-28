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
using _3_DataSet.storeP8DataSetTableAdapters;

namespace _3_DataSet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OrderArchiveTableAdapter orders = new OrderArchiveTableAdapter();
        ProductsTableAdapter products = new ProductsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            dateGrid.ItemsSource = orders.GetData();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dateGrid.Columns[2].Visibility = Visibility.Collapsed;
            dateGrid.Columns[2].Visibility = Visibility.Collapsed;
            dateGrid.Columns[2].Visibility = Visibility.Collapsed;

        }
    }
}
