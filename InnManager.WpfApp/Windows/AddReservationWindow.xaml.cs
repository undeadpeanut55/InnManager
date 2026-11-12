using InnManager.Guests;
using InnManager.Hotels;
using InnManager.Reservations;
using InnManager.Rooms;
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
    /// Interaction logic for AddReservationWindow.xaml
    /// </summary>
    public partial class AddReservationWindow : Window
    {
        public AddReservationWindow()
        {
            InitializeComponent();
        }

        public void HandleAddAreservation(object? sender, RoutedEventArgs e)
        {
            if (GuestInput.SelectedItem is Guest guest
                && int.TryParse(NumberOfGuestsInput.Text, out int numGuests)
                && RoomInput.SelectedItem is Room room)
            {


                var res = new Reservation()
                {
                    GuestName = guest.FirstName + " " + guest.LastName,
                    NumberOfGuests = numGuests,
                    RoomNumber = room.RoomNumber,
                    CheckInDate = CheckInDateInput.SelectedDate ?? DateTime.Now,
                    CheckOutDate = CheckOutDateInput.SelectedDate ?? DateTime.Now,
                    ReservationNumber = guest.GuestID + "-" + room.RoomNumber
                };

                if(!string.Equals(StatusInput.SelectedValue.ToString(), "Pending"))
                {
                    res.IsConfirmed = true;
                }

                if(DataContext is Hotel hotel)
                {
                    hotel.Reservations.Add(res);
                }

                Close();
            }
        }
        
    }
}
