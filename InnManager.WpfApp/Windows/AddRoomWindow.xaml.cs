using InnManager.Enums;
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

namespace InnManager.WpfApp
{
    /// <summary>
    /// Interaction logic for AddRoomWindow.xaml
    /// </summary>
    public partial class AddRoomWindow : Window
    {
        public AddRoomWindow()
        {
            InitializeComponent();
        }





        public void HandleAddRoom(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(FloorInput.Text, out int floorNum) 
                && decimal.TryParse(RateInput.Text, out decimal rate) 
                && int.TryParse(CapacityInput.Text, out int capacity))
            {




                if (DataContext is InnManager.Hotels.Hotel hotel)
                {
                    var r = new InnManager.Rooms.Room()
                    {
                        RoomNumber = RoomNumberInput.Text,
                        RoomType = (RoomType)RoomTypeInput.SelectedItem,
                        Floor = floorNum,
                        NightlyRate = rate,
                        Capacity = capacity,
                        Status = (RoomStatus)StatusInput.SelectedItem,
                        IsClean = IsCleanCheckBox.IsChecked ?? false,
                        HasBalcony = HasBalconyCheckBox.IsChecked ?? false
                    };
                    r.PropertyChanged += hotel.HandleRoomPropertyChange;
                    hotel.Rooms.Add(r);
                  this.Close();
                }
            }

        }

    }
}
