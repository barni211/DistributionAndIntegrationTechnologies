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
            NewOrder editOrderForm = new NewOrder();
            editOrderForm.ShowDialog();
            Order createdOrder = editOrderForm.ReturnCreatedOrder();
            if (createdOrder != null)
            {
                GvOperations.AddOrderToGv(createdOrder, gvOrders);
            }
        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            //TODO: Edit existing order in order form 
            Order selectedOrder = GvOperations.GetSelectedOrder(gvOrders);

            if (selectedOrder != null)
            {
                EditOrder editOrderForm = new EditOrder(selectedOrder);
                editOrderForm.ShowDialog();
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Order orderToSend = GvOperations.GetSelectedOrder(gvOrders);
            //TODO: Send order to bill printer
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Order orderToSend = GvOperations.GetSelectedOrder(gvOrders);

            //Solution when we are going to send dishes independently
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
            GvOperations.UpdateOrder(orderToSend, OrderStatus.Sended, gvOrders);

        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            GvOperations.DeleteOrder(gvOrders);
        }


        private void btnDeliver_Click(object sender, EventArgs e)
        {
            Order orderToDeliver = GvOperations.GetSelectedOrder(gvOrders);
            if (orderToDeliver.Status == OrderStatus.ReadyToPick)
            {
                GvOperations.UpdateOrder(orderToDeliver, OrderStatus.Delivered, gvOrders);
            }
            else
            {
                MessageBox.Show("Order is not ready.");
            }
        }


        //this method is also in GvOperations, but there is different color strategy
        private void ColorGridviewRows()
        {
            if (gvOrders.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gvOrders.Rows)
                {
                    OrderStatus status = (OrderStatus)row.Cells[2].Value;
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

        private void gvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ColorGridviewRows();
        }

        private void gvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SendOrderToKitchen()
        {
            //TODO: Send dish to kitchen
        }

        private void SendOrderToBar()
        {
            //TODO: Send dish to bar
        }
    }
}
