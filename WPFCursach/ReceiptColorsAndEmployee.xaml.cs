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
using System.Windows.Shapes;
using static WPFCursach.Window1;

namespace WPFCursach
{
    /// <summary>
    /// Логика взаимодействия для ReceiptColorsAndEmployee.xaml
    /// </summary>
    public partial class ReceiptColorsAndEmployee : Window
    {
        List <Employees> employees;
        List<PaintingColors> paintingColors;
        public ReceiptColorsAndEmployee()
        {
            InitializeComponent();
        }
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var mainWindow = new Window1
            {
                Visibility = Visibility.Visible
            };
        }

        private void msBoxCB_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new CетьМагазиновСантехникиEntities())
            {
                employees = context.Employees.ToList();
                paintingColors = context.PaintingColors.ToList();
            }

            string[] strings = new string[employees.Count + 1];
            for (int i = 0; i < employees.Count; i++)
            {
                strings[i] = employees[i].nameEmployee;

            }
            cbEmployeeSelect.ItemsSource = strings;

            string[] stringsColors = new string[paintingColors.Count];
            for (int i = 0; i < paintingColors.Count; i++)
            {
                stringsColors[i] = paintingColors[i].namePC;
            }
            cbColorsSelect.ItemsSource = stringsColors;
            btnAccept.Visibility = Visibility.Hidden;
        }


        private void cbEmployeeSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbEmployeeSelect.SelectedIndex != -1 && cbColorsSelect.SelectedIndex!=-1)
            {
                btnAccept.Visibility = Visibility.Visible;
            }
           
        }

        private void cbColorsSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbEmployeeSelect.SelectedIndex != -1 && cbColorsSelect.SelectedIndex != -1)
            {
                btnAccept.Visibility = Visibility.Visible;
            }
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            DataBank.idEmployee = (cbEmployeeSelect.SelectedIndex + 1);
            DataBank.idColor = (cbColorsSelect.SelectedIndex + 1);
            MessageBox.Show("Статус покупки", "Покупка совершена успешно", MessageBoxButton.OK);
            var mainWindow = new Window1
            {
                Visibility = Visibility.Visible
            };
            UseProcedureAddCheck();
        }
        public void UseProcedureAddCheck()
        {
            using (var context = new CетьМагазиновСантехникиEntities())
            {

                context.AddCheck(DataBank.idEmployee, DataBank.idColor, DataBank.nameProductAddCheck);

            }
        }
    }
}
