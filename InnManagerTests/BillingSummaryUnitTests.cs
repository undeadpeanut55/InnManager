using InnManager;
using InnManager.Billing;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class BillingSummaryUnitTests
    {
        [Fact]
        public void BillingSummaryDefaultValuesTest()
        {
            BillingSummary bs = new BillingSummary(new List<BillingRecord>());

            Assert.Equal(0, bs.TotalCharges);
            Assert.Equal(0, bs.TotalPayments);
            Assert.Equal(0, bs.NetBalance);
        }


        [Theory]
        [InlineData(false, false, false, false,0,0,0)]
        [InlineData(true, true, true, true,300,300,0)]
        [InlineData(false, false, true, true,0,300,-300)]
        [InlineData(true, true, false, false,300,0,300)]
        [InlineData(false, true, false, true,200,200,0)]
        [InlineData(true, false, true, false,100,100,0)]
        [InlineData(false, true, true, false,200,100,100)]
        [InlineData(true, false, false, true,100,200,-100)]
        public void IsProcessedNeededForTotalsAndBalance(bool c1IsProcessed, bool c2IsProcessed, bool p1IsProcessed, bool p2IsProcessed, decimal expectedTotalCharges, decimal expectedTotalPayments, decimal expectedNetBalance)
        {

            Charge c1 = new Charge();
            c1.IsProcessed = c1IsProcessed;
            c1.Amount = 100;

            Charge c2 = new Charge();
            c2.IsProcessed = c2IsProcessed;
            c2.Amount = 200;


            Payment p1 = new Payment();
            p1.IsProcessed = p1IsProcessed;
            p1.Amount = 100;

            Payment p2 = new Payment();
            p2.IsProcessed = p2IsProcessed;
            p2.Amount = 200;

            BillingSummary bs = new BillingSummary(new List<BillingRecord> { c1, c2, p1, p2 });


            Assert.Equal(expectedTotalCharges, bs.TotalCharges);
            Assert.Equal(expectedTotalPayments, bs.TotalPayments);
            Assert.Equal(expectedNetBalance, bs.NetBalance);
        }


    }
}
