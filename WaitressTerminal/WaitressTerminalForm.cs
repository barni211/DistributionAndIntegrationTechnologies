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

namespace WaitressTerminal
{
    public partial class WaitressTerminalForm : Form
    {
        private ConnectionHandler _connection;
        public WaitressTerminalForm()
        {
            InitializeComponent();
            _connection = new ConnectionHandler();
            _connection.CreateConnection();
        }

        private void WaitressTerminalForm_Load(object sender, EventArgs e)
        {
            _connection.InvokeFunc1();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            //TODO: Create new order and open edit order form (in parameter Pass type of order kitchen/bar)
            NewOrder editOrderForm = new NewOrder();
            editOrderForm.ShowDialog();
            Order createdOrder = editOrderForm.ReturnCreatedOrder();
            if (createdOrder != null)
            {
                AddOrderToGv(createdOrder);
            }
        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            //TODO: Edit existing order in order form 
            Order selectedOrder = GetSelectedOrder();

            if (selectedOrder != null)
            {
                EditOrder editOrderForm = new EditOrder(selectedOrder);
                editOrderForm.ShowDialog();
            }
        }

        private void AddOrderToGv(Order newOrder)
        {
            List<Order> ordersFromGv = gvOrders.DataSource as List<Order>;
            if (ordersFromGv != null)
            {
                ordersFromGv.Add(newOrder);
            }
            else
            {
                ordersFromGv = new List<Order>();
                ordersFromGv.Add(newOrder);
            }

            //hack to refresh datagridview, looking for better solution
            gvOrders.DataSource = null;
            gvOrders.DataSource = ordersFromGv;
        }

        private void UpdateOrder(Order order, OrderStatus status)
        {
            int selectedrowindex = gvOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvOrders.Rows[selectedrowindex];

            List<Order> ordersFromGv = gvOrders.DataSource as List<Order>;
            if (ordersFromGv != null)
            {
                ordersFromGv.ElementAt(selectedrowindex).Status = status;
            }

            gvOrders.DataSource = null;
            gvOrders.DataSource = ordersFromGv;
        }

        private Order GetSelectedOrder()
        {
            int selectedrowindex = gvOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvOrders.Rows[selectedrowindex];
            return (Order)selectedRow.DataBoundItem;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: Send order to bill printer
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Order orderToSend = GetSelectedOrder();
            foreach (IDishes dish in orderToSend.Dishes)
            {
                if (dish.Status != OrderStatus.NotSend)
                {
                    continue;
                }

                if (dish.Type == OrderDestination.Bar)
                {
                    SendDishToBar();
                }
                else if (dish.Type == OrderDestination.Kitchen)
                {
                    SendDishToKitchen();
                }
                UpdateOrder(orderToSend, OrderStatus.Sended);
            }

        }

        private void DeleteOrder()
        {
            int selectedrowindex = gvOrders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvOrders.Rows[selectedrowindex];

            List<Order> ordersFromGv = gvOrders.DataSource as List<Order>;
            if (ordersFromGv != null && ordersFromGv.ElementAt(selectedrowindex).Status == OrderStatus.NotSend)
            {
                ordersFromGv.RemoveAt(selectedrowindex);
                gvOrders.DataSource = null;
                gvOrders.DataSource = ordersFromGv;
            }
            else
            {
                MessageBox.Show("Delete sended order is not allowed");
            }

        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }


        private void btnDeliver_Click(object sender, EventArgs e)
        {
            Order orderToDeliver = GetSelectedOrder();
            if(orderToDeliver.Status == OrderStatus.ReadyToPick)
            {
                UpdateOrder(orderToDeliver, OrderStatus.Delivered);
            }
            else
            {
                MessageBox.Show("Order is not ready.");
            }
        }


        private void SendDishToKitchen()
        {
            //TODO: Send dish to kitchen
        }

        private void SendDishToBar()
        {
            //TODO: Send dish to bar
        }
    }
}
