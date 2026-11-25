using InnManager.WpfApp.Windows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InnManager.WpfApp.Controls
{
    /// <summary>
    /// Interaction logic for EmployeesControl.xaml
    /// </summary>
    public partial class EmployeesControl : UserControl
    {
        public EmployeesControl()
        {
            InitializeComponent();
        }

        public void HandleNewEmployeeClick(object? sender, RoutedEventArgs e)
        {
            var empWin = new AddEmployeeWindow();
            empWin.DataContext = DataContext;
            empWin.ShowDialog();
        }
    }
}
