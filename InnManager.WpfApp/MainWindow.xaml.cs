using System.Collections.Specialized;
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

namespace InnManager.WpfApp
{




    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// A helper enum for displaying the proper control
        /// </summary>
        private enum CurrentlyDisplayed
        {
            Dashboard,
            Employees,
            Guests,
            Housekeeping,
            Invoices,
            Payments,
            Reports,
            Reservations,
            Rooms,
            Services,
            Settings
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = new Hotels.Hotel();
        }

        /// <summary>
        /// Helper value for dealing with the display
        /// </summary>
        private CurrentlyDisplayed Display = CurrentlyDisplayed.Dashboard;

        /// <summary>
        /// Handles the switching display to the dashboard menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToDashboard(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            DashboardDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Dashboard;
        }

        /// <summary>
        /// Handles the switching display to the employees menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToEmployees(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            EmployeesDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Employees;
        }

        /// <summary>
        /// Handles the switching display to the guests menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToGuests(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            GuestsDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Guests;
        }

        /// <summary>
        /// Handles the switching display to the housekeeping menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToHousekeeping(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            HousekeepingDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Housekeeping;
        }

        /// <summary>
        /// Handles the switching display to the invoices menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToInvoices(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            InvoicesDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Invoices;
        }

        /// <summary>
        /// Handles the switching display to the payments menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToPayments(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            PaymentsDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Payments;
        }

        /// <summary>
        /// Handles the switching display to the reports menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToReports(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            ReportsDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Reports;
        }

        /// <summary>
        /// Handles the switching display to the reservations menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToReservations(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            ReservationsDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Reservations;
        }

        /// <summary>
        /// Handles the switching display to the rooms menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToRooms(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            RoomsDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Rooms;
        }

        /// <summary>
        /// Handles the switching display to the services menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToServices(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: break;
                case CurrentlyDisplayed.Settings: SettingsDisplay.Visibility = Visibility.Hidden; break;
            }
            ServicesDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Services;
        }

        /// <summary>
        /// Handles the switching display to the settings menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleSwitchToSettings(object sender, RoutedEventArgs e)
        {
            switch (Display)
            {
                case CurrentlyDisplayed.Dashboard: DashboardDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Employees: EmployeesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Guests: GuestsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Housekeeping: HousekeepingDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Invoices: InvoicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Payments: PaymentsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reports: ReportsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Reservations: ReservationsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Rooms: RoomsDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Services: ServicesDisplay.Visibility = Visibility.Hidden; break;
                case CurrentlyDisplayed.Settings: break;
            }
            SettingsDisplay.Visibility = Visibility.Visible;
            Display = CurrentlyDisplayed.Settings;
        }
    }
}