using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFCursach
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Products> products;
        List<Categories> categories;
        List<Stores> stores;
        List<ViewProductsOnCategories_Result> viewProductsOnCategories;
        string nameBuyProduct;
        public string myVariable;
        
        public Window1()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(DataBank.IDJobTitle != 1 && DataBank.IDJobTitle!=2)
            {
                btnEditProduct.Visibility = Visibility.Hidden;
            }
            if(DataBank.IDJobTitle != 1)
            {
                btnMenuAdmin.Visibility = Visibility.Hidden;
            }
            using (var context = new CетьМагазиновСантехникиEntities())
            {
                products = context.Products.ToList();
                categories = context.Categories.ToList();
                stores = context.Stores.ToList();
            }

            string[] strings = new string[categories.Count+1];
            for (int i = 0; i < categories.Count; i++)
            {
                strings[i] = categories[i].nameCategories;

            }
            lbCategoriesSelected.ItemsSource = strings;
            string[] stringsStores = new string[stores.Count];
            for (int i = 0; i < stores.Count; i++)
            {
                stringsStores[i] = stores[i].adressStore;
            }

            cbStoreSelected.ItemsSource = stringsStores;
            lbCategoriesSelected.SelectedIndex = 10;
            cbStoreSelected.SelectedIndex = 10;
            cbStoreSelected.SelectedIndex = 10;
            cbSortSelect.SelectedIndex = 2;
            GridFillAfterSearchAndFilter();
        }


        private void GridFillAfterSearchAndFilter()
        {
            grid.Children.Clear();
            using (var context = new CетьМагазиновСантехникиEntities())
            {

                viewProductsOnCategories = context.ViewProductsOnCategories(lbCategoriesSelected.SelectedIndex + 1, cbStoreSelected.SelectedIndex + 1, tbSearch.Text,Convert.ToString(cbSortSelect.SelectedIndex+1)).ToList();

            }
            int productCount = viewProductsOnCategories.Count;
            int columnCount = 3;
            int rowCount;

            if (productCount / columnCount != 0)
            {
                rowCount = productCount / columnCount + 1;
            }
            else
            {
                rowCount = productCount / columnCount;
            }

            grid.Rows = rowCount;

            foreach (var item in viewProductsOnCategories)
            {
                UserControl1 userControl = new UserControl1();
                userControl.textBlockName.Text += item.nameProduct;
                userControl.amountInStock.Text += item.AmountInStocksProduct;
                userControl.price.Text += item.priceProduct;
                userControl.btnBuyUserControl.Click += BtnBuyUserControl_Click;
                Uri uri = new Uri($"../../Properties/{item.ImagePath}", UriKind.Relative);
                userControl.img.Source = new BitmapImage(uri); 
                if(Focusable == IsEnabled)
                {
                    nameBuyProduct = item.nameProduct;
                }
                grid.Children.Add(userControl);
            }
        }

        private void BtnBuyUserControl_Click(object sender, RoutedEventArgs e)
        {
            DataBank.nameProductAddCheck = nameBuyProduct;
            Visibility = Visibility.Hidden;
            var ReceiptColorsAndEmployee = new ReceiptColorsAndEmployee
            {
                Visibility = Visibility.Visible
            };
        }

        private void cbStoreChanged(object sender, SelectionChangedEventArgs e)
        {
            GridFillAfterSearchAndFilter();
        }
        private void lbCategoriesChanged(object sender, SelectionChangedEventArgs e)
        {
            GridFillAfterSearchAndFilter();
        }

        private void tbSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            GridFillAfterSearchAndFilter();
        }

        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            var EditProduct = new EditProduct
            {
                Visibility = Visibility.Visible
            };
        }
        private void btnMenuAdmin_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            var AdminWindow = new AdminWindow
            {
                Visibility = Visibility.Visible
            };
        }
    }
}