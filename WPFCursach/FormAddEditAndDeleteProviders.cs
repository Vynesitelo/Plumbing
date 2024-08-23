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
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace WPFCursach
{
    public partial class FormAddEditAndDeleteProviders : Form
    {
        List<Provider> providers;
        public FormAddEditAndDeleteProviders()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            UseProcedureAddEditAndDeleteProviders();
            this.Close();
            AdminWindow form = new AdminWindow();
            form.Show();
        }

        private void FormAddEditAndDeleteProviders_Load(object sender, EventArgs e)
        {
            using (var context = new CетьМагазиновСантехникиEntities())
            {
                providers = context.Provider.ToList();
            }

            string[] strings = new string[providers.Count + 1];
            for (int i = 0; i < providers.Count; i++)
            {
                strings[i] = providers[i].nameProvider;

            }
            cbNameProvider.DataSource = strings;
            switch (DataBank.paramss)
            {
                case 1:
                    labelNameProvider.Visible = true;
                    tbNameProvider.Visible = true;
                    labelCBProvider.Visible = false;
                    cbNameProvider.Visible = false;
                    break;
                case 2:
                    labelNameProvider.Visible = false;
                    tbNameProvider.Visible = false;
                    labelCBProvider.Visible = true;
                    cbNameProvider.Visible = true;
                    break;
                case 3:
                    labelCBProvider.Visible = true;
                    cbNameProvider.Visible = true;
                    labelNameProvider.Visible = false;
                    tbNameProvider.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    tbPhoneProvider.Visible = false;
                    tbContactDetailsProvider.Visible = false;
                    break;
                default:
                    return;
            }
        }
        public void UseProcedureAddEditAndDeleteProviders()
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

                            context.AddEditAndDeleteProviders(DataBank.paramss, tbNameProvider.Text, tbContactDetailsProvider.Text,  tbPhoneProvider.Text);
                        }
                        break;
                    case 2:
                        using (var context = new CетьМагазиновСантехникиEntities())
                        {

                            context.AddEditAndDeleteProviders(DataBank.paramss, cbNameProvider.Text, tbContactDetailsProvider.Text, tbPhoneProvider.Text);
                        }
                        break;
                    case 3:
                        using (var context = new CетьМагазиновСантехникиEntities())
                        {
                            context.AddEditAndDeleteProviders(DataBank.paramss, cbNameProvider.Text, "", "");
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

        private void cbNameProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNameProvider.SelectedIndex != 0)
            {
                for (int i = 0; i < providers.Count; i++)
                {
                    if (cbNameProvider.Text == providers[i].nameProvider)
                    {
                        tbContactDetailsProvider.Text = Convert.ToString(providers[i].contactDetailsProvider + 1);
                        tbPhoneProvider.Text = Convert.ToString(providers[i].phoneProvider + 1);
                    }
                }
            }
        }

        private void FormAddEditAndDeleteProviders_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminWindow form = new AdminWindow();
            form.Show();
        }
    }
}
