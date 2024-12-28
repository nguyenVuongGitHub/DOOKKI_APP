using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOKKI_APP.Models.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DOOKKI_APP.Controllers
{
    internal class CustomerController : AbstractController<Customer>
    {
        public CustomerController(DookkiContext context) 
        {
            _context = context;
        }
        public override void Add(Customer element)
        {
            _context.Customers.Add(element);
        }

        public override Microsoft.EntityFrameworkCore.DbSet<Customer> GetModel()
        {
            return _context.Customers;
        }

        public override void Remove(Customer element)
        {
            _context.Customers.Remove(element);
        }

        public override void SaveChanges()
        {
            _context.SaveChanges();
        }

        public override void Update(Customer element)
        {
            _context.Customers.Update(element);
        }

        /// <summary>
        /// U need to call this funcion after you have customerID and totalBill
        /// to update customer's mark
        /// </summary>

        /* code example
         * 
            // Add the order
            _context.Orders.Add(order);
            _context.SaveChangesAsync();

            // Add the order details
            foreach (var detail in orderDetails)
            {
                detail.OrderID = order.OrderID; // Associate the details with the order
                _context.OrderDetails.Add(detail);
            }

            _context.SaveChangesAsync();

            // Calculate total amount based on order details
            decimal totalAmount = orderDetails.Sum(d => d.Quantity * d.Ticket.Price); // Assuming you have a Price property in Ticket

            // Update customer marks using the stored procedure
            await UpdateCustomerMarksAsync(order.CustomerID, totalAmount);
         */
        public async Task UpdateCustomerMark(int customerId, decimal totalAmount)
        {
            // Create the parameters for the stored procedure
            var parameters = new[]
            {
            new SqlParameter("@CustomerID", customerId),
            new SqlParameter("@TotalAmount", totalAmount)
        };

            // Execute the stored procedure
            await _context.Database.ExecuteSqlRawAsync("EXEC sp_UpdateCustomerMarks @CustomerID, @TotalAmount", parameters);
        }
    }
}
