using DOOKKI_APP.Models;
using DOOKKI_APP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Controllers
{
    internal class OrderControllerSingleton
    {
        private static OrderControllerSingleton instance;

        public static OrderControllerSingleton Instance
        {
            get { if (instance == null) instance = new OrderControllerSingleton(); return instance; }
            set { instance = value; }
        }

        private OrderControllerSingleton() { }

        public List<Menu> GetMenuItem(int id)
        {
            using (var context = new DookkiContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.TableId == id && o.Status == 0);
                if (order == null)
                {
                    return new List<Menu>();
                }
                var orderDetails = context.OrderDetails.Where(od => od.OrderId == order.Id && od.IsActive == true).ToList();
                var menuItems = orderDetails.Select(od => new Menu
                {
                    Name = context.Tickets.FirstOrDefault(t => t.Id == od.TicketId).Name,
                    Quantity = od.Quantily,
                    Price = context.Tickets.FirstOrDefault(t => t.Id == od.TicketId).Price
                }).ToList();

                return menuItems;
            }
        }


        public int GetUncheckOrderByTableID(int id)
        {
            using (var context = new DookkiContext())
            {
                var uncheckOrder = context.Orders.FirstOrDefault(o => o.TableId == id && o.Status == 0);
                if (uncheckOrder != null)
                {
                    return uncheckOrder.Id;
                }
                return -1;
            }
        }

        public void InsertOrder(int tableID)
        {
            using (var context = new DookkiContext())
            {
                var order = new Order
                {
                    TableId = tableID,
                    Time = TimeOnly.FromDateTime(DateTime.Now),
                    Status = 0
                };
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void InsertOrderDetail(int orderID, int ticketID, int quantity)
        {
            using (var context = new DookkiContext())
            {
                var existOrderDetail = context.OrderDetails.FirstOrDefault(od => od.OrderId == orderID && od.TicketId == ticketID);

                //Neu order da ton tai
                if (existOrderDetail != null)
                {
                    if(existOrderDetail.IsActive == false)
                    {
                        existOrderDetail.IsActive = true;
                        existOrderDetail.Quantily = quantity;
                    }
                    else
                    {
                        decimal newQuantity = existOrderDetail.Quantily + quantity;
                        if (newQuantity > 0)
                        {
                            existOrderDetail.Quantily = newQuantity;
                        }
                        else
                        {
                            context.OrderDetails.Remove(existOrderDetail);
                        }
                    }
                    context.SaveChanges();

                }
                // Neu order chua ton tai
                else
                {
                    var orderDetail = new OrderDetail
                    {
                        OrderId = orderID,
                        TicketId = ticketID,
                        Quantily = quantity
                    };
                    context.OrderDetails.Add(orderDetail);
                }

                // Cập nhật trạng thái Table
                var order = context.Orders.FirstOrDefault(o => o.Id == orderID && o.Status == 0);
                if (order != null)
                {
                    var table = context.Tables.FirstOrDefault(t => t.Id == order.TableId);
                    if (table != null)
                    {
                        table.Status = true;
                    }
                }
                context.SaveChanges();
            }
        }

        public int GetMaxOrderID()
        {
            try
            {
                using (var context = new DookkiContext())
                {
                    return context.Orders.Max(o => o.Id);
                }
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int id, int tableID, decimal totalPrice, int customerID)
        {
            using (var context = new DookkiContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.Id == id);
                var table = context.Tables.FirstOrDefault(t => t.Id == tableID);
                bool hasOrders = context.Orders.Any(o => o.TableId == tableID && o.Status == 0);

                if (order != null)
                {
                    if(table != null && hasOrders)
                    {
                        order.Status = 1;
                        order.Total = totalPrice;
                        order.CustomerId = customerID;
                        table.Status = false;
                        context.SaveChanges();
                    }
                    
                }
            }
        }

        public int GetCurrentOrderId(int tableID)
        {
            using (var context = new DookkiContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.TableId == tableID && o.Status == 0);
                return order?.Id ?? 0;
            }
        }


        public void DeleteOrderDetail(int orderID, int ticketID)
        {
            using (var context = new DookkiContext())
            {
                var orderDetail = context.OrderDetails.FirstOrDefault(od => od.OrderId == orderID && od.TicketId == ticketID);
                if (orderDetail != null)
                {
                    //context.OrderDetails.Remove(orderDetail);
                    orderDetail.IsActive = false;
                    context.SaveChanges();

                    // Kiểm tra xem Order còn món nào không
                    bool hasOrderDetails = context.OrderDetails.Any(od => od.OrderId == orderID && od.IsActive == true);

                    if (!hasOrderDetails)
                    {
                        // Nếu Order không còn món nào, cập nhật trạng thái bàn về "Trống"
                        var order = context.Orders.FirstOrDefault(o => o.Id == orderID);
                        if (order != null)
                        {
                            var table = context.Tables.FirstOrDefault(t => t.Id == order.TableId);
                            if (table != null)
                            {
                                table.Status = false; // Đặt trạng thái bàn về "Trống"
                                context.SaveChanges();
                            }
                        }
                    }
                }
            }
        }
        
        public List<OrderDetail> GetOrderDetails(int idTable)
        {
            using (var context = new DookkiContext())
            {
                var menuItems = GetMenuItem(idTable);
                decimal totalPrice = 0;
                List<OrderDetail> orderDetails = new List<OrderDetail>();
                
                foreach (var item in menuItems)
                {
                    OrderDetail orderDetail = new OrderDetail();

                    orderDetail.Quantily = item.Quantity;
                    int ticketID = (from ti in context.Tickets
                                    where ti.Name == item.Name
                                    select ti.Id).SingleOrDefault();
                    orderDetail.TicketId = ticketID;

                    orderDetails.Add(orderDetail);
                }
                return orderDetails;
            }
        }
    }
}
