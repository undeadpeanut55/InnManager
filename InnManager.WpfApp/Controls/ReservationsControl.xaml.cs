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
    /// Interaction logic for ReservationsControl.xaml
    /// </summary>
    public partial class ReservationsControl : UserControl
    {
        public ReservationsControl()
        {
            InitializeComponent();
        }

        public void HandleAddReservationClick(object? sender, RoutedEventArgs e)
        {
            var AddRes = new AddReservationWindow();
            AddRes.DataContext = DataContext;
            AddRes.ShowDialog();
        }
    }
}
