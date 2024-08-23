using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WPFCursach
{
    public partial class FormAddEditAndDeleteEmployee : Form
    {
        List<Employees> employees;
        List<Categories> categories;
        List<Stores> stores;
        public FormAddEditAndDeleteEmployee()
        {
            InitializeComponent();
        }
        string nameEmployee = null;
        string phoneEmployee = null;
        string adressEmployee = null;
        string idStoreEmployee = null;
        string expEmployee = null;
        string idCategorie = null;
        private void FormAddEditAndDeleteEmployee_Load(object sender, EventArgs e)
        {
            using (var context = new CетьМагазиновСантехникиEntities())
            {
                employees = context.Employees.ToList();
                categories = context.Categories.ToList();
                stores = context.Stores.ToList();
            }

            string[] strings = new string[categories.Count + 1];
            for (int i = 0; i < categories.Count; i++)
            {
                strings[i] = categories[i].nameCategories;

            }
            cbCategories.DataSource = strings;
            string[] stringsEmployee = new string[employees.Count];
            for (int i = 0; i < employees.Count; i++)
            {
                stringsEmployee[i] = employees[i].nameEmployee;
            }

            cbNameEmployee.DataSource = stringsEmployee;


            string[] stringsStores = new string[stores.Count];
            for (int i = 0; i < stores.Count; i++)
            {
                stringsStores[i] = stores[i].adressStore;
            }

            cbStore.DataSource = stringsStores;
            switch (DataBank.paramss)
            {
                case 1:
                    labelEnterNameEmployee.Visible = true;
                    labelSelectEmployee.Visible = false;
                    tbNameEmployee.Visible = true;
                    cbNameEmployee.Visible = false;
                    break;
                case 2:
                    labelEnterNameEmployee.Visible = false;
                    labelSelectEmployee.Visible = true;
                    tbNameEmployee.Visible = false;
                    cbNameEmployee.Visible = true;
                    break;
                case 3:
                    labelEnterNameEmployee.Visible = false;
                    labelSelectEmployee.Visible = true;
                    tbNameEmployee.Visible = false;
                    cbNameEmployee.Visible = true;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    tbPhone.Visible = false;
                    tbExp.Visible = false;
                    tbAdress.Visible = false;
                    cbCategories.Visible = false;
                    cbStore.Visible = false;
                    break;
                default:
                    return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void UseProcedureAddEditAndDeleteEmployees()
        {


            try
            {
                //nameEmployee = tb.Text;
                //phoneEmployee = tbPriceProduct.Text;
                //adressEmployee = tbPurchasePriceProduct.Text;
                //expEmployee = tbAmountInStore.Text;
                switch (DataBank.paramss)
                {
                    case 1:
                        using (var context = new CетьМагазиновСантехникиEntities())
                        {

                            context.AddEditAndDeleteEmployees(DataBank.paramss, tbNameEmployee.Text, tbPhone.Text, tbAdress.Text, Convert.ToInt32(tbExp.Text), Convert.ToInt32(cbStore.SelectedIndex + 1), (cbCategories.SelectedIndex + 1));
                        }
                        break;
                    case 2:
                        using (var context = new CетьМагазиновСантехникиEntities())
                        {

                            context.AddEditAndDeleteEmployees(DataBank.paramss, cbNameEmployee.Text, tbPhone.Text, tbAdress.Text, Convert.ToInt32(tbExp.Text), Convert.ToInt32(cbStore.SelectedIndex + 1), (cbCategories.SelectedIndex + 1));
                        }
                        break;
                    case 3:
                        using (var context = new CетьМагазиновСантехникиEntities())
                        {
                            context.AddEditAndDeleteEmployees(DataBank.paramss, cbNameEmployee.Text, "", "", 1, 1, 1);
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

        private void acceptButton_Click(object sender, EventArgs e)
        {
            UseProcedureAddEditAndDeleteEmployees();
            this.Close();
            AdminWindow form = new AdminWindow();
            form.Show();
        }

        private void cbNameEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNameEmployee.SelectedIndex != 0)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if (cbNameEmployee.Text == employees[i].nameEmployee)
                    {
                        tbPhone.Text = Convert.ToString(employees[i].phoneEmployee + 1);
                        tbExp.Text = Convert.ToString(employees[i].experienceEmployee + 1);
                        tbAdress.Text = Convert.ToString(employees[i].adressEmployee + 1);
                        cbCategories.SelectedIndex = Convert.ToInt32(employees[i].IDCategoriesEmployee);
                        cbStore.SelectedIndex = Convert.ToInt32(employees[i].IDStoreEmployee);
                    }
                }
            }
        }

        private void FormAddEditAndDeleteEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminWindow form = new AdminWindow();
            form.Show();
        }
    }
}
