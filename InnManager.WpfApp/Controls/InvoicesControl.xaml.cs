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
    /// Interaction logic for InvoicesControl.xaml
    /// </summary>
    public partial class InvoicesControl : UserControl
    {
        public InvoicesControl()
        {
            InitializeComponent();
        }

        public void HandleNewInvoiceClick(object sender, RoutedEventArgs e)
        {
            var invoiceWindow = new AddInvoiceWindow();
            invoiceWindow.DataContext = DataContext;
            invoiceWindow.ShowDialog();
        }
    }
}
