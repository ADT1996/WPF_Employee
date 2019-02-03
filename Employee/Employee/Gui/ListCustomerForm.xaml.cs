using Employee.Model;
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

namespace Employee.Gui
{
    /// <summary>
    /// Interaction logic for ListCustomerForm.xaml
    /// </summary>
    public partial class ListCustomerForm : UserControl
    {
        public ListCustomerForm()
        {
            InitializeComponent();
        }

        private void DtgCustomer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Customer customer = (Customer) dtgCustomer.SelectedItem;
            if (customer != null)
            {
                UpdateCustomer update = new UpdateCustomer();
                update.Owner = (Window)this.Parent;
                update.ShowDialog();
            } else
            {
                e.Handled = true;
            }
        }
    }
}
