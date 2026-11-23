using InnManager.Billing;
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
    /// Interaction logic for AddInvoiceWindow.xaml
    /// </summary>
    public partial class AddInvoiceWindow : Window
    {
        public AddInvoiceWindow()
        {
            InitializeComponent();
        }

        public void HandleReservationSelected(object? sender, RoutedEventArgs e)
        {
            if (ReservationInput.SelectedItem is InnManager.Reservations.Reservation res && 
                DataContext is Hotel hotel)
            {
                List<InnManager.Guests.Guest> guestList = new List<Guests.Guest>();
                foreach(InnManager.Guests.Guest guest in hotel.Guests)
                {
                    if(string.Equals(guest.FirstName +" " +guest.LastName, res.GuestName))
                    {
                        guestList.Add(guest);
                    }
                }
                DueDateInput.SelectedDate = res.CheckOutDate;
                InvoiceDateInput.SelectedDate = res.CheckInDate;
                GuestInput.ItemsSource = guestList;
            }
        }



        public void HandleCreateInvoice(object? sender, RoutedEventArgs e)
        {


            if (DataContext is Hotel hotel)
            {
                var guest = (InnManager.Guests.Guest)GuestInput.SelectedItem;
                var res = (InnManager.Reservations.Reservation)ReservationInput.SelectedItem; 
                var invoice = new InnManager.Billing.Invoice()
                {
                    InvoiceNumber = "INV-" + res.ReservationNumber.Substring(4),
                    InvoiceDate = InvoiceDateInput.SelectedDate ?? DateTime.Now,
                    GuestName = guest.FirstName+" "+guest.LastName,
                    RoomNumber = res.RoomNumber,
                    DueDate = DueDateInput.SelectedDate ?? DateTime.Now,
                };
                invoice.BillingRecords.Add(new Charge {Category = Enums.ChargeCategory.Room, Amount = res.TotalAmount, IsProcessed=true});
                hotel.Invoices.Add(invoice);
                Close();
            }


        }

    }
}
