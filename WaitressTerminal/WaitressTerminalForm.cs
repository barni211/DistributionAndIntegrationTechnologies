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
        private bool _isFirstTimeLoading = true;
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
            Order orderToSend = GetSelectedOrder();
            //TODO: Send order to bill printer
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Order orderToSend = GetSelectedOrder();
            //foreach (Dish dish in orderToSend.Dishes)
            //{
            //    if (dish.Status != OrderStatus.NotSend)
            //    {
            //        continue;
            //    }

            //    if (dish.Type == OrderDestination.Bar)
            //    {
            //        SendDishToBar();
            //    }
            //    else if (dish.Type == OrderDestination.Kitchen)
            //    {
            //        SendDishToKitchen();
            //    }
            //    UpdateOrder(orderToSend, OrderStatus.Sended);
            //}
            if (orderToSend.Destination == OrderDestination.Bar)
            {
                SendOrderToBar();
            }
            else if (orderToSend.Destination == OrderDestination.Kitchen)
            {
                SendOrderToKitchen();
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
            if (orderToDeliver.Status == OrderStatus.ReadyToPick)
            {
                UpdateOrder(orderToDeliver, OrderStatus.Delivered);
            }
            else
            {
                MessageBox.Show("Order is not ready.");
            }
        }

        private void ColorGridviewRows()
        {
            if (gvOrders.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gvOrders.Rows)
                {
                    OrderStatus status = (OrderStatus)row.Cells[3].Value;
                    if (status == OrderStatus.ReadyToPick)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (status == OrderStatus.NotSend)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (status == OrderStatus.Sended || status == OrderStatus.Preparation)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (status == OrderStatus.Done)
                    {
                        row.DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
            }

        }


        private void SendOrderToKitchen()
        {
            //TODO: Send dish to kitchen
        }

        private void SendOrderToBar()
        {
            //TODO: Send dish to bar
        }

        private void gvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ColorGridviewRows();
        }

        private void gvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
