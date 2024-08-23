using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;

namespace WPFCursach
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        List<Employees> employees;
        List<Supplies> supplies;
        List<Provider> providers;

        DataTable dataTable = new DataTable();

        public AdminWindow()
        {
            InitializeComponent();
            dataTable.Columns.Add("qwt", typeof(int));
            
        }


        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        private void GridInit()
        {
            using (var context = new CетьМагазиновСантехникиEntities())
            {
                employeeDataGrid.ItemsSource = ToDataTable(context.Employees.ToList()).DefaultView;
            }
            using (var context = new CетьМагазиновСантехникиEntities())
            {
                suppliesDataGrid.ItemsSource = ToDataTable(context.Supplies.ToList()).DefaultView;
            }
            using (var context = new CетьМагазиновСантехникиEntities())
            {
                providerDataGrid.ItemsSource = ToDataTable(context.Provider.ToList()).DefaultView;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GridInit();
        }

        private void addSupplie_Click(object sender, RoutedEventArgs e)
        {
            DataBank.paramss = 1;
            this.Close();
            FormAddAndDeleteSupplies form = new FormAddAndDeleteSupplies();
            form.Show();
        }

        private void editSupplie_Click(object sender, RoutedEventArgs e)
        {
            DataBank.paramss = 2;
            this.Close();
            FormAddAndDeleteSupplies form = new FormAddAndDeleteSupplies();
            form.Show();
        }

        private void deleteSupplie_Click(object sender, RoutedEventArgs e)
        {
            DataBank.paramss = 3;
            this.Close();
            FormAddAndDeleteSupplies form= new FormAddAndDeleteSupplies();
            form.Show();
        }

        private void addEmployee_Click(object sender, RoutedEventArgs e)
        {
            DataBank.paramss = 1;
            this.Close();
            FormAddEditAndDeleteEmployee form = new FormAddEditAndDeleteEmployee();
            form.Show();
        }

        private void editEmployee_Click(object sender, RoutedEventArgs e)
        {
            DataBank.paramss = 2;
            this.Close();
            FormAddEditAndDeleteEmployee form = new FormAddEditAndDeleteEmployee();
            form.Show();
        }

        private void deleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            DataBank.paramss = 3;
            this.Close();
            FormAddEditAndDeleteEmployee form = new FormAddEditAndDeleteEmployee();
            form.Show();
        }

        private void addProvider_Click(object sender, RoutedEventArgs e)
        {
            DataBank.paramss = 1;
            this.Close();
            FormAddEditAndDeleteProviders form = new FormAddEditAndDeleteProviders();
            form.Show();
        }

        private void editProvider_Click(object sender, RoutedEventArgs e)
        {
            DataBank.paramss = 2;
            this.Close();
            FormAddEditAndDeleteProviders form = new FormAddEditAndDeleteProviders();
            form.Show();
        }

        private void deleteProvider_Click(object sender, RoutedEventArgs e)
        {
            DataBank.paramss = 3;
            this.Close();
            FormAddEditAndDeleteProviders form = new FormAddEditAndDeleteProviders();
            form.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window1 form = new Window1();
            form.Show();
        }
    }
}
