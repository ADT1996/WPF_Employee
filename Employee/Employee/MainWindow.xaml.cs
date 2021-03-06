﻿using System;
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

namespace Employee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Gui.ListEmployee getListEmp() => listEmp;

        public MainWindow() => InitializeComponent();

        private void BtnAddEmp_Click(object sender, RoutedEventArgs e)
        {
            Gui.UpdateEmployee update = new Gui.UpdateEmployee();
            update.Owner = this;
            update.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            switch(menuItem.Name)
            {
                case "itemCity":
                    MessageBox.Show("Thành phố");
                    break;
                case "itemFolk":
                    MessageBox.Show("Dân tộc");
                    break;
                case "itemReligion":
                    MessageBox.Show("Tôn giáo");
                    break;
            }
        }
    }
}
