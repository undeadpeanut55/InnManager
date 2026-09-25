using InnManager;
using InnManager.Billing;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class PaymentUnitTests
    {
        [Fact]
        public void PaymentDefaultValuesTest()
        {
            Payment p = new Payment();

            Assert.Equal(decimal.Zero, p.Amount);
            Assert.Equal(DateTime.Now.Date, p.Date.Date);
            Assert.Empty(p.Description);
            Assert.False(p.IsProcessed);
            Assert.Equal(PaymentMethod.Cash, p.PaymentMethod);
            Assert.Equal(decimal.Zero, p.SignedAmount);

        }

        [Theory]
        [InlineData(0.00, 0.00)]
        [InlineData(25.00,-25.00)]
        [InlineData(50.00,-50.00)]
        [InlineData(100.00,-100.00)]
        [InlineData(250.00,-250.00)]
        [InlineData(500.00,-500.00)]
        [InlineData(1250.00,-1250.00)]
        [InlineData(5000.00,-5000.00)]
        public void SignedAmountIsNegative(decimal actualAmount, decimal expectedSignedAmount)
        {
            Payment p = new Payment();
            p.Amount = actualAmount;

            Assert.Equal(expectedSignedAmount, p.SignedAmount);

        }

        [Fact]
        public void PaymentInheritsFromBillingRecord()
        {
            Payment p = new Payment();
            

            Assert.IsAssignableFrom<BillingRecord>(p);
            Assert.IsAssignableFrom<IBillingRecord>(p);
        }

    }
}
