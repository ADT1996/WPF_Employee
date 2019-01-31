using Employee.Bll;
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
    /// Interaction logic for ListEmployee.xaml
    /// </summary>
    public partial class ListEmployee : UserControl
    {
        private ICollection<Model.Employee> Employees
        {
            get
            {
                return new EmployeeBll().All();
            }
        }

        public ListEmployee()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        public void addRow(Model.Employee employee)
        {
            dtgEmp.Items.Add(employee);
        }

        public void removeRow(Model.Employee employee)
        {
            dtgEmp.Items.Remove(employee);
        }
    }
}
