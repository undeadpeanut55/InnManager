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
    /// Interaction logic for AddServiceWindow.xaml
    /// </summary>
    public partial class AddServiceWindow : Window
    {
        public AddServiceWindow()
        {
            InitializeComponent();
        }


        public void HandleAddService(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(PriceInput.Text, out var price))
            {


                var service = new InnManager.Services.Service()
                {
                    ServiceName = NameInput.Text,
                    Price = price,
                    Description = DescriptionInput.Text,
                    IsAvailable = AvailableInput.IsChecked ?? false,
                    Category = (InnManager.Enums.ServiceCategory)CategoryInput.SelectedItem
                };

                if (DataContext is InnManager.Hotels.Hotel hotel)
                {
                    hotel.Services.Add(service);

                    Close();
                }
            }
        }
    }
}
