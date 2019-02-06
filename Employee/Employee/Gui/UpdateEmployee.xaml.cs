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
            ImageSourceConverter a = new ImageSourceConverter();

            bool flag = employee != null;
            txtId.Text = flag ? employee.PublicId : UpdateForm.EMPTY;
            txtPassword.Password = flag ? employee.Password : UpdateForm.EMPTY;
            txtName.Text = flag ? employee.FullName : UpdateForm.EMPTY;
            txtNickName.Text = flag ? employee.NickName : UpdateForm.EMPTY;
            chkGender.IsChecked = flag ? employee.Gender : UpdateForm.UNCHECKED;
            chkMaried.IsChecked = flag ? employee.Married : UpdateForm.UNCHECKED;
            imgAvatar.Source = flag ? UpdateForm.BytesToImage(Employee.Image) : null;
            txtMobie.Text = flag ? employee.Mobie : UpdateForm.EMPTY;
            txtPhone.Text = flag ? employee.Phone : UpdateForm.EMPTY;
            txtEmail.Text = flag ? employee.Email : UpdateForm.EMPTY;
            dateBirthDay.SelectedDate = flag ? employee.BirthDay : UpdateForm.NONDAY;
            txtBirthPlace.Text = flag ? employee.BirthPlace : UpdateForm.EMPTY;
            cmbCity.SelectedItem = flag ? employee.City : UpdateForm.NONITEM;
            txtPersonId.Text = flag ? employee.PersonId : UpdateForm.EMPTY;
            datePersonDay.SelectedDate = flag ? employee.TakenPIDate : UpdateForm.NONDAY;
            txtPersonPlace.Text = flag ? employee.TakenPIPlace : UpdateForm.EMPTY;
            txtNativeLand.Text = flag ? employee.NativeLand : UpdateForm.EMPTY;
            txtAddress.Text = flag ? employee.Address : UpdateForm.EMPTY;
            txtTabernacle.Text = flag ? employee.Tabernacle : UpdateForm.EMPTY;

            cmbTypeStaff.SelectedItem = flag ? employee.TypeStaff : UpdateForm.NONITEM;
            dateStartDay.SelectedDate = flag ? employee.StartDay : UpdateForm.NONDAY;
            cmbDeparment.SelectedItem = flag ? employee.Deparmant : UpdateForm.NONITEM;
            cmbJob.SelectedItem = flag ? employee.Job : UpdateForm.NONITEM;
            cmbPosition.SelectedItem = flag ? employee.Position : UpdateForm.NONITEM;
            txtSalaryBase.Text = flag ? employee.BaseSalary.ToString() : UpdateForm.EMPTY;
            txtSalaryFactor.Text = flag ? employee.FactorySalary.ToString() : UpdateForm.EMPTY;
            txtSalaryAllowwed.Text = flag ? employee.AllowedSalary.ToString() : UpdateForm.EMPTY;
            txtLaborId.Text = flag ? employee.LaborId : UpdateForm.EMPTY;
            dateLaborDay.SelectedDate = flag ? employee.LaborDay : UpdateForm.NONDAY;
            txtLaborPlace.Text = flag ? employee.LaborPlace : UpdateForm.EMPTY;
            txtBankId.Text = flag ? employee.BankId : UpdateForm.EMPTY;
            txtBankName.Text = flag ? employee.Bank : UpdateForm.EMPTY;
            cmbLearning.SelectedItem = flag ? employee.Learning : UpdateForm.NONITEM;
            cmbDegree.SelectedItem = flag ? employee.Deparmant : UpdateForm.NONITEM;
            cmbForeignLanguage.SelectedItem = flag ? employee.ForeignLanguage : UpdateForm.NONITEM;
            cmbComputing.SelectedItem = flag ? employee.Computing : UpdateForm.NONITEM;
            cmbFolk.SelectedItem = flag ? employee.Folk : UpdateForm.NONITEM;
            cmbNationnality.SelectedItem = flag ? employee.Nationnality : UpdateForm.NONITEM;
            cmbReligion.SelectedItem = flag ? employee.Religion : UpdateForm.NONITEM;
        }

        private void toEmployee()
        {
            Employee.PublicId = txtId.Text;
            Employee.Password = txtPassword.Password;
            Employee.FullName = txtName.Text;
            Employee.NickName = txtNickName.Text;
            Employee.Gender = chkGender.IsChecked != null ? chkGender.IsChecked.Value : UpdateForm.UNCHECKED;
            Employee.Married = chkMaried.IsChecked != null ? chkMaried.IsChecked.Value : UpdateForm.UNCHECKED;
            Employee.Image = UpdateForm.ImageToBytes(imgAvatar.Source);
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

        private void activeForm(bool flag = true)
        {
            txtId.IsEnabled = flag;
            txtId.Background = UpdateForm.DefaultBGTextBox;
            txtPassword.IsEnabled = flag;
            txtPassword.Background = UpdateForm.DefaultBGTextBox;
            txtName.IsEnabled = flag;
            txtName.Background = UpdateForm.DefaultBGTextBox;
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
            cmbTypeStaff.Background = UpdateForm.DefaultBGCmb;
            dateStartDay.IsEnabled = flag;
            cmbTypeStaff.Background = UpdateForm.DefaultBGCmb;
            cmbDeparment.IsEnabled = flag;
            cmbDeparment.Background = UpdateForm.DefaultBGCmb;
            cmbJob.IsEnabled = flag;
            cmbJob.Background = UpdateForm.DefaultBGCmb;
            cmbPosition.IsEnabled = flag;
            cmbPosition.Background = UpdateForm.DefaultBGCmb;
            txtSalaryBase.IsEnabled = flag;
            txtSalaryBase.Background = UpdateForm.DefaultBGTextBox;
            txtSalaryFactor.IsEnabled = flag;
            txtSalaryFactor.Background = UpdateForm.DefaultBGTextBox;
            txtSalary.IsEnabled = flag;
            txtSalaryAllowwed.IsEnabled = flag;
            txtSalaryAllowwed.Background = UpdateForm.DefaultBGTextBox;
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
            fileDialog.Filter = "Image (*.jpg,*.jpeg)|*.jpg;*jpeg;";
        }

        private void BtnImage_Click(object sender, RoutedEventArgs e)
        {
            Nullable<bool> code = fileDialog.ShowDialog();
            if(code != null && code == true)
            {
                var bitmap = new BitmapImage(new Uri(fileDialog.FileName));
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

        private void ValidateForm()
        {
            bool focused = false;
            string mess = "";

            if (txtId.Text.Length == 0)
            {
                if(!focused)
                {
                    Keyboard.Focus(txtId);
                    focused = true;
                }
                txtId.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa nhập mã nhân viên.\n";
            } else
            {
                txtId.Background = UpdateForm.DefaultBGTextBox;
            }

            if (txtPassword.Password.Length == 0)
            {
                if (!focused)
                {
                    Keyboard.Focus(txtPassword);
                    focused = true;
                }
                txtPassword.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa nhập mật khẩu.\n";
            }
            else
            {
                txtPassword.Background = UpdateForm.DefaultBGTextBox;
            }

            if (txtName.Text.Length == 0)
            {
                if (!focused)
                {
                    Keyboard.Focus(txtName);
                    focused = true;
                }
                txtName.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa nhập tên nhân viên.\n";
            } else
            {
                txtName.Background = UpdateForm.DefaultBGTextBox;
            }

            if (cmbTypeStaff.SelectedItem == null)
            {
                if (!focused)
                {
                    Keyboard.Focus(cmbTypeStaff);
                    focused = true;
                }
                cmbTypeStaff.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa chọn loại nhân viên.\n";
            } else
            {
                cmbTypeStaff.Background = UpdateForm.DefaultBGCmb;
            }

            if (dateStartDay.SelectedDate == null)
            {
                if (!focused)
                {
                    Keyboard.Focus(dateStartDay);
                    focused = true;
                }
                dateStartDay.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa chọn ngày bắt đầu làm.\n";
            } else
            {
                dateStartDay.Background = UpdateForm.DefaultBGTextBox;
            }

            if (cmbDeparment.SelectedItem == null)
            {
                if (!focused)
                {
                    Keyboard.Focus(cmbDeparment);
                    focused = true;
                }
                cmbDeparment.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa chọn phòng ban.\n";
            } else
            {
                cmbDeparment.Background = UpdateForm.DefaultBGCmb;
            }

            if (cmbJob.SelectedItem == null)
            {
                if (!focused)
                {
                    Keyboard.Focus(cmbJob);
                    focused = true;
                }
                cmbJob.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa chọn công việc.\n";
            } else
            {
                cmbJob.Background = UpdateForm.DefaultBGCmb;
            }

            if (cmbPosition.SelectedItem == null)
            {
                if (!focused)
                {
                    Keyboard.Focus(cmbPosition);
                    focused = true;
                }
                cmbPosition.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa chọn chức vụ.\n";
            } else
            {
                cmbPosition.Background = UpdateForm.DefaultBGCmb;
            }

            if (txtSalaryBase.Text.Length == 0)
            {
                if (!focused)
                {
                    Keyboard.Focus(txtSalaryBase);
                    focused = true;
                }
                txtSalaryBase.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa nhập lương cơ bản.\n";
            } else
            {
                try
                {
                    int salarybase = int.Parse(txtSalaryBase.Text);
                    if (salarybase < 1000)
                    {
                        if (!focused)
                        {
                            Keyboard.Focus(txtSalaryBase);
                            focused = true;
                        }
                        txtSalaryBase.Background = UpdateForm.ErrorBGControl;
                        mess += "Lương cơ bản không được bé hơn 1000.\n";
                    } else
                    {
                        txtSalaryBase.Background = UpdateForm.DefaultBGTextBox;
                    }
                } catch
                {
                    if (!focused)
                    {
                        Keyboard.Focus(txtSalaryBase);
                        focused = true;
                    }
                    txtSalaryBase.Background = UpdateForm.ErrorBGControl;
                    mess += "Lương cơ bản không hợp lệ.\n";
                }
            }

            if (txtSalaryFactor.Text.Length == 0)
            {
                if (!focused)
                {
                    Keyboard.Focus(txtSalaryFactor);
                    focused = true;
                }
                txtSalaryFactor.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa nhập hệ số lương.\n";
            } else
            {
                try
                {
                    double factor = double.Parse(txtSalaryFactor.Text);
                    if (factor < 1.0d)
                    {
                        if (!focused)
                        {
                            Keyboard.Focus(txtSalaryFactor);
                            focused = true;
                        }
                        txtSalaryFactor.Background = UpdateForm.ErrorBGControl;
                        mess += "Hệ số lương không được bé hơn 1.\n";
                    } else
                    {
                        txtSalaryFactor.Background = UpdateForm.DefaultBGTextBox;
                    }
                }
                catch
                {
                    if (!focused)
                    {
                        Keyboard.Focus(txtSalaryFactor);
                        focused = true;
                    }
                    txtSalaryFactor.Background = UpdateForm.ErrorBGControl;
                    mess += "Hệ số lương không hợp lệ.\n";
                }
            }

            if (txtSalaryAllowwed.Text.Length == 0)
            {
                if (!focused)
                {
                    Keyboard.Focus(txtSalaryAllowwed);
                    focused = true;
                }
                txtSalaryAllowwed.Background = UpdateForm.ErrorBGControl;
                mess += "Chưa nhập phụ cấp.\n";
            } else
            {
                try
                {
                    int allowwed = int.Parse(txtSalaryAllowwed.Text);
                    if (allowwed < 0)
                    {
                        if (!focused)
                        {
                            Keyboard.Focus(txtSalaryAllowwed);
                            focused = true;
                        }
                        txtSalaryAllowwed.Background = UpdateForm.ErrorBGControl;
                        mess += "Phụ cấp không hợp lệ.\n";
                    } else
                    {
                        txtSalaryAllowwed.Background = UpdateForm.DefaultBGTextBox;
                    }
                }
                catch
                {
                    if (!focused)
                    {
                        Keyboard.Focus(txtSalaryAllowwed);
                        focused = true;
                    }
                    txtSalaryAllowwed.Background = UpdateForm.ErrorBGControl;
                    mess += "Phụ cấp không hợp lệ.\n";
                }
            }

            if(focused)
            {
                throw new Exception(mess);
            }

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                ValidateForm();

                if (action == ACTION.INSERT)
                {
                    Employee = new Model.Employee();
                    toEmployee();
                    new EmployeeBll().Insert(Employee);

                    MainWindow mainWindow = (MainWindow)Owner;
                    mainWindow.getListEmp().addRow(Employee);
                }
                else if (action == ACTION.EDIT)
                {
                    new EmployeeBll().Update(Employee);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
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
