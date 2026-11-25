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
    /// Interaction logic for AddHousekeepingWindow.xaml
    /// </summary>
    public partial class AddHousekeepingWindow : Window
    {
        public AddHousekeepingWindow()
        {
            InitializeComponent();
            StatusInput.ItemsSource = new List<string> { "Completed", "Not Completed" };
        }

        public void HandleAddTaskClick(object? sender, RoutedEventArgs e)
        {
            if (DataContext is Hotels.Hotel hotel)
            {
                if (RoomInput.SelectedItem is Rooms.Room room
                    && EmployeeInput.SelectedItem is Employees.Employee employee)
                {
                    var task = new Housekeeping.HousekeepingTask
                    {
                        Description = DescriptionInput.Text,
                        RoomNumber = room.RoomNumber,
                        ScheduledDate = DateInput.SelectedDate ?? DateTime.Now,
                        AssignedStaff = employee.FirstName + " " + employee.LastName
                    };

                    if (StatusInput.SelectedIndex == 1)
                    {
                        task.IsCompleted = false;
                    }
                    else task.IsCompleted = true;

                    hotel.HousekeepingTasks.Add(task);
                }



                Close();
            }
        }
    }
}
