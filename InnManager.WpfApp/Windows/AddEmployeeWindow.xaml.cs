using InnManager.Hotels;
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
using System.Windows.Shapes;

namespace InnManager.WpfApp.Windows
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
            StatusInput.ItemsSource = new List<string> { "Active", "Inactive" };
        }

        public void HandleAddEmployeeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Hotel hotel)
            {

                if (PositionInput.SelectedItem is Enums.EmployeePosition position)
                {

                    var employee = new Employees.Employee
                    {
                        FirstName = FirstNameInput.Text,
                        LastName = LastNameInput.Text,
                        Email = EmailInput.Text,
                        PhoneNumber = PhoneInput.Text,
                        Position = position,
                        HireDate = HireDateInput.SelectedDate ?? DateTime.Now,
                        EmployeeID = ""
                    };

                    if(string.Equals((string)StatusInput.SelectedItem, "Active"))
                    {
                        employee.IsActive = true;
                    }else employee.IsActive = false;

                    hotel.Employees.Add(employee);


                    Close();
                }
            }
        }
    }
}
