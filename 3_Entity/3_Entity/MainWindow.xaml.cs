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
using _3_Entity;

namespace _3_Entity
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        private storeP8Entitieeees products = new storeP8Entitieeees();
        private storeP8Entitieeees categories = new storeP8Entitieeees();
        private storeP8Entitieeees orders = new storeP8Entitieeees();

        public MainWindow()
        {
            InitializeComponent();

            var query = from o in products.OrderArchive
                        join p in products.Products on o.Product_ID equals p.Product_ID
                        join c in products.Categories on p.Category_ID equals c.Category_ID
                        select new
                        {
                            o.OrderPrice,
                            p.ProductName,
                            p.Price,
                            c.CategoryName
                        };

            dateGrid.ItemsSource = query.ToList();
        }
    }
}

