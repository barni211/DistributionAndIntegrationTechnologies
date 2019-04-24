using CommonOperations;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaitressTerminal;

namespace Restaurant
{
    public partial class PaymentTerminal : Form
    {
        private List<Order> _orderList;
        public PaymentTerminal()
        {
            InitializeComponent();
            SetUpTestData();
        }

        private void SetUpTestData()
        {
            List<Dish> dishList = new List<Dish>();
            dishList.Add(new Dish() { Id = 1, Name = "Dish1", Status = OrderStatus.Sended, Type = OrderDestination.Bar });
            dishList.Add(new Dish() { Id = 2, Name = "Dish2", Status = OrderStatus.Sended, Type = OrderDestination.Bar });
            dishList.Add(new Dish() { Id = 3, Name = "Dish3", Status = OrderStatus.Sended, Type = OrderDestination.Bar });

            _orderList = new List<Order>();
            _orderList.Add(new Order() { Id = "1", Destination = OrderDestination.Bar, Status = OrderStatus.Sended, TableNumber = 1, Dishes = dishList });
            _orderList.Add(new Order() { Id = "2", Destination = OrderDestination.Bar, Status = OrderStatus.Sended, TableNumber = 1, Dishes = dishList });
            _orderList.Add(new Order() { Id = "3", Destination = OrderDestination.Bar, Status = OrderStatus.Sended, TableNumber = 1, Dishes = dishList });
            gvOrders.DataSource = _orderList;
        }

        private void gvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GvOperations.ColorGridviewRows(gvOrders);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: Send order to printer
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            Order currentOrder = GvOperations.GetSelectedOrder(gvOrders);
            ChangeStatus changeStatusForm = new ChangeStatus(currentOrder.Status);
            changeStatusForm.ShowDialog();
            OrderStatus newStatus = changeStatusForm.GetOrderStatus();
            GvOperations.UpdateOrder(currentOrder, newStatus, gvOrders);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GvOperations.DeleteOrder(gvOrders, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Order selectedOrder = GvOperations.GetSelectedOrder(gvOrders);

            if (selectedOrder != null)
            {
                EditOrder editOrderForm = new EditOrder(selectedOrder);
                editOrderForm.ShowDialog();
            }
        }
    }
}
