using Employee.Bll;
using Employee.Util;
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

namespace Employee
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            Model.Employee employee = new EmployeeBll().Select(txtId.Text.Trim(),txtPassword.Password.Trim());
            if(employee != null)
            {
                ProgramVariable.Employee = employee;
                new MainWindow().Visibility = Visibility.Visible;
                Close();
            } else
            {
                MessageBox.Show("Mã nhân viên hoặc mật khẩu không đúng. Vui lòng nhập lại.", "Đăng nhập thất bại",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
