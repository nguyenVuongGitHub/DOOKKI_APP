using DOOKKI_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Helpers
{
    internal class DashboardHelper
    {
        public class RenvenueByDate
        {
            public string Date { get; set; }
            public decimal TotalAmount { get; set; }

            public RenvenueByDate() { }
        }
        public class TopProduct
        {
            public string Name { get; set; }
            public string NumberOfUse { get; set; }
            public TopProduct() { }

        }
        public class DashboardController
        {
            //Fields & properties
            private readonly DookkiContext _context;
            private DateOnly startDate;
            private DateOnly endDate;
            private int numberDays;

            public int numberCustomer { get; private set; }
            public int numberEmployee { get; private set; }
            public List<TopProduct> TopProductList { get; private set; }

            public List<RenvenueByDate> GrossRevenueList { get; private set; }
            public int numberOrder;
            public decimal totalRevenue;

            //Constructor
            public DashboardController(DookkiContext context)
            {
                _context = context;
            }

            //Private Function
            private void GetNumberItems()
            {
                numberCustomer = _context.Customers.Count();
                numberEmployee = _context.Employees.Count();
                numberOrder = _context.Orders
                              .Where(o => o.OrderDetails.Any(t => t.Payment.Day >= startDate && t.Payment.Day <= endDate))
                              .Count();
            }

            private void GetOrderAnalisys()
            {
                GrossRevenueList = new List<RenvenueByDate>();
                totalRevenue = 0;

                if (numberDays <= 31)
                {
                    // Group by day
                    GrossRevenueList = _context.Orders
                        .Where(o => o.OrderDetails != null && o.OrderDetails.Any(t => t.Payment != null && t.Payment.Day >= startDate && t.Payment.Day <= endDate))
                        .SelectMany(o => o.OrderDetails) // Flatten OrderDetails
                        .Include(d=>d.Payment)
                        .Where(od => od.Payment != null && od.Payment.Day >= startDate && od.Payment.Day <= endDate) // Filter OrderDetails again
                        .AsEnumerable()
                        .GroupBy(od => od.Payment.Day) // Group by Payment day
                        .Select(g => new RenvenueByDate
                        {
                            Date = g.Key.ToString("dd-MM"), // Format the day as a string
                            TotalAmount = g.Sum(od => od.Payment != null ? od.Payment.Amount : 0) // Sum the payment amounts for that day
                        })
                        .ToList();
                }
                else if (numberDays <= 92)
                {
                    // Group by week
                    GrossRevenueList = _context.Orders
                    .Where(o => o.OrderDetails.Any(t => t.Payment.Day >= startDate && t.Payment.Day <= endDate))
                    .SelectMany(o => o.OrderDetails) // Flatten OrderDetails
                    .Include(d => d.Payment)
                    .Where(od => od.Payment.Day >= startDate && od.Payment.Day <= endDate) // Filter OrderDetails again
                    .AsEnumerable()
                    .GroupBy(od => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(od.Payment.Day.ToDateTime(TimeOnly.MinValue), CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                    .Select(g => new RenvenueByDate
                    {
                        Date = "Week: " + g.Key.ToString(), // Format the day as a string
                        TotalAmount = g.Sum(od => od.Payment.Amount) // Sum the payment amounts for that day
                    })
                    .ToList();
                }
                else if (numberDays <= (365) * 2)
                {
                    // Group by month-year
                    GrossRevenueList = _context.Orders
                    .Where(o => o.OrderDetails.Any(t => t.Payment.Day >= startDate && t.Payment.Day <= endDate))
                    .SelectMany(o => o.OrderDetails) // Flatten OrderDetails
                    .Include(d => d.Payment)
                    .Where(od => od.Payment.Day >= startDate && od.Payment.Day <= endDate) // Filter OrderDetails again
                    .AsEnumerable()
                    .GroupBy(od => od.Payment.Day.ToString("MM-yyyy")) // Group by Payment month
                    .Select(g => new RenvenueByDate
                    {
                        Date = g.Key,
                        TotalAmount = g.Sum(od => od.Payment.Amount) // Sum the payment amounts for that day
                    })
                    .ToList();
                }
                else
                {
                    // Group by year
                    GrossRevenueList = _context.Orders
                        .Where(o => o.OrderDetails != null && o.OrderDetails.Any(t => t.Payment != null && t.Payment.Day >= startDate && t.Payment.Day <= endDate))
                        .SelectMany(o => o.OrderDetails) // Flatten OrderDetails
                        .Include(d => d.Payment)
                        .Where(od => od.Payment != null && od.Payment.Day >= startDate && od.Payment.Day <= endDate) // Filter OrderDetails again
                        .AsEnumerable()
                        .GroupBy(od => od.Payment.Day.Year) // Group by Payment year
                        .Select(g => new RenvenueByDate
                        {
                            Date = g.Key.ToString(),
                            TotalAmount = g.Sum(od => od.Payment != null ? od.Payment.Amount : 0) // Sum the payment amounts safely
                        })
                        .ToList();
                }

                // Calculate the total revenue
                totalRevenue = GrossRevenueList.Sum(kvp => kvp.TotalAmount);
            }

            private void GetProductAnalisys()
            {
                TopProductList = _context.OrderDetails
                    .Include(a => a.Ticket)
                    .GroupBy(b => b.Ticket.Name) // Group by TicketID and TicketName
                    .Select(c => new TopProduct
                    {
                        Name = c.Key, // Access the key of the group
                        NumberOfUse = c.Count().ToString() // Count the items in the group
                    }).ToList();
            }

            //Public methods
            public bool LoadData(DateTime start, DateTime end)
            {
                GetProductAnalisys();
                endDate = new DateOnly(end.Year, end.Month, end.Day);
                if (DateOnly.FromDateTime(start) != startDate || DateOnly.FromDateTime(end) != endDate)
                {
                    startDate = DateOnly.FromDateTime(start);
                    endDate = DateOnly.FromDateTime(end);
                    numberDays = (end - start).Days;

                    GetNumberItems();
                    GetOrderAnalisys();
                    Console.WriteLine("Data refreshed");
                    return true;
                }
                else
                {
                    Console.WriteLine("Data not refreshed");
                    return false;
                }
            }
        }
    }
}
