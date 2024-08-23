using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
        List<Products> products;
        List<Categories> categories;
        List<Stores> stores;
        string imagepath;
        string imageName;
        public EditProduct()
        {
            InitializeComponent();
        }
        string nameProduct = null;
        string priceProduct = null;
        string purchasePriceProduct = null;
        string amount = null;
        string amountInStore = null;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            labelNameProducts.Visibility = Visibility.Hidden;
            cbNameProducts.Visibility = Visibility.Hidden;
            labelSecondNameProducts.Visibility = Visibility.Hidden;
            tbNameProducts.Visibility = Visibility.Hidden;
            labelPriceProduct.Visibility = Visibility.Hidden;
            tbPriceProduct.Visibility = Visibility.Hidden;
            labelPurchasePriceProduct.Visibility = Visibility.Hidden;
            tbPurchasePriceProduct.Visibility = Visibility.Hidden; 
            labelAmountInStock.Visibility = Visibility.Hidden;
            tbAmountInStock.Visibility = Visibility.Hidden;
            labelCategories.Visibility = Visibility.Hidden;
            cbCategories.Visibility = Visibility.Hidden;
            labelStores.Visibility = Visibility.Hidden; 
            labelAmountInStore.Visibility = Visibility.Hidden;
            cbStores.Visibility = Visibility.Hidden;
            tbAmountInStore.Visibility = Visibility.Hidden;
            img.Visibility = Visibility.Hidden;
            ChangeImg.Visibility = Visibility.Hidden;

            using (var context = new CетьМагазиновСантехникиEntities())
            {
                products = context.Products.ToList();
                categories = context.Categories.ToList();
                stores = context.Stores.ToList();
            }
            string[] strings = new string[categories.Count + 1];
            for (int i = 0; i < categories.Count; i++)
            {
                strings[i] = categories[i].nameCategories;

            }
            cbCategories.ItemsSource = strings;
            string[] stringsProducts = new string[products.Count];
            for (int i = 0; i < products.Count; i++)
            {
                stringsProducts[i] = products[i].nameProduct;
            }

            cbNameProducts.ItemsSource = stringsProducts;


            string[] stringsStores = new string[stores.Count];
            for (int i = 0; i < stores.Count; i++)
            {
                stringsStores[i] = stores[i].adressStore;
            }

            cbStores.ItemsSource = stringsStores;
        }

        private void cbParams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbParams.SelectedIndex == 0)
            {
                labelNameProducts.Visibility = Visibility.Hidden;
                cbNameProducts.Visibility = Visibility.Hidden;
                labelSecondNameProducts.Visibility = Visibility.Visible;
                tbNameProducts.Visibility = Visibility.Visible;
                labelPriceProduct.Visibility = Visibility.Visible;
                tbPriceProduct.Visibility = Visibility.Visible;
                labelPurchasePriceProduct.Visibility = Visibility.Visible;
                tbPurchasePriceProduct.Visibility = Visibility.Visible;
                labelAmountInStock.Visibility = Visibility.Visible;
                tbAmountInStock.Visibility = Visibility.Visible;
                labelCategories.Visibility = Visibility.Visible;
                cbCategories.Visibility = Visibility.Visible;
                labelStores.Visibility = Visibility.Visible;
                labelAmountInStore.Visibility = Visibility.Visible;
                cbStores.Visibility = Visibility.Visible;
                tbAmountInStore.Visibility = Visibility.Visible;
                ChangeImg.Visibility = Visibility.Visible;
                img.Visibility = Visibility.Visible;
            }

            else if (cbParams.SelectedIndex == 2)
            {
                labelNameProducts.Visibility = Visibility.Visible;
                cbNameProducts.Visibility = Visibility.Visible;
                labelSecondNameProducts.Visibility = Visibility.Hidden;
                tbNameProducts.Visibility = Visibility.Hidden;
                labelPriceProduct.Visibility = Visibility.Hidden;
                tbPriceProduct.Visibility = Visibility.Hidden;
                labelPurchasePriceProduct.Visibility = Visibility.Hidden;
                tbPurchasePriceProduct.Visibility = Visibility.Hidden;
                labelAmountInStock.Visibility = Visibility.Hidden;
                tbAmountInStock.Visibility = Visibility.Hidden;
                labelCategories.Visibility = Visibility.Hidden;
                cbCategories.Visibility = Visibility.Hidden;
                labelStores.Visibility = Visibility.Hidden;
                labelAmountInStore.Visibility = Visibility.Hidden;
                cbStores.Visibility = Visibility.Hidden;
                tbAmountInStore.Visibility = Visibility.Hidden;
                ChangeImg.Visibility = Visibility.Hidden;
                img.Visibility = Visibility.Hidden;
            }
            else if (cbParams.SelectedIndex == 1)
            {
                labelNameProducts.Visibility = Visibility.Visible;
                cbNameProducts.Visibility = Visibility.Visible;
                labelSecondNameProducts.Visibility = Visibility.Hidden;
                tbNameProducts.Visibility = Visibility.Hidden;
                labelPriceProduct.Visibility = Visibility.Visible;
                tbPriceProduct.Visibility = Visibility.Visible;
                labelPurchasePriceProduct.Visibility = Visibility.Visible;
                tbPurchasePriceProduct.Visibility = Visibility.Visible;
                labelAmountInStock.Visibility = Visibility.Visible;
                tbAmountInStock.Visibility = Visibility.Visible;
                labelCategories.Visibility = Visibility.Visible;
                cbCategories.Visibility = Visibility.Visible;
                labelStores.Visibility = Visibility.Hidden;
                labelAmountInStore.Visibility = Visibility.Hidden;
                cbStores.Visibility = Visibility.Hidden;
                tbAmountInStore.Visibility = Visibility.Hidden;
                img.Visibility = Visibility.Visible;
                ChangeImg.Visibility = Visibility.Visible;

            }
        }
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var mainWindow = new Window1
            {
                Visibility = Visibility.Visible
            };
        }
        private void btnEditProductAccept_Click(object sender, RoutedEventArgs e)
        {
            UseProcedureAddEditAndDeleteProducts();
            this.Close();
            var mainWindow = new Window1
            {
                Visibility = Visibility.Visible
            };
        }
        public void UseProcedureAddEditAndDeleteProducts()
        {
            

            try
            {
                nameProduct = tbNameProducts.Text;
                priceProduct = tbPriceProduct.Text;
                purchasePriceProduct = tbPurchasePriceProduct.Text;
                amount = tbAmountInStock.Text;
                amountInStore = tbAmountInStore.Text;
                switch (cbParams.SelectedIndex)
                {
                    case 0:
                        using (var context = new CетьМагазиновСантехникиEntities())
                        {

                            context.AddEditAndDeleteProducts(Convert.ToInt32(cbParams.SelectedIndex + 1), tbNameProducts.Text, Convert.ToDecimal(tbPriceProduct.Text), Convert.ToDecimal(tbPurchasePriceProduct.Text), Convert.ToInt32(tbAmountInStock.Text), Convert.ToInt32(cbCategories.SelectedIndex + 1), imageName, (cbStores.SelectedIndex + 1), Convert.ToInt32(amountInStore));
                        }
                        break;
                    case 1:
                        using (var context = new CетьМагазиновСантехникиEntities())
                        {

                            context.AddEditAndDeleteProducts(cbParams.SelectedIndex + 1, cbNameProducts.Text, Convert.ToDecimal(priceProduct), Convert.ToDecimal(purchasePriceProduct), Convert.ToInt32(amount), cbCategories.SelectedIndex + 1, imageName, 1, 1);
                        }
                        break;
                    case 2:
                        using (var context = new CетьМагазиновСантехникиEntities())
                        {
                            context.AddEditAndDeleteProducts(cbParams.SelectedIndex + 1, cbNameProducts.Text, 1, 1, 1, 1, "", 1, 1);
                        }
                        break;
                    default:
                        return;
                }
            }
            catch 
            {
                MessageBox.Show("Проверьте верность введённых данных", "Ошибка", MessageBoxButton.OK);
            }
            
        }

        private void tbNameProducts_TextChanged(object sender, TextChangedEventArgs e)
        {
            nameProduct = tbNameProducts.Text;
        }

        private void tbPriceProduct_TextChanged(object sender, TextChangedEventArgs e)
        {
            priceProduct = tbPriceProduct.Text;
        }

        private void tbPurchasePriceProduct_TextChanged(object sender, TextChangedEventArgs e)
        {
            purchasePriceProduct = tbPurchasePriceProduct.Text;
        }

        private void tbAmountInStock_TextChanged(object sender, TextChangedEventArgs e)
        {
            amount = tbAmountInStock.Text;
        }

        private void cbNameProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                for (int i = 0; i < products.Count; i++)
                {
                    if ((cbNameProducts.SelectedIndex+1) == products[i].IDProduct)
                    {
                        tbPriceProduct.Text = Convert.ToString(products[i].priceProduct);
                        tbPurchasePriceProduct.Text = Convert.ToString(products[i].purchasePriceProduct);
                        tbAmountInStock.Text = Convert.ToString(products[i].AmountInStocksProduct);
                        cbCategories.SelectedIndex = Convert.ToInt32(products[i].IDCategories-1);
                        imagepath = products[i].ImagePath;
                    }
                }
            Uri uri = new Uri($"../../Properties/{imagepath}", UriKind.Relative);
            img.Source = new BitmapImage(uri);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files(*.*)|*.*)";
            int idproduct = 0;


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (cbNameProducts.Visibility == Visibility.Hidden)
                    {
                        imagepath = ofd.FileName.ToString();
                        try
                        {
                            for (int i = 0; i < products.Count; i++)
                            {
                                if (tbNameProducts.Text == products[i].nameProduct)
                                {
                                    idproduct = i + 1;
                                }
                                else
                                {
                                    idproduct = products.Count + 1;
                                }
                            }
                            imageName = $"images/{idproduct}.jpg";
                            if (File.Exists($@"../../Properties/images/{idproduct}.jpg"))
                            {
                                File.Delete($@"../../Properties/images/{idproduct}.jpg");
                            }
                            File.Copy(ofd.FileName, $@"../../Properties/images/{idproduct}.jpg");
                            imagepath = ofd.FileName.ToString();
                            Uri uri = new Uri($"../../Properties/{imagepath}", UriKind.Relative);
                            img.Source = new BitmapImage(uri);
                            MessageBox.Show($"Успешно", "Файл выбран", MessageBoxButton.OK);
                        }
                        finally { imagepath = ofd.FileName.ToString(); }
                    }
                    else
                    {
                        imagepath = ofd.FileName.ToString();
                        try
                        {
                            for (int i = 0; i < products.Count; i++)
                            {
                                if (cbNameProducts.Text == products[i].nameProduct)
                                {
                                    idproduct = i + 1;
                                }
                            }
                            imageName = $"images/{idproduct}.jpg";
                            if (File.Exists($@"../../Properties/images/{idproduct}.jpg"))
                            {
                                File.Delete($@"../../Properties/images/{idproduct}.jpg");
                            }
                            File.Copy(ofd.FileName, $@"../../Properties/images/{idproduct}.jpg");
                            imagepath = ofd.FileName.ToString();
                            Uri uri = new Uri($"../../Properties/{imagepath}", UriKind.Relative);
                            img.Source = new BitmapImage(uri);
                            MessageBox.Show($"Успешно", "Файл выбран", MessageBoxButton.OK);
                        }
                        finally { imagepath = ofd.FileName.ToString();}
                    }
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButton.OK);
                }
            }

        }
    }
}