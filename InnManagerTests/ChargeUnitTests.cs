using InnManager.Billing;
using InnManager.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class ChargeUnitTests
    {

        [Fact]
        public void ChargeDefaultValuesTest()
        {
            Charge c = new Charge();

            Assert.Equal(decimal.Zero, c.Amount);
            Assert.Equal(DateTime.Now.Date, c.Date.Date);
            Assert.Empty(c.Description);
            Assert.False(c.IsProcessed);
            Assert.Equal(ChargeCategory.Miscellaneous, c.Category);
            Assert.Equal(decimal.Zero, c.SignedAmount);
        }

        [Theory]
        [InlineData(0.00,0.00)]
        [InlineData(25.00, 25.00)]
        [InlineData(50.00, 50.00)]
        [InlineData(100.00, 100.00)]
        [InlineData(250.00, 250.00)]
        [InlineData(600.00, 600.00)]
        [InlineData(1250.00, 1250.00)]
        [InlineData(5000.00, 5000.00)]
        public void SignedAmountIsPositive(decimal actualAmount, decimal expectedSignedAmount)
        {
            Charge c = new Charge();
            c.Amount = actualAmount;

            Assert.Equal(expectedSignedAmount, c.SignedAmount);
        }

        [Fact]
        public void ChargeInheritsFromBillingRecord()
        {
            Charge c = new Charge();

            Assert.IsAssignableFrom<BillingRecord>(c);
            Assert.IsAssignableFrom<IBillingRecord>(c);
        }
    }
}