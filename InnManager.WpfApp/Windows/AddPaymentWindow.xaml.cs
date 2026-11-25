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
    /// Interaction logic for AddPaymentWindow.xaml
    /// </summary>
    public partial class AddPaymentWindow : Window
    {
        public AddPaymentWindow()
        {
            InitializeComponent();
        }

        public void HandleAddPaymentClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Hotel hotel
                && InvoiceInput.SelectedItem is InnManager.Billing.Invoice invoice
                && PaymentMethodInput.SelectedItem is InnManager.Enums.PaymentMethod paymentMethod)
            {

                if (decimal.TryParse(AmountInput.Text, out decimal amount))
                {

                    var payment = new InnManager.Billing.Payment
                    {
                        Amount = amount,
                        Date = PaymentDateInput.SelectedDate ?? DateTime.Now,
                        PaymentMethod = paymentMethod,
                        IsProcessed = true
                    };


                    payment.ReferenceNumber = "PAY" + invoice.InvoiceNumber.Substring(3, 8);
                    switch (paymentMethod)
                    {
                        case InnManager.Enums.PaymentMethod.CreditCard: payment.ReferenceNumber += "CC"; break;
                        case InnManager.Enums.PaymentMethod.Cash: payment.ReferenceNumber += "CASH"; break;
                        case InnManager.Enums.PaymentMethod.BankTransfer: payment.ReferenceNumber += "BANK"; break;
                        case InnManager.Enums.PaymentMethod.DebitCard: payment.ReferenceNumber += "DC"; break;
                        case InnManager.Enums.PaymentMethod.DigitalWallet: payment.ReferenceNumber += "DIGI"; break;
                        default: break;
                    }
                    invoice.BillingRecords.Add(payment);
                    hotel.Payments.Add(payment);
                }


                Close();
            }
        }

    }
}
