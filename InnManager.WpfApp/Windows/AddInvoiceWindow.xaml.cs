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

        public void HandleReservationSelected(object sender, RoutedEventArgs e)
        {

        }



        public void HandleCreateInvoice(object? sender, RoutedEventArgs e)
        {



            var invoice = new InnManager.Billing.Invoice()
            {

            };


        }
    }
}
