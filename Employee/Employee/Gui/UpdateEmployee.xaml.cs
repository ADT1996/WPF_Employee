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
using Employee.Model;
using Employee.Util;
using Employee.Bll;

namespace Employee.Gui
{
    /// <summary>
    /// Interaction logic for UpdateEmployee.xaml
    /// </summary>
    public partial class UpdateEmployee : Window
    {

        private Microsoft.Win32.OpenFileDialog fileDialog = new Microsoft.Win32.OpenFileDialog();

        private ACTION action;

        private Model.Employee Employee;

        public UpdateEmployee()
        {
            Init();
            this.action = ACTION.INSERT;
            activeForm(true);
        }

        public UpdateEmployee(Model.Employee employee, int action)
        {
            Init();
            this.action = (ACTION)action;
            Employee = employee;
            if (this.action == ACTION.VIEW)
            {
                activeForm(false);
                
            }
            else
            {
                activeForm(true);
                if (this.action == ACTION.EDIT)
                {
                    txtId.IsEnabled = false;
                    loadForm(Employee);
                } else if (this.action == ACTION.INSERT)
                {
                    loadForm(null);
                }
            }
        }

        private void loadForm(Model.Employee employee)
        {
            bool flag = employee != null;
            txtId.Text = flag ? employee.PublicId : Util_UpdateEmployee.EMPTY;
            txtName.Text = flag ? employee.FullName : Util_UpdateEmployee.EMPTY;
            txtNickName.Text = flag ? employee.NickName : Util_UpdateEmployee.EMPTY;
            chkGender.IsChecked = flag ? employee.Gender : Util_UpdateEmployee.UNCHECKED;
            chkMaried.IsChecked = flag ? employee.Married : Util_UpdateEmployee.UNCHECKED;
            //imgAvatar.Source. = employee != null ?  : null;
            txtMobie.Text = flag ? employee.Mobie : Util_UpdateEmployee.EMPTY;
            txtPhone.Text = flag ? employee.Phone : Util_UpdateEmployee.EMPTY;
            txtEmail.Text = flag ? employee.Email : Util_UpdateEmployee.EMPTY;
            dateBirthDay.SelectedDate = flag ? employee.BirthDay : Util_UpdateEmployee.NONDAY;
            txtBirthPlace.Text = flag ? employee.BirthPlace : Util_UpdateEmployee.EMPTY;
            cmbCity.SelectedItem = flag ? employee.City : Util_UpdateEmployee.NONITEM;
            txtPersonId.Text = flag ? employee.PersonId : Util_UpdateEmployee.EMPTY;
            datePersonDay.SelectedDate = flag ? employee.TakenPIDate : Util_UpdateEmployee.NONDAY;
            txtPersonPlace.Text = flag ? employee.TakenPIPlace : Util_UpdateEmployee.EMPTY;
            txtNativeLand.Text = flag ? employee.NativeLand : Util_UpdateEmployee.EMPTY;
            txtAddress.Text = flag ? employee.Address : Util_UpdateEmployee.EMPTY;
            txtTabernacle.Text = flag ? employee.Tabernacle : Util_UpdateEmployee.EMPTY;

            cmbTypeStaff.SelectedItem = flag ? employee.TypeStaff : Util_UpdateEmployee.NONITEM;
            dateStartDay.SelectedDate = flag ? employee.StartDay : Util_UpdateEmployee.NONDAY;
            cmbDeparment.SelectedItem = flag ? employee.Deparmant : Util_UpdateEmployee.NONITEM;
            cmbJob.SelectedItem = flag ? employee.Job : Util_UpdateEmployee.NONITEM;
            cmbPosition.SelectedItem = flag ? employee.Position : Util_UpdateEmployee.NONITEM;
            txtSalaryBase.Text = flag ? employee.BaseSalary.ToString() : Util_UpdateEmployee.EMPTY;
            txtSalaryFactor.Text = flag ? employee.FactorySalary.ToString() : Util_UpdateEmployee.EMPTY;
            txtSalaryAllowwed.Text = flag ? employee.AllowedSalary.ToString() : Util_UpdateEmployee.EMPTY;
            txtLaborId.Text = flag ? employee.LaborId : Util_UpdateEmployee.EMPTY;
            dateLaborDay.SelectedDate = flag ? employee.LaborDay : Util_UpdateEmployee.NONDAY;
            txtLaborPlace.Text = flag ? employee.LaborPlace : Util_UpdateEmployee.EMPTY;
            txtBankId.Text = flag ? employee.BankId : Util_UpdateEmployee.EMPTY;
            txtBankName.Text = flag ? employee.Bank : Util_UpdateEmployee.EMPTY;
            cmbLearning.SelectedItem = flag ? employee.Learning : Util_UpdateEmployee.NONITEM;
            cmbDegree.SelectedItem = flag ? employee.Deparmant : Util_UpdateEmployee.NONITEM;
            cmbForeignLanguage.SelectedItem = flag ? employee.ForeignLanguage : Util_UpdateEmployee.NONITEM;
            cmbComputing.SelectedItem = flag ? employee.Computing : Util_UpdateEmployee.NONITEM;
            cmbFolk.SelectedItem = flag ? employee.Folk : Util_UpdateEmployee.NONITEM;
            cmbNationnality.SelectedItem = flag ? employee.Nationnality : Util_UpdateEmployee.NONITEM;
            cmbReligion.SelectedItem = flag ? employee.Religion : Util_UpdateEmployee.NONITEM;
        }

        private void toEmployee()
        {
            Employee.PublicId = txtId.Text;
            Employee.FullName = txtName.Text;
            Employee.NickName = txtNickName.Text;
            Employee.Gender = chkGender.IsChecked != null ? chkGender.IsChecked.Value : Util_UpdateEmployee.UNCHECKED;
            Employee.Married = chkMaried.IsChecked != null ? chkMaried.IsChecked.Value : Util_UpdateEmployee.UNCHECKED;
            Employee.Mobie = txtMobie.Text;
            Employee.Phone = txtPhone.Text;
            Employee.Email = txtEmail.Text;
            Employee.BirthDay = dateBirthDay.SelectedDate;
            Employee.BirthPlace = txtBirthPlace.Text;
            Employee.City = (Model.City) cmbCity.SelectedItem;
            Employee.PersonId = txtPersonId.Text;
            Employee.TakenPIDate = dateBirthDay.SelectedDate;
            Employee.TakenPIPlace = txtPersonPlace.Text;
            Employee.NativeLand = txtNativeLand.Text;
            Employee.Address = txtAddress.Text;
            Employee.Tabernacle = txtTabernacle.Text;

            Employee.TypeStaff = (Model.TypeStaff)cmbTypeStaff.SelectedItem;
            Employee.StartDay = dateStartDay.SelectedDate;
            Employee.Deparmant = (Model.Deparmant)cmbDeparment.SelectedItem;
            Employee.Job = (Model.Job)cmbJob.SelectedItem;
            Employee.Position = (Model.Position)cmbPosition.SelectedItem;
            Employee.BaseSalary =  int.Parse(txtSalaryBase.Text);
            Employee.FactorySalary = double.Parse(txtSalaryFactor.Text);
            Employee.AllowedSalary = int.Parse(txtSalaryAllowwed.Text);
            Employee.LaborId = txtLaborId.Text;
            Employee.LaborDay = dateLaborDay.SelectedDate;
            Employee.LaborPlace = txtLaborPlace.Text;
            Employee.BankId = txtBankId.Text;
            Employee.Bank = txtBankName.Text;
            Employee.Learning = (Model.Learning) cmbLearning.SelectedItem;
            Employee.ForeignLanguage = (Model.ForeignLanguage)cmbForeignLanguage.SelectedItem;
            Employee.Computing = (Model.Computing)cmbComputing.SelectedItem;
            Employee.Folk = (Model.Folk)cmbFolk.SelectedItem;
            Employee.Nationnality = (Model.Nationnality)cmbNationnality.SelectedItem;
            Employee.Religion = (Model.Religion)cmbReligion.SelectedItem;
        }

        private void activeForm(bool flag)
        {
            txtId.IsEnabled = flag;
            txtName.IsEnabled = flag;
            txtNickName.IsEnabled = flag;
            chkGender.IsEnabled = flag;
            chkMaried.IsEnabled = flag;
            btnImage.IsEnabled = flag;
            txtMobie.IsEnabled = flag;
            txtPhone.IsEnabled = flag;
            txtEmail.IsEnabled = flag;
            dateBirthDay.IsEnabled = flag;
            txtBirthPlace.IsEnabled = flag;
            cmbCity.IsEnabled = flag;
            txtPersonId.IsEnabled = flag;
            datePersonDay.IsEnabled = flag;
            txtPersonPlace.IsEnabled = flag;
            txtNativeLand.IsEnabled = flag;
            txtAddress.IsEnabled = flag;
            txtTabernacle.IsEnabled = flag;

            cmbTypeStaff.IsEnabled = flag;
            dateStartDay.IsEnabled = flag;
            cmbDeparment.IsEnabled = flag;
            cmbJob.IsEnabled = flag;
            cmbPosition.IsEnabled = flag;
            txtSalaryBase.IsEnabled = flag;
            txtSalaryFactor.IsEnabled = flag;
            txtSalary.IsEnabled = flag;
            txtSalaryAllowwed.IsEnabled = flag;
            txtLaborId.IsEnabled = flag;
            dateLaborDay.IsEnabled = flag;
            txtLaborPlace.IsEnabled = flag;
            txtBankId.IsEnabled = flag;
            txtBankName.IsEnabled = flag;
            cmbLearning.IsEnabled = flag;
            cmbDegree.IsEnabled = flag;
            cmbForeignLanguage.IsEnabled = flag;
            cmbComputing.IsEnabled = flag;
            cmbFolk.IsEnabled = flag;
            cmbNationnality.IsEnabled = flag;
            cmbReligion.IsEnabled = flag;

            if(flag)
            {
                btnUpdate.Visibility = Visibility.Visible;
                btnCancel.Visibility = Visibility.Visible;

                btnInsert.Visibility = Visibility.Hidden;
                btnEdit.Visibility = Visibility.Hidden;
                btnDelete.Visibility = Visibility.Hidden;
                btnPrint.Visibility = Visibility.Hidden;
                btnClose.Visibility = Visibility.Hidden;
            }
        }

        private void Init()
        {
            InitializeComponent();
            fileDialog.Filter = "Image (*.jpg,*.jpeg,*.png,*.bmp)|*.jpg;*jpeg;*.png;*.bmp";
        }

        private void BtnImage_Click(object sender, RoutedEventArgs e)
        {
            Nullable<bool> code = fileDialog.ShowDialog();
            if(code != null && code == true)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(fileDialog.FileName);
                bitmap.EndInit();
                imgAvatar.Source = bitmap;
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(Employee != null)
            {
                MessageBoxResult code = MessageBox.Show("Đồng ý xoá nhân viên " + Employee.PublicId + "?", "", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Cancel);
                if (code == MessageBoxResult.OK)
                {
                    new EmployeeBll().Delete(Employee);
                    ((MainWindow)Owner).getListEmp().removeRow(Employee);
                }
            } else {
                MessageBox.Show("Không thể xoá nhân viên","",MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            action = ACTION.EDIT;
            loadForm(Employee);
            activeForm(true);
            txtId.IsEnabled = false;
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            action = ACTION.INSERT;
            loadForm(null);
            activeForm(true);
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (action == ACTION.INSERT)
            {
                Employee = new Model.Employee();
                toEmployee();
                new EmployeeBll().Insert(Employee);

                MainWindow mainWindow = (MainWindow)Owner;
                mainWindow.getListEmp().addRow(Employee);
            } else if(action == ACTION.EDIT)
            {
                new EmployeeBll().Update(Employee);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (Employee == null)
            {
                Close();
            } else {
                activeForm(false);
                loadForm(Employee);
            }
        }
    }
}
