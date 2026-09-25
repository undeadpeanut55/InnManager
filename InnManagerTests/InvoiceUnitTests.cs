using InnManager;
using InnManager.Billing;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class InvoiceUnitTests
    {
        [Fact]
        public void InvoiceDefaultValuesTest()
        {
            Invoice i = new Invoice();

            Assert.Empty(i.GuestName);
            Assert.Empty(i.RoomNumber);
            Assert.Empty(i.BillingRecords);
            Assert.Equal(0,i.TotalCharges);
            Assert.Equal(0,i.TotalPayments);
            Assert.Equal(0,i.BalanceDue);
            Assert.Equal("Paid", i.Status);
        }

        [Theory]
        [InlineData(500,0,500,"Unpaid")]
        [InlineData(500,100,400, "Unpaid")]
        [InlineData(500,250,250, "Unpaid")]
        [InlineData(500,499,1, "Unpaid")]
        [InlineData(500,500,0,"Paid")]
        [InlineData(500,550,-50, "Paid")]
        [InlineData(1000,250,750, "Unpaid")]
        [InlineData(1000,1200,-200, "Paid")]
        public void BalanceDueAndStatusAreCorrect(decimal chargeAmount, decimal paymentAmount, decimal expectedBalanceDue, string expectedStatus)
        {
            Invoice i = new Invoice();
            Charge c = new Charge();
            Payment p = new Payment();

            c.Amount = chargeAmount;
            p.Amount = paymentAmount;

            c.IsProcessed = true;
            p.IsProcessed = true;

            i.BillingRecords.Add(c);
            i.BillingRecords.Add(p);

            Assert.Equal(expectedBalanceDue, i.BalanceDue);
            Assert.Equal(expectedStatus, i.Status);
        }
    }
}
