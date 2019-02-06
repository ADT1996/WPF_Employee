using Employee.Bll;
using Employee.Dal;
using Employee.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Employee.Gui
{
    /// <summary>
    /// Interaction logic for UpdateCustomer.xaml
    /// </summary>
    public partial class UpdateCustomer : Window
    {
        private Customer customer;

        private ACTION action;

        private void ActiveForm(bool flag = true)
        {
            txtName.IsEnabled = flag;
            chkGender.IsEnabled = flag;
            chkMaried.IsEnabled = flag;
            txtMobie.IsEnabled = flag;
            txtPhone.IsEnabled = flag;
            txtEmail.IsEnabled = flag;
            dateBirthDay.IsEnabled = flag;
            txtBirthPlace.IsEnabled = flag;
            cmbCity.IsEnabled = flag;
            txtPersonId.IsEnabled = flag;
            txtPersonPlace.IsEnabled = flag;
            datePersonDay.IsEnabled = flag;
            txtAddress.IsEnabled = flag;
            txtTabernacle.IsEnabled = flag;
            txtNativeLand.IsEnabled = flag;

            if (flag)
            {
                btnCancel.Visibility = Visibility.Visible;
                btnSave.Visibility = Visibility.Visible;

                btnInsert.Visibility = Visibility.Hidden;
                btnEdit.Visibility = Visibility.Hidden;
                btnDelete.Visibility = Visibility.Hidden;
                btnPrint.Visibility = Visibility.Hidden;
                btnClose.Visibility = Visibility.Hidden;
            } else
            {
                btnCancel.Visibility = Visibility.Hidden;
                btnSave.Visibility = Visibility.Hidden;

                btnInsert.Visibility = Visibility.Visible;
                btnEdit.Visibility = Visibility.Visible;
                btnDelete.Visibility = Visibility.Visible;
                btnPrint.Visibility = Visibility.Visible;
                btnClose.Visibility = Visibility.Visible;

            }
        }

        private void LoadForm(Customer customer = null)
        {
            bool flag = customer != null;

            txtName.Text = flag ? customer.FullName : UpdateForm.EMPTY;
            chkGender.IsChecked = flag ? customer.Gender : UpdateForm.UNCHECKED;
            chkMaried.IsChecked = flag ? customer.Married : UpdateForm.UNCHECKED;
            txtMobie.Text = flag ? customer.Mobie : UpdateForm.EMPTY;
            txtPhone.Text = flag ? customer.Phone : UpdateForm.EMPTY;
            txtEmail.Text = flag ? customer.Email : UpdateForm.EMPTY;
            txtPersonId.Text = flag ? customer.PersonId : UpdateForm.EMPTY;
            txtPersonPlace.Text = flag ? customer.TakenPIPlace : UpdateForm.EMPTY;
            datePersonDay.SelectedDate = flag ? customer.TakenPIDate : UpdateForm.NONDAY;
            dateBirthDay.SelectedDate = flag ? customer.BirthDay : UpdateForm.NONDAY;
            txtBirthPlace.Text = flag ? customer.BirthPlace : UpdateForm.EMPTY;
            txtNativeLand.Text = flag ? customer.NativeLand : UpdateForm.EMPTY;
            txtAddress.Text = flag ? customer.Address : UpdateForm.EMPTY;
            txtTabernacle.Text = flag ? customer.Tabernacle : UpdateForm.EMPTY;

        }

        private void ValidForm()
        {
            bool focused = false;

            string mess = "";

            if(txtName.Text.Trim().Length == 0)
            {
                if(!focused)
                {
                    Keyboard.Focus(txtName);
                    focused = true;
                }
                txtName.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa nhập tên khách hàng.\n";
            } else
            {
                txtName.Background = UpdateForm.DefaultBGTextBox;
            }

            if(focused)
            {
                throw new Exception(mess);
            }
        }

        private void ToCustomer()
        {
            if (action == ACTION.INSERT) customer = new Customer();

            customer.FullName = txtName.Text;
            customer.Gender = chkGender.IsChecked != null ? (bool)chkGender.IsChecked : false;
            customer.Married = chkMaried.IsChecked != null ? (bool)chkMaried.IsChecked : false;
            customer.Mobie = txtMobie.Text;
            customer.Phone = txtPhone.Text;
            customer.Email = txtEmail.Text;
            customer.BirthDay = dateBirthDay.SelectedDate;
            customer.BirthPlace = txtBirthPlace.Text;
            customer.City = (City)cmbCity.SelectedItem;
            customer.PersonId = txtPersonId.Text;
            customer.TakenPIPlace = txtPersonPlace.Text;
            customer.TakenPIDate = datePersonDay.SelectedDate;
            customer.Address = txtAddress.Text;
            customer.Tabernacle = txtTabernacle.Text;
            customer.NativeLand = txtNativeLand.Text;
        }

        public UpdateCustomer()
        {
            InitializeComponent();
            action = ACTION.INSERT;
            ActiveForm();
        }

        public UpdateCustomer(Customer customer,int action)
        {
            InitializeComponent();
            this.customer = customer;
            this.action = (ACTION) action;
            ActiveForm(this.action != ACTION.VIEW);
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(customer != null)
            {
                MessageBoxResult result = MessageBox.Show("Đồng ý xoá khách hàng " + customer.Id + "?",
                "", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.OK);

                if (result == MessageBoxResult.OK)
                {
                    new CustomerDal().Delete(customer);
                    Close();
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            action = ACTION.EDIT;
            LoadForm(customer);
            ActiveForm();
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            action = ACTION.INSERT;
            LoadForm();
            ActiveForm();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ValidForm();
                if (action == ACTION.INSERT)
                {
                    ToCustomer();
                    customer.CreatedByEmployeeId = ProgramVariable.Employee.Id;
                    customer.CreatedDate = new DateTime();
                    new CustomerBll().Insert(customer);
                }
                else if (action == ACTION.EDIT)
                {
                    ToCustomer();
                    customer.LastEditedByEmployeeId = ProgramVariable.Employee.Id;
                    customer.LastEditedDate = new DateTime();
                    new CustomerBll().Update(customer);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            if(customer != null)
            {
                txtName.Background = UpdateForm.DefaultBGTextBox;

                LoadForm(customer);
                ActiveForm(false);
            } else
            {
                Close();
            }
        }
    }
}
