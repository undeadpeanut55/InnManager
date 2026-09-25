using InnManager;
using InnManager.Billing;
using InnManager.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace InnManagerTests
{
    public class SpecificRequiredTests
    {
        [Fact]
        public void ProcessedRoomChargeTest()
        {
            Charge c = new Charge { Amount = 600.00m , Category = ChargeCategory.Room , IsProcessed = true };

            Assert.Equal(600.00m, c.Amount);
            Assert.Equal(600.00m, c.SignedAmount);
            Assert.Equal(ChargeCategory.Room, c.Category);
            Assert.True(c.IsProcessed);

            Assert.IsAssignableFrom<BillingRecord>(c);
            Assert.IsAssignableFrom<IBillingRecord>(c);


        }

        [Fact]
        public void ProcessedCreditCardPaymentTest()
        {
            Payment p = new Payment { Amount = 500.00m, PaymentMethod = PaymentMethod.CreditCard, IsProcessed = true };

            Assert.Equal(500.00m, p.Amount);
            Assert.Equal(-500.00m, p.SignedAmount);
            Assert.Equal(PaymentMethod.CreditCard, p.PaymentMethod);
            Assert.True(p.IsProcessed);

            Assert.IsAssignableFrom<BillingRecord>(p);
            Assert.IsAssignableFrom<IBillingRecord>(p);
        }

        [Fact]
        public void PartiallyPaidInvoiceTest()
        {
            Invoice i = new Invoice();
            i.BillingRecords.Add(new Charge() { Amount = 600.00m, Category = ChargeCategory.Room, IsProcessed = true });
            i.BillingRecords.Add(new Charge() { Amount = 40.00m, Category = ChargeCategory.Laundry, IsProcessed = true });
            i.BillingRecords.Add(new Payment() { Amount = 250.00m, PaymentMethod = PaymentMethod.CreditCard, IsProcessed = true });

            Assert.Equal(640.00m, i.TotalCharges);
            Assert.Equal(250.00m, i.TotalPayments);
            Assert.Equal(390.00m, i.BalanceDue);
            Assert.Equal("Unpaid", i.Status);
        }

        [Fact]
        public void FullyPaidInvoiceTest()
        {
            Invoice i = new Invoice();
            i.BillingRecords.Add(new Charge() { Amount = 600.00m, Category = ChargeCategory.Room, IsProcessed = true });
            i.BillingRecords.Add(new Charge() { Amount = 40.00m, Category = ChargeCategory.Laundry, IsProcessed = true });
            i.BillingRecords.Add(new Payment() { Amount = 640.00m, IsProcessed = true });

            Assert.Equal(640.00m, i.TotalCharges);
            Assert.Equal(640.00m, i.TotalPayments);
            Assert.Equal(0.00m, i.BalanceDue);
            Assert.Equal("Paid", i.Status);
        }

        [Fact]
        public void IgnoreUnprocessedBillingRecordsTest()
        {
            Invoice i = new Invoice();
            i.BillingRecords.Add(new Charge() { Amount = 700.00m, Category = ChargeCategory.Room, IsProcessed = true });
            i.BillingRecords.Add(new Charge() { Amount = 1500.00m, Category = ChargeCategory.Spa, IsProcessed = false });
            i.BillingRecords.Add(new Payment() { Amount = 200.00m, IsProcessed = true });
            i.BillingRecords.Add(new Payment() { Amount = 300.00m, IsProcessed = false });

            Assert.Equal(700.00m, i.TotalCharges);
            Assert.Equal(200.00m, i.TotalPayments);
            Assert.Equal(500.00m, i.BalanceDue);
            Assert.Equal("Unpaid", i.Status);

        }

        [Fact]
        public void BillingSummaryWithMixedRecordsTest()
        {

            Charge c1 = new() { Amount = 1200.00m, Category=ChargeCategory.Room, IsProcessed = true };
            Charge c2 = new() { Amount = 300.00m, Category=ChargeCategory.Dining, IsProcessed = true };
            Charge c3 = new() { Amount = 100.00m, Category=ChargeCategory.Laundry, IsProcessed = true };
            Charge c4 = new() { Amount = 400.00m, Category=ChargeCategory.Spa, IsProcessed = false};

            Payment p1 = new() { Amount = 800.00m, IsProcessed = true };
            Payment p2 = new() { Amount = 250.00m, IsProcessed = true };
            Payment p3 = new() { Amount = 500.00m, IsProcessed = false };

            BillingSummary bs = new BillingSummary(new List<BillingRecord>{ c1,c2,c3,c4,p1,p2,p3});

            Assert.Equal(1600.00m, bs.TotalCharges);
            Assert.Equal(1050.00m, bs.TotalPayments);
            Assert.Equal(550.00m, bs.NetBalance);
        }

        [Fact]
        public void HotelRoomStatusCountsTest()
        {
            Hotel h = new Hotel() { Name = "Grandview Hotel", Type = HotelType.Business };

            h.Rooms.Add(new Room { RoomNumber="101",Status=RoomStatus.Available});
            h.Rooms.Add(new Room { RoomNumber="102", Status = RoomStatus.Available });
            h.Rooms.Add(new Room { RoomNumber="103", Status = RoomStatus.Occupied });
            h.Rooms.Add(new Room { RoomNumber="104", Status = RoomStatus.Reserved });
            h.Rooms.Add(new Room { RoomNumber="201", Status = RoomStatus.Maintenance });
            h.Rooms.Add(new Room { RoomNumber="202", Status = RoomStatus.Occupied });
            h.Rooms.Add(new Room { RoomNumber="203", Status = RoomStatus.Maintenance });
            h.Rooms.Add(new Room { RoomNumber="204", Status = RoomStatus.Available });

            Assert.Equal(8, h.Rooms.Count);
            Assert.Equal(3, h.AvailableRoomCount);
            Assert.Equal(2, h.OccupiedRoomCount);
        }

        [Fact]
        public void HousekeepingStatusTest()
        {
            HousekeepingTask h = new HousekeepingTask() { RoomNumber = "204", Description = "Clean and prepare room", IsCompleted = false };

            Assert.Equal("Not Completed", h.Status);

            h.IsCompleted = true;

            Assert.Equal("Completed", h.Status);

        }

    }
}
