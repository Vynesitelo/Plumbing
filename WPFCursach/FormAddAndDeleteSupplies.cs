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
    public partial class FormAddAndDeleteSupplies : Form
    {
        List<Products> products;
        List<Supplies> supplies;
        List<Provider> providers;

        public FormAddAndDeleteSupplies()
        {
            InitializeComponent();
        }

        private void FormAddAndDeleteSupplies_Load(object sender, EventArgs e)
        {
            using (var context = new CетьМагазиновСантехникиEntities())
            {
                products = context.Products.ToList();
                supplies = context.Supplies.ToList();
                providers = context.Provider.ToList();

            }
            string[] strings = new string[providers.Count + 1];
            for (int i = 0; i < providers.Count; i++)
            {
                strings[i] = providers[i].nameProvider;

            }
            cbNameProvider.DataSource = strings;
            string[] stringsProducts = new string[products.Count];
            for (int i = 0; i < products.Count; i++)
            {
                stringsProducts[i] = products[i].nameProduct;
            }

            cbProducts.DataSource = stringsProducts;
            string[] stringsSupplies = new string[products.Count];
            for (int i = 0; i < supplies.Count; i++)
            {
                stringsProducts[i] = Convert.ToString(supplies[i].IDSupplie);
            }

            cbSupplies.DataSource = stringsProducts;
            switch (DataBank.paramss)
            {
                case 1:
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    cbNameProvider.Visible = true;
                    cbProducts.Visible = true;
                    cbSupplies.Visible = false;
                    labelSelectIDSupplies.Visible = false;
                    break;
                case 2:
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    cbNameProvider.Visible = false;
                    cbProducts.Visible = false;
                    cbSupplies.Visible = true;
                    labelSelectIDSupplies.Visible = true;
                    break;
                default:
                    return;
            }
        }
        public void UseProcedureAddAndDeleteSupplies()
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

                            context.AddAndDeleteSupplies(DataBank.paramss, cbNameProvider.SelectedIndex+1, cbProducts.SelectedIndex+1, Convert.ToInt32(tbAmount.Text),1);
                        }
                        break;
                    case 2:
                        using (var context = new CетьМагазиновСантехникиEntities())
                        {

                            context.AddAndDeleteSupplies(DataBank.paramss, 1, 1, 1, cbSupplies.SelectedIndex+1);
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
            UseProcedureAddAndDeleteSupplies();
            this.Close();
            AdminWindow form = new AdminWindow();
            form.Show();
        }

        private void FormAddAndDeleteSupplies_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminWindow form = new AdminWindow();
            form.Show();
        }
    }
}
