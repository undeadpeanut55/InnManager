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

namespace InnManager.WpfApp.Windows
{
    /// <summary>
    /// Interaction logic for AddGuestWindow.xaml
    /// </summary>
    public partial class AddGuestWindow : Window
    {
        public AddGuestWindow()
        {
            InitializeComponent();
        }

        public void HandleAddGuestClick(object? sender, RoutedEventArgs e)
        {
            var guest = new InnManager.Guests.Guest()
            {
                FirstName = FirstNameInput.Text, 
                LastName = LastNameInput.Text,
                PhoneNumber = PhoneInput.Text,
                Address = AddressInput.Text,
                Email = EmailInput.Text,
                IDType = (IDType)IDTypeInput.SelectedItem,
                IDNumber = IDNumberInput.Text
            };
        }
    }
}
