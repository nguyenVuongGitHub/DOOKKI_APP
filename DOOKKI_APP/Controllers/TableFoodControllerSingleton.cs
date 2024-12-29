using DOOKKI_APP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Controllers
{
    internal class TableFoodControllerSingleton
    {
        private static TableFoodControllerSingleton instance;
        public static TableFoodControllerSingleton Instance
        {
            get { if (instance == null) instance = new TableFoodControllerSingleton(); return instance; }
            private set { instance = value; }
        }

        private TableFoodControllerSingleton() { }

        public List<Table> GetTableList()
        {
            using (var context = new DookkiContext())
            {
                return context.Tables.ToList();
            }
        }

        public void SwitchTable(int id1, int id2)
        {
            using (var context = new DookkiContext())
            {
                // 1. Kiểm tra bàn mới (id2) có trạng thái "Có người" hay không
                var targetTable = context.Tables.FirstOrDefault(t => t.Id == id2);
                if (targetTable == null || targetTable.Status == true)
                {
                    MessageBox.Show("Bàn được chọn đã có người. Vui lòng chọn bàn khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Lấy danh sách các Order chưa thanh toán của bàn cũ (id1)
                var ordersToSwitch = context.Orders
                    .Where(o => o.TableId == id1 && o.Status == 0)
                    .ToList();

                if (ordersToSwitch.Count == 0)
                {
                    MessageBox.Show("Bàn hiện tại không có Order nào để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Cập nhật TableID cho các Order chuyển sang bàn mới
                foreach (var order in ordersToSwitch)
                {
                    order.TableId = id2;
                }

                // 4. Lưu các thay đổi vào database
                context.SaveChanges();

                // 5. Cập nhật trạng thái bàn
                // Bàn mới -> Có người
                targetTable.Status = true;

                // Kiểm tra lại bàn cũ (id1), nếu không còn Order nào thì chuyển về "Trống"
                var tableOld = context.Tables.FirstOrDefault(t => t.Id == id1);
                bool hasOrders = context.Orders.Any(o => o.TableId == id1 && o.Status == 0);
                if (!hasOrders && tableOld != null)
                {
                    tableOld.Status = false;
                }

                // Lưu thay đổi trạng thái bàn
                context.SaveChanges();
            }
        }
    }
}
