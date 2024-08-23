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

namespace WPFCursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<JobTitle> authorizationData;

            using (var context = new CетьМагазиновСантехникиEntities())
            {
                authorizationData = context.JobTitle.ToList();

            }

            var selectedTitle = authorizationData.Where(item => item.loginJT == textboxLogin.Text && item.passwordJT == textboxPassword.Text).FirstOrDefault();

            if (selectedTitle == null)
            {
                MessageBox.Show("Статус", "Неверный логин или пароль", MessageBoxButton.OK);
                return;
            }
            else if(selectedTitle.IDJT == 1)
            {
                DataBank.IDJobTitle = selectedTitle.IDJT;
                MessageBox.Show("Статус", "Вы успешно авторизировались как администратор", MessageBoxButton.OK);
                Visibility = Visibility.Hidden;
                var mainWindow = new Window1
                {
                    Visibility = Visibility.Visible
                };
            }

            else if(selectedTitle.IDJT == 2)
            {
                DataBank.IDJobTitle = selectedTitle.IDJT;
                MessageBox.Show("Статус", "Вы успешно авторизировались как сотрудник", MessageBoxButton.OK);
                Visibility = Visibility.Hidden;
                var mainWindow = new Window1
                {
                    Visibility = Visibility.Visible
                };
            }
        }

        private void Button_ClickEnterForGuest(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            var mainWindow = new Window1
            {
                Visibility = Visibility.Visible
            };
        }

    }

}